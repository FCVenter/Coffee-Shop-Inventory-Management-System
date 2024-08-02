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

namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    public partial class frmCoffee : Form
    {

        private ControlAnimation btnPlaceOrderAnimation;
        private frmClientOrder _frmClientOrder;

        public frmCoffee(frmClientOrder form)
        {
            InitializeComponent();
            _frmClientOrder = form;
        }

        private void frmCoffee_Load(object sender, EventArgs e)
        {
            // Do not call "initialiseForm" method, as it does not work with MDI child forms. 
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;
            initialiseControls();
        }

        private void initialiseControls()
        {
            FormFormatting.SetBackgroundImage(this, "CoffeeBackground.jpg");

            FormFormatting.SetControlsForeColor(new List<Control> { lblCoffee, lblSize, lblQuantity, lblAddons }, Color.Beige);
            FormFormatting.SetControlsBackColor(new List<Control> { btnPlaceOrder, rtbCoffee}, Color.BurlyWood);

            btnPlaceOrderAnimation = new ControlAnimation(btnPlaceOrder);

            // Populate CofeeType Combobox
            SQL.populateCombobox(cmbCoffeeType, "SELECT DrinkName FROM Drinks WHERE (DrinkTypeID = 1)");

            rtbCoffee.ReadOnly = true;
            rtbCoffee.BorderStyle = BorderStyle.None;


            rtbCoffee.SelectionFont = new Font(rtbCoffee.Font.FontFamily, 18, FontStyle.Bold); // Set size to 14 and style to bold
            rtbCoffee.AppendText(String.Format("{0,-13}{1,5}\t{2,5}\t{3,5}\n\n",
                "Coffee",
                "Small",
                "Medium",
                "Large"
            ));
            rtbCoffee.SelectionFont = new Font(rtbCoffee.Font.FontFamily, rtbCoffee.Font.Size, FontStyle.Regular); // Set size and style back to original

            SQL.readDrinkPrices(rtbCoffee, "SELECT DrinkName, DrinkPrice FROM Drinks WHERE (DrinkTypeID = 1)");
        }

        private void btnPlaceOrder_MouseEnter(object sender, EventArgs e)
        {
            btnPlaceOrderAnimation.AnimateToColor(Color.Beige);
        }

        private void btnPlaceOrder_MouseLeave(object sender, EventArgs e)
        {
            btnPlaceOrderAnimation.AnimateToColor(Color.BurlyWood);
        }

        private void frmCoffee_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private string getSize()
        {
            if (rdoSmall.Checked) return "Small";
            if (rdoMedium.Checked) return "Medium";
            if (rdoLarge.Checked) return "Large";
            else
            {
                MessageBox.Show("Please select a size");
                return null;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            string size = getSize();

            if (size == null) return;

            if (!InventoryManagement.ValidateOrderInput(cmbCoffeeType, nUpDownCoffee)) return;

            int quantity = (int)nUpDownCoffee.Value; // Amount
            string productType = cmbCoffeeType.Text; // DrinkName

            //Get Drink ID for the current drink
            int drinkID = InventoryManagement.getDrinkID(productType);

            decimal totalDrinkPrice = InventoryManagement.getDrinkPrice(productType, size) * quantity;

            // Warning message displayed in GetDrinkPrice method above
            if (totalDrinkPrice == 0) return;

            totalPrice += totalDrinkPrice;

            try
            {
                totalPrice += InventoryManagement.CalculateAddonPrice(chkCream, quantity);
                totalPrice += InventoryManagement.CalculateAddonPrice(chkDouble, quantity);
                totalPrice += InventoryManagement.CalculateAddonPrice(chkSyrup, quantity);
            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message);
                return;
            }

            // REVIEW ORDER
            DialogResult result = MessageBox.Show($"You are about to complete your order:\n" +
                $"{quantity} x {productType}\nTotal Amount: R{totalPrice}", "Order Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
                return;


            // Decrease item quantity in inventory once validation has been done
            InventoryManagement.processItem(productType, quantity);
            InventoryManagement.processItem(chkCream.Text, quantity);
            InventoryManagement.processItem(chkDouble.Text, quantity);
            InventoryManagement.processItem(chkSyrup.Text, quantity);

            _frmClientOrder.currentOrder.updateDetails(true, drinkID, quantity, totalPrice);
            InventoryManagement.processOrder(_frmClientOrder.currentOrder);

        }
    }
}
