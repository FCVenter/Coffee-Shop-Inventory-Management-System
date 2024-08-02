
namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    partial class frmTea
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
            this.nUpDownTea = new System.Windows.Forms.NumericUpDown();
            this.chkMilk = new System.Windows.Forms.CheckBox();
            this.chkLemon = new System.Windows.Forms.CheckBox();
            this.chkHoney = new System.Windows.Forms.CheckBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.cmbTeaType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAddons = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTeaType = new System.Windows.Forms.Label();
            this.rtbTea = new System.Windows.Forms.RichTextBox();
            this.lblAddonPrices = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownTea)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblAddonPrices);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Controls.Add(this.nUpDownTea);
            this.panel1.Controls.Add(this.chkMilk);
            this.panel1.Controls.Add(this.chkLemon);
            this.panel1.Controls.Add(this.chkHoney);
            this.panel1.Controls.Add(this.rdoLarge);
            this.panel1.Controls.Add(this.rdoMedium);
            this.panel1.Controls.Add(this.rdoSmall);
            this.panel1.Controls.Add(this.cmbTeaType);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblAddons);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.lblTeaType);
            this.panel1.Location = new System.Drawing.Point(21, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 438);
            this.panel1.TabIndex = 1;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(237, 340);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(242, 95);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            this.btnPlaceOrder.MouseEnter += new System.EventHandler(this.btnPlaceOrder_MouseEnter);
            this.btnPlaceOrder.MouseLeave += new System.EventHandler(this.btnPlaceOrder_MouseLeave);
            // 
            // nUpDownTea
            // 
            this.nUpDownTea.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownTea.Location = new System.Drawing.Point(610, 343);
            this.nUpDownTea.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownTea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownTea.Name = "nUpDownTea";
            this.nUpDownTea.Size = new System.Drawing.Size(99, 47);
            this.nUpDownTea.TabIndex = 11;
            this.nUpDownTea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkMilk
            // 
            this.chkMilk.AutoSize = true;
            this.chkMilk.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMilk.Location = new System.Drawing.Point(610, 183);
            this.chkMilk.Name = "chkMilk";
            this.chkMilk.Size = new System.Drawing.Size(84, 38);
            this.chkMilk.TabIndex = 10;
            this.chkMilk.Text = "Milk";
            this.chkMilk.UseVisualStyleBackColor = true;
            // 
            // chkLemon
            // 
            this.chkLemon.AutoSize = true;
            this.chkLemon.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLemon.Location = new System.Drawing.Point(458, 183);
            this.chkLemon.Name = "chkLemon";
            this.chkLemon.Size = new System.Drawing.Size(112, 38);
            this.chkLemon.TabIndex = 9;
            this.chkLemon.Text = "Lemon";
            this.chkLemon.UseVisualStyleBackColor = true;
            // 
            // chkHoney
            // 
            this.chkHoney.AutoSize = true;
            this.chkHoney.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHoney.Location = new System.Drawing.Point(326, 183);
            this.chkHoney.Name = "chkHoney";
            this.chkHoney.Size = new System.Drawing.Size(105, 38);
            this.chkHoney.TabIndex = 8;
            this.chkHoney.Text = "Honey";
            this.chkHoney.UseVisualStyleBackColor = true;
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLarge.Location = new System.Drawing.Point(610, 108);
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
            this.rdoMedium.Location = new System.Drawing.Point(458, 108);
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
            this.rdoSmall.Location = new System.Drawing.Point(326, 108);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(97, 38);
            this.rdoSmall.TabIndex = 5;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            // 
            // cmbTeaType
            // 
            this.cmbTeaType.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeaType.FormattingEnabled = true;
            this.cmbTeaType.Location = new System.Drawing.Point(326, 32);
            this.cmbTeaType.Name = "cmbTeaType";
            this.cmbTeaType.Size = new System.Drawing.Size(375, 47);
            this.cmbTeaType.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(17, 269);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(178, 46);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblAddons
            // 
            this.lblAddons.AutoSize = true;
            this.lblAddons.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddons.Location = new System.Drawing.Point(17, 183);
            this.lblAddons.Name = "lblAddons";
            this.lblAddons.Size = new System.Drawing.Size(157, 46);
            this.lblAddons.TabIndex = 2;
            this.lblAddons.Text = "Add-ons:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(17, 100);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(98, 46);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size:";
            // 
            // lblTeaType
            // 
            this.lblTeaType.AutoSize = true;
            this.lblTeaType.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeaType.Location = new System.Drawing.Point(17, 30);
            this.lblTeaType.Name = "lblTeaType";
            this.lblTeaType.Size = new System.Drawing.Size(206, 46);
            this.lblTeaType.TabIndex = 0;
            this.lblTeaType.Text = "Select Tea:";
            // 
            // rtbTea
            // 
            this.rtbTea.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTea.Location = new System.Drawing.Point(46, 23);
            this.rtbTea.Name = "rtbTea";
            this.rtbTea.ReadOnly = true;
            this.rtbTea.Size = new System.Drawing.Size(494, 326);
            this.rtbTea.TabIndex = 2;
            this.rtbTea.TabStop = false;
            this.rtbTea.Text = "";
            // 
            // lblAddonPrices
            // 
            this.lblAddonPrices.AutoSize = true;
            this.lblAddonPrices.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddonPrices.Location = new System.Drawing.Point(360, 224);
            this.lblAddonPrices.Name = "lblAddonPrices";
            this.lblAddonPrices.Size = new System.Drawing.Size(284, 26);
            this.lblAddonPrices.TabIndex = 14;
            this.lblAddonPrices.Text = "R8            R5                    R2\r\n";
            this.lblAddonPrices.Click += new System.EventHandler(this.lblAddonPrices_Click);
            // 
            // frmTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 818);
            this.Controls.Add(this.rtbTea);
            this.Controls.Add(this.panel1);
            this.Name = "frmTea";
            this.Text = "Tea";
            this.Load += new System.EventHandler(this.frmTea_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownTea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.NumericUpDown nUpDownTea;
        private System.Windows.Forms.CheckBox chkMilk;
        private System.Windows.Forms.CheckBox chkLemon;
        private System.Windows.Forms.CheckBox chkHoney;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.ComboBox cmbTeaType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAddons;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTeaType;
        private System.Windows.Forms.RichTextBox rtbTea;
        private System.Windows.Forms.Label lblAddonPrices;
    }
}