using System;
using MyHelperMethods;

namespace _12ci_tapsiriq
{
    class Program
    {
        //    12) 2 dene 5 reqemli eded daxil et.
        //        I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
        //        Neticenin axirina I ededin en axiinci reqemini artir.
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Error1:
            number1 = Reader.ReadInteger("Enter first five-digit number: ");

            number2 = Reader.ReadInteger("Enter second five-digit number: ");

            if (number1 >= 10000 && number1 <= 99999)
            {
                Console.WriteLine(number1);
            }
            
            else
            {
                Console.Clear();
                Console.WriteLine("Enter Correctly!");
                goto Error1;
            }
            Console.Clear();
            if (number2>=10000 && number2<=99999)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Enter Correctly!");
                goto Error1;
            }
            Console.Clear();

            int sum = Calculator.SumOfDigits(number1);
            int multiply = Calculator.MultiplyOfDigits(number2);

            int sum1 = sum + multiply;

            int digit = number1 % 10;

            sum1 = sum1 * 10 + digit;

            Console.WriteLine($"Your Result: {sum1}");




        }
    }
}
