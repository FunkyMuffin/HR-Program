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
    public partial class SchedulesScreen : Form
    {
        public SchedulesScreen()
        {
            InitializeComponent();
        }

        private void Top_bar_pctb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CustomUI.ReleaseCapture();
                CustomUI.SendMessage(Handle);
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e) => Close();
    }
}
