using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");

            SomeMethod();

            Console.WriteLine("Main Method End");
            Console.ReadLine();

            HashSet<String> hat = new();
        }

        public static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");

            //Thread.Sleep(TimeSpan.FromSeconds(10));
            Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("\n");
            Console.WriteLine("Some Method End");
        }
    }
}
