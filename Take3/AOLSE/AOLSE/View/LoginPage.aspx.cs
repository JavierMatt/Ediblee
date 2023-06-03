using AOLSE.Controller;
using AOLSE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLSE.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        static MainDBEntities db = new MainDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegButton_Click(object sender, EventArgs e)
        {
            //Kalo ngga ada username yg sm di database
            if (!(db.Users.Any(u => u.Username == UsernameTxt.Text)))
            {
                StatusLbl.Text = "User Not Found!";
            }
            //Kalo ada
            else
            {
                //Pw nya uda bener
                if(db.Users.Any(u => u.Password.Equals(Pw1.Text) && u.Username.Equals(UsernameTxt.Text)))
                {
                    StatusLbl.Text = "Logged on";
                    //UserController
                    String Username = UsernameTxt.Text;
                    String Password = Pw1.Text;
                    UserController.FindUser(Username, Password);
                }
                //Pw nya salah
                else
                {
                    StatusLbl.Text = "Password Incorrect!";
                }
            }
        }
    }
}