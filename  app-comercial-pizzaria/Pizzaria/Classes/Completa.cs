using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Classes
{
    public class Completa
    {
        public Produto[] produto;
        public double valorUnitario;
        public int quantidade;
        public int cod_completo;

        public Completa(Produto[] produto, int qtd, int codCompleto)
        {
            this.cod_completo = codCompleto;
            valorUnitario = 0;
            this.produto = produto;
            quantidade = qtd;

            for (int i = 0; i < produto.Length; i++)
            {
                valorUnitario += produto[i].valor;

            }


        }
    }
}
