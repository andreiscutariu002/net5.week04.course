using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello from program ...");

            int a = ReadNumber();
            int b = ReadNumber();

            int difResult = Dif(a, b);

            Console.WriteLine($"{a} - {b} = {difResult}");

            int addResult = Add(a, b);

            Console.WriteLine($"{a} + {b} = {difResult}");
        }

        public static int ReadNumber()
        {
            Console.Write("Enter a number: ");

            string input = Console.ReadLine();

            return int.Parse(input);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Dif(int a, int b)
        {
            return a - b;
        }
    }
}
