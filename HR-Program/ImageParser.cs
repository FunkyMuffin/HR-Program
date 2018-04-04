using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Program
{
    class ImageParser
    {
        private string path;

        public ImageParser()
        {
            path = Directory.GetCurrentDirectory();
            if (!Directory.Exists(path + @"\images"))
            {
                Directory.CreateDirectory(path + @"\images");
            }

            path = path + @"\images";
        }

        public string getImagePath(string name)
        {
            try
            {
                return Directory.GetFiles(path).Where(x => x.ToString().Contains(name)).First();
            }
            catch
            {
                MessageBox.Show("Couldn't find Image file");
                return "";
            }
        }
    }
}
