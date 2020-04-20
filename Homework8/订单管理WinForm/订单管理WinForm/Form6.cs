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
    public partial class Form6 : Form
    {
        public string OrderNumber;
        public OrderItem NewItem;
        public bool isUpdate = false;

        public Form6(string ordernumber,OrderItem CurrentItem)
        {
            InitializeComponent();
            OrderNumber = ordernumber;
            NewItem = CurrentItem;
            ItemBindingSource.DataSource = NewItem;
            txtOrderNumber.Text = ordernumber;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int count;
            double singleprice;
            if (txtOrderNumber.Text == "" || txtItemNumber.Text == "" || txtItemName.Text == "" || txtSinglePrice.Text == "" || txtCount.Text == "")
            {
                lblAlert.Text = "错误：不能有输入项为空！";
            }
            else if (!int.TryParse(txtCount.Text, out count))
            {
                lblAlert.Text = "错误：数量必须是整数！";
            }
            else if (!double.TryParse(txtSinglePrice.Text, out singleprice))
            {
                lblAlert.Text = "错误：单价必须是浮点数！";
            }
            else
            {
                lblAlert.Text = "";
                OrderNumber = txtOrderNumber.Text;
                isUpdate = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            this.Close();
        }
    }
}
