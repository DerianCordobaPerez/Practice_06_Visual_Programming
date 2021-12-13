using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_06.Views;
using System.Windows.Forms;

namespace Practice_06.Utils
{
    public static class ChangePasswordViewBuilder
    {
        private readonly static User _user = UserContext.GetInstance().GetUser();
        public static void ComparePassword<T>(this T form) where T : ChangePasswordView
        {
            var equals = form.TextBoxCurrentPassword.Text.Equals(_user.Password);

            form.TextBoxNewPassword.Enabled = equals;
            form.TextBoxConfirmPassword.Enabled = equals;
        }

        public static async Task ChangePassword<T>(this T form) where T : ChangePasswordView
        {
            var invoiceEntities = new InvoiceManagementEntities();
            var users = invoiceEntities.Users;

            var user = users.Where(item => item.UserName.Equals(_user.UserName)).FirstOrDefault();
            user.Password = form.TextBoxNewPassword.Text;
            await invoiceEntities.SaveChangesAsync();

            UserContext.GetInstance().SetUser(user);
            MessageBox.Show("Password updated successfully");
            form.Close();
        }

        public static void VerifyPassword<T>(this T form) where T : ChangePasswordView
        {
            var equals = form.TextBoxNewPassword.Text.Equals(form.TextBoxConfirmPassword.Text);
            form.ButtonChangePassword.Enabled = equals;
        }
    }
}
