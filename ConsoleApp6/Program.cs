﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координаты вершин x1= ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты вершин y2= ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты вершин x2= ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введиет координаты вершин y2= ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"d={Dl(x1, y1, x2, y2):F1}");
            Console.Write("Введите значения a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение с= ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"P={a}+{b}+{c}={Per(a, b, c)}");
            Console.WriteLine($"S={a}+{b}+{c}/2={Plo(a,b,c)}");
            Console.ReadLine();
        }
        public static double Dl(double x1, double y1, double x2, double y2)
        {
            return (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static double Per(double a, double b, double c)
        {
            return a + b + c;
        }
        public static double Plo(double a, double b, double c)
        {
            return (double)(a + b + c) / 2;
        }
    }
}
