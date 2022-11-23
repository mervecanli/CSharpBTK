using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3,4));


            //var tip = typeof(DortIslem); // çalışacağımız tip DortIslem
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 6, 7); // DortIslem dortIslem = new DortIslem(); // Activator.CreateInstance(tip) returns an object
            //Console.WriteLine(dortIslem.Topla(4,5));
            //Console.WriteLine(dortIslem.Topla2());


            var tip = typeof(DortIslem);
            var instance = Activator.CreateInstance(tip, 6, 5);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("------");

            var metodlar = tip.GetMethods();
            foreach(var info in metodlar)
            {
                Console.WriteLine("Metod Adı: {0}", info.Name);
                foreach(var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}", parameterInfo.Name);
                }

                foreach(var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name);
                }
                Console.WriteLine("--------------------");
            }



            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1*sayi2;
        }

        public int Topla2()
        {
            return _sayi1+_sayi2;
        }

        [MethodName("Carpma")] // Dışarıya Carpma ismiyle gözükecektir.
        public int Carp2()
        {
            return _sayi1*_sayi2;
        }
    }

    public class MethodNameAttribute:Attribute
    {
        private string _name;
        public MethodNameAttribute(string name)
        {
            _name=name;
        }

    }
}


// Reflection;
// Çalışma anında(uygulama çalışırken) herhangi bir nesnenin hakkında bilgi toplayabilir ve toplanan bilgiye göre nesneyi istenilen zaman örneğin bir metodun çalışması sağlanılabilir.
// Kullanım durumlarına örnek verilecek olursa; örneğin çalışma anında hangi nesne ile çalışacağımızı bilemediğimiz durumlar olabilir.
// Kullanıcının girdiği değerlere göre o an ne yapılmasına karar verilebilecek durumlar olabilir.
// Nesneler hakkında bilgi almak da reflection'ının bir diğer kullanım alanıdır. Örneğin => Bir nesnenin özellikleri, attibuteları varsa bunlar nelerdir,... 
// AMAÇ: ÇALIŞMA ANINDA NESNELER HAKKINDA BİLGİ ALMAK VE İSTENİLİRSE BU NESNELERİ ÇALIŞTIRABİLMEKTİR.
// Reflection ile bir nesneye ait özelliklere liste şeklinde erişmek mümkündür.
// Attribute reflection ilişkisi ile beslenen bir mimaridir.