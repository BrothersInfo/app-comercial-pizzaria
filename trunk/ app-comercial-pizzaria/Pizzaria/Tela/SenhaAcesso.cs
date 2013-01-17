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
    public partial class SenhaAcesso : Form
    {
        public SenhaAcesso()
        {
            InitializeComponent();
        }
        public bool acesso = false;
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (new Banco.Banco().isAdm(tbUsuario.Text, tbSenha.Text))
            {
                acesso = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("SENHA INVALIDA OU USUARIO NÃO AUTORIZADO");
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btConfirmar.Focus();
                btConfirmar_Click(sender, null);
            }
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                tbSenha.Focus();
            }
        }

        private void SenhaAcesso_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Escape://MANUTENCAO
                    this.Close();
                    break;
                
            }
        }

    }
}
