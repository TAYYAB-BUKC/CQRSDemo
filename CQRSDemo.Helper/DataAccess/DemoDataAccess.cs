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

        public List<Person> GetPeople()
        {
            return People;
        }

        public Person InsertPerson(string firstName, string lastName)
        {
            Person newPerson = new() { Id = People.Count == 0 ? 1 : People.Max(p => p.Id) + 1, FirstName = firstName, LastName = lastName };
            People.Add(newPerson);
            return newPerson;
        }
    }
}