using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARMasterLock
{
    public partial class reviewOrder : System.Web.UI.Page
    {
        public int customerId;
        public Order myOrder;       
        public LockUser currentUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["savedUser"] != null)
            {
                LockUser savedUser = (LockUser)Session["savedUser"];
                customerId = savedUser.customerId;
            }

            //show the cart

            if ((Order)Session["Order"] != null)
            {
                myOrder = (Order)Session["Order"];

                grdCartContents.DataSource = myOrder.OrderLines;
                grdCartContents.DataBind();
            }

            if ((LockUser)Session["savedUser"] != null)
            {
                currentUser = (LockUser)Session["savedUser"];
                
            }
        }
        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            myOrder.orderDate = DateTime.Now;
            myOrder.customerId = customerId;
            myOrder.PlaceOrder();


            lblMessage.Text = "Your order has been placed!";
            Session["Order"] = null;
            //if page is posting back after order placed - Hide Button
            if(Page.IsPostBack)
            {
                btnPlaceOrder.Visible = false;
            }


        }
    }
}