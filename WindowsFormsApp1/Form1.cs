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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
           


            this.Load += (s, e) => {
                btnLogIn.Dock = DockStyle.Fill;
                btnSignUp.Dock = DockStyle.Fill;
              
            };
        }

        //if the user has an account, they are sent to the login page
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();//hide this form
            LogInForm frmL = new LogInForm();//create a new instance of LogInForm
            frmL.FormClosed += FrmL_FormClosed;// attach an event handler to the FormClosed event
            frmL.Show();// show the LogInForm
        }

        private void FrmL_FormClosed(object sender, FormClosedEventArgs e)//LogInForm closed event handler
        {
            this.Close();// close the current form (Form1)
        }

        //if the user doesn't have an account, they are sent to the sign up page
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            SignUpForm frmS = new SignUpForm();// create a new instance of SignUpForm
            frmS.FormClosed += FrmS_FormClosed;// attach an event handler to the FormClosed event
            frmS.Show();// show the SignUpForm
        }

        private void FrmS_FormClosed(object sender, FormClosedEventArgs e)// SignUpForm closed event handler
        {
            this.Close();// close the current form (Form1)
        }
    }
}
