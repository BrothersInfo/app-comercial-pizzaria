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
        public bool needImpress;
        public GarconFisico[] garcons;
        private string observacao;
        public void setNoticia(string noticia)
        {

            observacao = noticia;
            if (observacao.Length > 35) observacao = observacao.Substring(0, 35);
        }
        public string getNoticia()
        {
            return observacao;
        }

        public Completa(Produto[] produto,  int codCompleto, GarconFisico[] garcons)
        {
            this.cod_completo = codCompleto;
            valorUnitario = 0;
            this.produto = produto;
            quantidade = new Banco.BancoInformacao().quantidadeCompletaByCodigo(cod_completo);

            for (int i = 0; i < produto.Length; i++)
            {
                valorUnitario += produto[i].valor;

            }

            needImpress = false;

            for (int i = 0; i < produto.Length; i++ ) {
                if (produto[i].impresso) { needImpress = true; break; }
            }

            this.garcons = garcons;
        }
    }
}
