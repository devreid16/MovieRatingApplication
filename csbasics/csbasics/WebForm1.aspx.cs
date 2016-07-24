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
        public const double lkThree = 5.00;
        public const double lkFive = 7.00;
        public const double lkSeven = 9.00;
        public const double delCharge = 3.00;
        public string mdlName;
        


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


       
        public  int CalcOrderCost(int lkType, int qtyItem)
        {
            int cost = 0;
            double price = 0;

          if (lkType == 3)
                            
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
            
              double delChrg = qtyItem * delCharge;

              cost = Convert.ToInt32(price + delChrg);
              return cost;
            
 }

        protected void submit_Click(object sender, EventArgs e)
        {
            int price = CalcOrderCost(Convert.ToInt32(lkType.SelectedItem.Value),
            Convert.ToInt32(qtyItem.Text));

            lblFname.Text = "";
            lblLname.Text = "";

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