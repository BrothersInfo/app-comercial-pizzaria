using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Relatorios.RelatorioVenda
{
    public partial class frpVenda : Form
    {
        crVenda3 cr;
        public frpVenda(DataTable data)
        {
            

            InitializeComponent();
            cr = new crVenda3();
            cr.SetDataSource(data);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();

        }
    }
}
