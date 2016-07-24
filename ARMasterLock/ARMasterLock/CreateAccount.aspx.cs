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
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Handles the Click event of the btnCreateUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            LockUser myUser = new LockUser();             
              myUser.FirstName = fName.Text;
              myUser.LastName = lName.Text;
              myUser.Address = address.Text;
              myUser.City = city.Text;
              myUser.State = ddlStateList.SelectedValue;
              myUser.ZipCode = zipCode.Text;
              myUser.Phone = phone.Text;
              myUser.Email = email.Text;
              myUser.UserName = userName.Text;
              myUser.Password = password.Text;

            if (Page.IsValid)
            
                lblOutput.Text = myUser.CreateAccount();
            /// lblOutput.Text = myUser.ToString(); 

            if (Page.IsPostBack)
                ClearForm();
        }

        //Clear other form fields
        protected void ClearForm()
        {
                fName.Text = "";
                lName.Text = "";
                address.Text = "";
                city.Text = "";
                ddlStateList.SelectedValue = "";
                zipCode.Text = "";
                phone.Text = "";
                email.Text = "";
                userName.Text = "";
                password.Text = "";
                Response.Redirect("Default.aspx"); 
        }
    }
}