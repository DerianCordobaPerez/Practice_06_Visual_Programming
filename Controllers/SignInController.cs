using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_06.Utils;

namespace Practice_06.Controllers
{
    internal class SignInController
    {
        private readonly InvoiceManagementEntities _invoiceManagementEntities = new InvoiceManagementEntities();

        public User SignIn(string username, string password)
        {
            var users = _invoiceManagementEntities.Users;
            var exists = users
                .Where(user => String.Compare(user.UserName, username, StringComparison.Ordinal) == 0)
                .FirstOrDefault(user => String.Compare(user.Password, password, StringComparison.Ordinal) == 0);
            
            return exists;
        }
        
        public void Logout()
        {
            UserContext.GetInstance().RemoveUser();
        }
    }
}
