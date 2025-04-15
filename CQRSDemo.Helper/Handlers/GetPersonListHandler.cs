using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSDemo.Helper.DataAccess;
using CQRSDemo.Helper.Models;
using CQRSDemo.Helper.Queries;
using MediatR;

namespace CQRSDemo.Helper.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<Person>>
    {
        private readonly IDemoDataAccess _demoDataAccess;
        public GetPersonListHandler(IDemoDataAccess demoDataAccess)
        {
            _demoDataAccess = demoDataAccess;
        }

        public Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_demoDataAccess.GetPeople());
        }
    }
}