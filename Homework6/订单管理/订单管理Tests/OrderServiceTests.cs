using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace homework5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        Order TestOrder;
        OrderItem TestItem;
        User TestUser;
        OrderService TestServer;

        [TestInitialize]
        public void Initialize()
        {
            TestUser = new User("001", "test");
            TestItem = new OrderItem("10001", "精品牛奶", 50, 1);
            TestOrder = new Order("001", TestUser);
            TestServer = new OrderService();
        }

        [TestMethod()]
        public void AddOrderTest1()
        {
            int OldNum = TestServer.Orders.Count;
            TestServer.AddOrder(TestOrder);
            Assert.AreEqual(OldNum + 1, TestServer.Orders.Count);
        }
        [TestMethod()]
        public void AddOrderTest2()
        {
            string OrderID = "001";
            TestServer.AddOrder(TestOrder);
            Assert.AreEqual(OrderID, TestServer.Orders.FirstOrDefault<Order>().OrderNumber);
        }
        [TestMethod()]
        public void AddOrderTest3()
        {
            TestServer.AddOrder(TestOrder);
            Assert.AreEqual(false, TestServer.AddOrder(TestOrder));
        }

        [TestMethod()]
        public void DeleteOrderTest1()
        {
            TestServer.AddOrder(TestOrder);
            int OldNum = TestServer.Orders.Count;
            TestServer.DeleteOrder("001");
            Assert.AreEqual(OldNum - 1, TestServer.Orders.Count);
        }
        [TestMethod()]
        public void DeleteOrderTest2()
        {
            TestServer.AddOrder(TestOrder);
            int OldNum = TestServer.Orders.Count;
            Assert.AreEqual(false, TestServer.DeleteOrder("002"));
            Assert.AreEqual(OldNum, TestServer.Orders.Count);
        }

        [TestMethod()]
        public void AddItemToOrderTest1()
        {
            TestServer.AddOrder(TestOrder);
            int OldNum = TestServer.Orders.FirstOrDefault<Order>().Items.Count;
            TestServer.AddItemToOrder("001", TestItem);
            Assert.AreEqual(OldNum + 1, TestServer.Orders.FirstOrDefault<Order>().Items.Count);
        }
        [TestMethod()]
        public void AddItemToOrderTest2()
        {
            TestServer.AddOrder(TestOrder);
            int OldNum = TestServer.Orders.FirstOrDefault<Order>().Items.Count;
            Assert.AreEqual(false, TestServer.AddItemToOrder("002", TestItem));
            Assert.AreEqual(OldNum, TestServer.Orders.FirstOrDefault<Order>().Items.Count);
        }

        [TestMethod()]
        public void DeleteItemInOrderTest1()
        {
            TestServer.AddOrder(TestOrder);
            TestServer.AddItemToOrder("001", TestItem);
            int OldNum = TestServer.Orders.FirstOrDefault<Order>().Items.Count;
            TestServer.DeleteItemInOrder("001", TestItem);
            Assert.AreEqual(OldNum - 1, TestServer.Orders.FirstOrDefault<Order>().Items.Count);
        }
        [TestMethod()]
        public void DeleteItemInOrderTest2()
        {
            TestServer.AddOrder(TestOrder);
            TestServer.AddItemToOrder("001", TestItem);
            int OldNum = TestServer.Orders.FirstOrDefault<Order>().Items.Count;
            Assert.AreEqual(false, TestServer.DeleteItemInOrder("002", TestItem));
            Assert.AreEqual(OldNum, TestServer.Orders.FirstOrDefault<Order>().Items.Count);
        }
        [TestMethod()]
        public void DeleteItemInOrderTest3()
        {
            TestServer.AddOrder(TestOrder);
            TestServer.AddItemToOrder("001", TestItem);
            int OldNum = TestServer.Orders.FirstOrDefault().Items.Count;
            TestItem = new OrderItem("10002");
            Assert.AreEqual(false, TestServer.DeleteItemInOrder("001", TestItem));
            Assert.AreEqual(OldNum, TestServer.Orders.FirstOrDefault().Items.Count);
        }

        [TestMethod()]
        public void FindOrderNumberTest1()
        {
            TestServer.AddOrder(TestOrder);
            var query = TestServer.FindOrderNumber("001");
            Assert.AreEqual("001", query.FirstOrDefault().OrderNumber);
        }
        [TestMethod()]
        public void FindOrderNumberTest2()
        {
            TestServer.AddOrder(TestOrder);
            var query = TestServer.FindOrderNumber("002");
            Assert.IsNull(query.FirstOrDefault());
        }

        [TestMethod()]
        public void FindItemTest1()
        {
            TestServer.AddOrder(TestOrder);
            TestServer.AddItemToOrder("001", TestItem);
            var query = TestServer.FindItem(TestItem);
            Assert.AreEqual(TestOrder.OrderNumber, query.FirstOrDefault().OrderNumber);
        }
        [TestMethod()]
        public void FindItemTest2()
        {
            TestServer.AddOrder(TestOrder);
            TestServer.AddItemToOrder("001", TestItem);
            TestItem = new OrderItem("10002");
            var query = TestServer.FindItem(TestItem);
            Assert.IsNull(query.FirstOrDefault());
        }

        [TestMethod()]
        public void FindCustomerTest1()
        {
            TestServer.AddOrder(TestOrder);
            var query = TestServer.FindCustomer(TestUser);
            Assert.AreEqual(TestUser.ID, query.FirstOrDefault().GetUser().ID);
        }
        [TestMethod()]
        public void FindCustomerTest2()
        {
            TestServer.AddOrder(TestOrder);
            TestUser = new User("002", null);
            var query = TestServer.FindCustomer(TestUser);
            Assert.IsNull(query.FirstOrDefault());
        }

        [TestMethod()]
        public void GetAllTest()
        {
            TestServer.AddOrder(TestOrder);
            var query = TestServer.GetAll();
            List<Order> list = query.ToList();
            Assert.AreEqual(TestServer.Orders.Count, list.Count);
        }

        [TestMethod()]
        public void SortOrderTest()
        {
            TestOrder = new Order("002", null);
            TestServer.AddOrder(TestOrder);
            TestOrder = new Order("001", null);
            TestServer.AddOrder(TestOrder);
            TestServer.SortOrder();
            Assert.AreEqual("001", TestServer.Orders.FirstOrDefault().OrderNumber);
            Assert.AreEqual("002", TestServer.Orders[1].OrderNumber);
        }

        [TestMethod()]
        public void ExportTest()
        {
            TestServer.Export(null);
            FileStream fs = new FileStream("Orders.xml", FileMode.Open);
        }
    }
}