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

    public partial class AlterarForm : Form
    {
        public AlterarForm(short cod)
        {
            InitializeComponent();
            carregarAlterar();
            carregarCaixa();
            cod_caixa = cod;
        }
        short cod_caixa;
        private void btConfAlterar_Click(object sender, EventArgs e)
        {
            if (!tbAltNomeGarcon.Text.Equals(""))
            {
                if (!new BancoConsulta().existeGarcon(tbAltNomeGarcon.Text))
                {
                    alterarGarcon();
                    MessageBox.Show("Alteração realizada com Sucesso", "Alterar");
                }
            }
            else MessageBox.Show("Campo em branco, favor preencher para alterar", "Aviso");
            limparGarcon(); carregarAlterar();
        }       
        private void btAltSub_Click(object sender, EventArgs e)
        {

            if (!new BancoConsulta().existeTamanhoAll(tbAltSub.Text))
                alterarTamanho();
            limpaTamanho(); carregarAlterar();
        }
        private void btAltSeg_Click(object sender, EventArgs e)
        {
            if (!new BancoConsulta().existeTipoAll(tbAltSeg.Text))
                alterarTipo();
            limpaTipo(); carregarAlterar();
        }
        private void btAltMesa_Click(object sender, EventArgs e)
        {
            if (new BancoConsulta().existeMesaAll(cbAltMesa.Text))
                new BancoConsulta().alterarAmbienteDaMesa(cbAltNovoAmb.Text, cbAltMesa.Text, cBoxAltMesa.Checked);

            carregarAlterar();
        }
        private void btAltAmb_Click(object sender, EventArgs e)
        {
            if (!new BancoConsulta().existeAmbienteAll(tbAltAmb.Text))
                alterarAmbiente();
            limpaTipo(); carregarAlterar();
        }
        private void btAltCaixConfirmar_Click(object sender, EventArgs e)
        {
            if (new BancoConsulta().isAdm(new BancoConsulta().getNome_Caixa((int)cod_caixa)))
                new BancoConsulta().caixaOpcoes(cbCAQuadroAlterar.Text, tbCANomeAlterar.Text, tbCAIdAlterar.Text, tbCAPassAlterar.Text, cbCAAdm.Checked);
        }
        private void alterarTamanho()
        {
            if (!tbAltSub.Text.Equals(""))
                new BancoConsulta().alterarTamanho(cbAltSub.Text, tbAltSub.Text, cboxAltSub.Checked);
       
        }
        public void limpaTamanho()
        {
            tbAltSub.Clear();
        }
        public void carregarCaixa()
        {
            cbCAQuadroAlterar.DataSource = new BancoConsulta().descricaoCaixa();
            cbCAQuadroAlterar.DisplayMember = "nomecaixa";
            try { cbCAQuadroAlterar.SelectedIndex = 1; }
            catch { return; }
            cbCAQuadroAlterar.SelectedIndex = 0;
        }
        public void carregarAlterar()
        {
            //
            //garcon
            cbQuadroGarcon.DataSource = new BancoConsulta().descricaoGarcon();
            cbQuadroGarcon.DisplayMember = "nome";
            cbQuadroGarcon.SelectedIndex = 1;
            cbQuadroGarcon.SelectedIndex = 0;
            nGarcon = cbQuadroGarcon.Text;

            cbAltSub.DataSource = new BancoConsulta().descricaoTamanhoAll();
            cbAltSub.DisplayMember = "descricao";
            cbAltSub.SelectedIndex = 1;
            cbAltSub.SelectedIndex = 0;

          
            cbAltSeg.DataSource = new BancoConsulta().descricaoTipoAll();
            cbAltSeg.DisplayMember = "nome";
            cbAltSeg.SelectedIndex = 1;
            cbAltSeg.SelectedIndex = 0;

            cbAltMesa.DataSource = new BancoConsulta().descricaoMesa();
            cbAltMesa.DisplayMember = "descricao";
            cbAltMesa.SelectedIndex = 1;
            cbAltMesa.SelectedIndex = 0;

            cbAltNovoAmb.DataSource = new BancoConsulta().descricaoAmbiente();
            cbAltNovoAmb.DisplayMember = "descricao";
            cbAltNovoAmb.SelectedIndex = 1;
            cbAltNovoAmb.SelectedIndex = 0;

            cbAltAmb.DataSource = new BancoConsulta().descricaoAmbienteAll();
            cbAltAmb.DisplayMember = "descricao";
            cbAltAmb.SelectedIndex = 1;
            cbAltAmb.SelectedIndex = 0;


        }
        public void limparGarcon()
        {
            carregarAlterar();
            tbAltNomeGarcon.Clear();
        }
        public void alterarGarcon()
        {
            if (!tbAltNomeGarcon.Text.Equals(""))
                new BancoConsulta().alterarGarcon(cbQuadroGarcon.Text, tbAltNomeGarcon.Text, cboxGarconAlterarAtivo.Checked);
            else new BancoConsulta().alterarGarcon(cbQuadroGarcon.Text, cbQuadroGarcon.Text, cboxGarconAlterarAtivo.Checked);
        }
        private void alterarTipo()
        {
            if (!tbAltSeg.Text.Equals(""))
                new BancoConsulta().alterarTipo(cbAltSeg.Text, tbAltSeg.Text, cBoxAltSeg.Checked);
            else new BancoConsulta().alterarTipo(cbAltSeg.Text, cbAltSeg.Text, cBoxAltSeg.Checked);

        }
        public void limpaTipo()
        {
            tbAltSeg.Clear();
        }
        public void alterarAmbiente()
        {
            if (!tbAltAmb.Text.Equals(""))
                new BancoConsulta().alterarAmbiente(cbAltAmb.Text, tbAltAmb.Text, cBoxAltAmb.Checked);
            else new BancoConsulta().alterarAmbiente(cbAltAmb.Text, cbAltAmb.Text, cBoxAltAmb.Checked);
        }
        string nGarcon = "";

        private void cbQuadroGarcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nGarcon = cbQuadroGarcon.Text;
                bool xxxd = new BancoConsulta().getGarconAtivo(nGarcon);
                cboxGarconAlterarAtivo.Checked = xxxd;
            }
            catch
            {
                cboxGarconAlterarAtivo.Checked = new BancoConsulta().getGarconAtivo(new BancoVenda().nomeGarcon(1));
                return;
            }    
        }
       
        private void cbAltSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboxAltSub.Checked = new BancoConsulta().isTamanhoAtivo(cbAltSub.Text);
            }
            catch
            {
                return;
            }    
        }
        private void cbAltSeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxAltSeg.Checked = new BancoConsulta().isTipoAtivo(cbAltSeg.Text);
        }
        private void cbAltMesa_SelectedIndexChanged(object sender, EventArgs e)
        {

            cBoxAltMesa.Checked = new BancoConsulta().isMesaAtivo(cbAltMesa.Text);
            lbAltMesaOld.Text = new BancoConsulta().ambienteDaMesa(cbAltMesa.Text);
        }
        private void cbAltAmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxAltAmb.Checked = new BancoConsulta().isAmbienteAtivo(cbAltAmb.Text);
        }
        
             
        private void tbComanda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                tbNewDescricao.Text =
                    new Banco().preencherNomeProduct(Convert.ToInt16(tbNewCodigo.Text));
                cboxNewImpresso.Checked = 
                    new Banco().produtoIsImpresso(Convert.ToInt16(tbNewCodigo.Text));
                cboxNewAtivo.Checked
                    = new BancoConsulta().produtoIsAtivo(Convert.ToInt16(tbNewCodigo.Text));
                cbNewSegmento.DataSource
                    = new BancoConsulta().descricaoTamanho();
            cbCAQuadroAlterar.DisplayMember = "nomecaixa";
            try { cbCAQuadroAlterar.SelectedIndex = 1; }
            catch { return; }
            cbCAQuadroAlterar.SelectedIndex = 0;
                
            }
            catch
            {
                
                return;
            }
        }
        private void tbNewCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                btNewConfirmar.Visible = true;

                tbNewDescricao.Text =
                    new Banco().preencherNomeProdctAll(Convert.ToInt16(tbNewCodigo.Text));
                cboxNewImpresso.Checked =
                    new Banco().produtoIsImpresso(Convert.ToInt16(tbNewCodigo.Text));
                cboxNewAtivo.Checked
                    = new BancoConsulta().produtoIsAtivo(Convert.ToInt16(tbNewCodigo.Text));

                 string [] vari = new BancoConsulta().descricaoTipo();
                 cbNewSegmento.DataSource = vari;
                cbNewSegmento.DisplayMember 
                    = "nome";
                string segDoProduto = new Banco().segmentoDoProduto(Convert.ToInt16(tbNewCodigo.Text));
                for (int i = 0; i < vari.Length; i++)
                {
                    if (vari[i] == segDoProduto) {
                        cbNewSegmento.SelectedIndex = i;
                        break;
                    }
                }
                flpNewAlterar.Visible = false;
                flpNewMais.Visible = false;
                flpNewMenos.Visible = false;

            }
            catch
            {
                btNewConfirmar.Visible = false;
            }
        }
        private void btNewMais_Click(object sender, EventArgs e)
        {
            
        //tenho q carregar todos os tamanhos q nao estao contidos no produto
            try
            {

                flpNewMais.Visible = true;
                flpNewMenos.Visible = false;
                flpNewAlterar.Visible = false;
                cbNewTamanhoOpcao.DataSource = new Banco().subCategoriaNaoProduto(Convert.ToInt16(tbNewCodigo.Text));
                cbNewTamanhoOpcao.DisplayMember
                           = "descricao";
                cbNewSegmento.SelectedIndex = 0;
                btNewAdd.Visible = false;
                mtbNewValor.Clear();
            
            }
            catch { return; }
        }
        private void btNewMenos_Click(object sender, EventArgs e)
        {
            try
            {
           
                flpNewMais.Visible = false;
            flpNewMenos.Visible = true;
            flpNewAlterar.Visible = false;
            cbNewTamanhoDoProduto.DataSource = new Banco().subcategoriaProduto(Convert.ToInt16(tbNewCodigo.Text));
                   cbNewTamanhoDoProduto.DisplayMember
                           = "descricao";
                cbNewTamanhoDoProduto.SelectedIndex = 0;

                if (cbNewTamanhoDoProduto.Items.Count > 1)
                    btnewRemover.Visible = true;
                else btnewRemover.Visible = false;
            }
            catch { return; }

        }
        private void btNewAlterarSub_Click(object sender, EventArgs e)
        {
            try
            {
                flpNewMais.Visible = false;
                flpNewMenos.Visible = false;
                flpNewAlterar.Visible = true;
                cbNewAlterarSub.DataSource = new Banco().subcategoriaProduto(Convert.ToInt16(tbNewCodigo.Text));
                cbNewAlterarSub.DisplayMember
                        = "descricao";
                cbNewAlterarSub.SelectedIndex = 0;
                btNewAlterarConfir.Visible = false;
                mtbNewAlterarSub.Clear();
            }
            catch { return; }
        }
        private void mtbNewAlterarSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbNewAlterarSub.MaskFull)
                btNewAlterarConfir.Visible = true;
            else
                btNewAlterarConfir.Visible = false;
        }
        private void mtbNewValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbNewValor.MaskFull)
                btNewAdd.Visible = true;
            else 
                btNewAdd.Visible = false;
        }
        private void btNewAlterarConfir_Click(object sender, EventArgs e)
        {
            new Banco().alterarValorSubCategoria(Convert.ToInt16(tbNewCodigo.Text), new Banco().codTamanho(cbNewAlterarSub.Text), Convert.ToDouble(mtbNewAlterarSub.Text.Replace('.', ',')));
            flpNewAlterar.Visible = false;
        }
        private void btNewAdd_Click(object sender, EventArgs e)
        {
            new Banco().insereSubCategoria(Convert.ToInt16(tbNewCodigo.Text), new Banco().codTamanho(cbNewTamanhoOpcao.Text), Convert.ToDouble(mtbNewValor.Text.Replace('.', ',')));
            flpNewMais.Visible = false;
        }
        private void btnewRemover_Click(object sender, EventArgs e)
        {
            new Banco().removerSubCategoria(Convert.ToInt16(tbNewCodigo.Text), new Banco().codTamanho(cbNewTamanhoDoProduto.Text));
            flpNewMenos.Visible = false;
        }
        private void btNewConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                new Banco().alterarProduto(Convert.ToInt16(tbNewCodigo.Text), tbNewDescricao.Text, new BancoConsulta().cod_tipoPeloNome(cbNewSegmento.Text), cboxNewAtivo.Checked, cboxNewImpresso.Checked);
                MessageBox.Show("ALTERAÇÃO CONCLUIDA COM SUCESSO", "MENSAGEM");
                tbNewCodigo.Clear();
                tbNewCodigo.Focus();
            }
            catch { }
         
        }

        private void btNewDivisor_Click(object sender, EventArgs e)
        {
                  cbNewDivisor.DataSource = new BancoConsulta().descricaoDivisoresNoInTamanho(new Banco().codTamanho(cbAltSub.Text));
            cbNewDivisor.DisplayMember = "descricao";
            cbNewDivisor.SelectedIndex = 0;

            flp01.Visible = true;
            flp02.Visible = false;
            
        }

        private void btOldDivisor_Click(object sender, EventArgs e)
        {
            cbOldDivisor.DataSource = new BancoConsulta().descricaoDivisoresbyTamanho(new Banco().codTamanho(cbAltSub.Text));
            cbOldDivisor.DisplayMember = "descricao";
            cbOldDivisor.SelectedIndex = 0;
            flp02.Visible = true;
            flp01.Visible = false;
        }

        private void btAddDiv_Click(object sender, EventArgs e)
        {
            if (cbNewDivisor.Text.Length > 0)
            {
                new BancoConsulta().inserirTamanhoDivisor(new Banco().codTamanho(cbAltSub.Text), new BancoConsulta().cod_divisorByDescricao(cbNewDivisor.Text));
                MessageBox.Show("Alteração concluida com Sucesso!", "MESSAGEM", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btSubDiv_Click(object sender, EventArgs e)
        {
            if (cbOldDivisor.Text.Length > 0)
            {
                new BancoConsulta().removerTamanhoDivisor(new Banco().codTamanho(cbAltSub.Text),
                    new BancoConsulta().cod_divisorByDescricao(cbOldDivisor.Text));
                MessageBox.Show("Alteração concluida com Sucesso!","MESSAGEM"  ,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }



    }
}
