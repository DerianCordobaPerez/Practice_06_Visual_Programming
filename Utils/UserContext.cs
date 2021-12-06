using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06.Utils
{
    internal class UserContext
    {
        private User User;

        private static UserContext instance;

        public static UserContext GetInstance()
        {
            if (instance == null)
                instance = new UserContext();
            return instance;
        }

        public void SetUser(User user) => User = user;
        public void RemoveUser() => User = null;
        public User GetUser() => User;
        public bool IsLoggedIn() => User != null;
        

    }
}
