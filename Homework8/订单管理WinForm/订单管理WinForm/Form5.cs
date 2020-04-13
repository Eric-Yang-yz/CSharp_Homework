using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 订单管理WinForm
{
    public partial class Form5 : Form
    {
        public string OrderNumber;
        public string ItemNumber;
        public bool isDelete = false;

        public Form5(string OrderNumber,string ItemNumber)
        {
            InitializeComponent();
            this.OrderNumber = OrderNumber;
            this.ItemNumber = ItemNumber;
            txtOrderNumber.Text = OrderNumber;
            txtItemNumber.Text = ItemNumber;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text == "" || txtItemNumber.Text == "")
            {
                lblAlert.Text = "错误：不能有输入项为空！";
            }
            else
            {
                lblAlert.Text = "";
                OrderNumber = txtOrderNumber.Text;
                ItemNumber = txtItemNumber.Text;
                isDelete = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isDelete = false;
            this.Close();
        }
    }
}
