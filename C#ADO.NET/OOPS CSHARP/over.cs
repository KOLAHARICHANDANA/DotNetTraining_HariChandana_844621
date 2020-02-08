using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over
{
    class Program
    {
        static void Main(string[] args)
        {
            student emp = new student();
            var x = emp.Getmarks(10, 20);
            Console.WriteLine(x);
            Teacher emp1 = new Teacher();
            var y = emp1.Getmarks(10, 20);
            Console.WriteLine(y);

        }
    }
    public class student
    {
        public virtual int Getmarks(int correct, int wrong)
        {
            int marks = correct * wrong;
            return marks;
        }
    }
    public class Teacher : student
    {
        public override int Getmarks(int correct, int wrong)
        {
            return base.Getmarks(correct, wrong) + 10;
        }
    }
}
