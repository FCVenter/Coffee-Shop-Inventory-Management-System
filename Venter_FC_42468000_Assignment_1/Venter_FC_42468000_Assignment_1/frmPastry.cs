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
    public partial class frmPastry : Form
    {

        private ControlAnimation btnPlaceOrderAnimation;

        private frmClientOrder _frmClientOrder;

        public frmPastry(frmClientOrder form)
        {
            InitializeComponent();
            _frmClientOrder = form;
        }
        private void frmPastry_Load(object sender, EventArgs e)
        {
            // Do not call "initialiseForm" method, as it does not work with MDI child forms. 
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;
            initialiseControls();
        }

        private void initialiseControls()
        {
            FormFormatting.SetBackgroundImage(this, "PastryBackground.jpg");

            FormFormatting.SetControlsForeColor(new List<Control> { lblPastryType, lblQuantity }, Color.Beige);
            FormFormatting.SetControlsBackColor(new List<Control> { btnPlaceOrder, rtbPastry }, Color.BurlyWood);

            btnPlaceOrderAnimation = new ControlAnimation(btnPlaceOrder);

            // Populate PastryType Combobox
            SQL.populateCombobox(cmbPastryType, "SELECT FoodName FROM Food WHERE (FoodTypeID = 1)");

            rtbPastry.SelectionFont = new Font(rtbPastry.Font.FontFamily, 18, FontStyle.Bold); // Set size to 14 and style to bold
            rtbPastry.AppendText(String.Format("{0,-18}{1,5}\n\n", "Pastry", "Price"));
            rtbPastry.SelectionFont = new Font(rtbPastry.Font.FontFamily, rtbPastry.Font.Size, FontStyle.Regular); // Set size and style back to original

            SQL.readFoodPrices(rtbPastry, "SELECT FoodName, FoodPrice FROM Food WHERE (FoodTypeID = 1)");

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

            if (!InventoryManagement.ValidateOrderInput(cmbPastryType, nUpDownPastry)) return;

            int quantity = (int) nUpDownPastry.Value; // Amount
            string productType = cmbPastryType.Text; // FoodName

            int foodID = InventoryManagement.getFoodID(productType);

            totalPrice += InventoryManagement.getFoodPrice(productType) * quantity;

            // REVIEW ORDER
            DialogResult result = MessageBox.Show($"You are about to complete your order:\n" +
                $"{quantity} x {productType}\nTotal Amount: R{totalPrice}", "Order Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
                return;

            // Decrease item quantity in inventory once validation has been done
            InventoryManagement.processItem(productType, quantity);

            _frmClientOrder.currentOrder.updateDetails(false, foodID, quantity, totalPrice);
            InventoryManagement.processOrder(_frmClientOrder.currentOrder);


        }
    }
}
