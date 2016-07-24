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

            lblOutput.Text = myUser.ToString();

            
        }


    }
}