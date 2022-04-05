using DemoMiniProfiler.Models;
using DemoMiniProfiler.Models.Dtos;
using DemoMiniProfiler.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StackExchange.Profiling;
using System.Threading.Tasks;

namespace DemoMiniProfiler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IItemRepository _itemRepository;

        public PedidoController(ILogger<PedidoController> logger,
                                IPedidoRepository pedidoRepository,
                                IItemRepository itemRepository)
        {
            _logger = logger;
            _pedidoRepository = pedidoRepository;
            _itemRepository = itemRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(SalvarPedidoDto pedidoDto)
        {
            using (MiniProfiler.Current.Step("SavePedido"))
            {
                _pedidoRepository.Salvar(new Pedido(pedidoDto.DataPedido, pedidoDto.CodigoCliente, pedidoDto.Valor));
                await _itemRepository.ObterTodos();
            }
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _itemRepository.ObterTodos();
            return Ok(await _pedidoRepository.ObterTodos());
        }
    }
}
