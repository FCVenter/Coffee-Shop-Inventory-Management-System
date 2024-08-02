using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    public partial class frmStaffLogin : Form
    {

        private ControlAnimation btnLoginAnimation;
        private ControlAnimation btnCancelAnimation;

        private bool bypassValidation = false;
        public frmStaffLogin()
        {
            InitializeComponent();
        }

        private void frmStaffLogin_Load(object sender, EventArgs e)
        {
            FormFormatting.initialiseForm(this);
            initialiseControls();
        }

        // Method to format all controls
        private void initialiseControls()
        {
            FormFormatting.SetBackgroundImage(this, "LoginBackground.jpeg");

            try
            {
                FormFormatting.SetControlsBackColor(new List<Control> { btnCancel, btnLogin }, Color.BurlyWood);
                FormFormatting.SetControlsForeColor(new List<Control> { lblUsername, lblPassword }, Color.Black);

                btnLoginAnimation = new ControlAnimation(btnLogin);
                btnCancelAnimation = new ControlAnimation(btnCancel);

                txtUsername.Focus();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message);
            }

            // Mask user input in Password Textbox
            txtPassword.UseSystemPasswordChar = true;

        }

        // Custom method to test whether the provided username and password matches with their respective contents in the Database
        private bool doesPasswordMatch(string username, string password)
        {
            return (SQL.readSingleValue($"Select UserPassword FROM Users WHERE (UserName = '{username}') ") == password);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bypassValidation = true;
            this.Close();
            bypassValidation = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            int userRole = Convert.ToInt32(SQL.readSingleValue($"SELECT RoleID FROM Users WHERE (UserName = '{txtUsername.Text}')"));

            //Customers Don't have passwords, and are not allowed to log in as staff
            if (userRole == 4)
                return;

            // Test if entered password and username is found in the database and if they match
            if (!doesPasswordMatch(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Username and password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmStaffManagement ManagementForm = new frmStaffManagement();
            ManagementForm.Show();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLoginAnimation.AnimateToColor(Color.Beige);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLoginAnimation.AnimateToColor(Color.BurlyWood);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancelAnimation.AnimateToColor(Color.Beige);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancelAnimation.AnimateToColor(Color.BurlyWood);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (!bypassValidation)
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    // Cancel the event and select the text to correct by the user.
                    e.Cancel = true;
                    txtUsername.Focus();
                    eProvider.SetError(txtUsername, "Please enter a valid Username");
                }
                else
                {
                    // Clear the error, if any, in the error provider.
                    eProvider.SetError(txtUsername, "");
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!bypassValidation)
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    // Cancel the event and select the text to correct by the user.
                    e.Cancel = true;
                    txtUsername.Focus();
                    eProvider.SetError(txtPassword, "Please enter a valid Username");
                }
                else
                {
                    // Clear the error, if any, in the error provider.
                    eProvider.SetError(txtPassword, "");
                }
            }
        }
    }
}
