using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
       
   
        static void Main(string[] args)
        {
            String Str = "Hello World";
            string strRev = null;
            char[] Chars = Str.ToCharArray();
            for (int i = Str.Length - 1; i >= 0; i--)
            {
                strRev += Chars[i];

            }

            Console.WriteLine("Reverse of {0} = {1}", Str, strRev);
           
        }
       
    }
}
