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
    
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
        }

        public int cod_caixa= 0 ;
        public bool isAdm = false;
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (new Banco().temUsuario(tbUsuario.Text, tbSenha.Text))
            {
                cod_caixa = new Banco().cod_caixaByNome(tbUsuario.Text);
                if (new Banco().isAdm(tbUsuario.Text, tbSenha.Text))
                {
                    isAdm = true;
                    this.Close();
                }
                else
                {
                    isAdm = false;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Senha e/ou usuário inválidos", "Aviso Loggin");
            }
            
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                tbSenha.Focus();
            }
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btConfirmar.Focus();
                btConfirmar_Click(sender, null);
            }
        }

        private void btAnular_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
       

        
    }
}
