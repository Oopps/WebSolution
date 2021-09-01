using System;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(OrdersContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{CustomerName= "Carson Alexander",CustomerAddress = "Address1"},
            new Customer{CustomerName= "Meredith Barzdukas",CustomerAddress = "Address2"},
            new Customer{CustomerName= "Arturo Anand",CustomerAddress = "Address3"},
            };
            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();

            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }
            var products = new Product[]
            {
            new Product{ProductName="Cherry",ProductCost= 3},
            new Product{ProductName="Apple",ProductCost= 10},
            new Product{ProductName="Melon",ProductCost= 5},
            };
            foreach (Product c in products)
            {
                context.Products.Add(c);
            }
            context.SaveChanges();

            if (context.Orders.Any())
            {
                return;   // DB has been seeded
            }
            var orders = new Order[]
            {
            new Order
            {
                OrderNumber= 1050,CustomerId=1,
                ProductName = "Apple",ProductCost=10
            },
            new Order
            {
                OrderNumber= 4022,CustomerId=2,
                ProductName="Cherry",ProductCost= 3
            },
            };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
        }
    }
}