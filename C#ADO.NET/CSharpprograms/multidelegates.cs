using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidelegates
{
    class Program
    {
      
        public delegate void mathdelegate(int x, int y);
        public delegate void printhandler();
        public event printhandler print;
        public void onprint()
        {
            Console.WriteLine("PRINTING IS DONE");
        }
        public void Show()
        {
            Console.WriteLine("inside the show method");
            print();
        }
       
        static void Main(string[] args)
        {
           mathdelegate mathdeleg = new mathdelegate(add);
            mathdeleg += sub;
            mathdeleg += multi;
            mathdeleg += div;
            mathdeleg.Invoke(1000, 10);
            Program objp = new Program();
            objp.print += new printhandler(objp.onprint);//registering onprint event handler with print event
            objp.Show();
            Console.ReadKey();
         }
        public static void add(int a,int b)
        {
            var addition = a + b;
            Console.WriteLine("the addition is  {0} is", addition);


        }
        public static void sub(int a, int b)
        {
            var subtraction = a-b;
            Console.WriteLine("the subtraction is {0}", subtraction);

        }
        public static void multi(int a, int b)
        {
            var multiplication = a * b;
            Console.WriteLine("the multiplicaton is {0}", multiplication);
        }
            
        public static void div(int a, int b)
        {
            var division = a/b ;
            Console.WriteLine("the division is {0}", division);
        }
    }
}


