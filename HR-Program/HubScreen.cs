using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace HR_Program
{
    public partial class HubScreen : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wPatam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public HubScreen()
        {
            InitializeComponent();
        }

        // Exit Button Event Handler
        private void Exit_btn_Click(object sender, EventArgs e) => Close();

        private void Top_Bar_pctb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Contacts_form_btn_Click(object sender, EventArgs e)
        {
            if (!IsOpen("ContactsScreen"))
            {
                new Thread(() => new ContactsScreen().ShowDialog()).Start();
            }
            else
            {
                MessageBox.Show("There is already an instance of the contact list");
            }
        }

        private bool IsOpen(string form_name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (var form in fc)
            {
                if (form.ToString().IndexOf(form_name) != -1)
                {
                    return true;
                }
            }

            return false;
        }

        private void Calander_form_btn_Click(object sender, EventArgs e)
        {
            if (!IsOpen("SchedulesScreen"))
            {
                new Thread(() => new SchedulesScreen().ShowDialog()).Start();
            }
            else
            {
                MessageBox.Show("There is already an instance of the contact list");
            }
        }
    }
}
