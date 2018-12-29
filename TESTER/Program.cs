using System;
using OpticianMathLibrary;

namespace TESTER
{
    class Program
    {
        static void Main(string[] args)
        {
            double diopters = Power.DioptricPower(.333);

            Console.WriteLine($"Unformatted value is {diopters}");

            string frmtDiopters = diopters.ToDiopterFormatThreePlaces();



            Console.WriteLine($"Formatted value is {frmtDiopters}");

            Console.ReadLine();
        }
    }
}
