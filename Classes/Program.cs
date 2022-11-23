using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // referansı oluşturmak, örneğini oluşturmak, nstance oluşturmak
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Merve";
            customer.LastName = "Canlı";

            Customer customer2 = new Customer { Id=2, FirstName="Merve", LastName="Canlı", City="Ankara" };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}