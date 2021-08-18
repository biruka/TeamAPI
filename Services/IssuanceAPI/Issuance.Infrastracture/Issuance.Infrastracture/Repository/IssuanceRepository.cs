using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Issuance.Domain.Interfaces.Repository;
using Issuance.Domain.Model;
using Issuance.Infrastracture.Context;

namespace Issuance.Infrastracture.Repository
{
    public class IssuanceRepository : AsyncRepository<Issuance.Domain.Model.Issuance>, IIssuanceRepository
    {
        public IssuanceRepository(IssuanceContext context) : base(context)
        {

        }
        public Task<List<Domain.Model.Issuance>> GetByRequest(Guid request)
        {
            throw new NotImplementedException();
        }
    }
}
