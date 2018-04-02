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
        public string[] Files_names { get; set; }
        public string Selected_file { get; set; }

        public JsonFilesModal( string[] files)
        {
            InitializeComponent();

            Files_listbox.DataSource = files;
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Selected_file = Files_listbox.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
