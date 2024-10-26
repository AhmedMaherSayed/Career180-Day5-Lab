namespace Day5_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.myevent += Club.forevent;
            Employee.myevent += Social.forevent;

            Employee one = new Employee(1, "Ahmed");
            Club c = new Club(1, "Cairo");
            Social s = new Social(20);
            Employee two = new Employee(2, "Ali");
            Club c2 = new Club(2, "Giza");
            Social s2 = new Social(13);
            Dictionary<Club, Social> d = new Dictionary<Club, Social>();
            d.Add(c, s);
            Dictionary<Club, Social> d2 = new Dictionary<Club, Social>();
            d2.Add(c2, s2);
            Employee.employees.Add(one, d);
            Employee.employees.Add(two, d2);

            foreach (var e in Employee.employees)
            {
                foreach (var i in e.Value)
                    e.Key.OnMyEvent(i.Key, i.Value);
            }
        }
    }
}
