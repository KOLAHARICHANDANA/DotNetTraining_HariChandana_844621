using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankComponent;

namespace bankapp
{
    class Program
    {
        static void Main(string[] args)
        {

            savingsBank bk = new savingsBank(); 

            //var bankdata = bk.ShowData();
            //Console.WriteLine(bankdata);
            var Simplei = bk.GetSimpleinterest(30000,5,3);
            
           
            Console.WriteLine("Simplei :{0}", Simplei);
            Console.ReadKey();
        }
    }
}
