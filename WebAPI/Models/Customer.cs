using System.Collections.Generic;

namespace WebAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int TotalOrderedCost { get; set; }
        public int OrdersCount { get; set; }
        
    }
    
}