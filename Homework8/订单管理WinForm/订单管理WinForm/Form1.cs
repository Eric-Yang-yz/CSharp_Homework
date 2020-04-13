using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework5;

namespace 订单管理WinForm
{
    public partial class Form1 : Form
    {
        public OrderService Manager { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Manager = new OrderService();
            User CurrentUser = new User("789", "YYZ");
            Order NewOrder = new Order("001", CurrentUser);
            Manager.AddOrder(NewOrder);

            OrderItem NewItem = new OrderItem("10001", "精品蔬菜", 5, 5);
            Manager.AddItemToOrder("001", NewItem);
            NewItem = new OrderItem("10002", "精品水果", 10, 2);
            Manager.AddItemToOrder("001", NewItem);

            CurrentUser = new User("987", "AAA");
            NewOrder = new Order("002", CurrentUser);
            Manager.AddOrder(NewOrder);

            NewItem = new OrderItem("10001", "精品蔬菜", 5, 10);
            Manager.AddItemToOrder("002", NewItem);
            NewItem = new OrderItem("10003", "精品猪肉", 50, 1);
            Manager.AddItemToOrder("002", NewItem);
            orderBindingSource.DataSource = Manager.Orders;
            lblCurrentOrder.DataBindings.Add("Text", orderBindingSource, "OrderNumber");
            lblCurrentState.Text = "就绪";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            User SearchUser;
            OrderItem SearchItem;
            IEnumerable<Order> query;
            switch(cmbSearch.SelectedIndex)
            {
                case 0:
                    query = Manager.FindOrderNumber(txtSearch.Text);
                    if (query.Count() != 0)
                    {
                        orderBindingSource.DataSource = query;
                        lblCurrentState.Text = "就绪";
                    }
                    else
                    {
                        orderBindingSource.DataSource = Manager.Orders;
                        lblCurrentState.Text = "未找到指定订单！";
                    }
                    break;
                case 1:
                    SearchUser = new User(txtSearch.Text, null);
                    query = Manager.FindCustomer(SearchUser);
                    if (query.Count() != 0)
                    {
                        orderBindingSource.DataSource = query;
                        lblCurrentState.Text = "就绪";
                    }
                    else
                    {
                        orderBindingSource.DataSource = Manager.Orders;
                        lblCurrentState.Text = "未找到指定订单！";
                    }
                    break;
                case 2:
                    SearchItem = new OrderItem(txtSearch.Text);
                    query = Manager.FindItem(SearchItem);
                    if (query.Count() != 0)
                    {
                        orderBindingSource.DataSource = query;
                        lblCurrentState.Text = "就绪";
                    }
                    else
                    {
                        orderBindingSource.DataSource = Manager.Orders;
                        lblCurrentState.Text = "未找到指定订单！";
                    }
                    break;
                default:lblCurrentState.Text = "未选择查询条件！"; break;
            }
        }

        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Manager.Orders;
            lblCurrentState.Text = "就绪";
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (f2.isAdd == true)
                if (Manager.AddOrder(f2.NewOrder)) lblCurrentState.Text = "订单添加成功！";
                else lblCurrentState.Text = "订单添加失败，原因是订单号已存在！";
            else lblCurrentState.Text = "就绪";
            orderBindingSource.DataSource = Manager.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            Order CurrentOrder = orderBindingSource.Current as Order;
            Form3 f3 = new Form3(CurrentOrder.OrderNumber);
            f3.ShowDialog();
            if (f3.isDelete == true)
                if (Manager.DeleteOrder(f3.DeleteOrderNumber)) lblCurrentState.Text = "订单删除成功！";
                else lblCurrentState.Text = "订单删除失败，原因是找不到订单号！";
            else lblCurrentState.Text = "就绪";
            orderBindingSource.DataSource = Manager.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Order CurrentOrder = orderBindingSource.Current as Order;
            Form4 f4 = new Form4(CurrentOrder.OrderNumber);
            f4.ShowDialog();
            if (f4.isAdd == true)
                if (Manager.AddItemToOrder(f4.OrderNumber,f4.NewItem)) lblCurrentState.Text = "明细添加成功！";
                else lblCurrentState.Text = "明细添加失败，原因是找不到订单号或者该编号商品已经存在！";
            else lblCurrentState.Text = "就绪";
            orderBindingSource.DataSource = Manager.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            Order CurrentOrder = orderBindingSource.Current as Order;
            OrderItem CurrentItem = itemsBindingSource.Current as OrderItem;
            Form5 f5 = new Form5(CurrentOrder.OrderNumber,CurrentItem.ItemNumber);
            f5.ShowDialog();
            if (f5.isDelete == true)
                if (Manager.DeleteItemInOrder(f5.OrderNumber, new OrderItem(f5.ItemNumber))) lblCurrentState.Text = "明细删除成功！";
                else lblCurrentState.Text = "明细删除失败，原因是找不到订单号或者不存在该编号商品！";
            else lblCurrentState.Text = "就绪";
            orderBindingSource.DataSource = Manager.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Order CurrentOrder = orderBindingSource.Current as Order;
            OrderItem CurrentItem = itemsBindingSource.Current as OrderItem;
            Form6 f6 = new Form6(CurrentOrder.OrderNumber, CurrentItem);
            f6.ShowDialog();
            if (f6.isUpdate == true)
            {
                Manager.DeleteItemInOrder(CurrentOrder.OrderNumber, CurrentItem);
                Manager.AddItemToOrder(CurrentOrder.OrderNumber, f6.NewItem);
                lblCurrentState.Text = "明细修改成功！";
            }
            else lblCurrentState.Text = "就绪";
            orderBindingSource.DataSource = Manager.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Manager.Export(null);
            lblCurrentState.Text = "导出成功！";
            orderBindingSource.DataSource = Manager.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!Manager.Import(null)) lblCurrentState.Text = "导入失败，原因是文件不存在！";
            else lblCurrentState.Text = "导入成功！";
            orderBindingSource.DataSource = Manager.Orders;
            orderBindingSource.ResetBindings(false);
        }
    }
}
