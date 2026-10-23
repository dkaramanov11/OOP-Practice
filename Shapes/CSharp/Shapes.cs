using System;
using System.Collections.Generic;

namespace OOP_Practice.Shapes.CSharp
{
    internal abstract class Shape
    {
        public string Name { get; }

        protected Shape(string name)
        {
            Name = name;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public void PrintInfo()
        {
            Console.WriteLine($"Shape: {Name}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
        }
    }

    internal class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
            : base("Rectangle")
        {
            if (width <= 0)
            {
                Console.WriteLine(
                    "Width must be greater than 0. Setting it to 1.");

                Width = 1;
            }
            else
            {
                Width = width;
            }

            if (height <= 0)
            {
                Console.WriteLine(
                    "Height must be greater than 0. Setting it to 1.");

                Height = 1;
            }
            else
            {
                Height = height;
            }
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    internal class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
            : base("Circle")
        {
            if (radius <= 0)
            {
                Console.WriteLine(
                    "Radius must be greater than 0. Setting it to 1.");

                Radius = 1;
            }
            else
            {
                Radius = radius;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(4, 3),
                new Circle(2),
                new Rectangle(-4, 3)
            };

            Console.WriteLine();

            foreach (Shape shape in shapes)
            {
                shape.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}