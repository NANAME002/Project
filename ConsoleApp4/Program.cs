using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y= ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{x}+{y}={Sum(x,y)}");
            Console.WriteLine($"{x}-{y}={Min(x,y)}");
            Console.WriteLine($"{x}*{y}={Pro(x,y)}");
            Console.WriteLine($"{x}/{y}={Del(x,y):F2}");
            Console.ReadLine();
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Min(double x, double y)
        {
          return x-y;
        }
        public static double Pro(double x, double y)
        {
            return x*y;
        }
        public static double Del(double x, double y)
        {
            return (double)x / y;
        }
    }
}
