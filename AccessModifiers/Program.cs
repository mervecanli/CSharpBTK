using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int Id { get; set; }
        protected string FirstName { get; set; }

        public void Save()
        {
        }

        public void Delete()
        {

        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
        }
    }

    internal class Course
    {
        public string Name { get; set; }
        private class Nested
        {

        }
    }
}

// private bir değişken/metod vs. sadece tanımlandığı blok içerisinde geçerlidir.
// protected bir değişken/metod vs. tanımlandığı blok içerisinde ve inherit edildiği sınıflarda geçerlidir. 
// internal bir class bağlı bulunduğu proje (assembly) içerisinde referans ihtiyacı olmadan kullanılmasıdır. 
    // yani tanımladığı proje içerisinde istenilen yerden çağırılabilmesidir.
    // bir class'ın default erişim bildirgeci internal'dır.
    // bir üst seviyeli class private, protected olamaz. 
    // bir class ya internal olabilir ya da public olabilir.
    // iç içe class'larda private erişim bildirgeci kullanılabilir.
// public bir değişken/metod vs. erişim bildirgeçi faklı projlerden de erişime izin verir.
