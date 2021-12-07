using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06.Controllers
{
    internal class SignInController
    {
        private readonly InvoiceManagementEntities _invoiceManagementEntities = new InvoiceManagementEntities();

        public User SignIn(string username, string password)
        {
            var users = _invoiceManagementEntities.Users;
            var exists = users
                .AsQueryable()
                .Where(user => user.UserName.CompareTo(username) == 0)
                .Where(user => user.Password.CompareTo(password) == 0)
                .FirstOrDefault();
            
            return exists;
        }
    }
}
