using System;
using MyHelperMethods;

namespace _3cu_tapsiriq
{
    class Program
    {
        //3)Verilmish 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
        static void Main(string[] args)
        {
            int number;
            Error1:
            number = Reader.ReadInteger("Enter nine-digit number: ");
            if (number<100000000 || number>999999999)
            {
                Console.Clear();
                Console.WriteLine("Do it correctly!");
                goto Error1;
            }
            int number1= (number / 1000) % 1000;
            int sum = Calculator.SumOfDigits(number1);
            Console.WriteLine($"Sum of Number's Digits: {sum}");
        }
    }
}
