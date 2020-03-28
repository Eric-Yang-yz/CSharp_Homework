using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class EditFailException : ApplicationException//编辑失败异常
    {
        public EditFailException(String message):base(message)
        {
        }
        public String message { get => Message; }
    }
    class OrderManager//manager类里的所有方法对应于OrderService类的所有方法，增加了输出部分
    {
        OrderService Server = new OrderService();

        public void AddOrder(Order order)
        {
            if (Server.AddOrder(order)) Console.WriteLine("订单添加成功！");
            else
            {
                Console.WriteLine("订单添加失败！");
                throw new EditFailException("订单号重复！");
            }
        }

        public void DeleteOrder(string number)
        {
            if (Server.DeleteOrder(number)) Console.WriteLine("订单删除成功！");
            else
            {
                Console.WriteLine("订单删除失败！");
                throw new EditFailException("未找到订单号！");
            }
        }

        public void AddItemToOrder(string number, OrderItem item)
        {
            if (Server.AddItemToOrder(number,item)) Console.WriteLine("商品添加成功！");
            else
            {
                Console.WriteLine("商品添加失败！");
                throw new EditFailException("商品号重复！");
            }
        }

        public void DeleteItemInOrder(string number, OrderItem item)
        {
            if (Server.DeleteItemInOrder(number,item)) Console.WriteLine("商品删除成功！");
            else
            {
                Console.WriteLine("商品删除失败！");
                throw new EditFailException("未找到商品号！");
            }
        }

        public void FindOrderNumber(string number)
        {
            var query = Server.FindOrderNumber(number);
            List<Order> orders = query.ToList();
            if (orders.Count==0) Console.WriteLine("未找到指定订单！");
            else
            foreach (Order m in orders)
            {
                Console.WriteLine(m.ToString());
            }
            
        }

        public void FindItem(OrderItem item)
        {
            var query = Server.FindItem(item);
            List<Order> orders = query.ToList();
            if (orders.Count == 0) Console.WriteLine("未找到指定订单！");
            else
            {
                Console.WriteLine("以下是包含该商品的订单：");
                foreach (Order m in orders)
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }

        public void FindCustomer(User user)
        {
            var query = Server.FindCustomer(user);
            List<Order> orders = query.ToList();
            if (orders.Count == 0) Console.WriteLine("未找到指定订单！");
            else
            {
                foreach (Order m in orders)
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }

        public void GetAll()
        {
            var query = Server.GetAll();
            List<Order> orders = query.ToList();
            if (orders.Count == 0) Console.WriteLine("无订单！");
            else
            {
                foreach (Order m in orders)
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }

        public void SortOrder()
        {
            Server.SortOrder();
            Console.WriteLine("排序完成！");
        }

        public void Export(string ExportPath)
        {
            Server.Export(ExportPath);
            Console.WriteLine("导出完成！");
        }

        public void Import(string ImportPath)
        {
            Server.Import(ImportPath);
            Console.WriteLine("导入完成！");
        }

        public OrderManager()
        {
            Server = new OrderService();
        }
    }
}
