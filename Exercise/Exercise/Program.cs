using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            string t;
            Shape s;
            do
            {
                Console.WriteLine("press 0(exit), 1(Rectangle), 2(Square), 3(Triangle), 4(Circle)");
                t = Console.ReadLine();
                switch (t)
                {
                    case "1":
                        Console.Write("a=");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("b=");
                        b = float.Parse(Console.ReadLine());
                        s = new Rectangle(a, b);
                        Console.WriteLine("perimeter: " + s.Perimeter());
                        break;
                    case "2":
                        Console.Write("a=");
                        a = float.Parse(Console.ReadLine());
                        s = new Square(a);
                        Console.WriteLine("perimeter: " + s.Perimeter());
                        break;
                    case "3":
                        Console.Write("a=");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("b=");
                        b = float.Parse(Console.ReadLine());
                        Console.Write("c=");
                        c = float.Parse(Console.ReadLine());
                        s = new Triangle(a, b, c);
                        Console.WriteLine("perimeter: " + s.Perimeter());
                        break;
                    case "4":
                        Console.Write("a=");
                        a = float.Parse(Console.ReadLine());
                        s = new Circle(a);
                        Console.WriteLine("perimeter: " + s.Perimeter());
                        break;
                }
                
            } while (t != "0");
        }

    }
}
