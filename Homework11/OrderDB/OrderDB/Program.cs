using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDB
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService manager = new OrderService();
            InitDB();

            string str1, str2, str3;
            double price;
            int count,Orderid, Userid;
            while (true)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("欢迎使用YYZ的订单查询系统！\n操作码：（a）添加订单 （b）向指定订单添加商品 （c）删除订单 （d）删除商品\n（e）查询订单号  （f）查询某用户的订单\n（g）显示所有订单 （x）退出");
                Console.Write("请输入操作码：");
                string str = Console.ReadLine();
                char op;
                while (!char.TryParse(str, out op))
                {
                    Console.WriteLine("非法字符！请重新输入！");
                    str = Console.ReadLine();
                }
                switch (op)
                {
                    case 'a':
                        Console.WriteLine("请输入订单号：");
                        str1 = Console.ReadLine();
                        if (!int.TryParse(str1, out Orderid))
                        {
                            Console.WriteLine("错误！订单号必须是整数！");
                            break;
                        }
                        Console.WriteLine("请输入用户ID：");
                        str2 = Console.ReadLine();
                        if (!int.TryParse(str2, out Userid))
                        {
                            Console.WriteLine("错误！用户ID必须是整数！");
                            break;
                        }
                        Console.WriteLine("请输入用户名称：");
                        str3 = Console.ReadLine();
                        Console.WriteLine("---------------------------------");
                        manager.AddOrder(Orderid, Userid, str3);
                        break;
                 case 'b':
                        Console.WriteLine("请输入订单号：");
                        if (!int.TryParse(Console.ReadLine(), out Orderid))
                        {
                            Console.WriteLine("错误！订单号必须是整数！");
                            break;
                        }
                        Console.WriteLine("请输入商品名称：");
                        str1 = Console.ReadLine();
                        Console.WriteLine("请输入商品单价：");
                        if (!double.TryParse(Console.ReadLine(),out price))
                        {
                            Console.WriteLine("错误！单价必须是浮点数！");
                            break;
                        }
                        Console.WriteLine("请输入商品数量：");
                        if (!int.TryParse(Console.ReadLine(),out count))
                        {
                            Console.WriteLine("错误！数量必须是整数！");
                            break;
                        }
                        Console.WriteLine("---------------------------------");
                        manager.AddItemToOrder(Orderid,str1,price,count);
                        break;
                 case 'c':
                        Console.WriteLine("请输入订单号：");
                        if (!int.TryParse(Console.ReadLine(), out Orderid))
                        {
                            Console.WriteLine("错误！订单号必须是整数！");
                            break;
                        }
                        Console.WriteLine("---------------------------------");
                        manager.DeleteOrder(Orderid);
                        break;
                 case 'd':
                        Console.WriteLine("请输入订单号：");
                        if (!int.TryParse(Console.ReadLine(), out Orderid))
                        {
                            Console.WriteLine("错误！订单号必须是整数！");
                            break;
                        }
                        Console.WriteLine("请输入商品名称：");
                        str1 = Console.ReadLine();
                        Console.WriteLine("---------------------------------");
                        manager.DeleteItem(Orderid, str1);
                        break;
                 case 'e':
                        Console.WriteLine("请输入订单号：");
                        if (!int.TryParse(Console.ReadLine(), out Orderid))
                        {
                            Console.WriteLine("错误！订单号必须是整数！");
                            break;
                        }
                        Console.WriteLine("---------------------------------");
                        manager.FindOrderID(Orderid);
                        break;
                 case 'f':
                        Console.WriteLine("请输入用户名：");
                        str1 = Console.ReadLine();
                        Console.WriteLine("---------------------------------");
                        manager.FindUserName(str1);
                        break;
                 case 'g':
                        Console.WriteLine("---------------------------------");
                        manager.FindAll();
                        break;
                 case 'x': break;
                 default: Console.WriteLine("无效操作符！"); break;
                }
                if (op == 'x') break;
            }

        }

        static void InitDB()
        {
            using (var db = new OrderContext())
            {
                var Order1 = new Order { UserID = 1, UserName = "yyz", Time = DateTime.Now };//id=1
                Order1.Items = new List<Item>() {
                    new Item { Name = "精品蔬菜", Count = 1, SinglePrice = 5.0},
                    new Item { Name = "精品水果", Count = 5, SinglePrice = 10.0}
                };
                db.Orders.Add(Order1);

                var Order2 = new Order { UserID = 2, UserName = "lsq", Time = DateTime.Now };//id=2
                Order2.Items = new List<Item>() {
                    new Item { Name = "精品蔬菜", Count = 1, SinglePrice = 5.0 },
                    new Item { Name = "精品猪肉", Count = 3, SinglePrice = 15.0 }
                };
                db.Orders.Add(Order2);

                db.SaveChanges();

            }
        }
    }
}

/*
修改之前做的订单程序，基于EF框架，将订单保存到MySql数据库中，并实现订单的增删改查功能
*/
