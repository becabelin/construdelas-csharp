using System;
using System.Collections.Generic;
using System.Text;

namespace ConstruDelasConsole
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }

        public double ValorTotal()
        {
            double valorTotal = 0;
            foreach (var produto in Produtos)
            {
                valorTotal += produto.Valor * produto.Quantidade;
            }

            return valorTotal;
        }
    }
}