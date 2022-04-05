using System;

namespace DemoMiniProfiler.Models
{
    public class Item
    {
        public Item()
        {
            Id = Guid.NewGuid();
        }

        public Item(string descricao)
        {
            Descricao = descricao;
        }

        public Guid Id { get; private set; }
        public string Descricao { get; set; }
    }
}
