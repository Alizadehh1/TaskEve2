using System;
using MyHelperMethods;

namespace Task_Eve2_
{
    //1) verilmish 4 reqemli ededin reqemlerinin cemini tap
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Error1:
            number=Reader.ReadInteger("Enter four-digit number: ");
            if (number < 1000 || number > 9999)
            {
                Console.Clear();
                Console.WriteLine("Do it Correctly!!");
                goto Error1;
                
            }
            
                int sum = Calculator.SumOfDigits(number);
                Console.WriteLine($"Sum of number's digits: {sum}");

        }
    }
}
