using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARMasterLock
{
    public class OrderLine
    {
        public Int32 orderId { get; set; }       
        public Int32 productId { get; set; }
        public int productQty { get; set; }        
        public Int32 productPrice { get; set; }      
               
    }
}
