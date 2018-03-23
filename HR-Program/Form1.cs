using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Program
{
    public partial class Form1 : Form
    {
        private JsonParser jsonParser = new JsonParser();
        private Filters filters;

        private Contact template = new Contact("","",DateTime.Now,"","", "");

        public Form1()
        {
            InitializeComponent();
            filters = new Filters(jsonParser);

            try
            {
                List<string> kuk = jsonParser.getNames();

                Contacts_lstbx.SelectedIndexChanged -= Contacts_lstbx_SelectedIndexChanged;
                Contacts_lstbx.DataSource = kuk; 
                Contacts_lstbx.SelectedIndex = -1;
                Contacts_lstbx.SelectedIndexChanged += Contacts_lstbx_SelectedIndexChanged;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Experiance_cmbx.DataSource = template.Experiances;
        }

        private void AddPerson_btn_Click(object sender, EventArgs e)
        {

        }

        private void RemovePerson_btn_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePerson_btn_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Age_txtbx.Text = (DateTime.Now.Year - BirthDate_dtpk.Value.Year).ToString();
        }

        private void Contacts_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = Contacts_lstbx.SelectedValue.ToString();

            int id = int.Parse(selection.Split('.')[0]);

            Contact selected = jsonParser.GetContact(id);

            populateInformation(selected);
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            Contacts_lstbx.SelectedIndexChanged -= Contacts_lstbx_SelectedIndexChanged;

            if (Filter_opt_cmbx.SelectedItem.ToString() == "גיל")
            {
                Control min_txtbx = Filter_tlp.Controls.Find("Filter_min_txtbx", true)[0];
                Control max_txtbx = Filter_tlp.Controls.Find("Filter_max_txtbx",true)[0];

                List<string> filtered_list = filters.ByAge(min_txtbx.Text, max_txtbx.Text);

                Contacts_lstbx.DataSource = filtered_list;
            }
            else if (Filter_opt_cmbx.SelectedItem.ToString() == "שם")
            {
                Control name_txtbx = Filter_tlp.Controls.Find("Filter_name_txtbx", true)[0];

                List<string> filtered_list = filters.ByName(name_txtbx.Text);

                Contacts_lstbx.DataSource = filtered_list;
            }
            else if (Filter_opt_cmbx.SelectedItem.ToString() == "ניסיון")
            {
                ComboBox exp_cmb = (ComboBox)Filter_tlp.Controls.Find("Filter_exp_options_cmbx", true)[0];

                List<string> filtered_list = filters.ByExperiance(exp_cmb.SelectedItem.ToString());

                Contacts_lstbx.DataSource = filtered_list;
                
            }

            Contacts_lstbx.SelectedIndex = -1;
            Contacts_lstbx.SelectedIndexChanged += Contacts_lstbx_SelectedIndexChanged;
        }

        private void Filter_opt_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Filter_Values_tlp.ColumnCount; i++)
            {
                Control c = Filter_Values_tlp.GetControlFromPosition(i, 0);
                if (c != null)
                    c.Dispose();
            }
            if (Filter_opt_cmbx.SelectedItem.ToString() == "גיל")
            {
                upodateFilter_Table_Controls("age",Filter_Values_tlp);
            }
            else if (Filter_opt_cmbx.SelectedItem.ToString() == "ניסיון")
            {
                upodateFilter_Table_Controls("experiance", Filter_Values_tlp);
            }
            else if (Filter_opt_cmbx.SelectedItem.ToString() == "שם")
            {
                upodateFilter_Table_Controls("name", Filter_Values_tlp);
            }
        }

        private void upodateFilter_Table_Controls(string reason, TableLayoutPanel tlp)
        {

            if (reason == "age")
            {
                tlp.ColumnCount = 3;

                TextBox t1 = new TextBox { Name = "Filter_max_txtbx",  Width = 20, TextAlign = HorizontalAlignment.Center };
                Label lbl = new Label { Text = "-", Width = 10, TextAlign = ContentAlignment.MiddleCenter };
                TextBox t2 = new TextBox { Name = "Filter_min_txtbx", Width = 20, TextAlign = HorizontalAlignment.Center };

                tlp.Controls.Add(t1, 0, 0);
                tlp.Controls.Add(lbl, 1, 0);
                tlp.Controls.Add(t2, 2, 0);
                
            }

            else if (reason == "experiance")
            {
                tlp.ColumnCount = 1;

                ComboBox cmb1 = new ComboBox() { Name = "Filter_exp_options_cmbx", DataSource = template.Experiances };

                tlp.Controls.Add(cmb1, 0, 0);
            }
            else if (reason == "name")
            {
                tlp.ColumnCount = 1;

                TextBox t1 = new TextBox { Name = "Filter_name_txtbx"};

                tlp.Controls.Add(t1, 0, 0);
            }

        }

        private void populateInformation(Contact contact)
        {

            Name_txtbx.Text = contact.First_name + " " + contact.Last_name;
            BirthDate_dtpk.Value = contact.Birth_date;
            Tel_txtbx.Text = contact.Telephone;
            Cell_txtbx.Text = contact.Cellphone;
            Address_txtbx.Text = contact.address;
            Experiance_cmbx.SelectedItem = contact.Experiance;
            Summary_txtbx.Text = contact.Summary;

            if (contact.isAvailable)
            {
                Avaiability_cmbx.SelectedIndex = 0;
            }
            else
            {
                Avaiability_cmbx.SelectedIndex = 1;
            }

            Title_lbl.Text = Name_txtbx.Text + ", " + Age_txtbx.Text;
        }
    }
}
