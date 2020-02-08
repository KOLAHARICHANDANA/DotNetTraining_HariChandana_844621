using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        aA{
            int a, b;
            a = 9;b = 5;
            Division(a, b);
            Multiply(a, b);
            for(int i =1;i<=5;i++)
            {
                 var result = 85 + i;
                Console.WriteLine("result = {0}", result);

            }
        }
        public static double Multiply(int a ,int b)
        {
            var prod = a * b;
            return prod;
           
        }
        public static double Division(int a,int b)
        {
            var div = a / b;
            return div;
        }
    }
        
}
