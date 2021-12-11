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
    public partial class SignInView : Form
    {
        public SignInView()
        {
            InitializeComponent();
        }

        private void SignInView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ClosingForm(e);
        }

        private void TextBoxUserName_Leave(object sender, EventArgs e)
        {
            this.ShowHideLabel(sender, ErrorLabelUserName, 2);
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            this.ShowHideLabel(sender, ErrorLabelPassword, 8);
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            this.BackgroundWorkerSignInStart();
        }

        private void BackgroundWorkerSingIn_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BackgroundWorkerSignInDoWork();
        }

        private void BackgroundWorkerSingIn_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.BackgroundWorkerSignInCompleted();   
        }

        private void TextBoxUserName_KeyUp(object sender, KeyEventArgs e)
        {
            this.EnabledButtonSignIn();
        }

        private void TextBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            this.EnabledButtonSignIn();
        }
    }
}
