using System;
using Stage0Project.Logic;

namespace Stage0Project
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorLogic calc = new CalculatorLogic();
            int result = calc.Add(2, 3);

            Console.WriteLine(result);
        }
    }
}
