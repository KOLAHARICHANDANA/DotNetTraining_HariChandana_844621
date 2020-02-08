using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Io_manupulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("c:\\sampleDirectory");
            //dir.Create();

            //FileInfo file = new FileInfo(@"c:\SampleDirectory\sample.txt");
            //file.Create();

            Console.WriteLine("the directory and the text file have been created successfully");

            //FileStream fs = new FileStream(@"c:\SampleDirectory\sample.txt", FileMode.OpenOrCreate, FileAccess.Write);

            //StreamWriter sw = new StreamWriter(fs);

            //sw.WriteLine("this text has been writen to the file using file input/output manipulation");

            //sw.Close();
            //fs.Close();


            FileStream fs = new FileStream(@"c:\SampleDirectory\sample.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("this text has been appended to the existing content");

            sw.Close();
            fs.Close();




            Console.WriteLine("some content is written to the file");

            fs = new FileStream(@"c:\SampleDirectory\sample.txt", FileMode.Append, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);


            //var content = sr.ReadToEnd();

            //Console.WriteLine("The file content :{0}", content);

            string lineByline;

            while ((lineByline = sr.ReadLine()) != null)
            {
                Console.WriteLine("\nthe file content: {0}", lineByline);
            }
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
