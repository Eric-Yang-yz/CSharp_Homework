using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = Convert.ToInt32(num1.Text);
                b = Convert.ToInt32(num2.Text);
                switch (Convert.ToChar(comboBox1.Text))
                {
                    case '+': ans_label.Text = (a + b).ToString(); break;
                    case '-': ans_label.Text = (a - b).ToString(); break;
                    case '*': ans_label.Text = (a * b).ToString(); break;
                    case '/':
                        if (b == 0) ans_label.Text = "Divider can't be Zero!";
                        else ans_label.Text = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b));
                        break;
                    default:
                        ans_label.Text = "Operator Error!";
                        break;
                }
            }
            catch (FormatException)
            {
                ans_label.Text = "Format Error!";
            }
            catch (OverflowException)
            {
                ans_label.Text = "Overflow Error!";
            }
            catch (ArgumentNullException)
            {
                ans_label.Text = "NULL Error!";
            }
        }
    }
}
