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
        private MockList ml = new MockList();
        private Contact template = new Contact("","",DateTime.Now,"","", "");

        public Form1()
        {
            InitializeComponent();
            Contacts_lstbx.SelectedIndexChanged -= Contacts_lstbx_SelectedIndexChanged;
            Contacts_lstbx.DataSource = ml.getNames();
            Contacts_lstbx.SelectedIndexChanged += Contacts_lstbx_SelectedIndexChanged;

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Age_txtbx.Text = (DateTime.Now.Year - BirthDate_dtpk.Value.Year).ToString();
        }

        private void Contacts_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = Contacts_lstbx.SelectedValue.ToString();

            int id = int.Parse(selection.Split('.')[0]);
            string f_name = selection.Split('.')[1].Split(' ')[1];

            Contact person = ml.getContact(id, f_name);

            Name_txtbx.Text = person.first_name + " " + person.last_name;
            BirthDate_dtpk.Value = person.birth_date;
            Tel_txtbx.Text = person.telephone;
            Cell_txtbx.Text = person.cellphone;
            Address_txtbx.Text = person.address;
            Experiance_cmbx.SelectedItem = person.experiance;

            if (person.isAvailable)
            {
                Avaiability_cmbx.SelectedIndex = 0;
            }
            else
            {
                Avaiability_cmbx.SelectedIndex = 1;
            }

            Title_lbl.Text = Name_txtbx.Text + ", " + Age_txtbx.Text;
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            if (Filter_opt_cmbx.SelectedItem.ToString() == "גיל")
            {
                Control min_txtbx = Filter_tlp.Controls.Find("Filter_min_txtbx", true)[0];
                Control max_txtbx = Filter_tlp.Controls.Find("Filter_max_txtbx",true)[0];

                List<string> filtered_list = filterByAge(min_txtbx.Text, max_txtbx.Text);

                Contacts_lstbx.DataSource = filtered_list;
            }
            else if (Filter_opt_cmbx.SelectedItem.ToString() == "שם")
            {
                Control name_txtbx = Filter_tlp.Controls.Find("Filter_name_txtbx", true)[0];

                List<string> filtered_list = filterByName(name_txtbx.Text);

                Contacts_lstbx.DataSource = filtered_list;
            }
            else if (Filter_opt_cmbx.SelectedItem.ToString() == "ניסיון")
            {
                ComboBox exp_cmb = (ComboBox)Filter_tlp.Controls.Find("Filter_exp_options_cmbx", true)[0];

                List<string> filtered_list = filterByExperiance(exp_cmb.SelectedItem.ToString());

                Contacts_lstbx.DataSource = filtered_list;
            }
        }

        private List<string> filterByAge(string min_num, string max_num)
        {
            if (min_num == "") { min_num = "0"; }

            if (max_num == "") { max_num = "100"; }

            int min = int.Parse(min_num);
            int max = int.Parse(max_num);
            List<string> new_list = new List<string>();

            foreach (Contact person in ml.dem_list)
            {
                int age = person.getAge();
                if ( age > min && age < max)
                {
                    new_list.Add(person.ToString());
                }
            }

            return new_list;
        }

        private List<string> filterByName(string name)
        {
            List<string> new_list = new List<string>();

            foreach (Contact person in ml.dem_list)
            {
                if (person.first_name.Contains(name) || person.last_name.Contains(name))
                {
                    new_list.Add(person.ToString());
                }
            }

            return new_list;
        }

        private List<string> filterByExperiance(string exp)
        {

            List<string> new_list = new List<string>();

            foreach (Contact person in ml.dem_list)
            {
                if (person.experiance == exp)
                {
                    new_list.Add(person.ToString());
                }
            }

            return new_list;
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
    }
}
