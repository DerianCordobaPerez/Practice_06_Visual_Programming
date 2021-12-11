namespace Practice_06.Views
{
    partial class SignInView
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
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSignIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorLabelUserName = new System.Windows.Forms.Label();
            this.ErrorLabelPassword = new System.Windows.Forms.Label();
            this.BackgroundWorkerSingIn = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(71, 202);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(195, 20);
            this.TextBoxUserName.TabIndex = 0;
            this.TextBoxUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxUserName_KeyUp);
            this.TextBoxUserName.Leave += new System.EventHandler(this.TextBoxUserName_Leave);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(71, 251);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(195, 20);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyUp);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.BackColor = System.Drawing.Color.Navy;
            this.ButtonSignIn.Enabled = false;
            this.ButtonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignIn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonSignIn.Location = new System.Drawing.Point(11, 301);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.Size = new System.Drawing.Size(255, 40);
            this.ButtonSignIn.TabIndex = 4;
            this.ButtonSignIn.Text = "SignIn";
            this.ButtonSignIn.UseVisualStyleBackColor = false;
            this.ButtonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practice_06.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorLabelUserName
            // 
            this.ErrorLabelUserName.AutoSize = true;
            this.ErrorLabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabelUserName.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelUserName.Location = new System.Drawing.Point(4, 228);
            this.ErrorLabelUserName.Name = "ErrorLabelUserName";
            this.ErrorLabelUserName.Size = new System.Drawing.Size(260, 13);
            this.ErrorLabelUserName.TabIndex = 6;
            this.ErrorLabelUserName.Text = "Username must contain at least 2 characters";
            this.ErrorLabelUserName.Visible = false;
            // 
            // ErrorLabelPassword
            // 
            this.ErrorLabelPassword.AutoSize = true;
            this.ErrorLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabelPassword.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelPassword.Location = new System.Drawing.Point(4, 277);
            this.ErrorLabelPassword.Name = "ErrorLabelPassword";
            this.ErrorLabelPassword.Size = new System.Drawing.Size(262, 13);
            this.ErrorLabelPassword.TabIndex = 7;
            this.ErrorLabelPassword.Text = "Password must contain at least 8 characters ";
            this.ErrorLabelPassword.Visible = false;
            // 
            // BackgroundWorkerSingIn
            // 
            this.BackgroundWorkerSingIn.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerSingIn_DoWork);
            this.BackgroundWorkerSingIn.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerSingIn_RunWorkerCompleted);
            // 
            // SignInView
            // 
            this.AcceptButton = this.ButtonSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 346);
            this.Controls.Add(this.ErrorLabelPassword);
            this.Controls.Add(this.ErrorLabelUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonSignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.MaximizeBox = false;
            this.Name = "SignInView";
            this.Text = "SignIn with your credentials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignInView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextBoxUserName;
        public System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button ButtonSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ErrorLabelUserName;
        private System.Windows.Forms.Label ErrorLabelPassword;
        public System.ComponentModel.BackgroundWorker BackgroundWorkerSingIn;
    }
}