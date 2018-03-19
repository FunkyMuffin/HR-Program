using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HR_Program
{
    class MockList
    {
        public List<Contact> dem_list = new List<Contact>();

        public MockList()
        {

            dem_list.Add(new Contact(
                "יהונתן רבי",
                "פישמן",
                DateTime.Parse("27/10/1995"),
                "050-8282188",
                "077-366-5340",
                "דגניה 15, תל אביב",
                true,
                "מתחיל",
                "אוהב לטייל בשבתות בצפון"
                ));
            dem_list.Add(new Contact(
                "ראובן",
                "חיים",
                DateTime.Parse("01/09/1980"),
                "050-11111",
                "077-36614",
                "דגניה 15, תל אביב",
                true,
                null,
                "אוהב לטייל בשבתות בדרום"
                ));
            dem_list.Add(new Contact(
                "מיכל",
                "לוי",
                DateTime.Parse("01/06/1997"),
                "050-11111",
                "077-36614",
                "הרב כהנמן 50, בני ברק",
                true,
                null,
                "לחוצת חתונה"
                ));
            dem_list.Add(new Contact(
                "גלעד",
                "ליפשיץ",
                DateTime.Parse("01/09/1980"),
                "050-11111",
                "077-36614",
                "ההסתדרות 13, תל אביב"
                ));
            dem_list.Add(new Contact(
                "אברהם אליהו",
                "ליפשיץ",
                DateTime.Parse("01/09/1980"),
                "050-11111",
                "077-36614",
                "דרך עזה 80, ירושלים"
                ));
        }

        public Contact getContact(int id, string first_name)
        {
            return dem_list.Find(x => x.id == id && x.first_name.Contains(first_name));
        }

        public List<string> getNames()
        {
            List<string> names = new List<string>();

            foreach( Contact person in dem_list)
            {
                names.Add(person.ToString());
            }
            return names;
        }
    }
}
