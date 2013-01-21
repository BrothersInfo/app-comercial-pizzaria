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
    using Pizzaria.Banco;
    using Pizzaria.Properties;
    using Pizzaria.Classes;

    public partial class Venda : Form
    {
        public VendaFull venda;
        public VendaFull x;
        public bool isSubNew = false;
        //----------------------
        private bool addProduto = false;
        private bool removeProduto = false;
        public  bool getAddProduto(){
            return addProduto;
        }
        public  bool getRemoveProduto()
        {
            return removeProduto;
        }
        public  int  getCodVenda()
        {
            return venda.cod_venda;
        }
       
        //---------------------------------------------------------------------------------------
        public Venda(string mesa)
        {
            int cod_venda = new Banco().codigoDaVendaPelaMesa(mesa);
            InitializeComponent();
                 venda = new BancoVenda().carregaVenda(cod_venda);
                 tamanhoMTVALOR(venda);
                 carregarListView(venda);
                 regularTamanho(lvInfo.Width);
                 double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
                 double yy = ((13.5-10) * valr)+10 ;
                  this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
        }
        //---------------------------------------------------------------------------------------
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
            if (this.lvInfo.Items.Count >= 9)
                this.lvInfo.Scrollable = true;

            this.codGar.Width = (int)70;
            this.nomGar.Width = this.lvGarcon.Width - 68;

            this.lvGarcon.Scrollable = false;
            if (this.lvGarcon.Items.Count > 4)
                this.lvGarcon.Scrollable = true;

            this.nomMesa.Width = (int)70;
            this.ambient.Width = this.lvMesa.Width - 68;

            this.lvMesa.Scrollable = false;
            if (this.lvMesa.Items.Count > 4)
                this.lvMesa.Scrollable = true;

        }
        public void carregarListView(VendaFull vendas)
        {
            lOpcao.Text = "OPÇÕES DA VENDA - " + vendas.cod_venda;
            try
            {
                vendas.ordenaProduto();
                lvInfo.Items.Clear();
                lvGarcon.Items.Clear();
                lvMesa.Items.Clear();
                for (int i = 0; i < vendas.Completos.Length; i++)
                {
                    //codigo
                    //lvInfo.Items.Add(vendas.Completos[i].cod_completo.ToString());
                    lvInfo.Items.Add((i+1).ToString());
                    //nome            
                    if (vendas.Completos[i].produto[0].porcentagem != 1)
                        lvInfo.Items[i].SubItems.Add("Mista : " + new Banco().preencherNomeProdctAll(vendas.Completos[i].produto[0].cod_produto));
                    else
                        lvInfo.Items[i].SubItems.Add(new Banco().preencherNomeProdctAll(vendas.Completos[i].produto[0].cod_produto));

                    lvInfo.Items[i].SubItems.Add(new BancoInformacao().tamanhoDescricaoByCodigo(vendas.Completos[i].produto[0].cod_tamanho));
                    lvInfo.Items[i].SubItems.Add(vendas.Completos[i].quantidade.ToString());
                    lvInfo.Items[i].SubItems.Add("R$ " + new Tratamento().retornaValorEscrito(vendas.Completos[i].valorUnitario));
                    lvInfo.Items[i].SubItems.Add("R$ " + new Tratamento().retornaValorEscrito(vendas.Completos[i].quantidade * vendas.Completos[i].valorUnitario));

                }
            }
            catch { }
            List<Int16> gf = new List<Int16>();

            for (int i = 0; i < vendas.Completos.Length; i++)
                for (int j = 0; j < vendas.Completos[i].garcons.Length; j++)
                {
                    GarconFisico g = vendas.Completos[i].garcons[j];
                    bool can = true;
                    for (int k = 0 ; k < gf.Count;k++)
                        if(gf[k]==g.cod_garcon)
                                can = false;
                    if (can)
                        gf.Add((short)g.cod_garcon);
                    
                }
            for (int i = 0; i < gf.Count; i++)
            {
                lvGarcon.Items.Add(gf[i].ToString());
                lvGarcon.Items[i].SubItems.Add(new BancoVenda().nomeGarcon(gf[i]));
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
                if (venda.valorComissao > 0)
                {
                    lbComissao.Visible = true;
                    lbSubValor.Visible = true;
                    lbTotal.Visible = true;

                    lbSubValor.Text = "Sub Total R$" + new Tratamento().retornaValorEscrito(venda.subValor);
                    lbComissao.Text = "Couvert R$" + new Tratamento().retornaValorEscrito(venda.valorComissao);
                    lbTotal.Text = "Valor Total R$" + new Tratamento().retornaValorEscrito(venda.valorSomado);
                }
                else
                {
                    lbComissao.Visible = false;
                    lbSubValor.Visible = false;
                    lbTotal.Visible = true;
                    lbTotal.Text = "Valor Total R$" + new Tratamento().retornaValorEscrito(venda.valorSomado);
                }
               
            }
            catch
            {
                
            }
        }
   
        public void impressaoOk(int cod_venda)
        {
                new BancoVenda().imprimiu(cod_venda);
        }
        public void naoimpressao(int cod_venda)
        {
            new BancoVenda().naoImprimiu(cod_venda);
        }
        //-----------------------------os 7 botoes
        private void btInseMesa_Click(object sender, EventArgs e)
        {
            if (new Banco().mesasDisponiveis().Length > 0)
            {
                //    this.Visible = false;
                new AlterarMesa(false, venda.cod_venda).ShowDialog();

                naoimpressao(venda.cod_venda);
                //   this.Visible = true;
            }
            venda = new BancoVenda().carregaVenda(venda.cod_venda);
            tamanhoMTVALOR(venda);
            carregarListView(venda);
        }
        private void btRemoMesa_Click(object sender, EventArgs e)
        {
            if (venda.mesa.Length > 1)
            {
                new AlterarMesa(true, venda.cod_venda).ShowDialog();
                naoimpressao(venda.cod_venda);
            }
            venda = new BancoVenda().carregaVenda(venda.cod_venda);
            tamanhoMTVALOR(venda);
            carregarListView(venda);
        }
        private void btProduto_Click(object sender, EventArgs e)
        {
           new AddProduto(venda.cod_venda).ShowDialog();

         
            venda = new BancoVenda().carregaVenda(venda.cod_venda);
            tamanhoMTVALOR(venda);
            carregarListView(venda);
            naoimpressao(venda.cod_venda);
            this.Focus();
        }
        private void btRemoveProd_Click(object sender, EventArgs e)
        {
            int[] codigos = new int[lvInfo.Items.Count];
            for (int i = 0; i < codigos.Length; i++)
                codigos[i] = venda.Completos[Convert.ToInt16(lvInfo.Items[i].Text) - 1].cod_completo;
               // codigos[i] = Convert.ToInt16(lvInfo.Items[i].Text);

            int[] qtd = new int[lvInfo.Items.Count];
            for (int i = 0; i < qtd.Length; i++)
                qtd[i] = Convert.ToInt16(lvInfo.Items[i].SubItems[3].Text);

            new RemoverProduto(venda.cod_venda, codigos, qtd).ShowDialog();
            venda = new BancoVenda().carregaVenda(venda.cod_venda);
            tamanhoMTVALOR(venda);
            carregarListView(venda);
            naoimpressao(venda.cod_venda);
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja ANULAR esta venda?", "Confirme sua Opcao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new BancoVenda().anularVenda(venda.cod_venda,false);
                this.Close();
            }
        }
        private void btImprimir_Click(object sender, EventArgs e)
        {
            Impressao p;
            try
            { 
                p = new Impressao(venda);
                new BancoVenda().imprimiu(venda.cod_venda);
                p.imprimirComanda(1,venda);
            }
            catch
            {
                MessageBox.Show(" Erro 011 - informe a fabricio do ocorrido - Abertura de Classe ");
                return;
            }
        }
        private void btEncerrar_Click(object sender, EventArgs e)
        {
           
                if (new BancoVenda().isImpresso(venda.cod_venda) || (MessageBox.Show("COMANDA DESATUALIZADA \n DESEJA ENCERRAR MESMO ASSIM?", "Confirme sua Opcao", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    Pagamento rec = new Pagamento(  venda.cod_venda,venda.subValor,venda.valorComissao, venda.valorSomado, venda.mesa, false);
                   
                    rec.ShowDialog();
                    if (rec.encerrou)
                    {
                        MessageBox.Show("VENDA REALIZADA COM SUCESSO","MESSAGEM",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                        this.Close();
                    }
                }
        }
        private void btParcial_Click(object sender, EventArgs e)
        {
            new DividirVenda(venda).ShowDialog();
            venda = new BancoVenda().carregaVenda(new Banco().codigoDaVendaPelaMesa(venda.mesa[0]));
           
            tamanhoMTVALOR(venda);
            carregarListView(venda);
            regularTamanho(lvInfo.Width);
        }
        private void btMesaTrocar_Click(object sender, EventArgs e)
        {
            if (new Banco().mesasDisponiveis().Length > 0)
            {
                //    this.Visible = false;
                new AlterarMesa(venda.cod_venda).ShowDialog();

                naoimpressao(venda.cod_venda);
                //   this.Visible = true;
            }
            venda = new BancoVenda().carregaVenda(venda.cod_venda);
            tamanhoMTVALOR(venda);
            carregarListView(venda);
        }
        private void btAgrupar_Click(object sender, EventArgs e)
        {
            AlterarMesa am = new AlterarMesa();
            am.ShowDialog();
            if (am.cod_venda != 0)
            {
                venda = new BancoVenda().carregaVenda(am.cod_venda);
                tamanhoMTVALOR(venda);
                carregarListView(venda);
            }
        }
        private void lvInfo_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                ListViewItem t = lvInfo.FocusedItem;
                int asd =
                venda.Completos[Convert.ToInt16(lvInfo.FocusedItem.SubItems[0].Text) - 1].cod_completo;
                DataTable dttGarcon = new Banco().GarconDaVenda(venda.cod_venda);

                if (dttGarcon.Rows.Count > 1)
                {
                    Garcon g = new Garcon(venda.cod_venda);
                    g.ShowDialog();

                    Completa cc = new BancoVenda().getCompleta(asd, false);
                    new BancoInformacao().addqtdGarconCompleto(g.getRetorno(), asd, 1);// cod_garcon cod_completo quantidade
                    if (cc.needImpress)
                    {
                        cc.garconImprimir = new BancoVenda().nomeGarcon(g.getRetorno());
                        cc.quantidade = 1;
                        cc.segmentoImprimir = new Banco().segmentoDoProduto(cc.produto[0].cod_produto);
                        Impressao p = new Impressao(venda);
                        p.gerarComandaCozinha(new Completa[] { cc }, venda.mesa, false);
                    }
                }
                else
                    if (MessageBox.Show("Acrescentar Mais Um ?", "Confirme sua Opcao", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                    {
                        Completa cc = new BancoVenda().getCompleta(asd, false);
                        new BancoInformacao().addqtdGarconCompleto(Convert.ToInt16(dttGarcon.Rows[0].ItemArray.GetValue(0)),
                       asd, 1);
                        if (cc.needImpress)
                        {
                            cc.garconImprimir = cc.garcons[0].nome;
                            cc.quantidade = 1;
                            cc.segmentoImprimir = new Banco().segmentoDoProduto(cc.produto[0].cod_produto);
                            Impressao p = new Impressao(venda);
                            p.gerarComandaCozinha(new Completa[] { cc }, venda.mesa, false);
                        }
                    }

                venda = new BancoVenda().carregaVenda(venda.cod_venda);
                tamanhoMTVALOR(venda);
                carregarListView(venda);
                regularTamanho(lvInfo.Width);
            }
            catch { return; }
        }
        private void Venda_KeyDown(object sender, KeyEventArgs e)
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
                case Keys.S://Voltar Tela
                    btParcial_Click(sender, null);
                    break;
                case Keys.A://Voltar Tela
                   btAgrupar_Click(sender, null);
                    break;
                case Keys.P://Voltar Tela
                    btProduto_Click(sender, null);
                    break;
                case Keys.R://Voltar Tela
                    btRemoveProd_Click(sender, null);
                    break;
                case Keys.M://Voltar Tela
                    btInseMesa_Click(sender, null);
                    break;
                case Keys.N://Voltar Tela
                    btRemoMesa_Click(sender, null);
                    break;
                case Keys.T://Voltar Tela
                    btMesaTrocar_Click(sender, null);
                    break;




            }
        }
    
        
        private void reimpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int lvd = lvInfo.FocusedItem.Index;
                Completa item = venda.Completos[lvd];

                new QuantidadeItem(venda.cod_venda, item).ShowDialog();
            }
            catch {
                return;
            }
        }
        private void MSProduto_Click(object sender, EventArgs e)
        {
            ListViewItem t = lvInfo.FocusedItem;
            try
            {
                if (t.Equals(null))
                {
                    return;
                }
            }
            catch
            {
                return;
            }
            int asd =
            venda.Completos[Convert.ToInt16(lvInfo.FocusedItem.SubItems[0].Text) - 1].cod_completo;
            try
            {
                DataTable dttGarcon = new Banco().GarconDaVenda(venda.cod_venda);

                if (dttGarcon.Rows.Count > 1)
                {
                    Garcon g = new Garcon(venda.cod_venda);
                    g.ShowDialog();

                    Completa cc = new BancoVenda().getCompleta(asd, false);
                    new BancoInformacao().addqtdGarconCompleto(g.getRetorno(), asd, 1);// cod_garcon cod_completo quantidade
                    if (cc.needImpress)
                    {
                        cc.garconImprimir = new BancoVenda().nomeGarcon(g.getRetorno());
                        cc.quantidade = 1;
                        cc.segmentoImprimir = new Banco().segmentoDoProduto(cc.produto[0].cod_produto);
                        Impressao p = new Impressao(venda);
                        p.gerarComandaCozinha(new Completa[] { cc }, venda.mesa,false );
                    }
                }
                else
                    {

                        Completa cc = new BancoVenda().getCompleta(asd, false);
                        new BancoInformacao().addqtdGarconCompleto(Convert.ToInt16(dttGarcon.Rows[0].ItemArray.GetValue(0)),
                       asd, 1);
                        if (cc.needImpress)
                        {
                            cc.garconImprimir = cc.garcons[0].nome;
                            cc.quantidade = 1;
                            cc.segmentoImprimir = new Banco().segmentoDoProduto(cc.produto[0].cod_produto);
                            Impressao p = new Impressao(venda);
                            p.gerarComandaCozinha(new Completa[] { cc }, venda.mesa, false);
                        }
                    }

                venda = new BancoVenda().carregaVenda(venda.cod_venda);
                tamanhoMTVALOR(venda);
                carregarListView(venda);
                regularTamanho(lvInfo.Width);
            }
            catch { }
        }
        private void ttRemoverUm_Click(object sender, EventArgs e)
        {
              try
            {
            int lvd = lvInfo.FocusedItem.Index;
            
                Completa item = venda.Completos[lvd];

                new BancoInformacao().deletarCompleto(item.cod_completo, 1);

                venda = new BancoVenda().carregaVenda(venda.cod_venda);
                tamanhoMTVALOR(venda);
                carregarListView(venda);
            }
            catch{return; }
        }
        private void ttRemoverTodos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza Disso ?", "Confirme sua Opcao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1
                , MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
            {
                try
                {
                    int lvd = lvInfo.FocusedItem.Index;
                    Completa item = venda.Completos[lvd];

                    new BancoInformacao().deletarCompleto(item.cod_completo, item.quantidade);

                    venda = new BancoVenda().carregaVenda(venda.cod_venda);
                    tamanhoMTVALOR(venda);
                    carregarListView(venda);
                }
                catch
                {
                    return;
                }

            }
        }
      
        }

      
        //------------------------------------------------------------------------------------
    }

