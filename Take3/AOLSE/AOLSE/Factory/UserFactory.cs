using AOLSE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLSE.Factory
{
    public class UserFactory
    {
        public static User CreateUser(String Username, String Email, String Password)
        {
            User user = new User();
            user.Username = Username;
            user.Email = Email;
            user.Password = Password;
            return user;
        }
    }
}