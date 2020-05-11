using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDB
{
    class OrderService
    {
        public void AddOrder(int id,int Uid,string Uname)
        {
            using (var db = new OrderContext())
            {
                var query = from order in db.Orders
                            where order.OrderID == id
                            select order;
                if (query.Count() == 0)
                {
                    var NewOrder = new Order { OrderID = id, UserID = Uid, UserName = Uname,Time = DateTime.Now };
                    db.Orders.Add(NewOrder);
                    db.SaveChanges();
                    Console.WriteLine("订单添加成功！");
                }
                else
                {
                    Console.WriteLine("此订单号已存在，添加失败！");
                }
            }
        }

        public void AddItemToOrder(int orderid,string name,double price,int count)
        {
            using (var db = new OrderContext())
            {
                var query = from order in db.Orders
                            where order.OrderID == orderid
                            select order;
                if (query.Count() != 0)
                {
                    var item = new Item() { OrderID = orderid, Name = name, SinglePrice = price, Count = count };
                    db.Entry(item).State = EntityState.Added;
                    db.SaveChanges();
                    Console.WriteLine("商品添加成功！");
                }
                else
                {
                    Console.WriteLine("商品添加失败，订单号不存在！");
                }
            }
        }

        public void DeleteOrder(int id)
        {
            using (var db = new OrderContext())
            {
                var order = db.Orders.Include("Items").FirstOrDefault(m => m.OrderID == id);//未找到返回null,有外键则级联删除
                if (order == null)
                {
                    Console.WriteLine("删除失败，订单号不存在！");
                }
                else
                {
                    db.Orders.Remove(order);
                    db.SaveChanges();
                    Console.WriteLine("删除成功！");
                }
            }
        }

        public void DeleteItem(int orderid,string name)
        {
            using (var db = new OrderContext())
            {
                var item = db.Items.FirstOrDefault(m => m.OrderID == orderid && m.Name == name);
                if (item == null)
                {
                    Console.WriteLine("删除失败，未找到该商品！");
                }
                else
                {
                    db.Items.Remove(item);
                    db.SaveChanges();
                    Console.WriteLine("删除成功！");
                }
            }
        }

        public void FindOrderID(int id)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include("Items").Where(m => m.OrderID == id);//级联查询
                if (query.Count() == 0)
                {
                    Console.WriteLine("错误，订单号不存在！");
                }
                else
                {
                    foreach (Order order in query)
                    {
                        Console.WriteLine(order);
                        foreach (Item item in order.Items)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        public void FindUserName(string name)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include("Items").Where(m => m.UserName == name);//级联查询
                if (query.Count() == 0)
                {
                    Console.WriteLine("错误，用户不存在！");
                }
                else
                {
                    foreach (Order order in query)
                    {
                        Console.WriteLine(order);
                        foreach (Item item in order.Items)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        public void FindAll()
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include("Items").Where(m => true);//级联查询
                if (query.Count() == 0)
                {
                    Console.WriteLine("错误，无订单！");
                }
                else
                {
                    foreach (Order order in query)
                    {
                        Console.WriteLine(order);
                        foreach (Item item in order.Items)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }
    }
}
