using System;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARMasterLock
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (((string)Session["postBackType"]) == "display")
            {
                if (Session["savedUser"] != null)
                {
                    LockUser savedUser = (LockUser)Session["savedUser"];
                    fName.Text = savedUser.FirstName;
                    lName.Text = savedUser.LastName;
                    address.Text = savedUser.Address;
                    city.Text = savedUser.City;
                    state.Text = savedUser.State;
                    zipCode.Text = savedUser.ZipCode;
                    phone.Text = savedUser.Phone;
                    email.Text = savedUser.Email;
                    userName.Text = savedUser.UserName;                    
                }
                Session["postBackType"] = "";
                    
            }
        }

        /// <summary>
        /// Handles the Click event of the btnUpdateUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UserUpdate myUser = new UserUpdate();

            myUser.FirstName = fName.Text;
            myUser.LastName = lName.Text;
            myUser.Address = address.Text;
            myUser.City = city.Text;
            myUser.State = state.Text;
            myUser.ZipCode = zipCode.Text;
            myUser.Phone = phone.Text;
            myUser.Email = email.Text;
            myUser.UserName = userName.Text;

            if (Page.IsValid)

                lblOutput.Text = myUser.UpdateProfile();
            /// lblOutput.Text = myUser.ToString();  
            /// 
            ///
        }            
    }
}