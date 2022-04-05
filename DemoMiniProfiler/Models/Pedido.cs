using System;

namespace DemoMiniProfiler.Models
{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public DateTime DataPedido { get; set; }
        public int CodigoCliente { get; set; }
        public decimal Valor { get; set; }
        public Pedido(DateTime dataPedido, int codigoCliente, decimal valor)
        {
            DataPedido = dataPedido;
            CodigoCliente = codigoCliente;
            Valor = valor;
        }
    }
}
