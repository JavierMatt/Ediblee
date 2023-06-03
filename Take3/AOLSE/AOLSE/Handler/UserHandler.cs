using AOLSE.Factory;
using AOLSE.Model;
using AOLSE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLSE.Handler
{
    public class UserHandler
    {
        public static void CreateUser(String Username, String Email, String Password)
        {
            User user = UserFactory.CreateUser(Username, Email, Password);
            UserRepository.CreateUser(user);
            return;
        }

        public static User FindUser(String Username, String Password)
        {
            //Panggil Repos
            return UserRepository.FindUser(Username, Password);
        }
    }
}