using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组处理
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[5];
            Console.WriteLine("请输入5个数（每行一个）:");
            for (int i=0;i<5;i++)
            {
                string str;
                str = Console.ReadLine();
                while(!int.TryParse(str,out array[i]))
                {
                    Console.WriteLine("该输入不合法！请重新输入");
                    str = Console.ReadLine();
                }
            }
            GetAttribute(array);
        }
        static void GetAttribute(int[] array)
        {
            int max, min, total;
            double average;
            max = int.MinValue; min = int.MaxValue; total = 0;
            foreach (int num in array)
            {
                if (num < min) min = num;
                if (num > max) max = num;
                total += num;
            }
            average = (double)total / 5.0;
            Console.Write("最小值：{0}\n最大值：{1}\n平均数：{2}\n", min, max, average);
        }
    }
}
