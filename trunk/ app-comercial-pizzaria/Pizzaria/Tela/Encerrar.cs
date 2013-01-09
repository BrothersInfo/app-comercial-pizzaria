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
    public partial class Encerrar : Form
    {
        int cod_venda;
        double valor;
        string[] mesas;
        VendaFull venda;

        //---
        double recebimento = 0;
         double desconto = 0;
        double troco = -1;
        public bool encerrou = false;
         public Encerrar(VendaFull vend) {
            venda = vend;
            InitializeComponent();
            carregandoTudo();
           // mtValor.Focus();
            posicionamento();
            
        }
         public bool isBalcao = false;
        public Encerrar(int cod_venda , double valor_venda, string [] mesa, bool balcao)
        {
            InitializeComponent();
            this.cod_venda = cod_venda;
            this.valor = valor_venda;
            carregandoTudo();
            mesas = mesa;
            //mtValor.Focus();
            posicionamento();
            isBalcao = balcao;
           
        }


        private void Encerrar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape://Voltar Tela
                    btAnular_Click(sender, null);

                    break;
            }
        }

   
        




        }
}
