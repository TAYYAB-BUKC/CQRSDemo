using CQRSDemo.Helper.Commands;
using CQRSDemo.Helper.DataAccess;
using CQRSDemo.Helper.Models;
using MediatR;

namespace CQRSDemo.Helper.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, Person>
    {
        private readonly IDemoDataAccess _demoDataAccess;
        public InsertPersonHandler(IDemoDataAccess demoDataAccess)
        {
            _demoDataAccess = demoDataAccess;
        }

        public Task<Person> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_demoDataAccess.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
