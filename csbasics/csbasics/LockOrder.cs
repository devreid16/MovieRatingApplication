using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csbasics
{
    public class LockOrder
    {
        // Declare variables used in calculations

        public int Locks { get; set; }
        public int Quantity { get; set; }
        public string MdlName { get; set; }      
              
        public static double lkThree = 5.00;
        public static double lkFive = 7.00;
        public static double lkSeven = 9.00;
        public static double delCharge = 3.00;        
       
    /// <summary>
    /// Initializes a new instance of the LockOrder class
    /// </summary>
    /// <param name="lkType"></param>
    /// <param name="qtyItem"></param>
        public LockOrder(int lkType, int qtyItem)
        {
            Locks = lkType;
            Quantity = qtyItem;
           

        }
        /// <summary>
        /// Function to calculate the cost of the order: initialize cost, price
        /// </summary>
        /// <returns>Model No. and set, delChrg, Cost</returns>
        public int CalcOrderCost()
        {
                        
            int cost = 0;
            double price = 0;
           
            if (Locks == 3)

            // Obtain the price of lock and model name (based on lock no.) 
            // item price multiplied by the quantity ordered gives total price; 

            {
                MdlName = " Master Lock No. 3";
                price = lkThree * Quantity;
            }
                else

            if (Locks == 5)
            {
                MdlName = " Master Lock No. 5";
                price = lkFive * Quantity;
            }
                else

            if (Locks == 7)
            {
                MdlName = " Master Lock No. 7";
                price = lkSeven * Quantity;
            }

            // Delivery Charge calculated

            double delChrg = Quantity * delCharge;

            //Order cost determined

            cost = Convert.ToInt32(price + delChrg);
            return cost;
        }
        public override string ToString()
        {
            decimal ldCost = CalcOrderCost();

            string message = 
                "You ordered " +  Quantity +  " of " + MdlName +
                ". The order cost is: $ " +   ldCost + ".00";            

            return message;
        }
    }
}