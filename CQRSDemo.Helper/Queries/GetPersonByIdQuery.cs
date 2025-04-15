using CQRSDemo.Helper.Models;
using MediatR;

namespace CQRSDemo.Helper.Queries
{
    public record GetPersonByIdQuery(int id) : IRequest<Person>;
}