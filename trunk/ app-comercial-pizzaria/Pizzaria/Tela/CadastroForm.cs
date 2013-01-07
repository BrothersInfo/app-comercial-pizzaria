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
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
            carregarCaixaTamanho();
            carregarAmbiente();
        }
     
        public void carregarCaixaTamanho()
        {
            while (cLboxTamanho.Items.Count > 0)
                cLboxTamanho.Items.RemoveAt(0);


            DataTable t = new BancoConsulta().descricaoTamanho();
            for (int i = 0; i < t.Rows.Count; i++)
            {
                cLboxTamanho.Items.Add(t.Rows[i].ItemArray.GetValue(0));

            }
            cbProdCategoria.DataSource = new BancoConsulta().descricaoTipo();
            cbProdCategoria.DisplayMember = "nome";
            cbProdCategoria.SelectedIndex = 1;
            cbProdCategoria.SelectedIndex = 0;


            cbCadSubDivis.DataSource = new BancoConsulta().descricaoDivisores();
            cbCadSubDivis.DisplayMember = "descricao";
            cbCadSubDivis.SelectedIndex = 1;
            cbCadSubDivis.SelectedIndex = 0;

        }
        public void pProduto()
        {

            carregarCaixaTamanho();
            bgValores.Visible = false;
            bgAlterarTamanho.Visible = true;
            tbNome.Focus();
            tbNome.Clear();
            //----
        }
        Tamanho[] t; int ii = 0;
       

        private void mtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    btContinue_Click(sender, null);
                }

            }
            catch { }
        }
        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    btConf_Click(sender, null);
                }

            }
            catch { }
        }
      
    //-----------cad
        
        public void limparTudoCaixaGarc()
        {

            tbNome.Clear();
            tbCCPass.Clear();
            tbCCNome.Clear();
            tbCCId.Clear();
            tbNewGarcon.Clear();

        }
        public void limparTudoTamanhoTipo()
        {

            tbNovoTipo.Clear();
            tbCadTamNome.Clear();

        }
        public void limparTudoMesaAmbi()
        {
            tbNovoAmbiente.Clear();
        }

        private void btConf_Click(object sender, EventArgs e)
        {
            if (!new BancoConsulta().existeProdudo(tbNome.Text) && cLboxTamanho.CheckedItems.Count > 0)
            {
                t = new Tamanho[cLboxTamanho.CheckedItems.Count];

                for (int i = 0; i < t.Length; i++)
                {
                    t[i] = new Tamanho();
                    t[i].setCodigo(cLboxTamanho.CheckedItems[i].ToString());
                }
                bgValores.Visible = true;
                bgAlterarTamanho.Visible = false;
                lbTamanho.Text = t[0].nome2;
                lbProduto.Text = tbNome.Text;
                MessageBox.Show("Cadastro Realizado com Sucesso", "Cadastro");
            }
            else MessageBox.Show("PRODUTO JA EXISTENTE");
        }
        private void btContinue_Click(object sender, EventArgs e)
        {
            t[ii].valor = new Tratamento().stringToDouble(mtValor.Text);
            try
            {
                lbTamanho.Text = t[++ii].nome2;
                mtValor.Clear();
            }
            catch
            {
                new BancoConsulta().cadastrarProduto(tbNome.Text, cbProdCategoria.Text, t,cbComanda.Checked);
                bgValores.Visible = false;
                bgAlterarTamanho.Visible = true;
                ii = 0;
                mtValor.Clear();
                tbNome.Clear();
                cLboxTamanho.ClearSelected();
            }
        }
        private void btConfCadastro_Click(object sender, EventArgs e)
        {
            if (!tbNewGarcon.Text.Equals(""))
            {
                if (!new BancoConsulta().existeGarcon(tbNewGarcon.Text))
                {
                    new BancoConsulta().novoGarcon(tbNewGarcon.Text);
                    MessageBox.Show("Cadastro Realizado com Sucesso", "Cadastro");
                }
            }
            else
                MessageBox.Show("Campo Vazio, Preencha para realizar Cadastro", "Aviso");            
            limparTudoCaixaGarc();
        }
        private void btCadCaixConfirm_Click(object sender, EventArgs e)
        {
            if (!new BancoConsulta().existeCaixa(tbCCNome.Text, tbCCId.Text))
            {
                new BancoConsulta().novoCaixa(tbCCNome.Text, tbCCId.Text, tbCCPass.Text, cbCCAdm.Checked);
                MessageBox.Show("Cadastro Realizado com Sucesso", "Cadastro");
            }
            else MessageBox.Show("USUARIO/ID EXISTENTE");
            limparTudoCaixaGarc();
        }
        private void btCadTamanho_Click(object sender, EventArgs e)
        {
            if (!tbCadTamNome.Text.Equals(""))
            {
                if (!new BancoConsulta().existeTamanho(tbCadTamNome.Text))
                {
                    new BancoConsulta().novoTamanho(tbCadTamNome.Text, new BancoConsulta().cod_divisorByDescricao(cbCadSubDivis.Text));
                    MessageBox.Show("Cadastro Realizado com Sucesso", "Cadastro");
                }
            }
            else MessageBox.Show("Campo Vazio, Preencha para realizar Cadastro", "Aviso");    
            limparTudoTamanhoTipo();
        }
        private void btCadTipCadastrar_Click(object sender, EventArgs e)
        {
            if (!tbNovoTipo.Text.Equals(""))
            {
                if (!new BancoConsulta().existeTipo(tbNovoTipo.Text))
                {
                    new BancoConsulta().novoTipo(tbNovoTipo.Text);
                    MessageBox.Show("Cadastro Realizado com Sucesso", "Cadastro");
                }
            }
            else MessageBox.Show("Campo Vazio, Preencha para realizar Cadastro", "Aviso"); 
            limparTudoTamanhoTipo();
        }
        private void btMesaCad_Click(object sender, EventArgs e)
        {
            if (!cbAmbiente.Text.Equals(""))
            {
                new BancoConsulta().novaMesa( cbAmbiente.Text);
                MessageBox.Show("Cadastro Realizado com Sucesso", "Cadastro");
            }
            else MessageBox.Show("Campo Vazio, Preencha para realizar Cadastro", "Aviso");
            
            limparTudoMesaAmbi();
        }        
        private void btCadAmbCadastrar_Click(object sender, EventArgs e)
        {
            if (!tbNovoAmbiente.Text.Equals(""))
            {
                if (!new BancoConsulta().existeAmbiente(tbNovoAmbiente.Text))
                {
                    new BancoConsulta().novoAmbiente(tbNovoAmbiente.Text);
                    MessageBox.Show("Cadastro Realizado com Sucesso", "Cadastro");
                }
            }
            else MessageBox.Show("Campo Vazio, Preencha para realizar Cadastro", "Aviso");
            limparTudoMesaAmbi();
        }

        public void carregarAmbiente()
        {
            cbAmbiente.DataSource = new BancoConsulta().descricaoAmbiente();
            cbAmbiente.DisplayMember = "descricao";
            cbAmbiente.SelectedIndex = 1;
            cbAmbiente.SelectedIndex = 0;
        }
    
    }
}
