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
        private ContactBook Contacts;

        // 
        // Constructor - Looks for a '.json' file under CurrentDir.
        // If files are found:
        //  only 1      - uses it and continue.
        //  more than 1 - show popup to select which file to use.
        //  no file     - show popup to select a file from dialogbox.
        //
        public jsonParser()
        {
            file_path = getFilePath();

            FileStream fileStream = new FileStream(file_path, FileMode.Open);
            Contacts= (ContactBook)DeserializeFromStream(fileStream);
        }

        public List<string> getNames()
        {
            List<string> names = new List<string>();
            foreach (var contact in Contacts.contactbook)
            {
                names.Add(contact.ToString());
            }
            return names;
        }

        public List<string> getNames(string field, string value1, string value2 = null)
        {
            List<string> name_list = new List<string>();
            List<Contact> filtered_list = new List<Contact>();

            if (field == "name")
            {
                filtered_list = Contacts.contactbook.Where(x => x.first_name.Contains(value1) || x.last_name.Contains(value1)).ToList();
            }
            else if (field == "age")
            {
                DateTime min_date = DateTime.Now.AddYears(int.Parse(value1) * -1); // Will be higher than birth_date
                DateTime max_date = DateTime.Now.AddYears(int.Parse(value2) * -1); // Will be lower than birth

                filtered_list = Contacts.contactbook.Where(x => x.birth_date < min_date && x.birth_date > max_date).ToList();
            }
            else if (field == "experience")
            {
                filtered_list = Contacts.contactbook.Where(x => x.experience == value1).ToList();
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

        public Contact GetContact(int id)
        {
            return Contacts.contactbook.Where(x => x.id == id).First();

        }

        public void AddContact(Contact contact)
        {
            
        }


        // SUPPORT METHODS //
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

        private object DeserializeFromStream(Stream stream)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(stream))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<ContactBook>(jsonTextReader);
            }
        }
    }
}
