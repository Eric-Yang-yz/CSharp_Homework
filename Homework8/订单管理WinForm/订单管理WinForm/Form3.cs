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
    public partial class Form3 : Form
    {
        public string DeleteOrderNumber = "";
        public bool isDelete = false;
        public string CurrentNumber;

        public Form3(string Current)
        {
            InitializeComponent();
            CurrentNumber = Current;
            txtOrderNumber.Text = CurrentNumber;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text=="")
            {
                lblAlert.Text = "错误：不能有输入项为空！";
            }
            else
            {
                lblAlert.Text = "";
                DeleteOrderNumber = txtOrderNumber.Text;
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
