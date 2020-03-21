using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class OrderItem//商品，默认商品号是唯一的，且不能有多条同一商品的信息
    {
        int Count { get; set; }
        string Name { get; set; }
        string ItemNumber { get; set; }
        double SinglePrice { get; set; }

        public double TotalPrice
        {
            get => SinglePrice * Count;
        }

        public override bool Equals(object obj)//根据商品编号来判断是否相同
        {
            OrderItem item = obj as OrderItem;
            return item != null && item.ItemNumber == ItemNumber;
        }

        public override string ToString()
        {
            return "{商品编号：" + ItemNumber + " 商品名称：" + Name + " 单价：" + SinglePrice + " 数量：" + Count + " 总价：" + TotalPrice + "}";
        }

        public OrderItem(string number, string name="", double singleprice=0, int count=0)
        {
            Name = name;
            ItemNumber = number;
            SinglePrice = singleprice;
            Count = count;
        }
    }
}
