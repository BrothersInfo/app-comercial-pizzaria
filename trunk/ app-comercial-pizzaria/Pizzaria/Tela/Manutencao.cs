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
    public partial class Manutencao : Form
    {
        public Manutencao()
        {
            InitializeComponent();
            mtComissao.Text = new Banco.Banco().getValorComissao().ToString();
            rbPct.Checked = new Banco.Banco().comissaoIsPct();
            rbFixo.Checked = !rbPct.Checked;
        }

        private void btComissao_Click(object sender, EventArgs e)
        {
            if (mtComissao.Text.Length > 0)
            {
                new Banco.Banco().setBoolComissaoIsPct(rbPct.Checked);
                new Banco.Banco().setComissao(Convert.ToInt16(mtComissao.Text));
                MessageBox.Show("Comissao alterada para " + mtComissao.Text, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Manutencao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    this.Close();
                    break;
            }
        }

        private void btIsPct_Click(object sender, EventArgs e)
        {
            new Banco.Banco().setBoolComissaoIsPct( rbPct.Checked);
            MessageBox.Show("Comissao por Porcentagem foi marcado para " + rbPct.Checked, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void rbPct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPct.Checked)
                lbPct.Text = "%";
            else
                lbPct.Text = "R$";
        }
        private void DisplayImage()
        {
            PictureBox imageControl = new PictureBox();
           // pbFoto.Width = 200;
           // pbFoto.Height = 200;
          //  pbFoto.Dock = DockStyle.Fill;
            

            pbFoto.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "\\logo.png");
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void Manutencao_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }


    }
}
