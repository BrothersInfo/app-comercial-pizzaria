using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Relatorios
{
    public partial class reVenda : Form
    {
        public reVenda()
        {
            InitializeComponent();
            DataTable dtt = new Banco.BancoRelatorio().consultaLeituraX("10/10/2012");
            crGarcon1 = new crGarcon();
            crGarcon1.SetDataSource(dtt.Clone());
         
        }
    }
}
