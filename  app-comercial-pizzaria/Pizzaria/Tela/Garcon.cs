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
    public partial class Garcon : Form
    {
        public Garcon(int cod_venda)
        {
            InitializeComponent();
            carregar(cod_venda);
        }
        private string retorno;
        private void carregar(int cod_venda)
        {
            List<ListViewItem> conjItem;
            try
            {
                DataTable t = new Banco().GarconDaVenda(cod_venda);
                //   DataTable t = new Banco().informacoes("Mesa 25");
                listVenda.Items.Clear();

                listVenda.LargeImageList = imageList1;
                conjItem = new List<ListViewItem>();

                for (int i = 0; i < t.Rows.Count; i++)
                {   
                    conjItem.Add(new ListViewItem(t.Rows[i].ItemArray.GetValue(1).ToString(), 0));
                    listVenda.Items.Add(conjItem.Last());
                }
                listVenda.AllowColumnReorder = true;
                listVenda.FullRowSelect = true;
                listVenda.GridLines = true;
            }
            catch { return; }

        }
        public int getRetorno()
        {
            return new Banco().codGarconByNome(retorno);
        }
           
        private void listVenda_ItemActivate(object sender, EventArgs e)
        {
             retorno = listVenda.FocusedItem.Text;
             this.Close();

        }

        private void Garcon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    retorno = null;

                    this.Close();
                    break;
            }
        }

        private void bUnico_Click(object sender, EventArgs e)
        {
            retorno = null;
            this.Close();
        }
    }
}
