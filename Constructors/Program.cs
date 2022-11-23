using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(20);
            customerManager.List();

            Product product = new Product { Id=1, Name="Laptop" };
            Product product2 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            //Teacher teacher = new Teacher(); // static new'lenemez.
            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSometing();
            Manager manager = new Manager();
            manager.DoSometing2();


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }
        
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }


    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message ", _entity);
        }
    }

    class PersonManager:BaseClass
    {
        // ctor ile base sınıfa parametre göndermek
        public PersonManager(string entity) : base(entity)
        {
                    
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    
    static class Teacher
    {
        public static int Number { get; set; }
    }


    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSometing()
        {
            Console.WriteLine("Done");
        }

        public void DoSometing2()
        {
            Console.WriteLine("Done 2");
        }
    }


}

// constructor bir sınıf new'lendiğinde çalışacak kod bloğudur.

// örneğin; bir tane abstract sınıfımız olsun.
// Abstract sınıfın içerisinde herşey standart sadece bir parametre değişkenlik gösteriyor olsun.
// Bu parametre connection string oabilir. Oracle ve mysql için connection string farklıdır.
// Connection string base'e parametre olarak gider, geriye kalan bütün işlemleri abstract sınıf yapar.



// static;
// static nesneler direk nesne yani class seviyesinde olabilir. 
// static nesnelerde bir nesnenin hiçbir zaman instance'i oluşturulamaz.
// arka planda tek bir nesne oluşturulur ve o nesne bütün kullanıcılar tarafından aynı nesne olduğu için tüketilir.
// dolayısıyla static bir nesne ile çalışıldığında paylaşılan bir kaynak olup olmadığından emin olunmalıdır.

// static nesnenin bütün özelliklerinin de static bildirgesine sahip olması gerekir.
// static bellekte tanımlanır, o sunucuda herkes için aynı değer geçerlidir.
// yani static nesneler ortak nesnelerdir ve herkes onu kullanabilir.

// biri değiştiğinde diğeri içinde değişmesi istenilen durumlar varsa static kullanılır.
// ancak genellikle static nesnelerden uzak durulmaya çalışılır.

// bir class static olabileceği gibi, class'ı static yapmayıp özelliklerini static yapabiliriz.(ör: class Manager'a bak.)
// static olan metod/property vs. sınıf ismi üzerinden, static olmayan metod/property vs. instance üzerinden çağırılır.

// static bir sınıfın herşeyi static olmak zorundadır, ama sınıf static tanımlanmıyorsa o sınıfın içerisinde 
// static olan ve/veya olmayan property/metod vs. olabilir.