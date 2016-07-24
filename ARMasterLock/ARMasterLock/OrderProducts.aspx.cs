using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARMasterLock
{
    public partial class OrderProducts : System.Web.UI.Page
    {
        public Order myOrder;
        public int productId;
        public int customerId;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["savedUser"] != null)
            {
                LockUser savedUser = (LockUser)Session["savedUser"];
                customerId = savedUser.customerId;
            }
                if ((Order)Session["Order"] != null) //if we have an existing order, get it from the session (it won't be null if we have one already)
            {
                myOrder = (Order)Session["Order"]; //set the variable on the page to the existing session variable that has our order
                myOrder.productId = productId;
                        
            }
            else
            {
                myOrder = new Order();  //we don't have an order so create a new blank one in case the customer wants to order a product
            }
                        
            //get the info on a product to show

            //create data access
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();

            //we need one parameter for each product, since this page only displays one product 
            //we can hard code the 1 product by sending only one product id as our only parameter

            SqlParameter productIdParameter = new SqlParameter();
            productIdParameter.ParameterName = "@productID";
            productIdParameter.Value = 8;
            parms.Add(productIdParameter);

            grdProduct.DataSource = da.GetDataReader("GetProduct", parms);

            grdProduct.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //get the items needed to create a OrderLine

            //Rows[0] gets the first row of data from the grid, Cells[0] gets the first cell in the row (zero based index)

            //product id is the first cell in the row
            Int32 productID = Convert.ToInt32(grdProduct.Rows[0].Cells[0].Text);

            //we don't know the order id in the orderline yet, so don't update it

            //get the quantity from the dropdown
            Int32 quantity = Convert.ToInt32(ddlQuantity.SelectedValue);            

            //get the price from the grid, it is in cell 6 (starting at zero)
            Decimal price = Convert.ToDecimal(grdProduct.Rows[0].Cells[6].Text);

            //create the orderline and add it to the current order

            OrderLine ol = new OrderLine();
            ol.productId = productID;
            ol.productQty = quantity;
            ol.productPrice = Convert.ToInt32(price);

            //now add the new order line to the order object
            myOrder.AddOrderLine(ol);

            //save the order to the session to make sure we have the new orderline in memory
            Session["Order"] = myOrder;

            //redirect to place sample order page (since we added an item)

            Response.Redirect("PlaceOrder.aspx");
            
        }
    
    }
}