using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    [Serializable]
    public class Order//订单类，默认订单编号是唯一的
    {
        public List<OrderItem> Items { get; set; }
        public string OrderNumber { get; set; }
        public User Customer { get; set; }
        public DateTime OrderTime { get; set; }

        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (OrderItem item in Items)
                {
                    total += item.TotalPrice;
                }
                return total;
            }
        }

        public override bool Equals(object obj)//订单号相同则订单相同
        {
            Order m = obj as Order;
            return m != null && m.OrderNumber == OrderNumber;
        }

        public bool AddItem(OrderItem item)//明细项相同则增加失败
        {
            foreach(OrderItem m in Items)
            {
                if (item.Equals(m)) return false;
            }
            Items.Add(item);
            return true;
        }
        public bool DeleteItem(OrderItem item)//根据商品编号删除，无要删除的明细则删除失败
        {
            return Items.Remove(item);
        }

        public bool ContianItem(OrderItem item)//是否包含某商品
        {
            bool flag = false;
            foreach(OrderItem m in Items)
            {
                if (m.Equals(item)) { flag = true;break; }
            }
            return flag;
        }

        public User GetUser()//返回用户
        {
            return this.Customer;
        }

        public string GetNumber()
        {
            return OrderNumber;
        }

        public override string ToString()
        {
            StringBuilder ans = new StringBuilder();
            ans.Append("订单号：" + OrderNumber + "\n");
            ans.Append(Customer.ToString() + "\n");
            ans.Append("下单时间：" + OrderTime + "\n");
            foreach (OrderItem item in Items)
            {
                ans.Append(item.ToString() + "\n");
            }
            ans.Append("总金额：" + TotalPrice);
            return ans.ToString();
        }

        public Order(string number, User user)
        {
            Items = new List<OrderItem>();
            OrderNumber = number;
            Customer = user;
            OrderTime = DateTime.Now;
        }

        public Order()
        {
            Items = new List<OrderItem>();
        }
    }
}
