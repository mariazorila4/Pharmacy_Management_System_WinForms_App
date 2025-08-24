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
    public partial class PatientsForm: Form
    {
        public PatientsForm()
        {
            InitializeComponent();
        }

        // back button to go to HomePageForm
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide this form
            HomePageForm frmH = new HomePageForm(); // create a new instance of HomePageForm
            frmH.FormClosed += FrmH_FormClosed; // attach an event handler to the FormClosed event
            frmH.Show(); // show the HomePageForm
        }

        private void FrmH_FormClosed(object sender, FormClosedEventArgs e)// HomePageForm closed event handler
        {
            this.Close(); // close the current form (PatientsForm)
        }
    }
}
