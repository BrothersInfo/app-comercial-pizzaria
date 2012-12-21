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
        public void setInfo(int cod_prod, int pct, double valor, int tamanho, bool impresso)
        {
            cod_produto = cod_prod;
            porcentagem = pct;
            this.valor = valor;
            this.cod_tamanho = tamanho;
            this.impresso = impresso;
        }
        public int quantidade;
        //o valor por este metodo ja esta relacionado com porcentagem
        public void setLoad(int cod_prod, double pct, double valor, int tamanho, int quantidade, bool impress)
        {
            cod_produto = cod_prod;
            porcentagem = pct / 100; //100 50 25
            this.valor = (pct / 100) * valor;


            this.cod_tamanho = tamanho;
            this.quantidade = quantidade;
            impresso = impress;
        }
    }
}
