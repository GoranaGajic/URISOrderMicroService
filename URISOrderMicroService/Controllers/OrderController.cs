using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using URISOrderMicroService.DataAccess;
using URISOrderMicroService.Models;

namespace URISOrderMicroService.Controllers
{
    public class OrderController :ApiController
    {
        /// <summary>
        /// Get single order based on id
        /// </summary>
        /// <param name="id">Order id</param>
        /// <returns>Single order</returns>
        [Route("api/Order/{id}"), HttpGet]
        public Order GetOrder(int id)
        {
            return OrderDB.GetOrder(id);

        }

        /// <summary>
        /// Create new order
        /// </summary>
        /// <param name="order">Order as json</param>
        /// <returns>Created order</returns>
        [Route("api/Order"), HttpPost]
        public Order CreateOrder([FromBody] Order order)
        {
            return OrderDB.CreateOrder(order);
        }

        /// <summary>
        /// Update order
        /// </summary>
        /// <param name="order">Order as json</param>
        /// <returns>Updated order</returns>
        [Route("api/Order"), HttpPut]
        public Order UpdateOrder([FromBody]Order order)
        {
            return OrderDB.UpdateOrder(order);
        }

        /// <summary>
        /// Delete order
        /// </summary>
        /// <param name="id"></param>
        [Route("api/Order/{id}"), HttpDelete]
        public void DeleteOrder(int id)
        {
            OrderDB.DeleteOrder(id);
        }      
            
    }
}