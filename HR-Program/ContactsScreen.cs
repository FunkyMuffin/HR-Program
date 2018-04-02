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
    public partial class ContactsScreen : Form
    {
        private jsonParserAllToMemAllToMem jsonParserAllToMemAllToMem = new jsonParserAllToMemAllToMem();
        private Filters filters;

        private Contact template = new Contact("","",DateTime.Now,"","", "");

        public ContactsScreen()
        {
            InitializeComponent();
            filters = new Filters(jsonParserAllToMemAllToMem);

            jsonParserAllToMemAllToMem.Show();
            try
            {
                List<string> kuk = jsonParserAllToMemAllToMem.getNames();

                Contacts_lstbx.SelectedIndexChanged -= Contacts_lstbx_SelectedIndexChanged;
                Contacts_lstbx.DataSource = kuk; 
                Contacts_lstbx.SelectedIndex = -1;
                Contacts_lstbx.SelectedIndexChanged += Contacts_lstbx_SelectedIndexChanged;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            experience_cmbx.DataSource = Contact.experiences;

            CustomUI.CustomComboBox(Filter_multichoice_cmbx);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Age_txtbx.Text = (DateTime.Now.Year - BirthDate_dtpk.Value.Year).ToString();
        }

        private void Contacts_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = Contacts_lstbx.SelectedValue.ToString();

            int id = int.Parse(selection.Split('.')[0]);

            //Contact selected = jsonParserAllToMem.GetContact(id);

            //populateInformation(selected);
        }


        private void populateInformation(Contact contact)
        {

            Name_txtbx.Text = contact.first_name + " " + contact.last_name;
            BirthDate_dtpk.Value = contact.birth_date;
            Tel_txtbx.Text = contact.telephone;
            Cell_txtbx.Text = contact.cellphone;
            Address_txtbx.Text = contact.address;
            experience_cmbx.SelectedItem = contact.experience;
            summary_txtbx.Text = contact.summary;

            if (contact.availability)
            {
                Avaiability_cmbx.SelectedIndex = 0;
            }
            else
            {
                Avaiability_cmbx.SelectedIndex = 1;
            }
        }

        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int name_words = Name_txtbx.Text.Split(' ').Count();

            if ( name_words < 2)
            {
                MessageBox.Show("שם מלא לא מצויין");
                return;
            }
            

            string f_name = "";
            for (int i = 0; i < name_words -1; i++)
            {
                if ((i + 1) < name_words)
                {
                    f_name += Name_txtbx.Text.Split(' ')[i] + " ";
                }
                else
                {
                    f_name += Name_txtbx.Text.Split(' ')[i];
                }
            }
            
            string l_name = Name_txtbx.Text.Split(' ')[name_words - 1];

            Contact contact = new Contact()
            {

                first_name = f_name,
                last_name = l_name,
                birth_date = BirthDate_dtpk.Value,
                telephone = Tel_txtbx.Text,
                cellphone = Cell_txtbx.Text,
                address = Address_txtbx.Text,
                availability = Avaiability_cmbx.SelectedIndex == 0 ? true : false,
                experience = experience_cmbx.SelectedItem.ToString(),
                summary = summary_txtbx.Text
            };

            jsonParserAllToMemAllToMem.AddContact(contact);
        }

        private void Exit_btn_Click(object sender, EventArgs e) => Close();

        private void Top_bar_pctb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CustomUI.ReleaseCapture();
                CustomUI.SendMessage(Handle);
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e) => Filter_search_btn.BackgroundImage = Properties.Resources.mag1_over_x48;

        private void pictureBox1_MouseLeave(object sender, EventArgs e) => Filter_search_btn.BackgroundImage = Properties.Resources.mag1_x48;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) => Filter_search_btn.BackgroundImage = Properties.Resources.mag1_click_x48;

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) => Filter_search_btn.BackgroundImage = Properties.Resources.mag1_x48;

        private void Filtering_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = Filtering_cmbx.SelectedItem.ToString();

            if (selection == "גיל")
            {
                Filter_string_txtbx.Visible = true;
                Filter_multichoice_cmbx.Visible = false;
                Filter_string_txtbx.TextAlign = HorizontalAlignment.Center;
                Filter_string_txtbx.Text = "";
            }
            else if (selection == "שם")
            {
                Filter_string_txtbx.Visible = true;
                Filter_multichoice_cmbx.Visible = false;
                Filter_string_txtbx.TextAlign = HorizontalAlignment.Right;
                Filter_string_txtbx.Text = "";
            }
            else if (selection == "ניסיון")
            {
                Filter_string_txtbx.Visible = false;
                Filter_multichoice_cmbx.Visible = true;
                Filter_multichoice_cmbx.DataSource = Contact.experiences;
            }
            else
            {
                Filter_string_txtbx.Visible = false;
                Filter_multichoice_cmbx.Visible = false;
            }
        }

        private void Filter_search_btn_Click(object sender, EventArgs e)
        {
            Contacts_lstbx.SelectedIndexChanged -= Contacts_lstbx_SelectedIndexChanged;

            string selection = Filtering_cmbx.SelectedItem.ToString();

            if (selection == "גיל")
            {
                if (Filter_string_txtbx.Text.Contains('-'))
                {
                    string[] ranges = Filter_string_txtbx.Text.Split(',');

                    string min_age = ranges[0];
                    string max_age = ranges[1];

                    Contacts_lstbx.DataSource = filters.ByAge(min_age, max_age);
                }
            }
            else if (selection == "שם")
            {
                Contacts_lstbx.DataSource = filters.ByName(Filter_string_txtbx.Text);
            }
            else if (selection == "ניסיון")
            {
                Contacts_lstbx.DataSource = filters.Byexperience(Filter_multichoice_cmbx.SelectedItem.ToString());
            }

            Contacts_lstbx.SelectedIndex = -1;
            Contacts_lstbx.SelectedIndexChanged += Contacts_lstbx_SelectedIndexChanged;
        }

        private void Person_add_pbtn_MouseEnter_1(object sender, EventArgs e) => Person_add_pbtn.BackgroundImage = Properties.Resources.person_add_over_x48;

        private void Person_add_pbtn_MouseDown_1(object sender, MouseEventArgs e) => Person_add_pbtn.BackgroundImage = Properties.Resources.person_add_click_x48;

        private void Person_add_pbtn_MouseLeave_1(object sender, EventArgs e) => Person_add_pbtn.BackgroundImage = Properties.Resources.person_add_x48;

        private void Person_update_pbtn_MouseDown(object sender, MouseEventArgs e) => Person_update_pbtn.BackgroundImage = Properties.Resources.person_update_click_x48;

        private void Person_update_pbtn_MouseEnter(object sender, EventArgs e) => Person_update_pbtn.BackgroundImage = Properties.Resources.person_update_over_x48;

        private void Person_update_pbtn_MouseLeave(object sender, EventArgs e) => Person_update_pbtn.BackgroundImage = Properties.Resources.person_update_x48;

        private void Person_remove_pbtn_MouseEnter(object sender, EventArgs e) => Person_remove_pbtn.BackgroundImage = Properties.Resources.person_remove_over_x48;

        private void Person_remove_pbtn_MouseDown(object sender, EventArgs e) => Person_remove_pbtn.BackgroundImage = Properties.Resources.person_remove_click_x48;

        private void Person_remove_pbtn_MouseLeave(object sender, EventArgs e) => Person_remove_pbtn.BackgroundImage = Properties.Resources.person_remove_x48;

    }
}
