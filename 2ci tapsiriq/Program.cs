using System;
using MyHelperMethods;

namespace _2ci_tapsiriq
{
    class Program
    {
        //2) verilmish 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3
        static void Main(string[] args)
        {
            int number;
            Error1:
            number = Reader.ReadInteger("Enter Six-digit number: ");
            if (number<100000 || number>999999)
            {
                Console.Clear();
                Console.WriteLine("Do It Correctly!");
                goto Error1;
            }
            int number1 = number / 1000;
            int sum = Calculator.SumOfDigits(number1);
            Console.WriteLine($"Sum Of Number's Digits: {sum}");


        }
    }
}
