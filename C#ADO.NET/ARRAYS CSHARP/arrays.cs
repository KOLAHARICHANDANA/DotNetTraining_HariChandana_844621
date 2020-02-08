using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] marks = new int[6] { 97, 98, 96, 92, 91, 92 };
            for (int i = 0; i < marks.Length; i++)

                Console.WriteLine("marks={0}", marks[i]);
            var avgMarks = average(marks);
            Console.WriteLine("average of marks= {0}", avgMarks);
            Console.ReadKey();

        }
        public static double average(int[] marks)
        {
            int total = 0;
            double avg;
            for (int i = 0; i < marks.Length; i++)
                total = total + marks[i];
            avg = total / marks.Length;
            return avg;


        }


    }
}



