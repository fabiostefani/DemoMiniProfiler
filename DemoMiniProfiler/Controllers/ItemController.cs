using DemoMiniProfiler.Models;
using DemoMiniProfiler.Models.Dtos;
using DemoMiniProfiler.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DemoMiniProfiler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IItemRepository _itemRepository;

        public ItemController(ILogger<ItemController> logger,
                                IItemRepository itemRepository)
        {
            _logger = logger;
            _itemRepository = itemRepository;
        }

        [HttpPost]
        public IActionResult Post(SalvarItemDto itemDto)
        {
            _itemRepository.Salvar(new Item(itemDto.Descricao));
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _itemRepository.ObterTodos());
        }
    }
}
