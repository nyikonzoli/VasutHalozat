using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VasuthalozatCommonLibrary.Repository;
using VasuthalozatCommonLibrary.Model;


namespace VasuthalozatCommonLibrary.Authentication
{
    class Authenticator
    {
        private static UserDbContext userContext = UserDbContext.Instance;
        public User LoggedInUser { get; set; }

        private static Authenticator authenticator;
        public static Authenticator Instance
        {
            get
            {
                if (authenticator == null) authenticator = new Authenticator();
                return authenticator;
            }
        }

        private Authenticator()
        {

        }
    }
}
