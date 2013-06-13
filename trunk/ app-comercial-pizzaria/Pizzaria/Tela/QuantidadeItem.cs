using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Pizzaria.Banco;
using Pizzaria.Properties;
using Pizzaria.Classes;

namespace Pizzaria.Tela
{
    public partial class QuantidadeItem : Form
    {
        Completa produto;
        int cod_venda;
        public QuantidadeItem(int cod_venda, Completa p)
        {
            InitializeComponent();
            produto = p;  
            numQuantidade.Maximum = decimal.Parse(  p.quantidade.ToString().Replace(',','.') );
            this.cod_venda = cod_venda;
        }

        private void btParcial_Click(object sender, EventArgs e)
        {
            try
            {
                produto.quantidade = (int)numQuantidade.Value;
                produto.garconImprimir = produto.garcons[0].nome;
                produto.segmentoImprimir = new Banco.Banco().segmentoDoProduto(produto.produto[0].cod_produto);
                VendaFull vf = new BancoVenda().carregaVenda(cod_venda);
                new Impressao(vf).gerarComandaCozinha(new Completa[] { produto }, vf.mesa, true);
            }
            catch { return; }
            this.Close();

        }

        private void QuantidadeItem_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    this.Close();
                    break;
           
                case Keys.I://Voltar Tela
                    btParcial_Click(sender, null);
                    break;
           
            }
        }


    }
}
