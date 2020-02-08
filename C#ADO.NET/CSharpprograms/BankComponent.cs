using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankComponent
{
    public class savingsBank
    {
        //public double balance { get; }
        //public int principle { get; set; }

        //public int time { get; set; }

        //public float rate { get; set; }

        public double GetSimpleinterest(int p, int t, float r)
        {
            var Simplei = (p * t * r) / 100;
            Console.WriteLine("the simple interst is", Simplei);

            return Simplei;

        }


        

    }
}
