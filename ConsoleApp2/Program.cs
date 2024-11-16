using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        public static void Func()
        {
            Console.Write("Ввод a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ввод b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
        }
    }
}
