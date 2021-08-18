using Item.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Interfaces.Repository
{
    public interface IItemRepository : IAsyncRepository<Model.Item>
    {
        Task<List<Model.Item>> GetByUser(string user);
    }
}
