using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 素数因子
{
    class Program
    {
        static void Main(string[] args)
        {
            int data;
            string str;
            Console.Write("请输入一个正整数：");
            str=Console.ReadLine();
            while(!int.TryParse(str,out data))
            {
                Console.WriteLine("输入不合法，重新输入!");
                str = Console.ReadLine();
            }
            if (data<=1)
            {
                Console.WriteLine("该数没有质因子");
                return;
            }
            for (int i=2;i*i<=data;i++)
            {
                if (data % i == 0)
                {
                    Console.Write($"{i} ");
                    while(data % i == 0)
                    {
                        data /= i;
                    }
                }
                if (data == 1) break;
            }
            if (data != 1) Console.Write("{0}", data);
            Console.WriteLine("\n以上是该数所有的质因子");
        }
    }
}
