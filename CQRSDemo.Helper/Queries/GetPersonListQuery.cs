using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSDemo.Helper.Models;
using MediatR;

namespace CQRSDemo.Helper.Queries
{
    public record GetPersonListQuery : IRequest<List<Person>>
    {
    }
}
