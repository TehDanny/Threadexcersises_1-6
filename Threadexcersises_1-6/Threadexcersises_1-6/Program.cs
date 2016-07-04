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
        /* Opgave 1-2
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
        */

        /* opgave 3
        static void Main(string[] args)
        {
            ThreadStart GenerateTemperatureMethod = new ThreadStart(GenerateRandomTemerature);
            Thread temperatureThread = new Thread(GenerateTemperatureMethod);
            temperatureThread.Start();

            while (temperatureThread.IsAlive == true)
            {
                Thread.Sleep(10000);
            }
            PrintTemperatureThreadStop();
            Thread.Sleep(1000);
        }

        private static void GenerateRandomTemerature()
        {
            Random random = new Random();
            int outOfRange = 0;

            while (outOfRange < 3)
            {
                int temperature = random.Next(-20, 120);
                Thread.Sleep(2000);

                PrintTemperature(temperature);
                if (temperature < 0 || temperature > 100)
                {
                    outOfRange++;
                    PrintTemperatureAlert(outOfRange);
                }
            }
        }

        private static void PrintTemperature(int temperature)
        {
            Console.WriteLine("The temperature is {0} C.", temperature);
        }

        private static void PrintTemperatureAlert(int outOfRange)
        {
            Console.WriteLine("The temperature is out of range. Alarm #{0}.", outOfRange);
        }

        private static void PrintTemperatureThreadStop()
        {
            Console.WriteLine("Thread is terminated.");
        }
        */

        /* Opgave 4
        private static int count;
        private static object countLock = count;


        static void Main(string[] args)
        {
            ThreadStart Add2Method = new ThreadStart(Add2);
            ThreadStart Substract1Method = new ThreadStart(Substract1);
            Thread add2Thread = new Thread(Add2);
            Thread substract1Thread = new Thread(Substract1Method);
            add2Thread.Start();
            substract1Thread.Start();
        }

        private static void Add2()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Monitor.Enter(countLock);
                try
                {
                    count += 2;
                    PrintCount();
                }
                finally
                {
                    Monitor.Exit(countLock);
                }
            }
        }

        private static void Substract1()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Monitor.Enter(countLock);
                try
                {
                    count--;
                    PrintCount();
                }
                finally
                {
                    Monitor.Exit(countLock);
                }
            }
        }

        private static void PrintCount()
        {
            Console.WriteLine("Count is {0}", count);
        }
        */

        // Opgave 5
        private static int symbolCount;
        private static object symbolLock = symbolCount;
        static void Main(string[] args)
        {
            ThreadStart printStarsMethod = new ThreadStart(PrintStars);
            Thread starThread = new Thread(printStarsMethod);
            ThreadStart printHashesMethod = new ThreadStart(PrintHashes);
            Thread hashThread = new Thread(printHashesMethod);
            starThread.Start();
            hashThread.Start();
        }

        private static void PrintStars()
        {
            while (true)
            {
                Monitor.Enter(symbolLock);
                try
                {
                    symbolCount += 60;
                    Console.WriteLine("************************************************************ " + symbolCount);
                }
                finally
                {
                    Monitor.Exit(symbolLock);
                }
                Thread.Sleep(1000);
            }
        }

        private static void PrintHashes()
        {
            while (true)
            {
                Monitor.Enter(symbolLock);
                try
                {
                    symbolCount += 60;
                    Console.WriteLine("############################################################ " + symbolCount);
                }
                finally
                {
                    Monitor.Exit(symbolLock);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
