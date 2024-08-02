
namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    partial class frmStaffManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoSaleID = new System.Windows.Forms.RadioButton();
            this.rdoTotalAmount = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoAsc = new System.Windows.Forms.RadioButton();
            this.rdoDesc = new System.Windows.Forms.RadioButton();
            this.lblColumn = new System.Windows.Forms.Label();
            this.pnlShowInfo = new System.Windows.Forms.Panel();
            this.rdoInventory = new System.Windows.Forms.RadioButton();
            this.rdoRoles = new System.Windows.Forms.RadioButton();
            this.rdoUsers = new System.Windows.Forms.RadioButton();
            this.rdoSaleItems = new System.Windows.Forms.RadioButton();
            this.rdoSales = new System.Windows.Forms.RadioButton();
            this.rdoFoodTypes = new System.Windows.Forms.RadioButton();
            this.rdoDrinkTypes = new System.Windows.Forms.RadioButton();
            this.rdoFood = new System.Windows.Forms.RadioButton();
            this.rdoDrinks = new System.Windows.Forms.RadioButton();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.rtxbReport = new System.Windows.Forms.RichTextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.lblStaffManagementHeading = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlShowInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Controls.Add(this.pnlShowInfo);
            this.pnlLogin.Controls.Add(this.rtxbReport);
            this.pnlLogin.Controls.Add(this.btnReport);
            this.pnlLogin.Controls.Add(this.button1);
            this.pnlLogin.Controls.Add(this.dgvFilter);
            this.pnlLogin.Controls.Add(this.lblStaffManagementHeading);
            this.pnlLogin.Controls.Add(this.btnBack);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(2353, 1037);
            this.pnlLogin.TabIndex = 3;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblColumn);
            this.panel1.Location = new System.Drawing.Point(870, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 401);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoDate);
            this.panel3.Controls.Add(this.rdoSaleID);
            this.panel3.Controls.Add(this.rdoTotalAmount);
            this.panel3.Location = new System.Drawing.Point(11, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 174);
            this.panel3.TabIndex = 22;
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDate.Location = new System.Drawing.Point(24, 105);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(95, 38);
            this.rdoDate.TabIndex = 22;
            this.rdoDate.Text = "Date";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdoDate_CheckedChanged);
            // 
            // rdoSaleID
            // 
            this.rdoSaleID.AutoSize = true;
            this.rdoSaleID.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSaleID.Location = new System.Drawing.Point(24, 33);
            this.rdoSaleID.Name = "rdoSaleID";
            this.rdoSaleID.Size = new System.Drawing.Size(122, 38);
            this.rdoSaleID.TabIndex = 20;
            this.rdoSaleID.Text = "SaleID";
            this.rdoSaleID.UseVisualStyleBackColor = true;
            this.rdoSaleID.CheckedChanged += new System.EventHandler(this.rdoSaleID_CheckedChanged);
            // 
            // rdoTotalAmount
            // 
            this.rdoTotalAmount.AutoSize = true;
            this.rdoTotalAmount.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTotalAmount.Location = new System.Drawing.Point(200, 33);
            this.rdoTotalAmount.Name = "rdoTotalAmount";
            this.rdoTotalAmount.Size = new System.Drawing.Size(194, 38);
            this.rdoTotalAmount.TabIndex = 21;
            this.rdoTotalAmount.Text = "TotalAmount";
            this.rdoTotalAmount.UseVisualStyleBackColor = true;
            this.rdoTotalAmount.CheckedChanged += new System.EventHandler(this.rdoTotalAmount_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoAsc);
            this.panel2.Controls.Add(this.rdoDesc);
            this.panel2.Location = new System.Drawing.Point(11, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 100);
            this.panel2.TabIndex = 12;
            // 
            // rdoAsc
            // 
            this.rdoAsc.AutoSize = true;
            this.rdoAsc.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAsc.Location = new System.Drawing.Point(24, 33);
            this.rdoAsc.Name = "rdoAsc";
            this.rdoAsc.Size = new System.Drawing.Size(152, 38);
            this.rdoAsc.TabIndex = 20;
            this.rdoAsc.Text = "Ascending";
            this.rdoAsc.UseVisualStyleBackColor = true;
            // 
            // rdoDesc
            // 
            this.rdoDesc.AutoSize = true;
            this.rdoDesc.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDesc.Location = new System.Drawing.Point(200, 33);
            this.rdoDesc.Name = "rdoDesc";
            this.rdoDesc.Size = new System.Drawing.Size(167, 38);
            this.rdoDesc.TabIndex = 21;
            this.rdoDesc.Text = "Descending";
            this.rdoDesc.UseVisualStyleBackColor = true;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.Location = new System.Drawing.Point(16, 28);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(245, 36);
            this.lblColumn.TabIndex = 22;
            this.lblColumn.Text = "Sort according to:";
            // 
            // pnlShowInfo
            // 
            this.pnlShowInfo.Controls.Add(this.btnDelete);
            this.pnlShowInfo.Controls.Add(this.btnInsert);
            this.pnlShowInfo.Controls.Add(this.btnUpdate);
            this.pnlShowInfo.Controls.Add(this.rdoInventory);
            this.pnlShowInfo.Controls.Add(this.rdoRoles);
            this.pnlShowInfo.Controls.Add(this.rdoUsers);
            this.pnlShowInfo.Controls.Add(this.rdoSaleItems);
            this.pnlShowInfo.Controls.Add(this.rdoSales);
            this.pnlShowInfo.Controls.Add(this.rdoFoodTypes);
            this.pnlShowInfo.Controls.Add(this.rdoDrinkTypes);
            this.pnlShowInfo.Controls.Add(this.rdoFood);
            this.pnlShowInfo.Controls.Add(this.rdoDrinks);
            this.pnlShowInfo.Controls.Add(this.btnShowInfo);
            this.pnlShowInfo.Location = new System.Drawing.Point(1360, 593);
            this.pnlShowInfo.Name = "pnlShowInfo";
            this.pnlShowInfo.Size = new System.Drawing.Size(990, 308);
            this.pnlShowInfo.TabIndex = 10;
            // 
            // rdoInventory
            // 
            this.rdoInventory.AutoSize = true;
            this.rdoInventory.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInventory.Location = new System.Drawing.Point(534, 225);
            this.rdoInventory.Name = "rdoInventory";
            this.rdoInventory.Size = new System.Drawing.Size(158, 38);
            this.rdoInventory.TabIndex = 19;
            this.rdoInventory.Text = "Inventory";
            this.rdoInventory.UseVisualStyleBackColor = true;
            this.rdoInventory.CheckedChanged += new System.EventHandler(this.rdoInventory_CheckedChanged);
            // 
            // rdoRoles
            // 
            this.rdoRoles.AutoSize = true;
            this.rdoRoles.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRoles.Location = new System.Drawing.Point(381, 225);
            this.rdoRoles.Name = "rdoRoles";
            this.rdoRoles.Size = new System.Drawing.Size(97, 38);
            this.rdoRoles.TabIndex = 18;
            this.rdoRoles.Text = "Roles";
            this.rdoRoles.UseVisualStyleBackColor = true;
            this.rdoRoles.CheckedChanged += new System.EventHandler(this.rdoRoles_CheckedChanged);
            // 
            // rdoUsers
            // 
            this.rdoUsers.AutoSize = true;
            this.rdoUsers.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUsers.Location = new System.Drawing.Point(225, 225);
            this.rdoUsers.Name = "rdoUsers";
            this.rdoUsers.Size = new System.Drawing.Size(103, 38);
            this.rdoUsers.TabIndex = 17;
            this.rdoUsers.Text = "Users";
            this.rdoUsers.UseVisualStyleBackColor = true;
            this.rdoUsers.CheckedChanged += new System.EventHandler(this.rdoUsers_CheckedChanged);
            // 
            // rdoSaleItems
            // 
            this.rdoSaleItems.AutoSize = true;
            this.rdoSaleItems.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSaleItems.Location = new System.Drawing.Point(20, 225);
            this.rdoSaleItems.Name = "rdoSaleItems";
            this.rdoSaleItems.Size = new System.Drawing.Size(165, 38);
            this.rdoSaleItems.TabIndex = 16;
            this.rdoSaleItems.Text = "SaleItems";
            this.rdoSaleItems.UseVisualStyleBackColor = true;
            this.rdoSaleItems.CheckedChanged += new System.EventHandler(this.rdoSaleItems_CheckedChanged);
            // 
            // rdoSales
            // 
            this.rdoSales.AutoSize = true;
            this.rdoSales.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSales.Location = new System.Drawing.Point(626, 135);
            this.rdoSales.Name = "rdoSales";
            this.rdoSales.Size = new System.Drawing.Size(97, 38);
            this.rdoSales.TabIndex = 15;
            this.rdoSales.Text = "Sales";
            this.rdoSales.UseVisualStyleBackColor = true;
            this.rdoSales.CheckedChanged += new System.EventHandler(this.rdoSales_CheckedChanged);
            // 
            // rdoFoodTypes
            // 
            this.rdoFoodTypes.AutoSize = true;
            this.rdoFoodTypes.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFoodTypes.Location = new System.Drawing.Point(442, 135);
            this.rdoFoodTypes.Name = "rdoFoodTypes";
            this.rdoFoodTypes.Size = new System.Drawing.Size(164, 38);
            this.rdoFoodTypes.TabIndex = 14;
            this.rdoFoodTypes.Text = "FoodTypes";
            this.rdoFoodTypes.UseVisualStyleBackColor = true;
            this.rdoFoodTypes.CheckedChanged += new System.EventHandler(this.rdoFoodTypes_CheckedChanged);
            // 
            // rdoDrinkTypes
            // 
            this.rdoDrinkTypes.AutoSize = true;
            this.rdoDrinkTypes.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDrinkTypes.Location = new System.Drawing.Point(257, 135);
            this.rdoDrinkTypes.Name = "rdoDrinkTypes";
            this.rdoDrinkTypes.Size = new System.Drawing.Size(172, 38);
            this.rdoDrinkTypes.TabIndex = 13;
            this.rdoDrinkTypes.Text = "DrinkTypes";
            this.rdoDrinkTypes.UseVisualStyleBackColor = true;
            this.rdoDrinkTypes.CheckedChanged += new System.EventHandler(this.rdoDrinkTypes_CheckedChanged);
            // 
            // rdoFood
            // 
            this.rdoFood.AutoSize = true;
            this.rdoFood.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFood.Location = new System.Drawing.Point(146, 135);
            this.rdoFood.Name = "rdoFood";
            this.rdoFood.Size = new System.Drawing.Size(90, 38);
            this.rdoFood.TabIndex = 12;
            this.rdoFood.Text = "Food";
            this.rdoFood.UseVisualStyleBackColor = true;
            this.rdoFood.CheckedChanged += new System.EventHandler(this.rdoFood_CheckedChanged);
            // 
            // rdoDrinks
            // 
            this.rdoDrinks.AutoSize = true;
            this.rdoDrinks.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDrinks.Location = new System.Drawing.Point(20, 135);
            this.rdoDrinks.Name = "rdoDrinks";
            this.rdoDrinks.Size = new System.Drawing.Size(111, 38);
            this.rdoDrinks.TabIndex = 11;
            this.rdoDrinks.Text = "Drinks";
            this.rdoDrinks.UseVisualStyleBackColor = true;
            this.rdoDrinks.CheckedChanged += new System.EventHandler(this.rdoDrinks_CheckedChanged);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(20, 22);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(190, 90);
            this.btnShowInfo.TabIndex = 9;
            this.btnShowInfo.Text = "Show all info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.button2_Click);
            this.btnShowInfo.MouseEnter += new System.EventHandler(this.btnShowInfo_MouseEnter);
            this.btnShowInfo.MouseLeave += new System.EventHandler(this.btnShowInfo_MouseLeave);
            // 
            // rtxbReport
            // 
            this.rtxbReport.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbReport.Location = new System.Drawing.Point(35, 153);
            this.rtxbReport.Name = "rtxbReport";
            this.rtxbReport.Size = new System.Drawing.Size(806, 826);
            this.rtxbReport.TabIndex = 8;
            this.rtxbReport.Text = "";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(892, 578);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(190, 90);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Generate Sales Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            this.btnReport.MouseEnter += new System.EventHandler(this.btnReport_MouseEnter);
            this.btnReport.MouseLeave += new System.EventHandler(this.btnReport_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1144, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvFilter
            // 
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Location = new System.Drawing.Point(1360, 153);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.Size = new System.Drawing.Size(981, 386);
            this.dgvFilter.TabIndex = 4;
            // 
            // lblStaffManagementHeading
            // 
            this.lblStaffManagementHeading.AutoSize = true;
            this.lblStaffManagementHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffManagementHeading.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffManagementHeading.ForeColor = System.Drawing.Color.Black;
            this.lblStaffManagementHeading.Location = new System.Drawing.Point(21, 27);
            this.lblStaffManagementHeading.Name = "lblStaffManagementHeading";
            this.lblStaffManagementHeading.Size = new System.Drawing.Size(591, 79);
            this.lblStaffManagementHeading.TabIndex = 3;
            this.lblStaffManagementHeading.Text = "Staff Management:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(2183, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 64);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(239, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 90);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update Items";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(462, 22);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(190, 90);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert Items";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseEnter += new System.EventHandler(this.btnInsert_MouseEnter);
            this.btnInsert.MouseLeave += new System.EventHandler(this.btnInsert_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(688, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 90);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Items";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // frmStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2353, 1037);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmStaffManagement";
            this.Text = "frmStaffManagement";
            this.Load += new System.EventHandler(this.frmStaffManagement_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlShowInfo.ResumeLayout(false);
            this.pnlShowInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblStaffManagementHeading;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvFilter;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxbReport;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Panel pnlShowInfo;
        private System.Windows.Forms.RadioButton rdoInventory;
        private System.Windows.Forms.RadioButton rdoRoles;
        private System.Windows.Forms.RadioButton rdoUsers;
        private System.Windows.Forms.RadioButton rdoSaleItems;
        private System.Windows.Forms.RadioButton rdoSales;
        private System.Windows.Forms.RadioButton rdoFoodTypes;
        private System.Windows.Forms.RadioButton rdoDrinkTypes;
        private System.Windows.Forms.RadioButton rdoFood;
        private System.Windows.Forms.RadioButton rdoDrinks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoDesc;
        private System.Windows.Forms.RadioButton rdoAsc;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoSaleID;
        private System.Windows.Forms.RadioButton rdoTotalAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
    }
}