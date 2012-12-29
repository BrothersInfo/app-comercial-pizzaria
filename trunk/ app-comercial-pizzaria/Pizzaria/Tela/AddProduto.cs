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
                int XquantidadeProduto = Convert.ToInt16(numQuantidade.Text);// quantidade do produto inserido
             
                Produto []produto = new Produto[conjuntoCodProduto.Length];
                double [] porcentagem = new Banco().valorPctByDescricao(cbMista.Text);
                for (int i = 0; i < conjuntoCodProduto.Length;i++ )
                {
                    produto[i] = new Produto();
                    
                    produto[i].setInfo(conjuntoCodProduto[i] ,porcentagem[i] ,valor*porcentagem[i]
                        ,cod_tamanho,new Banco().isImpressoProduto(conjuntoCodProduto[i]))  ; 
                }
                int cod_completo;
                if (!new Banco().existeProdutoNaVenda(cod_venda, produto, Xcod_garcon))
                {
                    cod_completo = new Banco().novoCompleto(produto, valor, XquantidadeProduto);
                    new Banco().makeVendaCompleto(cod_venda, cod_completo);
                    new Banco().GarconCompleto(Xcod_garcon, cod_completo, XquantidadeProduto);
                }
                else
                    cod_completo = new Banco().cod_completoByVendaProdutoValorTamanho(cod_venda,produto[0].cod_produto,cod_tamanho,valor);
                
                Completa cc = new BancoVenda().getCompleta(cod_completo);
                cc.quantidade = (int)numQuantidade.Value;
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
                if ((MessageBox.Show("Deseja acrescentar outro Produto? ", "INFORMAÇÃO", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    limpaCampoCodigoProduto();                    mtCodigo.Visible = true;                    mtCodigo.Focus();
                }
                else
                {
                    if (!(new Banco().isVendaBalcao(cod_venda)))
                    {
                        for (int j = 0; j < listaProd.Length; j++)
                            if (listaProd[j].Count > 0)
                                new Impressao(new BancoVenda().carregaVenda(cod_venda)).gerarComandaInterna(listaProd[j].ToArray()
                                    , conjGarc.ToArray(), mesas);
                    }
                    else
                    {
                        try
                        {
                            VendaFull f = (new BancoVenda().carregaVenda(cod_venda));
                            Encerrar rec = new Encerrar(f.cod_venda, f.valorTotal, f.mesa, true);
                            this.Visible = false;
                            rec.ShowDialog();
                            if (rec.encerrou)
                            {
                                for (int j = 0; j < listaProd.Length; j++)
                                    if (listaProd[j].Count > 0)
                                       new Impressao(new BancoVenda().carregaVenda(cod_venda)).gerarComandaInterna(listaProd[j].ToArray(), conjGarc.ToArray(), mesas);
                                MessageBox.Show("VENDA REALIZADA COM SUCESSO", "ATENDIMENDO BALCAO");
                              
                            }
                            else
                                new BancoVenda().anularVenda(cod_venda, true);
                           
                            this.Visible = true;

                        }    catch { }
                    } this.Close();
                }
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
            posicionamento();
            preencherTexto(new string[] { "BALCAO ", " ATENDIMENTO RAPIDO" });
            this.cod_venda = new Banco().novaVenda(cod_caixa, new int[] { new Banco().codBalcao() });
            pGarLivre.Visible = false; lbGarcon.Visible = false; cbGarVen.Visible = false;
            load(cod_venda);
            new BancoVenda().superVenda(this.cod_venda);//cria a super venda e associa a venda criada
            //garconDaVenda();
            mtCodigo_KeyPress(null, null);
        }
        public AddProduto(string[] mesasDaVenda, short cod_caixa)//Venda Sendo Aberta
        {
            InitializeComponent();
            posicionamento();
            inicializaLista();
            mesas = mesasDaVenda;
            this.cod_caixa = cod_caixa;
            this.cod_venda = new Banco().novaVenda(cod_caixa, new Banco().cod_mesa(mesas));//venda aberta
            new BancoVenda().superVenda(this.cod_venda);//cria a super venda e associa a venda criada
            preencherTexto(mesas);
            load(cod_venda);
            //mtCodigo.Focus();
            garconDaVenda();
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
            mtCodigo_KeyPress(null, null);
        }
        public void load(int cod_venda)
        {
            cbMista.Visible = false; lTamanho.Visible = false;
            cbTamanho.Visible = false; lbMista.Visible = false;
            numQuantidade.Visible = false;
            LQuantidade.Visible = false;
        }
        public bool podeCodigo(int cod_produto)
        {
            return new Banco().codigoAceito(cod_produto, Convert.ToInt16(mtCodigo.Text));
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
            double yy = (13.5 * valr) + 345;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);

            this.TopMost = true;
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
                        p.gerarComandaInterna(listaProd[j].ToArray(), conjGarc.ToArray(), mesas);
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
            if ((new Banco().isVendaBalcao(cod_venda)))
            {
                lbGarcon.Visible = false;
                cbGarVen.Visible = false;
                btGarc.Visible = false;
                pGarLivre.Visible = false;
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
            CodigoProduto tc = new CodigoProduto();
            tc.ShowDialog();
            mtCodigo.Text = tc.getCodigoProduto();
            KeyPressEventArgs x = new KeyPressEventArgs('\r');
            mtCodigo_KeyPress(sender, x);
        }
        private void btConsulta2_Click(object sender, EventArgs e)
        {
            CodigoProduto tc = new CodigoProduto();
            tc.ShowDialog();
            mtCodigo1.Text = tc.getCodigoProduto();
            KeyPressEventArgs x = new KeyPressEventArgs('\r');
            mtCodigo1_KeyPress(sender, x);
        }
        private void btConsulta3_Click(object sender, EventArgs e)
        {
            CodigoProduto tc = new CodigoProduto();
            tc.ShowDialog();
            mtCodigo2.Text = tc.getCodigoProduto();
            KeyPressEventArgs x = new KeyPressEventArgs('\r');
            mtCodigo2_KeyPress(sender, x);
        }
        private void btConsulta4_Click(object sender, EventArgs e)
        {
            CodigoProduto tc = new CodigoProduto();
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

            mtValor.Text = new Tratamento().retornaValorEscrito(t);
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
                    if (podeCodigo(Convert.ToInt16(texto1.Text)))
                    {
                        if (texto2.Visible)
                        {
                            if (podeCodigo(Convert.ToInt16(texto2.Text)))
                            {
                                preencherLabelDescritivo(new Banco().codTamanho(cbTamanho.Text)
                                            , new Banco().codDivisorByDescricao(cbMista.Text));
                                numQuantidade.Focus();
                            }
                            else                                texto2.Clear(); texto2.Focus();
                            
                        }
                        else
                        {
                            preencherLabelDescritivo(new Banco().codTamanho(cbTamanho.Text)
                                            , new Banco().codDivisorByDescricao(cbMista.Text));
                            numQuantidade.Focus();
                        }
                    }
                    else                        texto1.Clear(); texto1.Focus();
                }
                else
                {
                    preencherLabelDescritivo(new Banco().codTamanho(cbTamanho.Text)
                                            , new Banco().codDivisorByDescricao(cbMista.Text));
                    numQuantidade.Focus();
                }
            }
            else                usado.Clear(); usado.Focus();
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
                        mascaraValor(valor1 + valor2);

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
                        mascaraValor(valor1 + valor2 + valor3);
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

                        mascaraValor(valor1 + valor2 + valor3 + valor4);
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
                        cbTamanho.SelectedIndex = 0;
                        lTamanho.Visible = true;
                        cbTamanho.Visible = true;
                        cbTamanho_SelectedIndexChanged(sender, null);
                        if (mtCodigo1.Visible)
                            mtCodigo1.Focus();
                        else cbTamanho.Focus();
                        LQuantidade.Visible = true;
                        numQuantidade.Visible = true;
                    }
                    else
                    {
                        LQuantidade.Visible = false;
                        numQuantidade.Visible = false;
                        mtCodigo.Clear(); mtCodigo.Focus();
                    }
                }
            }
            catch   {      return;  }
        }
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
                if (cbMista.Visible)
                    cbMista.Focus();
                else numQuantidade.Focus();
            }
        }
        private void cbTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codTamanho = new Banco().codTamanho(cbTamanho.Text);

            cbMista.DataSource = new Banco().divisorByTamanho(codTamanho);
            cbMista.DisplayMember = "descricao";
            cbMista.SelectedIndex = 0;

            preencherLabelDescritivo(codTamanho, new Banco().codDivisorByDescricao(cbMista.Text));

            lbMista.Visible = true;
            cbMista.Visible = true;
            panelValor.Visible = true;
        }
        private void cbMista_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (mtCodigo1.Visible)
                        mtCodigo1.Focus();
                    else numQuantidade.Focus();
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
    //700 linhas
    }
}
