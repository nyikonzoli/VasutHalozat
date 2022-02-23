using VasuthalozatCommonLibrary.Repository;
using VasuthalozatCommonLibrary.Exceptions;
using VasuthalozatCommonLibrary.Model;
using System.Linq;

namespace VasuthalozatPublicApplication.Controllers
{
    class RegisterController
    {
        private UserDbContext userContext = UserDbContext.Instance;

        public void Register(string name, string email, string username, string password1, string password2)
        {
            if (password1 != password2) throw new VasuthalozatException("Nem egyezik a két jelszó!");
            if (userContext.Users.FirstOrDefault(user => user.Email == email || user.UserName == username) != null)
            {
                throw new VasuthalozatException("Már létezik felhasználó ilyen névvel vagy email címmel!");
            }
            userContext.Add(new User(name, username, email, BCrypt.Net.BCrypt.HashPassword(password1), Role.User));
            userContext.SaveChanges();
        }

    }
}
