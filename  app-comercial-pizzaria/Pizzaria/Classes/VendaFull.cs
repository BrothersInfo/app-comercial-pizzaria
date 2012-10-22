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
        public int super;
        public int cod_pagamento;
        public int cod_venda;
        public int cod_caixa;
        public double valorTotal;
        public string horario;
        public string dia;
        public string[] mesa;
        public ArrayList produto = new ArrayList();
        public Completa[] Completos;
        public int qtdItens;
        public int[] garcon;
        public VendaHalf subItem;//-----------------------------------------------------------------------------


        public bool isHalfNull()
        {
            return subItem.Equals(null);
        }
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
        public void inserirProdutos(int[] codigo)
        {
            double tot = 0;
            Completa[] conj = new Completa[codigo.Length];

            for (int x = 0; x < conj.Length; x++)
                conj[x] = new BancoVenda().getCompleta(codigo[x]);

            for (int v = 0; v < codigo.Length; v++)
                tot += (conj[v].valorUnitario * conj[v].quantidade);

            subItem = new VendaHalf(cod_venda, cod_caixa, tot, DateTime.Now.ToShortTimeString(), dia, mesa);
            subItem.setCompleta(conj);
        }

        public VendaFull(Completa[] conjProd, int cod_venda, int cod_caixa, double valorTotal,
            string horario, string dia, string[] mesas, int[] garcon)
        {
            try
            {
                this.garcon = garcon;
                Completos = conjProd;

                this.cod_venda = cod_venda;
                this.cod_caixa = cod_caixa;
                this.valorTotal = valorTotal;
                this.horario = horario;
                this.dia = dia;
                this.mesa = mesas;


                produto.AddRange(conjProd);

                for (int i = 0; i < conjProd.Length; i++)
                {
                    this.valorTotal += (conjProd[i].valorUnitario * conjProd[i].quantidade);
                }
            }
            catch { }
        }
        public void encerraVenda()
        {
            new BancoVenda().encerrarVenda(valorTotal, cod_venda, mesa);
        }

        //esse metodo retorna a mesma venda, como uma nova venda.
        //retirando os produtos da 
        public VendaFull subVenda()
        {
            return null;
        }

    }
}
