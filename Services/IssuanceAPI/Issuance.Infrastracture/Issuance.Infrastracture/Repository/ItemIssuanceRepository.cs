using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Issuance.Domain.Entities;
using Issuance.Domain.Interfaces.Repository;
using Issuance.Domain.Model;
using Issuance.Infrastracture.Context;

namespace Issuance.Infrastracture.Repository
{
    public class ItemIssuanceRepository : AsyncRepository<Issuance.Domain.Model.ItemIssuance>, IItemIssuanceRepostory
    {

        public ItemIssuanceRepository(IssuanceContext context) : base(context)
        {

        }

        public Task<List<ItemIssuanceEntity>> GetByIssuance(Guid issuance)
        {
            throw new NotImplementedException();
        }
    }
}
