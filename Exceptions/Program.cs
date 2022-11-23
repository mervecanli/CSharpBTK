using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //ClassicalTryCatch();

            //ActionDemo();

            //Console.WriteLine(Topla(2,3));


            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate () // Burada Func<int> parametresiz metodlara delegate yapıyor ama sonucunda int döndürüyor.
            {
                Random random = new Random();
                return random.Next(1,100);
            };

            Thread.Sleep(3000);

            Func<int> getRandomNumber2 = () => new Random().Next(1,100);

            Console.WriteLine(getRandomNumber2());

            Thread.Sleep(1000);

            Console.WriteLine(getRandomNumber());

            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x+y;
        }

        private static void ActionDemo()
        {
            // yukarıdaki try-catch bloğunun aşağıdaki gibi yazılması daha güzeldir.
            HandleException(() =>
            {  // Method içerisinde parametre olarak yine method göndermek (delege) : Parametresiz kod bloğu gönderilecek o kod bloğunun karşılığı ise aşağıdadır.
                Find();
            });
        }

        private static void ClassicalTryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action) // Action parametresiz metod bloğudur. void operasyonlar için kullanılır. Herhangi bir return ifadesi gerekmez.
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };
                students[3] = "Ahmet"; // Index was outside the bounds of the array.
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException); // Exception için varsa daha detaylı bilgi verir.
            }
            Console.ReadLine();
        }
    }
}


// Action and Func are built-in delegate.
// Action is used for only nonparameter operations which return void.
// Func is used for parameter or nonparameter operations which must return a type.
