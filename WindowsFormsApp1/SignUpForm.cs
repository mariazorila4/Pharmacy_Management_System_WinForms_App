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
            this.Hide();// hide this form
            LogInForm frmL2 = new LogInForm();// create a new instance of LogInForm
            frmL2.FormClosed += FrmL2_FormClosed;// attach an event handler to the FormClosed event
            frmL2.Show();// show the LogInForm
        }

        private void FrmL2_FormClosed(object sender, FormClosedEventArgs e)// LogInForm closed event handler
        {
            this.Close();// close the current form (SignUpForm)
        }

        //clear placeholder when first name textbox is focused
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if(txtFirstName.Text=="First name")//if placeholder text is present
            {
                txtFirstName.Text = "";// clear the textbox
                txtFirstName.ForeColor = Color.DarkGreen;// change the text color to dark green
            }
        }

        //clear placeholder when last name textbox is focused
        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last name")//if placeholder text is present
            {
                txtLastName.Text = "";// clear the textbox
                txtLastName.ForeColor = Color.DarkGreen;// change the text color to dark green
            }
        }

        //clear placeholder when phone number textbox is focused
        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "Phone number")//if placeholder text is present
            {
                txtPhoneNumber.Text = "";// clear the textbox
                txtPhoneNumber.ForeColor = Color.DarkGreen;// change the text color to dark green
            }
        }

        //clear placeholder when email address textbox is focused
        private void txtEmailAddress_Enter(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "Email address")//if placeholder text is present
            {
                txtEmailAddress.Text = "";// clear the textbox
                txtEmailAddress.ForeColor = Color.DarkGreen;// change the text color to dark green
            }
        }

        //clear placeholder when password textbox is focused
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")//if placeholder text is present
            {
                txtPassword.Text = "";// clear the textbox
                txtPassword.ForeColor = Color.DarkGreen;// change the text color to dark green
            }
        }

        //restore placeholder if first name textbox is left empty
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")// if the textbox is empty
            {
                txtFirstName.Text = "First name";// restore the placeholder text
                txtFirstName.ForeColor = Color.LightGray;// change the text color to light gray
            }
        }

        //restore placeholder if last name textbox is left empty
        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")// if the textbox is empty
            {
                txtLastName.Text = "Last name";// restore the placeholder text
                txtLastName.ForeColor = Color.LightGray;// change the text color to light gray
            }
        }

        //restore placeholder if phone number textbox is left empty
        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "")// if the textbox is empty
            {
                txtPhoneNumber.Text = "Phone number";// restore the placeholder text
                txtPhoneNumber.ForeColor = Color.LightGray;// change the text color to light gray
            }
        }

        //restore placeholder if email address textbox is left empty
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

        //create the account and send the user to the home page
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            HomePageForm frmH1 = new HomePageForm();// create a new instance of HomePageForm
            frmH1.FormClosed += FrmH_FormClosed;// attach an event handler to the FormClosed event
            frmH1.Show();// show the HomePageForm
        }

        private void FrmH_FormClosed(object sender, FormClosedEventArgs e)// HomePageForm closed event handler
        {
            this.Close();// close the current form (SignUpForm)
        }
    }
}
