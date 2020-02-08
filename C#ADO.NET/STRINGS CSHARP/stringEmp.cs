using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringEmp
{
    class Program
    {
       
  
      
            static void Main(string[] args)

            {

            string[] employees = new string[3] { "hari", "chandana", "nan"};

               
                for (int i = 0; i<employees.Length; i++)

                    Console.WriteLine("employees={0}", employees[i]);
                Console.ReadKey();

            }
        
    }

}
   
