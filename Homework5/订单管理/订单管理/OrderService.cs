using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class OrderService
    {
        List<Order> Orders;

        public bool AddOrder(Order order)//添加不同订单号的订单才能成功
        {
            foreach (Order m in Orders)
            {
                if (order.Equals(m)) return false;
            }
            Orders.Add(order);
            return true;
        }

        public bool DeleteOrder(string number)//根据订单号删除订单
        {
            Order m = new Order(number,null);
            return Orders.Remove(m);
        }

        public bool AddItemToOrder(string number,OrderItem item)//向某个订单添加订单明细
        {
            bool flag = false;
            int index;
            Order temp = new Order(number, null);
            for (index=0;index<Orders.Count;index++)//找不到订单返回错误
            {
                if (Orders[index].Equals(temp))
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true) return Orders[index].AddItem(item);
            return flag;
        }

        public bool DeleteItemInOrder(string number,OrderItem item)//删除指定订单中的指定明细
        {
            bool flag = false;
            int index;
            Order temp = new Order(number, null);
            for (index = 0; index < Orders.Count; index++)//找不到订单返回错误
            {
                if (Orders[index].Equals(temp))
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true) return Orders[index].DeleteItem(item);
            else return flag;
        }

        public IEnumerable<Order> FindOrderNumber(string number)//查找指定订单
        {
            Order temp = new Order(number, null);
            var query = from m in Orders
                        where m.Equals(temp)
                        select m;
            return query;
        }

        public IEnumerable<Order> FindItem(OrderItem item)//查找包含指定商品的订单
        {
            var query = from m in Orders
                        where m.ContianItem(item)
                        orderby m.TotalPrice
                        select m;
            return query;
        }

        public IEnumerable<Order> FindCustomer(User user)//查找指定用户的订单
        {
            var query = from m in Orders
                        where user.Equals(m.GetUser())
                        orderby m.TotalPrice
                        select m;
            return query;
        }

        public OrderService()
        {
            Orders = new List<Order>();
        }
    }
}
