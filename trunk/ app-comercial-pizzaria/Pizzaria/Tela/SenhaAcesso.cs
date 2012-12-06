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

    }
}
