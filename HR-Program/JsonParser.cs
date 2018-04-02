using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Globalization;

namespace HR_Program
{
    class JsonParser
    {
        private string file_path;

        // 
        // Constructor - Looks for a '.json' file under CurrentDir.
        // If files are found:
        //  only 1      - uses it and continue.
        //  more than 1 - show popup to select which file to use.
        //  no file     - show popup to select a file from dialogbox.
        //
        public JsonParser()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory()).Where( x => x.EndsWith(".json")).ToArray();
            if (files.Count() > 1)
            {
                using (JsonFilesModal modal = new JsonFilesModal(files))
                {
                    if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        file_path = modal.Selected_file;
                    }
                }
            }
            else if (files.Count() == 1)
            {
                file_path = files[0];
            }
            else
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "JSON | *.json";
                    ofd.Title = "בחר קובץ ארכיון";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        file_path = ofd.FileName;

                    }
                    else
                    {
                        MessageBox.Show("לא נבחר קובץ ארכיון!");
                    }
                }
                
            }
        }


        //
        // GetNames - returns list of names from file_path variable.
        //
        public List<string> GetNames()
        {
            JObject json = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(file_path, Encoding.UTF8));

            List <string> name_list = new List<string>();

            int id;
            string first_name,last_name;
            
            foreach (JToken person in json["ContactBook"].Children())
            {
                try
                {
                    id = int.Parse(person["id"].ToString());
                    first_name = person["forename"].ToString();
                    last_name = person["surname"].ToString();

                    name_list.Add(id + ". " + first_name + " " + last_name);
                }
                catch
                {
                    throw new Exception("שגיאה בטעינת שמות!" + Environment.NewLine + "שדות: id, forename, surname");
                }
            }

            Contact.ID = int.Parse(name_list[name_list.Count() - 1].Split('.')[0]);
            return name_list;
        }

        //
        //  GetNames - returns list of names from file_path variable.
        //  Args:
        //      field   - Name of the filtering field [name | age | experiance ].
        //      value1  - First value.
        //      value2  - Second value, optional.
        //
        public List<string> getNames(string field, string value1, string value2 = null)
        {
            List<string> name_list = new List<string>();

            JObject full_json = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(file_path, Encoding.UTF8));
            IEnumerable<JToken> raw_json;

            if (field == "name")
            {
                raw_json = (from a in full_json["ContactBook"]
                                where a["forename"].ToString().Contains(value1) || a["surname"].ToString().Contains(value1)
                                select a).ToList();
            }
            else if (field == "age")
            {
                DateTime min_date = DateTime.Now.AddYears(int.Parse(value1) * -1); // Will be higher than birth 
                DateTime max_date = DateTime.Now.AddYears(int.Parse(value2) * -1); // Will be lower than birth
                

                raw_json = (from a in full_json["ContactBook"]
                                where DateTime.Parse(a["birth_date"].ToString()) > max_date && DateTime.Parse(a["birth_date"].ToString()) < min_date
                            select a).ToList();
            }
            else if (field == "experience")
            {
                raw_json = (from a in full_json["ContactBook"]
                            where a["experience"].ToString().Equals(value1)
                            select a).ToList();
            }
            else
            {
                raw_json = (from a in full_json["ContactBook"]
                            select a).ToList();
            }
            full_json = null;
            
            JArray contacts = new JArray(raw_json);
            raw_json = null;

            int id;
            string first_name, last_name;

            foreach (JToken contact in contacts.Children())
            {
                try
                {
                    id = int.Parse(contact["id"].ToString());
                    first_name = contact["forename"].ToString();
                    last_name = contact["surname"].ToString();

                    name_list.Add(id + ". " + first_name + " " + last_name);
                }
                catch
                {
                    throw new Exception("שגיאה בטעינת שמות!" + Environment.NewLine + "שדות: id, forename, surname");
                }
            }

            return name_list;
        }


        //
        //  GeContact - returns Contact object by id
        //  Args:
        //      id - ID if selected person
        //
        public Contact GetContact(int id)
        {
            JObject full_json = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(file_path, Encoding.UTF8));

            var queried_json = (from a in full_json["ContactBook"]
                             where a["id"].ToString().Equals(id.ToString())
                             select a).ToList();

            JObject person = JObject.Parse(queried_json[0].ToString());

            Contact contact = new Contact
            {
                id = int.Parse(person["id"].ToString()),
                First_name = person["forename"].ToString(),
                Last_name = person["surname"].ToString(),
                Birth_date = DateTime.Parse(person["birth_date"].ToString()),
                Telephone = person["telephone"].ToString(),
                Cellphone = person["cellphone"].ToString(),
                address = person["address"].ToString(),
                Advisers = (JArray)person["advisers"],
                isAvailable = bool.Parse(person["availability"].ToString()),
                Experiance = person["experience"].ToString(),
                Summary = person["summary"].ToString()

            };

            return contact;
        }

        public void AddContact(Contact contact)
        {
            
        }
    }
}
