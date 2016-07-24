using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARMasterLock
{
    public partial class LoginView : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void lgnView_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = Login1.UserName;

            string password = Login1.Password;            

            LockUser currentUser = LockUser.LoginUser(username, password);

            if (currentUser != null && currentUser.Address != null && currentUser.UserName != null
                    && currentUser.Password != null)
            {
                e.Authenticated = true;

                //do work to unhide menus
                Session["savedUser"] = currentUser;               
                Response.Redirect("Default.aspx");                               
            }
            else
            {
                //do work to hide menus                
                Response.Redirect("CreateAccount.aspx");                
            }
        
        }

        protected void Password_Chg(object sender, EventArgs e)
        {
            string username = Login1.UserName;
                        
            string password = Login1.Password;           

            LockUser currentUser = LockUser.LoginUser(username, password);

            if (currentUser != null && currentUser.Address != null && currentUser.UserName != null
                    && currentUser.Password != null)

                //do work to unhide menus
                Session["savedUser"] = currentUser;
                Session["postBackType"] = "display";
                Response.Redirect("ChgPassword.aspx");                            
        }


        public string userProfile;

        protected void Profile_View(object sender, EventArgs e)
        {
            
            string username = Login1.UserName;

            string password = Login1.Password;

            LockUser currentUser = LockUser.LoginUser(username, password);
            
            if (currentUser != null && currentUser.Address != null && currentUser.UserName != null
                    && currentUser.Password != null)

                //do work to unhide menus
                Session["savedUser"] = currentUser;               
                Session["postBackType"] = "display";
                Response.Redirect("UpdateProfile.aspx");                                 
        }
    }  
}