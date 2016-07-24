using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
  public partial class _default : System.Web.UI.Page
  {
    public const double premiumTicket = 40.00;
    public const double basicTicket = 20.00;
    public const double serviceCharge = 2.0;

    protected void Page_Load(object sender, EventArgs e)
    {
      // if (!Page.IsPostBack)
      {
        Random RandomClass = new Random();

        for (int i = 0; i < 5; i++)
          }

      int randomNumber = RandomClass.Next(1, 300);
      sections.Items.Add(randomNumber.ToString());
    }

    public int calcTicketCost(int section, int quantity)
    {   

    
    sections.Items.Add(randomNumber.ToString());
    // (number of tickets * ticket price) + (number of tickets * service charge)

    int cost = 0;
    
    double price = 0;
     
    if (sections > 150)
      { 
    return cost;

      price = basicTicket * quantity;
         else
           price = premiumTicket* quantity;
    double servChg = quanityt*serviceCharge;
   
   cost = convert.ToInt32(price+servChg);
   cost = (quantity * 


    calcTicketCost(Convert.ToInt32(sections.SelectedItem.Value),
     Convert.ToInt32(qtyTickets.Text));

    lblOutput.Text = "The ticket cost is " + price;
    }
  }
}