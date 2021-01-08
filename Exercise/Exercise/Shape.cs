using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public interface IShape
    {
        void ShowInfo();
        float CalculationPerimeter();
        string GetShapeType();
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

        public void ShowInfo()
        {
            Console.WriteLine(string.Format("Rectangle({0}, {1})", a, b));
        }

        public float CalculationPerimeter()
        {
            return (a + b) * 2;
        }

        public string GetShapeType()
        {
            return "Rectangle";
        }
    }

    public class Square: IShape
    {
        private float a;
        public Square(float a)
        {
            this.a = a;
        }

        public float CalculationPerimeter()
        {
            return a * 4;
        }

        public void ShowInfo()
        {
            Console.WriteLine(string.Format("Square({0})", a));
        }

        public string GetShapeType()
        {
            return "Square";
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
        
        public float CalculationPerimeter()
        {
            return a + b + c;
        }

        public void ShowInfo()
        {
            Console.WriteLine(string.Format("Triangle({0}, {1}, {2})", a, b, c));
        }

        public string GetShapeType()
        {
            return "Triangle";
        }
    }

    public class Circle : IShape
    {
        private float a;
        public Circle(float a)
        {
            this.a = a;
        }

        public float CalculationPerimeter()
        {
            return a * 2 * 3.14f;
        }

        public void ShowInfo()
        {
            Console.WriteLine(string.Format("Circle({0})", a));
        }

        public string GetShapeType()
        {
            return "Circle";
        }
    }
}
