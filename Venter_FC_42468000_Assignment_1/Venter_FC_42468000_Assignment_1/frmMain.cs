using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Venter FC 42468000_
 Motara Yaaseen 40925846
  */

namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
	public partial class frmMain : Form
	{

		private ControlAnimation btnExitAnimation;
		private ControlAnimation btnPlaceOrderAnimation;
		private ControlAnimation btnStaffAnimation;

		public frmMain()
		{
			InitializeComponent();
		}

		private void btnPlaceOrder_Click(object sender, EventArgs e)
		{
			frmClientOrder ClientOrderForm = new frmClientOrder();
			ClientOrderForm.Show();
		}

		private void initialiseControls()
		{
            try
            {
				pnlLogin.Dock = DockStyle.Fill;
				string imagePath = Path.Combine(Application.StartupPath, "Images", "MainBackGround.jpeg");
				pnlLogin.BackgroundImage = Image.FromFile(imagePath);
				pnlLogin.BackgroundImageLayout = ImageLayout.Stretch;
            }
			catch (FileNotFoundException fnfe)
            {
				MessageBox.Show("Error: file not found: " + fnfe.Message);
            }

			FormFormatting.SetControlsBackColor(new List<Control> {btnCloseForm, btnPlaceOrder, btnStaff }, Color.BurlyWood);

			btnExitAnimation = new ControlAnimation(btnCloseForm);
			btnPlaceOrderAnimation = new ControlAnimation(btnPlaceOrder);
			btnStaffAnimation = new ControlAnimation(btnStaff);

			lblMainFormHeading.ForeColor = Color.Beige;
			
		}


		private void frmMain_Load(object sender, EventArgs e)
		{
			FormFormatting.initialiseForm(this);
			initialiseControls();
		}

		private void btnCloseForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCloseForm_MouseEnter(object sender, EventArgs e)
		{
			btnExitAnimation.AnimateToColor(Color.Beige);
		}

		private void btnCloseForm_MouseLeave(object sender, EventArgs e)
		{
			btnExitAnimation.AnimateToColor(Color.BurlyWood);
		}

        private void btnPlaceOrder_MouseEnter(object sender, EventArgs e)
        {
			btnPlaceOrderAnimation.AnimateToColor(Color.Beige);
        }

        private void btnPlaceOrder_MouseLeave(object sender, EventArgs e)
        {
			btnPlaceOrderAnimation.AnimateToColor(Color.BurlyWood);
		}

        private void btnStaff_MouseEnter(object sender, EventArgs e)
        {
			btnStaffAnimation.AnimateToColor(Color.Beige);
		}

		private void btnStaff_MouseLeave(object sender, EventArgs e)
        {
			btnStaffAnimation.AnimateToColor(Color.BurlyWood);
		}

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
			frmStaffLogin LoginForm = new frmStaffLogin();
			LoginForm.Show();
        }
    }
}
