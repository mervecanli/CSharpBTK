using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1, LastName="Canlı", Age=25};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }

        [RequiredProperty]
        public string LastName { get; set; }

        [RequiredProperty]
        public int Age { get; set; }
    }


    class CustomerDal
    {
        [Obsolete("Pls. dont use this method insted of AddNew()")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //[AttributeUsage(AttributeTargets.All)]
    //[AttributeUsage(AttributeTargets.Class)]
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName=tableName;
        }
    }
}

// Attribute ile;
// Merkezi bir noktada iş kuralları konulabilir.
// İlgili nesne için bir kural oluşturulabilir.
// Çalışma anında nesnelere, nesnelerin property'sine ve/veya metodlarına anlam katmak için için attibute'lardan yararlanırız.
// AttributeUsage ile bir attibute'un nerelerde kullanılabileceği hakkında conf. yapılır.