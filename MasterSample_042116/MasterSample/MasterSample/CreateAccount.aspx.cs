using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterSample
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
            TicketUser myUser = new TicketUser();
            myUser.FirstName = firstName.Text;
            myUser.LastName = lastName.Text;
            myUser.UserName = userName.Text;
            myUser.Address = address.Text;
            myUser.City = city.Text;
            myUser.State = state.Text;
            myUser.Zip = zip.Text;
            myUser.Phone = phone.Text;
            myUser.Email = email.Text;
            myUser.Password = password.Text;

           lblOutput.Text = myUser.CreateAccount();

          //  lblOutput.Text = myUser.ToString();


        }
    }
}