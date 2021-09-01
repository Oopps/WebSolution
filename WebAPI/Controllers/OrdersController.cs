using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly OrdersContext _context;
        
        public OrdersController(ILogger<OrdersController> logger, OrdersContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _context.Orders.Include(c => c.Customer).Include(c => c.Product).ToArray();
        }
    }
}