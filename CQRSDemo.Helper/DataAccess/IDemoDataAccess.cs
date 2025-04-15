using CQRSDemo.Helper.Models;

namespace CQRSDemo.Helper.DataAccess
{
    public interface IDemoDataAccess
    {
        List<Person> GetPeople();
        Person InsertPerson(string firstName, string lastName);
    }
}