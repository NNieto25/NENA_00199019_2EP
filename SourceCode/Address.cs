using System;

namespace SourceCode
{
    public class Address
    {
        public int IdAddress { get; set; }
        public int IdUser { get; set; }
        public String SAddress { get; set; } // Member names cannot be the same as their enclosing type
        
        public Address(){}
    }
}