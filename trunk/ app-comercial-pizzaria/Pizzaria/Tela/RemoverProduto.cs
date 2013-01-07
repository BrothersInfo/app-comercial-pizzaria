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
    public partial class RemoverProduto : Form
    {
        int[] codigosCompleto; int []qtd;
        int cod_venda;
        public RemoverProduto(int cod_venda, int [] codigo, int [] qtd)
        {
            this.cod_venda = cod_venda;
            codigosCompleto = codigo;
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
            for (int i = 0; i < codigosCompleto.Length; i++)
                if (codigosCompleto[i] == codigo)
                   return qtd[i];
                return 0;
        }
        public bool existe(int codigo)
        {
            for (int i = 0; i < codigosCompleto.Length; i++)
                if (codigosCompleto[i] == codigo)
                    return true;
            return false;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (existe( codigosCompleto[ Convert.ToInt16(mtProduto.Text)-1]   ))
            {
 
                if (numQuantidade.Value <= quantidade(codigosCompleto[Convert.ToInt16(mtProduto.Text) - 1]))
                {
                    new BancoInformacao().deletarCompleto(codigosCompleto[Convert.ToInt16(mtProduto.Text) - 1],
                         Convert.ToInt16(numQuantidade.Value));

                    MessageBox.Show("ALTERAÇÂO CONCLUIDA COM SUCESSO", "MENSAGEM");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("QUANDITADE DE ITENS RETIRADOS ALÉM DA QUANTIA EXISTENTE ","MENSAGEM DE ERRO");
                }
            }
            else
            { MessageBox.Show("CODIGO NÃO IDENTIFICADO NESTA VENDA ", "MENSAGEM DE ERRO"); }

        }

        private void mtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && existe(codigosCompleto[Convert.ToInt16(mtProduto.Text) - 1]))
            {
                numQuantidade.Maximum = quantidade(codigosCompleto[Convert.ToInt16(mtProduto.Text) - 1]);
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
