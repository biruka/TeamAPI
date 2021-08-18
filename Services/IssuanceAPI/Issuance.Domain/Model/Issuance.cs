using System;
using System.Collections.Generic;
using System.Text;
using Issuance.Domain.Seed;

namespace Issuance.Domain.Model
{
    public class Issuance : BaseAuditModel
    {
        public int requestId { get; set; }
        
        public string issuedBy { get; set; } 
        
        public DateTime issuedDate { get; set; }

        public Issuance()
        {
            this.requestId = requestId;
            this.issuedBy = issuedBy;
            this.issuedDate = issuedDate;

        }
    }
}
