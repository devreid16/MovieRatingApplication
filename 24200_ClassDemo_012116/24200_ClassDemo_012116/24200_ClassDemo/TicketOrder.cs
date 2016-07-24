using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24200_ClassDemo
{
    public class TicketOrder
    {
        public int Section  { get; set; }
        public int Quantity { get; set; }
        public static double PremiumTicket = 40.00;
        public static double BasicTicket = 20.00;
        public static double ServiceCharge = 2.00;


        public TicketOrder(int section, int quantity)
        {
            Section = section;
            Quantity = quantity;
        }

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
    }
}