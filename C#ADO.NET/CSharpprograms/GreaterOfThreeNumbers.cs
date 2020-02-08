using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfThreeNumbers
{
    class Program
    {
       
       

        static int a = int.Parse(Console.ReadLine());



       static  int b = int.Parse(Console.ReadLine());

        static int c = int.Parse(Console.ReadLine());
        //Console.WriteLine("enter a,b,c value", a, b, c);


        public void Greater()
        {
         
          

           
            if (a>b&&a>c)
            {
                Console.WriteLine("the greatest number is {0}", a);
            }
            else if(b>a&&b>c)
            
            {
                Console.WriteLine("the greatest number is {0}", b);
            }
            else
            {
                Console.WriteLine("the greatest number is {0}", c);
            }

        }
        static void Main(string[] args)
        {
          

            Program p = new Program();
            p.Greater();


        }
    }
}
