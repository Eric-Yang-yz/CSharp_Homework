using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework3
{
    public interface Shape
    {
        double Area { get; }
        bool IsTrue();
    }
    public class Rectangle:Shape
    {
        private double length;
        private double width;
        public bool IsTrue()
        {
            return length > 0 && width > 0;
        }
        public double Length
        {
            get => length;
            set
            {
                if (value < 0) throw new ArgumentException($"{value}");
                else length = value;
            }
        }
        public double Width
        {
            get => length;
            set
            {
                if (value < 0) throw new ArgumentException($"{value}");
                else width = value;
            }
        }
        public double Area
        {
            get
            {
                if (IsTrue()) return length * width;
                else throw new Exception();
            }
        }
        public Rectangle()
        {
            length = width = 0;
        }
        public Rectangle(double Length,double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
    }
    //---------------
    public class Square:Shape
    {
        private double side;
        public bool IsTrue()
        {
            return side > 0;
        }
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value < 0) throw new ArgumentException($"{value}");
                else side = value;
            }
        }
        public double Area
        {
            get
            {
                if (IsTrue()) return side * side;
                else throw new Exception();
            }
        }
        public Square()
        {
            side = 0;
        }
        public Square(double Side)
        {
            this.Side = Side;
        }
    }
    //------------------
    public class Triangle:Shape
    {
        private double a, b, c;
        public bool IsTrue()
        {
            return a + b > c && a + c > b && b + c > a;
        }
        public double Area
        {
            get
            {
                if (IsTrue())
                {
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
                else throw new Exception();
            }
        }
        public double Side1
        {
            get => a;
            set
            {
                if (value < 0) throw new ArgumentException($"{value}");
                else a = value;
            }
        }
        public double Side2
        {
            get => b;
            set
            {
                if (value < 0) throw new ArgumentException($"{value}");
                else b = value;
            }
        }
        public double Side3
        {
            get => c;
            set
            {
                if (value < 0) throw new ArgumentException($"{value}");
                else c = value;
            }
        }
        public Triangle()
        {
            Side1 = Side2 = Side3 = 0;
        }
        public Triangle(double Side1,double Side2,double Side3)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
            this.Side3 = Side3;
        }
    }
    //----------------------
    public class ShapeFactory
    {
        static public Shape GetShape(string ShapeType,double a=0,double b=0,double c=0)
        {
            if (ShapeType == null)
            {
                return null;
            }
            else if (ShapeType.Equals("Rectangle"))
            {
                return new Rectangle(a, b);
            }
            else if (ShapeType.Equals("Square"))
            {
                return new Square(a);
            }
            else if (ShapeType.Equals("Triangle"))
            {
                return new Triangle(a, b, c);
            }
            else return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] Type = new[] { "Rectangle", "Square", "Triangle" };
            Random rnd = new Random();
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                Shape NewShape = null;
                int flag = rnd.Next(1, 4);
                do
                {
                    switch (flag)
                    {
                        case 1: NewShape = ShapeFactory.GetShape(Type[0], rnd.Next(1, 10), rnd.Next(1, 10)); break;
                        case 2: NewShape = ShapeFactory.GetShape(Type[1], rnd.Next(1, 10)); break;
                        case 3: NewShape = ShapeFactory.GetShape(Type[2], rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10)); break;
                        default: break;
                    }
                } while (!NewShape.IsTrue());//直到生成合法图形
                switch (flag)
                {
                    case 1: Console.WriteLine("生成了一个长方形"); break;
                    case 2: Console.WriteLine("生成了一个正方形"); break;
                    case 3: Console.WriteLine("生成了一个三角形"); break;
                    default: break;
                }
                total += NewShape.Area;
            }
            Console.WriteLine("十个图形的总面积是：" + total);
        }
    }
}
