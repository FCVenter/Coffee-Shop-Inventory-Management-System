
namespace Venter_FC_42468000_Assignment_1
{
    partial class frmItemDetails
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
            this.lblTeaType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoCoffee = new System.Windows.Forms.RadioButton();
            this.rdoTea = new System.Windows.Forms.RadioButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.rdoPastry = new System.Windows.Forms.RadioButton();
            this.rdoSandwich = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeaType
            // 
            this.lblTeaType.AutoSize = true;
            this.lblTeaType.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeaType.Location = new System.Drawing.Point(12, 49);
            this.lblTeaType.Name = "lblTeaType";
            this.lblTeaType.Size = new System.Drawing.Size(228, 46);
            this.lblTeaType.TabIndex = 1;
            this.lblTeaType.Text = "Item Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(12, 143);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(213, 46);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Item Price:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoSandwich);
            this.panel1.Controls.Add(this.rdoPastry);
            this.panel1.Controls.Add(this.rdoTea);
            this.panel1.Controls.Add(this.rdoCoffee);
            this.panel1.Location = new System.Drawing.Point(20, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 100);
            this.panel1.TabIndex = 4;
            // 
            // rdoCoffee
            // 
            this.rdoCoffee.AutoSize = true;
            this.rdoCoffee.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCoffee.Location = new System.Drawing.Point(15, 34);
            this.rdoCoffee.Name = "rdoCoffee";
            this.rdoCoffee.Size = new System.Drawing.Size(114, 38);
            this.rdoCoffee.TabIndex = 12;
            this.rdoCoffee.Text = "Coffee";
            this.rdoCoffee.UseVisualStyleBackColor = true;
            this.rdoCoffee.CheckedChanged += new System.EventHandler(this.rdoCoffee_CheckedChanged);
            // 
            // rdoTea
            // 
            this.rdoTea.AutoSize = true;
            this.rdoTea.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTea.Location = new System.Drawing.Point(147, 34);
            this.rdoTea.Name = "rdoTea";
            this.rdoTea.Size = new System.Drawing.Size(82, 38);
            this.rdoTea.TabIndex = 13;
            this.rdoTea.Text = "Tea";
            this.rdoTea.UseVisualStyleBackColor = true;
            this.rdoTea.CheckedChanged += new System.EventHandler(this.rdoTea_CheckedChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(20, 375);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(190, 90);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            this.btnProcess.MouseEnter += new System.EventHandler(this.btnProcess_MouseEnter);
            this.btnProcess.MouseLeave += new System.EventHandler(this.btnProcess_MouseLeave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(280, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 40);
            this.txtName.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(280, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(242, 40);
            this.txtPrice.TabIndex = 17;
            // 
            // rdoPastry
            // 
            this.rdoPastry.AutoSize = true;
            this.rdoPastry.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPastry.Location = new System.Drawing.Point(249, 34);
            this.rdoPastry.Name = "rdoPastry";
            this.rdoPastry.Size = new System.Drawing.Size(115, 38);
            this.rdoPastry.TabIndex = 14;
            this.rdoPastry.Text = "Pastry";
            this.rdoPastry.UseVisualStyleBackColor = true;
            this.rdoPastry.CheckedChanged += new System.EventHandler(this.rdoPastry_CheckedChanged);
            // 
            // rdoSandwich
            // 
            this.rdoSandwich.AutoSize = true;
            this.rdoSandwich.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSandwich.Location = new System.Drawing.Point(386, 34);
            this.rdoSandwich.Name = "rdoSandwich";
            this.rdoSandwich.Size = new System.Drawing.Size(145, 38);
            this.rdoSandwich.TabIndex = 15;
            this.rdoSandwich.Text = "Sandwich";
            this.rdoSandwich.UseVisualStyleBackColor = true;
            this.rdoSandwich.CheckedChanged += new System.EventHandler(this.rdoSandwich_CheckedChanged);
            // 
            // frmItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 581);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTeaType);
            this.Name = "frmItemDetails";
            this.Text = "frmItemDetails";
            this.Load += new System.EventHandler(this.frmItemDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeaType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoTea;
        private System.Windows.Forms.RadioButton rdoCoffee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.RadioButton rdoSandwich;
        private System.Windows.Forms.RadioButton rdoPastry;
        public System.Windows.Forms.Button btnProcess;
    }
}