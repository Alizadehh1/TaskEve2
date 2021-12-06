using System;
using MyHelperMethods;

namespace _13cu_tapsiriq
{
    class Program
    {
        //    13) 3 dene 5 reqemli eded var.
        //    Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet.Alinan neticeleri topla
        //    Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            Error1:
            number1 = Reader.ReadInteger("Enter first five-digit number: ");
            number2 = Reader.ReadInteger("Enter second five-digit number: ");
            number3 = Reader.ReadInteger("Enter third five-digit number: ");

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
            if (number2 >= 10000 && number2 <= 99999)
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
            if (number3 >= 10000 && number3 <= 99999)
            {
                Console.WriteLine(number3);
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Enter Correctly!");
                goto Error1;
            }
            Console.Clear();

            int digit1 = number1 / 10000;
            int digit2 = number1 % 10;
            digit1 = digit1 * 10 + digit2;

            digit2 = number2 / 10000;
            int digit3 = number2 % 10;
            digit2 = digit2 * 10 + digit3;

            digit3 = number3 / 10000;
            int digit4 = number3 % 10;
            digit3 = digit3 * 10 + digit4;

            double lastnum = digit1 + digit2 + digit3;
            lastnum = lastnum + (lastnum * 0.5);

            Console.WriteLine($"Your Result: {lastnum}");
        }
    }
}
