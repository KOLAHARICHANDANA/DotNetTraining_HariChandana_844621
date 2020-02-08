using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{ 

public class overriding
{
    public static int mul(int a, int b)
    {
        return a*b;
    }
    public static int mul(int a, int b, int c)
    {
        return a * b * c;
    }
}
    public class TestMemberOverloading
    {
        public static void Main()
        {
            Console.WriteLine(overriding.mul(12, 23));
            Console.WriteLine(overriding.mul(12, 23, 25));
        }
    }
}

    