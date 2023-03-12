using System;

namespace Divisibleby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an interger");

            double num = double.Parse(Console.ReadLine());

            if(num > 0 && num % 11 ==0 ) 
            {


                Console.WriteLine($"{num} is divisible by 11.");
            }
            else
            {
                Console.WriteLine($"{num} is not divisible by 11.");
            }
        }
    }
}