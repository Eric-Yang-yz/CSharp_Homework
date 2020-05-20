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
    public class ItemController:ControllerBase
    {
        private readonly OrderContext OrderDB;
        public ItemController(OrderContext context)
        {
            this.OrderDB = context;
        }

        [HttpGet]
        public ActionResult<List<Item>> GetItems(string Iname)//按商品名查询
        {
            IQueryable<Item> query = OrderDB.Items;
            if (Iname != null)
            {
                query = query.Where(m => m.Name.Contains(Iname));
            }
            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(long id)//按id查询
        {
            var item = OrderDB.Items.FirstOrDefault(m => m.ItemID == id);
            if (item == null)return NotFound();
            else return item;
        }

        [HttpGet("pageQuery")]//分页查询
        public ActionResult<List<Item>> queryItem(string name,int skip,int take)
        {
            IQueryable<Item> query = OrderDB.Items;
            if (name!=null)
            {
                query = query.Where(m => m.Name.Contains(name));
            }
            return query.Skip(skip).Take(take).ToList();
        }

        [HttpPost]
        public ActionResult<Item> PostItem(Item item)
        {
            try
            {
                OrderDB.Items.Add(item);
                OrderDB.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return item;
        }

        [HttpPut("{id}")]
         public ActionResult<Item> PutItem(long id, Item item)
        {
            if (id != item.ItemID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                OrderDB.Entry(item).State = EntityState.Modified;
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
        public ActionResult DeleteItem(long id)
        {
            try
            {
                var item = OrderDB.Items.FirstOrDefault(m => m.ItemID==id);
                if (item != null)
                {
                    OrderDB.Items.Remove(item);
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