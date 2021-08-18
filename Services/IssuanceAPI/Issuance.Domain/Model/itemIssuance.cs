using System;
using System.Collections.Generic;
using System.Text;
using Issuance.Domain.Seed;

namespace Issuance.Domain.Model
{
    public class ItemIssuance : BaseAuditModel
    {
        public int ItemId { get; set; }

        public int IssueId { get; set; }

        public int RequestId { get; set; }

        public decimal Quantity { get; set; }

        public ItemIssuance(int itemId, int issuedId, int requestId, decimal quantity)
        {
            this.ItemId = itemId;
            this.IssueId = issuedId;
            this.RequestId = requestId;
            this.Quantity = quantity;

        }
    }
}
