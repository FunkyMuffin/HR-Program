using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows.Forms;

namespace HR_Program
{
    class JsonParser
    {
        private string file_path;

        public JsonParser()
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory()).Where( x => x.EndsWith(".json"));

            if (files.Count() > 1)
            {
                using (JsonFilesModal modal = new JsonFilesModal())
                {
                    modal.file_names = files.ToArray();

                    if (modal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        file_path = modal.selected_file;
                    }
                }
            }
        }

        public void praseFile()
        {
            try
            {
                JObject jObj = JObject.Parse(file_path);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

        }
    }
}
