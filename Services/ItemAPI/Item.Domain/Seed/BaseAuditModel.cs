using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Seed
{
    public class BaseAuditModel
    {
        public Guid Id { get; protected set; }
        public DateTime Createddate { get; protected set; }

    }
}
