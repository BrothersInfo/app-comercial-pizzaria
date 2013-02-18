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
    public partial class Codes : Form
    {
        public Codes()
        {
            InitializeComponent();
            preencherTreeView();
        }
        public Codes(int codigo)
        {
            InitializeComponent();
            preencherUmTree(codigo);
        }

        List<ListViewItem> conjItem;
        List<ListViewItem> conjProduto;
        private void preencherTreeView()
        {
            tvTipado.ImageList =  imageList1;
            tvTipado.Nodes.Clear();

            DataTable t = new DataTable();
            t = new Banco.Banco().carregarCodigo();
            for (int i = 0; i < t.Rows.Count; i++)
            {
                tvTipado.Nodes.Add(t.Rows[i].ItemArray.GetValue(0).ToString());
                tvTipado.Nodes[i].ImageIndex = Convert.ToInt16(t.Rows[i].ItemArray.GetValue(1).ToString()) - 1;
                tvTipado.Nodes[i].SelectedImageIndex = Convert.ToInt16(t.Rows[i].ItemArray.GetValue(1).ToString()) - 1;
                tvTipado.Nodes[i].Tag = "RootDB";
            }
        }
        public void carregarProdutos(string nome)
        {
            conjProduto = new List<ListViewItem>();
            lvCodigo.Items.Clear();
            lvCodigo.LargeImageList = imageList2;
            DataTable produtos = new Banco.Banco().carregarNomeProdutoPeloTipo(nome);
            for (int i = 0; i < produtos.Rows.Count; i++)
            {
                conjProduto.Add(
                  new ListViewItem(
                      produtos.Rows[i].ItemArray.GetValue(0).ToString() + " : " + produtos.Rows[i].ItemArray.GetValue(1).ToString()
                      , new Banco.Banco().carregarCodigoFoto(Convert.ToInt16(produtos.Rows[i].ItemArray.GetValue(0))))
                           );
                lvCodigo.Items.Add(conjProduto.Last());

            }
        }
        private void tvTipado_AfterSelect(object sender, TreeViewEventArgs e)
        {

            carregarProdutos(tvTipado.SelectedNode.Text);
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                codigoProduto = Convert.ToInt16(lvCodigo.FocusedItem.Text.Split(':')[0].ToString());
                this.Close();
            }
            catch { };
        }
        public string getCodigoProduto()
        {
            return codigoProduto.ToString();
        }
        private int codigoProduto;

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void preencherUmTree(int cod_tipo)
        {
            conjItem = new List<ListViewItem>();

            tvTipado.ImageList = imageList1;
            tvTipado.Nodes.Clear();
            string av = new Banco.Banco().carregarCodigoUM(cod_tipo).Rows[0].ItemArray.GetValue(0).ToString();
            tvTipado.Nodes.Add(av);
            tvTipado.Nodes[0].ImageIndex = (Convert.ToInt16(new Banco.Banco().carregarCodigoUM(cod_tipo).Rows[0].ItemArray.GetValue(1))) - 1;
            tvTipado.Nodes[0].SelectedImageIndex = (Convert.ToInt16(new Banco.Banco().carregarCodigoUM(cod_tipo).Rows[0].ItemArray.GetValue(1))) - 1;
            tvTipado.Nodes[0].Tag = "RootDB";

        }

        private void Codes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    btCancelar_Click(sender, e);
                    break;
                case Keys.Enter://Voltar Tela
                    if (tvTipado.Focused)  lvCodigo.Focus();
                    else btConfirmar_Click(sender, e);
                    break;
            }
        }

        private void lvCodigo_ItemActivate(object sender, EventArgs e)
        {

            try
            {
                codigoProduto = Convert.ToInt16(lvCodigo.FocusedItem.Text.Split(':')[0].ToString());
                this.Close();
            }
            catch { };
        }
    }
}
