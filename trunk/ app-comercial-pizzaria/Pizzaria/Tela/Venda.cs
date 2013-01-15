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
     /*   Panel painel;
        Button avancar;
        NumericUpDown numQuantidade;
        Label label;
        Label label2;
        Label recado;
        */
        private bool addProduto = false;
        private bool removeProduto = false;
        public bool getAddProduto(){
            return addProduto;
        }
        public bool getRemoveProduto()
        {
            return removeProduto;
        }
        public int getCodVenda()
        {
            return venda.cod_venda;
        }
        int cont = 0;
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
        //------------------------------------------------------------------------------------

        //-------------------------OBJETOS DINAMICOS DA TELA----------------------------------

        //------------------------------------------------------------------------------------

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
                p.gerarComprovante();
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
                    Pagamento rec = new Pagamento(venda.cod_venda, venda.valorTotal, venda.mesa, false);
                   
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
            /*if (lvInfo.CheckedItems.Count > 0)
            {
                int[] num = new int[lvInfo.CheckedItems.Count];

                for (int i = 0; i < num.Length; i++)
                    num[i] =  venda.Completos[  Convert.ToInt16(lvInfo.CheckedItems[i].Text)-1].cod_completo;

                venda.inserirProdutos(num);
                //
                //painel Teste
                //
                temp = primeiroParcial();
                if (temp != null)
                {
                    inicializarPainel(primeiroParcial().quantidade);
                    label.Text = temp.cod_completo.ToString();
                    label2.Text = new Banco().preencherNomeProdutoAlt(temp.produto[0].cod_produto);
                    naoimpressao(venda.cod_venda);
                    
                    tamanhoMTVALOR(venda);
                    carregarListView(venda);
                }
                else
                {
                    naoimpressao(venda.cod_venda);
                    venda.subItem.corrigirValor();
                    x = resgatarSubVenda(venda);

                    SubVenda objs = new SubVenda(this.getX());
                    objs.ShowDialog();

                    int cod_ = new Banco().codigoDaVendaPelaMesa(venda.mesa[0]);
                  
                    venda = new BancoVenda().carregaVenda(cod_);
                    tamanhoMTVALOR(venda);
                    carregarListView(venda);
                    regularTamanho(lvInfo.Width);
                 
                }
            }
            else
            {
                MessageBox.Show("SELECIONE OS ITENS DA VENDA PARCIAL");
            }
             */
            new DividirVenda(venda).ShowDialog();
            venda = new BancoVenda().carregaVenda(new Banco().codigoDaVendaPelaMesa(venda.mesa[0]));
           
            tamanhoMTVALOR(venda);
            carregarListView(venda);
            regularTamanho(lvInfo.Width);
        }
        public VendaFull resgatarSubVenda(VendaFull retorno)
        {

            retorno.Completos = retorno.subItem.Completos;
            retorno.valorTotal = retorno.subItem.valorTotal;

            retorno.subItem.comanda = true;
            return retorno;
        }
        public Completa metodoEscrita()
        {
            while (++cont < venda.subItem.Completos.Length)
                if (venda.subItem.Completos[cont].quantidade > 1)
                    return venda.subItem.Completos[cont];
            return null;
        }
        public Completa primeiroParcial()
        {
            try
            {
                for (int i = 0; venda.subItem != null && i < venda.subItem.Completos.Length; i++)
                    if (venda.subItem.Completos[i].quantidade > 1)
                    {
                        cont = i;
                        return venda.subItem.Completos[i];

                    }
                return null;
            }
            catch
            {
                return null;
            }
        }
        //------------------------------------------------------------------------------------
/*        public void btAvanco_click(object sender, EventArgs e)
        {

            //primeiro evento do clique é alterar a quantidade do item atual, mas que item atual?
            temp.quantidade = (int)numQuantidade.Value;
            substituir(venda, cont);
            temp = metodoEscrita();

            if (temp != null)
            {
                label.Text = temp.cod_completo.ToString();
                label2.Text = new Banco().preencherNomeProdutoAlt(temp.produto[0].cod_produto);
                numQuantidade.Maximum = temp.quantidade;
            }
            else
            {
                venda.subItem.corrigirValor();
                x = resgatarSubVenda(venda);

                SubVenda objs = new SubVenda(this.getX());
                objs.ShowDialog();

                int cod_ = new Banco().codigoDaVendaPelaMesa(venda.mesa[0]);
               
                venda = new BancoVenda().carregaVenda(cod_);
                tamanhoMTVALOR(venda);
                carregarListView(venda);
                regularTamanho(lvInfo.Width);

                tabLayDescricao.Visible = true;
                painel.Dispose();
            }

        }
        public VendaFull getX()
        {
            return x;
        }
        public void substituir(VendaFull vendas, int posicao)//atualiza depois da mudança dentro do PAINEL
        {
            vendas.subItem.Completos[posicao] = temp;

        }
  */
        //---------------------inicializadores
  /*      public void inicializarRecado()
        {
            if (recado != null)
                recado.Dispose();

            recado = new Label();
            recado.AutoSize = true;//nome
            recado.Font = new System.Drawing.Font("Arial", 13F);
            recado.ForeColor = System.Drawing.Color.Maroon;
            recado.Location = new System.Drawing.Point(25, 20);
            recado.Name = "recado";
            recado.Size = new System.Drawing.Size(46, 21);
            recado.TabIndex = 15;
            recado.Text = "DEFINA A QUANTIDADE DOS ITENS NA SUB-VENDA \n*A QUANTIDADE SERÁ RETIRADA DA VENDA ATUAL";
        }
        public void inicializarQuantidade(int qtd)
        {
            if (numQuantidade != null)
                numQuantidade.Dispose();
            numQuantidade = new NumericUpDown();
            numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numQuantidade.Location = new System.Drawing.Point(350, 80);
            numQuantidade.Maximum = new decimal(new int[] { qtd, 0, 0, 0 });
            numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new System.Drawing.Size(50, 32);
            numQuantidade.TabIndex = qtd;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
        }
        public void inicializarDoisLabel()
        {
            if (label != null)
                label.Dispose();

            label = new Label();
            label.AutoSize = true; // codigo
            label.Font = new System.Drawing.Font("Arial", 13F);
            label.ForeColor = System.Drawing.Color.Maroon;
            label.Location = new System.Drawing.Point(90, 85);
            label.Name = "label";
            label.Size = new System.Drawing.Size(46, 21);
            label.TabIndex = 15;
            label.Text = "";

            if (label2 != null)
                label2.Dispose();

            label2 = new Label();
            label2.AutoSize = true;//nome
            label2.Font = new System.Drawing.Font("Arial", 13F);
            label2.ForeColor = System.Drawing.Color.Maroon;
            label2.Location = new System.Drawing.Point(175, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 21);
            label2.TabIndex = 15;
            label2.Text = "";

        }
        public void inicializarAvancar()
        {
            if (avancar != null)
                avancar.Dispose();
            avancar = new System.Windows.Forms.Button();
            avancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            avancar.BackgroundImage = global::Pizzaria.Properties.Resources.BTnewAvancar;
            avancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            avancar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            avancar.Location = new System.Drawing.Point(430, 75);
            avancar.Name = "avancar";
            avancar.Size = new System.Drawing.Size(80, 40);
            avancar.TabIndex = 2;
            this.ttEncerrar.SetToolTip(avancar, "Avancar");
            avancar.UseVisualStyleBackColor = true;
          //  avancar.Click += new System.EventHandler(this.btAvanco_click);

        }
        public void inicializarPainel(int parcial)
        {
            try
            {
                if (painel != null)
                    painel.Dispose();
                painel = new System.Windows.Forms.Panel();
                painel.SuspendLayout();

                painel.BackColor = System.Drawing.Color.White;
                painel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                // painel.Controls.Add(this.btSair);


                painel.Location = new System.Drawing.Point(448, 163);
                painel.Name = "painel";
                painel.Size = new System.Drawing.Size(566, 150);
                painel.TabIndex = 1;
                painel.Visible = true;
                painel.BringToFront();
                painel.Dock = System.Windows.Forms.DockStyle.None;
                tabLayDescricao.Visible = false;
                
                this.panBut  .Controls.Add(this.painel);

                // this.Controls.Add(this.tabLayPan);
                //  this.Controls.Add(this.statusStrip1);

                //  ja tenho o painel para fazer a logica
                /*
                    dentro do painel deve haver 
                    um botao para avancar, 
                 *  junto ao avançar eu preciso começar a definir a quandidade de cada item.
                 *  se é um item, eu passo direto, se for mais de um item
                 *  o usuario precisa escolher a quantidade q ele deseja inserir na SubVenda
                 * ///
                inicializarAvancar();
                inicializarQuantidade(parcial);
                inicializarDoisLabel();
                inicializarRecado();
                painel.Controls.Add(this.avancar);
                painel.Controls.Add(this.numQuantidade);
                painel.Controls.Add(this.label);
                painel.Controls.Add(this.label2);
                painel.Controls.Add(this.recado);
            }
            catch
            {
                painel = new System.Windows.Forms.Panel();
            }


        }
        */
        private void lvInfo_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem t = lvInfo.FocusedItem;
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
                     new BancoInformacao().addqtdGarconCompleto(g.getRetorno(),asd, 1);// cod_garcon cod_completo quantidade
                     if (cc.needImpress)
                     {
                         cc.garconImprimir = new BancoVenda().nomeGarcon( g.getRetorno());
                         cc.quantidade = 1;
                         cc.segmentoImprimir = new Banco().segmentoDoProduto(cc.produto[0].cod_produto);
                         Impressao p = new Impressao(venda);
                         p.gerarComandaInterna(new Completa[] { cc }, venda.mesa);
                     }
                }
                else
                    if (MessageBox.Show("Acrescentar Mais Um ?", "Confirme sua Opcao", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
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
                            p.gerarComandaInterna(new Completa[] { cc }, venda.mesa);
                        }
                    }

                venda = new BancoVenda().carregaVenda(venda.cod_venda);
                tamanhoMTVALOR(venda);
                carregarListView(venda);
                regularTamanho(lvInfo.Width);
            }
            catch { }
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
        private void btMesaTrocar_Click(object sender, EventArgs e)
        {
            if (new Banco().mesasDisponiveis().Length > 0)
            {
                //    this.Visible = false;
                new AlterarMesa( venda.cod_venda).ShowDialog();

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
  
        }

      
        //------------------------------------------------------------------------------------
    }

