namespace Practice_06.Views
{
    partial class ChangePasswordView
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
            this.TextBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.ButtonChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current password";
            // 
            // TextBoxCurrentPassword
            // 
            this.TextBoxCurrentPassword.Location = new System.Drawing.Point(131, 13);
            this.TextBoxCurrentPassword.Name = "TextBoxCurrentPassword";
            this.TextBoxCurrentPassword.PasswordChar = '*';
            this.TextBoxCurrentPassword.Size = new System.Drawing.Size(232, 20);
            this.TextBoxCurrentPassword.TabIndex = 1;
            this.TextBoxCurrentPassword.TextChanged += new System.EventHandler(this.TextBoxCurrentPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "New password";
            // 
            // TextBoxNewPassword
            // 
            this.TextBoxNewPassword.Enabled = false;
            this.TextBoxNewPassword.Location = new System.Drawing.Point(131, 52);
            this.TextBoxNewPassword.Name = "TextBoxNewPassword";
            this.TextBoxNewPassword.PasswordChar = '*';
            this.TextBoxNewPassword.Size = new System.Drawing.Size(232, 20);
            this.TextBoxNewPassword.TabIndex = 3;
            this.TextBoxNewPassword.TextChanged += new System.EventHandler(this.TextBoxNewPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm password";
            // 
            // TextBoxConfirmPassword
            // 
            this.TextBoxConfirmPassword.Enabled = false;
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(131, 93);
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.PasswordChar = '*';
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(232, 20);
            this.TextBoxConfirmPassword.TabIndex = 5;
            this.TextBoxConfirmPassword.TextChanged += new System.EventHandler(this.TextBoxConfirmPassword_TextChanged);
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.BackColor = System.Drawing.Color.Navy;
            this.ButtonChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChangePassword.Enabled = false;
            this.ButtonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChangePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonChangePassword.Location = new System.Drawing.Point(16, 130);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(347, 50);
            this.ButtonChangePassword.TabIndex = 6;
            this.ButtonChangePassword.Text = "Change password";
            this.ButtonChangePassword.UseVisualStyleBackColor = false;
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // ChangePasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 192);
            this.Controls.Add(this.ButtonChangePassword);
            this.Controls.Add(this.TextBoxConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxCurrentPassword);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordView";
            this.Text = "ChangePasswordView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TextBoxCurrentPassword;
        public System.Windows.Forms.TextBox TextBoxNewPassword;
        public System.Windows.Forms.TextBox TextBoxConfirmPassword;
        public System.Windows.Forms.Button ButtonChangePassword;
    }
}