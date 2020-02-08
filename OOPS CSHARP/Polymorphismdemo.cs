using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            var salary = emp.Getsalary(30, 800);
            Console.WriteLine("Salary without incentives: Rs {0}", salary);
            salary = emp.Getsalary(30, 800, 5000);
            Console.WriteLine("Salary with incentives: Rs {0}", salary);
            Manager objm = new Manager();
            var ts = objm.Getperks(5000, 3000);
            Console.WriteLine("the salary of manager is rs {0}",ts);

            Console.ReadKey();
        }
    }
    public class Employee
    {
        public double Getsalary(int nds, float spd)
        {
            double salary = nds * spd;
            return salary;
        }
        public double Getsalary(int nds, float spd, float incent)
        {
            double salary = (nds * spd) + incent;
            return salary;
        }
        public virtual double Getperks(float salary, float perks)
        {
            double ts = salary + perks;
            return ts;

        }
    }

        public class Manager : Employee
        {
            public override double Getperks(float salary, float perks)
            {
                return base.Getperks(salary, perks) * 1.10;
                //double ts = 1.10* (salary + perks);
                //return ts;
            }
        }

    
}
