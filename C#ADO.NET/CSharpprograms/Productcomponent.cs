using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Productcomponent
{
    public class Product
    {
        public int Proid { get; set; }

       
        public int Proprice { get; set; }

        public double GetPrice(int n,int sp)

        {
              var Price = n * sp;

            return Price;
        }

        public double GetID(double price)
        {
            var Id = 2 * price;
            return Id;
        }


        public string ShowData()
        {
            return string.Format("Proid  = {0},   Proprice = {2}", Proid, Proprice);
        }
    }
}
