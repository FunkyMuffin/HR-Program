using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Program
{
    class CustomUI
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg= WM_NCLBUTTONDOWN, int wPatam = HT_CAPTION, int lParam = 0);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public static void CustomComboBox(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.RightToLeft = RightToLeft.Yes;
            comboBox.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Regular);
            
        }
    }
}
