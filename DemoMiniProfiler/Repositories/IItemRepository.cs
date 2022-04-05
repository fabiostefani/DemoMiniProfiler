using DemoMiniProfiler.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoMiniProfiler.Repositories
{
    public interface IItemRepository
    {
        void Salvar(Item item);
        Task<IEnumerable<Item>> ObterTodos();
    }
}
