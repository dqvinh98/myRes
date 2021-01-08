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
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Rectangle(12, 20));
            shapes.Add(new Rectangle(15, 16));
            shapes.Add(new Square(50));
            shapes.Add(new Square(29));
            shapes.Add(new Triangle(4, 5, 6));
            shapes.Add(new Triangle(15, 19, 26));
            shapes.Add(new Circle(22));
            shapes.Add(new Circle(10));

            for (var i=0; i<shapes.Count; i++)
            {
                shapes[i].Info();
                shapes[i].Perimeter();
            }
            Console.ReadKey();
        }

    }
}
