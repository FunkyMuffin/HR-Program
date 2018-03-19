using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace HR_Program
{
    class Contact
    {
        private static int ID = 0;
        public string[] Experiances = new[] { "ללא", "מתחיל", "מנוסה" };


        public int id { get; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime birth_date { get; set; }
        public string telephone { get; set; }
        public string cellphone { get; set; }
        public string address { get; set; }
        public JObject advisors { get; set; }
        public bool isAvailable = true;
        public string experiance;
        public string Experiance
        {
            get
            {
                return experiance;
            }

            set
            {
                if (Experiances.Contains(value))
                {
                    this.experiance = value;
                }
                else
                {
                    this.experiance = "ללא";
                }
            }
        }

        public Contact(string f_name, string l_name, DateTime birth, string tel, string cell, string addr,bool avail = true, string exp = "ללא", JObject adv = null)
        {
            first_name = f_name;
            last_name = l_name;
            birth_date = birth;
            telephone = tel;
            cellphone = cell;
            address = addr;
            advisors = adv;
            isAvailable = avail;
            Experiance = exp;

            ID++;
            id = ID;
        }

        public int getAge()
        {
            return DateTime.Now.Year - birth_date.Year;
        }

        public override string ToString()
        {
            return id + ". " + first_name + " " + last_name;
        }
    }
}
