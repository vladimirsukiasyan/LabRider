using System;

namespace Lab2
{
    abstract class Figure: IPrint, IComparable
    {
        public abstract double area();

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public int CompareTo(object obj)
        {
            var right = (Figure) obj;
            if (area() < right.area()) return -1;
            if (area() == right.area()) return 0;
            return 1;
        }
    }
    
}