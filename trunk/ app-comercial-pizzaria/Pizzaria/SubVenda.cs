using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class SubVenda : Form
    {
        public SubVenda(VendaFull vf)
        {
            InitializeComponent();
            venda = vf;
      
       tamanhoMTVALOR(venda);
        carregarListView(venda);
        regularTamanho(lvInfo.Width);
        posicionamento();
        }
        private void posicionamento()
        {
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr) + 345;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
        }
        VendaFull venda;
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void regularTamanho(double tamanho)
        {
            double umPct = tamanho / 100;
            this.lvInfo.Size = new System.Drawing.Size((int)tamanho, 384); //570 555
            this.codigo.Width = (int)(umPct * 10);// 55;//10% 

            this.Produto.Width = (int)(umPct * 32);//32%

            this.Tamanho.Width = (int)(umPct * 13);//13%

            this.Quantidade.Width = (int)(umPct * 14);//14%

            this.ValorUni.Width = (int)(umPct * 16);//16%

            this.SubTotal.Width = (int)(umPct * 15);//15%
            this.lvInfo.Scrollable = false;
            if (this.lvInfo.Items.Count >= 5)
                this.lvInfo.Scrollable = true;

            this.codGar.Width = (int)70;
            this.nomGar.Width = this.lvGarcon.Width - 68;
            this.lvGarcon.Scrollable = false;
            if (this.lvGarcon.Items.Count > 5)
                this.lvGarcon.Scrollable = true;

            this.nomMesa.Width = (int)70;
            this.ambient.Width = this.lvMesa.Width - 68;
            this.lvMesa.Scrollable = false;
            if (this.lvMesa.Items.Count > 5)
                this.lvMesa.Scrollable = true;

        }
        public void carregarListView(VendaFull vendas)
        {
            try
            {
                vendas.ordenaProduto();
                lvInfo.Items.Clear();
                lvGarcon.Items.Clear();
                lvMesa.Items.Clear();
                for (int i = 0; i < vendas.Completos.Length; i++)
                {
                    //codigo
                   // lvInfo.Items.Add(vendas.Completos[i].cod_completo.ToString());
                    lvInfo.Items.Add((i + 1).ToString());
                    
                    //nome            
                    if (vendas.Completos[i].produto[0].porcentagem != 1)
                        lvInfo.Items[i].SubItems.Add("Mista : " + new Banco().preencherNomeProdctAll(vendas.Completos[i].produto[0].cod_produto));
                    else
                        lvInfo.Items[i].SubItems.Add(new Banco().preencherNomeProdctAll(vendas.Completos[i].produto[0].cod_produto));

                    lvInfo.Items[i].SubItems.Add(new BancoVenda().tamanhoDescricao(vendas.Completos[i].produto[0].cod_tamanho));
                    lvInfo.Items[i].SubItems.Add(vendas.Completos[i].quantidade.ToString());
                    lvInfo.Items[i].SubItems.Add("R$ " + new Tratamento().retornaValorEscrito(vendas.Completos[i].valorUnitario));
                    lvInfo.Items[i].SubItems.Add("R$ " + new Tratamento().retornaValorEscrito(vendas.Completos[i].quantidade * vendas.Completos[i].valorUnitario));

                }
            }
            catch { }
            for (int i = 0; i < vendas.garcon.Length; i++)
            {
                lvGarcon.Items.Add(vendas.garcon[i].ToString());
                lvGarcon.Items[i].SubItems.Add(new BancoVenda().nomeGarcon(vendas.garcon[i]));
            }
            for (int i = 0; i < vendas.mesa.Length; i++)
            {
                lvMesa.Items.Add(vendas.mesa[i]);
                lvMesa.Items[i].SubItems.Add(new BancoVenda().nomeAmbiente(vendas.mesa[i]));
            }
        }
        public void tamanhoMTVALOR(VendaFull venda)
        {
            try
            {
                if (venda.valorTotal < 10) mtValor.Mask = "0.00";
                else
                    if (venda.valorTotal < 100 && venda.valorTotal >= 10) mtValor.Mask = "00.00";
                    else if (venda.valorTotal >= 100 && venda.valorTotal < 1000) mtValor.Mask = "000.00";
                    else mtValor.Mask = "0000.00";

                mtValor.Text = new Tratamento().retornaValorEscrito(venda.valorTotal);
            }
            catch
            {
                mtValor.Mask = "0.00";
            }

        }      
        private void btImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Impressao p;
                p = new Impressao(venda);
                new BancoVenda().imprimiu(venda.cod_venda);
                p.gerarComprovante();
                p.lerArquivo();
            }
            catch
            {
                MessageBox.Show(" Erro 011 - informe a fabricio do ocorrido ");
                return;
            }
        }
        private void btEncerrar_Click(object sender, EventArgs e)
        {
            if (new BancoVenda().isImpresso(venda.cod_venda) || (MessageBox.Show("COMANDA DESATUALIZADA \n DESEJA ENCERRAR MESMO ASSIM?", "Confirme sua Opcao", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                Encerrar rec = new Encerrar(venda);
                rec.ShowDialog();
                if (rec.encerrou)
                {
                    MessageBox.Show("VENDA REALIZADA COM SUCESSO");
                    this.Close();
                }
            }
        }

        private void SubVenda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    btVoltar_Click(sender, null);
                    break;
                case Keys.I://Voltar Tela
                    btImprimir_Click(sender, null);
                    break;
                case Keys.V://Voltar Tela
                    btEncerrar_Click(sender, null);
                    break;
            }
        }

 

    }
}
