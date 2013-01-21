using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Relatorios.RelatorioGarcon
{
    public partial class frpGarcon : Form
    {
        
        crGarcon2 cr;
          public frpGarcon(DataTable data)
        {
            
           
            InitializeComponent();
            cr = new crGarcon2();
              cr.Load(Application.StartupPath + "\\crGarcon2.rpt");
           
            cr.SetDataSource(data);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();

        }
    }
}
