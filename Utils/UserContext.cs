using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06.Utils
{
    internal class UserContext
    {
        private User _user;

        private static UserContext _instance;

        public static UserContext GetInstance()
        {
            return _instance ?? (_instance = new UserContext());
        }

        public void SetUser(User user) => _user = user;
        public void RemoveUser() => _user = null;
        public User GetUser() => _user;
        public bool IsLoggedIn() => _user != null;
    }
}
