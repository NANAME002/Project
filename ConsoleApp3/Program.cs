using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
/// . Вычислить значение функции b = 12a2 + 7a - 6 
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"b={Func()}");
            Console.ReadLine();
        }
        public static double Func()
        {
            Console.Write("Введите a= ");
            double a=Convert.ToDouble(Console.ReadLine());
            return (double)12 * Math.Pow(a, 2) + 7 * a - 6;
        }
    }
}
