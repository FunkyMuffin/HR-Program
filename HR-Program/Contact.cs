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
        public static int ID { get; set; }
        public static string[] experiences = new[] { "ללא", "מתחיל", "מנוסה" };


        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime birth_date { get; set; }
        public string cellphone { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
        public string ethnicity { get; set; }
        public List<Adviser> advisers { get; set; }
        public bool availability = true;
        private string exp;
        public string experience
        {
            get
            {
                return exp;
            }

            set
            {
                if (experiences.Contains(value))
                {
                    this.exp = value;
                }
                else
                {
                    this.exp = "ללא";
                }
            }
        }
        public string summary { get; set; }

        public Contact()
        {
            ID++;

            if (id == 0)
               id = ID;
        }

        public Contact(string f_name, string l_name, DateTime birth, string tel, string cell, string addr,bool avail = true, string exp = "ללא", string sum = "", List<Adviser> adv = null)
        {
            first_name = f_name;
            last_name = l_name;
            birth_date = birth;
            telephone = tel;
            cellphone = cell;
            address = addr;
            advisers = adv;
            availability = avail;
            experience = exp;
            summary = sum;

            ID++;
            id = ID;
        }

        public int getAge()
        {
            return DateTime.Now.Year - birth_date.Year;
        }

        public override string ToString() => id + ". " + first_name + " " + last_name;
    }
}
