using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Classes
{
    public class Produto
    {
        public int cod_produto;
        public double porcentagem;
        public double valor;
        public int cod_tamanho;
        public bool impresso;
      
        //o valor por este metodo ja esta relacionado com porcentagem
        public void setLoad(int cod_prod, double pct, double valor, int tamanho,  bool impress)
        {
            cod_produto = cod_prod;
            porcentagem = pct; //100 50 25
            this.valor =pct * valor;


            this.cod_tamanho = tamanho;
            impresso = impress;
        }
        public void setLoadDividido(int cod_prod, double pct, double valor, int tamanho, bool impress)
        {
            cod_produto = cod_prod;
            porcentagem = pct; //100 50 25
            this.valor =  valor;


            this.cod_tamanho = tamanho;
            impresso = impress;
        }
    }
}
