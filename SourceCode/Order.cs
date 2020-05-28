using System;

namespace SourceCode
{
    public class Order
    {
        public int IdOrder { get; set; }
        public DateTime CreateDate { get; set; }
        public int IdProduct { get; set; }
        public int IdAddress { get; set; }
        
        public Order(){}
    }
}