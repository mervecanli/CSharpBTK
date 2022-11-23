using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int sayi1, int sayi2); 


    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            myDelegate();

            Console.WriteLine("---");

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Hello"); // DELEGATE'NIN EN ÖNEMLİ KISITI => AYNI PARAMETREYİ İKİ OPERASYONADA GONDERIR YANI
                                  // METODLARIN FARKLI PARAMETRE ALMASI DURUMUNDA KISIT ÇIKAR.
                                  // VERILEN PARAMETRE HER IKI METODA DA AYNI SEKİLDE GIDER. 
                                  // METODLARA AYNI PARAMETRE GIDECEGI ZAMAN KULLANABILIRSIN.

            Console.WriteLine("---");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2,3);
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }


        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1*sayi2;
        }
    }
}

// Delegate'lerde eğer bir return type varsa son yapılan delegate işleminden gelen return geçerli olur.
// build-in delegateler;
// action => exception, transaction, log vs yerlerde void olarak kullanılıyor.
// func => dönuş tipi olan parametreler için kullanışlıdır.


// C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için
// kullanılan yapıya delegate veya temsilci denir.
// delegate yapısı genellikle bellekteki metotların bir olay sonucu çalıştırılması için kullanılır.

// Windows Forms Application projesi oluşturup form alanına çift tıklandığında Form1_Load metodu oluşur.
// Bu metot Form sınıfında yer alan Load isimli temsilci tetiklendiğinde çalışacaktır.