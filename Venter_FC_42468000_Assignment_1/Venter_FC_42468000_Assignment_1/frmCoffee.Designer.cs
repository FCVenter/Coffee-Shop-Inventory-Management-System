
namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    partial class frmCoffee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.nUpDownCoffee = new System.Windows.Forms.NumericUpDown();
            this.chkSyrup = new System.Windows.Forms.CheckBox();
            this.chkCream = new System.Windows.Forms.CheckBox();
            this.chkDouble = new System.Windows.Forms.CheckBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.cmbCoffeeType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAddons = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.rtbCoffee = new System.Windows.Forms.RichTextBox();
            this.lblAddonPrices = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblAddonPrices);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Controls.Add(this.nUpDownCoffee);
            this.panel1.Controls.Add(this.chkSyrup);
            this.panel1.Controls.Add(this.chkCream);
            this.panel1.Controls.Add(this.chkDouble);
            this.panel1.Controls.Add(this.rdoLarge);
            this.panel1.Controls.Add(this.rdoMedium);
            this.panel1.Controls.Add(this.rdoSmall);
            this.panel1.Controls.Add(this.cmbCoffeeType);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblAddons);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.lblCoffee);
            this.panel1.Location = new System.Drawing.Point(15, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 436);
            this.panel1.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(243, 317);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(242, 95);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            this.btnPlaceOrder.MouseEnter += new System.EventHandler(this.btnPlaceOrder_MouseEnter);
            this.btnPlaceOrder.MouseLeave += new System.EventHandler(this.btnPlaceOrder_MouseLeave);
            // 
            // nUpDownCoffee
            // 
            this.nUpDownCoffee.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownCoffee.Location = new System.Drawing.Point(602, 232);
            this.nUpDownCoffee.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownCoffee.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownCoffee.Name = "nUpDownCoffee";
            this.nUpDownCoffee.Size = new System.Drawing.Size(99, 47);
            this.nUpDownCoffee.TabIndex = 11;
            this.nUpDownCoffee.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkSyrup
            // 
            this.chkSyrup.AutoSize = true;
            this.chkSyrup.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSyrup.Location = new System.Drawing.Point(598, 165);
            this.chkSyrup.Name = "chkSyrup";
            this.chkSyrup.Size = new System.Drawing.Size(103, 38);
            this.chkSyrup.TabIndex = 10;
            this.chkSyrup.Text = "Syrup";
            this.chkSyrup.UseVisualStyleBackColor = true;
            // 
            // chkCream
            // 
            this.chkCream.AutoSize = true;
            this.chkCream.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCream.Location = new System.Drawing.Point(444, 165);
            this.chkCream.Name = "chkCream";
            this.chkCream.Size = new System.Drawing.Size(112, 38);
            this.chkCream.TabIndex = 9;
            this.chkCream.Text = "Cream";
            this.chkCream.UseVisualStyleBackColor = true;
            // 
            // chkDouble
            // 
            this.chkDouble.AutoSize = true;
            this.chkDouble.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDouble.Location = new System.Drawing.Point(326, 165);
            this.chkDouble.Name = "chkDouble";
            this.chkDouble.Size = new System.Drawing.Size(115, 38);
            this.chkDouble.TabIndex = 8;
            this.chkDouble.Text = "Double";
            this.chkDouble.UseVisualStyleBackColor = true;
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLarge.Location = new System.Drawing.Point(602, 93);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(107, 38);
            this.rdoLarge.TabIndex = 7;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedium.Location = new System.Drawing.Point(444, 93);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(126, 38);
            this.rdoMedium.TabIndex = 6;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmall.Location = new System.Drawing.Point(326, 93);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(97, 38);
            this.rdoSmall.TabIndex = 5;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            // 
            // cmbCoffeeType
            // 
            this.cmbCoffeeType.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoffeeType.FormattingEnabled = true;
            this.cmbCoffeeType.Location = new System.Drawing.Point(326, 22);
            this.cmbCoffeeType.Name = "cmbCoffeeType";
            this.cmbCoffeeType.Size = new System.Drawing.Size(375, 47);
            this.cmbCoffeeType.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(17, 242);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(178, 46);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblAddons
            // 
            this.lblAddons.AutoSize = true;
            this.lblAddons.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddons.Location = new System.Drawing.Point(17, 165);
            this.lblAddons.Name = "lblAddons";
            this.lblAddons.Size = new System.Drawing.Size(157, 46);
            this.lblAddons.TabIndex = 2;
            this.lblAddons.Text = "Add-ons:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(17, 93);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(98, 46);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size:";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffee.Location = new System.Drawing.Point(17, 20);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(248, 46);
            this.lblCoffee.TabIndex = 0;
            this.lblCoffee.Text = "Select Coffee:";
            // 
            // rtbCoffee
            // 
            this.rtbCoffee.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCoffee.Location = new System.Drawing.Point(15, 12);
            this.rtbCoffee.Name = "rtbCoffee";
            this.rtbCoffee.ReadOnly = true;
            this.rtbCoffee.Size = new System.Drawing.Size(494, 326);
            this.rtbCoffee.TabIndex = 1;
            this.rtbCoffee.TabStop = false;
            this.rtbCoffee.Text = "";
            // 
            // lblAddonPrices
            // 
            this.lblAddonPrices.AutoSize = true;
            this.lblAddonPrices.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddonPrices.Location = new System.Drawing.Point(351, 206);
            this.lblAddonPrices.Name = "lblAddonPrices";
            this.lblAddonPrices.Size = new System.Drawing.Size(294, 26);
            this.lblAddonPrices.TabIndex = 13;
            this.lblAddonPrices.Text = "R15            R5                    R7 ";
            // 
            // frmCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 824);
            this.Controls.Add(this.rtbCoffee);
            this.Controls.Add(this.panel1);
            this.Name = "frmCoffee";
            this.Text = "Coffee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCoffee_FormClosing);
            this.Load += new System.EventHandler(this.frmCoffee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCoffee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAddons;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.ComboBox cmbCoffeeType;
        private System.Windows.Forms.CheckBox chkDouble;
        private System.Windows.Forms.CheckBox chkSyrup;
        private System.Windows.Forms.CheckBox chkCream;
        private System.Windows.Forms.NumericUpDown nUpDownCoffee;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.RichTextBox rtbCoffee;
        private System.Windows.Forms.Label lblAddonPrices;
    }
}