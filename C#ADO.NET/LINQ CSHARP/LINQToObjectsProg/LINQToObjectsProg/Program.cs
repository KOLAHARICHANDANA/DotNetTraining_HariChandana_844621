using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[6] { "jeffrey ", "andrew", "dathews", "aames", "troleson", "jacob" };
            var KnownEmpls = from emp in employees
                             where emp.StartsWith("j")
                             select emp;

            foreach (string emp in KnownEmpls)
            {
                Console.WriteLine("Empname starts with J:{0}", emp);

            }

            var someEmpls = employees.Where(s => s.Contains("a"));

            foreach (string emp in someEmpls)
            {
                Console.WriteLine("Empname starts with A:{0}", emp);

            }
            Console.WriteLine("***************************************************");
            List<string> fruits = new List<string>() { "Apple",
                                                      "Oranges",
                                                        "Grapes",
                                                        "Pineapple",
                                                         "Banana",
                                                           "watermelon"};
            var fruitswithP = from fruit in fruits
                              where fruit.Contains("p")
                              select fruit;
            foreach (string fruit in fruitswithP)
            {
                Console.WriteLine("Fruits with letter p:{0}", fruit);
            }


            var largernamefruits = from fruit in fruits

                                   where fruit.Length > 6
                                   select fruit;
            Console.WriteLine("***************************************************");
            foreach (string fruit in largernamefruits)
            {
                Console.WriteLine("larger name fruit:{0}", fruit);
            }
            Console.WriteLine("***************************************************");


            //using method syntax


            var smallnamefruits = fruits.Where(fruit => fruit.Length <= 6);
            foreach (string fruit in smallnamefruits)
            {
                Console.WriteLine("smaller name fruit:{0}", fruit);

            }
            Console.WriteLine("***************************************************");

            int[] marks = new int[6] { 98, 86, 89, 80, 94, 93 };
            var highMarks = from m in marks
                            where m > 90
                            select m;
            foreach (var m in highMarks)
            {
                Console.WriteLine("High marks:{0}", m);
            }

            Console.WriteLine("***************************************************");

            var marksinorder1 = from m in marks
                                orderby m
                                select m;

            foreach (var m in marksinorder1)
            {
                Console.WriteLine("marks in order:{0}", m);
            }


            Console.WriteLine("***************************************************");





            var marksinorder = from m in marks
                               orderby m descending
                               select m;

            foreach (var m in marksinorder)
            {
                Console.WriteLine("marks in desc order:{0}", m);
            }

            Console.WriteLine("***************************************************");




            var marksinorder2 = marks.OrderBy(m => m);
            foreach (var m in marksinorder2)
            {
                Console.WriteLine("marks  in automatic sorted order:{0}", m);
            }
            Console.WriteLine("***************************************************");



            var marksinorder3 = marks.OrderByDescending(m => m);
            foreach (var m in marksinorder3)
            {
                Console.WriteLine("marks in descending order:{0}", m);
            }
            Console.WriteLine("***************************************************");



            //Console.ReadLine();

            List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee() { EmpID = 1, EmpName = "Andres Helsberg" });

            Employees.Add(new Employee() { EmpID = 2, EmpName = "Ankith" });

            Employees.Add(new Employee() { EmpID = 3, EmpName = "harichandana" });



            var proEmpls = from emp in Employees

                           where emp.EmpName.Contains("A")

                           select new { ename = emp.EmpName };

            foreach (var emp in proEmpls)
            {
                Console.WriteLine("Empname starts with A:{0}", emp.ename);


            }
            Console.WriteLine("***************************************************");


            List<Product> Products = new List<Product>();
            Products.Add(new Product() { ProID = 1, ProName = "badam" });
            Products.Add(new Product() { ProID = 2, ProName = "orange" });
            Products.Add(new Product() { ProID = 3, ProName = "mango" });

            var Juiceproducts = from pr in Products
                                where pr.ProName.Contains("m")
                                select new { pid = pr.ProID, pname = pr.ProName,  };
            foreach (var pr in Juiceproducts)
            {
                Console.WriteLine("PRODUCTID:{0},PRODUCTNAME:{1}", pr.pid, pr.pname );
            }
           Console.WriteLine("***************************************************");



            List<Teacher> Teachers = new List<Teacher>();

            Teachers.Add(new Teacher() { ID = 1, FirstName = "hari", LastName = "kola", City = "Nellore" });
            Teachers.Add(new Teacher() { ID = 2, FirstName = "deepu", LastName = "pambala", City = "chennai" });
            Teachers.Add(new Teacher() { ID = 3, FirstName = "january", LastName = "july", City = "hyderabad" });


            List<Student> Students = new List<Student>();
              Students.Add(new Student() { ID = 4, FirstName = "babu", LastName = "nagesh", City = "bangalore" });
            Students.Add(new Student() { ID = 5, FirstName = "navya", LastName = "deepu", City = "Pune" });
            Students.Add(new Student() { ID = 6, FirstName = "prasanth", LastName = "nagesh", City = "Pune" });
            var peopleInPune = (from teacher in Teachers
                                where teacher.City == "Pune"
                                select teacher.FirstName)
                                .Concat(from student in Students
                                        where student.City == "Pune"
                                        select student.FirstName);

            foreach(var person in peopleInPune)
            {
                Console.WriteLine("From pune city:{0}", person);
            }

            Console.ReadLine();
            Console.WriteLine("***************************************************");

        }

        public class Employee
        {
            public int EmpID { get; set; }
            public string EmpName { get; set; }
        }

        public class Product
        {
            public int ProID { get; set; }
            public string ProName { get; set; }

        }
        public class Student
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
        public class Teacher
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
