using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Pizzaria.Classes
{

    using Pizzaria.Banco;
    public class VendaFull
    {
        public bool isComissaoPct;
        public double valorComissao;
        public int super;
        public int cod_pagamento;
        public int cod_venda;
        public int cod_caixa;
        public double valorSomado;
        public double subValor;
        public string horario;
        public string dia;
        public string[] mesa;
        public Completa[] Completos;
        public int qtdItens;
       // public int[] garcon;

        public void ordenaProduto()
        {

            for (int i = 0; i < Completos.Length; i++)
            {
                for (int j = 0; j < Completos.Length; j++)
                {
                    if (Completos[i].cod_completo < Completos[j].cod_completo)
                    {
                        Completa tempora = Completos[j];
                        Completos[j] = Completos[i];
                        Completos[i] = tempora;

                    }
                }
            }

        }

        public VendaFull(Completa[] conjProd, int cod_venda, int cod_caixa, double subValor,
            string horario, string dia, string[] mesas, bool isPctComissao, double valorComissao, double valorSomado)
        {
            try
            {
               // this.garcon = garcon;
                Completos = conjProd;
                this.cod_venda = cod_venda;
                this.cod_caixa = cod_caixa;
                this.valorSomado = valorSomado;
                this.horario = horario;
                this.dia = dia;
                this.mesa = mesas;
                this.isComissaoPct = isPctComissao;
                this.valorComissao = valorComissao;
                this.subValor = 0;
                if (this.subValor == 0)
                {
                    for (int i = 0; i < conjProd.Length; i++)
                        this.subValor += (conjProd[i].valorUnitario * conjProd[i].quantidade);

                    if (isPctComissao)
                    {
                        this.valorSomado = ((valorComissao / 100) * this.subValor) + this.subValor;
                        this.valorSomado = Math.Round(this.valorSomado, 2);
                        this.valorComissao = ((valorComissao / 100) * this.subValor);
                        this.valorComissao = Math.Round(this.valorComissao, 2);
                    }
                    else
                    {
                        this.valorSomado = this.subValor + valorComissao;
                        this.valorSomado = Math.Round(this.valorSomado, 2);
                    }
                }
            }
            catch { }
        }
        


    }
}
