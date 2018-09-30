using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(4, 5);
            var square = new Square(6);
            var circle = new Circle(10);

            var figures = new Figure[] {rect, square, circle};

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.area());
            }

            var prints = new IPrint[] {rect, square, circle};
            
            foreach (var print in prints)
            {
                Console.WriteLine(print.Print());
            }
        }
    }
}