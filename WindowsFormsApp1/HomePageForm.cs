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
    public partial class HomePageForm: Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.FormClosed += Frm1_FormClosed;
            frm1.Show();
        }

        private void Frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        
    }
}
