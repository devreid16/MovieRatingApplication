using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARMasterLock
{
    public partial class OrderLocks : System.Web.UI.Page
    {
        Order myOrder = new Order();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                for (int i = 3; i < 8; i += 2)
                {
                    int lk_Numbers = i;
                    lkType.Items.Add(lk_Numbers.ToString());
                }
            }

            myOrder.orderId = Convert.ToInt32("@orderId");
            
        }

        protected void btnPurchase_Click1(object sender, EventArgs e)
        {
            //create item from user selection
            OrderLine orderLine = new OrderLine();
            orderLine.orderId = Convert.ToInt32("@orderID");
           // orderLine.productId = "@productID";
        //    orderLine.productPrice = "@productPrice";
        //    orderLine.productQty = "@productQty";

            //add item to collection
            //myOrder.OrderLines = new List<OrderLine>();
            myOrder.OrderLines.Add(orderLine);

            //now we need to retain order object

            Session["Order"] = myOrder;

            //Response.Redirect("ReviewOrder.aspx");
        }

        protected void btnPurchase_Click2(object sender, EventArgs e)
        {
                    
            myOrder = (Order)Session["Order"];

            //create item
           // OrderLine orderLine = new OrderLine();
           // orderLine.ProductName = "@productName";
         //   orderLine.ProductDetail = "@productDetail";
         //   orderLine.productPrice = "@productPrice";
        //    orderLine.productQty = "@productQty";

            //add product to collection

       //     myOrder.OrderLines.Add(orderLine);


            //now we need to persist order object

            Session["Order"] = myOrder;
            Response.Redirect("ReviewOrder.aspx");
        }


        protected void submit_Click(object sender, EventArgs e)
        {

           // LockOrder myOrder =
        //    new LockOrder(Convert.ToInt32(lkType.SelectedItem.Value),
         //       Convert.ToInt32(qtyItem.Text));

           // lblOutput.Text = myOrder.ToString();

        }
    
    }
}