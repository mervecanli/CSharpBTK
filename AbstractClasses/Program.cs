using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }


    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle");
        }
    }




    // interface'lerde amaç imzaları oluşturmak ve onu implemente eden sınıfın bütün imzaları tekrardan yazmasını sağlamaktır.
    // İmzaların implemente edilmesi zorunlu hale getiriliyordu ve inheritance gibi de kullanılabiliniyordu.

    // virtual metodlarda temel operasyonlar vardır, isteyen istediği operasyonları ezebilir.

    // abstract'lar da birer class'dır. Yani interface gibi değildir.
    // Abstract class'ları interface'ler ile virtual metodların birleşimi olarak düşünülebilir.
    // Tamamen inheritance amacı ile kullanılır.
    // interface'ler ile virtual metodların tam kullanım nedenleri bir araya getirildiğinde ortaya çıkanlar
    // abstract class'lardaki amacı gösterir.

    // abstract class'larla hem tamamlanmış hem de tamamlanmamış(sadece imzası bulunan) metodlar yapılabilir.

    // abstract içi dolu olmayan virtual metoddur.
    // Yani abstract metodlar her ortamda farklı olduğu için herkesin ayrı ayrı implemente etmesi gerekir.

    // Aynı interface'ler gibi abstract class'larda new'lenemez.

    // abstract class'larda birer inheritance özelliğidir.
    // tek bir inheritance kabul eder, ancak birden fazla implemente kabul edebilir.
}
