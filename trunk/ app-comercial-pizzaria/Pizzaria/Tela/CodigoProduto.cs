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
    public partial class CodigoProduto : Form
    {
        public CodigoProduto()
        {
            InitializeComponent();
            carregarTipos();
            lvTipo.Focus();
            lvTipo.Select();    
            posicionamento();
        }
        private void posicionamento()
        {
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr);
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
        }
        
        public string getCodigoProduto()
        {
            return codigoProduto.ToString();
        }
        private int codigoProduto;

        public void carregarTipos()
        {
            conjItem = new List<ListViewItem>();
            DataTable t = new DataTable();
            t = new Banco().carregarCodigo();
            lvTipo.LargeImageList = imageList1;
            for (int i = 0; i < t.Rows.Count; i++)
            {
                conjItem.Add(
                    new ListViewItem(
                        t.Rows[i].ItemArray.GetValue(0).ToString(), 
                        Convert.ToInt16(  t.Rows[i].ItemArray.GetValue(1).ToString()   )-1
                                    )
                             );
                lvTipo.Items.Add(conjItem.Last());
            } 
        }
        List<ListViewItem> conjItem;
        List<ListViewItem> conjProduto;
        public void carregarProdutos(string nome)
        {
            conjProduto = new List<ListViewItem>();
            lvCodigo.Items.Clear();
            DataTable produtos = new Banco().carregarNomeProdutoPeloTipo(nome);
            for (int i = 0; i < produtos.Rows.Count; i++)
            {
                conjProduto.Add(
                  new ListViewItem(
                      produtos.Rows[i].ItemArray.GetValue(0).ToString() + " : " + produtos.Rows[i].ItemArray.GetValue(1).ToString(), new Banco().carregarCodigoFoto( Convert.ToInt16( produtos.Rows[i].ItemArray.GetValue(0))))
                    
                           );
                lvCodigo.Items.Add(conjProduto.Last());

            }
        }

        private void lvCodigo_ItemActivate(object sender, EventArgs e)
        {
            codigoProduto = Convert.ToInt16(lvCodigo.FocusedItem.Text.Split(':')[0].ToString());
            this.Close();
        }

        private void lvTipo_Click(object sender, EventArgs e)
        {
            carregarProdutos(lvTipo.FocusedItem.Text);
        }

        private void lvTipo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            carregarProdutos(lvTipo.FocusedItem.Text);

        }

        private void lvTipo_ItemActivate(object sender, EventArgs e)
        {
            lvCodigo.Focus();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                codigoProduto = Convert.ToInt16(lvCodigo.FocusedItem.Text);
                this.Close();
            }
            catch { };
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    btCancelar_Click(sender, e);
                    break;
                case Keys.Enter://Voltar Tela
                    btConfirmar_Click(sender, e);
                    break;
            }
        }

    }
}
