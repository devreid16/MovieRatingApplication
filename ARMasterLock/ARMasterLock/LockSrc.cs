using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ARMasterLock
{

    public class LockSrc
    {
        public IList<OrderLine> OrderLines { get; set; }
        public string ProdType { get; set; }        

        public LockSrc()
        {

        }

        ///method that sets sql params, calls DataAccess to get products by type

        public SqlDataReader SearchLocks()
        {
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();

            SqlParameter prodTypeParameter = new SqlParameter("@prodType",ProdType);
            prodTypeParameter.Value = ProdType;
            prodTypeParameter.ParameterName = "ProdType";                  
            parms.Add(prodTypeParameter);          

            SqlDataReader gv; 
            gv = da.GetDataReader("getProducts", parms);          

            ///returns Gridview with selected products

            return gv;    
        }          
    }

    ///method that sets variables and sql params, calls DataAccess to get products by price range
    public class LockSrc2
    {
        public IList<OrderLine> OrderLines { get; set; }
        public decimal LowPrice { get; set; }
        public decimal HighPrice { get; set; }       
                       
        public LockSrc2()
        {

        }

        public SqlDataReader SearchLocks2()
        {
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();

            SqlParameter ddllowPriceParameter = new SqlParameter("@LowPrice", LowPrice);
            ddllowPriceParameter.Value = LowPrice;
            ddllowPriceParameter.ParameterName = "LowPrice";
            parms.Add(ddllowPriceParameter);

            SqlParameter ddlhighPriceParameter = new SqlParameter("@HighPrice", HighPrice);
            ddlhighPriceParameter.Value = HighPrice;
            ddlhighPriceParameter.ParameterName = "HighPrice";
            parms.Add(ddlhighPriceParameter);

            SqlDataReader gv;

            gv = da.GetDataReader("srcProducts", parms);

            ///returns GridView of products in price range
            return gv;

        }
    }
}

















