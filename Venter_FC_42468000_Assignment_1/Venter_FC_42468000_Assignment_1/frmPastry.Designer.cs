
namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    partial class frmPastry
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
            this.nUpDownPastry = new System.Windows.Forms.NumericUpDown();
            this.cmbPastryType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPastryType = new System.Windows.Forms.Label();
            this.rtbPastry = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPastry)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Controls.Add(this.nUpDownPastry);
            this.panel1.Controls.Add(this.cmbPastryType);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblPastryType);
            this.panel1.Location = new System.Drawing.Point(12, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 369);
            this.panel1.TabIndex = 2;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(236, 259);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(242, 95);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            this.btnPlaceOrder.MouseEnter += new System.EventHandler(this.btnPlaceOrder_MouseEnter);
            this.btnPlaceOrder.MouseLeave += new System.EventHandler(this.btnPlaceOrder_MouseLeave);
            // 
            // nUpDownPastry
            // 
            this.nUpDownPastry.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownPastry.Location = new System.Drawing.Point(602, 171);
            this.nUpDownPastry.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownPastry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownPastry.Name = "nUpDownPastry";
            this.nUpDownPastry.Size = new System.Drawing.Size(99, 47);
            this.nUpDownPastry.TabIndex = 11;
            this.nUpDownPastry.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbPastryType
            // 
            this.cmbPastryType.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPastryType.FormattingEnabled = true;
            this.cmbPastryType.Location = new System.Drawing.Point(326, 57);
            this.cmbPastryType.Name = "cmbPastryType";
            this.cmbPastryType.Size = new System.Drawing.Size(375, 47);
            this.cmbPastryType.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(17, 168);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(178, 46);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPastryType
            // 
            this.lblPastryType.AutoSize = true;
            this.lblPastryType.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastryType.Location = new System.Drawing.Point(17, 60);
            this.lblPastryType.Name = "lblPastryType";
            this.lblPastryType.Size = new System.Drawing.Size(252, 46);
            this.lblPastryType.TabIndex = 0;
            this.lblPastryType.Text = "Select Pastry:";
            // 
            // rtbPastry
            // 
            this.rtbPastry.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPastry.Location = new System.Drawing.Point(37, 31);
            this.rtbPastry.Name = "rtbPastry";
            this.rtbPastry.ReadOnly = true;
            this.rtbPastry.Size = new System.Drawing.Size(305, 326);
            this.rtbPastry.TabIndex = 3;
            this.rtbPastry.TabStop = false;
            this.rtbPastry.Text = "";
            // 
            // frmPastry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 786);
            this.Controls.Add(this.rtbPastry);
            this.Controls.Add(this.panel1);
            this.Name = "frmPastry";
            this.Text = "Pastry";
            this.Load += new System.EventHandler(this.frmPastry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPastry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPastryType;
        public System.Windows.Forms.NumericUpDown nUpDownPastry;
        public System.Windows.Forms.ComboBox cmbPastryType;
        private System.Windows.Forms.RichTextBox rtbPastry;
    }
}