using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();
            // WhileLoop();
            // DoWhileLoop();
            // ForeachLoop();

            if(IsPrimeNumber(2))
            {
                Console.WriteLine("This number is a prime number.");
            }
            else
            {
                Console.WriteLine("This number is not a prime number.");
            }

            Console.WriteLine("Finished!");
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    result = false;
                    i=number;
                }
            }
            return result;
        }

        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students) // foreach iterable variable is readonly!
            {
                Console.WriteLine(student);
            }
        }

        private static int DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number>=11);
            return number;
        }

        private static int WhileLoop()
        {
            int number = 100;

            while (number>=0)
            {
                Console.WriteLine(number);
                number-=1;
            }

            return number;
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
