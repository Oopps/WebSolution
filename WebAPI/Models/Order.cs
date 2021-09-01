namespace WebAPI.Models
{
    
    public enum Status
    {
        New, Current, Shipped
    }

    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public Status Status { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}