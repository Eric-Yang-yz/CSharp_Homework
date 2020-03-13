using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_1
{
    public class Node<T>//链表结点
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>//泛型链表类
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void Foreach(Action<T> action)
        {
            Node<T> Temp = head;
            action(Temp.Data);
            while(Temp != tail)
            {
                Temp = Temp.Next;
                action(Temp.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<double> Glist = new GenericList<double>();
            Console.WriteLine("请输入5个浮点数！(每行一个)");
            int i = 0;
            while(i < 5)
            {
                double Data;
                if (!double.TryParse(Console.ReadLine(), out Data)) Console.WriteLine("非法输入，请重新输入！");
                else
                {
                    i++;
                    Glist.Add(Data);
                }
            }
            //打印所有元素
            Console.WriteLine("以下是链表中所有元素：");
            Glist.Foreach(m => Console.Write(m + " "));
            Console.WriteLine();
            //求最大值
            double max = double.MinValue;
            Glist.Foreach(m => { if (m > max) max = m; });
            Console.WriteLine("最大值是：" + max);
            //求最小值
            double min = double.MaxValue;
            Glist.Foreach(m => { if (m < min) min = m; });
            Console.WriteLine("最小值是：" + min);
            //求和
            double sum = 0;
            Glist.Foreach(m => sum += m);
            Console.WriteLine("所有数之和是：" + sum);
        }
    }
}
