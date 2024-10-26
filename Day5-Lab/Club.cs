using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lab
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Club(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public override string ToString()
        {
            return $"Club Id : {Id} - Location: {Name}";
        }
        public static void forevent(Employee e, Club c, Social s)
        {
            Console.WriteLine(e);
            Console.WriteLine(c);

        }
    }
}
