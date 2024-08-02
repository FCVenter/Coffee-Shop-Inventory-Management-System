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
    public partial class frmTea : Form
    {
        private ControlAnimation btnPlaceOrderAnimation;

        private frmClientOrder _frmClientOrder;

        public frmTea(frmClientOrder form)
        {
            InitializeComponent();
            _frmClientOrder = form;
        }

        private void frmTea_Load(object sender, EventArgs e)
        {
            // Do not call "initialiseForm" method, as it does not work with MDI child forms. 
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;
            initialiseControls();
        }

        private void initialiseControls()
        {
            FormFormatting.SetBackgroundImage(this, "TeaBackground.jpg");

            FormFormatting.SetControlsForeColor(new List<Control> { lblTeaType, lblAddonPrices, lblSize, lblQuantity, lblAddons, chkHoney, chkLemon, chkMilk, rdoSmall, rdoMedium, rdoLarge }, Color.White);
            FormFormatting.SetControlsBackColor(new List<Control> { btnPlaceOrder, rtbTea }, Color.BurlyWood);

            btnPlaceOrderAnimation = new ControlAnimation(btnPlaceOrder);

            // Populate CofeeType Combobox
            SQL.populateCombobox(cmbTeaType, "SELECT DrinkName FROM Drinks WHERE (DrinkTypeID = 2)");

            rtbTea.SelectionFont = new Font(rtbTea.Font.FontFamily, 18, FontStyle.Bold); // Set size to 14 and style to bold
            rtbTea.AppendText(String.Format("{0,-15}{1,5}\t{2,5}\t{3,5}\n\n",
                "Tea",
                "Small",
                "Medium",
                "Large"
            ));
            rtbTea.SelectionFont = new Font(rtbTea.Font.FontFamily, rtbTea.Font.Size, FontStyle.Regular); // Set size and style back to original

            SQL.readDrinkPrices(rtbTea, "SELECT DrinkName, DrinkPrice FROM Drinks WHERE (DrinkTypeID = 2)");
        }

        private void btnPlaceOrder_MouseEnter(object sender, EventArgs e)
        {
            btnPlaceOrderAnimation.AnimateToColor(Color.Beige);
        }

        private void btnPlaceOrder_MouseLeave(object sender, EventArgs e)
        {
            btnPlaceOrderAnimation.AnimateToColor(Color.BurlyWood);
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

            if (!InventoryManagement.ValidateOrderInput(cmbTeaType, nUpDownTea)) return;

            int quantity = (int)nUpDownTea.Value;
            string productType = cmbTeaType.Text;

            //Get Drink ID for the current drink
            int drinkID = InventoryManagement.getDrinkID(productType);

            decimal totalDrinkPrice = InventoryManagement.getDrinkPrice(productType, size) * quantity;

            // Warning message displayed in GetDrinkPrice method above
            if (totalDrinkPrice == 0) return;

            totalPrice += totalDrinkPrice;

            try
            {
                totalPrice += InventoryManagement.CalculateAddonPrice(chkHoney, quantity);
                totalPrice += InventoryManagement.CalculateAddonPrice(chkLemon, quantity);
                totalPrice += InventoryManagement.CalculateAddonPrice(chkMilk, quantity);
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
            InventoryManagement.processItem(chkHoney.Text, quantity);
            InventoryManagement.processItem(chkLemon.Text, quantity);
            InventoryManagement.processItem(chkMilk.Text, quantity);

            _frmClientOrder.currentOrder.updateDetails(true, drinkID, quantity, totalPrice);
            InventoryManagement.processOrder(_frmClientOrder.currentOrder);


        }

        private void lblAddonPrices_Click(object sender, EventArgs e)
        {

        }
    }
}
