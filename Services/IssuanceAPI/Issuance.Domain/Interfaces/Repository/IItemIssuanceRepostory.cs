using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Issuance.Domain.Entities;

namespace Issuance.Domain.Interfaces.Repository
{
    public interface IItemIssuanceRepostory
    {
        Task<List<ItemIssuanceEntity>> GetByIssuance(Guid issuance);
    }
}
