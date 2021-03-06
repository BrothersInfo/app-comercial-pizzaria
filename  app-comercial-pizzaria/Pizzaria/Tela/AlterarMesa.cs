﻿using System;
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
    public partial class AlterarMesa : Form
    {
        List<ListViewItem> conjItem = new List<ListViewItem>();
        public AlterarMesa(int cod_venda){
            this.cod_venda = cod_venda;
            InitializeComponent();
            trocaMesa();
            posicionamento();
            agrupar = false;
        }
        public bool agrupar;
        public AlterarMesa()
        {
            InitializeComponent();
            agruparVenda();
            agrupar = true;
            posicionamento(); cod_venda = 0;
        }
        public void trocaMesa(){
            troca = true;
            listVenda.Clear();
            listVenda.LargeImageList = imageList1;

            string[] mesa = new Banco().mesasDisponiveis();
            for (int i = 0; i < mesa.Length; i++)
            {
                conjItem.Add(new ListViewItem(mesa[i], 4));
                listVenda.Items.Add(conjItem.Last());
            }
            listVenda.AllowColumnReorder = true;
            listVenda.FullRowSelect = true;
            listVenda.GridLines = true;
            listVenda.CheckBoxes = true;

        }
        public void agruparVenda()
        {
            troca = true;
            listVenda.Clear();
            listVenda.LargeImageList = imageList1;

            string[] mesa = new Banco().mesasIndisponiveis();
            for (int i = 0; i < mesa.Length; i++)
            {
                conjItem.Add(new ListViewItem(mesa[i], 4));
                listVenda.Items.Add(conjItem.Last());
            }
            listVenda.AllowColumnReorder = true;
            listVenda.FullRowSelect = true;
            listVenda.GridLines = true;
            listVenda.CheckBoxes = true;

        }
        public bool troca = false;
        public AlterarMesa(bool retira, int cod_venda)
        {
            this.retira = retira;
            this.cod_venda = cod_venda;
            InitializeComponent();
            atualiza();
            posicionamento();
        }
        bool retira;
        public int cod_venda;

        public void atualiza()
        {
            if (retira)
            {
                listVenda.Clear();
                listVenda.LargeImageList = imageList1;

                string[] mesa = new BancoVenda().mesasDaVenda(cod_venda);
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
                this.btConfirmar.BackgroundImage = global::Pizzaria.Properties.Resources.BTnewAvancar;
                //       btConfirmar.BackgroundImage = this.BackgroundImage.
            }
            else
            {
                listVenda.Clear();
                listVenda.LargeImageList = imageList1;

                string[] mesa = new Banco().mesasDisponiveis();
                for (int i = 0; i < mesa.Length; i++)
                {
                    conjItem.Add(new ListViewItem(mesa[i], 4));
                    listVenda.Items.Add(conjItem.Last());
                }  
                listVenda.AllowColumnReorder = true;
                listVenda.FullRowSelect = true;
                listVenda.GridLines = true;
                listVenda.CheckBoxes = true;

            }

        }
        private void posicionamento()
        {
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr) + 345;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
        }
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (agrupar) {
                if (listVenda.CheckedItems.Count < 2) MessageBox.Show("Selecione duas ou mais vendas para Uni-las", "MENSAGEM");
                else
                {string [] mesas =  new string [listVenda.CheckedItems.Count];
                    for (int i = 0; i < listVenda.CheckedItems.Count; i++)
                        mesas [i]= (listVenda.CheckedItems[i].Text);
                    new BancoVenda().unirVendas(mesas, (cbMista.Text));
                 cod_venda =    new Banco().codigoDaVendaPelaMesa(cbMista.Text);
                 new BancoInformacao().unirProdutosIguais(new BancoVenda().carregaVenda(cod_venda));
                }
            }
            else 
            if (!troca)
                for (int i = 0; i < listVenda.CheckedItems.Count; i++)
                {
                    if (retira) new BancoVenda().removerMesaIntoVenda(cod_venda, new BancoVenda().codMesaPelaDescricao(listVenda.CheckedItems[i].Text));
                    else new BancoVenda().inserirMesaIntoVenda(cod_venda, new BancoVenda().codMesaPelaDescricao(listVenda.CheckedItems[i].Text));
                }
            else
            {
                if (listVenda.CheckedItems.Count > 0)
                {
                    string[] mesa = new BancoVenda().mesasDaVenda(cod_venda);
                    for (int i = 0; i < listVenda.CheckedItems.Count; i++)
                        new BancoVenda().inserirMesaIntoVenda(cod_venda, new BancoVenda().codMesaPelaDescricao(listVenda.CheckedItems[i].Text));
                    for (int i = 0; i < mesa.Length; i++)
                        new BancoVenda().removerMesaIntoVenda(cod_venda, new BancoVenda().codMesaPelaDescricao(mesa[i]));
                }
            }
            this.Close();

        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AlterarMesa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter://Encerrar venda
                    btConfirmar_Click(sender, null);
                    break;
                case Keys.Escape://Encerrar venda
                    btCancelar_Click(sender, null);
                    break;
            }
        }

        private void listVenda_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            cbMista.DataSource = null;
            string [] mesas =  new string [listVenda.CheckedItems.Count];
                    for (int i = 0; i < listVenda.CheckedItems.Count; i++)
                        mesas [i]= (listVenda.CheckedItems[i].Text);
            cbMista.DataSource = mesas;
            cbMista.DisplayMember = "descricao";
         //   cbMista.SelectedIndex = 0;
        if(agrupar)
            if (listVenda.CheckedItems.Count >= 2) { cbMista.Visible = true; lbMista.Visible = true; }
            else  { cbMista.Visible = false; lbMista.Visible = false;}

        }
    }
}
