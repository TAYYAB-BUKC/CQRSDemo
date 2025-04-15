using CQRSDemo.Helper.DataAccess;
using CQRSDemo.Helper.Models;
using CQRSDemo.Helper.Queries;
using MediatR;

namespace CQRSDemo.Helper.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, Person>
    {
        private readonly IMediator _mediator;
        public GetPersonByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var people = await _mediator.Send(new GetPersonListQuery());
            return people.FirstOrDefault(p => p.Id == request.id);
        }
    }
}
