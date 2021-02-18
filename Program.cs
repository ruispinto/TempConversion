using System;
using TempConversionClass;

namespace TempConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionCalculator calculator = new ConversionCalculator(32,'F');

            Console.ReadLine();
        }
    }
}
