using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLab.Model;

namespace ProjectLab.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];

            if (cookie != null)
            {
                UserTextBox.Text = cookie.Values["Username"];
                PasswordTextBox.Text = cookie.Values["Password"];
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Database1Entities1 db = new Database1Entities1();

            String username = UserTextBox.Text;
            String password = PasswordTextBox.Text;

            User user = (from u in db.Users where u.Username.Equals(username) && u.Password.Equals(password) select u).FirstOrDefault();

            if(user == null)
            {
                ErrorLabel.Text = "User Not Found";
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                bool remember = RememberMeCheckBox.Checked;
                if (remember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Values["Username"] = username;
                    cookie.Values["Password"] = password;
                    cookie.Expires = DateTime.Now.AddMinutes(5);
                    Response.Cookies.Add(cookie);
                }

                Session["user_session"] = user;
                Session["IsUserOnline"] = true;
                Response.Redirect("Home.aspx");
                    

            }
        }
    }
}