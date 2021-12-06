using MyHelperMethods;
using System;

namespace _7ci_tapsiriq
{
    class Program
    {
        //7)Verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir      1234       4321
        static void Main(string[] args)
        {
            int number;
            int digits = 0;
        error1:
            number = Reader.ReadInteger("Enter four-digit number: ");
            if (number < 1000 || number > 9999)
            {
                Console.Clear();
                Console.WriteLine("Do It Correctly!");
                goto error1;
            }

            while (number > 0)
            {
                digits = digits + number % 10;
                digits = digits * 10;
                number = number / 10;
            }
            double digit1 = digits / 10;
            double number1 = ((((digit1 / 10000) + 8) * 100000) + 8);
            Console.WriteLine($"Your Result: {number1}"); 




















        }
    }
}
