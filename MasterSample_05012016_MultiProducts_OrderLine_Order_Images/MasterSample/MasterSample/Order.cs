using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MasterSample
{
    public class Order
    {
        //this class represents an entry from the Order table in the database
        public Int32 OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserID { get; set; }
        public decimal Total { get; set; }

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

            //step 1: write the order info to the Order table.  This will give us an order id that we will use in each orderline to associate the orderline to the order

            ArrayList orderParameters = new ArrayList();

           
            SqlParameter userIDParameter = new SqlParameter();
            userIDParameter.ParameterName = "@UserID";
            userIDParameter.Value = UserID;
            orderParameters.Add(userIDParameter);

            SqlParameter orderDateParameter = new SqlParameter();
            orderDateParameter.ParameterName = "@OrderDate";
            orderDateParameter.Value = OrderDate;
            orderParameters.Add(orderDateParameter);

            //lets figure the total for the entire order so we can add it
            //reset the total first to make sure it is zero when we start
            Total = 0;

            foreach (OrderLine orderLine in OrderLines)
            {
                Total = Total + (orderLine.Quantity*orderLine.Price);
            }

            //I've added Total here so that I can easily show a total, otherwise I would need to manually compute the total from the orderlines
            SqlParameter totalParameter = new SqlParameter();
            totalParameter.ParameterName = "@Total";
            totalParameter.Value = Total;
            orderParameters.Add(totalParameter);


            da.InsertUpdateData("UpdateOrder", orderParameters);

            

 
            //There's a MUCH better way to do this, but for simplicity I created another stored proc to retrieve the order id based on the parameters of the order previously submitted


            SqlDataReader dr = da.GetDataReader("GetOrderID", orderParameters);

            if (dr.HasRows)
            {
                dr.Read();
                OrderID = Convert.ToInt32(dr["Id"]);
                dr.Close();
            }

            

            //you can use the newly created OrderID to update all of the orderlines with the orderID (which wasn't known when the order was intially created)

            foreach (OrderLine orderLine in OrderLines)
            {
                orderLine.OrderID = OrderID;
            }

            //step 2: now that we have the orderID, we will use it when we save the individual orderlines to the database

            ArrayList orderListParameters = new ArrayList();

            //create parms for each order line and put it in the arraylist to give to the data access class
            foreach (OrderLine line in OrderLines)
            {
                SqlParameter orderIDParameter = new SqlParameter();
                orderIDParameter.ParameterName = "@OrderID";
                orderIDParameter.Value = OrderID;
                orderListParameters.Add(orderIDParameter);

                SqlParameter productIDParameter = new SqlParameter();
                productIDParameter.ParameterName = "@ProductID";
                productIDParameter.Value = line.ProductID;
                orderListParameters.Add(productIDParameter);

                SqlParameter quantityParameter = new SqlParameter();
                quantityParameter.ParameterName = "@Quantity";
                quantityParameter.Value = line.Quantity;
                orderListParameters.Add(quantityParameter);

                SqlParameter priceParameter = new SqlParameter();
                priceParameter.ParameterName = "@Price";
                priceParameter.Value = line.Price;
                orderListParameters.Add(priceParameter);
            }
            //call the data access Insert method and insert the order lines
            da.InsertUpdateData("UpdateOrderLine", orderListParameters);

            //done!
        }
         
    }
}