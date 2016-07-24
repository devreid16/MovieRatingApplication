using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpBasicsProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public double lkThree = 5.00;
        public double lkFive = 7.00;
        public double lkSeven = 10.00;

        public double delCharge = 3.00;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            {
                lkType.Items.Clear();

                int[] lock_Numbers;
                lock_Numbers = new int[3];

                // Random RandomClass = new Random();
                for (int i = 0; i < 8; i+=2)
                {
                    //int randomNumber = RandomClass.Next(1, 300);
                   
                    lkType.Items.Add(lock_Numbers.ToString());

                }
            }
        }

        public int CalcOrderCost(int lkType, int qtyItem)
        {
            //(number of locks * lock price) + (number of locks * delivery charge)

            int cost = 0;
            double price = 0;

            if (lkType > 0)
            {
                price = lkType * qtyItem;
            
            }
                double delChrg = qtyItem * delCharge;

               cost = Convert.ToInt32(price + delChrg);

               return cost;
        }

        protected void submit_Click(object sender, EventArgs e)
       {
         int price = CalcOrderCost(Convert.ToInt32(lkType.SelectedItem.Value), Convert.ToInt32(qtyItem.Text));

         selLock.Text = "The Order cost is: " + price;

        }

    }
}