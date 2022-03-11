using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VasuthalozatCommonLibrary.Model;

namespace VasuthalozatCommonLibrary.Authentication
{
    interface IAuthenticator
    {
        public delegate void LogoutDelegate();
        public event LogoutDelegate LogoutEvent;
        public User Authenticate(string username, string password);
        public void Logout();
    }
}
