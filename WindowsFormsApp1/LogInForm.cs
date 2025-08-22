using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogInForm: Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        //if the user doesn't have an account, they are sent to the sign up page
        private void btnGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm frmS2 = new SignUpForm();
            frmS2.FormClosed += FrmS2_FormClosed;
            frmS2.Show();
        }

        private void FrmS2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //placeholder
        private void txtEmailAddress_Enter(object sender, EventArgs e)
        {
            if(txtEmailAddress.Text=="Email address")
            {
                txtEmailAddress.Text = "";
                txtEmailAddress.ForeColor = Color.DarkGreen;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.DarkGreen;
            }
        }

        //empty textbox
        private void txtEmailAddress_Leave(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "")
            {
                txtEmailAddress.Text = "Email address";
                txtEmailAddress.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm frmH = new HomePageForm();
            frmH.FormClosed += FrmH_FormClosed;
            frmH.Show();
        }

        private void FrmH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
