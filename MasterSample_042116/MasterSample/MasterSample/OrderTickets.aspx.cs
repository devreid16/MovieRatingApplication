using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterSample
{
    public partial class OrderTickets : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Random RandomClass = new Random();

                for (int i = 0; i < 5; i++)
                {

                    int randomNumber = RandomClass.Next(1, 300);
                    sections.Items.Add(randomNumber.ToString());
                }

            }
        }

        /// <summary>
        /// Handles the Click event of the submit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                TicketOrder myOrder = new TicketOrder(Convert.ToInt32(sections.SelectedValue),
                    Convert.ToInt32(qtyTickets.Text));

                lblOutput.Text = myOrder.ToString();
            }
            catch (FormatException)
            {

                lblOutput.Text = "Please enter a number";
            }







            // int price = CalcTicketCost(Convert.ToInt32(sections.SelectedItem.Value), Convert.ToInt32(qtyTickets.Text));

            //lblOutput.Text = "The ticket cost is: " + price;
        }
    }
}