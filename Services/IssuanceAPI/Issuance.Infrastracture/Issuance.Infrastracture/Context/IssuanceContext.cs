using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Issuance.Domain.Model;
using Issuance.Domain.Seed;

namespace Issuance.Infrastracture.Context
{
    public class IssuanceContext : DbContext
    {
        public IssuanceContext(DbContextOptions<IssuanceContext> options) : base(options)
        {

        }

        public DbSet<Issuance.Domain.Model.Issuance> Orders { get; set; }

        public DbSet<Issuance.Domain.Model.ItemIssuance> OrderItemModels { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseAuditModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedByUser = Guid.Empty;

                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = Guid.Empty;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
