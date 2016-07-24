using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _24200_ClassDemo
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            TicketUser myUser = new TicketUser();
            myUser.FirstName = firstName.Text;
            myUser.LastName = lastName.Text;
            myUser.UserName = userName.Text;

            
            lblOutput.Text = myUser.CreateAccount().ToString();
            //myUser.ToString();
        }
    }
}