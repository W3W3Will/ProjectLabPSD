using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLab.Model;
using ProjectLab.Repository;

namespace ProjectLab.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve gender options from the database or generate in code
                List<string> genderOptions = new List<string> { "Male", "Female" };

                // Bind the gender options to the dropdown list
                GenderDropDownList.DataSource = genderOptions;
                GenderDropDownList.DataBind();
            }

        }


        protected void CustomValidatorEmail_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string email = EmailTextBox.Text;

            if (!email.EndsWith(".com"))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string username = UserRegisterTextBox.Text;

            bool isValid = (username.Length >= 5 && username.Length <= 15) && System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z\\s]+$");

            args.IsValid = isValid;
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();
            User u = repo.addUser(UserRegisterTextBox.Text,
                EmailTextBox.Text,
                GenderDropDownList.SelectedValue,
                PasswordRegisterTextBox.Text);

            Response.Redirect("Login.aspx");
        }
    }
}