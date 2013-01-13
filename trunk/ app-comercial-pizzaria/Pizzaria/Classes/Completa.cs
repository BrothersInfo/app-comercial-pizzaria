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
        private string observacao= "";
        public string garconImprimir;
        public string segmentoImprimir;
        public void setNoticia(string noticia)
        {

            observacao = noticia;
            if (observacao.Length > 35) observacao = observacao.Substring(0, 35);
        }
        public string getNoticia()
        {

            return observacao;
        }

        public Completa(Produto[] produto,  int codCompleto, GarconFisico[] garcons, double valorCompleto)
        {
            this.cod_completo = codCompleto;
            valorUnitario = valorCompleto;
            this.produto = produto;
            quantidade = new Banco.BancoInformacao().quantidadeCompletaByCodigo(cod_completo);



            needImpress = false;

            for (int i = 0; i < produto.Length; i++ ) {
                if (produto[i].impresso) { needImpress = true; break; }
            }

            this.garcons = garcons;
        }
    }
}
