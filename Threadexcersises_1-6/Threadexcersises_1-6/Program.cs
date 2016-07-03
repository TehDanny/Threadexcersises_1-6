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
            Thread thread1 = new Thread(Print1);
            thread1.Start();
            Console.ReadKey();
        }

        private static void Print1()
        {
            Console.WriteLine("C#-trådning er nemt!");
            Console.WriteLine("C#-trådning er nemt!");
            Console.WriteLine("C#-trådning er nemt!");
            Console.WriteLine("C#-trådning er nemt!");
            Console.WriteLine("C#-trådning er nemt!");
        }
    }
}
