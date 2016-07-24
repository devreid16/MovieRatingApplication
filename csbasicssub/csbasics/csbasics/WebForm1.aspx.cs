using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace csbasics
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Declare variables used in calculations

        public const double lkThree = 5.00;
        public const double lkFive = 7.00;
        public const double lkSeven = 9.00;
        public const double delCharge = 3.00;
        public string mdlName;
        
        // Page loads, counter for listbox is established

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
        }

        // Function to calculate the cost of the order: initialize cost, price
        
        public  int CalcOrderCost(int lkType, int qtyItem)
        {
            int cost = 0;
            double price = 0;

          if (lkType == 3)
            
            // Obtain the price of lock and model name (based on lock no.) 
            // item price multiplied by the quantity ordered gives total price; 

            {
                mdlName = "Master Lock No. 3";
                price = lkThree * qtyItem;
            }
            else

                if (lkType == 5)
                 {
                    mdlName = "Master Lock No. 5";
                    price = lkFive * qtyItem;
                 }
                else

                    if (lkType == 7)
                    {
                        mdlName = "Master Lock No. 7";
                        price = lkSeven * qtyItem;
                    }

            // Delivery Charge calculated

              double delChrg = qtyItem * delCharge;

            //Order cost determined

              cost = Convert.ToInt32(price + delChrg);
              return cost;
            
 }
            // Submit button 
            // initialze price to converted CalcOrderCost function

        protected void submit_Click(object sender, EventArgs e)
        {
            int price = CalcOrderCost(Convert.ToInt32(lkType.SelectedItem.Value),
            Convert.ToInt32(qtyItem.Text));

            // Sets label text for name to string

            lblFname.Text = "";
            lblLname.Text = "";

            //Checks to see if textbox is empty, if not gets value entered
            //uses values entered to give order message

            if (fName.Text != "")

                Label1.Text = fName.Text +" " + lName.Text +
                    ",  you ordered a quantity of " + qtyItem.Text + " "  +  
                         mdlName + ". The order cost is: $ " +  price + ".00";
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}