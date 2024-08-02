
namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    partial class frmClientOrder
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
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandwichesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCustomerData = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.mStrip.SuspendLayout();
            this.pnlCustomerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(1523, 24);
            this.mStrip.TabIndex = 1;
            this.mStrip.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.backToolStripMenuItem.Text = "Options";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem1.Text = "Back";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coffeeToolStripMenuItem,
            this.teaToolStripMenuItem,
            this.pastriesToolStripMenuItem,
            this.sandwichesToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // coffeeToolStripMenuItem
            // 
            this.coffeeToolStripMenuItem.Name = "coffeeToolStripMenuItem";
            this.coffeeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.coffeeToolStripMenuItem.Text = "Coffee";
            this.coffeeToolStripMenuItem.Click += new System.EventHandler(this.coffeeToolStripMenuItem_Click);
            // 
            // teaToolStripMenuItem
            // 
            this.teaToolStripMenuItem.Name = "teaToolStripMenuItem";
            this.teaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.teaToolStripMenuItem.Text = "Tea";
            this.teaToolStripMenuItem.Click += new System.EventHandler(this.teaToolStripMenuItem_Click);
            // 
            // pastriesToolStripMenuItem
            // 
            this.pastriesToolStripMenuItem.Name = "pastriesToolStripMenuItem";
            this.pastriesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pastriesToolStripMenuItem.Text = "Pastries";
            this.pastriesToolStripMenuItem.Click += new System.EventHandler(this.pastriesToolStripMenuItem_Click);
            // 
            // sandwichesToolStripMenuItem
            // 
            this.sandwichesToolStripMenuItem.Name = "sandwichesToolStripMenuItem";
            this.sandwichesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sandwichesToolStripMenuItem.Text = "Sandwiches";
            this.sandwichesToolStripMenuItem.Click += new System.EventHandler(this.sandwichesToolStripMenuItem_Click);
            // 
            // pnlCustomerData
            // 
            this.pnlCustomerData.BackColor = System.Drawing.Color.Tan;
            this.pnlCustomerData.Controls.Add(this.btnSubmit);
            this.pnlCustomerData.Controls.Add(this.txtEmail);
            this.pnlCustomerData.Controls.Add(this.lblEmail);
            this.pnlCustomerData.Controls.Add(this.lblUsername);
            this.pnlCustomerData.Controls.Add(this.txtName);
            this.pnlCustomerData.Controls.Add(this.lblHeading);
            this.pnlCustomerData.Location = new System.Drawing.Point(21, 154);
            this.pnlCustomerData.Name = "pnlCustomerData";
            this.pnlCustomerData.Size = new System.Drawing.Size(756, 327);
            this.pnlCustomerData.TabIndex = 3;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(20, 19);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(564, 78);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Before you order:\r\nWould you mind providing your details?";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(207, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 40);
            this.txtName.TabIndex = 16;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(19, 138);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 46);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(19, 243);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(119, 46);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(207, 243);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 40);
            this.txtEmail.TabIndex = 19;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(491, 159);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(242, 95);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmClientOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 901);
            this.Controls.Add(this.pnlCustomerData);
            this.Controls.Add(this.mStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStrip;
            this.Name = "frmClientOrder";
            this.Text = "frmClientOrder";
            this.Load += new System.EventHandler(this.frmClientOrder_Load);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.pnlCustomerData.ResumeLayout(false);
            this.pnlCustomerData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coffeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sandwichesToolStripMenuItem;
        public System.Windows.Forms.Panel pnlCustomerData;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSubmit;
    }
}