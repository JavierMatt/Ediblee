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
    public partial class RegisterPage : System.Web.UI.Page
    {
        static MainDBEntities db = new MainDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegButton_Click(object sender, EventArgs e)
        {
            if (Pw1.Text != Pw2.Text)
            {
                StatusLbl.Text = "Password is not the same!";
            }
            else if (!EmailTxt.Text.Contains("@gmail.com"))
            {
                StatusLbl.Text = "Email Must have @gmail.com!";
            }
            else if(db.Users.Any(u => u.Username == UsernameTxt.Text))
            {
                StatusLbl.Text = "Username already exist!";
            }
            else if (EmailTxt.Text.Contains("@gmail.com") && Pw1.Text == Pw2.Text && !(db.Users.Any(u => u.Username == UsernameTxt.Text)))
            {
                String Username = UsernameTxt.Text;
                String Password = Pw1.Text;
                String Email = EmailTxt.Text;
                UserController.CreateUser(Username, Email, Password);

                StatusLbl.Text = "User has been created!";
            }
        }
    }
}