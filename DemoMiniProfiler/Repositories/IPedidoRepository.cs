using DemoMiniProfiler.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoMiniProfiler.Repositories
{
    public interface IPedidoRepository
    {
        void Salvar(Pedido pedido);
        Task<IEnumerable<Pedido>> ObterTodos();
    }
}
