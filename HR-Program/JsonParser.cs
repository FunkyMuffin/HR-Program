using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Globalization;
using System.Data;

namespace HR_Program
{
    class jsonParser
    {
        private string file_path;
        private List<Contact> ContactList;
        public static List<string> Names;

        // 
        // Constructor - Gets .json file path from getFilePath and Parse it into a list of strongly-typed classes 'Contact' and 'Adviser".
        //
        public jsonParser()
        {
            ContactBook book = new ContactBook();

            file_path = getFilePath();

            FileStream fileStream = new FileStream(file_path, FileMode.Open);
            book = DeserializeFromStream(fileStream);

            ContactList = book.contactbook;

            Names = getNames();
        }

        // 
        // Public Method - Gets formated names from all the contacts in the ContactList.
        // Returns list of all formated names.
        //
        public List<string> getNames()
        {
            List<string> names = new List<string>();
            foreach (var contact in ContactList)
            {
                names.Add(contact.ToString());
            }
            return names;
        }

        // 
        // Public Method - overloaded method for filtering by 'name' / 'age' / 'experience'.
        // Returns list of all formated names.
        //
        public List<string> getNames(string field, string value1, string value2 = null)
        {
            List<string> name_list = new List<string>();
            List<Contact> filtered_list = new List<Contact>();

            if (field == "name")
            {
                filtered_list = ContactList.Where(x => x.first_name.Contains(value1) || x.last_name.Contains(value1)).ToList();
            }
            else if (field == "age")
            {
                DateTime min_date = DateTime.Now.AddYears(int.Parse(value1) * -1); // Will be higher than birth_date
                DateTime max_date = DateTime.Now.AddYears(int.Parse(value2) * -1); // Will be lower than birth

                filtered_list = ContactList.Where(x => x.birth_date < min_date && x.birth_date > max_date).ToList();
            }
            else if (field == "experience")
            {
                filtered_list = ContactList.Where(x => x.experience == value1).ToList();
            }
            else
            {
                return this.getNames();
            }
            foreach (var contact in filtered_list)
            {
                name_list.Add(contact.ToString());
            }
            
            return name_list;
            
        }

        // 
        // Public Method - Gets a specific contact within the ContactList.
        // Returns Contact object.
        //
        public Contact GetContact(int id)
        {
            return ContactList.Where(x => x.id == id).First();

        }

        // 
        // Public Method - Checks if the id is taken:
        //   Taken - informs users and finish.
        //   Not taken - Adds the contact to the ContactList and adds formated name to the Names list.
        //
        public void AddContact(Contact contact)
        {
            if (!idTaken(contact.id))
            {
                ContactList.Add(contact);
                Names.Add(contact.ToString());
            }
            else
            {
                MessageBox.Show("מ'ס מזהה כבר נמצא בשימוש");
            }

        }

        // 
        // Public Method - Checks if the id is taken:
        //   Taken - Looks for the Contact and overrides if with the new_contact object.
        //   Not taken - informs users and finish.
        //
        public void UpdateContact(Contact new_contact)
        {
            if (idTaken(new_contact.id))
            {
                int index = ContactList.IndexOf(ContactList.Where(x => x.id == new_contact.id).First());

                ContactList[index] = new_contact;

                Names[index] = new_contact.ToString();
            }
            else
            {
                MessageBox.Show("מ'ס מזהה לא נמצא");
            }
            
        }

        // 
        // Public Method - Checks if the id is taken:
        //   Taken - Removes Contact by provided id from ContactList and Names list.
        //   Not taken - informs users and finish.
        //
        public void RemoveContact(int id)
        {
            if (idTaken(id))
            {
                int index = ContactList.IndexOf(ContactList.Where(x => x.id == id).First());

                ContactList.Remove(ContactList[index]);

                Names.Remove(ContactList[index-1].ToString());
            }
            else
            {
                MessageBox.Show("מ'ס מזהה לא נמצא");
            }
        }

        public void SaveToFile()
        {
            ContactBook contactBook = new ContactBook { contactbook = ContactList };

            try
            {
                SerializeFromStream(contactBook);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            MessageBox.Show("הקובץ נשמר בהצלחה");
        }


        // SUPPORT METHODS //

        //
        // Support Method- Searches for '.json' files.
        // If files are found:
        //  only 1      - uses it and continue.
        //  more than 1 - show popup to select which file to use.
        //  no file     - show popup to select a file from dialogbox.
        //  Returns the filename as string.
        //
        private string getFilePath()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory()).Where(x => x.EndsWith(".json")).ToArray();
            if (files.Count() > 1)
            {
                using (JsonFilesModal modal = new JsonFilesModal(files))
                {
                    if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        return modal.Selected_file;
                    }
                    else
                    {
                        throw new Exception("JsonFile Modal didn't return 'DialogResult.OK'");
                    }
                }
            }
            else if (files.Count() == 1)
            {
                return files[0];
            }
            else
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "JSON | *.json";
                    ofd.Title = "בחר קובץ ארכיון";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        return ofd.FileName;

                    }
                    else
                    {
                        MessageBox.Show("לא נבחר קובץ ארכיון!");
                        throw new Exception("No file chosen");
                    }
                }

            }
        }

        //
        // Support Method- Deserialize JSON format from a FileStream object.
        // Returns a 'ContactBook' object.
        //
        private ContactBook DeserializeFromStream(Stream stream)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(stream))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<ContactBook>(jsonTextReader);
            }
        }

        //
        // Support Method- Deserialize JSON format from a FileStream object.
        // Returns a 'ContactBook' object.
        //
        private void SerializeFromStream(ContactBook contactBook)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(file_path))
            using (JsonTextWriter jtr = new JsonTextWriter(sw))
            {
                serializer.Serialize(jtr, contactBook);
            }
        }


        //
        // Support Method- Check whether the provided id already exist.
        // Returns bool.
        //
        private bool idTaken(int id)
        {
            return ContactList.Where(x => x.id == id).Count() != 0 ? true : false;
        }
    }
}
