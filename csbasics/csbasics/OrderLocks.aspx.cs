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
               

        protected void submit_Click(object sender, EventArgs e)
        {
               
            LockOrder myOrder =
            new LockOrder(Convert.ToInt32(lkType.SelectedItem.Value), 
                Convert.ToInt32(qtyItem.Text));

            lblOutput.Text = myOrder.ToString();               
            
        
         
        }
    }
}