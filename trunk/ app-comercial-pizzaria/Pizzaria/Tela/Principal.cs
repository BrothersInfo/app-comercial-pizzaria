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
    public partial class Principal : Form
    {
        int hei;
        int wig;
        List<ListViewItem> conjItem;
        bool vendendo;
        public short cod_caixa;
        public TableLayoutPanel tlpBotoes;

        public void carregarTexto()
        {
            switch ((DateTime.Now.Hour / 6))
            {
                case 0:
                    lApresentacao.Text = "Boa Madrugada, ";

                    break;
                case 1:
                    lApresentacao.Text = "Bom Dia, ";
                    break;
                case 2:
                    lApresentacao.Text = "Boa Tarde, ";
                    break;
                case 3:
                    lApresentacao.Text = "Boa Noite, ";
                    break;
                default:
                    lApresentacao.Text = "Ola, ";
                    break;
            }
            lApresentacao.Text += (new BancoConsulta().getNome_Caixa(cod_caixa) + " - " + DateTime.Now.ToShortTimeString() + ", " + DateTime.Now.ToShortDateString() + " - ");

            lApresentacao.Text += frase();
         
        }

        public string frase()
        {

            string[] frases = {   
                                  "O homem comum fala, o sábio escuta, o tolo discute. Sabedoria Oriental"
                                  , "A dúvida é o principio da sabedoria. Aristóteles"
                                  , "A simplicidade é o último degrau da sabedoria, Khalil Gibran"
                                  , "Não basta conquistar a sabedoria, é preciso usá-la. Cícero"
                                  , "Seja a diferença que você quer ver no mundo. Mahatma Gandhi"
                                  , "Aprender que há outros pontos de vista é o início da sabedoria. Campbell"
                                  , "Muitas palavras não indicam necessariamente muita sabedoria. Mileto"
                                  , "O amor, única loucura do sábio e a única sabedoria do tolo. Shakespeare"
                                  , "Educar é semear com sabedoria e colher com paciência. Augusto Cury"
                                  , "O único lugar onde o sucesso vem antes do trabalho, o dicionário. Einstein"
                                  , "Não tentes ser bem sucedido, tenta antes ser um homem de valor. Eistein" 
                                  , "No meio da dificuldade encontra-se a oportunidade. Eistein"
                                  , "Não há lugar para a sabedoria onde não há paciência. Agostinho"
                                  , "A sabedoria começa na reflexão. Sócrates"
                                  , "Ser feliz sem motivo é a mais autêntica forma de felicidade. Drummond"
                                  ,"Só é lutador quem sabe lutar consigo mesmo. Carlos Drummond"
                                  ,"É Preciso amar as pessoas como se não houvesse amanhã. Renato Russo"
                                  ,"Conhecimento sem transformação não é sabedoria. Paulo Coelho"
                                  ,"Só há amor quando não existe nenhuma autoridade. Raul Seixas"
                                  ,"A formiga é pequena, mas elas são um exército quando juntas. Raul Seixas"
                                  ,"Tenho apenas duas mãos e o sentimento do mundo. Carlos Drummond"
                                  ,"A confiança é um ato de fé, e esta dispensa raciocínio. Carlos Drummond"//22
                                  ,"Uma longa viagem começa com um único passo. Lao-Tsé"
                                  ,"Aquele que se eleva nas pontas dos pés não está seguro. Lao-Tsé"
                                  ,"A alma não tem segredo que o comportamento não revele. Lao-Tsé"
                                  ,"Aquele que tudo julga fácil, encontrará muitas dificuldades. Lao-Tsé"
                                  ,"Não existe um caminho para a felicidade. A felicidade é o caminho. Gandhi"
                                  ,"Olho por olho, e o mundo acabará cego. Mahatma Gandhi"
                                  ,"O amor é a força mais sutil do mundo. Mahatma Gandhi"
                                  ,"Tenho em mim todos os sonhos do mundo. Fernando Pessoa"
                                  ,"Tudo vale a pena quando a alma não é pequena. Fernando Pessoa"
                                  ,"A vida é maravilhosa se não se tem medo dela. Charles Chaplin"
                                  ,"A Titan Soluções deseja um excelente trabalho para você."
                                  ,"A vida vai ficando cada vez mais dura perto do topo. Friedrich Nietzsche"
                                  ,"Amor é fogo que arde sem se ver. Luís de Camões"
                                  ,"Não levante a espada sobre a cabeça de quem te pediu perdão. Machado de Assis"
                                  ,"Eramos felizes e nem sabiamos. Bob Marley"
                                  ,"Tenho certeza de que se eu sorrisse menos teria menos amigos. Dalai Lama"
                                  ,"Sorria você não está sendo filmado. Oliveira"
                                  ,"Nós todos temos o direito de levar uma vida feliz. Dalai Lama"
                                  ,"A gente não faz amigos, reconhece-os. Vinícius de Moraes"//41
                                  ,"A vida é a arte do encontro, embora haja tantos desencontros por ela. Moraes"
                                  ,"Quem de dentro de si não sai, vai morrer sem amar ninguém. Vinícius de Moraes"
                                  ,"Triste coisa é querer bem a quem não sabe perdoar. Renato Russo"
                                  ,"Mentir pra se mesmo é sempre a pior mentira. Renato Russo"
                                  ,"Os princípios mais importantes podem e devem ser inflexíveis. Abraham Lincoln"
                                  ,"Nunca devemos mudar de cavalo no meio do rio. Abraham Lincoln"
                                  ,"Se quiser por à prova o caráter de um homem, dê-lhe poder. Abraham Lincoln"//48

                              };
            Random ran = new Random();
           

           return frases[ran.Next(frases.Length)];
        }
        private void DisplayImage()
        {
            PictureBox imageControl = new PictureBox();
            pbFoto.Width = 200;
            pbFoto.Height = 200;
            pbFoto.Dock = DockStyle.Fill;

            pbFoto.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "\\logo.png");
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage; 
          
        }
        public Principal(short cod_caixa,TableLayoutPanel fnd)
        {
            tlpBotoes = fnd;
            this.cod_caixa = cod_caixa;
            InitializeComponent();
            DisplayImage();
            carregarTexto();
            this.WindowState = FormWindowState.Maximized;
            conjItem = new List<ListViewItem>();
            tlpBotoes.Visible = false;
            try
            {
                pOcupada_MouseEnter(null, null);
                vendendo = true;
            }
            catch
            {
                pLivre_MouseEnter(null, null);
                vendendo = false;
            }
            regularTamanho();
            carregarGridItem();
        }
        public void carregarGridItem()
        {
            try
            {
                DataTable t = new Banco().informacoes(listVenda.FocusedItem.Text);
                lvInfo.Items.Clear();
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    lvInfo.Items.Add(new Banco().informacoes2(Convert.ToInt16(t.Rows[i].ItemArray.GetValue(0))));
                    lvInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(1).ToString());
                    lvInfo.Items[i].SubItems.Add("R$ " + new Tratamento().retornaValorEscrito(Convert.ToDouble(t.Rows[i].ItemArray.GetValue(2))));
                    lvInfo.Items[i].SubItems.Add("" + new BancoInformacao().quantidadeCompletaByCodigo(Convert.ToInt16(t.Rows[i].ItemArray.GetValue(0))));
                }
                VendaFull vf =  new BancoVenda().carregaVenda(new Banco().codVendaSelecionada2(listVenda.FocusedItem.Text));
                lValor.Text = "SUB TOTAL R$ " + new Tratamento().retornaValorEscrito(vf.subValor);

                lValor2.Text ="COUVERT R$ " + new Tratamento().retornaValorEscrito(vf.valorComissao);
                lValor3.Text ="TOTAL PARCIAL R$ "+ new Tratamento().retornaValorEscrito(vf.valorSomado);
                lValor.Visible = true;
                if (vf.valorComissao > 0)
                {

                    lValor.Margin = new Padding(3, 9, 4, 0);
                    lValor2.Visible = true;
                    lValor3.Visible = true;
                }
                else
                {
                    lValor.Margin = new Padding(150, 9, 4, 0);
                    lValor2.Visible = false;
                    lValor3.Visible = false;
                }
            }
            catch { return; }
        }
        private void regularTamanho()
        {
            double umPct =(double) 443 / 100;
       //     this.lvInfo.Size = new System.Drawing.Size((int)448, 384); //570 555
            this.aparelho.Width = (int)(umPct * 35);//35

            this.inicio.Width = (int)(umPct * 23);//23%

            this.fim.Width = (int)(umPct * 22);//22%

            this.qtd.Width = (int)(umPct * 20);//20%

            this.lvInfo.Scrollable = false;
            if (this.lvInfo.Items.Count >= 15)
                this.lvInfo.Scrollable = true;
        }
        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8://Voltar Tela
                   // textBox2.Visible = true;
                  //  textBox2.Focus();
                    break;
            }
        }
        public void carregarMesa(bool indisponivel)
        {
            if (indisponivel)
            {
                listVenda.Clear();
                ImageList il = new ImageList();

                //imageList1.ImageSize = 
                listVenda.LargeImageList = imageList1;

                string[] mesa = new Banco().mesasIndisponiveis();
                for (int i = 0; i < mesa.Length; i++)
                {
                    listVenda.LargeImageList = imageList1;
                    if (new BancoConsulta().mesaImpressa(mesa[i]))
                    {
                        conjItem.Add(new ListViewItem(mesa[i], 1));
                    }
                    else conjItem.Add(new ListViewItem(mesa[i], 2));
                    listVenda.Items.Add(conjItem.Last());
                }
                // Allow the user to rearrange columns.  
                listVenda.AllowColumnReorder = true;

                // Select the item and subitems when selection is made.  
                listVenda.FullRowSelect = true;
                // Display grid lines.  
                listVenda.GridLines = true;
                // Sort the items in the list in ascending order.  
                //  listMesas.Sorting = SortOrder.Ascending;
                listVenda.CheckBoxes = false;
                //   lbVenda.Text = "MESAS OCUPADAS";
                vendendo = true;
            }
            else
            {
                listVenda.Clear();
                listVenda.LargeImageList = imageList2;

                string[] mesa = new Banco().mesasDisponiveis();
                for (int i = 0; i < mesa.Length; i++)
                {
                    conjItem.Add(new ListViewItem(mesa[i], 0));
                    listVenda.Items.Add(conjItem.Last());
                }
                // Allow the user to rearrange columns.  
                listVenda.AllowColumnReorder = true;

                // Select the item and subitems when selection is made.  
                listVenda.FullRowSelect = true;
                // Display grid lines.  
                listVenda.GridLines = true;
                // Sort the items in the list in ascending order.  
                //  listMesas.Sorting = SortOrder.Ascending;
                listVenda.CheckBoxes = true;
                //   lbVenda.Text = "MESAS LIVRES";
                vendendo = false;
            }
        }
// olhar os 3 metodos depois de criar as aberturas das telas usadas pelos metodos !!!!!!!!!!!!!!!!!!!!!!!!!!
        private void MSImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma Impressão?", "Confirme sua Opcao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int cod_venda = new Banco().codigoDaVendaPelaMesa(listVenda.FocusedItem.Text);
                    VendaFull vd = new BancoVenda().carregaVenda(cod_venda);
                    Impressao p = new Impressao();
                    new BancoVenda().imprimiu(cod_venda);
                    p.imprimirComanda(1, vd);
                    new BancoVenda().imprimiu(cod_venda);
                    carregarMesa(true);

                }
            }
            catch { }
        }
        private void MSEncerrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod_venda = new Banco().codigoDaVendaPelaMesa(listVenda.FocusedItem.Text);
                VendaFull f = (new BancoVenda().carregaVenda(cod_venda));

                if (new BancoVenda().isImpresso(f.cod_venda) || (MessageBox.Show("COMANDA DESATUALIZADA \n DESEJA ENCERRAR MESMO ASSIM?", "Confirme sua Opcao", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {

                    Pagamento rec = new Pagamento(f.cod_venda,f.subValor,f.valorComissao, f.valorSomado, f.mesa, false);
                    rec.ShowDialog();
                    if (rec.encerrou)
                    {
                        MessageBox.Show("VENDA REALIZADA COM SUCESSO");
                        carregarMesa(true);
                    }
                }
            }
            catch { }
        }
        private void MSProduto_Click(object sender, EventArgs e)
        {


            int cod_venda = new Banco().codigoDaVendaPelaMesa(listVenda.FocusedItem.Text);
            VendaFull f = (new BancoVenda().carregaVenda(cod_venda));
           new AddProduto(f.cod_venda).ShowDialog();
            new BancoVenda().naoImprimiu(cod_venda);
            carregarMesa(true);


        }
        private void listVenda_ItemActivate(object sender, EventArgs e)
        {
            if (listVenda.CheckBoxes)
            {
                this.Visible = false;
                string[] num;
                if (listVenda.FocusedItem.Checked)
                {
                    num = new string[listVenda.CheckedItems.Count];
                    for (int i = 0; i < num.Length; i++)
                        num[i] = listVenda.CheckedItems[i].Text;
                }
                else
                {
                    num = new string[listVenda.CheckedItems.Count + 1];
                    for (int i = 0; i < num.Length - 1; i++)
                        num[i] = listVenda.CheckedItems[i].Text;

                    num[num.Length - 1] = listVenda.FocusedItem.Text;
                }
                new AddProduto(num, cod_caixa).ShowDialog();
                this.Visible = true;
                try
                {
                    carregarMesa(true);
                }
                catch {
                    //carregarMesa(false); return; 
                }
                this.Focus();
                }
            else
            {
                this.Visible = false;
                tlpBotoes.Visible = !tlpBotoes.Visible;
                new Venda(listVenda.FocusedItem.Text).ShowDialog();
                tlpBotoes.Visible = !tlpBotoes.Visible;
                try
                {
                    pOcupada_MouseEnter(null, null);
                    vendendo = true;
                }
                catch
                {
                    pLivre_MouseEnter(null, null);
                    vendendo = false;
                }
                this.Visible = true;
               
            }
        }
        private void listVenda_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            carregarGridItem();
        }
        public bool inVenda()
        {
            return vendendo;
        }
        private void listVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = e.KeyChar.ToString();

            if (inVenda() && a.ToLowerInvariant().Equals("i"))
            {
                MSImprimir_Click(sender, null);
                this.Enabled = false;
                this.Enabled = true;

            
            }
            else
                if (inVenda() && a.ToLowerInvariant().Equals("v"))
                    MSEncerrar_Click(sender, null);
                else
                    if (inVenda() && a.ToLowerInvariant().Equals("p"))
                        MSProduto_Click(sender, null);
                    else
                        if (a.ToLowerInvariant().Equals("b"))
                            new AddProduto(true, cod_caixa).ShowDialog();
                        else
                            if (a.ToLowerInvariant().Equals("l"))
                                carregarMesa(false);
                            else
                                if (a.ToLowerInvariant().Equals("o"))
                                    carregarMesa(true);
           
        }
        private void listVenda_MouseClick(object sender, MouseEventArgs e)
        {
            carregarGridItem();
        }
        private void pLivre_MouseEnter(object sender, EventArgs e)
        {
            pLivre.BorderStyle = BorderStyle.Fixed3D;
            pOcupada.BorderStyle = BorderStyle.FixedSingle;
            pLivre.BackColor = Color.WhiteSmoke;
            pOcupada.BackColor = Color.White;
            carregarMesa(false);
            lInutil2.ForeColor = Color.Black;
            linutil1.ForeColor = Color.Red;
            lValor.Text = "";
            lValor.Visible = false;

            lValor2.Text = "";
            lValor2.Visible = false;
            lValor3.Text = "";
            lValor3.Visible = false;
              
            carregarGridItem();
        }
        private void pOcupada_MouseEnter(object sender, EventArgs e)
        {
            lInutil2.ForeColor = Color.Red;
            linutil1.ForeColor = Color.Black;
            pOcupada.BackColor = Color.WhiteSmoke;
            pLivre.BackColor = Color.White;
            pLivre.BorderStyle = BorderStyle.FixedSingle;
            pOcupada.BorderStyle = BorderStyle.Fixed3D; lValor.Visible = true;
            carregarMesa(true);

           
        }
        private void Principal_Click(object sender, EventArgs e)
        {
            hei = Screen.PrimaryScreen.Bounds.Height;
            wig = Screen.PrimaryScreen.Bounds.Width;
        }
        private void pBalcao_MouseEnter(object sender, EventArgs e)
        {

            pBalcao.BorderStyle = BorderStyle.Fixed3D;
            lBalcao.ForeColor = Color.Red;
        }
        private void pBalcao_Click(object sender, EventArgs e)
        {
            pBalcao.BorderStyle = BorderStyle.Fixed3D;
            new AddProduto(true, cod_caixa).ShowDialog();
            pBalcao.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pBalcao_MouseLeave(object sender, EventArgs e)
        {
            pBalcao.BorderStyle = BorderStyle.FixedSingle;
            lBalcao.ForeColor = Color.Black;
        }
        private void lBalcao_Click(object sender, EventArgs e)
        {
            new AddProduto(true, cod_caixa).ShowDialog();
        }
        private void lBalcao_MouseEnter(object sender, EventArgs e)
        {
            pBalcao.BorderStyle = BorderStyle.Fixed3D;
            lBalcao.ForeColor = Color.Red;
        }
        private void lBalcao_MouseLeave(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            carregarTexto();
        }




    }
}
