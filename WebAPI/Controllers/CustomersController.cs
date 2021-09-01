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
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly OrdersContext _context;
        
        public CustomersController(ILogger<CustomersController> logger, OrdersContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.Customers.ToArray();
        }
    }
}