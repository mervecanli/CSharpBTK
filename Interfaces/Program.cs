using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customers = new ICustomerDal[3] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal() };

            foreach(var customerDal in customers)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            IPerson person = new Customer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id=1, FirstName="Merve", LastName="Canlı", Address="Ankara" });

            Student student = new Student { Id=2, FirstName="Büşra", LastName="Canlı", Departman="Maliye" };
            personManager.Add(student);

            Worker worker = new Worker();
            worker.Id=3;
            worker.FirstName="Ayşe";
            worker.LastName="Su";
            worker.Departman="Tarım Ürünleri Bakım Merkezi";
            personManager.Add(worker);
        }
    }

    // soyut nesne
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    // somut nesne
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }


    // somut nesne
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departman { get; set; }
    }

    // somut nesne
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departman { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }


    // Interface;
    // Temel nesne oluşturup bütün nesneleri ondan implemente etmektir.
    // soyut nesneler tek başına anlam ifade etmez.
    // interfaceler yazılırken imzası kullanılır.

    // Bir interface hiçbir zaman new'lenemez. Çünkü tek başına bir anlamı yoktur. Bir interface'in instance'i oluşturulamaz.
    // Yani interface ve abstract gibi soyut nesnelerin instance'ları oluşturulamaz.

    // Interface'ler katmanlar arası geçişlerde yoğun ölçüde kullanılır.
    // Burada amaç uygulamanın bağımlılıklarını minimize etmeye çalışmaktır.
}