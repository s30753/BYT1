// See https://aka.ms/new-console-template for more information
using System;
using Calc;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc1 = new Calculator(4.5, 4.5, '+');
            Console.WriteLine($"Result: {calc1.Calculate()}");
            
            Calculator calc2 = new Calculator(9.75, 4.5, '-');
            Console.WriteLine($"Result: {calc2.Calculate()}");
            
            Calculator calc3 = new Calculator(13, 4, '/');
            Console.WriteLine($"Result: {calc3.Calculate()}");
        }
    }
}