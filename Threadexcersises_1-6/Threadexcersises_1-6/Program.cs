using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threadexcersises_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart printMethod1 = new ThreadStart(Print1);
            ThreadStart printMethod2 = new ThreadStart(Print2);
            Thread thread1 = new Thread(printMethod1);
            Thread thread2 = new Thread(printMethod2);
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }

        private static void Print1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
                Thread.Sleep(1000);
            }
        }

        private static void Print2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde …");
                Thread.Sleep(1000);
            }
        }
    }
}
