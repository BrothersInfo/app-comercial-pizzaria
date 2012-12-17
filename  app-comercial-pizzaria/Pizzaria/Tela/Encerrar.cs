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
    public partial class Encerrar : Form
    {
        int cod_venda;
        double valor;
        string[] mesas;
        VendaFull venda;

        //---
        double recebimento = 0;
        double desconto = 0;
        double troco = -1;
        public bool encerrou = false;
         public Encerrar(VendaFull vend) {
            venda = vend;
            InitializeComponent();
            carregandoTudo();
           // mtValor.Focus();
            posicionamento();
            
        }
         public bool isBalcao = false;
        public Encerrar(int cod_venda , double valor_venda, string [] mesa, bool balcao)
        {
            InitializeComponent();
            this.cod_venda = cod_venda;
            this.valor = valor_venda;
            carregandoTudo();
            mesas = mesa;
            //mtValor.Focus();
            posicionamento();
            isBalcao = balcao;
           
        }
        public void carregandoTudo()
        {
            lbTrocoNumero.Visible = false;
            lbTroco.Visible = false;
          //  mtValor.Text = "000.00";
            mtDesconto.Text = "000.00";
            if (venda == null)
                lbTotal.Text = "R$ " + new Tratamento().retornaValorEscrito(valor);
            else
            {
                lbTotal.Text = "R$ " + new Tratamento().retornaValorEscrito(venda.valorTotal);
                valor = venda.valorTotal;
            }
        }
        private void posicionamento()
        {
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr) + 345;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
        }

        private void btEncerrar_Click(object sender, EventArgs e)
        {
            if (troco >= 0)
            {
                if (venda == null)
                {
                    int pag;
                    if (rbDinheiro.Checked)
                        pag = 1;
                    else if (rbCredito.Checked)
                        pag = 2;
                    else if (rbDebito.Checked)
                        pag = 3;
                    else if (rbCheque.Checked)
                        pag = 4;
                    else pag = 5;
                    new BancoVenda().receber(pag, cod_venda);
                    new BancoVenda().encerrarVenda((valor - desconto), cod_venda, mesas,isBalcao);
                    new BancoVenda().atualizaSuper(new BancoVenda().consultaSuper(cod_venda), (valor - desconto));
                }
                else
                {
                    if (rbDinheiro.Checked)
                        venda.cod_pagamento = 1;
                    else if (rbCredito.Checked)
                        venda.cod_pagamento = 2;
                    else if (rbDebito.Checked)
                        venda.cod_pagamento = 3;
                    else if (rbCheque.Checked)
                        venda.cod_pagamento = 4;
                    else venda.cod_pagamento = 5;


                    new BancoVenda().novaMeiaVenda(venda);


                    new BancoVenda().atualizaSuper(venda.super, venda.valorTotal);

                }
                encerrou = true;
                this.Close();
            }
        }
      
        private void btAnular_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Encerrar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    btAnular_Click(sender, null);

                    break;
            }
        }

        private void mtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtDesconto.MaskFull && mtDesconto.Text == "000.00")
            {
                mtDesconto.Text = "";
                mtDesconto.Focus();
            }
            try
            {
                desconto = Convert.ToDouble(mtDesconto.Text.Replace('.', ','));
            }
            catch { }
        }
        
        private void mtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (mtValor.MaskFull && mtValor.Text == "000.00")
                {
                    mtValor.Text = "";
                    mtValor.Focus();
                }
                if (e.KeyChar == '\r')
                {

                    recebimento = Convert.ToDouble(mtValor.Text.Replace('.', ','));
                    troco = (recebimento - desconto) - valor;
                    if (troco >= 0)
                    {
                        lbTroco.Visible = true;
                        lbTrocoNumero.Visible = true;
                        lbTrocoNumero.Text = "RS " + new Tratamento().retornaValorEscrito(troco);
                        btEncerrar.Focus();
                    }
                    else
                    {
                        lbTroco.Visible = false;
                        lbTrocoNumero.Visible = false;
                        mtDesconto.Focus();
                    }

                }
            }
            catch
            {
                mtValor.ResetText();
                mtValor.Text = "000.00";
            }

        }

    }
}
