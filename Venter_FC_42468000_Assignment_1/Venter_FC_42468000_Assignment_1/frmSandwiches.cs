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
    public partial class frmSandwiches : Form
    {

        private ControlAnimation btnPlaceOrderAnimation;

        private frmClientOrder _frmClientOrder;

        public frmSandwiches(frmClientOrder form)
        {
            InitializeComponent();
            _frmClientOrder = form;
        }

        private void frmSandwiches_Load(object sender, EventArgs e)
        {
            // Do not call "initialiseForm" method, as it does not work with MDI child forms. 
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;
            initialiseControls();
        }

        private void initialiseControls()
        {

            FormFormatting.SetBackgroundImage(this, "SandwichBackground.jpeg");

            FormFormatting.SetControlsForeColor(new List<Control> { lblSandwichType, lblAddonPrices, lblQuantity, lblAddons, chkAvocado, chkBacon, chkCheese }, Color.Beige);
            FormFormatting.SetControlsBackColor(new List<Control> { btnPlaceOrder, rtbSandwich }, Color.BurlyWood);

            btnPlaceOrderAnimation = new ControlAnimation(btnPlaceOrder);

            nUpDownQuantity.Minimum = 1;
            nUpDownQuantity.Maximum = 10;

            // Populate SandwichType Combobox
            SQL.populateCombobox(cmbSandwichType, "SELECT FoodName FROM Food WHERE (FoodTypeID = 2)");

            rtbSandwich.SelectionFont = new Font(rtbSandwich.Font.FontFamily, 18, FontStyle.Bold); // Set size to 14 and style to bold
            rtbSandwich.AppendText(String.Format("{0,-18}{1,5}\n\n", "Sandwich", "Price"));
            rtbSandwich.SelectionFont = new Font(rtbSandwich.Font.FontFamily, rtbSandwich.Font.Size, FontStyle.Regular); // Set size and style back to original

            SQL.readFoodPrices(rtbSandwich, "SELECT FoodName, FoodPrice FROM Food WHERE (FoodTypeID = 1)");

        }

        private void btnPlaceOrder_MouseEnter(object sender, EventArgs e)
        {
            btnPlaceOrderAnimation.AnimateToColor(Color.Beige);
        }

        private void btnPlaceOrder_MouseLeave(object sender, EventArgs e)
        {
            btnPlaceOrderAnimation.AnimateToColor(Color.BurlyWood);
        }

        
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            if (!InventoryManagement.ValidateOrderInput(cmbSandwichType, nUpDownQuantity))
                return;

            int quantity = (int)nUpDownQuantity.Value; // Amount
            string productType = cmbSandwichType.Text; // FoodName

            int foodID = InventoryManagement.getFoodID(productType);

            try
            {
                totalPrice += InventoryManagement.CalculateAddonPrice(chkBacon, quantity);
                totalPrice += InventoryManagement.CalculateAddonPrice(chkAvocado, quantity);
                totalPrice += InventoryManagement.CalculateAddonPrice(chkCheese, quantity);
            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message);
                return;
            }

            totalPrice += InventoryManagement.getFoodPrice(productType) * quantity;

            // REVIEW ORDER
            DialogResult result = MessageBox.Show($"You are about to complete your order:\n" +
                $"{quantity} x {productType}\nTotal Amount: R{totalPrice}", "Order Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
                return;

            // Decrease item quantity in inventory once validation has been done
            InventoryManagement.processItem(productType, quantity);
            InventoryManagement.processItem(chkBacon.Text, quantity);
            InventoryManagement.processItem(chkAvocado.Text, quantity);
            InventoryManagement.processItem(chkCheese.Text, quantity);

            _frmClientOrder.currentOrder.updateDetails(false, foodID, quantity, totalPrice);
            InventoryManagement.processOrder(_frmClientOrder.currentOrder);

        }


    }
}
