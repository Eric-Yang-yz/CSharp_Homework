using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDB
{
    class Order
    {
        public int OrderID { get; set; }//自动识别主键

        public DateTime Time { get; set; }

        public int UserID { get; set; }
        public string UserName { get; set; }

        public List<Item> Items { get; set; }//一对多关联导航属性

        public override string ToString()
        {
            return "ID:" + OrderID + " 用户:" + UserName + " 下单时间:" + Time;
        }
    }

    class Item
    {
        public int ItemID { get; set; }//自动识别主键,默认从1开始增加
        public int Count { get; set; }
        public double SinglePrice { get; set; }
        public string Name { get; set; }

        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }//多对一关联导航属性

        public override string ToString()
        {
            return "名称:" + Name + " 数量:" + Count + " 单价:" + SinglePrice;
        }
    }
}
