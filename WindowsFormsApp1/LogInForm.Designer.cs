namespace WindowsFormsApp1
{
    partial class LogInForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToSignUp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(297, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome back";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(229)))), ((int)(((byte)(149)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogIn.Location = new System.Drawing.Point(413, 437);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(100, 75, 100, 75);
            this.btnLogIn.MaximumSize = new System.Drawing.Size(180, 108);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(116, 54);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmailAddress.Location = new System.Drawing.Point(252, 184);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(420, 22);
            this.txtEmailAddress.TabIndex = 1;
            this.txtEmailAddress.Text = "Email address";
            this.txtEmailAddress.Enter += new System.EventHandler(this.txtEmailAddress_Enter);
            this.txtEmailAddress.Leave += new System.EventHandler(this.txtEmailAddress_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(252, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(420, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGoToSignUp);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(1, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 63);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(303, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btnGoToSignUp
            // 
            this.btnGoToSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.btnGoToSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.btnGoToSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToSignUp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoToSignUp.Location = new System.Drawing.Point(515, 3);
            this.btnGoToSignUp.Name = "btnGoToSignUp";
            this.btnGoToSignUp.Size = new System.Drawing.Size(98, 61);
            this.btnGoToSignUp.TabIndex = 0;
            this.btnGoToSignUp.Text = "Sign up";
            this.btnGoToSignUp.UseVisualStyleBackColor = false;
            this.btnGoToSignUp.Click += new System.EventHandler(this.btnGoToSignUp_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(946, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToSignUp;
    }
}