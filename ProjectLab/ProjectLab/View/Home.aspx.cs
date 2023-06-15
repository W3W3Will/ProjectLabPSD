using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLab.Model;

namespace ProjectLab.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserListBox.Visible = false;
            //OnlineUserCountLabel.Visible = false;

            if (Session["user_session"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Database1Entities1 db = new Database1Entities1();

            EmailLabelHome.Text = ((User)Session["user_session"]).Email;

            if(((User)Session["user_session"]).Roleid >= 1)
            {
                UserListBox.Visible = true;
                //OnlineUserCountLabel.Visible = true;
                List<User> users = (db.Users).ToList();

                foreach(User u in users)
                {
                    if(u.Roleid > ((User)Session["user_session"]).Roleid)
                    {
                        String userlistinfo = u.Username + "-" + u.Email;
                        UserListBox.Items.Add(userlistinfo);
                    }
                    
                }
            }
        }

        protected void LofOutHome_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}