using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types - Değer Tipleri
            int number1 = 2147483647;  // int   32 bitlik yer kaplar.
            long number2 = 2147483648; // long  64 bitlik yer kaplar.
            short number3 = 32767;     // short 16 bitlik yer kaplar.
            byte number4 = 255;        // byte  8 bitlik yer kaplar. (0-255 arası tam sayı değerleri alır.)
            bool condition = true;
            char character = 'A';
            double number5 = 10;       // double 64 bitlik yer kaplar. (Tam sayı ve ondalıklı sayı değerlerini alır.)
            double number6 = 10.4;     // double virgulden sonra 25-26 karakter tutar.
            decimal number7 = 10.4m;   // decimal virgulden sonra 28-29 karakter tutar.
            decimal number8 = 10;
            decimal number9 = 10.7M;
            var number10 = 10;
            number10 = 'A';
            //number10 = "A";
            

            Console.WriteLine("Number1 is {0}, Number2 is {1}, Number3 is {2}, Number4 is {3}, Condition is {4}, Character is {5}, " +
                "Numeric value of character {6}, Number5 is {7}, Number6 is {8}, Number7 is {9}, Number8 is {10}, Number9 is {11}, " +
                "Number10 is {12}", 
                number1, number2, number3, number4, condition, character, (int)character, number5, number6, number7, number8, number9, number10);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }

        enum Days
        {
            Monday=10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday, Sunday
        }
    }
}
