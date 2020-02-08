using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEFDBFirstProg
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqToEntity();
            //ModifyEmployee();
            //DeleteEmployee();
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            //var employee = new Employee()
            //{
            //    EmpID = 6,
            //    Name = "Andrew Trolesan",
            //    Salary = 35000,
            //    SSN = 2345678,
            //    DepID = 3


            //};
            //context.Employees.Add(employee);
            //context.SaveChanges();
            //var employee2 = new Employee()
            //{
            //    EmpID = 8,
            //    Name = "hari chandana",
            //    Salary = 3000,
            //    SSN = 2345,
            //    DepID = 4
            //};
          //  context.Employees.Add(employee2);
            //var employee3 = new Employee()
            //{
            //    EmpID = 2,
            //    Name = "chandana",
            //    Salary = 13000,
            //    SSN = 234345,
            //    DepID = 6
            //};
            //context.Employees.Add(employee3);
            context.SaveChanges();
        }
        public static void LinqToEntity()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;
            var empList = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach (var emp in empList)
            {
                Console.WriteLine("EmpID:{0},Name:{1},Salary:{2},SSN:{3}", emp.EmpID, emp.Name, emp.Salary, emp.SSN);

            }
        }
        public static void ModifyEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;
            var empList = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach (var emp in empList)
            {
                if (emp.EmpID == 1)
                    emp.Name = "sreeharibabu";
            }
            context.SaveChanges();
        }
        public static void DeleteEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;
            var employee = new Employee { EmpID = 7 };
            employees.Attach(employee);
            employees.Remove(employee);
            context.SaveChanges();
           
         


        }
    }
}
