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
    public partial class CodigoProduto : Form
    {
        public CodigoProduto()
        {
            InitializeComponent();
            carregarTipos();
            lvTipo.Focus();
            lvTipo.Select();
            regularTamanho();
        //    cbTipo_SelectedIndexChanged(null, null);
            posicionamento();
        }
        private void posicionamento()
        {
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr) +150;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
        }
        
        public string getCodigoProduto()
        {
            return codigoProduto.ToString();
        }
        private int codigoProduto;
        public void regularTamanho()
        {

            this.categoria.Width = lvTipo.Width-25;
            this.Codigo.Width = (int)65;
            this.Produto.Width = this.lvCodigo.Width -90;
        }
        public void carregarTipos()
        {
            DataTable t = new DataTable();
            t = new Banco().carregarCodigo();
            for (int i = 0; i < t.Rows.Count; i++)
            {
                lvTipo.Items.Add(t.Rows[i].ItemArray.GetValue(0).ToString());
            }
        }
        public void carregarProdutos(string nome)
        {

            lvCodigo.Items.Clear();
            DataTable produtos = new Banco().carregarNomeProdutoPeloTipo(nome);
            for (int i = 0; i < produtos.Rows.Count; i++)
            {
                //codigo
                lvCodigo.Items.Add(produtos.Rows[i].ItemArray.GetValue(0).ToString());
                //nome            
                lvCodigo.Items[i].SubItems.Add(produtos.Rows[i].ItemArray.GetValue(1).ToString());
            }
        }

        private void lvCodigo_ItemActivate(object sender, EventArgs e)
        {
            codigoProduto = Convert.ToInt16(lvCodigo.FocusedItem.Text);
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
