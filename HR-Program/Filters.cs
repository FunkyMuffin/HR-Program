using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Program
{
    class Filters
    {
        jsonParserAllToMemAllToMem jsonParserAllToMem;

        public Filters(jsonParserAllToMemAllToMem parser)
        {
            jsonParserAllToMem = parser;
        }


        public List<string> ByAge(string min_num, string max_num)
        {
            if (min_num == "") { min_num = "0"; }

            if (max_num == "") { max_num = "100"; }

            return jsonParserAllToMem.getNames("age", min_num, max_num);
        }

        public List<string> ByName(string name)
        {
            return jsonParserAllToMem.getNames("name", name);
        }

        public List<string> Byexperience(string exp)
        {
            return jsonParserAllToMem.getNames("experience", exp);
        }

    }
}
