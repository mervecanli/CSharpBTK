using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //List();

            //DictionaryIntro();
        }

        private static void DictionaryIntro()
        {
            // Dictionary: Sözlükte olduğu gibi bir anahtar kelime vasıtasıyla onun değerine ulaşmayı hedeflediğimiz yapılardır.
            // Dictionary bir collection'dur.
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]); // Throw an error => The given key was not present in the dictionary.

            foreach (var item in dictionary)
            {
                //Console.WriteLine(item);
                //Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass")); // false
            Console.WriteLine(dictionary.ContainsValue("bilgisayar")); // true


            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id=1, FirstName="Merve" });
            customers.Add(new Customer { Id=2, FirstName="Büşra" });

            List<Customer> customers2 = new List<Customer>
            {
                new Customer {Id=3, FirstName="Kübra"},
                new Customer {Id=4, FirstName="Nurhayat"}
            };


            var customer2 = new Customer { Id=3, FirstName="Melek" };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id=4, FirstName="Ali" },
                new Customer { Id=5, FirstName="Ayşe" }
            });
            //customers.Clear();

            Console.WriteLine(customers.Contains(new Customer { Id=4, FirstName="Ali" })); // always false because it'll create new reference
            Console.WriteLine(customers.Contains(customer2)); // true

            var index = customers.IndexOf(customer2); // listedeki elemanın listedeki sırasını verir
            Console.WriteLine("Index: {0}", index);

            customers.Add(customer2);
            var lastIndex = customers.LastIndexOf(customer2); // istenilen elemanı aramaya sondan başlar.
            Console.WriteLine("Last Index: {0}", lastIndex);

            customers.Insert(0, customer2); // kaçıncı sıraya neyi eklemek istiyorsun?

            customers.Remove(customer2); // Remove belirtilen elemanın ilk referansını bulduğu anda siler ve
                                         // başka referansların olup olmadığını kontrol etmeden aramayı durdurur.
                                         // elemanı bulamadığı zaman hiçbirşey yapmaz.
            customers.RemoveAll(c => c.FirstName=="Melek"); // it calls "Predicate"

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine(count);
            Console.ReadLine();

            // List type safe'dir.
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("Muğla");
            cities.Add('A');
            cities.Add(1);
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();

            // type safe değilse ArrayList kullanılabilir.
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}

// Bütün collectionlar zaten array bazlıdır.


// ArrayList cities = new ArrayList();
// List<Customer> customers = new List<Customer>();