using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    [Serializable]
    public class User//用户类
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "ID：" + ID + " 姓名：" + Name;
        }

        public override bool Equals(object obj)
        {
            User u = obj as User;
            return u != null && u.ID == ID;
        }

        public User(string id,string name)
        {
            ID = id;
            Name = name;
        }

        public User() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderManager manager = new OrderManager();

            User CurrentUser = new User("789", "YYZ");
            Order NewOrder = new Order("001", CurrentUser);
            manager.AddOrder(NewOrder);

            OrderItem NewItem = new OrderItem("10001","精品蔬菜",5,5);
            manager.AddItemToOrder("001", NewItem);
            NewItem = new OrderItem("10002", "精品水果", 10, 2);
            manager.AddItemToOrder("001", NewItem);

            CurrentUser = new User("987", "AAA");
            NewOrder = new Order("002", CurrentUser);
            manager.AddOrder(NewOrder);

            NewItem = new OrderItem("10001", "精品蔬菜", 5, 10);
            manager.AddItemToOrder("002", NewItem);
            NewItem = new OrderItem("10003", "精品猪肉", 50, 1);
            manager.AddItemToOrder("002", NewItem);

            string str1, str2, str3;
            double price;int count;
            while (true)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("欢迎使用YYZ的订单查询系统！\n操作码：（a）添加订单 （b）向指定订单添加商品 （c）删除订单 （d）删除商品\n（e）查询订单号 （f）查询含有某商品的订单 （g）查询某用户的订单\n（h）显示所有订单 （i）对所有订单按编号排序 （j）导出订单 （k）导入xml文件（x）退出");
                Console.Write("请输入操作码：");
                string str = Console.ReadLine();
                char op;
                while (!char.TryParse(str,out op))
                {
                    Console.WriteLine("非法字符！请重新输入！");
                    str = Console.ReadLine();
                }
                try
                {
                    switch (op)
                    {
                        case 'a':
                            Console.WriteLine("请输入订单号：");
                            str1 = Console.ReadLine();
                            Console.WriteLine("请输入用户ID：");
                            str2 = Console.ReadLine();
                            Console.WriteLine("请输入用户名称：");
                            str3 = Console.ReadLine();
                            Console.WriteLine("---------------------------------");
                            CurrentUser = new User(str2, str3);
                            NewOrder = new Order(str1, CurrentUser);
                            manager.AddOrder(NewOrder);
                            break;
                        case 'b':
                            Console.WriteLine("请输入订单号：");
                            str1 = Console.ReadLine();
                            Console.WriteLine("请输入商品编号：");
                            str2 = Console.ReadLine();
                            Console.WriteLine("请输入商品名称：");
                            str3 = Console.ReadLine();
                            Console.WriteLine("请输入商品单价：");
                            price = double.Parse(Console.ReadLine());
                            Console.WriteLine("请输入商品数量：");
                            count = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------");
                            NewItem = new OrderItem(str2, str3, price, count);
                            manager.AddItemToOrder(str1, NewItem);
                            break;
                        case 'c':
                            Console.WriteLine("请输入订单号：");
                            str1 = Console.ReadLine();
                            Console.WriteLine("---------------------------------");
                            manager.DeleteOrder(str1);
                            break;
                        case 'd':
                            Console.WriteLine("请输入订单号：");
                            str1 = Console.ReadLine();
                            Console.WriteLine("请输入商品编号：");
                            str2 = Console.ReadLine();
                            Console.WriteLine("---------------------------------");
                            NewItem = new OrderItem(str2);
                            manager.DeleteItemInOrder(str1, NewItem);
                            break;
                        case 'e':
                            Console.WriteLine("请输入订单号：");
                            str1 = Console.ReadLine();
                            Console.WriteLine("---------------------------------");
                            manager.FindOrderNumber(str1);
                            break;
                        case 'f':
                            Console.WriteLine("请输入商品编号：");
                            str2 = Console.ReadLine();
                            Console.WriteLine("---------------------------------");
                            NewItem = new OrderItem(str2);
                            manager.FindItem(NewItem);
                            break;
                        case 'g':
                            Console.WriteLine("请输入用户ID：");
                            str2 = Console.ReadLine();
                            Console.WriteLine("---------------------------------");
                            CurrentUser = new User(str2, null);
                            manager.FindCustomer(CurrentUser);
                            break;
                        case 'h':
                            Console.WriteLine("---------------------------------");
                            manager.GetAll();break;
                        case 'i':
                            Console.WriteLine("---------------------------------");
                            manager.SortOrder();break;
                        case 'j':
                            Console.WriteLine("---------------------------------");
                            manager.Export(null);break;
                        case 'k':
                            Console.WriteLine("---------------------------------");
                            manager.Import(null); break;
                        case 'x':break;
                        default: Console.WriteLine("无效操作符！"); break;
                    }
                }
                catch(EditFailException e)
                {
                    Console.WriteLine("操作失败，原因：" + e.message);
                }
                if (op == 'x') break;
            }
        }
    }
}
/*
写一个订单管理的控制台程序，能够实现
添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），
订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
*/
