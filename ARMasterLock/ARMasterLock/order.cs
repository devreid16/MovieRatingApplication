using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ARMasterLock
{
    public class Order
    {
        //this class represents an entry from the Order table in the database
        public Int32 orderId { get; set; }
        public int productId { get; set; }
        public int customerId { get; set; }
        public DateTime orderDate { get; set; }
        public decimal orderTotal { get; set; }


        //holds all the OrderLines in an order
        public ArrayList OrderLines { get; set; }


        public void AddOrderLine(OrderLine orderLine)
        {
            //if OrderLines arraylist hasn't been fully created, create it
            if (OrderLines == null)
            {
                OrderLines = new ArrayList();
            }

            //add the newly created order line to the arraylist
            OrderLines.Add(orderLine);
        }              

        public void PlaceOrder()
        {
            //create data access object to save info to both tables
            DataAccess da = new DataAccess();

            //step 1: write the order info to the Order table.  This will give us an order id that we will use
            //in each orderline to associate the orderline to the order

            ArrayList orderParameters = new ArrayList();

            SqlParameter customerIdParameter = new SqlParameter();
            customerIdParameter.ParameterName = "@customerId";
            customerIdParameter.Value = customerId;
            orderParameters.Add(customerIdParameter);

            SqlParameter orderDateParameter = new SqlParameter();
            orderDateParameter.ParameterName = "@orderDate";
            orderDateParameter.Value = orderDate;
            orderParameters.Add(orderDateParameter);

            //lets figure the total for the entire order so we can add it
            //reset the total first to make sure it is zero when we start
            orderTotal = 0;

            foreach (OrderLine orderLine in OrderLines)
            {
                orderTotal = orderTotal + (orderLine.productQty * orderLine.productPrice);
            }

            //I've added Total here so that I can easily show a total, otherwise I would 
            //need to manually compute the total from the orderlines

            SqlParameter orderTotalParameter = new SqlParameter();
            orderTotalParameter.ParameterName = "@total";
            orderTotalParameter.Value = orderTotal;
            orderParameters.Add(orderTotalParameter);

            da.InsertUpdateData("UpdateOrder", orderParameters);

            //There's a MUCH better way to do this, but for simplicity I created another stored proc to 
            //retrieve the orderid based on the parameters of the order previously submitted

            SqlDataReader dr = da.GetDataReader("GetOrderID", orderParameters);

            if (dr.HasRows)
            {
                dr.Read();
                orderId = Convert.ToInt32(dr["Id"]);
                dr.Close();
            }

            //you can use the newly created OrderID to update all of the orderlines with the orderID 
            //(which wasn't known when the order was intially created)

            foreach (OrderLine orderLine in OrderLines)
            {
                orderLine.orderId = orderId;
            }

            //step 2: now that we have the orderID, we will use it when we save the individual orderlines to 
            //the database

            ArrayList orderListParameters = new ArrayList();

            //create parms for each order line and put it in the arraylist to give to the data access class
            foreach (OrderLine line in OrderLines)
            {
                SqlParameter orderIdParameter = new SqlParameter();
                orderIdParameter.ParameterName = "@orderID";
                orderIdParameter.Value = orderId;
                orderListParameters.Add(orderIdParameter);

                SqlParameter productIdParameter = new SqlParameter();
                productIdParameter.ParameterName = "@productID";
                productIdParameter.Value = line.productId;
                orderListParameters.Add(productIdParameter);

                SqlParameter productQtyParameter = new SqlParameter();
                productQtyParameter.ParameterName = "@quantity";
                productQtyParameter.Value = line.productQty;
                orderListParameters.Add(productQtyParameter);

                SqlParameter productPriceParameter = new SqlParameter();
                productPriceParameter.ParameterName = "@price";
                productPriceParameter.Value = line.productPrice;
                orderListParameters.Add(productPriceParameter);
            }
            //call the data access Insert method and insert the order lines
               da.InsertUpdateData("OrderProducts", orderListParameters);

            //done!
        }
    }
}