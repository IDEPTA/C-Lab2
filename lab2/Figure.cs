using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public abstract double GetArea();
    }

    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Square : Figure
    {
        public double Width { get; set; }
        public override double GetArea()
        {
            return Math.Pow(Width, 2);
        }
    }
    class Сircle : Figure
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return 2 * Math.PI * Math.Pow(Radius, 2);
        }
    }
    class Triangle : Figure
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
    class Rhombus : Figure
    {
        public double diagonalOne { get; set; }
        public double diagonalTwo { get; set; }
        public override double GetArea()
        {
            return 0.5 * diagonalOne * diagonalTwo;
        }
    }

    class Trapeze : Figure
    {
        public double Top { get; set; }
        public double Bottom { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return 0.5 * (Top + Bottom) * Height;
        }
    }
    class Parallelogram : Figure
    {
        public double Bottom { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Height*Bottom;
        }
    }
    class Pentagon : Figure
    {
        public double sideLength { get; set; }
        public override double GetArea()
        {
            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(sideLength, 2);
        }
    }
    class Decagon : Figure
    {
        public double sideLength { get; set; }
        public override double GetArea()
        {
            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(sideLength, 2) * 10;
        }
    }

}
