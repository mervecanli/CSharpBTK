using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] people = new Person[3] { 
                new Customer { FirstName="Merve" }, 
                new Student { FirstName="Ayşe" },
                new Person { FirstName="Fatma" } 
            };
            foreach(var person in people)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer:Person
        {
            public string City { get; set; }
        }

        class Student:Person
        {
            public string Department { get; set; }
        }

        // Bir sınıf tek bir inheritance kabul eder ancak
        // birden fazla implement kabul edebilir.

        // Önce inhertance yazılır, sonra implementler yazılır.

        // class'ların tek başına bir anlamı vardır ancak interface'lerin tek başına bir anlamı yoktur.

        // İkisi de inheritance gibi kullanılabilir.
        // Interfaceler bir implementasyondur.
        // Fakat yeni nesil dillerde inheritance gibi de kullanım senaryoları söz konusu olabilir.
    }
}
