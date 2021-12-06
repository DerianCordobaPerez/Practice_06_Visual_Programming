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
using Practice_06.Controllers;

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

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            this.SignInForm();
        }
    }
}
