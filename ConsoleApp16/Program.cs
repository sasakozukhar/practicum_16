using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Printline1();

            Console.WriteLine();
            Printline2();

            Console.WriteLine();
            Printline3();

            Console.WriteLine();
            Printline4();
            Console.Read();
        }
        static void Printline1()
        {
            for (int i = 41; i <= 50; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        static void Printline2()
        {
            for (int i = 51; i <= 60; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        static void Printline3()
        {
            for (int i = 61; i <= 70; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        static void Printline4()
        {
            for (int i = 71; i <= 80; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}
