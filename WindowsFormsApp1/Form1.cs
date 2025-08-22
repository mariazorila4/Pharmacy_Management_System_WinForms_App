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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm frmL = new LogInForm();
            frmL.FormClosed += FrmL_FormClosed;
            frmL.Show();
        }

        private void FrmL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm frmS = new SignUpForm();
            frmS.FormClosed += FrmS_FormClosed;
            frmS.Show();
        }

        private void FrmS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
