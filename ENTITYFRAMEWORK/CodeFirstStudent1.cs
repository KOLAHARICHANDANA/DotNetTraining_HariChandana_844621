using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstStudent1
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentDBContext context = new StudentDBContext();
            //LinqToEntity();
            //var student = context.Students;
            //var student1 = student.Add(new Student() { StudentID = 19, StudentName = "hari", Department = "eee" });
            //var student2 = student.Add(new Student() { StudentID = 20, StudentName = "sunanda", Department = "ece" });
            //var student3 = student.Add(new Student() { StudentID = 52, StudentName = "manisha", Department = "cse" });



            var mar  = context.Mrks;
            var sub1 = mar.Add(new MarksofStudent() { ID = 4, Subject = "epts", Marks = 90 });
            var sub2 = mar.Add(new MarksofStudent() { Subject = "psa", Marks = 88 });
            var sub3 = mar.Add(new MarksofStudent() { Subject = "pe", Marks = 75 });
            var sub4 = mar.Add(new MarksofStudent() { Subject = "psd", Marks = 68 });
           


            context.SaveChanges();



        }
        public class StudentDBContext : DbContext
        {
            public StudentDBContext() :
                base("name=StudentDBContext")
            { }
            public DbSet<Student> Students { get; set; }
            public DbSet<MarksofStudent> Mrks { get; set; }
        }

        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }

            public string Department { get; set; }

        }
        public class MarksofStudent
        {
            public int ID { get; set; }
            public string Subject { get; set; }
            public int Marks { get; set; }
        }

    }
}
   
   


