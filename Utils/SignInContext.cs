using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06.Utils
{
    public class SignInContext
    {
        public bool Context { get; set; }

        private static SignInContext instance;

        public static SignInContext GetInstance()
        {
            if (instance == null)
                instance = new SignInContext();
            return instance;
        }
    }
}
