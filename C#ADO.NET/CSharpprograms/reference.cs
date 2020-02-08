using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = 100;  
            int a = 10;
            obj = a; //converting a value type to reference implicitly-boxing
            int b = (int)a;//unboxing-converting a boxed into a value type
            Console.WriteLine("values of a and b = {0} and {1}", a, b);
            int i, j;

            i=10; j=20;

            //double sum = ShowData(i, j);
            Console.WriteLine("values of i  and j = {0},{1}", i, j);
            ShowData1(i, j);
            Console.WriteLine("values of i and j before function call = {0},{1}", i, j);
            Console.WriteLine("values of i and j after function call = {0},{1}", i, j);





            int k,l;
            
          k=10;l=20;
            Console.WriteLine("values of k and l before function call = {0},{1}", k, l);

           // double sum = ShowData(ref i, ref j);
            ShowData2(ref k, ref l);
            Console.WriteLine("values of k and l after function call = {0},{1}", k, l);

            //.WriteLine("values of i and j after function call = {0},{1}", i, j);

           
            Console.ReadLine();
        }
        public static void ShowData1( int a,int b)
        {
            double sum = a + b;
            Console.WriteLine("sum={0}", sum);


            a +=5;
            b +=5;
          
        }
        public static void ShowData2(ref int a, ref int b)
        {
            double sum = a + b;
            Console.WriteLine("sum={0}", sum);
            a += 5;
            b += 5;
           


        }
    }
}