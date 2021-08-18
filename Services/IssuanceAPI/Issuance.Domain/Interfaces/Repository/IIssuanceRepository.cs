using System;
using System.Collections.Generic;
using System.Text;
using Issuance.Domain.Seed;
using Issuance.Domain.Model;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace Issuance.Domain.Interfaces.Repository
{
    public interface IIssuanceRepository : IAsyncRepository<Model.Issuance>
    {
        Task<List<Model.Issuance>> GetByRequest(Guid request);
    }
}
