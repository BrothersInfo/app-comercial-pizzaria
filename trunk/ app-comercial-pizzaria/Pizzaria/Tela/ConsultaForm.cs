using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pizzaria.Tela
{
    using Pizzaria.Banco;
    using Pizzaria.Properties;
    using Pizzaria.Classes;
    public partial class ConsultaForm : Form
    {
        public ConsultaForm()
        {
            InitializeComponent();
            carregarConsultar();
        }
        StringReader leitor;
        private void btConsImprimir_Click(object sender, EventArgs e)
        {
            lerArquivoConsulta(ConsultaComanda);
        }

        private void btImprimir1_Click(object sender, EventArgs e)
        {
            lerArquivoConsulta(ConsultaComanda2);
        }
        public void carregarConsultar()
        {
            ConsultaTamanhoList(tlpConsulta1Nivel2.Width);
            carregarListaConsulta();

        }
        public void lerArquivoConsulta(string comanda)
        {
            PrintDialog print = new PrintDialog();

            leitor = new StringReader(comanda);
            printDocument1.DocumentName = "comanda.txt";
            // printDocument1.OriginAtMargins = true;
            printDocument1.DefaultPageSettings.Margins.Left = 10;
            printDocument1.DefaultPageSettings.Margins.Right = 10;
            printDocument1.DefaultPageSettings.Margins.Top = 5;
            printDocument1.DefaultPageSettings.Margins.Bottom = 10;
            printDocument1.Print();

        }
        public void ConsultaTamanhoList(double tamanho)
        {

            while (lvConsInfo.Items.Count > 0)
                lvConsInfo.Items.RemoveAt(0);
            while (lvConsInfo2.Items.Count > 0)
                lvConsInfo2.Items.RemoveAt(0);

            //zerei a tabela
            double umPct = tamanho / 100;

            this.lvConsInfo.Size = new System.Drawing.Size((int)tamanho, 384); //570 555
            this.lvConsInfo2.Size = new System.Drawing.Size((int)tamanho, 384); //570 555 //editei tamanho


            this.codigo.Width = (int)(umPct * 14);// 55;//10% 
            this.Produto.Width = (int)(umPct * 39);//32%
            this.Tamanho.Width = (int)(umPct * 25);//13%
            this.Tamanho.Name = "Sub-Categoria";
            this.Tamanho.Text = "Sub-Categoria";
            this.ValorUni.Width = (int)(umPct * 20);//16%

            //this.ValorUni.Dispose();

            this.codigo2.Width = (int)(umPct * 23);// 55;//10% 
            this.descricao2.Width = (int)(umPct * 45);//32%
            this.tipo2.Width = (int)(umPct * 30);//13%
            this.tipo2.Name = "Segmento";
            this.tipo2.Text = "Segmento";
        }
        public void carregarListaConsulta()
        {
            DataTable t = new BancoConsulta().tabela(true); ;
            DataTable t2 = new BancoConsulta().tabela(false); ;

            //  lvConsInfo.Clear();
            ConsultaComanda = "";
            ConsultaComanda2 = "";
            for (int i = 0; i < t.Rows.Count; i++)
            {
                //codigo
                lvConsInfo.Items.Add(t.Rows[i].ItemArray.GetValue(0).ToString());                    //nome
                ConsultaComanda += t.Rows[i].ItemArray.GetValue(0).ToString() + " |\t ";
                lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(1).ToString());
                ConsultaComanda += t.Rows[i].ItemArray.GetValue(1).ToString() + " |\t\t ";
                lvConsInfo.Items[i].SubItems.Add(t.Rows[i].ItemArray.GetValue(2).ToString());
                ConsultaComanda += t.Rows[i].ItemArray.GetValue(2).ToString() + " |\t ";
                double teste = Convert.ToDouble(new Tratamento().stringToDouble(t.Rows[i].ItemArray.GetValue(3).ToString()));
                lvConsInfo.Items[i].SubItems.Add(new Tratamento().retornaValorEscrito(teste));
                string zzz = new Tratamento().retornaValorEscrito
                    (Convert.ToDouble(t.Rows[i].ItemArray.GetValue(3))) + " \n ";
                ConsultaComanda += zzz;
            }

            ConsultaComanda2 = "ITEM | PRODUTO | SEGMENTO\n";
            for (int i = 0; i < t2.Rows.Count; i++)
            {
                //codigo
                lvConsInfo2.Items.Add(t2.Rows[i].ItemArray.GetValue(0).ToString());
                ConsultaComanda2 += t2.Rows[i].ItemArray.GetValue(0).ToString() + " |\t ";//nome            
                lvConsInfo2.Items[i].SubItems.Add(t2.Rows[i].ItemArray.GetValue(1).ToString());
                ConsultaComanda2 += t2.Rows[i].ItemArray.GetValue(1).ToString() + " |\t\t ";
                lvConsInfo2.Items[i].SubItems.Add(t2.Rows[i].ItemArray.GetValue(2).ToString());
                ConsultaComanda2 += t2.Rows[i].ItemArray.GetValue(2).ToString() + "\n";

            }

        }
        string ConsultaComanda;
        string ConsultaComanda2;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                float linhasPorPagina = 0;
                float yPosicao = 0;
                int contador = 0;
                float margemEsquerda = 20;//e.MarginBounds.Left;
                float margemSuperior = 20;// e.MarginBounds.Top;
                string linha = null;
                Font fonteImpressao = new Font("ARIAL", 15);
                SolidBrush mCaneta = new SolidBrush(Color.Black);

                // Define o numero de linhas por pagina, usando MarginBounds.
                linhasPorPagina = 40;
                //35 + venda.Completos.Length;
                //e.MarginBounds.Height / fonteImpressao.GetHeight(e.Graphics);

                // Itera sobre a string usando StringReader, imprimindo cada linha

                while (contador < linhasPorPagina && ((linha = leitor.ReadLine()) != null))
                {
                    // calcula a posicao da proxima linha baseada
                    // na altura da fonte de acordo com o dispositivo de impressão
                    yPosicao = margemSuperior + (contador * fonteImpressao.GetHeight(e.Graphics));

                    StringFormat ww = new StringFormat(StringFormatFlags.FitBlackBox);

                    //ww.Alignment = StringAlignment.Center;
                    char[] letra = linha.ToCharArray();
                    float x = margemEsquerda;
                    e.Graphics.DrawString
                                (linha, fonteImpressao, mCaneta,
                                x,
                                yPosicao,
                                ww);

                    contador++;
                }
                // Verifica se existe mais linhas para imprimir


                if (linha != null)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;

                //libera recursos		
                mCaneta.Dispose();

            }
            catch { MessageBox.Show("erro dentro da edicao de impressao"); }
        }
    }
}
