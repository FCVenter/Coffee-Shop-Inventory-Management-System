using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1;

namespace Venter_FC_42468000_Assignment_1
{
    public partial class frmItemDetails : Form
    {

        public decimal price { get; set; }
        public string name { get; set; }
        public string table { get; set; }
        public int productID { get; set; }
        public string priceColumn { get; set; }

        private ControlAnimation btnProcessAnimation;

        public frmItemDetails()
        {
            InitializeComponent();
        }

        private void frmItemDetails_Load(object sender, EventArgs e)
        {
            initialiseConstrols();
        }

        private void initialiseConstrols()
        {
            FormFormatting.SetControlsBackColor(new List<Control> { btnProcess, this }, Color.BurlyWood);
            FormFormatting.SetControlsForeColor(new List<Control> { lblPrice, lblTeaType, rdoCoffee, rdoPastry, rdoTea, rdoSandwich }, Color.White);

            btnProcessAnimation = new ControlAnimation(btnProcess);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if ( !(rdoCoffee.Checked | rdoTea.Checked | rdoPastry.Checked | rdoSandwich.Checked) )
            {
                MessageBox.Show("Please the item type");
                return;
            }

            if ( txtName.Text == "")
            {
                MessageBox.Show("Please enter an item name");
                return;
            }

            if ( txtPrice.Text == "")
            {
                MessageBox.Show("Please enter an item price");
                return;
            }

            try
            {
                price = Decimal.Parse(txtPrice.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("An error occured trying to parse the price. Price set to 0.");
                return;
            }

            name = txtName.Text;

            this.Close();

        }

        private void rdoCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCoffee.Checked)
            {
                table = "Drinks";
                priceColumn = "DrinkPrice";
                productID = 1;
            }
        }

        private void rdoTea_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTea.Checked)
            {
                table = "Drinks";
                priceColumn = "DrinkPrice";
                productID = 2;
            }
        }

        private void rdoPastry_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPastry.Checked)
            {
                table = "Food";
                priceColumn = "FoodPrice";
                productID = 1;
            }
        }

        private void rdoSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSandwich.Checked)
            {
                table = "Food";
                priceColumn = "FoodPrice";
                productID = 2;
            }
        }

        private void btnProcess_MouseEnter(object sender, EventArgs e)
        {
            btnProcessAnimation.AnimateToColor(Color.Beige);
        }

        private void btnProcess_MouseLeave(object sender, EventArgs e)
        {
            btnProcessAnimation.AnimateToColor(Color.BurlyWood);
        }
    }
}
