using CQRSDemo.Helper.Models;
using MediatR;

namespace CQRSDemo.Helper.Commands
{
    public class InsertPersonCommand : IRequest<Person>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public InsertPersonCommand(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}