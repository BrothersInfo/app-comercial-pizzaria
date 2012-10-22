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
        short cod_caixa;
        public Principal(short cod_caixa)
        {
            this.cod_caixa = cod_caixa;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            conjItem = new List<ListViewItem>();
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
                    lvInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(3).ToString());
                }
                lValor.Text ="TOTAL PARCIAL = R$ "+ new Tratamento().retornaValorEscrito(new BancoVenda().carregaVenda(new Banco().codVendaSelecionada2(listVenda.FocusedItem.Text)).valorTotal);
              
            }
            catch { }
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
                    textBox2.Visible = true;
                    textBox2.Focus();
                    break;
            }
        }
        public void carregarMesa(bool indisponivel)
        {
            if (indisponivel)
            {
                listVenda.Clear();
                listVenda.LargeImageList = imageList1;

                string[] mesa = new Banco().mesasIndisponiveis();
                for (int i = 0; i < mesa.Length; i++)
                {
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
                listVenda.LargeImageList = imageList1;

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
                    Impressao p = new Impressao(new BancoVenda().carregaVenda(cod_venda));
                    new BancoVenda().imprimiu(cod_venda);
                    p.gerarComprovante();
                    p.lerArquivo();
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
                   Encerrar rec = new Encerrar(f.cod_venda, f.valorTotal, f.mesa);
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
                carregarMesa(true);
            }
            else
            {
                this.Visible = false;
                new Venda(listVenda.FocusedItem.Text).ShowDialog();
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
                MSImprimir_Click(sender, null);
            else
                if (inVenda() && a.ToLowerInvariant().Equals("v"))
                    MSEncerrar_Click(sender, null);
                else
                    if (inVenda() && a.ToLowerInvariant().Equals("p"))
                        MSProduto_Click(sender, null);
                    else

                        if (a.ToLowerInvariant().Equals("l"))
                            carregarMesa(false);
                        else if (a.ToLowerInvariant().Equals("o"))
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
        }
        private void pOcupada_MouseEnter(object sender, EventArgs e)
        {
            lInutil2.ForeColor = Color.Red;
            linutil1.ForeColor = Color.Black;
            pOcupada.BackColor = Color.WhiteSmoke;
            pLivre.BackColor = Color.White;
            pLivre.BorderStyle = BorderStyle.FixedSingle;
            pOcupada.BorderStyle = BorderStyle.Fixed3D;
            carregarMesa(true);
           
        }
        private void Principal_Click(object sender, EventArgs e)
        {
            hei = Screen.PrimaryScreen.Bounds.Height;
            wig = Screen.PrimaryScreen.Bounds.Width;
        }

    }
}
