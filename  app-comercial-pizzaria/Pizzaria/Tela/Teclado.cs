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
    public partial class Teclado : Form
    {
        public Teclado()
        {
            InitializeComponent();
        }

        public string retorno = "";

        private void bUm_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 1;
            preencherNomeProduto();
        }
        private void bDois_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 2;
            preencherNomeProduto();
        }
        private void bTres_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 3;
            preencherNomeProduto();
        }
        private void bQuatro_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 4; preencherNomeProduto();
        }
        private void bCinco_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 5; preencherNomeProduto();
        }
        private void bSeis_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 6; preencherNomeProduto();
        }
        private void bSete_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 7; preencherNomeProduto();
        }
        private void bOito_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 8; preencherNomeProduto();
        }
        private void bNove_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 9; preencherNomeProduto();
        }
        public void preencherNomeProduto()
        {
            try
            {
                lSabor.Text = new Banco.Banco().preencherNomeProduct(Convert.ToInt16(lResultado.Text));
            }
            catch { lSabor.Text = ""; return; }
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                lResultado.Text = lResultado.Text.Substring(0, lResultado.Text.Length - 1); preencherNomeProduto();
            }
            catch { lResultado.Text = ""; return; }
            }

        private void bApagar_Click(object sender, EventArgs e)
        {
            lResultado.Text = ""; preencherNomeProduto();
        }

        private void bZero_Click(object sender, EventArgs e)
        {
            lResultado.Text = lResultado.Text + 0; preencherNomeProduto();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            retorno = "";
            this.Close();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            retorno = lResultado.Text;
            this.Close();
        }


    }
}
