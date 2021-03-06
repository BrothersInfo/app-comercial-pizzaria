﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.error_messages;
using iTextSharp.text.pdf.interfaces;
using iTextSharp.text.xml.xmp;
using iTextSharp.text.pdf.intern;


namespace Pizzaria.Tela
{
    using Pizzaria.Banco;
    using Pizzaria.Properties;
    using Pizzaria.Classes;
    using System.IO;
    public partial class TipoRelatorio : Form
    {
        public TipoRelatorio()
        {
            InitializeComponent();
            cbRelatorio.SelectedIndex = 1;
            cbRelatorio.SelectedIndex = 0;
            limpaListView(); lvConsInfo.Items.Clear();

        }
        private void cbRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbRelatorio.SelectedIndex){
                case 0 :
                    flpVenda.Visible = true;
                    flpGarcon.Visible = false;
                   flpProduto.Visible = false;
                    flpVenda.Enabled = true;
                    flpGarcon.Enabled = false;
                    flpProduto.Enabled = false;
               //     panel1.Visible = false;
                    flpLeituraX.Enabled = false;
                    flpLeituraX.Visible = false;
                    carregarVenda();

                    break;
                case 1 :
                    flpVenda.Visible = false;
                    flpGarcon.Visible = true;
                    flpProduto.Visible = false;
                    flpVenda.Enabled = false;
                    flpGarcon.Enabled = true;
                    flpProduto.Enabled = false;
                 //   panel1.Visible = false;
                    flpLeituraX.Enabled = false;
                    flpLeituraX.Visible = false;
                    carregaGarcon();
                    break;
                case 2 :
                    flpVenda.Visible = false;
                    flpGarcon.Visible = false;
                   // panel1.Visible = true;
                    flpProduto.Visible = true;
                    flpVenda.Enabled = false;
                    flpGarcon.Enabled = false;
                    flpProduto.Enabled = true;
                    
                    flpLeituraX.Enabled = false;
                    flpLeituraX.Visible = false;
                    carregaProduto();
                    break;
                case 3:
                  //  panel1.Visible = false;
                    flpVenda.Visible = false;
                    flpGarcon.Visible = false;
                    flpProduto.Visible = false;
                    flpVenda.Enabled = false;
                    flpGarcon.Enabled = false;
                    flpProduto.Enabled = false;
                    flpLeituraX.Enabled = true;
                    flpLeituraX.Visible = true;
                    carregaLeituraX();
                    break;
                
                default :
                  //  panel1.Visible = false;
                    flpVenda.Visible = true;
                    flpGarcon.Visible = false;
                    flpProduto.Visible = false;
                    flpVenda.Enabled = true;
                    flpGarcon.Enabled = false;
                    flpProduto.Enabled = false;
                    flpLeituraX.Enabled = false;
                    flpLeituraX.Visible = false;
                    carregarVenda();
                    break;
            }
        }
        private void btConsultarVenda_Click(object sender, EventArgs e)
        {
            if (cbVendaTipo.SelectedIndex == 1 || cbVendaTipo.SelectedIndex == 0)
            {
                string[] data = new string[cbVendaData.SelectedIndex + 1];
                if (data.Length == 1)
                    data[0] = cbVendaDia.Text + "/" + (cbVendaMes.SelectedIndex + 1) + "/" + cbVendaAno.SelectedItem;
                else
                {
                    data[0] = dtpVendaUm.Value.ToShortDateString();
                    data[1] = dtpVendaDois.Value.ToShortDateString();
                }
                DataTable tabela = new BancoRelatorio().consultaVendaGeral(data, cbOrdenarVenda.SelectedIndex, gbSubFiltro.Visible, cbFiltroVenda.SelectedIndex, cbItem.SelectedIndex, rbVendaCres.Checked, cbVendaTipo.SelectedIndex == 1);
                carregarListView(tabela);
                lValor.Text = somarValores(tabela, 7);

                retorno = tabela;
            }
            else
            {
                if (tbVendaID.Text.Length > 0)
                {
                    DataTable tabel = new BancoRelatorio().consultaPorIDVenda(tbVendaID.Text);

                    carregarListView(tabel);
                }
            }
        }
        public string somarValores(DataTable tabela, int x)
        {
            double valor = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
                valor += Convert.ToDouble( tabela.Rows[i].ItemArray.GetValue(x).ToString().Substring(0).Replace('.',','));
            return "Valor Total : R$"+new Tratamento().retornaValorEscrito( Math.Round( valor,2));
        }
        public void carregarVenda()
        {
            string[] mes = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int[] ano = new int[(DateTime.Now.Year - 2012) + 1];
            for (int i = 0; i < ano.Length; i++)
                ano[i] = 2012 + i;
            cbVendaTipo.SelectedIndex = 0;
            cbVendaMes.DataSource = mes;
            cbVendaAno.DataSource = ano;
            cbVendaMes.SelectedIndex = DateTime.Now.Month - 1;
            cbVendaAno.SelectedIndex = DateTime.Now.Year - 2012;

            int[] dias = new int[DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)];
            for (int i = 0; i < dias.Length; i++)
                dias[i] = i + 1;
            cbVendaDia.DataSource = dias;
            cbVendaDia.SelectedIndex = DateTime.Now.Day-1;
            
            cbVendaData.SelectedIndex = 0;
            cbFiltroVenda.SelectedIndex = 0;

            cbOrdenarVenda.DataSource = new BancoRelatorio().orderByDaVenda();
            cbOrdenarVenda.SelectedIndex = 0;

        }
        public void carregaLeituraX()
        {
            string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int[] ano = new int[(DateTime.Now.Year - 2012) + 1];
            for (int i = 0; i < ano.Length; i++)
                ano[i] = 2012 + i;

            cbMesX.DataSource = mes;
            cbAnoX.DataSource = ano;
            cbMesX.SelectedIndex = DateTime.Now.Month - 1;
            cbAnoX.SelectedIndex = DateTime.Now.Year - 2012;

            int[] dias = new int[DateTime.DaysInMonth(Convert.ToInt16(cbAnoX.Text), DateTime.Now.Month)];
            for (int i = 0; i < dias.Length; i++)
                dias[i] = i + 1;
            cbDiaX.DataSource = dias;
            cbDiaX.SelectedIndex = DateTime.Now.Day - 1;
            

        }
        public void carregaProduto()
        {
            string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int[] ano = new int[(DateTime.Now.Year - 2012) + 1];
            for (int i = 0; i < ano.Length; i++)
                ano[i] = 2012 + i;

           
            cbProdutoMes.DataSource = mes;
            cbProdutoAno.DataSource = ano;

            cbProdutoMes.SelectedIndex = DateTime.Now.Month - 1;
            cbProdutoAno.SelectedIndex = DateTime.Now.Year - 2012;

            int[] dias = new int[DateTime.DaysInMonth(Convert.ToInt16(cbProdutoAno.Text), DateTime.Now.Month)];
          
            for (int i = 0; i < dias.Length; i++)
                dias[i] = i + 1;

            cbProdutoDia.DataSource = dias;
            cbProdutoDia.SelectedIndex = DateTime.Now.Day - 1;


            cbProdutoData.SelectedIndex = 0;

            cbProdutTipo.DataSource =   new BancoRelatorio().categorias();
            cbProdutTipo.SelectedIndex = 0;
            if (cbProdutTipo.SelectedIndex != 0)
            {
                gbProduto.Visible = true;
                gbFiltrarProduto.Visible = true;
                cbProduto.DataSource = new BancoRelatorio().produtosDoTipo(new BancoConsulta().cod_tipoPeloNome(cbProdutTipo.SelectedItem.ToString()));
                cbFiltroProduto.DataSource = new BancoRelatorio().tamanhosDoTipo(new BancoConsulta().cod_tipoPeloNome(cbProdutTipo.SelectedItem.ToString()));
            }
            else {
                gbProduto.Visible = false;
                gbFiltrarProduto.Visible = false;
            }
        }
        public void carregaGarcon()
        {
            int[] dias = new int[DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)];
            for (int i = 0; i < dias.Length; i++)
                dias[i] = i + 1;
            string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int[] ano = new int[(DateTime.Now.Year - 2012) + 1];
            for (int i = 0; i < ano.Length; i++)
                ano[i] = 2012 + i;

            cbGarconDia.DataSource = dias;
            cbGarconMes.DataSource = mes;
            cbGarconAno.DataSource = ano;

            cbGarconDia.SelectedIndex = DateTime.Now.Day - 1;
            cbGarconMes.SelectedIndex = DateTime.Now.Month - 1;
            cbGarconAno.SelectedIndex = DateTime.Now.Year - 2012;

            cbGarconData.SelectedIndex = 0;
            cbGarcon.DataSource = new BancoRelatorio().garcons();
            cbGarconTipo.DataSource = new BancoRelatorio().categorias();
            string[] parse = new BancoRelatorio().ambientes();
            string[] todos = new string[parse.Length + 1];
            todos[0] = "Todos";
            for (int i = 0; i < parse.Length; i++)
                todos[i + 1] = parse[i];
            cbGarconAmbiente.DataSource = todos;// 
            cbGarcon.SelectedIndex = 0;
            cbGarconTipo.SelectedIndex = 0;
            cbGarconAmbiente.SelectedIndex = 0;
            cbOrdenarGarcon.SelectedIndex = 0;

        }
        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbVendaData.SelectedIndex)
            {
                case 0:
                    gbDataVenda.Visible = true;
                    gbPeriodoVenda.Visible = false;
                    break;
                case 1:
                    gbDataVenda.Visible = false;
                    gbPeriodoVenda.Visible = true;
                    break;
            }
        }
        private void cbProdutoData_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProdutoData.SelectedIndex)
            {
                case 0:
                    gbProdutoDia.Visible = true;
                    gbPeriodoProduto.Visible = false;
                    break;
                case 1:
                    gbProdutoDia.Visible = false;
                    gbPeriodoProduto.Visible = true;
                    break;
            }
        }
        private void cbGarconData_SelectedIndexChanged(object sender, EventArgs e)  
        {
            switch (cbGarconData.SelectedIndex)
            {
                case 0:
                    gbGarconDia.Visible = true;
                    gbPeriodoGarcon.Visible = false;
                    break;
                case 1:
                    gbGarconDia.Visible = false;
                    gbPeriodoGarcon.Visible = true;
                    break;
                case 2:
                    gbGarconDia.Visible = false;
                    gbPeriodoGarcon.Visible = false;
                    break;

            }
        }
        private void cbFiltroVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroVenda.SelectedIndex > 0) gbSubFiltro.Visible = true;
            else gbSubFiltro.Visible = false;
            cbItem.DataSource = new BancoRelatorio().itemDoFiltroVenda(cbFiltroVenda.SelectedIndex);
        }
        public void carregarListView(DataTable tabela)
        {
            limpaListView();
            lvConsInfo.Items.Clear();
            int cont =tabela.Columns.Count;
            int j = 0;
            int tamanho = (lvConsInfo.Width/cont)-1;
            while (cont-- > 0)
            {
                lvConsInfo.Columns.Add(new ColumnHeader());
                lvConsInfo.Columns[j].Text = tabela.Columns[j].ColumnName;
                lvConsInfo.Columns[j++].Width = tamanho   ;
            }
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                lvConsInfo.Items.Add(tabela.Rows[i].ItemArray.GetValue(0).ToString());
                int size = 1;
                while (size<tabela.Rows[i].ItemArray.Length)
                    if (Object.ReferenceEquals(((double)2).GetType(), tabela.Rows[i].ItemArray.GetValue(size).GetType()))
                        lvConsInfo.Items[i].SubItems.Add(((double)tabela.Rows[i].ItemArray.GetValue(size++)).ToString("F2"));
                    else
                        lvConsInfo.Items[i].SubItems.Add(tabela.Rows[i].ItemArray.GetValue(size++).ToString());
            }

        }
        public void limpaListView()
        {
            while (lvConsInfo.Columns.Count > 0)
                lvConsInfo.Columns.RemoveAt(0);
        }
        //---
        private void btConsultarGarcon_Click(object sender, EventArgs e)
        {

            string[] data = new string[cbGarconData.SelectedIndex + 1];

            if (data.Length == 1)
            {
                data[0] = cbGarconDia.SelectedItem + "/" + (cbGarconMes.SelectedIndex + 1) + "/" + cbGarconAno.SelectedItem;
            }
            else
            {
                data[0] = dtpGarconUm.Value.ToShortDateString();
                data[1] = dtpGarconDois.Value.ToShortDateString();
            }
            DataTable tabela = new BancoRelatorio().consultaGarconGeral
                (cbGarconData.SelectedIndex == 2
                , data
                , cbGarcon.SelectedIndex != 0
                , cbGarcon.SelectedItem.ToString()
                , cbGarconAmbiente.SelectedIndex != 0
                , cbGarconAmbiente.SelectedItem.ToString()
                , cbGarconTipo.SelectedIndex != 0
                , cbGarconTipo.SelectedItem.ToString()
                , cbOrdenarGarcon.SelectedIndex
                , rbGarconCres.Checked);
            retorno = tabela;
            carregarListView(tabela);
            lValor.Text = somarValoresGarcon(tabela,12);

        }
        public string somarValoresGarcon(DataTable tabela, int x)
        {
            double vendido = 0;double extorno = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                string var = tabela.Rows[i].ItemArray.GetValue(x).ToString();
                if(var.Length>0)
                if (tabela.Rows[i].ItemArray.GetValue(x + 1).ToString().Equals("Vendido"))
                {
                    vendido += (Convert.ToDouble(tabela.Rows[i].ItemArray.GetValue(x).ToString().Replace('.', ',')));
                }
                else {
                     extorno += (Convert.ToDouble(tabela.Rows[i].ItemArray.GetValue(x).ToString().Replace('.', ',')));
                }
            }

            return "Valor de Vendas : R$" + new Tratamento().retornaValorEscrito(vendido) 
               + "\nValor de Extornos : R$" + new Tratamento().retornaValorEscrito(extorno);
        }

        DataTable retorno;
        private void btConsultarProduto_Click(object sender, EventArgs e)
        {
            string[] data = new string[cbProdutoData.SelectedIndex + 1];

            if (data.Length == 1)
            {
                data[0] = cbProdutoDia.SelectedItem + "/" + (cbProdutoMes.SelectedIndex + 1) + "/" + cbProdutoAno.SelectedItem;
            }
            else
            {
                data[0] = dtpProdutoUm.Value.ToShortDateString();
                data[1] = dtpProdutoDois.Value.ToShortDateString();
            }
            DataTable tabela;
            try
            {
               tabela = new BancoRelatorio().consultaProdutoGeral(data, rbProdutValor.Checked,
                    cbProdutTipo.SelectedIndex != 0, new BancoConsulta().cod_tipoPeloNome(cbProdutTipo.SelectedItem.ToString()),
                    cbFiltroProduto.SelectedIndex != 0, new Banco().codTamanho(cbFiltroProduto.SelectedItem.ToString()),
                    cbProduto.SelectedIndex != 0, new Banco().codigoProduto(cbProduto.SelectedItem.ToString()));
            }
            catch
            {
                tabela = new BancoRelatorio().consultaProdutoGeral(data, rbProdutValor.Checked,
                    cbProdutTipo.SelectedIndex != 0, new BancoConsulta().cod_tipoPeloNome(cbProdutTipo.SelectedItem.ToString()),
                    false, 1,
                    false, 1);
            }
            carregarListView(tabela);
            if (rbProdutValor.Checked)
                lValor.Text = somarValores(tabela,6);
            else lValor.Text = "";

            retorno = tabela;
        }

        private void cbProdutTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdutTipo.SelectedIndex != 0)
            {
                gbProduto.Visible = true;
                gbFiltrarProduto.Visible = true;
                cbProduto.DataSource = new BancoRelatorio().produtosDoTipo(new BancoConsulta().cod_tipoPeloNome(cbProdutTipo.SelectedItem.ToString()));
                cbFiltroProduto.DataSource = new BancoRelatorio().tamanhosDoTipo(new BancoConsulta().cod_tipoPeloNome(cbProdutTipo.SelectedItem.ToString()));
            }
            else
            {
                gbProduto.Visible = false;
                gbFiltrarProduto.Visible = false;
            }
        }

        private void btEscolhaProduto_Click(object sender, EventArgs e)
        {
            if (retorno.IsInitialized && retorno.Rows.Count > 0)
            {
                if (btConsultarVenda.Visible)
                {
                    Relatorios.RelatorioVenda.frpVenda venda = new Relatorios.RelatorioVenda.frpVenda(retorno);
                    venda.Show();
                }
                else if (btConsultarGarcon.Visible)
                {

                    Relatorios.RelatorioGarcon.frpGarcon garcon = new Relatorios.RelatorioGarcon.frpGarcon(retorno);
                    garcon.Show();
                }
                else if (btConsultarProduto.Visible)
                {
                    if (rbProdutQuant.Checked)
                    {

                        Relatorios.RelatorioProdutoQtd.frpProdutoQtd produtoQtd = new Relatorios.RelatorioProdutoQtd.frpProdutoQtd(retorno);
                        produtoQtd.Show();
                    }
                    else
                    {
                        Relatorios.RelatorioProdutoValor.frpProdutoValor produtoValor = new Relatorios.RelatorioProdutoValor.frpProdutoValor(retorno);
                        produtoValor.Show();
                    }
                }
            }
            else {
                MessageBox.Show("RELATÓRIO VAZIO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btLeituraX_Click(object sender, EventArgs e)
        {
            string data = cbDiaX.SelectedItem + "/" + (cbMesX.SelectedIndex+1) + "/" + cbAnoX.SelectedItem;
           

            DataTable tabela = new BancoRelatorio().consultaLeituraX(data);
            
            LeituraX lx = new LeituraX();
            lx.dataLeitura = data;
            for (int i = 0; i < tabela.Rows.Count; i++ )
            {
              
                lx.addItem(
                    tabela.Rows[i].ItemArray.GetValue(0).ToString(),
                    Convert.ToInt16(  tabela.Rows[i].ItemArray.GetValue(1) ),
                    Convert.ToInt16(  tabela.Rows[i].ItemArray.GetValue(2) ),
                    Convert.ToDouble(  tabela.Rows[i].ItemArray.GetValue(3).ToString().Replace('.',',') ),
                    tabela.Rows[i].ItemArray.GetValue(4).ToString());
            }
            lx.imprimir();

        }

        private void cbVendaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVendaTipo.SelectedIndex == 2)
            {
                gbVendaData.Visible = false;
                gbPeriodoVenda.Visible = false;
                gbDataVenda.Visible = false;
                gbFiltroVenda.Visible = false;
                gbSubFiltro.Visible = false;
                gbVendaOrdenar.Visible = false;
                gbVendaID.Visible = true;
            }
            else
            {

                gbVendaData.Visible = true;
                gbPeriodoVenda.Visible = true;
                gbDataVenda.Visible = true;
                gbFiltroVenda.Visible = true;
                gbSubFiltro.Visible = true;
                gbVendaOrdenar.Visible = true;
                gbVendaID.Visible = false;
                cbData_SelectedIndexChanged(sender, e);
                cbFiltroVenda_SelectedIndexChanged(sender, e);
                //torno invisivel o campo de digitacao do ID
            }
        }

        
 
    }
}