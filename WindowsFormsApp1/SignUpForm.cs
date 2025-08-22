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
    public partial class SignUpForm: Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        //if the user already has an account, they are sent to the login page
        private void btnGoToLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm frmL2 = new LogInForm();
            frmL2.FormClosed += FrmL2_FormClosed;
            frmL2.Show();
        }

        private void FrmL2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //placeholder 
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if(txtFirstName.Text=="First name")
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.DarkGreen;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last name")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.DarkGreen;
            }
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "Phone number")
            {
                txtPhoneNumber.Text = "";
                txtPhoneNumber.ForeColor = Color.DarkGreen;
            }
        }

        private void txtEmailAddress_Enter(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "Email address")
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
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First name";
                txtFirstName.ForeColor = Color.LightGray;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last name";
                txtLastName.ForeColor = Color.LightGray;
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "")
            {
                txtPhoneNumber.Text = "Phone number";
                txtPhoneNumber.ForeColor = Color.LightGray;
            }
        }

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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm frmH1 = new HomePageForm();
            frmH1.FormClosed += FrmH_FormClosed;
            frmH1.Show();
        }

        private void FrmH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
