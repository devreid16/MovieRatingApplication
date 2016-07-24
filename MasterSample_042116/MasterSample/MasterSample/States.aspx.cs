using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterSample
{
    public partial class States : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create data access class instance

            DataAccess da = new DataAccess();

            SqlDataReader dataReader = da.GetDataReader("GetProducts", null);

            Image1.ImageUrl = "@~/Images/" + dataReader["Image"];
             
            ddlStates.DataBind();
        }
    }
}