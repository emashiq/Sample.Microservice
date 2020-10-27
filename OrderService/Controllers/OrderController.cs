using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderService.Models;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        ILogger<OrderController> _orderControllerLogger;
        public OrderController(ILogger<OrderController> orderControllerLogger)
        {
            _orderControllerLogger = orderControllerLogger;
        }
        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ProductOrder Get(string id)
        {
            _orderControllerLogger.LogInformation(nameof(Get) + " is executed with id:" + id);
            return new ProductOrder()
            {
                OrderId = id,
                ProductId = Guid.NewGuid().ToString()
            };
        }

        // POST api/<OrderController>
        [HttpPost]
        public ProductOrder Post(ProductOrder value)
        {
            _orderControllerLogger.LogInformation(nameof(Post) + " is executed with data: {0}", value);

            return value;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ProductOrder Put(string id, ProductOrder value)
        {
            _orderControllerLogger.LogInformation(nameof(Put) + " is executed with data: {0}", value);

            return value;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public bool Delete(string id)
        {
            _orderControllerLogger.LogInformation(nameof(Delete) + " is executed with id: {0}", id);

            return true;
        }
    }
}
