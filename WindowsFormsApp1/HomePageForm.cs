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

        //log out button
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            Form1 frm1 = new Form1();// create a new instance of Form1
            frm1.FormClosed += Frm1_FormClosed;// attach an event handler to the FormClosed event
            frm1.Show();// show the Form1
        }

        private void Frm1_FormClosed(object sender, FormClosedEventArgs e)// Form1 closed event handler
        {
            this.Close();// close the current form (HomePageForm)
        }

        //medicines button
        private void btnMedicines_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            MedicinesForm frmM = new MedicinesForm();// create a new instance of MedicinesForm
            frmM.FormClosed += FrmM_FormClosed;// attach an event handler to the FormClosed event
            frmM.Show();// show the MedicinesForm
        }

        private void FrmM_FormClosed(object sender, FormClosedEventArgs e)// MedicinesForm closed event handler
        {
            this.Close();// close the current form (HomePageForm)
        }

        //effects button
        private void btnEffects_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            EffectsForm frmE = new EffectsForm();// create a new instance of EffectsForm
            frmE.FormClosed += FrmE_FormClosed;// attach an event handler to the FormClosed event
            frmE.Show();// show the EffectsForm
        }

        private void FrmE_FormClosed(object sender, FormClosedEventArgs e)// EffectsForm closed event handler
        {
            this.Close();// close the current form (HomePageForm)
        }

        //pharmacies button
        private void btnPharmacies_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            PharmaciesForm frmP = new PharmaciesForm();// create a new instance of PharmaciesForm
            frmP.FormClosed += FrmP_FormClosed;// attach an event handler to the FormClosed event
            frmP.Show();// show the PharmaciesForm
        }

        private void FrmP_FormClosed(object sender, FormClosedEventArgs e)// PharmaciesForm closed event handler
        {
            this.Close();// close the current form (HomePageForm)
        }

        //suppliers button
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            SuppliersForm frmS = new SuppliersForm();// create a new instance of SuppliersForm
            frmS.FormClosed += FrmS_FormClosed;// attach an event handler to the FormClosed event
            frmS.Show();// show the SuppliersForm
        }

        private void FrmS_FormClosed(object sender, FormClosedEventArgs e)// SuppliersForm closed event handler
        {
            this.Close();// close the current form (HomePageForm)
        }

        //orders and items button
        private void btnOrdersAndItems_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            OrdersAndItemsForm frmOI = new OrdersAndItemsForm();// create a new instance of OrdersAndItemsForm
            frmOI.FormClosed += FrmOI_FormClosed;// attach an event handler to the FormClosed event
            frmOI.Show();// show the OrdersAndItemsForm
        }

        private void FrmOI_FormClosed(object sender, FormClosedEventArgs e)// OrdersAndItemsForm closed event handler
        {
            this.Close();// close the current form (HomePageForm)
        }

        //doctors button
        private void btnDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            DoctorsForm frmD = new DoctorsForm();// create a new instance of DoctorsForm
            frmD.FormClosed += FrmD_FormClosed;// attach an event handler to the FormClosed event
            frmD.Show();// show the DoctorsForm
        }

        private void FrmD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();// close the current form (HomePageForm)
        }

        //patients button
        private void btnPatients_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            PatientsForm frmPa = new PatientsForm();// create a new instance of PatientsForm
            frmPa.FormClosed += FrmPa_FormClosed;// attach an event handler to the FormClosed event
            frmPa.Show();// show the PatientsForm
        }

        private void FrmPa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();// close the current form (HomePageForm)
        }

        //prescriptions button
        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            this.Hide();// hide this form
            PrescriptionsForm frmPr = new PrescriptionsForm();// create a new instance of PrescriptionsForm
            frmPr.FormClosed += FrmPr_FormClosed;// attach an event handler to the FormClosed event
            frmPr.Show();// show the PrescriptionsForm
        }

        private void FrmPr_FormClosed(object sender, FormClosedEventArgs e)// PrescriptionsForm closed event handler
        {
            this.Close();// close the current form (HomePageForm)
        }
    }
}
