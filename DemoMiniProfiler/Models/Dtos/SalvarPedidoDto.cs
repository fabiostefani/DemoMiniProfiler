using System;

namespace DemoMiniProfiler.Models.Dtos
{
    public class SalvarPedidoDto
    {
        public DateTime DataPedido { get; set; }
        public int CodigoCliente { get; set; }
        public decimal Valor { get; set; }
    }
}
