using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new string[] { "Engin", "Derin", "Salih" };
            string[] students3 = new[] { "Engin", "Derin", "Salih"};
            string[] students4 = { "Engin", "Derin", "Salih" };
            string[] students5 = new string[3] { "Engin", "Derin", "Salih" };
            //students4[3] = "Merve"; // index was outside... error


            //foreach (var student in students5)
            //{
            //    Console.WriteLine(student);
            //}


            string[,] regions = new string[7,3];
            //regions[0, 0] = "İstanbul";

            string[,] regions2 = new string[5, 3] 
            {
                { "İstanbul", "İzmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" }
            };

            //foreach(var row in regions2)
            //{
            //    Console.WriteLine(row);
            //}

            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions2[i, j]);
                }
                Console.WriteLine("***");
            }
            
            Console.ReadLine();
        }
    }
}