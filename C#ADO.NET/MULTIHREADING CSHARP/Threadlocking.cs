using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadLockingApp
{
    class ThreadLock
    
    {
        static void Main(string[] args)
        {
            ThreadLock objTL = new ThreadLock();
            Thread T1 = new Thread(objTL.Display);
            Thread T2 = new Thread(objTL.Display);
            Thread T3 = new Thread(objTL.Display);
            T1.Start();
            T2.Start();
            T3.Start();
            Console.ReadLine();
        }

        public void Display()
        {
            //lock (this)
           // {
                Console.Write("[Csharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented programming");

           // }

        

        }
    }
}
