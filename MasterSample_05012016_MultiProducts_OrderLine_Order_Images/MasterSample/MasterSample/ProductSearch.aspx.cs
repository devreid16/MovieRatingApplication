using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterSample
{
    public partial class ProductSearch : System.Web.UI.Page
    {

        public Order myOrder;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Order)Session["Order"] != null) //if we have an existing order, get it from the session (it won't be null if we have one already)
            {
                myOrder = (Order)Session["Order"]; //set the variable on the page to the existing session variable that has our order
            }
            else
            {
                myOrder = new Order();  //we don't have an order so create a new blank one in case the customer wants to order a product
            }

            //create data access
            DataAccess da = new DataAccess();

             

            


            grdProducts.DataSource = da.GetDataReader("GetProducts", null);



            grdProducts.DataBind();
        }



        

        protected void grdProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the items needed to create a OrderLine

            //SelectedRow gets the selected row of data from the grid, Cells[1] gets the first cell in the row (zero based index) 
            //Cells[0] has the select button.

            //product id is the first cell in the row
            Int32 productID = Convert.ToInt32(grdProducts.SelectedRow.Cells[1].Text);

            //we don't know the order id in the orderline yet, so don't update it

            //get the quantity from the dropdown
            Int32 quantity = Convert.ToInt32(ddlQuantity.SelectedValue);

            //get the price from the grid, it is in cell 6 (starting at zero)
            Decimal price = Convert.ToDecimal(grdProducts.SelectedRow.Cells[7].Text);

            //create the orderline and add it to the current order

            OrderLine ol = new OrderLine();
            ol.ProductID = productID;
            ol.Quantity = quantity;
            ol.Price = price;

            //now add the new order line to the order object
            myOrder.AddOrderLine(ol);

            //save the order to the session to make sure we have the new orderline in memory
            Session["Order"] = myOrder;

            //redirect to place sample order page (since we added an item)

            Response.Redirect("PlaceOrder.aspx");
        }



        
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}