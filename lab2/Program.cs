using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабараторная работа№2\nВыполнил - Outs1de -iwnl-");

            Rectangle a = new Rectangle() {Name = "Прямоугольник A" ,Width = 15.2, Height = 13.7 };
            Rectangle b = new Rectangle() { Name ="Прямоугольник B", Width= 5.1, Height = 2.8};
            Console.WriteLine($"Название фигуры: {a.Name}");
            Console.WriteLine($"Площадь фигуры: { a.GetArea()}");
            Console.WriteLine($"\nНазвание фигуры: {b.Name}");
            Console.WriteLine($"Площадь фигуры: {b.GetArea()}");

            Сircle circle = new Сircle() {Name = "Круг", Radius = 20 };
            Square square = new Square() {Name = "Квадрат", Width = 20 };
            Triangle triangle = new Triangle() {Name="Треугольник", Height= 20, Base = 30};
            Rhombus rhombus = new Rhombus() {Name ="Ромб", diagonalOne = 3, diagonalTwo = 40 };
            Trapeze trapeze = new Trapeze() {Name = "Трапеция", Top= 3, Bottom = 40, Height = 50};
            Parallelogram parallelogram = new Parallelogram() {Name = "Параллелограмм", Bottom = 30, Height = 40};
            Pentagon pentagon = new Pentagon() {Name = "Пятиугольник", sideLength = 50};
            Decagon decagon = new Decagon() {Name = "Десятиугольник", sideLength = 70 };

            Console.WriteLine($"\nНазвание фигуры: {circle.Name}");
            Console.WriteLine($"Площадь фигуры: {circle.GetArea()}");
            Console.WriteLine($"\nНазвание фигуры: {square.Name}");
            Console.WriteLine($"Плозадь фигуры: {square.GetArea()}");
            Console.WriteLine($"\nНазвание фигуры: {triangle.Name}");
            Console.WriteLine($"Площадь фигуры: {triangle.GetArea()}");
            Console.WriteLine($"\nНазвание фигуры: {trapeze.Name}");
            Console.WriteLine($"Площадь фигуры: {trapeze.GetArea()}");
            Console.WriteLine($"\nНазвание фигуры: {rhombus.Name}");
            Console.WriteLine($"Площадь фигуры: {rhombus.GetArea()}");
            Console.WriteLine($"\nНазвание фигуры: {parallelogram.Name}");
            Console.WriteLine($"Площадь фигуры: {parallelogram.GetArea()}");
            Console.WriteLine($"\nНазвание фигуры: {pentagon.Name}");
            Console.WriteLine($"Площадь фигуры: {pentagon.GetArea()}");
            Console.WriteLine($"\nНазвание фигуры: {decagon.Name}");
            Console.WriteLine($"Площадь фигуры: {decagon.GetArea()}");
        }
    }
}
