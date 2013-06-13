using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pizzaria.Tela
{

    using Pizzaria.Banco;
    using Pizzaria.Properties;
    using Pizzaria.Classes;
    public partial class AddProduto : Form
    {
        public int qtdProdutos() {

            if (!mtCodigo1.Visible)
                return 1;
            else if (!mtCodigo2.Visible)
                return 2;
            else if (!mtCodigo3.Visible)
                return 3;
            else 
                return 4;
        
        }

       public int[] preencherCodigosProduto(int [] vetor)
       {
           vetor[0] = Convert.ToInt16(mtCodigo.Text);
           if(mtCodigo1.Visible )
               vetor[1] = Convert.ToInt16(mtCodigo1.Text);
           if (mtCodigo2.Visible)
               vetor[2] = Convert.ToInt16(mtCodigo2.Text);
           if (mtCodigo3.Visible)
               vetor[3] = Convert.ToInt16(mtCodigo3.Text);

           return vetor;
       }
       public bool codigosAceitos(int [] vetor)
       {
           for (int i = 0; i < vetor.Length; i++)
               if (!new Banco().codigoAceito(vetor[0], Convert.ToInt16(mtCodigo.Text)))
                   return false;
               return true;
       }
        private void btEscolhaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int cod_tamanho = new Banco().cod_tamanhoDoEscolhido(Convert.ToInt16(mtCodigo.Text), cbTamanho.Text);//cod_tamanho
                int [] conjuntoCodProduto = new int[qtdProdutos()];//codigos dos produtos
                conjuntoCodProduto = preencherCodigosProduto(conjuntoCodProduto);
                if(!codigosAceitos(conjuntoCodProduto))
                    return;
                //garantido que os codigos são aceitos
                double valor = Convert.ToDouble(mtValor.Text);//valor de entrada do produto

                try
                {
                    if (mesas.Equals(null)) { }
                }
                catch
                {
                    mesas = new string[1];
                    mesas[0] = new Banco().trazerNomeMesa(cod_venda);
                }//mesas
                int Xcod_garcon;
                if (new Banco().isVendaBalcao(cod_venda))                    Xcod_garcon = new Banco().cod_garconBalcao();
                else                     Xcod_garcon = new Banco().codGarconByNome(getGarcon());
                //garcons preenchidos
                double XquantidadeProduto = Convert.ToDouble( tbQuantidade.Text.Replace('.',',') );// quantidade do produto inserido
             
                Produto []produto = new Produto[conjuntoCodProduto.Length];
                double [] porcentagem = new Banco().valorPctByDescricao(cbMista.Text);
                for (int i = 0; i < conjuntoCodProduto.Length;i++ )
                {
                    produto[i] = new Produto();
                    
                    produto[i].setLoad(conjuntoCodProduto[i] ,porcentagem[i] ,valor
                        ,cod_tamanho,new Banco().isImpressoProduto(conjuntoCodProduto[i]))  ; 
                }
                int cod_completo = 1;

                if ((produto.Length==1) && (new BancoInformacao().existeProdutoNaVenda(cod_venda,produto[0].cod_produto,cod_tamanho,valor)))
                {
                    cod_completo = new BancoInformacao().codCompletoExistente(cod_venda, produto[0].cod_produto, cod_tamanho, valor);
                    new BancoInformacao().addqtdGarconCompleto(Xcod_garcon, cod_completo, XquantidadeProduto);
                }
                else {
                cod_completo =    new BancoInformacao().criarCompleto(cod_venda, Xcod_garcon, valor
                            , XquantidadeProduto, produto[0].impresso, false, produto);
                    //aqui ele deve criar um novo produto
                }
                
                Completa cc = new BancoVenda().getCompleta(cod_completo, false);
                cc.quantidade = XquantidadeProduto;
                cc.garconImprimir = getGarcon();
                new Banco().inserePrecoCompraEmCompleto(cod_completo, new Banco().valorCompraDoProduto(cc.produto[0].cod_produto, cc.produto[0].cod_tamanho));
                cc.segmentoImprimir = new Banco().segmentoDoProduto(Convert.ToInt16( mtCodigo.Text));
                if (tbNoticia.TextLength > 0) cc.setNoticia(tbNoticia.Text);
                if (cc.needImpress)
                {
                    listaProd[new BancoVenda().codSegmentoByProduto(cc.produto[0].cod_produto) - 1].Add(cc);
                    bool can = true;
                    for (int y = 0; y < conjGarc.ToArray().Length && can; y++)
                        if (conjGarc.ToArray()[y] == getGarcon())
                            can = !can;
                    if (can)
                        conjGarc.Add(getGarcon());
                }


               // if(MessageBox.Show("DESEJA ACRESCENTAR OUTRO ITEM","INFORMAÇÂO",
               //     MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1
               //     ,MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            //    if (MessageBox.Show("ACRESCENTAR OUTRO ITEM??", "CONFIRME SUA OPCAO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                MessageBox.Show("PRODUTO INSERIDO", "CONFIRMAÇÃO", MessageBoxButtons.OK,MessageBoxIcon.Information);
                {
                    limpaCampoCodigoProduto(); this.Focus(); mtCodigo.Visible = true; mtCodigo.Focus();
                    tbQuantidade.Text = 1.ToString("0.00");
                    this.mtCodigo_KeyPress(sender,new KeyPressEventArgs ('\r'));
                }
            
                    if (!(new Banco().isVendaBalcao(cod_venda)))
                    {
                        for (int j = 0; j < listaProd.Length; j++)
                            if (listaProd[j].Count > 0)
                            {
                                new Impressao(new BancoVenda().carregaVenda(cod_venda)).gerarComandaCozinha(listaProd[j].ToArray(), mesas, false);
                             //   new Impressao(true, new BancoVenda().carregaVenda(cod_venda)).novoMetodo(listaProd[j].ToArray(), mesas);
                            }
                    }
                    else
                    {
                        try
                        {
                            VendaFull f = (new BancoVenda().carregaVenda(cod_venda));
                            Pagamento rec = new Pagamento(f.cod_venda,f.subValor,f.valorComissao, f.valorSomado, f.mesa, true);
                            this.Visible = false;
                            rec.ShowDialog();
                            if (rec.encerrou)
                            {
                                for (int j = 0; j < listaProd.Length; j++)
                                    if (listaProd[j].Count > 0)
                                    { 
                                       // new Impressao(new BancoVenda().carregaVenda(cod_venda)).gerarComandaInterna(listaProd[j].ToArray(), mesas);
                                        new Impressao(true,new BancoVenda().carregaVenda(cod_venda)).novoMetodo(listaProd[j].ToArray(), mesas); 
                                    }

                                MessageBox.Show("VENDA REALIZADA COM SUCESSO", "ATENDIMENDO BALCAO");
                              
                            }
                            else
                                new BancoVenda().anularVenda(cod_venda, true);
                           
                            this.Visible = true;

                        }    catch { }
                    } this.Close();
               
            }
            catch { };
        }        
        //------------------------------------------------NOVA CLASSE
        int cod_venda;
   
        string[] mesas;
        short cod_caixa;

        List<string> conjGarc = new List<string>();
        List<Completa>[] listaProd;//= new List<Completa>();
        public AddProduto(bool isBalcao, int cod_caixa)
        {
            InitializeComponent();
            inicializaLista();
          //  posicionamento();
            preencherTexto(new string[] { "BALCAO ", " ATENDIMENTO RAPIDO" });
            this.cod_venda = new Banco().novaVenda(cod_caixa, new int[] { new Banco().codBalcao() });
            pGarLivre.Visible = false; lbGarcon.Visible = false; cbGarVen.Visible = false;
            load(cod_venda);
            new BancoVenda().superVenda(this.cod_venda);//cria a super venda e associa a venda criada
            //garconDaVenda();
            //TopMost = true;
            mtCodigo_KeyPress(null, null);
        }
        public AddProduto(string[] mesasDaVenda, short cod_caixa)//Venda Sendo Aberta
        {
            InitializeComponent();
        //    posicionamento();
            inicializaLista();
            mesas = mesasDaVenda;
            this.cod_caixa = cod_caixa;
            this.cod_venda = new Banco().novaVenda(cod_caixa, new Banco().cod_mesa(mesas));//venda aberta
            new BancoVenda().superVenda(this.cod_venda);//cria a super venda e associa a venda criada
            preencherTexto(mesas);
            load(cod_venda);
            //mtCodigo.Focus();
            garconDaVenda();
         //   TopMost = true;

            mtCodigo_KeyPress(null, null);
          

        }
        public AddProduto(int cod_venda)
        {
            InitializeComponent();
            inicializaLista();
            posicionamento();
            this.cod_venda = cod_venda;
            load(cod_venda);
            garconDaVenda();
            preencherTexto(new BancoVenda().mesasDaVenda(cod_venda));
            // TopMost = true;
            mtCodigo_KeyPress(null, null);
        }
        public void load(int cod_venda)
        {
            cbMista.Visible = false; lTamanho.Visible = false;
            cbTamanho.Visible = false; lbMista.Visible = false;
            gbQtd.Visible = false;
           
        }
        public bool podeCodigo(int cod_produto)
        {
            try
            {
                return new Banco().codigoAceito(cod_produto, Convert.ToInt16(mtCodigo.Text));
            }
            catch { return false; }
        }
        public void inicializaLista()
        {
            listaProd = new List<Completa>[new BancoVenda().qtdSegmentos()];
            for (int i = 0; i < listaProd.Length; i++)
                listaProd[i] = new List<Completa>();
        }
        public void posicionamento()
        {
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr) + 200;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);

          // this.TopMost = true;
        }
        private void btGarc_Click(object sender, EventArgs e)
        {
            if (pGarLivre.Visible)
                garconDaVenda();
            else garconNaoDaVenda();
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            if (new Banco().isVendaBalcao(cod_venda))
                new BancoVenda().anularVenda(cod_venda, true);
            else
            {
                for (int j = 0; j < listaProd.Length; j++)
                {
                    if (listaProd[j].Count > 0)
                    {
                        Impressao p = new Impressao(new BancoVenda().carregaVenda(cod_venda));
                        p.gerarComandaCozinha(listaProd[j].ToArray(), mesas, false);
                    }
                }
            }

            this.Close();

        }
        public void garconDaVenda()
        {
            Banco bg = new Banco();
            if (bg.temGarconIn(cod_venda))
            {
                lbGarcon.Visible = true;
                cbGarVen.Visible = true;
                pGarLivre.Visible = false;
                cbGarVen.DataSource = bg.GarconDaVenda(cod_venda);
                cbGarVen.DisplayMember = "nome";
                cbGarVen.SelectedIndex = 0;
                btGarc.Visible = true;
            }
            else
            {
                btGarc.Visible = false;
                garconNaoDaVenda();
            }
        }
        public void garconNaoDaVenda()
        {
            Banco bg = new Banco();
            cbGarLivre.DataSource = bg.GarconNaoUsadoPelaVenda(cod_venda);
            cbGarLivre.DisplayMember = "nome";
            cbGarLivre.SelectedIndex = 0;
            {
                lbGarcon.Visible = false;
                cbGarVen.Visible = false;
                pGarLivre.Visible = true;
            }
        }
        public string getGarcon()
        {
            if (pGarLivre.Visible) return cbGarLivre.Text;
            else return cbGarVen.Text;
        }
        public void limpaCampoCodigoProduto()
        {
            mtValor.Clear();
            mtCodigo1.Clear();
            mtCodigo2.Clear();
            mtCodigo3.Clear();
            mtCodigo.Clear();
            lbPct1.Visible = false;
            lbPct2.Visible = false;
            lbPct3.Visible = false;
            lbPct4.Visible = false;
            mtCodigo1.Visible = false;
            mtCodigo2.Visible = false;
            mtCodigo3.Visible = false;
            btConsulta2.Visible = false;
            btConsulta3.Visible = false;
            btConsulta4.Visible = false;
            lbNomePizza1.Visible = false;
            lbNomePizza2.Visible = false;
            lbNomePizza3.Visible = false;
            lbNomePizza4.Visible = false;
            lbNomePizza2.Text = "";
            lbNomePizza3.Text = "";
            lbNomePizza4.Text = "";
            tbNoticia.Clear();
            if ((new Banco().isVendaBalcao(cod_venda)))
            {
                lbGarcon.Visible = false;
                cbGarVen.Visible = false;
                btGarc.Visible = false;
                pGarLivre.Visible = false;
            }
            else
            {
                lbGarcon.Visible = false;
                cbGarVen.Visible = false;
                btGarc.Visible = false;
                pGarLivre.Visible = false;
                cbMista.Visible = false;
                cbTamanho.Visible = false;
                lTamanho.Visible = false;
                gbQtd.Visible = false;
                lbMista.Visible = false;
                
                mtValor.Visible = false; lbRS.Visible = false;
                mtCodigo.Focus();
                
            }
        }
        private void numQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pGarLivre.Visible)
                cbGarLivre.Focus();
            else
                cbGarVen.Focus();
        }
        private void btConsulta1_Click(object sender, EventArgs e)
        {
            Codes tc = new Codes();
            tc.ShowDialog();
            mtCodigo.Text = tc.getCodigoProduto();
            KeyPressEventArgs x = new KeyPressEventArgs('\r');
            mtCodigo_KeyPress(sender, x);
        }
        private void btConsulta2_Click(object sender, EventArgs e)
        {
            Codes tc = new Codes(new BancoVenda().codSegmentoByProduto(Convert.ToInt16(mtCodigo.Text)));
            tc.ShowDialog();
            mtCodigo1.Text = tc.getCodigoProduto();
            KeyPressEventArgs x = new KeyPressEventArgs('\r');
            mtCodigo1_KeyPress(sender, x);
        }
        private void btConsulta3_Click(object sender, EventArgs e)
        {
            Codes tc = new Codes(new BancoVenda().codSegmentoByProduto(Convert.ToInt16(mtCodigo.Text)));
            tc.ShowDialog();
            mtCodigo2.Text = tc.getCodigoProduto();
            KeyPressEventArgs x = new KeyPressEventArgs('\r');
            mtCodigo2_KeyPress(sender, x);
        }
        private void btConsulta4_Click(object sender, EventArgs e)
        {
            Codes tc = new Codes(new BancoVenda().codSegmentoByProduto(Convert.ToInt16(mtCodigo.Text)));
            tc.ShowDialog();
            mtCodigo3.Text = tc.getCodigoProduto();
            KeyPressEventArgs x = new KeyPressEventArgs('\r');
            mtCodigo3_KeyPress(sender, x);
        }
        private void mtCodigo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (podeCodigo(Convert.ToInt16(mtCodigo3.Text)))
                    {
                        lbNomePizza4.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo3.Text));
                        lbNomePizza4.Visible = true;
                        continuidade(mtCodigo3,mtCodigo1,mtCodigo2);
                    }
                    else  {mtCodigo3.Clear(); mtCodigo3.Focus();   }
                }
            }
            catch { return; }
        }
        public void mascaraValor(double t)
        {
            
            if ((t < 100 && t >= 10) || t == 0) mtValor.Mask = "00.00";
            else
                if (t < 10) mtValor.Mask = "0.00";

                else if (t >= 100) mtValor.Mask = "000.00";
            mtValor.Text = t.ToString("0.00");
            mtValor.Visible = true;
        }
        private void mtCodigo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (podeCodigo(Convert.ToInt16(mtCodigo2.Text)))
                    {
                        lbNomePizza3.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo2.Text));
                        lbNomePizza3.Visible = true;
                        continuidade(mtCodigo2,mtCodigo1,mtCodigo3);
                    }
                    else  { mtCodigo2.Clear(); mtCodigo2.Focus();  }
                }
            }    catch   {     return; }
        }

        public void continuidade(MaskedTextBox usado, MaskedTextBox texto1, MaskedTextBox texto2)
        {
            if (podeCodigo(Convert.ToInt16(usado.Text)))
            {
                if (texto1.Visible)
                {
                    if (texto1.Text.Length>0 &&  podeCodigo(Convert.ToInt16(texto1.Text)))
                    {
                        if (texto2.Visible)
                        {
                            if (texto2.Text.Length > 0 && podeCodigo(Convert.ToInt16(texto2.Text)))
                            {
                                preencherLabelDescritivo(new Banco().codTamanho(cbTamanho.Text)
                                            , new Banco().codDivisorByDescricao(cbMista.Text));
                                gbQtd.Visible = true;

                                gbQtd.Focus();
                            }
                            else { texto2.Clear(); texto2.Focus(); }

                        }
                        else
                        {
                            preencherLabelDescritivo(new Banco().codTamanho(cbTamanho.Text)
                                            , new Banco().codDivisorByDescricao(cbMista.Text));
                              gbQtd.Visible = true;

                              gbQtd.Focus(); 
                        }
                    }
                    else { texto1.Clear(); texto1.Focus(); }
                }
                else
                {
                    preencherLabelDescritivo(new Banco().codTamanho(cbTamanho.Text)
                                            , new Banco().codDivisorByDescricao(cbMista.Text));
                    gbQtd.Visible = true;

                    gbQtd.Focus(); 
                }
            }
            else { usado.Clear(); usado.Focus(); }
        }
        private void mtCodigo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (podeCodigo(Convert.ToInt16(mtCodigo1.Text)))
                    {
                        lbNomePizza2.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo1.Text));
                        lbNomePizza2.Visible = true;
                        continuidade(mtCodigo1, mtCodigo2, mtCodigo3);
                    }
                    else{  mtCodigo1.Clear(); mtCodigo1.Focus();      }
                }
            }catch { return; }
        }
        
        public void preencherLabelDescritivo(int cod_tamanho, int cod_divisor)
        {
            string[] lbs = new Banco().subDivisorByTamanhoDivisor(cod_tamanho, cod_divisor);
            switch (lbs.Length)
            {
                case 1:
                    {
                        lbPct1.Text = lbs[0];
                        lbPct1.Visible = true;
                        lbPct2.Visible = false;
                        lbPct3.Visible = false;
                        lbPct4.Visible = false;
                        double t = new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho);
                        mtCodigo1.Visible = false;
                        mtCodigo2.Visible = false;
                        mtCodigo3.Visible = false;
                        btConsulta2.Visible = false;
                        btConsulta3.Visible = false;
                        btConsulta4.Visible = false;
                        lbNomePizza1.Visible = true;
                        lbNomePizza2.Visible = false;
                        lbNomePizza3.Visible = false;
                        lbNomePizza4.Visible = false;
                        lbNomePizza2.Text = "";
                        lbNomePizza3.Text = "";
                        lbNomePizza4.Text = "";

                        mtCodigo1.Clear();
                        mtCodigo2.Clear();
                        mtCodigo3.Clear();
                        mascaraValor(t);

                        break;
                    }
                case 2:
                    {
                        lbPct1.Text = lbs[0];
                        lbPct2.Text = lbs[1];
                        lbPct1.Visible = true;
                        lbPct2.Visible = true;
                        lbPct3.Visible = false;
                        lbPct4.Visible = false;
                        mtCodigo1.Visible = true;
                        mtCodigo2.Visible = false;
                        mtCodigo3.Visible = false;
                        btConsulta2.Visible = true;
                        btConsulta3.Visible = false;
                        btConsulta4.Visible = false;
                        lbNomePizza1.Visible = true;
                        lbNomePizza2.Visible = true;
                        lbNomePizza3.Visible = false;
                        lbNomePizza4.Visible = false;
                        double valor1 = new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho) *
                            new Banco().numeroPercentualSubDivisor(lbs[0]);
                        double valor2 = new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cod_tamanho) *
                             new Banco().numeroPercentualSubDivisor(lbs[1]);
                        mtCodigo2.Clear();
                        mtCodigo3.Clear();
                        if (!new Banco().formaDePrecoConjunto())
                            mascaraValor(valor1 + valor2);
                        else
                        {
                            if (valor1 >= valor2)
                                mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho));
                            else mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cod_tamanho));
                        }
                        lbNomePizza3.Text = "";
                        lbNomePizza4.Text = "";
                        break;
                    }
                case 3:
                    {
                        lbPct1.Text = lbs[0];
                        lbPct2.Text = lbs[1];
                        lbPct3.Text = lbs[2];
                        lbPct1.Visible = true;
                        lbPct2.Visible = true;
                        lbPct3.Visible = true;
                        lbPct4.Visible = false;
                        mtCodigo1.Visible = true;
                        mtCodigo2.Visible = true;
                        mtCodigo3.Visible = false;
                        btConsulta2.Visible = true;
                        btConsulta3.Visible = true;
                        btConsulta4.Visible = false;
                        lbNomePizza1.Visible = true;
                        lbNomePizza2.Visible = true;
                        lbNomePizza3.Visible = true;
                        lbNomePizza4.Visible = false;
                        double valor1 = new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho) *
                            new Banco().numeroPercentualSubDivisor(lbs[0]);
                        double valor2 = new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cod_tamanho) *
                            new Banco().numeroPercentualSubDivisor(lbs[1]);
                        double valor3 = new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cod_tamanho) *
                            new Banco().numeroPercentualSubDivisor(lbs[2]);

                        lbNomePizza4.Text = "";
                        mtCodigo3.Clear();
                   if (!new Banco().formaDePrecoConjunto())
                            mascaraValor(valor1 + valor2 + valor3);
                        else
                        {
                         if(new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho) >=
                             new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cod_tamanho))
                         {
                            if(new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho)>=
                                new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cod_tamanho))
                                 mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho));
                            else
                                mascaraValor( new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cod_tamanho));
                         }
                         else
                         {
                            if(new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cod_tamanho)>=
                                new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cod_tamanho))
                                mascaraValor( new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cod_tamanho));
                            else
                                mascaraValor( new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cod_tamanho));
                         }
                        }     
                        break;
                    }
                case 4:
                    {
                        lbPct1.Text = lbs[0];
                        lbPct2.Text = lbs[1];
                        lbPct3.Text = lbs[2];
                        lbPct4.Text = lbs[3];
                        lbPct1.Visible = true;
                        lbPct2.Visible = true;
                        lbPct3.Visible = true;
                        lbPct4.Visible = true;
                        mtCodigo1.Visible = true;
                        mtCodigo2.Visible = true;
                        mtCodigo3.Visible = true;
                        btConsulta2.Visible = true;
                        btConsulta3.Visible = true;
                        btConsulta4.Visible = true;
                        lbNomePizza1.Visible = true;
                        lbNomePizza2.Visible = true;
                        lbNomePizza3.Visible = true;
                        lbNomePizza4.Visible = true;
                        double teste1 = new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho);
                        double teste2 = new Banco().numeroPercentualSubDivisor(lbs[0]);
                        double valor1 = new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho) *
                                new Banco().numeroPercentualSubDivisor(lbs[0]);
                        double valor2 = new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cod_tamanho) *
                            new Banco().numeroPercentualSubDivisor(lbs[1]);
                        double valor3 = new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cod_tamanho) *
                            new Banco().numeroPercentualSubDivisor(lbs[2]);
                        double valor4 = new Banco().valorProduto(Convert.ToInt16(mtCodigo3.Text), cod_tamanho) *
                            new Banco().numeroPercentualSubDivisor(lbs[3]);
                        if (!new Banco().formaDePrecoConjunto())
                        mascaraValor(valor1 + valor2 + valor3 + valor4);
                        else{
                            if(valor1 >= valor2)
                            {
                                if(valor1 >= valor3)
                                {
                                    if(valor1 >= valor4)
                                         mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cod_tamanho));
                                    else
                                         mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo3.Text), cod_tamanho));
                                }
                                else
                                {
                                    if(valor3 >= valor4)
                                         mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cod_tamanho));
                                    else
                                         mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo3.Text), cod_tamanho));
                                }
                            }
                            else
                            {
                                if(valor2 >= valor3)
                                {
                                    if(valor2 >= valor4)
                                         mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cod_tamanho));
                                    else
                                         mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo3.Text), cod_tamanho));
                                }
                                else
                                {
                                    if(valor3 >= valor4)
                                         mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cod_tamanho));
                                    else
                                         mascaraValor(new Banco().valorProduto(Convert.ToInt16(mtCodigo3.Text), cod_tamanho));
                                }
                            }

                        
                        }
                        break;
                    }
            }
        }
        private void mtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           try
           {
                if (e.KeyChar == '\r')
                {
                    if (podeCodigo(Convert.ToInt16(mtCodigo.Text)))
                    {
                        lbNomePizza1.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo.Text));
                        lbNomePizza1.Visible = true;
                        cbTamanho.DataSource = new Banco().tamanhoProduto(Convert.ToInt16(mtCodigo.Text));
                        cbTamanho.DisplayMember = "descricao";
                       // cbTamanho.SelectedIndex = 0;
                     //   if (cbTamanho.Items.Count < 4) cbTamanho.Visible = false;
                      //  else cbTamanho.Visible = true;
                       // lTamanho.Visible = true;
                      //  cbTamanho.Visible = true; 
                        if (cbTamanho.Items.Count > 1) { cbTamanho.Visible = true; lTamanho.Visible = true; }
                        else { cbTamanho.Visible = false; lTamanho.Visible = false; }
                        mtValor.Visible = true; lbRS.Visible = true;
                      //  cbTamanho_SelectedIndexChanged(sender, null);
                        if (mtCodigo1.Visible)
                            mtCodigo1.Focus();
                        else
                        {
                            if (cbTamanho.Items.Count > 1)
                                cbTamanho.Focus();
                            else
                            {
                                if (pGarLivre.Visible)
                                    cbGarLivre.Focus();
                                else
                                {
                                    btEscolhaProduto.Focus();
                                }
                            }
                        }
                        gbQtd.Visible = true; tbQuantidade.Text = 1.ToString("0.00"); if (!new Banco().isVendaBalcao(cod_venda)) garconDaVenda();
                    }
                    else
                    {

                        gbQtd.Visible = false;
                        mtCodigo.Clear(); mtCodigo.Focus();
                    }
                }
            }
       
           
           catch   {      return;  }
        }//
        public void preencherTexto(string[] textoTitulo)
        {
            string texto = "";
            for (int i = 0; i < textoTitulo.Length && i < 10; i++)
            {
                texto += textoTitulo[i] + " | ";
            }
            lbMesa.Text = texto.Substring(0, texto.Length - 3);
        }
        private void AddProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    btBack_Click(sender, null);
                    break;
                case Keys.F1:
                    btConsulta1_Click(sender, null);
                    break;
                case Keys.F2:
                    if(btConsulta2.Visible)
                    btConsulta2_Click(sender, null);
                    break;
                case Keys.F3:
                    if (btConsulta3.Visible)
                    btConsulta3_Click(sender, null);
                    break;
                case Keys.F4:
                    if (btConsulta4.Visible)
                    btConsulta4_Click(sender, null);
                    break;
            }
        }
        private void cbMista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codTamanho = new Banco().codTamanho(cbTamanho.Text);
            try
            {
                preencherLabelDescritivo(codTamanho, new Banco().codDivisorByDescricao(cbMista.Text));
            }
            catch { return; }
        }
        private void mtCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            /* {
                 if (e.Button == MouseButtons.Left)
                 {
                     Teclado t =
                     new Teclado();
                     t.ShowDialog();
                     if (t.retorno != "") mtCodigo.Text = t.retorno;
                     mtCodigo_KeyPress(sender, new KeyPressEventArgs('\r'));
                 }
             }//*/
        }
        private void cbTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (cbMista.Items.Count > 1)
                    cbMista.Focus();
                else
                {
                    gbQtd.Visible = true;

                    gbQtd.Focus();
                }
            }
        }
        private void cbTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codTamanho = new Banco().codTamanho(cbTamanho.Text);

            cbMista.DataSource = new Banco().divisorByTamanho(codTamanho);
            cbMista.DisplayMember = "descricao";
            cbMista.SelectedIndex = 0;

            if (cbTamanho.Items.Count >= 2) { cbTamanho.Visible = true; lTamanho.Visible = true; }
            else { cbTamanho.Visible = false; lTamanho.Visible = false; }
            preencherLabelDescritivo(codTamanho, new Banco().codDivisorByDescricao(cbMista.Text));

            if (cbMista.Items.Count >=2) { cbMista.Visible = true; lbMista.Visible = true; }
            else { cbMista.Visible = false; lbMista.Visible = false; }
            //lbMista.Visible = true;
            //cbMista.Visible = true;
            panelValor.Visible = true;
      }
        private void cbMista_KeyPss(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (mtCodigo1.Visible)
                        mtCodigo1.Focus();
                   else
                {
                    gbQtd.Visible = true;

                    gbQtd.Focus();
                }
                }
            }
            catch { }
        }
        private void cbGarVen_KeyPress(object sender, KeyPressEventArgs e)
        {
            btEscolhaProduto.Focus();
        }
        private void cbGarLivre_KeyPress(object sender, KeyPressEventArgs e)
        {
            btEscolhaProduto.Focus();
        }
        private void cbMista_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (mtCodigo1.Visible)
                        mtCodigo1.Focus();
                 else
                {
                    gbQtd.Visible = true;

                    gbQtd.Focus();
                }
                }
            }
            catch { }
        }
        private void cbTamanho_Leave(object sender, EventArgs e)
        {
            cbTamanho.ForeColor = Color.Black;
            lTamanho.ForeColor = Color.Black;
            cbTamanho.BackColor = Color.WhiteSmoke;
        }
        private void cbMista_Leave(object sender, EventArgs e)
        {
            cbMista.ForeColor = Color.Black;
            lbMista.ForeColor = Color.Black;
            cbMista.BackColor = Color.WhiteSmoke;
        }

        private void modoNormal(Label pct , MaskedTextBox mtb)
        {

            pct.ForeColor = Color.Black;
            mtb.ForeColor = Color.Black;
        }
        private void modoSelecao(Label pct, MaskedTextBox mtb)
        {

            pct.ForeColor = Color.Red;
            mtb.ForeColor = Color.Red;
        }

        private void mtCodigo_Enter(object sender, EventArgs e)
        {
            mtCodigo.Focus();
            modoSelecao(lbPct1,mtCodigo);
        }
        private void mtCodigo_Leave(object sender, EventArgs e)
        {
            modoNormal(lbPct1, mtCodigo);
        }
        private void mtCodigo1_Enter(object sender, EventArgs e)
        {
            modoSelecao(lbPct2, mtCodigo1);
        }
        private void mtCodigo1_Leave(object sender, EventArgs e)
        {
            modoNormal(lbPct2, mtCodigo1);
        }
        private void mtCodigo2_Enter(object sender, EventArgs e)
        {
            modoSelecao(lbPct3, mtCodigo2);
        }
        private void mtCodigo2_Leave(object sender, EventArgs e)
        {
            modoNormal(lbPct3, mtCodigo2);
        }
        private void mtCodigo3_Enter(object sender, EventArgs e)
        {
            modoSelecao(lbPct4, mtCodigo3);
        }
        private void mtCodigo3_Leave(object sender, EventArgs e)
        {
            modoNormal(lbPct4, mtCodigo3);
        }
        private void tbNoticia_Enter(object sender, EventArgs e)
        {
            tbNoticia.ForeColor = Color.Red;
        }
        private void tbNoticia_Leave(object sender, EventArgs e)
        {
            tbNoticia.ForeColor = Color.Black;
        }

        private void cbTamanho_Enter(object sender, EventArgs e)
        {
            cbTamanho.ForeColor = Color.Red;
            lTamanho.ForeColor = Color.Red;
            cbTamanho.BackColor = Color.LightGreen;
          //  if (cbTamanho.Items.Count > 2) { cbTamanho.Visible = true; lTamanho.Visible = true; }
           // else  
            cbTamanho.ForeColor = Color.Black;
            lTamanho.ForeColor = Color.Black;
            cbTamanho.BackColor = Color.WhiteSmoke;
        }
        private void cbMista_Enter(object sender, EventArgs e)
        {
            cbMista.ForeColor = Color.Red;
            lbMista.ForeColor = Color.Red;
            cbMista.BackColor = Color.LightGreen;

      //      if (cbMista.Items.Count > 2) { cbMista.Visible = true; lbMista.Visible = true; }
      //      else { cbMista.Visible = false; cbMista.Visible =true; }
            cbMista.ForeColor = Color.Black;
            lbMista.ForeColor = Color.Black;
            cbMista.BackColor = Color.WhiteSmoke;
        }
        private void cbGarLivre_Enter(object sender, EventArgs e)
        {
            cbGarLivre.ForeColor = Color.Red;
            lGarLivre.ForeColor = Color.Red;
            cbGarLivre.BackColor = Color.LightGreen;
        }
        private void cbGarLivre_Leave(object sender, EventArgs e)
        {
            cbGarLivre.ForeColor = Color.Black;
            lGarLivre.ForeColor = Color.Black;
            cbGarLivre.BackColor = Color.WhiteSmoke;
        }
        private void cbGarVen_Leave(object sender, EventArgs e)
        {
            cbGarVen.ForeColor = Color.Black;
            lbGarcon.ForeColor = Color.Black;
            cbGarVen.BackColor = Color.WhiteSmoke;
        }
        private void cbGarVen_Enter(object sender, EventArgs e)
        {
            cbGarVen.ForeColor = Color.Red;
            lbGarcon.ForeColor = Color.Red;
            cbGarVen.BackColor = Color.LightGreen;   
        }

        private void numQuantidade_Enter(object sender, EventArgs e)
        {
         
            tbQuantidade.ForeColor = Color.Red;
        }

        private void numQuantidade_Leave(object sender, EventArgs e)
        {
            tbQuantidade.ForeColor = Color.Black;
        }

        private void AddProduto_Load(object sender, EventArgs e)
        {
            mtCodigo.Focus();
            this.ProcessTabKey(true);
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            if (double.Parse(tbQuantidade.Text)>1)
                tbQuantidade.Text = (double.Parse(tbQuantidade.Text) - 1).ToString("0.00") ;
        }

        private void btMais_Click(object sender, EventArgs e)
        {
            tbQuantidade.Text = (double.Parse(tbQuantidade.Text) + 1).ToString("0.00");
        }

        private void btBalanca_Click(object sender, EventArgs e)
        {
            try
            {
                string peso ="";
                string precoQuilo= "";
                string total ="";
               int ii =  Bemafi32.Bematech_FI_AbrePortaSerial();
               int k = Bemafi32.Bematech_FI_InfoBalanca("USB", 2, ref peso, ref precoQuilo,ref total);



                float ff = DllToledo.Get();
            }catch( Exception ee){
                MessageBox.Show(ee.Message);
            }
        }


    //700 linhas
    }
}
