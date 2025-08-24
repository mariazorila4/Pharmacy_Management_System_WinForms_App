namespace WindowsFormsApp1
{
    partial class MedicinesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.txtGenericName = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(449, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(829, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 54);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnHomePage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnHomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(229)))), ((int)(((byte)(149)))));
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHomePage.Location = new System.Drawing.Point(-1, 0);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(123, 54);
            this.btnHomePage.TabIndex = 11;
            this.btnHomePage.Text = "Home page";
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAddMedicine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAddMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAddMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddMedicine.Location = new System.Drawing.Point(659, 521);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(117, 54);
            this.btnAddMedicine.TabIndex = 13;
            this.btnAddMedicine.Text = "Add";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            // 
            // txtGenericName
            // 
            this.txtGenericName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGenericName.Location = new System.Drawing.Point(502, 91);
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.Size = new System.Drawing.Size(420, 22);
            this.txtGenericName.TabIndex = 14;
            this.txtGenericName.Text = "Generic name";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtManufacturer.Location = new System.Drawing.Point(502, 277);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(420, 22);
            this.txtManufacturer.TabIndex = 18;
            this.txtManufacturer.Text = "Manufacturer";
            // 
            // txtBrandName
            // 
            this.txtBrandName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBrandName.Location = new System.Drawing.Point(502, 138);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(420, 22);
            this.txtBrandName.TabIndex = 15;
            this.txtBrandName.Text = "Brand name";
            // 
            // txtDosage
            // 
            this.txtDosage.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDosage.Location = new System.Drawing.Point(502, 182);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(420, 22);
            this.txtDosage.TabIndex = 16;
            this.txtDosage.Text = "Dosage";
            // 
            // txtForm
            // 
            this.txtForm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtForm.Location = new System.Drawing.Point(502, 231);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(420, 22);
            this.txtForm.TabIndex = 17;
            this.txtForm.Text = "Form";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtExpirationDate.Location = new System.Drawing.Point(502, 317);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(420, 22);
            this.txtExpirationDate.TabIndex = 19;
            this.txtExpirationDate.Text = "Expiration date";
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuantityInStock.Location = new System.Drawing.Point(502, 364);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(420, 22);
            this.txtQuantityInStock.TabIndex = 20;
            this.txtQuantityInStock.Text = "Quantity in stock";
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrice.Location = new System.Drawing.Point(502, 408);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(420, 22);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.Text = "Price";
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(502, 457);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(420, 22);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "Effect ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(69)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(386, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 54);
            this.label1.TabIndex = 23;
            this.label1.Text = "Medicines";
            // 
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(946, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpirationDate);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtGenericName);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.txtForm);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.listView1);
            this.Name = "MedicinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicinesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.TextBox txtGenericName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
    }
}