using DemoMiniProfiler.Data;
using DemoMiniProfiler.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoMiniProfiler.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly MiniprofilerContext _context;
        public ItemRepository(MiniprofilerContext context)
        {
            _context = context;
        }
        public void Salvar(Item item)
        {
            _context.Itens.Add(item);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Item>> ObterTodos()
        {
            return await _context.Itens.ToListAsync();
        }
    }
}
