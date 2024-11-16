using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayBay();
            Console.ReadLine();
            

        }
        public static void SayHello()
        {
            Console.WriteLine("Привет");
        }
        public static void SayBay()
        {
            Console.WriteLine("Пока");
        }
    }
}
