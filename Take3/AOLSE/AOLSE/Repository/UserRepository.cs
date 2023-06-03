using AOLSE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLSE.Repository
{
    public class UserRepository
    {
        static MainDBEntities db = new MainDBEntities();
        //Insert / Register
        public static void CreateUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return;
        }
        // Login
        public static User FindUser(String Username, String Password)
        {
            //db.Users.Any(u => u.Username.Equals(Username) && u.Password.Equals(Password)) != null
            User user = (from data in db.Users where db.Users.Any(u => u.Username.Equals(Username) && u.Password.Equals(Password)) select data).FirstOrDefault();
            return user;
        }

        //Update
        //Delete
        //Get
    }
}