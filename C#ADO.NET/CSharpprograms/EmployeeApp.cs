using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeComponent;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() {EmployeID = 10, EmpName = "Jeffrey Ritcher", Department = "Technical" };
         
            var empdata = emp.ShowData();
            Console.WriteLine(empdata);
            var salary = emp.GetSalary(30, 800.00);
            var incent = emp.GetIncentives(salary);
            var tSalary = salary + incent;
            Console.WriteLine("Salary :{0},Incentives:{1},Total Salary:{2}", salary, incent, tSalary);
            Console.ReadKey();
        }
    }
}
