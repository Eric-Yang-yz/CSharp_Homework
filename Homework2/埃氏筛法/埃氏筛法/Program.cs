using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 埃氏筛法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2--100之间所有的素数有：");
            bool[] array = new bool[101];
            for (int i = 2; i <= 100; i++)//初始化数组
                array[i] = true;
            for (int i=2;i<=100;i++)
            {
                if (array[i] == true)
                {
                    for (int mul = 2; mul * i <= 100; mul++)
                        array[mul * i] = false;
                }
            }
            for (int i = 2; i <= 100; i++)
                if (array[i] == true) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
