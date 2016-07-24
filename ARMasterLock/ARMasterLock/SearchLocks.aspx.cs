using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARMasterLock
{
    public partial class SearchLocks : System.Web.UI.Page
    {
        
        LockSrc mySrc = new LockSrc();
       
        protected void Page_Load(object sender, EventArgs e)
        {

            {
               
            }
        }
/// <summary>
/// Button click to search price range
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        protected void btnsrcProductByPrice_Click(object sender, EventArgs e)
        {
            LockSrc2 mySrc = new LockSrc2();
            OrderLine orderLine = new OrderLine();
            mySrc.LowPrice = Convert.ToDecimal(ddllowPrice.SelectedValue);
            mySrc.HighPrice = Convert.ToDecimal(ddlhighPrice.SelectedValue);

            //Convert.ToInt32(ddllowPrice.Text);
          //  Convert.ToInt32(ddlhighPrice.Text);

            //add item to collection
            SqlDataReader da;

            da = mySrc.SearchLocks2();

            GridView1.DataSource = da;            
            GridView1.DataBind();
                               
        }

/// <summary>
/// Button Click event to search product type
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        protected void btnsrcProductByType_Click(object sender, EventArgs e)
        {            
            LockSrc mySrc2 = new LockSrc();
            OrderLine orderLine = new OrderLine();
            mySrc2.ProdType = prodType.Text;            

            //add item to collection
            SqlDataReader da;

            da = mySrc2.SearchLocks();

            mySrc2.OrderLines = new List<OrderLine>();
            mySrc2.OrderLines.Add(orderLine);
            
            GridView2.DataSource = da;
             
            GridView2.DataBind();
                                  
        }
    }
}