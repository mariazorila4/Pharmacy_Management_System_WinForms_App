namespace WindowsFormsApp1
{
    partial class SignUpForm
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
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.btnGoToLogIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmailAddress.Location = new System.Drawing.Point(251, 323);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(420, 22);
            this.txtEmailAddress.TabIndex = 4;
            this.txtEmailAddress.Text = "Email address";
            this.txtEmailAddress.Enter += new System.EventHandler(this.txtEmailAddress_Enter);
            this.txtEmailAddress.Leave += new System.EventHandler(this.txtEmailAddress_Leave);
            // 
            // btnGoToLogIn
            // 
            this.btnGoToLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.btnGoToLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.btnGoToLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLogIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoToLogIn.Location = new System.Drawing.Point(535, 0);
            this.btnGoToLogIn.Name = "btnGoToLogIn";
            this.btnGoToLogIn.Size = new System.Drawing.Size(86, 61);
            this.btnGoToLogIn.TabIndex = 0;
            this.btnGoToLogIn.Text = "Log in";
            this.btnGoToLogIn.UseVisualStyleBackColor = false;
            this.btnGoToLogIn.Click += new System.EventHandler(this.btnGoToLogIn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGoToLogIn);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 63);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(303, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Already have an account?";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPhoneNumber.Location = new System.Drawing.Point(251, 274);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(420, 22);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.Text = "Phone number";
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLastName.Location = new System.Drawing.Point(251, 230);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(420, 22);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Last name";
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(251, 369);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(420, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFirstName.Location = new System.Drawing.Point(251, 183);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(420, 22);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "First name";
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(229)))), ((int)(((byte)(149)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSignUp.Location = new System.Drawing.Point(412, 436);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(100, 75, 100, 75);
            this.btnSignUp.MaximumSize = new System.Drawing.Size(180, 108);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(116, 54);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(257, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 62);
            this.label2.TabIndex = 7;
            this.label2.Text = "Create an account";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(946, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmailAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Button btnGoToLogIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label2;
    }
}