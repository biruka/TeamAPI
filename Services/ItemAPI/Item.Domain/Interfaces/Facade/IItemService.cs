using Item.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Interfaces.Facade
{
    public interface IItemService
    {
        Task<List<ItemEntity>> GetAllItems();
        Task<Guid> Add(Item.Domain.Entities.ItemEntity Item);
        Task<List<ItemEntity>> GetByUser(string user);
        Task UpdateItem (ItemEntity Item);

    }
}
