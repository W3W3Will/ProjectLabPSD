using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLab.Model;

namespace ProjectLab
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnHome.Visible = false;
            btnHistory.Visible = false;
            btnManage.Visible = false;
            btnProfile.Visible = false;
            btnOrderQueue.Visible = false;
            btnReport.Visible = false;
            btnOrderRamen.Visible = false;
            btnLogout.Visible = false;
            

            Database1Entities1 db = new Database1Entities1();
            if(Session["user_session"] != null)
            {
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnProfile.Visible = true;
                btnLogout.Visible = true;

                if (((User)Session["user_session"]).Roleid == 0)
                {
                    btnOrderRamen.Visible = true;
                    btnHistory.Visible = true;
                }
                else if (((User)Session["user_session"]).Roleid == 1)
                {
                    btnHome.Visible = true;
                    btnOrderQueue.Visible = true;
                    btnManage.Visible = true;
                }
                else if (((User)Session["user_session"]).Roleid == 2)
                {
                    btnManage.Visible = true;
                    btnOrderQueue.Visible = true;
                    btnHistory.Visible = true;
                    btnReport.Visible = true;
                }
            }

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnManage_Click(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnOrderRamen_Click(object sender, EventArgs e)
        {

        }

        protected void btnOrderQueue_Click(object sender, EventArgs e)
        {

        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {

        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {

        }

        protected void btnReport_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}