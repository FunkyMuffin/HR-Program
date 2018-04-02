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
        public static string[] Experiances = new[] { "ללא", "מתחיל", "מנוסה" };


        public int id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public DateTime Birth_date { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string address { get; set; }
        public JArray Advisers { get; set; }
        public bool isAvailable = true;
        private string experiance;
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
        public string Summary { get; set; }

        public Contact()
        {
            ID++;

            if (id == 0)
               id = ID;
        }

        public Contact(string f_name, string l_name, DateTime birth, string tel, string cell, string addr,bool avail = true, string exp = "ללא", string sum = "", JArray adv = null)
        {
            First_name = f_name;
            Last_name = l_name;
            Birth_date = birth;
            Telephone = tel;
            Cellphone = cell;
            address = addr;
            Advisers = adv;
            isAvailable = avail;
            Experiance = exp;
            Summary = sum;

            ID++;
            id = ID;
        }

        public int getAge()
        {
            return DateTime.Now.Year - Birth_date.Year;
        }

        public override string ToString()
        {
            return id + ". " + First_name + " " + Last_name;
        }
    }
}
