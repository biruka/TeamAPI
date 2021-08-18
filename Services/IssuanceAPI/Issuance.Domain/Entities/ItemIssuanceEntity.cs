using System;
using System.Collections.Generic;
using System.Text;
using Issuance.Domain.Model;
using Issuance.Domain.Seed;

namespace Issuance.Domain.Entities
{
    public class ItemIssuanceEntity : BaseEntity<Model.ItemIssuance>
    {
        public int itemId { get; set; }

        public int issueId { get; set; }

        public int requestIda { get; set; }

        public decimal Quantity { get; set; }

        public List<ItemIssuance> issuanceItem { get; set; }

        public override ItemIssuance MapToModel()
        {
            throw new NotImplementedException();
        }

        public override ItemIssuance MapToModel(ItemIssuance t)
        {
            throw new NotImplementedException();
        }
    }
}
