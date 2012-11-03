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
                    pVenda.Visible = true;
                    pGarcon.Visible = false;
                    pProduto.Visible = false;
                    pVenda.Enabled = true;
                    pGarcon.Enabled = false;
                    pProduto.Enabled = false;
                   

                    break;
                case 1 :
                    pVenda.Visible = false;
                    pGarcon.Visible = true;
                    pProduto.Visible = false;
                    pVenda.Enabled = false;
                    pGarcon.Enabled = true;
                    pProduto.Enabled = false;
                    break;
                case 2 :
                    pVenda.Visible = false;
                    pGarcon.Visible = false;
                    pProduto.Visible = true;
                    pVenda.Enabled = false;
                    pGarcon.Enabled = false;
                    pProduto.Enabled = true;
                    break;
                default : 
                    pVenda.Visible = true;
                    pGarcon.Visible = false;
                    pProduto.Visible = false;
                    pVenda.Enabled = true;
                    pGarcon.Enabled = false;
                    pProduto.Enabled = false;
                    break;
            }
        }



        
    }
}
