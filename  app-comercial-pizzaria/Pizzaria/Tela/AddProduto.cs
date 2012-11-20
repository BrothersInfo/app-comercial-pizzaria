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
       
        Produto[] prod;
        string[] divisao1;
        string[] divisao2;
        int cod_venda;
        string texto = "";
        string[] mesas;
        short cod_caixa;

        public void preencherTexto(string [] t)
        {
            for (int i = 0; i < t.Length && i < 10; i++)
            {
                texto += t[i] + " | ";
            }
            lbMesa.Text = texto.Substring(0, texto.Length-3)  ;
        }
        
        public AddProduto( string [] t, short cod_caixa)//sempre vira como true
        {
            InitializeComponent();
            mesas = t;
            this.cod_caixa = cod_caixa;
            int[] x = new Banco().cod_mesa(t);
            this.cod_venda = new Banco().novaVenda(cod_caixa, x);
           
            divisao1 = new string[] { "INTEIRA", "50% | 50%", "50% | 2 x 25%", "4 x 25%" };
            divisao2 = new string[] { "INTEIRA", "50% | 50%" };
            
            
                   load(cod_venda);
        
            new BancoVenda().superVenda(this.cod_venda);//cria a super venda e associa a venda criada
            //mtCodigo.Focus();
            mtCodigo_KeyPress(null, null);
            preencherTexto(t);
            garconDaVenda();
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr) +345;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);

            this.TopMost = true;
        }
        public AddProduto(int cod_venda)
        {
            InitializeComponent();
            this.cod_venda = cod_venda;
            divisao1 = new string[] { "INTEIRA", "50% | 50%", "50% | 2 x 25%", "4 x 25%" };
            divisao2 = new string[] { "INTEIRA", "50% | 50%" };
            load(cod_venda);

            mtCodigo_KeyPress(null, null);
            preencherTexto( new BancoVenda().mesasDaVenda(cod_venda)  );
            garconDaVenda();
            double valr = Screen.PrimaryScreen.Bounds.Height/100f;
            double yy = (13.5 * valr) + 345;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
           this.TopMost = true;
            
            // Screen.PrimaryScreen
        }
        public void load(int cod_venda)
        {
            cbMista.Visible = false; lTamanho.Visible = false;
            cbTamanho.Visible = false; lbMista.Visible = false;
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
        private void btGarc_Click(object sender, EventArgs e)
        {
            if (pGarLivre.Visible)
            {
                garconDaVenda();
            }
            else garconNaoDaVenda();
        }
        public string getGarcon() {
            if (pGarLivre.Visible) return cbGarLivre.Text;
            else return cbGarVen.Text;
        
        }
     
        public void limpaCampo()
        {
            mtValor.Clear();
            mtCodigo1.Clear();
            mtCodigo2.Clear();
            mtCodigo3.Clear();

        }
        public void limpeza()
        {
            lbNomePizza1.Visible = false;
            lbNomePizza2.Visible = false;
            lbNomePizza3.Visible = false;
            lbNomePizza4.Visible = false;
            mtCodigo.Focus();
            numQuantidade.Value = 1;
            numQuantidade.Visible = false;
            lTamanho.Visible = false;
            lbMista.Visible = false;
            cbTamanho.Visible = false;
            garconDaVenda();
           
            cbMista.Visible = false;
            lbRS.Visible = false;
            mtValor.Visible = false;
            lbValor.Visible = false;
            LQuantidade.Visible = false;
        }
        public bool campoFull()
        {
            if (mtCodigo3.Visible)

                return (mtCodigo.Text.Length != 0 && mtCodigo1.Text.Length != 0 && mtCodigo2.Text.Length != 0 && mtCodigo3.Text.Length != 0);
            else if (mtCodigo2.Visible)

                return (mtCodigo.Text.Length != 0 && mtCodigo1.Text.Length != 0 && mtCodigo2.Text.Length != 0);
            else if (mtCodigo1.Visible)

                return (mtCodigo.Text.Length != 0 && mtCodigo1.Text.Length != 0);
            else return (mtCodigo.Text.Length != 0);

            //este metodo retorna se o campo de codigo esta preenchido ou nao
            //true para campos preenchidos

        }
        public void preecherTodosProdutos()
        {
            Banco b = new Banco();

            //e o preco dos produtos?
            if (campoFull())
            {
                string teste = cbTamanho.Text;
                int cod_tamanho = new Banco().cod_tamanhoDoEscolhido(Convert.ToInt16(mtCodigo.Text), cbTamanho.Text);
                if (new Banco().isPizza(Convert.ToInt16(mtCodigo.Text)))
                {
                    switch (cbMista.SelectedIndex)
                    {
                        case 0:
                            {
                                prod = new Produto[1];
                                prod[0] = new Produto();
                                prod[0].setInfo(Convert.ToInt16(mtCodigo.Text), 100, new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cbTamanho.Text), cod_tamanho);


                                break;
                            }
                        case 1:
                            {
                                prod = new Produto[2]; prod[0] = new Produto(); prod[1] = new Produto();
                                double rr = new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cbTamanho.Text);
                                prod[0].setInfo(Convert.ToInt16(mtCodigo.Text), 50, rr, cod_tamanho);
                                prod[1].setInfo(Convert.ToInt16(mtCodigo1.Text), 50, new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cbTamanho.Text), cod_tamanho);

                                break;
                            }
                        case 2:
                            {
                                prod = new Produto[3]; prod[0] = new Produto(); prod[1] = new Produto(); prod[2] = new Produto();

                                prod[0].setInfo(Convert.ToInt16(mtCodigo.Text), 50, new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cbTamanho.Text), cod_tamanho);
                                prod[1].setInfo(Convert.ToInt16(mtCodigo1.Text), 25, new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cbTamanho.Text), cod_tamanho);
                                prod[2].setInfo(Convert.ToInt16(mtCodigo2.Text), 25, new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cbTamanho.Text), cod_tamanho);

                                break;
                            }
                        case 3:
                            {
                                prod = new Produto[4]; prod[0] = new Produto(); prod[1] = new Produto();
                                prod[2] = new Produto(); prod[3] = new Produto();

                                prod[0].setInfo(Convert.ToInt16(mtCodigo.Text), 25, new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cbTamanho.Text), cod_tamanho);
                                prod[1].setInfo(Convert.ToInt16(mtCodigo1.Text), 25, new Banco().valorProduto(Convert.ToInt16(mtCodigo1.Text), cbTamanho.Text), cod_tamanho);
                                prod[2].setInfo(Convert.ToInt16(mtCodigo2.Text), 25, new Banco().valorProduto(Convert.ToInt16(mtCodigo2.Text), cbTamanho.Text), cod_tamanho);
                                prod[3].setInfo(Convert.ToInt16(mtCodigo3.Text), 25, new Banco().valorProduto(Convert.ToInt16(mtCodigo3.Text), cbTamanho.Text), cod_tamanho);

                                break;
                            }
                    }
                }
                else
                {

                    prod = new Produto[1]; prod[0] = new Produto();
                    prod[0].setInfo(Convert.ToInt16(mtCodigo.Text), 100, new Banco().valorProduto(Convert.ToInt16(mtCodigo.Text), cbTamanho.Text), cod_tamanho);
                }
            }
        }
        public void preencherValorProduto()
        {
            Banco c = new Banco();
            switch (cbMista.SelectedIndex)
            {
                case -1:
                    {
                        try
                        {
                            double t = c.valorProduto(Convert.ToInt16(mtCodigo.Text), (cbTamanho.Text));
                            if (t < 10) mtValor.Mask = "0.00";
                            else
                                if (t < 100 && t >= 10) mtValor.Mask = "00.00";
                                else if (t >= 100) mtValor.Mask = "000.00";

                            mtValor.Text = new Tratamento().retornaValorEscrito(t);
                            break;
                        }
                        catch { } break;
                    }
                case 0:
                    {
                        try
                        {
                            double t = c.valorProduto(Convert.ToInt16(mtCodigo.Text), (cbTamanho.Text));
                            if ((t < 100 && t >= 10) || t == 0) mtValor.Mask = "00.00";
                            else
                                if (t < 10) mtValor.Mask = "0.00";

                                else if (t >= 100) mtValor.Mask = "000.00";

                            mtValor.Text = new Tratamento().retornaValorEscrito(t);
                            break;
                        }
                        catch { } break;
                    }
                case 1:
                    {
                        try
                        {
                            double t = (c.valorProduto(Convert.ToInt16(mtCodigo.Text), (cbTamanho.Text))) + (c.valorProduto(Convert.ToInt16(mtCodigo1.Text), (cbTamanho.Text)));
                            t /= 2;
                            if (t < 10) mtValor.Mask = "0.00";
                            else
                                if (t < 100 && t >= 10) mtValor.Mask = "00.00";
                                else if (t >= 100) mtValor.Mask = "000.00";

                            mtValor.Text = new Tratamento().retornaValorEscrito(t);
                        }
                        catch { }
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            double t = c.valorProduto(Convert.ToInt16(mtCodigo.Text), (cbTamanho.Text));
                            double b = c.valorProduto(Convert.ToInt16(mtCodigo1.Text), (cbTamanho.Text));
                            double e = c.valorProduto(Convert.ToInt16(mtCodigo2.Text), (cbTamanho.Text));
                            t /= 2;
                            b /= 4;
                            e /= 4;
                            t += (b + e);
                            if (t < 10) mtValor.Mask = "0.00";
                            else if (t < 100 && t >= 10) mtValor.Mask = "00.00";
                            else if (t >= 100) mtValor.Mask = "000.00";

                            mtValor.Text = new Tratamento().retornaValorEscrito(t);

                        }
                        catch
                        {

                        } break;
                    }
                case 3:
                    {
                        try
                        {
                            double a = c.valorProduto(Convert.ToInt16(mtCodigo.Text), (cbTamanho.Text));
                            double b = c.valorProduto(Convert.ToInt16(mtCodigo1.Text), (cbTamanho.Text));
                            double e = c.valorProduto(Convert.ToInt16(mtCodigo2.Text), (cbTamanho.Text));
                            double d = c.valorProduto(Convert.ToInt16(mtCodigo3.Text), (cbTamanho.Text));
                            double t = ((a + b) + (e + d));
                            t /= 4; if (t < 10) mtValor.Mask = "0.00";
                            else if (t < 100 && t >= 10) mtValor.Mask = "00.00";
                            else if (t >= 100) mtValor.Mask = "000.00";
                            mtValor.Text = new Tratamento().retornaValorEscrito(t);

                        }
                        catch { } break;
                    }
            }
        }
        public void nomesVisiveis()
        {

            if (!mtCodigo1.Visible)
            {
                lbPct1.Visible = true;
                lbPct1.Text = "ÚNICO";
                lbPct2.Visible = false;
                lbPct3.Visible = false;
                lbPct4.Visible = false;
                btConsulta2.Visible = false;
                btConsulta3.Visible = false;
                btConsulta4.Visible = false;
                //--------------
                lbNomePizza2.Visible = false;
                lbNomePizza3.Visible = false;
                lbNomePizza4.Visible = false;
                lbValor.Visible = true;
                mtValor.Visible = true;
                lbRS.Visible = true;

            }
            else if (!mtCodigo2.Visible)
            {
                lbPct1.Visible = true;
                lbPct1.Text = "50 %";
                lbPct2.Visible = true;
                lbPct2.Text = "50 %";
                lbPct3.Visible = false;
                lbPct4.Visible = false;
                btConsulta2.Visible = true;
                btConsulta3.Visible = false;
                btConsulta4.Visible = false;
                lbNomePizza3.Visible = false;
                lbNomePizza4.Visible = false;
                lbValor.Visible = true;
                mtValor.Visible = true;
                lbRS.Visible = true;
            }
            else if (!mtCodigo3.Visible)
            {
                lbPct1.Visible = true;
                lbPct1.Text = "50 %";
                lbPct2.Visible = true;
                lbPct2.Text = "25 %";
                lbPct3.Visible = true;
                lbPct3.Text = "25 %";
                lbPct4.Visible = false;
                btConsulta2.Visible = true;
                btConsulta3.Visible = true;
                btConsulta4.Visible = false;
                lbNomePizza4.Visible = false;
                lbValor.Visible = true;
                mtValor.Visible = true;
                lbRS.Visible = true;
            }
            else
            {
                lbPct1.Visible = true;
                lbPct1.Text = "25 %";
                lbPct2.Visible = true;
                lbPct2.Text = "25 %";
                lbPct3.Visible = true;
                lbPct3.Text = "25 %";
                lbPct4.Visible = true;
                lbPct3.Text = "25 %";
                btConsulta2.Visible = true;
                btConsulta3.Visible = true;
                btConsulta4.Visible = true;
                lbValor.Visible = true;
                mtValor.Visible = true;
                lbRS.Visible = true;
            }
        }

        private void btConsulta1_Click(object sender, EventArgs e)
        {

            CodigoProduto tc = new CodigoProduto();
         
            tc.ShowDialog();
            //     if (tc.codigoProduto !=null)
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

        private void mtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Banco b = new Banco();
                //esses metodos irao dar confirmacao a venda
                if (e.KeyChar == '\r')
                {
                    
                    cbTamanho.Visible = true;
                    lTamanho.Visible = true;
                    // aqui eu tenho os tamanhos referentes ao produto
                        try
                        {
                            cbTamanho.DataSource = b.tamanhoProduto(Convert.ToInt16(mtCodigo.Text));
                            cbTamanho.DisplayMember = "descricao";
                            cbTamanho.SelectedIndex = 0;

                            if (b.isPizza(Convert.ToInt16(mtCodigo.Text)) )
                            {
                                lTamanho.Text = "TAMANHO";
                                cbMista.Visible = true;lbMista.Visible = true; lbGarcon.Visible = true;
                                garconDaVenda();
                                numQuantidade.Visible = true;  LQuantidade.Visible = true;

                                int codTamanho = b.codTamanho(cbTamanho.Text);
                                cbMista.Items.Clear();
                                if (codTamanho == 1) cbMista.Items.AddRange(divisao1);
                                else cbMista.Items.AddRange(divisao2);

                                cbMista.SelectedIndex = 0;
                            }
                            else
                            {
                                lTamanho.Text = "CATEGORIA";
                                cbMista.Visible = false;lbMista.Visible = false;
                                garconDaVenda();
                                LQuantidade.Visible = true; numQuantidade.Visible = true;
                            }
                            if (cbTamanho.Items.Count == 0)
                            { cbTamanho.Visible = false; lTamanho.Visible = false; }
                            //------------------------------------
                            string categoria = new Banco().categoriaProduto(Convert.ToInt16(mtCodigo.Text));
                            lbNomePizza1.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo.Text));
                            panelValor.Visible = true;           lbNomePizza1.Visible = true;

                            preencherValorProduto();    cbTamanho.Focus();    nomesVisiveis();
                        }

                        catch
                        {
                            cbTamanho.Visible = false; lTamanho.Visible = false;
                            mtCodigo.Clear();    panelValor.Visible = false;
                        }
                 
                }
            }
            catch
            {
                mtCodigo.Clear();
                cbMista.Visible = false;
                lbMista.Visible = false; cbTamanho.Visible = false; lTamanho.Visible = false; lbValor.Visible = false;
                mtValor.Visible = false;
            }
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (mtCodigo1.Visible)
                        mtCodigo1.Focus();
                    else cbTamanho.Focus();
                }
            }
            catch { }

        }

        private bool metodoValida(int numero, int posicao)
        {
            switch (posicao)
            {
                case 0:
                    {
                        if (!mtCodigo1.Visible && !mtCodigo2.Visible && !mtCodigo3.Visible)
                            return true;
                        else
                        {
                            if (mtCodigo1.Visible && mtCodigo1.Text.Length > 0 && numero == Convert.ToInt16(mtCodigo1.Text))
                                return false;
                            if (mtCodigo2.Visible && mtCodigo2.Text.Length > 0 && numero == Convert.ToInt16(mtCodigo2.Text))
                                return false;
                            if (mtCodigo3.Visible && mtCodigo2.Text.Length > 0 && numero == Convert.ToInt16(mtCodigo3.Text))
                                return false;

                            return true;
                        }
                    }
                case 1:
                    {
                            if ( numero == Convert.ToInt16(mtCodigo.Text))
                                return false;
                            if (mtCodigo2.Visible && mtCodigo2.Text.Length >0 && numero == Convert.ToInt16(mtCodigo2.Text))
                                return false;
                            if (mtCodigo3.Visible && mtCodigo3.Text.Length > 0 && numero == Convert.ToInt16(mtCodigo3.Text))
                                return false;
                            return true;
                    }
                case 2:
                    {
                        if (numero == Convert.ToInt16(mtCodigo.Text))
                            return false;
                        if (mtCodigo1.Visible && mtCodigo1.Text.Length > 0 && numero == Convert.ToInt16(mtCodigo1.Text))
                            return false;
                        if (mtCodigo3.Visible && mtCodigo3.Text.Length > 0 && numero == Convert.ToInt16(mtCodigo3.Text))
                            return false;
                        return true;
                    }
                case 3:
                    {
                        if (numero == Convert.ToInt16(mtCodigo.Text))
                            return false;
                        if (mtCodigo2.Visible && mtCodigo2.Text.Length > 0 && numero == Convert.ToInt16(mtCodigo2.Text))
                            return false;
                        if (mtCodigo1.Visible && mtCodigo1.Text.Length > 0 && numero == Convert.ToInt16(mtCodigo1.Text))
                            return false;
                        return true;
                    }
            }
            return true;
        }
        private void mtCodigo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Banco b = new Banco();
                //esses metodos irao dar confirmacao a venda
                if (e.KeyChar == '\r')
                {
                    if (metodoValida(Convert.ToInt16(mtCodigo1.Text), 1))
                    {
                        if (b.isPizza(Convert.ToInt16(mtCodigo1.Text)))
                        {
                            try
                            {
                                mtValor.Visible = true;
                                preencherValorProduto();
                                nomesVisiveis();
                                lbNomePizza2.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo1.Text));
                                lbNomePizza2.Visible = true;
                            }
                            catch
                            {
                                mtValor.Visible = false;
                                nomesVisiveis();
                                lbNomePizza2.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo1.Text));
                            }

                            if (mtCodigo2.Visible)
                                mtCodigo2.Focus();
                            else numQuantidade.Focus();
                        }
                        else { mtCodigo1.Clear(); lbNomePizza2.Visible = false; };
                    }
                    else { mtCodigo1.Clear(); }
                }

            }
            catch
            {

            }

        }
        private void mtCodigo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Banco b = new Banco();
                //esses metodos irao dar confirmacao a venda
                if (e.KeyChar == '\r')
                {
                    if (metodoValida(Convert.ToInt16(mtCodigo2.Text), 2))
                    {
                        if (b.isPizza(Convert.ToInt16(mtCodigo2.Text)))
                        {
                            try
                            {
                                panelValor.Visible = true;
                                preencherValorProduto();
                                nomesVisiveis();
                                lbNomePizza3.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo2.Text));
                                lbNomePizza3.Visible = true;
                            }
                            catch
                            {

                                nomesVisiveis();
                                lbNomePizza3.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo2.Text));
                                lbNomePizza3.Visible = true;

                            }

                            if (mtCodigo3.Visible)
                                mtCodigo3.Focus();
                            else numQuantidade.Focus();
                        }
                        else { mtCodigo2.Clear(); lbNomePizza3.Visible = false; };
                    }
                    else { mtCodigo2.Clear(); }
                }
                
            }
            catch
            {

            }
        }
        private void mtCodigo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Banco b = new Banco();
                //esses metodos irao dar confirmacao a venda
                if (e.KeyChar == '\r')
                {
                    if (metodoValida(Convert.ToInt16(mtCodigo3.Text), 3))
                    {
                        if (b.isPizza(Convert.ToInt16(mtCodigo3.Text)))
                        {
                            try
                            {
                                panelValor.Visible = true;
                                preencherValorProduto();
                                nomesVisiveis();
                                lbNomePizza4.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo3.Text));
                                lbNomePizza4.Visible = true;
                            }
                            catch
                            {
                                nomesVisiveis();
                                lbNomePizza4.Text = new Banco().preencherNomeProduct(Convert.ToInt16(mtCodigo3.Text));
                                lbNomePizza4.Visible = true;
                            }

                            numQuantidade.Focus();
                        }
                        else { mtCodigo3.Clear(); lbNomePizza4.Visible = false; };
                    }
                    else { mtCodigo3.Clear(); }
                }
            }
            catch { }
        }

        private void btEscolhaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int cod_tamanho = new Banco().cod_tamanhoDoEscolhido(Convert.ToInt16(mtCodigo.Text), cbTamanho.Text);
                double val = Convert.ToDouble(mtValor.Text);
                try
                {
                    if (mesas.Equals(null)) { }
                }
                catch
                {
                    mesas = new string[1];
                    mesas[0] = new Banco().trazerNomeMesa(cod_venda);
                }
                string XnomeMesa = mesas[0];
                int XcodigoProduto = Convert.ToInt16(mtCodigo.Text);
                int XcodTamanho = new Banco().codTamanho(cbTamanho.Text);
                double Xvalor = val;

                int Xcod_garcon = new Banco().codGarconByNome(getGarcon());
                int XquantidadeProduto = Convert.ToInt16(numQuantidade.Text);
                preecherTodosProdutos();
                if ((new Banco().jaTemProduto(cod_venda, XcodigoProduto, XcodTamanho, val, prod.Length == 1, XquantidadeProduto, Xcod_garcon)))//se ja houver produtos, aqui altera quantidade.
                {

                }
                else {

                    preecherTodosProdutos();
                    int cod_completo = new Banco().novoCompleto(prod, Convert.ToDouble(mtValor.Text), Convert.ToInt16(numQuantidade.Text));
                    new Banco().makeVendaCompleto(cod_venda, cod_completo);
                    new Banco().GarconCompleto(Xcod_garcon, cod_completo, XquantidadeProduto);
                }
                if ((MessageBox.Show("Deseja acrescentar outro Produto? ", "Pizzaria Delirius", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    mtCodigo1.Clear();
                    mtCodigo2.Clear();
                    mtCodigo3.Clear();
                    mtCodigo1.Visible = false;
                    mtCodigo2.Visible = false;
                    mtCodigo.Visible = false;
                    mtCodigo.Clear();
                    nomesVisiveis();
                    mtCodigo.Visible = true;
                    mtCodigo.Focus();
                    limpaCampo();
                    limpeza();
                }
                else this.Close();

            }
            catch { };
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void numQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pGarLivre.Visible)
                cbGarLivre.Focus();
            else
                cbGarVen.Focus();
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
            cbMista.Items.Clear();
            if (codTamanho == 1) cbMista.Items.AddRange(divisao1);
            else cbMista.Items.AddRange(divisao2); limpaCampo();
            preencherValorProduto();
            cbMista.DisplayMember = "descricao";
            cbMista.SelectedIndex = 0;
            panelValor.Visible = true;
        }
        private void cbMista_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpaCampo();
            if (cbMista.SelectedIndex == 0)
            {
                mtCodigo.Visible = true;
                mtCodigo1.Visible = false;
                mtCodigo2.Visible = false;
                mtCodigo3.Visible = false;
            }
            else
                if (cbMista.SelectedIndex == 1)
                {
                    mtCodigo.Visible = true;
                    mtCodigo1.Visible = true;
                    mtCodigo2.Visible = false;
                    mtCodigo3.Visible = false;
                }
                else
                    if (cbMista.SelectedIndex == 2)
                    {
                        mtCodigo.Visible = true;
                        mtCodigo1.Visible = true;
                        mtCodigo2.Visible = true;
                        mtCodigo3.Visible = false;
                    }
                    else
                        if (cbMista.SelectedIndex == 3)
                        {
                            mtCodigo.Visible = true;
                            mtCodigo1.Visible = true;
                            mtCodigo2.Visible = true;
                            mtCodigo3.Visible = true;
                        }
            nomesVisiveis();
            preecherTodosProdutos();
            preencherValorProduto();

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

   
    }
}
