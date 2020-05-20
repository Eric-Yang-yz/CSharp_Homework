using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace OrderApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController:ControllerBase
    {
        private readonly OrderContext OrderDB;
        public OrderController(OrderContext context)
        {
            this.OrderDB = context;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrders(string Uname)//按用户名查询
        {
            IQueryable<Order> query = OrderDB.Orders;
            if (Uname != null)
            {
                query = query.Where(m => m.UserName.Contains(Uname));
            }
            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long id)//按id查询
        {
            var order = OrderDB.Orders.FirstOrDefault(m => m.OrderID == id);
            if (order == null)return NotFound();
            else return order;
        }

        [HttpGet("pageQuery")]//分页查询
        public ActionResult<List<Order>> queryOrder(string Uname,int skip,int take)
        {
            IQueryable<Order> query = OrderDB.Orders;
            if (Uname!=null)
            {
                query = query.Where(m => m.UserName.Contains(Uname));
            }
            return query.Skip(skip).Take(take).ToList();
        }

        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                OrderDB.Orders.Add(order);
                OrderDB.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        [HttpPut("{id}")]
         public ActionResult<Order> PutOrder(long id, Order order)
        {
            if (id != order.OrderID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                OrderDB.Entry(order).State = EntityState.Modified;
                OrderDB.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(long id)
        {
            try
            {
                var order = OrderDB.Orders.Include("Items").FirstOrDefault(m => m.OrderID==id);
                if (order != null)
                {
                    OrderDB.Orders.Remove(order);
                    OrderDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}