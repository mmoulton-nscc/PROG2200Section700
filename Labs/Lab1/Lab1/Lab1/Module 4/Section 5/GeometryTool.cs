using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class GeometryTool
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 2 };
            var tri = new Triangle() { Base = 2, Height = 5 };
            var cir = new Circle() { Radius = 2 };

            square.Display();
            tri.Display();
            cir.Display();
        }
    }

    abstract class Shape
    {
        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());
        }
    }

    class Circle : Shape 
    {
        public double Radius;
        public override double GetArea()
        {
            return Math.PI * (Radius*Radius);
        }
    }
    class Square : Shape
    {
        public int Width;
        public override double GetArea()
        {
            return Width * Width;
        }
    }

    class Triangle : Shape
    {
        public int Base;
        public int Height;

        public override double GetArea()
        {
            return (Base * Height) / 2;
        }
    }

}
