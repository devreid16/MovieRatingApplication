using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterSample
{
    public partial class Loginaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lgnView_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string userName = lgnView.UserName;

            string password = lgnView.Password;

            TicketUser currentUser = TicketUser.LoginUser(userName, password);

            if (currentUser != null && currentUser.Address != null && currentUser.Password != null && currentUser.UserName != null)
            {
                e.Authenticated = true;
                    
                //do work to hide menus
                Session["savedUser"] = currentUser;
                Response.Redirect("ProductSearch.aspx");
            }
            else
            {
                
                Response.Redirect("CreateAccount.aspx");
            }




        }
    }
}