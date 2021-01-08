using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    interface Shape
    {
        float Perimeter();
    }

    class Rectangle : Shape
    {
        private float a;
        private float b;

        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public float Perimeter()
        {
            return (a + b) * 2;
        }
    }

    class Square: Shape
    {
        private float a;
        public Square(float a)
        {
            this.a = a;
        }

        public float Perimeter()
        {
            return a * 4;
        }
    }

    class Triangle : Shape
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
        public float Perimeter()
        {
            return a + b + c;
        }
    }

    class Circle : Shape
    {
        private float a;
        public Circle(float a)
        {
            this.a = a;
        }

        public float Perimeter()
        {
            return a * 2 * 3.14f;
        }
    }
}
