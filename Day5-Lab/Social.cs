using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lab
{
    public class Social
    {
        public int Cost { get; set; }
        public Social(int cost)
        {
            Cost = cost;
        }
        public override string ToString()
        {
            return $"Social Insurance cost : {Cost}$";
        }
        public static void forevent(Employee e, Club c, Social s)
        {
            Console.WriteLine(s);
            Console.WriteLine("-----------------------------------");
        }
    }
}
