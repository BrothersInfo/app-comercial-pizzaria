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
    public partial class RemoverProduto : Form
    {
        int[] cod; int []qtd;
        int cod_venda;
        public RemoverProduto(int cod_venda, int [] codigo, int [] qtd)
        {
            this.cod_venda = cod_venda;
            cod = codigo;
            this.qtd = qtd;
            InitializeComponent();
            mtProduto.Focus();
            posicionamento();
        }
        private void posicionamento()
        {
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr) + 345;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
        }

        public int quantidade(int codigo)
        {
            for (int i = 0; i < cod.Length; i++)
                if (cod[i] == codigo)
                   return qtd[i];
                return 0;
        }
        public bool existe(int codigo)
        {
            for (int i = 0; i < cod.Length; i++)
                if (cod[i] == codigo)
                    return true;
            return false;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (existe( cod[ Convert.ToInt16(mtProduto.Text)-1]   ))
            {
                if (numQuantidade.Value <= quantidade(cod[Convert.ToInt16(mtProduto.Text) - 1]))
                {
                    new BancoVenda().retirarProdutoOuQuantidade(cod_venda,
                                                               cod[Convert.ToInt16(mtProduto.Text) - 1],
                                                               quantidade(cod[Convert.ToInt16(mtProduto.Text) - 1]),
                                                               Convert.ToInt16(numQuantidade.Value));

                    MessageBox.Show("ALTERAÇÂO CONCLUIDA COM SUCESSO");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("QUANDITADE DE ITENS RETIRADOS ALÉM DA QUANTIA EXISTENTE ");
                }
            }
            else
            { MessageBox.Show("CODIGO NÃO IDENTIFICADO NESTA VENDA "); }

        }

        private void mtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && existe(cod[Convert.ToInt16(mtProduto.Text) - 1]))
            {
                numQuantidade.Maximum = quantidade(cod[Convert.ToInt16(mtProduto.Text) - 1]);
                btConfirmar_Click(sender, e);
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void RemoverProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {


                case Keys.Escape://Voltar Tela
                    btCancelar_Click(sender, null);
                    break;
            }
        }

    }
}
