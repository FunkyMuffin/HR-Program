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
        private jsonParser jsonParser = new jsonParser();
        private ImageParser imageParser = new ImageParser();
        private Filters filters;
        

        public ContactsScreen()
        {
            InitializeComponent();
            filters = new Filters(jsonParser);

            try
            {
                updateList();
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

            Contact selected = jsonParser.GetContact(id);

            populateInformation(selected);
        }

        private void Exit_btn_Click(object sender, EventArgs e) => Close();

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

        private void Person_add_pbtn_Click(object sender, EventArgs e)
        {
            if (Id_txtbx.Text == "")
            {
                Adviser a1 = new Adviser(), a2 = new Adviser(), a3 = new Adviser();
                List<Adviser> advisers_list = new List<Adviser>();

                if (Adviser_name1_txtbx.Text != "")
                {
                    a1 = new Adviser { name = Adviser_name1_txtbx.Text, relationship = Adviser_relation1_txtbx.Text, number = Adviser_contact1_txtbx.Text };
                }

                if (Adviser_name2_txtbx.Text != "")
                {
                    a2 = new Adviser { name = Adviser_name2_txtbx.Text, relationship = Adviser_relation2_txtbx.Text, number = Adviser_contact2_txtbx.Text };
                }
                if (Adviser_name3_txtbx.Text != "")
                {
                    a3 = new Adviser { name = Adviser_name3_txtbx.Text, relationship = Adviser_relation3_txtbx.Text, number = Adviser_contact3_txtbx.Text };
                }

                advisers_list.Add(a1);
                advisers_list.Add(a2);
                advisers_list.Add(a3);

                Contact contact = new Contact
                {
                    first_name = getFirstName(Name_txtbx.Text),
                    last_name = getLastName(Name_txtbx.Text),
                    birth_date = BirthDate_dtpk.Value,
                    telephone = Tel_txtbx.Text,
                    cellphone = Cell_txtbx.Text,
                    address = Address_txtbx.Text,
                    availability = Avaiability_cmbx.SelectedIndex == 0 ? true : false,
                    experience = experience_cmbx.SelectedItem.ToString(),
                    summary = summary_txtbx.Text,
                    advisers = advisers_list
                };

                jsonParser.AddContact(contact);
                Id_txtbx.Text = contact.id.ToString();
                updateList();
                MessageBox.Show(contact.first_name + " נוסף למאגר.");
            }
            else
            {
                MessageBox.Show("מ'ס מזהה כבר תפוס");
            }
        }

        private void Person_update_pbtn_Click(object sender, EventArgs e)
        {
            if (Id_txtbx.Text != "")
            {
                Adviser a1 = new Adviser(), a2 = new Adviser(), a3 = new Adviser();
                List<Adviser> advisers_list = new List<Adviser>();

                if (Adviser_name1_txtbx.Text != "")
                {
                    a1 = new Adviser { name = Adviser_name1_txtbx.Text, relationship = Adviser_relation1_txtbx.Text, number = Adviser_contact1_txtbx.Text };
                }

                if (Adviser_name2_txtbx.Text != "")
                {
                    a2 = new Adviser { name = Adviser_name2_txtbx.Text, relationship = Adviser_relation2_txtbx.Text, number = Adviser_contact2_txtbx.Text };
                }
                if (Adviser_name3_txtbx.Text != "")
                {
                    a3 = new Adviser { name = Adviser_name3_txtbx.Text, relationship = Adviser_relation3_txtbx.Text, number = Adviser_contact3_txtbx.Text };
                }

                advisers_list.Add(a1);
                advisers_list.Add(a2);
                advisers_list.Add(a3);

                Contact contact = new Contact
                {
                    id = int.Parse(Id_txtbx.Text),
                    first_name = getFirstName(Name_txtbx.Text),
                    last_name = getLastName(Name_txtbx.Text),
                    birth_date = BirthDate_dtpk.Value,
                    telephone = Tel_txtbx.Text,
                    cellphone = Cell_txtbx.Text,
                    address = Address_txtbx.Text,
                    availability = Avaiability_cmbx.SelectedIndex == 0 ? true : false,
                    experience = experience_cmbx.SelectedItem.ToString(),
                    summary = summary_txtbx.Text
                };

                jsonParser.UpdateContact(contact);
                updateList();
                MessageBox.Show("רשומה עודכנה");

            }
            else
            {
                MessageBox.Show("מ'ס מזהה לא נמצא");
            }
        }

        private void Person_remove_pbtn_Click(object sender, EventArgs e)
        {
            if (Id_txtbx.Text != "")
            {
                jsonParser.RemoveContact(int.Parse(Id_txtbx.Text));
                updateList();
                MessageBox.Show("רשומה נמחקה");

            }
            else
            {
                MessageBox.Show("מ'ס מזהה לא נמצא");
            }
        }

        private void Person_new_pbtn_Click(object sender, EventArgs e)
        {
            Name_txtbx.Text = "";
            Id_txtbx.Text = "";
            BirthDate_dtpk.Value = DateTime.Now;
            Cell_txtbx.Text = "";
            Tel_txtbx.Text = "";
            Ethnicity_cmbx.SelectedIndex = -1;
            Address_txtbx.Text = "";
            summary_txtbx.Text = "";
            experience_cmbx.SelectedIndex = -1;
            Avaiability_cmbx.SelectedIndex = -1;
            Contact_image_pnl.BackgroundImage = null;

            Adviser_contact1_txtbx.Text = "";
            Adviser_contact2_txtbx.Text = "";
            Adviser_contact3_txtbx.Text = "";

            Adviser_name1_txtbx.Text = "";
            Adviser_name2_txtbx.Text = "";
            Adviser_name3_txtbx.Text = "";

            Adviser_relation1_txtbx.Text = "";
            Adviser_relation2_txtbx.Text = "";
            Adviser_relation3_txtbx.Text = "";
        }


        private void Adviser_del1_btn_Click(object sender, EventArgs e)
        {
            Adviser_contact1_txtbx.Text = "";
            Adviser_name1_txtbx.Text = "";
            Adviser_relation1_txtbx.Text = "";
        }

        private void Adviser_del2_btn_Click(object sender, EventArgs e)
        {
            Adviser_contact2_txtbx.Text = "";
            Adviser_name2_txtbx.Text = "";
            Adviser_relation2_txtbx.Text = "";
        }

        private void Adviser_del3_btn_Click(object sender, EventArgs e)
        {
            Adviser_contact3_txtbx.Text = "";
            Adviser_name3_txtbx.Text = "";
            Adviser_relation3_txtbx.Text = "";
        }

        private void Save_pbtn_Click(object sender, EventArgs e)
        {
            jsonParser.SaveToFile();
        }


        // Support Methods
        private void populateInformation(Contact contact)
        {

            Name_txtbx.Text = contact.first_name + " " + contact.last_name;
            BirthDate_dtpk.Value = contact.birth_date;
            Tel_txtbx.Text = contact.telephone;
            Cell_txtbx.Text = contact.cellphone;
            Address_txtbx.Text = contact.address;
            experience_cmbx.SelectedItem = contact.experience;
            summary_txtbx.Text = contact.summary;
            Id_txtbx.Text = contact.id.ToString();
            Avaiability_cmbx.SelectedIndex = contact.availability?  0 : 1;
            Ethnicity_cmbx.SelectedIndex = contact.ethnicity == "אשכנז" ? 0 : 1;

            if (contact.advisers != null)
            {
                try
                {
                    Adviser_name1_txtbx.Text = contact.advisers[0].name;
                    Adviser_relation1_txtbx.Text = contact.advisers[0].relationship;
                    Adviser_contact1_txtbx.Text = contact.advisers[0].number;
                }
                catch
                {
                    Adviser_name1_txtbx.Text = "";
                    Adviser_relation1_txtbx.Text = "";
                    Adviser_contact1_txtbx.Text = "";
                }
                try
                {
                    Adviser_name2_txtbx.Text = contact.advisers[1].name;
                    Adviser_relation2_txtbx.Text = contact.advisers[1].relationship;
                    Adviser_contact2_txtbx.Text = contact.advisers[1].number;
                }
                catch
                {
                    Adviser_name2_txtbx.Text = "";
                    Adviser_relation2_txtbx.Text = "";
                    Adviser_contact2_txtbx.Text = "";
                }
                try
                {
                    Adviser_name3_txtbx.Text = contact.advisers[2].name;
                    Adviser_relation3_txtbx.Text = contact.advisers[2].relationship;
                    Adviser_contact3_txtbx.Text = contact.advisers[2].number;
                }
                catch
                {
                    Adviser_name3_txtbx.Text = "";
                    Adviser_relation3_txtbx.Text = "";
                    Adviser_contact3_txtbx.Text = "";
                }
            }

            try
            {
                Contact_image_pnl.BackgroundImage = Image.FromFile(imageParser.getImagePath(contact.image_name));
            }
            catch
            {
                Contact_image_pnl.BackgroundImage = null;
            }
            
        }

        private string getFirstName(string name)
        {
            int name_words = Name_txtbx.Text.Split(' ').Count();

            if (name_words < 2)
            {
                MessageBox.Show("שם מלא לא מצויין");
                return "";
            }


            string f_name = "";
            for (int i = 0; i < name_words - 1; i++)
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

            return f_name;
        }

        private string getLastName(string name)
        {
            return name.Split(' ')[name.Split(' ').Count() - 1];
        }

        private void updateList()
        {
            Contacts_lstbx.SelectedIndexChanged -= Contacts_lstbx_SelectedIndexChanged;
            Contacts_lstbx.DataSource = null;
            Contacts_lstbx.DataSource = jsonParser.Names;
            Contacts_lstbx.SelectedIndex = -1;
            Contacts_lstbx.SelectedIndexChanged += Contacts_lstbx_SelectedIndexChanged;
        }


        // Picture Box Image Behavior Methods
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

        private void Person_add_pbtn_MouseEnter_1(object sender, EventArgs e) => Person_add_pbtn.BackgroundImage = Properties.Resources.person_add_over_x48;

        private void Person_add_pbtn_MouseDown_1(object sender, MouseEventArgs e) => Person_add_pbtn.BackgroundImage = Properties.Resources.person_add_click_x48;

        private void Person_add_pbtn_MouseLeave_1(object sender, EventArgs e) => Person_add_pbtn.BackgroundImage = Properties.Resources.person_add_x48;

        private void Person_update_pbtn_MouseDown(object sender, MouseEventArgs e) => Person_update_pbtn.BackgroundImage = Properties.Resources.person_update_click_x48;

        private void Person_update_pbtn_MouseEnter(object sender, EventArgs e) => Person_update_pbtn.BackgroundImage = Properties.Resources.person_update_over_x48;

        private void Person_update_pbtn_MouseLeave(object sender, EventArgs e) => Person_update_pbtn.BackgroundImage = Properties.Resources.person_update_x48;

        private void Person_remove_pbtn_MouseEnter(object sender, EventArgs e) => Person_remove_pbtn.BackgroundImage = Properties.Resources.person_remove_over_x48;

        private void Person_remove_pbtn_MouseDown(object sender, EventArgs e) => Person_remove_pbtn.BackgroundImage = Properties.Resources.person_remove_click_x48;

        private void Person_remove_pbtn_MouseLeave(object sender, EventArgs e) => Person_remove_pbtn.BackgroundImage = Properties.Resources.person_remove_x48;

        private void Adviser_del1_btn_MouseDown_1(object sender, MouseEventArgs e) => Adviser_del1_btn.BackgroundImage = Properties.Resources.X_icon_click_x48;

        private void Adviser_del1_btn_MouseEnter_1(object sender, EventArgs e) => Adviser_del1_btn.BackgroundImage = Properties.Resources.X_icon_over_x48;

        private void Adviser_del1_btn_MouseLeave_1(object sender, EventArgs e) => Adviser_del1_btn.BackgroundImage = Properties.Resources.X_icon_x48;

        private void Adviser_del2_btn_MouseDown(object sender, MouseEventArgs e) => Adviser_del2_btn.BackgroundImage = Properties.Resources.X_icon_click_x48;

        private void Adviser_del2_btn_MouseEnter(object sender, EventArgs e) => Adviser_del2_btn.BackgroundImage = Properties.Resources.X_icon_over_x48;

        private void Adviser_del2_btn_MouseLeave(object sender, EventArgs e) => Adviser_del2_btn.BackgroundImage = Properties.Resources.X_icon_x48;

        private void Adviser_del3_btn_MouseDown(object sender, MouseEventArgs e) => Adviser_del3_btn.BackgroundImage = Properties.Resources.X_icon_click_x48;

        private void Adviser_del3_btn_MouseEnter(object sender, EventArgs e) => Adviser_del3_btn.BackgroundImage = Properties.Resources.X_icon_over_x48;

        private void Adviser_del3_btn_MouseLeave(object sender, EventArgs e) => Adviser_del3_btn.BackgroundImage = Properties.Resources.X_icon_x48;

        private void Person_new_pbtn_MouseDown(object sender, MouseEventArgs e) => Person_new_pbtn.BackgroundImage = Properties.Resources.person_new_click_x48;

        private void Person_new_pbtn_MouseEnter(object sender, EventArgs e) => Person_new_pbtn.BackgroundImage = Properties.Resources.person_new_over_x48;

        private void Person_new_pbtn_MouseLeave(object sender, EventArgs e) => Person_new_pbtn.BackgroundImage = Properties.Resources.person_new_x48;

        private void Save_pbtn_MouseDown(object sender, MouseEventArgs e) => Save_pbtn.BackgroundImage = Properties.Resources.save_click_x48;

        private void Save_pbtn_MouseEnter(object sender, EventArgs e) => Save_pbtn.BackgroundImage = Properties.Resources.save_over_x48;

        private void Save_pbtn_MouseLeave(object sender, EventArgs e) => Save_pbtn.BackgroundImage = Properties.Resources.save_x48;


    }
}
