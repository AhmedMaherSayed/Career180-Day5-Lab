using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lab
{
    public class Employee
    {
        public static Dictionary<Employee, Dictionary<Club, Social>> employees = new Dictionary<Employee, Dictionary<Club, Social>>();
        public int Id { get; set; }
        public string Name { get; set; }
        public static event Action<Employee, Club, Social> myevent;
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"EmployeeId : {Id} - Name: {Name}";
        }
        public void OnMyEvent(Club c, Social s)
        {
            myevent(this, c, s);
        }
    }
}
