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
    public partial class TipoRelatorio : Form
    {
        public TipoRelatorio()
        {
            InitializeComponent();
            cbRelatorio.SelectedIndex = 1;
            cbRelatorio.SelectedIndex = 0;

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
                    carregarVenda();

                    break;
                case 1 :
                    flpVenda.Visible = false;
                    flpGarcon.Visible = true;
                    flpProduto.Visible = false;
                    flpVenda.Enabled = false;
                    flpGarcon.Enabled = true;
                    flpProduto.Enabled = false;
                    carregaGarcon();
                    break;
                case 2 :
                    flpVenda.Visible = false;
                    flpGarcon.Visible = false;
                    flpProduto.Visible = true;
                    flpVenda.Enabled = false;
                    flpGarcon.Enabled = false;
                    flpProduto.Enabled = true;
                    carregaProduto();
                    break;
                default :
                    flpVenda.Visible = true;
                    flpGarcon.Visible = false;
                    flpProduto.Visible = false;
                    flpVenda.Enabled = true;
                    flpGarcon.Enabled = false;
                    flpProduto.Enabled = false;
                    carregarVenda();
                    break;
            }
        }

        private void btConsultarVenda_Click(object sender, EventArgs e)
        {

        }

        public void carregarVenda()
        {
            int[] dias = new int[DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)];
            for (int i = 0; i < dias.Length; i++)
                dias[i] = i + 1;
            string[] mes = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int[] ano = new int[(DateTime.Now.Year - 2012) + 1];
            for (int i = 0; i < ano.Length; i++)
                ano[i] = 2012 + i;
            cbVendaDia.DataSource = dias;
            cbVendaMes.DataSource = mes;
            cbVendaAno.DataSource = ano;

            cbVendaDia.SelectedIndex = DateTime.Now.Day-1;
            cbVendaMes.SelectedIndex = DateTime.Now.Month-1;
            cbVendaAno.SelectedIndex = DateTime.Now.Year- 2012;

            cbVendaData.SelectedIndex = 0;
        }

        public void carregaProduto()
        {
            int[] dias = new int[DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)];
            for (int i = 0; i < dias.Length; i++)
                dias[i] = i + 1;
            string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int[] ano = new int[(DateTime.Now.Year - 2012) + 1];
            for (int i = 0; i < ano.Length; i++)
                ano[i] = 2012 + i;

            cbProdutoDia.DataSource = dias;
            cbProdutoMes.DataSource = mes;
            cbProdutoAno.DataSource = ano;

            cbProdutoDia.SelectedIndex = DateTime.Now.Day - 1;
            cbProdutoMes.SelectedIndex = DateTime.Now.Month - 1;
            cbProdutoAno.SelectedIndex = DateTime.Now.Year - 2012;

            cbProdutoData.SelectedIndex = 0;
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
            }
        }




        
    }
}
