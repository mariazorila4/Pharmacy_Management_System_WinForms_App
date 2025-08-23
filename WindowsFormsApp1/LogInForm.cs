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
            this.Hide();// hide this form
            SignUpForm frmS2 = new SignUpForm();// create a new instance of SignUpForm
            frmS2.FormClosed += FrmS2_FormClosed;// attach an event handler to the FormClosed event
            frmS2.Show();// show the SignUpForm
        }

        private void FrmS2_FormClosed(object sender, FormClosedEventArgs e)// SignUpForm closed event handler
        {
            this.Close();// close the current form (LogInForm)
        }

        //clear placeholder when email textbox is focused
        private void txtEmailAddress_Enter(object sender, EventArgs e)
        {
            if(txtEmailAddress.Text=="Email address")//if placeholder text is present
            {
                txtEmailAddress.Text = "";// clear the textbox
                txtEmailAddress.ForeColor = Color.DarkGreen;// change the text color to dark green
            }
        }

        //clear placeholder when password textbox is focused
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")// if placeholder text is present
            {
                txtPassword.Text = "";// clear the textbox
                txtPassword.ForeColor = Color.DarkGreen;// change the text color to dark green
            }
        }

        //restore placeholder if email textbox is left empty
        private void txtEmailAddress_Leave(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "")// if the textbox is empty
            {
                txtEmailAddress.Text = "Email address";// restore the placeholder text
                txtEmailAddress.ForeColor = Color.LightGray;// change the text color to light gray
            }
        }

        //restore placeholder if password textbox is left empty
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")// if the textbox is empty
            {
                txtPassword.Text = "Password";// restore the placeholder text
                txtPassword.ForeColor = Color.LightGray;// change the text color to light gray
            }
        }

        //if the user has an account, they are sent to the home page
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            HomePageForm frmH = new HomePageForm();// create a new instance of HomePageForm
            frmH.FormClosed += FrmH_FormClosed;// attach an event handler to the FormClosed event
            frmH.Show();// show the HomePageForm
        }

        private void FrmH_FormClosed(object sender, FormClosedEventArgs e)// HomePageForm closed event handler
        {
            this.Close();// close the current form (LogInForm)
        }
    }
}
