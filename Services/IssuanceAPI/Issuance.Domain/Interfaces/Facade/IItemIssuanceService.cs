using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Issuance.Domain.Entities;

namespace Issuance.Domain.Interfaces.Facade
{
    public interface IItemIssuanceService
    {
        Task<List<ItemIssuanceEntity>> GetAllItemIssuance();

        Task<List<ItemIssuanceEntity>> GetItemIssuance(Guid itemIssuance);

        Task<Guid> Add(Issuance.Domain.Entities.ItemIssuanceEntity itemIssuance);

        Task UpdateItemIssuance(ItemIssuanceEntity itemIssuance);

        Task DeleteItemIssuance(ItemIssuanceEntity itemIssuance);
    }
}
