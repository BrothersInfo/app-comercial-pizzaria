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
        int sizeLetra = 7;
        public Impressao(LeituraX impri)
        {
            int qtdLinha = 20+  impri.itens.Count ;
            //this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 304, qtdLinha);
            //printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
          

            sizeLetra = 7;
            qtdLinha *= 10;
            qtdLinha += 70;
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            gerarLeituraX(impri);
        }
        public Impressao(VendaFull v)
        {
            //28+ qtd produto
            int qtdLinha = 28 + (v.Completos.Length*2) ;
            //this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 304, qtdLinha);
            //printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            venda = v;
            
            sizeLetra = 7;
            qtdLinha *= 10;
            qtdLinha += 70;
            this.printDocument1 = new System.Drawing.Printing.PrintDocument(); 
           
          //  printDocument1.PrinterSettings.PrinterName = "UNo";
           // printDocument1.PrinterSettings.PrintFileName = "Duno";
        }

        StringReader leitor;
        private System.Drawing.Printing.PrintDocument printDocument1;
        string endereco = "comanda.txt"; string comanda = "";
        int linePorFolha = 0;
        //aqui eu preciso colocar a data da LeituraX  -  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public void gerarLeituraX(LeituraX leitu){
            int qtdLinha = 20 + leitu.itens.Count;
            linePorFolha = qtdLinha;
            qtdLinha *= 10;
            qtdLinha += 70;
            this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 304, qtdLinha);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            try
            {
                Reporter mr = new Reporter();
                //quem vai colocar em italico e talz
                EpsonCodes mer = new EpsonCodes();
                if (File.Exists(endereco))
                    File.Delete(endereco);
                mr.Output = endereco;
                mr.StartJob();
                //--------------------------------------------------------------------------------

                string pont = "|-----------------------------------|";

                int line = 1;
                mr.PrintText(line++, 01, "|------------- LEITURA X -----------|");
                mr.PrintText(line++, 02, leitu.empresa);
                //o \n serve como paper feed na impressora...

                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "|Data:" + DateTime.Now.ToShortDateString()); mr.PrintText(line++, 37, "|");
                mr.PrintText(line, 01, "|Hora:" + DateTime.Now.ToShortTimeString()); mr.PrintText(line++, 37, "|");

                mr.PrintText(line++, 01, pont);
                //data e hora

                mr.PrintText(line++, 01, "|HORA  -VENDA  -PAGAMENTO   -VALOR  |");//id casa 1  - cod casa 7 -  desc - casa 12 - categ casa 32
                mr.PrintText(line++, 01, pont);
                //itens
                {
                    for (int i = 0; i < leitu.itens.Count; i++)
                    {
                        mr.PrintText(line, 01, "|");
                        mr.PrintText(line, 02, leitu.itens[i].hora);
                        mr.PrintText(line, 08, "-");
                        mr.PrintText(line, 09, leitu.itens[i].mesa);
                        mr.PrintText(line, 17, "-");
                        mr.PrintText(line, 18, leitu.itens[i].formaPagamento);

                        mr.PrintText(line, 29, "-");
                        mr.PrintText(line, 30, new Tratamento().retornaValorEscrito( leitu.itens[i].valor));
                        mr.PrintText(line++, 37, "|");
                    }

                }
                //itens

                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "|"); mr.PrintText(line, 15, ("TOTAL R$ " + new Tratamento().retornaValorEscrito(leitu.valorTotal))); mr.PrintText(line++, 37, "|");
                if (leitu.totDinheiro > 0)
                { mr.PrintText(line, 01, "|"); mr.PrintText(line, 15, ("DINHEIRO RS " + new Tratamento().retornaValorEscrito(leitu.totDinheiro))); mr.PrintText(line++, 37, "|"); }
                if (leitu.totCredito > 0)
                { mr.PrintText(line, 01, "|"); mr.PrintText(line, 15, ("CREDITO RS " + new Tratamento().retornaValorEscrito(leitu.totCredito))); mr.PrintText(line++, 37, "|"); }
                if (leitu.totDebito > 0)
                { mr.PrintText(line, 01, "|"); mr.PrintText(line, 15, ("DEBITO RS " + new Tratamento().retornaValorEscrito(leitu.totDebito))); mr.PrintText(line++, 37, "|"); }
                if (leitu.totCheque > 0)
                { mr.PrintText(line, 01, "|"); mr.PrintText(line, 15, ("CHEQUE RS " + new Tratamento().retornaValorEscrito(leitu.totCheque))); mr.PrintText(line++, 37, "|"); }

                mr.PrintText(line++, 01, pont);
                //--------------------------------
                mr.PrintText(line, 01, "|"); mr.PrintText(line++, 37, "|");
                mr.PrintText(line++, 01, "|___________________________________|");


                mr.PrintJob();
                mr.EndJob();
                lerArquivo();

            }
            catch { }
        }
        
        public void gerarComandaInterna(Completa [] produto, string [] garcon, string [] mesa)
        {
            sizeLetra
                 = 14;
            int qtd = 0;
           for (int u = 0; u < produto.Length; u++)
                qtd += produto[u].produto.Length;
           qtd *= 3;
            int qtdLinha = 18 +qtd;
            qtdLinha *= 26;
          //  qtdLinha += 400;
            this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 304, qtdLinha);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            try
            {
                //quem vai imprimir
                Reporter mr = new Reporter();
                //quem vai colocar em italico e talz

                EpsonCodes mer = new EpsonCodes();
                //mer.SetPageSize(40);

                if (File.Exists(endereco))
                    File.Delete(endereco);

                mr.Output = endereco;
                mr.StartJob();
                Comanda cc = new Comanda(venda.cod_venda,true);
                string pont = "|---------------|";
                int line = 1; 
                mr.PrintText(line++, 01, pont);
                if (cc.empresa.Length > 16) cc.empresa = cc.empresa.Substring(0, 16);
                mr.PrintText(line++, 01, cc.empresa);
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "|Data:" + DateTime.Now.ToShortDateString()); mr.PrintText(line++, 17, "|");
                mr.PrintText(line, 01, "|Hora:" + DateTime.Now.ToShortTimeString()); mr.PrintText(line++, 17, "|");
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "|"); mr.PrintText(line++, 17, "|");
                //produto
                int ii = produto.Length;

                while(ii-- > 0){
                    for (int j = 0; j < produto[ii].produto.Length;j++ )
                    {
                        string prod = new Banco().preencherNomeProdctAll(produto[ii].produto[j].cod_produto);
                        if (prod.Length > 15) prod = prod.Substring(0,15);
                        mr.PrintText(line, 01, "|" + prod); mr.PrintText(line++, 17, "|");
                        mr.PrintText(line, 01, "|"); mr.PrintText(line, 6, "--" + (produto[ii].produto[j].porcentagem * 100) + " %"); mr.PrintText(line++, 17, "|");
                        
                        
                    }
                     string tam = new BancoVenda().tamanhoDescricao(produto[ii].produto[0].cod_tamanho);
                     if (tam.Length > 10) tam = tam.Substring(0,  10);
                     mr.PrintText(line, 1, "|Tam- " + tam); mr.PrintText(line++, 17, "|");
                    mr.PrintText(line, 1, "|Quantid- " + produto[ii].quantidade); mr.PrintText(line++, 17, "|");
                    mr.PrintText(line, 01, "|"); mr.PrintText(line++, 17, "|");
                    mr.PrintText(line++, 01, "| -- - -- - --  |");
                }
                //produto
                mr.PrintText(line++, 01, pont);
                if (garcon[0].Length > 7) garcon[0] = garcon[0].Substring(0, 7);
                string garc = "|GARCON -" + garcon[0];
                mr.PrintText(line, 01, garc); mr.PrintText(line++, 17, "|");
                mr.PrintText(line++, 01, pont);

                mr.PrintText(line, 01,"| "+ mesa[mesa.Length-1]); mr.PrintText(line++, 17, "|");
                mr.PrintText(line++, 01, pont);
            
                mr.PrintJob();
                mr.EndJob();
                lerArquivo();
            }
            catch { }
        }
        public void gerarComandaNaoFiscal(string formaPagamento,double dinheiro, double troco)
        {
            int qtdLinha = 25 + (venda.Completos.Length * 2);
            qtdLinha *= 10;
            qtdLinha += 70;
            this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 304, qtdLinha);
                        printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            try
            {
                Reporter mr = new Reporter();
                //quem vai colocar em italico e talz
                EpsonCodes mer = new EpsonCodes();
                if (File.Exists(endereco))
                    File.Delete(endereco);
                mr.Output = endereco;
                mr.StartJob();
                //--------------------------------------------------------------------------------
                Comanda cc = new Comanda(venda.cod_venda);
                string pont = "|-----------------------------------|";
                int line = 1; int i = 0; int ii = 0;
                mr.PrintText(line++, 02, cc.empresa);
                //o \n serve como paper feed na impressora...
                mr.PrintText(line++, 01, cc.telefone);
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line++, 01, cc.fixCenter("Cupom Nao Fiscal", 1));
                mr.PrintText(line++, 01, pont);
                //data e hora
                mr.PrintText(line++, 01,  cc.fixCenter("Data : "+DateTime.Now.ToShortDateString()+" Hora : "+DateTime.Now.ToShortTimeString(),1));
                mr.PrintText(line++, 01, pont);
               
                mr.PrintText(line++, 01, "| ID |COD |     DESCRICAO    |CATEG |");//id casa 1  - cod casa 7 -  desc - casa 12 - categ casa 32
                mr.PrintText(line++, 01, "|    QTD Un X VL Un   =  SUB-TOTAL  |");// qtd - casa 6  - X na casa 7 - val Uni - casa 8 - sub total casa 18
                mr.PrintText(line++, 01, pont);

                i = venda.Completos.Length;
                while (ii < i)
                {
                    mr.PrintText(line, 01, "|"); mr.PrintText(line, 02, "" + new Tratamento().makeId(ii + 1)); mr.PrintText(line, 06, "-");
                    mr.PrintText(line, 07, "" + venda.Completos[ii].produto[0].cod_produto); mr.PrintText(line, 11, "-");
                    string prod = new Banco().preencherNomeProdctAll(venda.Completos[ii].produto[0].cod_produto);
                    if (venda.Completos[ii].produto.Length > 1) prod = "mist " + prod;
                    if (prod.Length > 16) prod = prod.Substring(0, 16);
                    mr.PrintText(line, 12, prod);
                    mr.PrintText(line, 28, "-");
                    string tam = new BancoVenda().tamanhoDescricao(venda.Completos[ii].produto[0].cod_tamanho);
                    if (tam.Length > 7) tam = tam.Substring(0, 7); mr.PrintText(line, 29, tam);
                    mr.PrintText(line++, 37, "|");


                    mr.PrintText(line, 01, "|"); mr.PrintText(line, 08, "" + venda.Completos[ii].quantidade); mr.PrintText(line, 11, "X");

                    mr.PrintText(line, 15, new Tratamento().retornaValorEscritoCo(venda.Completos[ii].valorUnitario));
                    mr.PrintText(line, 23, "=");

                    if ((venda.Completos[ii].valorUnitario * venda.Completos[ii].quantidade) >= 100)
                        mr.PrintText(line, 26, new Tratamento().retornaValorEscritoCo((venda.Completos[ii].valorUnitario * venda.Completos[ii++].quantidade)));
                    else
                        mr.PrintText(line, 25, new Tratamento().retornaValorEscritoCo((venda.Completos[ii].valorUnitario * venda.Completos[ii++].quantidade)));
                    mr.PrintText(line++, 37, "|");
                }

                mr.PrintText(line++, 01, pont);
                mr.PrintText(line++, 01,cc.fixCenter( "FORMA DE PAGAMENTO : "+formaPagamento, 1));
                mr.PrintText(line, 01, "|"); mr.PrintText(line, 18, ("TOTAL RS : " + new Tratamento().retornaValorEscrito(venda.valorTotal))); mr.PrintText(line++, 37, "|");
                mr.PrintText(line, 01, "|"); mr.PrintText(line, 18, ("DINHEIRO : " + new Tratamento().retornaValorEscrito(dinheiro))); mr.PrintText(line++, 37, "|");
                mr.PrintText(line, 01, "|"); mr.PrintText(line, 18, ("TROCO    : " + new Tratamento().retornaValorEscrito(troco))); mr.PrintText(line++, 37, "|");
                mr.PrintText(line++, 01, pont);
                //--------------------------------
             

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
                lerArquivo();

            }
            catch { }
        }
        public void gerarComprovante()
        {
           int qtdLinha = 28 + (venda.Completos.Length * 2);
           qtdLinha *= 11;
           qtdLinha += 70;
            this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 304, qtdLinha);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            try
            {
                Reporter mr = new Reporter();
                EpsonCodes mer = new EpsonCodes();
                if (File.Exists(endereco))
                    File.Delete(endereco);

                mr.Output = endereco;
                mr.StartJob();
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
                mr.PrintText(line++, 01, "| ID |COD |     DESCRICAO    |CATEG |");//id casa 1  - cod casa 7 -  desc - casa 12 - categ casa 32
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
                    if (tam.Length > 7) tam = tam.Substring(0, 7); mr.PrintText(line, 29, tam);  mr.PrintText(line++, 37, "|");
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
                mr.PrintText(line++, 01, cc.fixRightPont("TOTAL RS : " + new Tratamento().retornaValorEscrito(venda.valorTotal),1));
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
                lerArquivo();

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
                Font fonteImpressao = new Font("Arial", sizeLetra);

                SolidBrush mCaneta = new SolidBrush(Color.Black);

                if (linePorFolha == 0)
                    linhasPorPagina = 100 + venda.Completos.Length;
                else linhasPorPagina = linePorFolha;
                while (contador < linhasPorPagina && ((linha = leitor.ReadLine()) != null))
                {
                    yPosicao = margemSuperior + (contador * fonteImpressao.GetHeight(e.Graphics));

                    StringFormat ww = new StringFormat(StringFormatFlags.FitBlackBox);

                    int mult = 1;
                    //if (sizeLetra != 7)                        mult = 2;
                    //ww.Alignment = StringAlignment.Center;
                    char[] letra = linha.ToCharArray();
                    float x = margemEsquerda;
                    int u = 0;

                    while (u <= letra.Length-1)
                    {
        
                            x += sizeLetra;// 7 ou 14
                            x +=  (0.5f * mult);
                            if (letra[u].Equals('i') || letra[u].Equals('l') || letra[u].Equals('I'))
                            {
                                e.Graphics.DrawString
                                   (letra[u++].ToString(), fonteImpressao, mCaneta,
                                   (x + (3*mult)), yPosicao, ww);
                            }
                            else
                            {
                                if (u > 0 && letraGrande(letra[u - 1], letra[u]))
                                {
                                    e.Graphics.DrawString
                                    (letra[u++].ToString(), fonteImpressao, mCaneta,
                                    (x + (1.5f* mult)), yPosicao, ww);
                                }
                                else
                                {
                                    e.Graphics.DrawString
                                    (letra[u++].ToString(), fonteImpressao, mCaneta,
                                    (x* mult), yPosicao, ww);
                                }

                            }
                    /*    }
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
        private bool letraGrande(char ant, char atual)
        {
            if (ant == 'G' || ant == 'Q' || ant == 'm' || ant == 'M' || ant == 'O' || ant == 'A' || ant == 'B')
                return true;
            else return false;
        }
        private void lerArquivo()
        {
            PrintDialog print = new PrintDialog();

            print.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 380, 2000);    // 500;
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
