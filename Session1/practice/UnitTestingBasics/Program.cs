using System;

namespace UnitTestingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int sum = calculator.Add(2, 3);
            Console.WriteLine($"The sum of 2 and 3 is: {sum}");
        }
    }
}
