using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FigureCollections;
using Lab3;

namespace Lab2
{
    class Program
    {
                
        static void Main(string[] args)
        {
            //создание экзмепляров классов
            var rect = new Rectangle(4, 5);
            var square = new Square(6);
            var circle = new Circle(10);

            //создание обобщенного списка и вывод
            var arrayList = new ArrayList {square, circle, rect };
            Console.WriteLine("Через необобщенную коллекцию ArrayList ");
            Console.WriteLine("До сортировки:");

            foreach (var figure in arrayList)
            {
                Console.WriteLine(((Figure)figure).area());
            }

            // сортировка и вывод
            arrayList.Sort();            
            Console.WriteLine("\nПосле сортировки:");

            foreach (var figure in arrayList)
            {
                Console.WriteLine(((Figure)figure).area());
            }

            Console.WriteLine("\nТо же самое, но только через обобщенную коллекцию List<T> ");
            //создание необобщенного списка, сортировка и вывод
            var list = new List<Figure>{square, circle, rect};
            list.Sort();
            foreach (var figure in list)
            {
                Console.WriteLine(figure.area());
            }
            
            
            //создание разреженной матрицы
            
            Console.WriteLine("\nМатрица");
            var matrix = new Matrix<Figure>(2, 2, 2, new FigureMatrixCheckEmpty());
            for (var i = 0; i < 2; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    for (var k = 0; k < 2; k++)
                    {
                        matrix[i, j, k] = list[new Random().Next(0,2)];
                    }
                }
            }
            Console.WriteLine(matrix.ToString());
            
            
            Console.WriteLine("Работаем со стеком: ");
            var stack=new SimpleStack<Figure>();
            stack.push(rect);
            stack.push(square);
            stack.push(circle);
            stack.add(circle);

            
            Console.WriteLine("\nВывод стэка простым перебором обычного списка по принципу FIFO: ");
            foreach (var element in stack)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine("\nВывод стэка методом pop() по принципу LIFO: ");
            
            while (stack.count>0)
            {
                Console.WriteLine(stack.pop().ToString());
            }
        }
    }
}