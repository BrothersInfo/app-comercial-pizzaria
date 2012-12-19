using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MatrixReporter;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace Pizzaria.Classes
{
    
    using Pizzaria.Banco;

    public class Impressao
    {
        VendaFull venda;
        public Impressao(VendaFull v)
        {
            //28+ qtd produto
            int qtdLinha = 28 + (v.Completos.Length*2) ;
            venda = v;
            qtdLinha *= 10;
            qtdLinha += 70;
            this.printDocument1 = new System.Drawing.Printing.PrintDocument(); 
            this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 304, qtdLinha);
         
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
          //  printDocument1.PrinterSettings.PrinterName = "UNo";
           // printDocument1.PrinterSettings.PrintFileName = "Duno";
        }

        StringReader leitor;
        private System.Drawing.Printing.PrintDocument printDocument1;
        string endereco = "comanda.txt"; string comanda = "";
        public void gerarComprovante()
        {
            try
            {
                //ImprimeImpressora();

                //quem vai imprimir
                Reporter mr = new Reporter();
                //quem vai colocar em italico e talz
                
                EpsonCodes mer = new EpsonCodes();
                //mer.SetPageSize(40);

                if (File.Exists(endereco))
                    File.Delete(endereco);

                mr.Output = endereco;
                mr.StartJob();
                //--------------------------------------------------------------------------------
                

                Comanda cc = new Comanda(venda.cod_venda);
                string pont = "|-----------------------------------|";

                mr.PrintText(01, 02, cc.empresa);
                //o \n serve como paper feed na impressora...
                mr.PrintText(02, 01, pont);
                mr.PrintText(03, 01, cc.telefone);
                mr.PrintText(04, 01, pont);
                mr.PrintText(05, 01, cc.titulo);
                int line = 6; int i = 0; int ii = 0;
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line++, 01, "| ID |COD |     DESCRICAO     |CATEG|");//id casa 1  - cod casa 7 -  desc - casa 12 - categ casa 32
                mr.PrintText(line++, 01, "|    QTD Un X VL Un   =  SUB-TOTAL  |");// qtd - casa 6  - X na casa 7 - val Uni - casa 8 - sub total casa 18
                mr.PrintText(line++, 01, pont);

                i = venda.Completos.Length;
                while (ii < i)
                {
                    mr.PrintText(line, 01, "|"); mr.PrintText(line, 02, "" + new Tratamento().makeId(ii+1) ); mr.PrintText(line, 06, "|");
                    mr.PrintText(line, 07, "" + venda.Completos[ii].produto[0].cod_produto); mr.PrintText(line, 11, "|");
                    string prod = new Banco().preencherNomeProdctAll(venda.Completos[ii].produto[0].cod_produto);
                    if (venda.Completos[ii].produto.Length > 1) prod = "mist " + prod;
                    if (prod.Length > 16)          prod = prod.Substring(0, 16); 
                    mr.PrintText(line, 12, prod);
                    mr.PrintText(line, 28, "|");
                    string tam = new BancoVenda().tamanhoDescricao(venda.Completos[ii].produto[0].cod_tamanho);
                    if (tam.Length > 7) tam = tam.Substring(0, 7); mr.PrintText(line, 29, tam);
                    mr.PrintText(line++, 37, "|");


                    mr.PrintText(line, 01, "|"); mr.PrintText(line, 08, "" + venda.Completos[ii].quantidade); mr.PrintText(line, 11, "X");

                    mr.PrintText(line, 15,new Tratamento().retornaValorEscritoCo(venda.Completos[ii].valorUnitario ));
                    mr.PrintText(line, 23, "=");
                    
                    if ((venda.Completos[ii].valorUnitario * venda.Completos[ii].quantidade)>=100)
                        mr.PrintText(line, 26, new Tratamento().retornaValorEscritoCo((venda.Completos[ii].valorUnitario * venda.Completos[ii++].quantidade)));
                    else
                        mr.PrintText(line, 25, new Tratamento().retornaValorEscritoCo((venda.Completos[ii].valorUnitario * venda.Completos[ii++].quantidade)));
                    mr.PrintText(line++, 37, "|");
                }
                
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line++, 01, cc.fixRightPont("TOTAL RS : " + new Tratamento().retornaValorEscrito(venda.valorTotal)));
                mr.PrintText(line++, 01, pont);
                //--------------------------------

                int gPos = 12;
                string garc = "";
                int x = 0;
                
                string garc3 = new BancoVenda().nomeGarcon(venda.garcon[x++]);

                garc += garc3;

                while (gPos < 36 && x < venda.garcon.Length)
                {
                    garc += " | " + new BancoVenda().nomeGarcon(venda.garcon[x++]);
                    gPos = 12 + garc.Length;
                }
                

                mr.PrintText(line, 01, "| GARCON : " + garc); mr.PrintText(line++, 37, "|");

                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "|");
                int xx = 3;
                ii = 0;
                while (ii < 5 && ii < venda.mesa.Length)
                {
                    mr.PrintText(line, xx, venda.mesa[ii] + " | ");
                    xx = xx + venda.mesa[ii++].Length + 3;
                }
                mr.PrintText(line++, 37, "|");
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "| CAIXA : "); mr.PrintText(line, 11, new BancoVenda().nomeVendedor(venda.cod_caixa)); mr.PrintText(line++, 37, "|");
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line++, 01, cc.data);
                mr.PrintText(line, 01, "| Inicio :" + new Banco().getHorarioVenda(venda.cod_venda)+ " |  Final : "+ DateTime.Now.ToShortTimeString()) ; mr.PrintText(line++, 37, "|");
                mr.PrintText(line++, 01, pont);

                mr.PrintText(line, 01, "|"); mr.PrintText(line++, 37, "|");
                mr.PrintText(line++, 01, cc.mensagem);
                mr.PrintText(line, 01, "|"); mr.PrintText(line++, 37, "|");
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line++, 01, cc.cidade);
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line++, 01, cc.progNome);
                mr.PrintText(line++, 01, cc.progTelefone);
                mr.PrintText(line++, 01, "|___________________________________|");
                

                mr.PrintJob();
                mr.EndJob();


            }
            catch { }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
                float linhasPorPagina = 0;
                float yPosicao = 0;
                int contador = 0;
                float margemEsquerda = 0;//e.MarginBounds.Left;
                float margemSuperior = 10;// e.MarginBounds.Top;
                string linha = null;
                Font fonteImpressao = new Font("Arial", 7);

                SolidBrush mCaneta = new SolidBrush(Color.Black);


                //   e.PageBounds = new RectangleConverter(). 
                //e.PageSettings.Bounds.Height = 300;

                // Define o numero de linhas por pagina, usando MarginBounds.
                linhasPorPagina = 35 + venda.Completos.Length;
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
                    int u = 0;
                    while (u <= 37)
                    {
                //        x += 7;
                 //       e.Graphics.DrawString
                 //           (letra[u++].ToString(), fonteImpressao, mCaneta,
                  //          (x), yPosicao, ww);
                        try
                        {

                            x += 7;
                            x = x + 0.5f;
                            if (letra[u].Equals('i') || letra[u].Equals('l') || letra[u].Equals('I'))
                            {
                                e.Graphics.DrawString
                                   (letra[u++].ToString(), fonteImpressao, mCaneta,
                                   (x + 3), yPosicao, ww);
                            }
                            else
                            {
                                if (u > 0 && letraGrande(letra[u - 1], letra[u]))
                                {
                                    e.Graphics.DrawString
                                    (letra[u++].ToString(), fonteImpressao, mCaneta,
                                    (x + 1.5f), yPosicao, ww);
                                }
                                else
                                {
                                    e.Graphics.DrawString
                                    (letra[u++].ToString(), fonteImpressao, mCaneta,
                                    (x), yPosicao, ww);
                                }

                            }
                        }
                        catch
                        {
                            x += 7;
                            e.Graphics.DrawString
                                (letra[u++].ToString(), fonteImpressao, mCaneta,
                                (x), yPosicao, ww);
                        }//*/
                    }
                    contador++;
                }
                // Verifica se existe mais linhas para imprimir


                if (linha != null)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;

                //libera recursos		
                mCaneta.Dispose();

                if (File.Exists(endereco))
                    File.Delete(endereco);
            //}            catch { MessageBox.Show("erro dentro da edicao de impressao"); }
        }
        public bool letraGrande(char ant, char atual)
        {
            if (ant == 'G' || ant == 'Q' || ant == 'm' || ant == 'M' || ant == 'O' || ant == 'A' || ant == 'B')
                return true;
            else return false;
        }
        public void lerArquivo()
        {
            PrintDialog print = new PrintDialog();

            print.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 380, 600);    // 500;
            print.PrinterSettings.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 10);
            //  printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = print.PrinterSettings.DefaultPageSettings.PaperSize; //.PaperSize = new System.Drawing.Printing.PaperSize("fabricio", 300, 600);

            // printDialog1.Document = printDocument1;
            LerArquivoTexto(endereco);
            string x = comanda;
            leitor = new StringReader(x);
            printDocument1.DocumentName = "comanda.txt";
            // printDocument1.OriginAtMargins = true;
            printDocument1.DefaultPageSettings.Margins.Left = 0;
            printDocument1.DefaultPageSettings.Margins.Right = 0;
            printDocument1.DefaultPageSettings.Margins.Top = 0;
            printDocument1.DefaultPageSettings.Margins.Bottom = 0;
            
            printDocument1.Print();
        }
        private void LerArquivoTexto(string StrArquivo)
        {
            try
            {
                //Cria uma instância do StreamReader para ler o arquivo
                //A declaração using fecha o stream no fim do escopo
                using (StreamReader sr = new StreamReader(StrArquivo))
                {
                    String linha;
                    //Ler e exibe as linhas até alcançar o fim do arquivo.
                    while ((linha = sr.ReadLine()) != null)
                        comanda += linha + "\n";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não é possivel ler o arquivo");
                MessageBox.Show(e.Message);
            }
        }

    }
}
