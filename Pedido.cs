using System;
using System.Collections.Generic;
using System.Text;

namespace ConstruDelasConsole
{
    public class Pedido
    {
        public Pedido()
        {
        }

        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }

        internal void Add(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}