using AOLSE.Handler;
using AOLSE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLSE.Controller
{
    public class UserController
    {
        public static void CreateUser(String Username, String Email, String Password)
        {
            UserHandler.CreateUser(Username, Email, Password);
            return;
        }

        public static User FindUser(String Username, String Password)
        {
            //UserHandler
            return UserHandler.FindUser(Username, Password);
        }
    }
}