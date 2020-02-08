using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridingex
{
class override
public class show()
        {
   Console.WriteLine("My name is hari chandana");
       
public class over : override
 {
    public class show()

  Console.WriteLine("this is thursday");
}


static void Main(string[] args)
{
    override obj = new override();
    obj.show();
    obj = new over;
    obj.show();
   
}
