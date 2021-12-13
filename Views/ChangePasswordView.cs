using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice_06.Utils;

namespace Practice_06.Views
{
    public partial class ChangePasswordView : Form
    {
        public ChangePasswordView()
        {
            InitializeComponent();
        }

        private void TextBoxCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            this.ComparePassword();
        }

        private void TextBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            this.VerifyPassword();
        }

        private void TextBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            this.VerifyPassword();
        }

        private async void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            await this.ChangePassword();
        }
    }
}
