using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemoProg
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount objSB = new SBAccount();
            CCAccount objCC = new CCAccount();

            double siSB = objSB.GetSimpleInterest(95000.00, 5, 8);
            double tamt = objSB.GetTotalAmount(50000.00, siSB);

            Console.WriteLine("SIMPLE INTEREST(SAVING ACCOUNT): RS {0}", siSB);
            Console.WriteLine("tOTAL AMOUNT: RS {0}", tamt);

            var siCC = objCC.GetSimpleInterest(95000.00, 5, 8);
            tamt = objCC.GetTotalAmount(50000.00, siCC);

            Console.WriteLine("SIMPLE INTEREST(cURRENT aCCOUNT): RS {0}", siCC);
            Console.WriteLine("tOTAL AMOUNT: RS {0}", tamt);
            objSB.show();

        }
    }
    public abstract class Banking
    {
        public abstract double GetSimpleInterest(double pr, int td, short rt);
        public abstract double GetTotalAmount(double bal,double si);
        public void show()
        {
            Console.WriteLine("THIS IS A CONCRETE METHOD DEFINED WITHIN AN ABSTRACT CLASS");

        }

    }
    public class SBAccount : Banking

    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = (pr * td * rt) / 100;
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }

    }
    public class CCAccount:Banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = 0.25 * ((pr * td * rt) / 100);
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }


    }
}
