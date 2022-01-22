using System;

namespace Udemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> areaSquare = side => side * side;
            Console.WriteLine(areaSquare(5));

            Func<int, int> division = number => number / 2;
            Console.WriteLine(division(100));

            Func<int, int> adition = number => number / 2;
            Console.WriteLine(adition(50));

            Func<int, int> subtraction = number => number - 212;
            Console.WriteLine(subtraction(312));

            Func<int, int> multiplication = number => number * 2;
            Console.WriteLine(multiplication(12));
        }
    }
}
