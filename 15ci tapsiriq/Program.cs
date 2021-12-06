using System;
using MyHelperMethods;

namespace _15ci_tapsiriq
{
    class Program
    {
     // 15)* 5 dene eded daxil et.Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.
     // 3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
     // Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
     // Cavabdan 7 reqemli ededin son 5 reqemini cix. 
     // Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
     // Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
     // Cavabin axirina 11 artir.
     // Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
     // Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;
        Error1:
            number1 = Reader.ReadInteger("Enter first three-digit number: ");
            number2 = Reader.ReadInteger("Enter second three-digit number: ");
            number3 = Reader.ReadInteger("Enter first six-digit number: ");
            number4 = Reader.ReadInteger("Enter second six-digit number: ");
            number5 = Reader.ReadInteger("Enter seven-digit number: ");

            if (number1 >= 100 && number1 <= 999)
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
            if (number2 >= 100 && number2 <= 999)
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
            if (number4 >= 100000 && number4 <= 999999)
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
            if (number5 >= 1000000 && number5 <= 9999999)
            {
                Console.WriteLine(number5);
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Enter Correctly!");
                goto Error1;
            }
            Console.Clear();

            int num1 = (number1 + number2)%100;
            int num2= (int)Math.Pow(num1,2);
            
            int num3 = number1 * 1000 + number2;
            int num4 = num2 + num3;
            
            int num5 = number5 % 100000;
            int num6 = num4 - num5;
            
            int num7 = (number3 + number4) % 1000 + num6;
            

            int num8 = Calculator.SumOfDigits(number5);
            int reversenum8 = 0;
            while (num8>0)
            {
                reversenum8 = reversenum8+ num8 % 10;
                num8 = num8 / 10;
                reversenum8 = reversenum8 * 10;
            }
            reversenum8 = reversenum8 / 10;
            
            int num9 = (num7 + reversenum8)*100+11;
            

            int counter = 1;
            int digits = 0;
            int num10 = 0;
            while (number5>0)
            {
                digits = number5 % 10;          //7        //6      //5     //4     //3     //2  //1
                number5 = number5 / 10;         //123456  //12345  //1234  //123   //12    //1  //0
                if ( counter%2 != 0)
                {
                    num10=num10*10+digits;      //0+7=7      //70+5  //750+3 //7530+1 //7531
                }
                counter++;
            }
            int box = 0;
            while (num10>0)
            {
                box = box + num10 % 10;   //0+1     //10+3  //130+5 //1350+7
                num10 = num10 / 10;       //753     //75    //7     //0
                box = box * 10;           //10      //130   //1350  //13570
            }
            box = box / 10;
            

            int num11 = num9 - box;
            

            int box1 = num11 % 10;
            num11 = num11 / 10;
            num11 = num11 * 100 + 88;
            num11 = num11 * 10 + box1;


            Console.WriteLine($"Your Result: {num11}");
            
        }
    }
}
