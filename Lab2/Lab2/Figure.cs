using System;

namespace Lab2
{
    abstract class Figure: IPrint
    {
        public abstract double area();

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
    
}