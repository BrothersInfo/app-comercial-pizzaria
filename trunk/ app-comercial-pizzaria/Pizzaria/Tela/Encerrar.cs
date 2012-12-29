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
                    VendaFull temp = new BancoVenda().carregaVenda(cod_venda);
                    if (rbSim.Checked)
                    {
                        Impressao p = new Impressao(temp);
                        p.gerarComandaNaoFiscal(new BancoVenda().formaPagamento(pag), recebimento, troco);
                    }
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
                    if (rbSim.Checked)
                    {
                        Impressao p = new Impressao(new BancoVenda().carregaVenda(venda.cod_venda));
                        p.gerarComandaNaoFiscal(new BancoVenda().formaPagamento(venda.cod_pagamento), recebimento, troco);
                    }
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

     
        

        /// <summary>
        /// --- NOVOS
        /// </summary>
        /// <param name="Val"></param>
        /// <returns></returns>
        String str = string.Empty; 


        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val >= 96 && Val <= 105) || (Val == 8) || (Val == 46));
        }
       
       private void FormatarValorMoeda(KeyEventArgs e, TextBox campo)
        {
            int KeyCode = e.KeyValue;
            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    KeyCode = (int)Keys.D0;
                    break;
                case Keys.NumPad1:
                    KeyCode = (int)Keys.D1;
                    break;
                case Keys.NumPad2:
                    KeyCode = (int)Keys.D2;
                    break;
                case Keys.NumPad3:
                    KeyCode = (int)Keys.D3;
                    break;
                case Keys.NumPad4:
                    KeyCode = (int)Keys.D4;
                    break;
                case Keys.NumPad5:
                    KeyCode = (int)Keys.D5;
                    break;
                case Keys.NumPad6:
                    KeyCode = (int)Keys.D6;
                    break;
                case Keys.NumPad7:
                    KeyCode = (int)Keys.D7;
                    break;
                case Keys.NumPad8:
                    KeyCode = (int)Keys.D8;
                    break;
                case Keys.NumPad9:
                    KeyCode = (int)Keys.D9;
                    break;
            }


            if (((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back)))
            {
                str = str + Convert.ToChar(KeyCode);
            }
            if (str.Length == 0)
            {
                campo.Text = "";
            }

            if (str.Length == 1)
            {
                campo.Text = "0,0" + str;
            }
            else if (str.Length == 2)
            {
                campo.Text = "0," + str;
            }
            else if (str.Length > 2 && str.Length <= 5)
            {
                campo.Text = str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2);
            }
         
        }
    
      
        private void textBox1_Enter(object sender, EventArgs e)
        {
            str = String.Empty;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            FormatarValorMoeda(e, tbValor);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {


                recebimento = Convert.ToDouble(tbValor.Text.Replace('.', ','));
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
                    tbDesonto.Focus();
                }

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           

                recebimento = Convert.ToDouble(tbValor.Text.Replace('.', ','));
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
                    tbDesonto.Focus();
                }

            
        }

        private void tbDesonto_Enter(object sender, EventArgs e)
        {
            str = String.Empty;
        }

        private void tbDesonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            try
            {
                desconto = Convert.ToDouble(tbDesonto.Text.Replace('.', ','));
            }
            catch { }
        }

        private void tbDesonto_KeyUp(object sender, KeyEventArgs e)
        {
            FormatarValorMoeda(e, tbDesonto);
        }

        private void tbDesonto_Leave(object sender, EventArgs e)
        {
            try
            {
                desconto = Convert.ToDouble(tbDesonto.Text.Replace('.', ','));
            }
            catch { }
        }
        }
}
