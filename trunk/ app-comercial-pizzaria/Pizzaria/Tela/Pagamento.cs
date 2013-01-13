using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pizzaria.Banco;
using Pizzaria.Classes;
namespace Pizzaria.Tela
{
    public partial class Pagamento : Form
    {
        
        private void posicionamento()
        {
            double valr = Screen.PrimaryScreen.Bounds.Height / 100f;
            double yy = (13.5 * valr) + 345;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Size.Width) / 2, (int)yy);
        }
        int cod_venda;
        double valor;
        string[] mesas;
        VendaFull venda;

        //---
        double recebimento = 0;
         double desconto = 0;
        double troco = -1;
        public bool encerrou = false;
         public Pagamento(VendaFull vend) {
            venda = vend;
            InitializeComponent();
             carregandoTudo();
           // mtValor.Focus();
            posicionamento();
            
        }
         String str = string.Empty; 
         public bool isBalcao = false;
        public Pagamento(int cod_venda , double valor_venda, string [] mesa, bool balcao)
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
            else if (str.Length > 2 && str.Length <= 6)
            {
                campo.Text = str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2);
            }
         
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val >= 96 && Val <= 105) || (Val == 8) || (Val == 46));
        }
        private void tbValor_Enter(object sender, EventArgs e)
        {
            str = String.Empty;
            tbValor.ForeColor = Color.Red;
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                //devo 100
                //desconto 30
                //dei 90
                if (tbValor.Text.Length == 0) { tbValor.Focus(); return; }
                if (tbDesonto.Text.Length == 0) { tbDesonto.Focus(); return; }
                recebimento = Convert.ToDouble(tbValor.Text.Replace('.', ','));//90
                desconto = Convert.ToDouble(tbDesonto.Text.Replace('.', ','));

                troco = recebimento - (valor - desconto);
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

        private void tbValor_KeyUp(object sender, KeyEventArgs e)
        {
            FormatarValorMoeda(e, tbValor);
        }

        private void tbValor_Leave(object sender, EventArgs e)
        {

            if (tbValor.Text.Length == 0) { return; }
            if (tbDesonto.Text.Length == 0) { return; }
            recebimento = Convert.ToDouble(tbValor.Text.Replace('.', ','));//90
            desconto = Convert.ToDouble(tbDesonto.Text.Replace('.', ','));
            troco = recebimento - (valor - desconto);
    
            if (troco >= 0)
            {
                lbTroco.Visible = true;
                lbTrocoNumero.Visible = true;

                lbTrocoNumero.Text = "RS " + new Tratamento().retornaValorEscrito(troco);
                btEncerrar.Focus();
                tbValor.ForeColor = Color.Black;
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
            tbDesonto.ForeColor = Color.Red;
        }

        private void tbDesonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    if (tbValor.Text.Length == 0) { tbValor.Focus(); return; }
                    if (tbDesonto.Text.Length == 0) { tbDesonto.Focus(); return; }
                    recebimento = Convert.ToDouble(tbValor.Text.Replace('.', ','));//90
                    desconto = Convert.ToDouble(tbDesonto.Text.Replace('.', ','));

                    troco = recebimento- (valor- desconto);
               //     if (troco < 0) troco *= -1;
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
                catch { }
            }
        }

        private void tbDesonto_KeyUp(object sender, KeyEventArgs e)
        {
            FormatarValorMoeda(e, tbDesonto);
        }

        private void tbDesonto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tbValor.Text.Length == 0) { return; }
                if (tbDesonto.Text.Length == 0) { return; }
                recebimento = Convert.ToDouble(tbValor.Text.Replace('.', ','));//90
                desconto = Convert.ToDouble(tbDesonto.Text.Replace('.', ','));
                troco = recebimento - (valor - desconto);
           //     if (troco < 0) troco *= -1;
                if (troco >= 0)
                {
                    lbTroco.Visible = true;
                    lbTrocoNumero.Visible = true;
                    tbDesonto.ForeColor = Color.Black;
                    lbTrocoNumero.Text = "RS " + new Tratamento().retornaValorEscrito(troco);
                    btEncerrar.Focus();
                }
            }
            catch { }
        }

        private void btAnular_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEncerrar_Click(object sender, EventArgs e)
        {
            if (troco >= 0)
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
                new BancoVenda().encerrarVenda((valor - desconto), cod_venda, mesas, isBalcao);
                new BancoVenda().atualizaSuper(new BancoVenda().consultaSuper(cod_venda), (valor - desconto));
                VendaFull temp = new BancoVenda().carregaVenda(cod_venda);
                if (rbSim.Checked)
                {
                    Impressao p = new Impressao(temp);
                    p.gerarComandaNaoFiscal(new BancoVenda().formaPagamento(pag), recebimento, troco);
                }


                encerrou = true;
                this.Close();
            }
        }

        private void Pagamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    btAnular_Click(sender, null);

                    break;
            }
        }

        private void gbFormaPag_Enter(object sender, EventArgs e)
        {
            gbFormaPag.ForeColor = Color.Red;
        }

        private void gbFormaPag_Leave(object sender, EventArgs e)
        {
            gbFormaPag.ForeColor = Color.Black;
        }
     

    }
}
