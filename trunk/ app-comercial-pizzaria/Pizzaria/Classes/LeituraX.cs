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

        public LeituraX()
        {
           totCheque =  totDinheiro =   totCredito =  totDebito = valorTotal = 0;
           itens = new List<Item>();
           data = DateTime.Now.ToShortDateString();
            
           hora = DateTime.Now.ToShortTimeString();
           empresa = new Banco.Banco().carregaComanda().Rows[0].ItemArray.GetValue(0).ToString();
        }
        public void addItem(string hora, int cod_mesa, int cod_pagamento, double valor)
        {
            itens.Add(new Item(hora, cod_mesa, cod_pagamento, valor));
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
        public void imprimir()
        {
            new Impressao( this );
           
        }

    }
    public class Item
    {
        public int codMesa;
        public string mesa;
        public string hora;
        public int codPagamento;
        public double valor;
        public string formaPagamento;

        public Item(string hora, int codMesa, int codPagamento, double valor)
        {
            this.hora = hora;
            this.codMesa = codMesa;
            mesa = new Banco.Banco().mesaNomeByCodigo(codMesa);

            this.codPagamento = codPagamento;
            formaPagamento = new Banco.BancoVenda().formaPagamento(codPagamento);
            this.valor = valor;

        }
    }
}
