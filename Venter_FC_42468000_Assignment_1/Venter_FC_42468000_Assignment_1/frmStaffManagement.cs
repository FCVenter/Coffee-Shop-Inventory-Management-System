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
using Venter_FC_42468000_Assignment_1;

namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    public partial class frmStaffManagement : Form
    {

        private ControlAnimation btnBackAnimation;
        private ControlAnimation btnReportAnimation;
        private ControlAnimation btnShowInfoAnimation;
        private ControlAnimation btnUpdateAnimation;
        private ControlAnimation btnInsertAnimation;
        private ControlAnimation btnDeleteAnimation;

        private string selectedTableForDGV;
        private string selectedColumn;

        public frmStaffManagement()
        {
            InitializeComponent();
        }

        private void frmStaffManagement_Load(object sender, EventArgs e)
        {
            FormFormatting.initialiseForm(this);
            initialiseControls();
            SQL.displaySql("Select * FROM SaleItems", dgvFilter);
        }

        private void initialiseControls()
        {
            try
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", "ManagementBackground.jpeg");
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error: file not found: " + ioe.Message);
            }

            FormFormatting.SetControlsBackColor(new List<Control> { btnBack, btnReport, btnShowInfo, button1, btnUpdate, btnInsert, btnDelete }, Color.BurlyWood);
            FormFormatting.SetControlsForeColor(new List<Control> { rdoFood, rdoDrinkTypes, rdoFoodTypes, rdoSales, rdoSaleItems, rdoUsers, rdoUsers, rdoInventory, rdoRoles, rdoDrinks}, Color.White);

            btnBackAnimation = new ControlAnimation(btnBack);
            btnShowInfoAnimation = new ControlAnimation(btnShowInfo);
            btnReportAnimation = new ControlAnimation(btnReport);
            btnUpdateAnimation = new ControlAnimation(btnUpdate);
            btnInsertAnimation = new ControlAnimation(btnInsert);
            btnDeleteAnimation = new ControlAnimation(btnDelete);



            // Set the font for the entire DataGridView
            dgvFilter.DefaultCellStyle.Font = new Font("Times New Roman", 18f);

            // Set the font for the header cells
            dgvFilter.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18f);

            // Set the font for the row header cells (if visible)
            dgvFilter.RowHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18f);

            // Set the column auto-sizing mode
            dgvFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBackAnimation.AnimateToColor(Color.Beige);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBackAnimation.AnimateToColor(Color.BurlyWood);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
            if ( !(rdoAsc.Checked | rdoDesc.Checked ) )
            {
                MessageBox.Show("Please choose ascending or descending");
                return;
            }

            if (!(rdoTotalAmount.Checked | rdoSaleID.Checked | rdoDate.Checked))
            {
                MessageBox.Show("Please choose a column to sort by");
                return;
            }

            string orderString = rdoAsc.Checked ? "ASC" : "DESC";


            SQL.GenerateReport($"SELECT * FROM Sales ORDER BY {selectedColumn} {orderString}", rtxbReport);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(rdoDrinks.Checked || rdoDrinkTypes.Checked || rdoFood.Checked || rdoFoodTypes.Checked || rdoInventory.Checked || rdoRoles.Checked || rdoSaleItems.Checked || rdoSales.Checked || rdoUsers.Checked))
            {
                MessageBox.Show("Please select a table");
                return;
            }

            SQL.displaySql($"Select * FROM {selectedTableForDGV}", dgvFilter);
        }

        private void btnReport_MouseEnter(object sender, EventArgs e)
        {
            btnReportAnimation.AnimateToColor(Color.Beige);
        }

        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            btnReportAnimation.AnimateToColor(Color.BurlyWood);
        }

        private void btnShowInfo_MouseEnter(object sender, EventArgs e)
        {
            btnShowInfoAnimation.AnimateToColor(Color.Beige);
        }

        private void btnShowInfo_MouseLeave(object sender, EventArgs e)
        {
            btnShowInfoAnimation.AnimateToColor(Color.BurlyWood);
        }

        private void rdoDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDrinks.Checked)
                selectedTableForDGV = rdoDrinks.Text;
        }

        private void rdoFood_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFood.Checked)
                selectedTableForDGV = rdoFood.Text;
        }

        private void rdoDrinkTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDrinkTypes.Checked)
                selectedTableForDGV = rdoDrinkTypes.Text;
        }

        private void rdoFoodTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFoodTypes.Checked)
                selectedTableForDGV = rdoFoodTypes.Text;
        }

        private void rdoSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSales.Checked)
                selectedTableForDGV = rdoSales.Text;
        }

        private void rdoSaleItems_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSaleItems.Checked)
                selectedTableForDGV = rdoSaleItems.Text;
        }

        private void rdoUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUsers.Checked)
                selectedTableForDGV = rdoUsers.Text;
        }

        private void rdoRoles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRoles.Checked)
                selectedTableForDGV = rdoRoles.Text;
        }

        private void rdoInventory_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInventory.Checked)
                selectedTableForDGV = rdoInventory.Text;
        }

        private void rdoSaleID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSaleID.Checked)
                selectedColumn = "SaleID";
        }

        private void rdoTotalAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTotalAmount.Checked)
                selectedColumn = "TotalAmount";
        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDate.Checked)
                selectedColumn = "SaleDate";
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateAnimation.AnimateToColor(Color.Beige);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateAnimation.AnimateToColor(Color.BurlyWood);

        }

        private void btnInsert_MouseEnter(object sender, EventArgs e)
        {
            btnInsertAnimation.AnimateToColor(Color.Beige);
        }

        private void btnInsert_MouseLeave(object sender, EventArgs e)
        {
            btnInsertAnimation.AnimateToColor(Color.BurlyWood);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteAnimation.AnimateToColor(Color.Beige);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteAnimation.AnimateToColor(Color.BurlyWood);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmItemDetails itemDetailsForm = new frmItemDetails();

            itemDetailsForm.btnProcess.Text = "Update";

            itemDetailsForm.ShowDialog();  

            SQL.updateRecord($"UPDATE {itemDetailsForm.table} SET {itemDetailsForm.priceColumn} = '{itemDetailsForm.price}'");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmItemDetails itemDetailsForm = new frmItemDetails();

            itemDetailsForm.btnProcess.Text = "Insert";

            itemDetailsForm.ShowDialog();

            string IDColumn, nameColumn, typeIDColumn;

            if (itemDetailsForm.table == "Drinks")
            {
                IDColumn = "DrinkID";
                nameColumn = "DrinkName";
                typeIDColumn = "DrinkTypeID";
            }
            else
            {
                IDColumn = "FoodID";
                nameColumn = "FoodName";
                typeIDColumn = "FoodTypeID";
            }

            // ID is not autonumber, so add manually
            int ID = Convert.ToInt32(SQL.readSingleValue($"SELECT TOP 1 {IDColumn} FROM {itemDetailsForm.table} ORDER BY {IDColumn} DESC")) + 1;

            SQL.updateRecord($"INSERT INTO {itemDetailsForm.table} ({IDColumn}, {nameColumn}, {itemDetailsForm.priceColumn}, {typeIDColumn}) VALUES ({ID}, {itemDetailsForm.name}, {itemDetailsForm.price}, {itemDetailsForm.productID})");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmItemDetails itemDetailsForm = new frmItemDetails();

            itemDetailsForm.btnProcess.Text = "Delete";

            itemDetailsForm.ShowDialog();

            string IDColumn, nameColumn, typeIDColumn;


            if (itemDetailsForm.table == "Drinks")
            {
                IDColumn = "DrinkID";
                nameColumn = "DrinkName";
                typeIDColumn = "DrinkTypeID";
            }
            else
            {
                IDColumn = "FoodID";
                nameColumn = "FoodName";
                typeIDColumn = "FoodTypeID";
            }

            // Update method also made to support delete statements
            SQL.updateRecord($"DELETE FROM {itemDetailsForm.table} WHERE ({nameColumn} = {itemDetailsForm.name})");

        }
    }
}
