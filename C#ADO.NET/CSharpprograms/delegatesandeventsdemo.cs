using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesamd_eventsdemo
{
    class Program
    {
        public delegate double saldelegate(int ds, float sd);

        static void Main(string[] args)
        {
            saldelegate deleg = new saldelegate(Getsalary);
            var salary = deleg.Invoke(20, 200);
            Console.WriteLine("salary= {0}", salary);
            //deleg = new saldelegate(Getincentive);
            deleg += Getincentive;
            var incent = deleg.Invoke(30, 800);
            Console.WriteLine("incentives = {0}", incent);
            Console.ReadKey();
        }
        public static double Getsalary(int nds,float spd)
        {
            var salary = (nds * spd);
            return salary;
        }
        public static double Getincentive(int nds,float spd)
        {
            var incent = 0.1 * (nds * spd);
            return incent;
        }
    }
}
