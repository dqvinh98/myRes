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
            shapes.Add(new Rectangle(2, 5));
            shapes.Add(new Rectangle(15, 16));
            shapes.Add(new Square(50));
            shapes.Add(new Square(29));
            shapes.Add(new Triangle(4, 5, 6));
            shapes.Add(new Triangle(15, 19, 26));
            shapes.Add(new Circle(22));
            shapes.Add(new Circle(10));

            for (var i=0; i<shapes.Count; i++)
            {
                shapes[i].ShowInfo();
                Console.WriteLine(shapes[i].GetShapeType()+" Perimeter: " + shapes[i].CalculationPerimeter());
            }
            Console.WriteLine("-------------------------");
            //kiem hinh chu vi lon hon 20
            var shapes20 = from shape in shapes
                    where shape.CalculationPerimeter() > 20
                    select shape;
            Console.WriteLine("Shapes have perimeter bigger than 20");
            var a = shapes.Where(s => s.CalculationPerimeter() > 20).ToList();
            foreach (var s in a)
            {
                s.ShowInfo();
            }
            Console.WriteLine("-------------------------");
            //kiem hinh nao la tam giac
            var triangles = from shape in shapes
                            where shape.GetShapeType() == "Triangle"
                            select shape;
            var b = shapes.Where(s => s.GetType() == typeof(Triangle)).ToList();

            Console.WriteLine("Shapes are Triangle");
            foreach (var s in b)
            {
                s.ShowInfo();
            }
            Console.ReadKey();
        }

    }
}
