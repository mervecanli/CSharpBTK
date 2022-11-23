using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();

            sqlServer.Add();
            mySql.Add();

            Console.ReadLine();
        }
    }


    class Database
    {
        public virtual void Add() 
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete() 
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer: Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by sql code");
            //base.Add();
        }
    }

    class MySql:Database
    {

    }

    // Inheritance yapılan ortamda genel bir operasyon olduğunu düşünelim.
    // Bu operasyon bir çok ortamda aynıyken bazı ortamlarda da farklı olabileceğini düşünelim.
    // Bu farklı olabilecek ortamlarda operasyon virtual keywordu ile ezilebilir.

    // virtual interface'ler ile yapılamaz, virtual kullanılmaz istenilirse bunun için inheritance kullanılmalıdır.
}
