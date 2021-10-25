using System;
using System.Collections.Generic;
using System.Text;

namespace ConstruDelasConsole
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotal()
        {
            return Valor * Quantidade;
        }
    }
}