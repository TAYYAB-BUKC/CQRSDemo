using CQRSDemo.Helper.Models;

namespace CQRSDemo.Helper.DataAccess
{
    public class DemoDataAccess
    {
        public List<Person> People = new();

        public DemoDataAccess()
        {
            People.Add(new Person { Id = 1, FirstName = "Tayyab", LastName = "Arsalan" });
            People.Add(new Person { Id = 2, FirstName = "Noman", LastName = "Khalid" });
            People.Add(new Person { Id = 3, FirstName = "Tahir", LastName = "Jaffar" });
        }
    }
}