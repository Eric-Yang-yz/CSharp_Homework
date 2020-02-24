using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Int64 num1, num2;
                char ch;
                Console.WriteLine("计算器");
                Console.WriteLine("--------------------");
                Console.WriteLine("输入一个数a");
                num1 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("输入另一个数b");
                num2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("输入计算方式（+ - * /）");
                ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case '+': Console.WriteLine("答案是：" + (num1 + num2)); break;
                    case '-': Console.WriteLine("答案是：" + (num1 - num2)); break;
                    case '*': Console.WriteLine("答案是：" + (num1 * num2)); break;
                    case '/':
                        while (num2 == 0)
                        {
                            Console.WriteLine("除数不能为零，输入新的除数");
                            num2 = Convert.ToInt64(Console.ReadLine());
                        }
                        Console.WriteLine("答案是：" + (Double.Parse(num1.ToString()) / Double.Parse(num2.ToString())));
                        break;
                    default: Console.WriteLine("非法运算符"); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Error!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Error!");
            }
        }
    }
}
