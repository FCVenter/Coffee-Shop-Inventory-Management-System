namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    partial class frmMain
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblMainFormHeading = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(490, 318);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(242, 95);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place An Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            this.btnPlaceOrder.MouseEnter += new System.EventHandler(this.btnPlaceOrder_MouseEnter);
            this.btnPlaceOrder.MouseLeave += new System.EventHandler(this.btnPlaceOrder_MouseLeave);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(1337, 12);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(170, 64);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "Exit";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            this.btnCloseForm.MouseEnter += new System.EventHandler(this.btnCloseForm_MouseEnter);
            this.btnCloseForm.MouseLeave += new System.EventHandler(this.btnCloseForm_MouseLeave);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblMainFormHeading);
            this.pnlLogin.Controls.Add(this.btnStaff);
            this.pnlLogin.Controls.Add(this.btnPlaceOrder);
            this.pnlLogin.Controls.Add(this.btnCloseForm);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1519, 882);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // lblMainFormHeading
            // 
            this.lblMainFormHeading.AutoSize = true;
            this.lblMainFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblMainFormHeading.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainFormHeading.ForeColor = System.Drawing.Color.Black;
            this.lblMainFormHeading.Location = new System.Drawing.Point(21, 27);
            this.lblMainFormHeading.Name = "lblMainFormHeading";
            this.lblMainFormHeading.Size = new System.Drawing.Size(655, 79);
            this.lblMainFormHeading.TabIndex = 3;
            this.lblMainFormHeading.Text = "Welcome to BeelteCaf!";
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(770, 318);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(242, 95);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Staff Login";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            this.btnStaff.MouseEnter += new System.EventHandler(this.btnStaff_MouseEnter);
            this.btnStaff.MouseLeave += new System.EventHandler(this.btnStaff_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 882);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmMain";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label lblMainFormHeading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

