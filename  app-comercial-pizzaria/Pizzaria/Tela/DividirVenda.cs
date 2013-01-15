using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Tela
{
    public partial class DividirVenda : Form
    {
        Classes.VendaFull vendas;
        public DividirVenda(Classes.VendaFull vf)
        {
            InitializeComponent();
            vendas = vf;
            carregar();
            mesas = new List<string>();
            rbAberta.Checked = true;
            lbTItulo.Text += " : "+vf.mesa[0];
        }
        public void carregar()
        {
            //carregar Mesas Disponiveis
            //carregar Itens
            try
            {
                
                vendas.ordenaProduto();
                lvItensOld.Items.Clear();
                for (int i = 0; i < vendas.Completos.Length; i++)
                {
                    //codigo
                    //lvInfo.Items.Add(vendas.Completos[i].cod_completo.ToString());
                    lvItensOld.Items.Add((i + 1).ToString());
                    //nome            
                    if (vendas.Completos[i].produto[0].porcentagem != 1)
                        lvItensOld.Items[i].SubItems.Add("Mista : " + new Banco.Banco().preencherNomeProdctAll(vendas.Completos[i].produto[0].cod_produto));
                    else
                        lvItensOld.Items[i].SubItems.Add(new Banco.Banco().preencherNomeProdctAll(vendas.Completos[i].produto[0].cod_produto));

                    lvItensOld.Items[i].SubItems.Add(new Banco.BancoInformacao().tamanhoDescricaoByCodigo(vendas.Completos[i].produto[0].cod_tamanho));
                    lvItensOld.Items[i].SubItems.Add(vendas.Completos[i].quantidade.ToString());
                    lvItensOld.Items[i].SubItems.Add("R$ " + new Classes.Tratamento().retornaValorEscrito(vendas.Completos[i].valorUnitario));
                    lvItensOld.Items[i].SubItems.Add("R$ " + new Classes.Tratamento().retornaValorEscrito(vendas.Completos[i].quantidade * vendas.Completos[i].valorUnitario));

                }
            }
            catch { }

        }
        List<String> mesas;
        public bool livre;
        private void btInserirMesa_Click(object sender, EventArgs e)
        {
            if (rbLivre.Checked)
            {
                livre = true;
                bool can = true;
                gbAddProduto.Visible = true;
                for (int i = 0; i < mesas.Count; i++)
                {
                    if (mesas[i] == cbMesas.Text) can = false;
                }
                if (can)
                    mesas.Add(cbMesas.Text);
            }
            else
            {
                if (vendas.cod_venda == new Banco.Banco().codigoDaVendaPelaMesa(cbMesas.Text)) {
                    return;
                
                }
                livre = false;
                gbAddProduto.Visible = true;
               
            }
            lbTituloDes.Text += (" : " + cbMesas.Text);
            label1.Visible = true;
            gbMesaDaVenda.Visible = false;
        }
        public int quantidade(int codigo)
        {
            for (int i = 0; i < codigosCompleto.Length; i++)
                if (codigosCompleto[i] == codigo)
                    return qtd[i];
            return 0;
        }
        public bool existe(int codigo)
        {
            for (int i = 0; i < codigosCompleto.Length; i++)
                if (codigosCompleto[i] == codigo)
                    return true;
            return false;
        }
        int[] codigosCompleto; int[] qtd;
        int cod_novaVenda = 0;
        public void carregarNovaVenda()
        {

            Classes.VendaFull vf = new Banco.BancoVenda().carregaVenda(cod_novaVenda);
            try
            {

                vf.ordenaProduto();
                lvItensNew.Items.Clear();
                for (int i = 0; i < vf.Completos.Length; i++)
                {
                    //codigo
                    //lvInfo.Items.Add(vendas.Completos[i].cod_completo.ToString());
                    lvItensNew.Items.Add((i + 1).ToString());
                    //nome            
                    if (vf.Completos[i].produto[0].porcentagem != 1)
                        lvItensNew.Items[i].SubItems.Add("Mista : " + new Banco.Banco().preencherNomeProdctAll(vf.Completos[i].produto[0].cod_produto));
                    else
                        lvItensNew.Items[i].SubItems.Add(new Banco.Banco().preencherNomeProdctAll(vf.Completos[i].produto[0].cod_produto));

                    lvItensNew.Items[i].SubItems.Add(new Banco.BancoInformacao().tamanhoDescricaoByCodigo(vf.Completos[i].produto[0].cod_tamanho));
                    lvItensNew.Items[i].SubItems.Add(vf.Completos[i].quantidade.ToString());
                    lvItensNew.Items[i].SubItems.Add("R$ " + new Classes.Tratamento().retornaValorEscrito(vf.Completos[i].valorUnitario));
                    lvItensNew.Items[i].SubItems.Add("R$ " + new Classes.Tratamento().retornaValorEscrito(vf.Completos[i].quantidade * vf.Completos[i].valorUnitario));

                }
            }
            catch { }
        }
        private void btProduto_Click(object sender, EventArgs e)
        {
            if (!livre)
            { 
                cod_novaVenda = new Banco.Banco().codigoDaVendaPelaMesa(cbMesas.Text); 

            
            }
                if (cod_novaVenda == 0)
                {

                    this.cod_novaVenda = new Banco.Banco().novaVenda(vendas.cod_caixa, new Banco.Banco().cod_mesa(mesas.ToArray()));//venda aberta
                    new Banco.BancoVenda().superVenda(this.cod_novaVenda);//cria a super venda e associa a venda criada
                }

                codigosCompleto = new int[lvItensOld.Items.Count];//os codigos dos produtos
                for (int i = 0; i < codigosCompleto.Length; i++)
                    codigosCompleto[i] = vendas.Completos[Convert.ToInt16(lvItensOld.Items[i].Text) - 1].cod_completo;
                // codigos[i] = Convert.ToInt16(lvInfo.Items[i].Text);

                qtd = new int[lvItensOld.Items.Count];//as quantidades
                for (int i = 0; i < qtd.Length; i++)
                    qtd[i] = Convert.ToInt16(lvItensOld.Items[i].SubItems[3].Text);
                //tenho q mover ou deletar

                if (existe(codigosCompleto[Convert.ToInt16(mtCodigo.Text) - 1]))
                {
                    if (numQuantidade.Value <= quantidade(codigosCompleto[Convert.ToInt16(mtCodigo.Text) - 1]))
                    {
                        new Banco.BancoInformacao().transferirCompleto(codigosCompleto[Convert.ToInt16(mtCodigo.Text) - 1],
                             Convert.ToInt16(numQuantidade.Value), this.cod_novaVenda);

                        MessageBox.Show("ALTERAÇÃO CONCLUÍDA", "MENSAGEM");
                        vendas = new Banco.BancoVenda().carregaVenda(vendas.cod_venda);
                        carregar();
                        new Banco.BancoInformacao().unirProdutosIguais(new Banco.BancoVenda().carregaVenda(cod_novaVenda));
                        carregarNovaVenda();
                    }
                    else
                    {
                        MessageBox.Show("QUANDITADE DE ITENS RETIRADOS ALÉM DA QUANTIA EXISTENTE", "MENSAGEM DE ERRO");
                    }
                }
                else
                { MessageBox.Show("CODIGO NÃO IDENTIFICADO NESTA VENDA ", "MENSAGEM DE ERRO"); }

                mtCodigo.Clear();
                mtCodigo.Focus();
            
        }

        private void btEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DividirVenda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    this.Close();
                    break;
            }
        }
        private void rbLivre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLivre.Checked)
            {

                cbMesas.DataSource = new Banco.Banco().mesasDisponiveis();
                cbMesas.DisplayMember = "descricao";

            }
            else
            {
                cbMesas.DataSource = new Banco.Banco().mesasIndisponiveis();
                cbMesas.DisplayMember = "descricao";
            }
        }




    }
}
