using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] { new Manager(), new Worker(), new Robot() };
            foreach(var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2] { new Worker(), new Manager()};
            foreach(var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    // SOLID, I=>Interface Segregation
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager getsalary");
        }

        public void Work()
        {
            Console.WriteLine("Manager work");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker getsalary");
        }

        public void Work()
        {
            Console.WriteLine("Worker work");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot work");
        }
    }

    // Bir class birden fazla interface'i implement edebilir.
}