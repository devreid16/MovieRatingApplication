using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24200_ClassDemo
{
    public class TicketOrder
    {
        public int Section { get; set; }
        public int Quantity { get; set; }
        public static double PremiumTicket = 40.00;
        public static double BasicTicket = 20.00;
        public static double ServiceCharge = 2.00;


        /// <summary>
        /// Initializes a new instance of the <see cref="TicketOrder"/> class.
        /// </summary>
        /// <param name="section">The section.</param>
        /// <param name="quantity">The quantity.</param>
        public TicketOrder(int section, int quantity)
        {
            Section = section;
            Quantity = quantity;
        }

        /// <summary>
        /// Calculates the ticket cost.
        /// </summary>
        /// <returns>The ticket cost.</returns>
        public int CalcTicketCost()
        {
            //(number of tickets * ticket price) + (number of tickets * service charge)

            int cost = 0;


            double price = 0;

            if (Section > 150)
            {
                price = BasicTicket * Quantity;
            }
            else
            {
                price = PremiumTicket * Quantity;

            }

            double servChg = Quantity * ServiceCharge;

            cost = Convert.ToInt32(price + servChg);





            return cost;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string message = "You have ordered " + Quantity + " tickets from section " + Section  +
                " Your cost is: $"+ CalcTicketCost();
            return message;
        }
    }
}