using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace MultiThreadAppPerform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is started");
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            IncrementCount1();
            IncrementCount2();
            s1.Stop();

            Stopwatch s2 = new Stopwatch();

            Thread T1 = new Thread(IncrementCount1);
            Thread T2 = new Thread(IncrementCount2);

            s2.Start();
            T1.Start();
            T2.Start();
            s2.Start();

            T1.Join();
            T2.Join();


            
            Console.WriteLine("Total time elapsed for a single thread is:{0}", s1.ElapsedMilliseconds);
            Console.WriteLine("Total time elapsed for a multi thread is:{0}", s2.ElapsedMilliseconds);

            Console.WriteLine("Main Thread is exited");

           // Console.WriteLine("Total time elapsed:{0}", s1.ElapsedMilliseconds);
        }
        public static void IncrementCount1()
        {
            long Count1 = 0;
            for (int i = 0; i < 10000000; i++)
                Count1++;
            Console.WriteLine("Count1:{0}", Count1);
        }
        public static void IncrementCount2()
        {
            long Count2 = 0;
            for (int i = 0; i < 10000000; i++)
                Count2++;
            Console.WriteLine("Count2:{0}", Count2);
        }
    }
}
