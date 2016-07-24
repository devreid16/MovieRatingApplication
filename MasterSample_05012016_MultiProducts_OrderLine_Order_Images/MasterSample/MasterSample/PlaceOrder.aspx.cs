using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterSample
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        public Order myOrder;
        public TicketUser currentUser;
        protected void Page_Load(object sender, EventArgs e)
        {
           //show the cart

            if ((Order) Session["Order"] != null)
            {
                myOrder = (Order)Session["Order"];

                grdCartContents.DataSource = myOrder.OrderLines;
                grdCartContents.DataBind();
            }
            if ((TicketUser)Session["savedUser"] != null)
            {
                currentUser = (TicketUser)Session["savedUser"];

                 
            }

        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            myOrder.OrderDate = DateTime.Now;
            myOrder.UserID = currentUser.UserID.ToString();
            myOrder.PlaceOrder();


            lblMessage.Text = "Your order has been placed!";
            Session["Order"] = null;
        }
    }
}