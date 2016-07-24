using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARMasterLock
{
    public partial class ReviewOrder : System.Web.UI.Page
    {
        public int customerId;
        public Order myOrder;        
        public LockUser currentUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["savedUser"] != null)
            {
                LockUser savedUser = (LockUser)Session["savedUser"];
                customerId = savedUser.customerId;
            }

            else
            {
                Response.Redirect("OrderProducts.aspx");  //we don't have an order; exit
            }

            //get the info on order to show

            //create data access
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();            
           
            SqlParameter customerIdParameter = new SqlParameter();
            customerIdParameter.ParameterName = "@customerId";
            customerIdParameter.Value = customerId;
            parms.Add(customerIdParameter);

            GridOrders.DataSource = da.GetDataReader("selectOrders", parms);           

            GridOrders.DataBind();
        }

    }     
    
}