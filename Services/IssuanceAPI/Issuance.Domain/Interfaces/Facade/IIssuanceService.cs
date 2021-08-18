using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Issuance.Domain.Entities;

namespace Issuance.Domain.Interfaces.Facade
{
    public interface IIssuanceService
    {
        Task<List<IssuanceEntity>> GetAllIssuance();

        Task<Guid> Add(Issuance.Domain.Entities.IssuanceEntity issuance);

        Task<List<IssuanceEntity>> GetIssuance(Guid issuance);

        Task UpdateIssuance(IssuanceEntity issuance);

        Task Delete(IssuanceEntity issuance);
    }
}
