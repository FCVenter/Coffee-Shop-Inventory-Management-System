using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    public static class FormFormatting
    {

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr h, int msg, int wParam, int[] lParam);

        const int EM_SETTABSTOPS = 0x00CB;

        public static void SetTabWidth(RichTextBox richTextBox, int tabWidth)
        {
            SendMessage(richTextBox.Handle, EM_SETTABSTOPS, 1, new int[] { tabWidth * 4 });
        }

        public static void initialiseForm(Form frm)
        {
            frm.ControlBox = false;
            frm.Text = "";
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            CentreFormOnScreen(frm); // Centre the form on the screen
        }

        public static void SetBackgroundImage(Form form, string imageName)
        {
            try
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", imageName);
                form.BackgroundImage = Image.FromFile(imagePath);
                form.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Error: file not found: " + fnfe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static void CentreFormOnScreen(Form frm)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width; // Get the width of the primary screen
            int screenHeight = Screen.PrimaryScreen.Bounds.Height; // Get the height of the primary screen
            int formWidth = frm.Width; // Get the width of the form
            int formHeight = frm.Height; // Get the height of the form

            int left = (screenWidth - formWidth) / 2; // Calculate the left position to center the form horizontally
            int top = (screenHeight - formHeight) / 2; // Calculate the top position to center the form vertically

            frm.Location = new Point(left, top); // Set the location of the form to the calculated position
        }

        public static void SetControlsBackColor(IEnumerable<Control> controls, Color color)
        {
            foreach (Control control in controls)
            {
                control.BackColor = color;
            }
        }

        public static void SetControlsForeColor(IEnumerable<Control> controls, Color color)
        {
            foreach (Control control in controls)
            {
                control.ForeColor = color;
            }
        }


    }
}
