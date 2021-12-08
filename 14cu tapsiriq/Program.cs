using MyHelperMethods;
using System;

namespace _14cu_tapsiriq
{
    class Program
    {
        // 14) 4 dene eded daxil et.Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
        // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
        // Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
        // Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
        // Neticenin 60 % tap.Cavabin axirina 60 artir.
        // Neticeden 18% cix.
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            int number4;
        Error1:
            number1 = Reader.ReadInteger("Enter first six-digit number: ");
            number2 = Reader.ReadInteger("Enter second six-digit number: ");
            number3 = Reader.ReadInteger("Enter third six-digit number: ");
            number4 = Reader.ReadInteger("Enter seven-digit number: ");

            if (number1 >= 100000 && number1 <= 999999)
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
            if (number2 >= 100000 && number2 <= 999999)
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
            if (number3 >= 100000 && number3 <= 999999)
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
            if (number4 >= 1000000 && number4 <= 9999999)
            {
                Console.WriteLine(number4);
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Enter Correctly!");
                goto Error1;
            }
            Console.Clear();            

            int num1 = number1 / 1000;
            int num2 = number2 / 1000;
            int num3 = number3 / 1000;
            int num4 = number4 % 10000; //7reqemli son 4 reqemi
            int num5 = number4 / 10000; //7 reqemli ilk 3 reqem

            int multiofnum5 = Calculator.MultiplyOfDigits(num5);

            double num = (((num1 + num2 + num3 + num4) - multiofnum5) * 0.6);   //eded
            double eded1 = (num % 10)/10; //tekce kesr hisse
            int eded2 = (int)num;       //tam hisse
            double eded3;
            double eded4;
            
            if (eded1 > 0 && eded1 < 1)
            {
                eded2 = eded2 * 100 + 60;
                num = eded2 + eded1;
                eded4 = num-(num * 0.18);
                Console.WriteLine(eded4);
            }
            else
            {
                eded2 = eded2 * 100 + 60;
                eded3 = eded2-(eded2 * 0.18);
                Console.WriteLine($"Your Result: {eded3}");
            }



            

            

        }
    }
}
