using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            var result = Add2(2,4);
            var result2 = Add3();

            int number1 = 20;
            int number2 = 100;
            var result3 = Add4(ref number1, number2);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3); // 130
            Console.WriteLine(number1); // 20 (ref keyword kullanılırsa number1=30 olur.)

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add5(2,4,5,6));
            Console.WriteLine(Add5(2,4,5,6,5,343,4,-457));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1, int number2)
        {
            var result =  number1 + number2;
            return result;
        }

        static int Add3(int number1=20, int number2=30)
        {
            var result = number1+number2;
            return result;
        }

        static int Add4(ref int number1, int number2)
        {
            // ref keywordu değer tiplerinin referans tip gibi kullanılmasını sağlar.
            // out keywordu ref keywordu ile aynı mantığa sahiptir.
            
            // ref ve out farkı; 
            // ref'te kullanılan değişken daha önceden mutlaka set edilmiş olmalıdır ama out'ta bu zorunluluk yoktur.
            // Projelerde eğer değeri baştan set etme ihtiyacı olursa ref kullanırız. 
            // Değerin baştan set edilmeye ihtiyacı yoksa out kullanırız.
            // out'da metodun içerisinde set edilmesi gerekir.

            number1=30;
            return number1+number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1*number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1*number2*number3;
        }

        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
