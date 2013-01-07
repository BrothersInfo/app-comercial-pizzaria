using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Classes
{
    public class LeituraX
    {
        public string data;
        public string hora;
        public string empresa;
        public  List< Item> itens;
        public double valorTotal;
        public double totDinheiro;
        public double totCredito;
        public double totDebito;
        public double totCheque;
        public string dataLeitura;
        public double extorno;
        public LeituraX()
        {
          extorno = totCheque =  totDinheiro =   totCredito =  totDebito = valorTotal = 0;
           itens = new List<Item>();
           data = DateTime.Now.ToShortDateString();
            
           hora = DateTime.Now.ToShortTimeString();
           empresa = new Banco.Banco().carregaComanda().Rows[0].ItemArray.GetValue(0).ToString();
        }
        public void addItem(string hora, int cod_venda, int cod_pagamento, double valor, string situ)
        {
            itens.Add(new Item(hora, cod_venda, cod_pagamento, valor, situ));

            if (situ.Equals("Finaliz"))
            {
                valorTotal += valor;
                switch (cod_pagamento)
                {
                    case 1:
                        totDinheiro += valor;
                        break;
                    case 2:
                        totCredito += valor;
                        break;
                    case 3:
                        totDebito += valor;
                        break;
                    case 4:
                        totCheque += valor;
                        break;
                }
            }
            else
            {
                extorno += valor;
            }
        }
        public void imprimir()
        {
            new Impressao( this );
           
        }

    }
    public class Item
    {
        public int cod_venda;
        public string mesa;
        public string hora;
        public int codPagamento;
        public double valor;
        public string formaPagamento;
        public string situac;

        public Item(string hora, int codMesa, int codPagamento, double valor, string situ)
        {
            this.hora = hora;
            this.cod_venda = codMesa;
          //  mesa = new Banco.Banco().mesaNomeByCodigo(codMesa);

            this.codPagamento = codPagamento;
            formaPagamento = new Banco.BancoVenda().formaPagamento(codPagamento);
            this.valor = valor;
            situac = situ;

        }
    }
}
