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
    public partial class PdfGenerator : Form
    {
        public PdfGenerator( DataTable dtt)
        {
            InitializeComponent();
            tabela = dtt;

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                Classes.CRelatorio cr = new Classes.CRelatorio(tabela.Columns.Count);
                switch (cr.size)
                {
                    case 5:
                        {
                            cr.coluna1 = tabela.Rows[i].ItemArray.GetValue(0).ToString();
                            cr.coluna2 = tabela.Rows[i].ItemArray.GetValue(1).ToString();
                            cr.coluna3 = tabela.Rows[i].ItemArray.GetValue(2).ToString();
                            cr.coluna4 = tabela.Rows[i].ItemArray.GetValue(3).ToString();
                            cr.coluna5 = tabela.Rows[i].ItemArray.GetValue(4).ToString();
                        }
                        break;

                    case 7:
                        {
                            cr.coluna1 = tabela.Rows[i].ItemArray.GetValue(0).ToString();
                            cr.coluna2 = tabela.Rows[i].ItemArray.GetValue(1).ToString();
                            cr.coluna3 = tabela.Rows[i].ItemArray.GetValue(2).ToString();
                            cr.coluna4 = tabela.Rows[i].ItemArray.GetValue(3).ToString();
                            cr.coluna5 = tabela.Rows[i].ItemArray.GetValue(4).ToString();
                            cr.coluna6 = tabela.Rows[i].ItemArray.GetValue(5).ToString();
                            cr.coluna7 = tabela.Rows[i].ItemArray.GetValue(6).ToString();
                        }
                        break;
                    case 8:
                        {
                            cr.coluna1 = tabela.Rows[i].ItemArray.GetValue(0).ToString();
                            cr.coluna2 = tabela.Rows[i].ItemArray.GetValue(1).ToString();
                            cr.coluna3 = tabela.Rows[i].ItemArray.GetValue(2).ToString();
                            cr.coluna4 = tabela.Rows[i].ItemArray.GetValue(3).ToString();
                            cr.coluna5 = tabela.Rows[i].ItemArray.GetValue(4).ToString();
                            cr.coluna6 = tabela.Rows[i].ItemArray.GetValue(5).ToString();
                            cr.coluna7 = tabela.Rows[i].ItemArray.GetValue(6).ToString();
                            cr.coluna8 = tabela.Rows[i].ItemArray.GetValue(7).ToString();
                        }
                        break;
                    case 11:
                        {
                            cr.coluna1 = tabela.Rows[i].ItemArray.GetValue(0).ToString();
                            cr.coluna2 = tabela.Rows[i].ItemArray.GetValue(1).ToString();
                            cr.coluna3 = tabela.Rows[i].ItemArray.GetValue(2).ToString();
                            cr.coluna4 = tabela.Rows[i].ItemArray.GetValue(3).ToString();
                            cr.coluna5 = tabela.Rows[i].ItemArray.GetValue(4).ToString();
                            cr.coluna6 = tabela.Rows[i].ItemArray.GetValue(5).ToString();
                            cr.coluna7 = tabela.Rows[i].ItemArray.GetValue(6).ToString();
                            cr.coluna8 = tabela.Rows[i].ItemArray.GetValue(7).ToString();
                            cr.coluna9 = tabela.Rows[i].ItemArray.GetValue(8).ToString();
                            cr.coluna10 = tabela.Rows[i].ItemArray.GetValue(9).ToString();
                            cr.coluna11 = tabela.Rows[i].ItemArray.GetValue(10).ToString();
                        }
                        break;

                }
                list.Insert(i, cr);

            } CRelatorioBindingSource.DataSource = list;
          
            this.rvPdf.RefreshReport();
        }
        DataTable tabela;
        List<Classes.CRelatorio> list = new List<Classes.CRelatorio>();
        private void PdfGenerator_Load(object sender, EventArgs e)
        {
            this.rvPdf.RefreshReport();

        }
    }
}
