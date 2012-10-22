using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class AlterarForm : Form
    {
        public AlterarForm()
        {
            InitializeComponent();
            carregarAlterar();
            carregarCaixa();
        }
        short cod_caixa;
        private void btConfAlterar_Click(object sender, EventArgs e)
        {
            if (!new BancoConsulta().existeGarcon(tbAltNomeGarcon.Text))
                alterarGarcon();
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

        private void btAltProdAtivo_Click(object sender, EventArgs e)
        {
            if (!lbProdAltNome.Text.Equals(""))
                new BancoConsulta().produtoAlterarAll(Convert.ToInt16(tbAlterarProdCod1.Text),
                    lbProdAltNome.Text, new BancoConsulta().cod_tipoPeloNome(new Banco().categoriaProdutoAll(Convert.ToInt16(tbAlterarProdCod1.Text))), cbAltProdAtivo.Checked);
        }
        private void btAltCaixConfirmar_Click(object sender, EventArgs e)
        {
            if (new BancoConsulta().isAdm(new BancoConsulta().getNome_Caixa((int)cod_caixa)))
                new BancoConsulta().caixaOpcoes(cbCAQuadroAlterar.Text, tbCANomeAlterar.Text, tbCAIdAlterar.Text, tbCAPassAlterar.Text, cbCAAdm.Checked);
        }
        private void btAltProdSeg_Click(object sender, EventArgs e)
        {
            try
            {
                if (new BancoConsulta().prodExiste(Convert.ToInt16(tbAltProdSegCodProd.Text)))
                {
                    int a = Convert.ToInt16(tbAltProdSegCodProd.Text);//codigo
                    string b = lbAltProdSeg.Text;
                    int c = new BancoConsulta().cod_tipoPeloNome(cbAltProdSegTipo.Text);
                    bool d = new BancoConsulta().produtoIsAtivo(Convert.ToInt16(tbAltProdSegCodProd.Text));
                    new BancoConsulta().produtoAlterarAll(a, b, c, d);
                }
                tbAltProdSegCodProd.Clear();
                lbAltProdSeg.Text = "";
                tbAltProdSegCodProd.Focus();
                lbSegmentoAtual.Text = "";
                cbAltProdSegTipo.DataSource = null;
            }
            catch
            {
                tbAltProdSegCodProd.Clear();
                lbAltProdSeg.Text = "";
                tbAltProdSegCodProd.Focus();
                lbSegmentoAtual.Text = "";
                cbAltProdSegTipo.DataSource = null;
                return;
            }
        }
        private void btAltProdNome_Click(object sender, EventArgs e)
        {
            if (new BancoConsulta().prodExiste(Convert.ToInt16(tbProdAltNomeCod.Text))
            && !new BancoConsulta().existeProdudo(tbProdAltNomeNovo.Text))
            {
                int a = Convert.ToInt16(tbProdAltNomeCod.Text);
                string b = tbProdAltNomeNovo.Text;
                int c = new BancoConsulta().cod_tipoPeloNome(new Banco().categoriaProdutoAll(a));
                bool d = new BancoConsulta().produtoIsAtivo(Convert.ToInt16(tbProdAltNomeCod.Text));
                new BancoConsulta().produtoAlterarAll(a, b, c, d);
            }
            tbProdAltNomeCod.Clear();
            tbProdAltNomeNovo.Clear();
            lProdAltNomeAntigo.Text = "";
        }
        private void btAltProdNewValCat_Click(object sender, EventArgs e)
        {
            t[ii].valor = new Tratamento().stringToDouble(mtValor1.Text);
            try
            {
                lbTamanho1.Text = t[++ii].nome2;
                mtValor1.Clear();
            }
            catch
            {
                new BancoConsulta().alterarTamanhoDoProduto(lbProduto1.Text, t);
                gBoxProdAlt55.Visible = false;
                gBoxProdAlt5.Visible = true;
                ii = 0;
                mtValor1.Clear();
                lbProduto1.Text = "";
                clbSegmento.ClearSelected();
                return;
            }
        }
        int ii = 0;
        Tamanho [] t;
        private void btAltProdSegUpdat_Click(object sender, EventArgs e)
        {
            if (new BancoConsulta().existeProdudo(lbAltSeg.Text) && clbSegmento.CheckedItems.Count > 0)
            {
                t = new Tamanho[clbSegmento.CheckedItems.Count];

                for (int i = 0; i < t.Length; i++)
                {
                    t[i] = new Tamanho();
                    t[i].setCodigo(clbSegmento.CheckedItems[i].ToString());
                }
            }
            gBoxProdAlt55.Visible = true;
            gBoxProdAlt5.Visible = false;
            lbTamanho1.Text = t[0].nome2;
            lbProduto1.Text = lbAltSeg.Text;
        }
        private void btProdAltValor_Click(object sender, EventArgs e)
        {
            try
            {
                new Banco().alterarValor(Convert.ToInt16(tbAltProdValCodProd.Text), new Banco().codTamanho(cbAltProdValTamanho.Text), new Tratamento().stringToDouble(mtbAltProdValor.Text));
                tbAltProdValCodProd.Clear();
                tbAltProdValCodProd.Focus();
                mtbAltProdValor.Clear();
            }
            catch
            {
                tbAltProdValCodProd.Clear();
                tbAltProdValCodProd.Focus();
                mtbAltProdValor.Clear();

            }
        }

        private void btClick1_Click(object sender, EventArgs e)
        {
            gBoxProdAlt1.Visible = true;
            gBoxProdAlt2.Visible = false;
            gBoxProdAlt3.Visible = false;
            gBoxProdAlt4.Visible = false;
            gBoxProdAlt5.Visible = false;
        }
        private void btClick2_Click(object sender, EventArgs e)
        {
            gBoxProdAlt1.Visible = false;
            gBoxProdAlt2.Visible = true;
            gBoxProdAlt3.Visible = false;
            gBoxProdAlt4.Visible = false;
            gBoxProdAlt5.Visible = false;
        }
        private void btClick3_Click(object sender, EventArgs e)
        {
            gBoxProdAlt1.Visible = false;
            gBoxProdAlt2.Visible = false;
            gBoxProdAlt3.Visible = true;
            gBoxProdAlt4.Visible = false;
            gBoxProdAlt5.Visible = false;
        }
        private void btClick4_Click(object sender, EventArgs e)
        {
            gBoxProdAlt1.Visible = false;
            gBoxProdAlt2.Visible = false;
            gBoxProdAlt3.Visible = false;
            gBoxProdAlt4.Visible = true;
            gBoxProdAlt5.Visible = false;
        }
        private void btClick5_Click(object sender, EventArgs e)
        {
            gBoxProdAlt1.Visible = false;
            gBoxProdAlt2.Visible = false;
            gBoxProdAlt3.Visible = false;
            gBoxProdAlt4.Visible = false;
            gBoxProdAlt5.Visible = true;
        }

        private void alterarTamanho()
        {
            if (!tbAltSub.Text.Equals(""))
                new BancoConsulta().alterarTamanho(cbAltSub.Text, tbAltSub.Text, cboxAltSub.Checked);
            else new BancoConsulta().alterarTamanho(cbAltSub.Text, cbAltSub.Text, cboxAltSub.Checked);

        }
        public void limpaTamanho()
        {
            tbAltSub.Clear();
        }
        public void carregarCaixaTamanhoAlt()
        {
            while (clbSegmento.Items.Count > 0)
                clbSegmento.Items.RemoveAt(0);

            try
            {
                lbAltSeg.Text = new Banco().preencherNomeProdutoAlt(Convert.ToInt16(tbAltProSegCod.Text));
                DataTable t = new BancoConsulta().descricaoTamanho();
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    int b = Convert.ToInt16(tbAltProSegCod.Text);
                    int c = new Banco().codTamanho(t.Rows[i].ItemArray.GetValue(0).ToString());

                    bool a = new BancoConsulta().isTamanhoAtivo(b, c);

                    clbSegmento.Items.Add(t.Rows[i].ItemArray.GetValue(0), a);

                }
            }
            catch
            {
                lbAltSeg.Text = "";
                return;
            }

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
        private void cbAltProdValTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double variant = new Banco().valorProduto(Convert.ToInt16(tbAltProdValCodProd.Text), (cbAltProdValTamanho.Text));


                if (variant < 10) mtbAltProdValor.Mask = "0.00";
                else
                    if (variant < 100 && variant >= 10) mtbAltProdValor.Mask = "00.00";
                    else if (variant >= 100) mtbAltProdValor.Mask = "000.00";

                mtbAltProdValor.Text = new Tratamento().retornaValorEscrito(variant);
            }
            catch { return; }
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
       
        
        private void tbAlterarProdCod1_KeyUp(object sender, KeyEventArgs e) 
        {
            try
            {
                cbAltProdAtivo.Checked
                     = new BancoConsulta().produtoIsAtivo(Convert.ToInt16(tbAlterarProdCod1.Text));
                lbProdAltNome.Text = new Banco().preencherNomeProdutoAlt(Convert.ToInt16(tbAlterarProdCod1.Text));

            }
            catch
            {
                tbAlterarProdCod1.Clear();
                lbProdAltNome.Text = "";
                return;
            }
        }
        private void tbProdAltNomeCod_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                lProdAltNomeAntigo.Text = new Banco().preencherNomeProdutoAlt(Convert.ToInt16(tbProdAltNomeCod.Text));

            }
            catch
            {
                tbProdAltNomeCod.Clear();
                lProdAltNomeAntigo.Text = "";
                return;
            }
        }
        private void tbAltProdValCodProd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                cbAltProdValTamanho.DataSource = new Banco().tamanhoProduto(Convert.ToInt16(tbAltProdValCodProd.Text));
                cbAltProdValTamanho.DisplayMember = "descricao";
                cbAltProdValTamanho.SelectedIndex = 0;
                double t = new Banco().valorProduto(Convert.ToInt16(tbAltProdValCodProd.Text), (cbAltProdValTamanho.Text));


                if (t < 10) mtbAltProdValor.Mask = "0.00";
                else
                    if (t < 100 && t >= 10) mtbAltProdValor.Mask = "00.00";
                    else if (t >= 100) mtbAltProdValor.Mask = "000.00";
                lbAltProdValNome.Text = new Banco().preencherNomeProdutoAlt(Convert.ToInt16(tbAltProdValCodProd.Text));
                mtbAltProdValor.Text = new Tratamento().retornaValorEscrito(t);
            }
            catch
            {
                cbAltProdValTamanho.DataSource = null;
                lbAltProdValNome.Text = "";
                tbAltProdValCodProd.Clear();
                tbAltProdValCodProd.Focus();
                mtbAltProdValor.Clear();
                return;
            }
        }
        private void tbAltProdSegCodProd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lbSegmentoAtual.Text = new Banco().categoriaProdutoAll(Convert.ToInt16(tbAltProdSegCodProd.Text));
                cbAltProdSegTipo.DataSource = new BancoConsulta().descricaoTipo();// new Banco().tamanhoProduto(Convert.ToInt16(tbAltProdValCodProd.Text));
                cbAltProdSegTipo.DisplayMember = "nome";
                cbAltProdSegTipo.SelectedIndex = 0; lbAltProdSeg.Text = new Banco().preencherNomeProdutoAlt(Convert.ToInt16(tbAltProdSegCodProd.Text));

            }
            catch
            {
                cbAltProdSegTipo.DataSource = null;
                lbSegmentoAtual.Text = "";
                lbAltProdSeg.Text = "";
                tbAltProdSegCodProd.Clear();
                tbAltProdSegCodProd.Text = "";
                return;
            }
        }
        private void tbAltProSegCod_KeyUp(object sender, KeyEventArgs e)
        {
            carregarCaixaTamanhoAlt();
        }
    }
}
