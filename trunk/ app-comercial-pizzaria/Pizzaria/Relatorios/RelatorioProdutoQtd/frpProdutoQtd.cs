using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Relatorios.RelatorioProdutoQtd
{
    public partial class frpProdutoQtd : Form
    {
        public frpProdutoQtd(DataTable data)
        {
            InitializeComponent();

               cr = new crProdutoQtd2();
               cr.Load(Application.StartupPath + "\\crProdutoQtd2.rpt");
            cr.SetDataSource(data);
             crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
        }
        crProdutoQtd2 cr;
    }
}
