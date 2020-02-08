using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100); //non-generic colection class 

            items.Add("hello world");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add(true);

            foreach (object obj in items)
                Console.WriteLine(obj.ToString());

            ArrayList item = new ArrayList(100); //non-generic colection class 

            items.Add("hello world");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add(true);

            foreach (object obj in items)
                Console.WriteLine(obj.ToString());

            List<int> myInts = new List<int>();       //generic collection class

            myInts.Add(10);
            myInts.Add(80);
            myInts.Add(90);


            foreach (var n in myInts)
                Console.WriteLine(n.ToString());

            List<string> employees = new List<string>() { "chandu", "sai", "vena", "hasina" };

            foreach (var emp in employees)
                Console.WriteLine(emp);

            Dictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(1, "apple");
            fruits.Add(2, "banana");
            fruits.Add(3, "grapes");
            fruits.Add(4, "orange");

            foreach (KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);
            }

            fruits.Remove(2);
            fruits.Add(2, "watermelon");

            foreach (KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);
            }

            SortedDictionary<int, string> gadgets = new SortedDictionary<int, string>();

            gadgets.Add(5, "phone");
            gadgets.Add(3, "Iphone");
            gadgets.Add(1, "telephone");
            gadgets.Add(4, "landline phone");
            gadgets.Add(2, "notepad");

            foreach (KeyValuePair<int, string> kv in gadgets)
            {
                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);
            }

            List<Employee> Employee = new List<Employee>();
            Employee.Add(new Employee() { Employeeid = 1, Empname = "sun", department = "microsoft" });

            Employee.Add(new Employee() { Employeeid = 2, Empname = "sundy", department = "microsoft" });

            Employee.Add(new Employee() { Employeeid = 11, Empname = "sunny", department = "microsoft" });

            foreach (var emp in Employee)
            {
                Console.WriteLine("Empid = {0},Empname  = {1},department = {2}", emp.Employeeid, emp.Empname, emp.department);
            }


            //stack and queue data structures
            //stack = LIFO  and  queue = FIFO

            Stack<float> fnumbers = new Stack<float>();

            fnumbers.Push(10.50f);
            fnumbers.Push(11.30f);
            fnumbers.Push(12.90f);
            fnumbers.Push(13.89f);
            Console.WriteLine("\n before calling the pop method\n");

            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            fnumbers.Pop();
            Console.WriteLine("\n After calling the pop method\n");

            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            Queue<double> qnumbers = new Queue<double>();
            qnumbers.Enqueue(15.98);
            qnumbers.Enqueue(12.98);
            qnumbers.Enqueue(13.98);
            qnumbers.Enqueue(14.98);

            Console.WriteLine("\n before calling the Dequeue method\n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            qnumbers.Dequeue();
            Console.WriteLine("\n After calling the Dequeue method\n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            int a, b;
            a = 20; b = 30;
            Console.WriteLine("before swap: a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);

            Console.WriteLine("After swap: a = {0}, b = {1}", a, b);

            string s1, s2;
            s1 = "hello";
            s2 = "world";
            Console.WriteLine("before swap: s1 = {0}, s2 = {1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("after swap: a ={0},b = {1}", s1, s2);



            Console.ReadKey();
        }


        public static void Swap<T>(ref T a, ref T b)       //generic method is used to swap different types
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
    }

    public class Employee
    {
        public int Employeeid
        { get; set; }
        public string Empname
        { get; set; }
        public string department
        { get; set; }

        public string ShowData()
        {
            return string.Format("Empid:{0,Empname;{1}},department:{2}", Employeeid, Empname, department);
        }
    }
}
    