using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pibble
{
    public partial class NewFile : Form
    {

        private static string widthPlaceholder = "Width in px";
        private static string heightPlaceholder = "Height in px";
        private static string widthErrPlaceholder = "Only numbers allowed!";
        private static string heightErrPlaceholder = "Only numbers allowed!";
        private bool errorWidth;
        private bool errorHeight;

        public int width, height;

        public NewFile()
        {
            InitializeComponent();

            tbxWidth.GotFocus += tbxWidthOnFocus;
            tbxWidth.LostFocus += tbxWidthOnDeFocus;

            tbxHeight.GotFocus += tbxHeightOnFocus;
            tbxHeight.LostFocus += tbxHeightOnDeFocus;



            tbxWidth.Text = "Width in px";
            tbxHeight.Text = "Height in px";
        }

        

        private void NewFile_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tbxWidthOnFocus(Object sender, EventArgs e){
            if (tbxWidth.Text.Equals(widthPlaceholder) || tbxWidth.Text.Equals(widthErrPlaceholder)) {
                tbxWidth.Text = "";
            }           
            widthUnderline.BackColor = Color.FromArgb(255, 25, 34, 124);
            tbxWidth.ForeColor = Color.Black;
        }

        private void tbxWidthOnDeFocus(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxWidth.Text)) {
                tbxWidth.ForeColor = Color.FromArgb(255, 158, 158, 158);
                tbxWidth.Text = "Width in px";
            }
            widthUnderline.BackColor = Color.FromArgb(255, 158, 158, 158);
        }

        private void tbxHeightOnFocus(Object sender, EventArgs e)
        {

            if (tbxHeight.Text.Equals(heightPlaceholder) || tbxHeight.Text.Equals(heightErrPlaceholder)) {
                tbxHeight.Text = "";
            }
            heightUnderline.BackColor = Color.FromArgb(255, 25, 34, 124);
            tbxHeight.ForeColor = Color.Black;
        }

        private void tbxHeightOnDeFocus(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxHeight.Text)) {
                tbxHeight.ForeColor = Color.FromArgb(255, 158, 158, 158);
                tbxHeight.Text = "Height in px";
            }
            heightUnderline.BackColor = Color.FromArgb(255, 158, 158, 158);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool err = false;

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxWidth.Text, "[^0-9]")) {
                widthUnderline.BackColor = Color.Red;
                tbxWidth.Text = widthErrPlaceholder;
                tbxWidth.ForeColor = Color.Red;
                err = true;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxHeight.Text, "[^0-9]")) {
                heightUnderline.BackColor = Color.Red;
                tbxHeight.Text = heightErrPlaceholder;
                tbxHeight.ForeColor = Color.Red;
                err = true;
            }

            if (err) {
                return;
            }


            width = int.Parse(tbxWidth.Text);
            height = int.Parse(tbxHeight.Text);
            this.DialogResult = DialogResult.OK;

        }
    }
}
