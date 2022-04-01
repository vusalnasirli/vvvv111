using ConsoleApp100.MODELS;
using System;

namespace ConsoleApp100
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(4,5));
            Console.WriteLine(Calculator.Subtract(10,5));
            Console.WriteLine(Calculator.Multiply(3, 5));
            Console.WriteLine(Calculator.Divide(10,5));

            int num = 2;
            Console.WriteLine(num.Power(2));
        }
    }
}
