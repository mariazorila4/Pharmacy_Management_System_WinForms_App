namespace WindowsFormsApp1
{
    partial class EffectsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEffectID = new System.Windows.Forms.TextBox();
            this.txtEffectName = new System.Windows.Forms.TextBox();
            this.btnAddEffect = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(420, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Effects";
            // 
            // txtEffectID
            // 
            this.txtEffectID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEffectID.Location = new System.Drawing.Point(503, 151);
            this.txtEffectID.Name = "txtEffectID";
            this.txtEffectID.Size = new System.Drawing.Size(420, 22);
            this.txtEffectID.TabIndex = 1;
            this.txtEffectID.Text = "ID";
            // 
            // txtEffectName
            // 
            this.txtEffectName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEffectName.Location = new System.Drawing.Point(503, 198);
            this.txtEffectName.Name = "txtEffectName";
            this.txtEffectName.Size = new System.Drawing.Size(420, 22);
            this.txtEffectName.TabIndex = 2;
            this.txtEffectName.Text = "Name";
            // 
            // btnAddEffect
            // 
            this.btnAddEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnAddEffect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnAddEffect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.btnAddEffect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(174)))), ((int)(((byte)(66)))));
            this.btnAddEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEffect.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddEffect.Location = new System.Drawing.Point(661, 275);
            this.btnAddEffect.Margin = new System.Windows.Forms.Padding(101, 75, 101, 75);
            this.btnAddEffect.MaximumSize = new System.Drawing.Size(181, 108);
            this.btnAddEffect.Name = "btnAddEffect";
            this.btnAddEffect.Size = new System.Drawing.Size(117, 54);
            this.btnAddEffect.TabIndex = 3;
            this.btnAddEffect.Text = "Add";
            this.btnAddEffect.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(229)))), ((int)(((byte)(149)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(829, -1);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(101, 75, 101, 75);
            this.btnHelp.MaximumSize = new System.Drawing.Size(181, 108);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 54);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnHomePage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnHomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHomePage.Location = new System.Drawing.Point(-1, -1);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(123, 54);
            this.btnHomePage.TabIndex = 5;
            this.btnHomePage.Text = "Home page";
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(449, 388);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EffectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(946, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEffectID);
            this.Controls.Add(this.txtEffectName);
            this.Controls.Add(this.btnAddEffect);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.listView1);
            this.Name = "EffectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EffectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEffectID;
        private System.Windows.Forms.TextBox txtEffectName;
        private System.Windows.Forms.Button btnAddEffect;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.ListView listView1;
    }
}