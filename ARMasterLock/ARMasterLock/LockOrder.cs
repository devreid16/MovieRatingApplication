using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ARMasterLock
{
    public class LockOrder
    {       
        public IList<OrderLine> OrderLines { get; set; }
        public string productMdlNum { get; set; }
        public string productQty { get; set; }

        public LockOrder()
        {

        }

        public SqlDataReader OrderLocks()
        {
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();

            SqlParameter productMdlNumParameter = new SqlParameter("@productMdlNum", productMdlNum);
            productMdlNumParameter.Value = productMdlNum;
            productMdlNumParameter.ParameterName = "productMdlNum";
            parms.Add(productMdlNumParameter);

            SqlParameter productQtyParameter = new SqlParameter("productQty", productQty);
            productQtyParameter.Value = productQty;
            productQtyParameter.ParameterName = "productQty";
            parms.Add(productQtyParameter);

            SqlDataReader GridOdrs;

            GridOdrs = da.GetDataReader("OrderProducts", parms);

            ///returns GridView of products ordered
            return GridOdrs;

        }
    }
}