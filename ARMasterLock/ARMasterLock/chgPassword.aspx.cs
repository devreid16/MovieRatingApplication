using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARMasterLock
{
    public partial class chgPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (((string)Session["postBackType"]) == "display")
            {

                if (Session["savedUser"] != null)
                {
                    LockUser savedUser = (LockUser)Session["savedUser"];
                    currPassword.Text = savedUser.Password;                    
                    uName.Text = savedUser.UserName;
                }                

            }
        }
        
        protected void Submit_Click(object sender, EventArgs e)
        {
            
            chgPass myUser = new chgPass();

            myUser.Password = currPassword.Text;
            myUser.NewPassword = newPassword.Text;
            myUser.ConfPassword = confPassword.Text;           
            myUser.UserName = uName.Text;

            if (newPassword.Text != confPassword.Text)
            {
                lblOutput1.Text = "Passwords do not match!";

            }
            else               

                lblOutput1.Text = myUser.UpdatePassword();
        }
    }
}