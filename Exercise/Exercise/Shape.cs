using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public interface IShape
    {
        void calPerimeter();
        void showInfo();
    }

    public class Rectangle : IShape
    {
        private float a;
        private float b;

        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public void showInfo()
        {
            Console.WriteLine(string.Format("Rectangle({0}, {1})",a,b));
        }

        public void calPerimeter()
        {
            Console.WriteLine("Perimeter Rectangle: " + ((a + b) * 2));
        }
    }

    public class Square: IShape
    {
        private float a;
        public Square(float a)
        {
            this.a = a;
        }

        public void calPerimeter()
        {
            Console.WriteLine("Perimeter Square: " + (a*4));
        }

        public void showInfo()
        {
            Console.WriteLine(string.Format("Square({0})", a));
        }
    }

    public class Triangle : IShape
    {
        private float a;
        private float b;
        private float c;
        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void calPerimeter()
        {
            Console.WriteLine("Perimeter Triangle: " + (a+b+c));
        }

        public void showInfo()
        {
            Console.WriteLine(string.Format("Triangle({0}, {1}, {2})", a, b, c));
        }
    }

    public class Circle : IShape
    {
        private float a;
        public Circle(float a)
        {
            this.a = a;
        }

        public void calPerimeter()
        {
            Console.WriteLine("Perimeter Circle: " + (a * 2 * 3.14f));
        }

        public void showInfo()
        {
            Console.WriteLine(string.Format("Circle({0})", a));
        }
    }
}
