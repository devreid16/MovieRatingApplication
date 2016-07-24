using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterSample
{
    public class OrderLine
    {
        //represents one line of the OrderLine table

        public Int32 ID { get; set; }
        public Int32 OrderID { get; set; }
        public Int32 ProductID { get; set; }
        public Int32 Quantity { get; set; }
        public decimal Price { get; set; }
        
 






    }
}