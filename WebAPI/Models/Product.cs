using System.Collections.Generic;

namespace WebAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
        public int ProductCategory { get; set; }
        
    }
}