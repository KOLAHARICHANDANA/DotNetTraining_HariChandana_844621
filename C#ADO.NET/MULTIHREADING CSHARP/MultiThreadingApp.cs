using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingApp
{
    class Program
    {
        public static Thread T3;

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread is started");

            Thread t = Thread.CurrentThread;

            t.Name = "Main Method";
             Console.WriteLine("{0} is running now with ID:{1}", t.Name, t.ManagedThreadId);

            //Method1();
            //Method2();
            // Method3();

            Thread T1 = new Thread( new ThreadStart(Method1));
            Thread T2 = new Thread(Method2); //Method 2 is implicitly  delegate
              T3 = new Thread(Method3);

            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();T2.Join();T3.Join();
            Thread tp= new Thread (new ParameterizedThreadStart(Test));
            tp.Start(100);
            Thread ts = new Thread(new ThreadStart(FindArea));
           ts.Start();


                

            Console.WriteLine("Main thread is exited");
            Console.ReadLine();
            
        }
        public static void Method1()
        {
            Console.WriteLine("Thread1 is started");
            for (int i=1; i <= 50; i++)

          Console.WriteLine("Method1={0}", i);
            Console.WriteLine("Thread1 is exited");
        }


        public static void  Method2()
        {
            Console.WriteLine("Thread2 is started");
            for (int i = 1; i <= 50; i++)
            {
                if (i == 25)
                {
                    Thread.Sleep(500);
                }
                Console.WriteLine("Method2={0}", i);
                Console.WriteLine("Thread2 is exited");
            }
        }
            
             




        public static void Method3()
        {
            Console.WriteLine("Thread3 is started");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Method3={0}", i);
                Console.WriteLine("Thread3 is exited");


            }
               
        }
        public static void Test(object max)
        {
            int j = Convert.ToInt32(max);
            

            for (int i = 1; i <=j; i++)
            {
                Console.WriteLine("Test:{0}", i);
            }
        }
        public static void FindArea()
        {
            double len, brd;
            Console.WriteLine("enter length");
            len = double.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth");
            brd = double.Parse(Console.ReadLine());
            //var area = len * brd;
            Console.WriteLine("area of rectangle: {0}", (len*brd).ToString());
        }
    }
}
