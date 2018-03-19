using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Program
{
    public partial class JsonFilesModal : Form
    {
        public string[] file_names { get; set; }
        public string selected_file { get; set; }

        public JsonFilesModal()
        {
            InitializeComponent();

            Files_listbox.DataSource = file_names;
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            selected_file = Files_listbox.SelectedItem.ToString();
        }
    }
}
