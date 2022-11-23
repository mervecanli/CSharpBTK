using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndVaueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1; // ikinci sayının değeri eşittir birinci sayının değeridir.
            number1=30;
            Console.WriteLine(number2); // 10


            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };  // 101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesi" }; // 102 => 101
            cities2 = cities1; // cities2'nin referansı eşittir cities1'in referansıdır.
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]); // İstanbul

            Console.ReadLine();
        }
    }
}

// int, bool, enum, double, decimal gibi değişkenler değer tiptir.
// class, string, interface, abstract, array vs. referans tiptir.

// değer tiplerde atamalar tamamen değer üzerinden gerçekleşir. Referans tutulmaz.