using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    public partial class frmClientOrder : Form
    {

        public int userID;

        public OrderDetails currentOrder;

        public frmClientOrder()
        {
            InitializeComponent();
        }

        private void frmClientOrder_Load(object sender, EventArgs e)
        {
            FormFormatting.initialiseForm(this); // Call custom method to set all properties of the form as nmeeded 
            initialiseControls();
        }

        private void initialiseControls()
        {
            FormFormatting.SetBackgroundImage(this, "CustomerOrderBackground.jpeg");
            mStrip.Enabled = false;

            txtEmail.Text = "";
            txtName.Text = "";
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close(); // Go back to Main Form
            InventoryManagement.finaliseOrder(currentOrder);
            pnlCustomerData.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close Application
        }

        private void OpenForm<T>() where T : Form
        {
            try
            {
                T mdiForm = (T)Activator.CreateInstance(typeof(T), new object[] { this });
                mdiForm.MdiParent = this;
                mdiForm.Show();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Win32Exception we)
            {
                MessageBox.Show("Error: " + we.Message);
            }
        }


        private void coffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmCoffee>(); // Open Coffee Mdi Form
            pnlCustomerData.Visible = false;
        }

        private void teaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmTea>(); // Open Tea Mdi Form
            pnlCustomerData.Visible = false;
        }

        private void pastriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmPastry>(); // Open Pastries Mdi Form
            pnlCustomerData.Visible = false;
        }

        private void sandwichesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmSandwiches>(); // Open Sandwiches Mdi Form
            pnlCustomerData.Visible = false;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // TODO: Add validation

            string email = txtEmail.Text;
            string name = txtName.Text;

            SQL.insertRecord($"INSERT INTO Users (RoleID, UserName, UserEmail) VALUES (4, '{name}', '{email}')");

            int userID = Convert.ToInt32(SQL.readSingleValue($"SELECT UserID FROM Users WHERE (UserName = '{name}')"));

            // Instantiate current order (for the whole order session between all drinks and food)
            currentOrder = new OrderDetails(userID);

            mStrip.Enabled = true;
            pnlCustomerData.Visible = false;
        }
    }
}
