using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Relatorios.RelatorioProdutoValor
{
    public partial class frpProdutoValor : Form
    {
       public frpProdutoValor(DataTable data)
        {
            InitializeComponent();

               cr = new crProdutoValor2();
               cr.Load(Application.StartupPath + "\\crProdutoValor2.rpt");
            cr.SetDataSource(data);
             crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
        }
        crProdutoValor2 cr;
    }
}
