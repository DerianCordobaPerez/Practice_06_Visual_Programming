using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice_06.Views;
using Practice_06.Controllers;

namespace Practice_06.Utils
{
    public static class SignInViewBuilder
    {
        private static bool Success { get; set; }

        public static void SignInForm<T>(this T form) where T : SignInView
        {
            string username = form.TextBoxUserName.Text;
            string password = form.TextBoxPassword.Text;
            SignInController signInController = new SignInController();
            var user = signInController.SignIn(username, password);

            if (user != null)
            {
                MessageBox.Show("Session successfully started");
                UserContext.GetInstance().SetUser(user);
                Success = true;
                return;
            }

            MessageBox.Show("The username or password is incorrect");
            Success = false;
        }

        public static void BackgroundWorkerSignInStart<T>(this T form) where T : SignInView
        {
            if (form.BackgroundWorkerSingIn.IsBusy != true)
                form.BackgroundWorkerSingIn.RunWorkerAsync();
        }

        public static void BackgroundWorkerSignInDoWork<T>(this T form) where T : SignInView
        {
            SignInForm(form);
        }

        public static void ShowHideLabel<T>(this T form, object sender, Label label, int minimum) where T : SignInView
        {
            if (((TextBox)sender).Text.Length < minimum)
                label.Show();
            else
                label.Hide();
        }

        public static void EnabledButtonSignIn<T>(this T form) where T : SignInView
        {
            var enabled = form.TextBoxUserName.TextLength >= 2 && form.TextBoxPassword.TextLength >= 8;
            form.ButtonSignIn.Enabled = enabled;
        }

        public static void BackgroundWorkerSignInCompleted<T>(this T form) where T : SignInView
        {
            form.BackgroundWorkerSingIn.Dispose();
            if (Success)
                form.Dispose();
        }
    }
}
