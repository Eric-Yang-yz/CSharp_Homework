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
    public partial class Form2 : Form
    {
        public Order NewOrder;
        public bool isAdd = false;

        public Form2()
        {
            InitializeComponent();
            NewOrder = null;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtOrderNumber.Text==""||txtUserID.Text==""||txtUserName.Text=="")
            {
                lblAlert.Text = "错误：不能有输入项为空！";
            }
            else
            {
                lblAlert.Text = "";
                string OrderNumber = txtOrderNumber.Text;
                User NewUser = new User(txtUserID.Text, txtUserName.Text);
                NewOrder = new Order(OrderNumber, NewUser);
                isAdd = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isAdd = false;
            this.Close();
        }
    }
}
