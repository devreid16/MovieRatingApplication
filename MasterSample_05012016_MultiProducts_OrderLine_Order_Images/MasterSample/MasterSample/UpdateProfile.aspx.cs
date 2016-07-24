using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterSample
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        public TicketUser savedUser = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["savedUser"] != null)
            {
                 savedUser = (TicketUser) Session["savedUser"];
                lastName.Text = savedUser.LastName;
                firstName.Text = savedUser.FirstName;
                address.Text = savedUser.Address;
                city.Text = savedUser.City;
                state.Text = savedUser.State;
                zip.Text = savedUser.Zip;
                phone.Text = savedUser.Phone;
                email.Text = savedUser.Email;


            }

        }

        /// <summary>
        /// Handles the Click event of the btnUpdateUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {
            TicketUser myUser = new TicketUser();
            myUser.FirstName = firstName.Text;
            myUser.LastName = lastName.Text;
            myUser.UserName = savedUser.UserName;
            myUser.Address = address.Text;
            myUser.City = city.Text;
            myUser.State = state.Text;
            myUser.Zip = zip.Text;
            myUser.Phone = phone.Text;
            myUser.Email = email.Text;
             
           lblOutput.Text = myUser.UpdateAccount();

          //  lblOutput.Text = myUser.ToString();


        }
    }
}