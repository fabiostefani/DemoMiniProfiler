using DemoMiniProfiler.Data;
using DemoMiniProfiler.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoMiniProfiler.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly MiniprofilerContext _context;
        public PedidoRepository(MiniprofilerContext context)
        {
            _context = context;
        }
        public void Salvar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Pedido>> ObterTodos()
        {
            return await _context.Pedidos.ToListAsync();
        }
    }
}
