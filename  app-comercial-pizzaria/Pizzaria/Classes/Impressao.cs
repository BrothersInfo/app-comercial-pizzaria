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
        //esse metodo é a atualizacao para a impressao. INICIO
        public Impressao()
        {
        }
        public Impressao(bool novo, VendaFull v)
        {
            venda = v;
        }
        public void novoMetodo(Completa[] produto, string[] mesa)
        {

            try
            {
                Reporter mr = new Reporter();
                EpsonCodes mer = new EpsonCodes();

                if (File.Exists(endereco))
                    File.Delete(endereco);

                mr.Output = endereco;
                mr.StartJob();
                Comanda cc = new Comanda(venda.cod_venda, true);
                string pont = "|---------------------------|";
                int line = 1;
                int limite = 29;
                mr.PrintText(line++, 01, "|----------COZINHA----------|");

                mr.PrintText(line, 01, "|Data:" + DateTime.Now.ToShortDateString()); mr.PrintText(line++, limite, "|");
                mr.PrintText(line, 01, "|Hora:" + DateTime.Now.ToShortTimeString()); mr.PrintText(line++, limite, "|");
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "|"); mr.PrintText(line++, limite, "|");
                //produto
                int ii = produto.Length;

                while (ii-- > 0)
                {
                    mr.PrintText(line, 1, "| - " + produto[ii].segmentoImprimir); mr.PrintText(line++, limite, "|");
                    string tam = new BancoInformacao().tamanhoDescricaoByCodigo(produto[ii].produto[0].cod_tamanho);
                    if (tam.Length > 18) tam = tam.Substring(0, 18);
                    mr.PrintText(line, 1, "|Tamanho- " + tam); mr.PrintText(line++, limite, "|");
                    for (int j = 0; j < produto[ii].produto.Length; j++)
                    {
                        string prod = new Banco().preencherNomeProdctAll(produto[ii].produto[j].cod_produto);
                        if (prod.Length > 27) prod = prod.Substring(0, 27);
                        mr.PrintText(line, 01, "|" + prod); mr.PrintText(line++, limite, "|");
                        mr.PrintText(line, 01, "|"); mr.PrintText(line, 6, "--" + (produto[ii].produto[j].porcentagem * 100) + " %"); mr.PrintText(line++, limite, "|");
                    }

                    mr.PrintText(line, 1, "|Quantidade - " + produto[ii].quantidade); mr.PrintText(line++, limite, "|");
                    string noticia = "";
                    int u = 0;
                    string nota = produto[ii].getNoticia(); string obs = "obs. "; int limit = limite -7;
                    while (u < nota.Length)
                    {
                        if (noticia.Length % limit == 0 && u >= limit)
                        {
                            mr.PrintText(line, 01, obs + noticia); mr.PrintText(line++, limite, "|"); noticia = ""; obs = ""; limit = limite-1;
                        }
                        noticia += produto[ii].getNoticia().Substring(u++, 1);
                    }
                    mr.PrintText(line, 01, "|" + noticia); mr.PrintText(line++, limite, "|"); noticia = "";
                    mr.PrintText(line++, 01, "| -- - -- - --  |");
                }
                //produto
                mr.PrintText(line++, 01, pont);
                if (produto[0].garconImprimir.Length > 15) produto[0].garconImprimir = produto[0].garconImprimir.Substring(0, 15);
                string garc = "|GARCON -" + produto[0].garconImprimir;
                mr.PrintText(line, 01, garc); mr.PrintText(line++, limite, "|");

                mr.PrintText(line, 01, "| " + mesa[mesa.Length - 1]); mr.PrintText(line++, limite, "|");
                mr.PrintText(line++, 01, pont);

                mr.PrintJob();
                mr.EndJob();

                ImprimirBematech(endereco, new Banco().getCodImpressoraByTipo(new BancoConsulta().cod_tipoPeloNome(new Banco().segmentoDoProduto(produto[0].produto[0].cod_produto))));


            }
            catch { }
        }
        // FIM ---- 
        private void ImprimirBematech(string StrArquivo, int cod_impressora)
        {
            DataTable impressora = new Banco().impressora(cod_impressora);
            MP2032.ConfiguraModeloImpressora(Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(2)));
            MP2032.IniciaPorta(impressora.Rows[0].ItemArray.GetValue(3).ToString());//se for internet a porta é o IP

            MP2032.AjustaLarguraPapel(48);
           
            try
            {
                using (StreamReader sr = new StreamReader(StrArquivo))
                {
                    String linha;
                    //Ler e exibe as linhas até alcançar o fim do arquivo.
                    while ((linha = sr.ReadLine()) != null)
                    {
                        MP2032.FormataTX(linha + "\r\n"
                            , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(4))
                            , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(5))
                            , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(6))
                            , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(7))
                            , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(8)));

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não é possivel ler o arquivo");
                MessageBox.Show(e.Message);
            }

            MP2032.AcionaGuilhotina(1);
            MP2032.FechaPorta();
        }
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

        DataTable impressora;
        public void inserirLinhaImpressao(string linha, int cod_enfatizado)
        {
            MP2032.FormataTX(linha + "\r\n"
               , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(4))
               , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(5))
               , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(6))
               , Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(7))
               , cod_enfatizado);
        }
        public void imprimirComanda(int cod_impressora, VendaFull vend )
        {
               try
            {

                impressora = new Banco().impressora(cod_impressora);
                
                   Comanda cc = new Comanda(vend.cod_venda);

          
                //
                string pont = "|----------------------------------------------|";
                string linha = "| ID da VENDA : " + vend.cod_venda; linha = linha.PadRight(47, ' '); linha += "|";
                string[] VETOR1 = new string[vend.Completos.Length];
                string[] VETOR2 = new string[vend.Completos.Length];
                  
                   int ii = 0; int i = vend.Completos.Length;
                   while (ii < i)
                   {
                       string ID = (ii + 1).ToString("000");

                       string CODPRODUTO = "" + vend.Completos[ii].produto[0].cod_produto.ToString("000"); // 3
                       string PRODUTO  = new Banco().preencherNomeProdctAll(vend.Completos[ii].produto[0].cod_produto); // 3
                       if (vend.Completos[ii].produto.Length > 1) PRODUTO = "mista " + PRODUTO; //18

                       if(PRODUTO.Length > 18 )    PRODUTO = PRODUTO.Substring(0, 18);
                       else                        PRODUTO = PRODUTO.PadRight(18,' ');


                       string TAMANHO = new BancoInformacao().tamanhoDescricaoByCodigo(vend.Completos[ii].produto[0].cod_tamanho); // 9
                       if(TAMANHO.Length > 9 )    TAMANHO = TAMANHO.Substring(0, 9);
                       else                        TAMANHO = TAMANHO.PadRight(9,' ');
                       linha = "| "+ID+ " - "+ CODPRODUTO + "   , "+ PRODUTO + " | " + TAMANHO + " |"; //48 
                       VETOR1[ii] = linha;
                       
                       

                       string QUANTIDADE =  vend.Completos[ii].quantidade.ToString("0.000").PadRight(6, ' ');//6

                       string UNITARIO = (vend.Completos[ii].valorUnitario).ToString("0.00").PadRight(8, ' ');//8
                       string VALORSOMADO = ( vend.Completos[ii].quantidade * vend.Completos[ii].valorUnitario).ToString("0.00");
                       
                       linha = ("|    "+ QUANTIDADE + "   X   "+ UNITARIO+ "        = "+ VALORSOMADO+"").PadRight(47,' ')+ "|";//48
                       VETOR2[ii] = linha;
                       ii++;    
                   }
                   string COMISSAO = "";
                   if (vend.valorComissao > 0)
                   {
                       COMISSAO = "COUVERT : " + String.Format("{0:C}", vend.valorComissao) + " |";
                       COMISSAO = "|" + COMISSAO.PadLeft(47, ' ');
                 
                   }
                   string VALORCOMANDA;
                   VALORCOMANDA = "VALOR TOTAL : " + String.Format("{0:C}", vend.valorSomado) + " |";
                   VALORCOMANDA = "|" + VALORCOMANDA.PadLeft(47, ' ');


                   //rotina GARCON
                   List<String> garcons = new List<string>();
                   for (int k = 0; k < vend.Completos.Length; k++)
                       for (int l = 0; l < vend.Completos[k].garcons.Length; l++)
                       {
                           bool can = true;
                           for (int m = 0; m < garcons.Count; m++)
                               if (garcons[m] == vend.Completos[k].garcons[l].nome)
                                   can = false;
                           if (can) garcons.Add(vend.Completos[k].garcons[l].nome);
                       }

                   int n = 0; string GARCON = "| GARCOM - ";
                   while (n < garcons.Count)
                       GARCON += garcons[n++] + " - ";
                   if (GARCON.Length > 47) GARCON = GARCON.Substring(0, 47);
                   GARCON = GARCON.PadRight(47, ' ') + "|";
                   string MESA = "";
                   for (int l = 0; l < vend.mesa.Length && l < 7; l++)
                       MESA += "| " + vend.mesa[l] + " ";
                   MESA = MESA.PadRight(47, ' ') + "|";
                   string CAIXA = "| CAIXA : " + new BancoVenda().nomeVendedor(vend.cod_caixa);
                   CAIXA = CAIXA.PadRight(47, ' ') + "|";
                   string HORARIOVENDA = "| Abertura : " + vend.horario + "  - Final : " + DateTime.Now.ToShortTimeString();
                   string LIMPO = "|";
                   LIMPO = LIMPO.PadRight(47, ' ') + "|";
                   HORARIOVENDA = HORARIOVENDA.PadRight(47, ' ') + "|";
                   string SUBLINADA = "|";
                   SUBLINADA = SUBLINADA.PadRight(47, '_') + "|";
                   
                   //IMRESSAO
                   MP2032.ConfiguraModeloImpressora(Convert.ToInt16(impressora.Rows[0].ItemArray.GetValue(2)));
                   MP2032.IniciaPorta(impressora.Rows[0].ItemArray.GetValue(3).ToString());//se for internet a porta é o IP
                   
                  MP2032.AjustaLarguraPapel(48);
                   MP2032.ImprimeBmpEspecial(Application.StartupPath + "logo.bmp", -1, -1, 0);
                   inserirLinhaImpressao(pont, 0);
                   inserirLinhaImpressao(cc.empresa, 0);
                   inserirLinhaImpressao(cc.telefone, 0);
                   inserirLinhaImpressao(pont, 0);
                   inserirLinhaImpressao(cc.titulo, 0);
                   inserirLinhaImpressao(pont, 0);
                   inserirLinhaImpressao("| ID | CODIGO |      DESCRICAO     | CATEGORIA |", 0);
                   inserirLinhaImpressao("|    QTD Unid  X  VALOR Unit       = SUB-TOTAL |", 0);
                   inserirLinhaImpressao(pont, 0);
                   for (int h = 0; h < VETOR1.Length; h++)
                   {
                       inserirLinhaImpressao(VETOR1[h], 0);
                       inserirLinhaImpressao(VETOR2[h], 0);
                   }
                   inserirLinhaImpressao(pont, 0);
                   if(vend.valorComissao >0)
                       inserirLinhaImpressao(COMISSAO, 0);
                   //IMPRESSAO DESDE VALOR ATE O FIM
                   inserirLinhaImpressao(VALORCOMANDA, 1);
                   inserirLinhaImpressao(pont, 0);
                   inserirLinhaImpressao(GARCON, 0);
                   inserirLinhaImpressao(MESA, 0);
                   inserirLinhaImpressao(pont, 0);
                   inserirLinhaImpressao(CAIXA, 0);
                   inserirLinhaImpressao(pont, 0);
                   inserirLinhaImpressao(HORARIOVENDA, 0);
                   inserirLinhaImpressao(pont, 0);
                   inserirLinhaImpressao(LIMPO, 0);
                   inserirLinhaImpressao(cc.mensagem, 0);
                   inserirLinhaImpressao(LIMPO, 0);
                   inserirLinhaImpressao(cc.cidade, 0);
                   inserirLinhaImpressao(cc.progNome, 0);
                   inserirLinhaImpressao(cc.progTelefone, 0);                   
                   inserirLinhaImpressao(SUBLINADA, 0);
                MP2032.AcionaGuilhotina(1);
                MP2032.FechaPorta();
                
            }
               catch { }
        }
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
                mr.PrintText(line, 01, "|Data:" + leitu.dataLeitura); mr.PrintText(line++, 37, "|");
                mr.PrintText(line, 01, "|Hora:" + DateTime.Now.ToShortTimeString()); mr.PrintText(line++, 37, "|");

                mr.PrintText(line++, 01, pont);
                //data e hora

                mr.PrintText(line++, 01, "|HORA  -VENDA- PAGAM -VALOR  -SITUAC|");//id casa 1  - cod casa 7 -  desc - casa 12 - categ casa 32
                mr.PrintText(line++, 01, pont);
                //itens
                {
                    for (int i = 0; i < leitu.itens.Count; i++)
                    {
                        mr.PrintText(line, 01, "|");
                        mr.PrintText(line, 02, leitu.itens[i].hora);
                        mr.PrintText(line, 08, "-");
                        mr.PrintText(line, 09, ""+leitu.itens[i].cod_venda);
                        mr.PrintText(line, 15, "-");
                        mr.PrintText(line, 16, leitu.itens[i].formaPagamento.Substring(0,5));

                        mr.PrintText(line, 22, "-");
                        mr.PrintText(line, 23, new Tratamento().retornaValorEscrito( leitu.itens[i].valor));
                        mr.PrintText(line, 30,"-"+ leitu.itens[i].situac.Substring(0,6));
                        mr.PrintText(line++, 37, "|");
                    }

                }
                //itens

                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "|"); mr.PrintText(line, 15, ("TOTAL R$ " + new Tratamento().retornaValorEscrito(leitu.valorTotal))); mr.PrintText(line++, 37, "|");
                if (leitu.extorno > 0)
                { mr.PrintText(line, 01, "|"); mr.PrintText(line, 15, ("EXTORNO RS " + new Tratamento().retornaValorEscrito(leitu.extorno))); mr.PrintText(line++, 37, "|"); }
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
                mr.PrintText(line, 01, "|Data Impresao :" + DateTime.Now.ToShortDateString()); mr.PrintText(line++, 37, "|");
                mr.PrintText(line++, 01, "|___________________________________|");


                mr.PrintJob();
                mr.EndJob();
                lerArquivo(0);

            }
            catch { }
        }

        public void gerarComandaCozinha(Completa[] produto, string[] mesa, bool reimpresso)
        {
            try
            {
                this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 304, 2000);
                printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
                Reporter mr = new Reporter();
                if (File.Exists(endereco))
                    File.Delete(endereco);

                mr.Output = endereco;
                mr.StartJob();
                //tamanho Interno 23

                Comanda cc = new Comanda(venda.cod_venda, true);
                string pont = "|---------------------|";
                int line = 1;
                //

                string cozinha = new Banco().carregaComandaCozinha();
                mr.PrintText(line++, 01, "|----" + cozinha + "----|");//13

                mr.PrintText(line, 01, "| Data : " + DateTime.Now.ToShortDateString()); mr.PrintText(line++, 23, "|");
                mr.PrintText(line, 01, "| Hora : " + DateTime.Now.ToShortTimeString()); mr.PrintText(line++, 23, "|");
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "|"); mr.PrintText(line++, 23, "|");
                //produto
                int ii = produto.Length;

                while (ii-- > 0)
                {
                    if (reimpresso)
                    {
                        mr.PrintText(line, 1, "| - REIMPRESSAO "); mr.PrintText(line++, 23, "|");
                    }
                    mr.PrintText(line, 1, "| - " + produto[ii].segmentoImprimir); mr.PrintText(line++, 23, "|");

                    string tam = new BancoInformacao().tamanhoDescricaoByCodigo(produto[ii].produto[0].cod_tamanho);
                    if (tam.Length > 14) tam = tam.Substring(0, 14);
                    mr.PrintText(line, 1, "| Especif. - " + tam); mr.PrintText(line++, 23, "|");
                    for (int j = 0; j < produto[ii].produto.Length; j++)
                    {
                        string prod = "Item - " + new Banco().preencherNomeProdctAll(produto[ii].produto[j].cod_produto);
                        if (prod.Length > 16) prod = prod.Substring(0, 16);
                        mr.PrintText(line, 01, "| " + prod); mr.PrintText(line++, 23, "|");
                        mr.PrintText(line, 1, "| PRECO UNITARIO - " + produto[ii].valorUnitario); mr.PrintText(line++, 23, "|");
                        if (produto[ii].produto[j].porcentagem != 1)
                        {
                            mr.PrintText(line, 01, "|");
                            mr.PrintText(line, 6, " -- " + (produto[ii].produto[j].porcentagem * 100) + " %");
                            mr.PrintText(line++, 23, "|");
                        }
                    }
                    mr.PrintText(line, 1, "|Quantidade - " + produto[ii].quantidade.ToString("0.000")); mr.PrintText(line++, 23, "|");
                    mr.PrintText(line, 1, "|Valor Item - " + (produto[ii].valorUnitario * produto[ii].quantidade).ToString("0.00")); mr.PrintText(line++, 23, "|");
                    //   mr.PrintText(line, 01, "|"); mr.PrintText(line++, 17, "|");
                    string noticia = "";
                    int u = 0;
                    string nota = produto[ii].getNoticia(); string obs = "obs. "; int limite = 16;
                    while (u < nota.Length)
                    {
                        if (noticia.Length % limite == 0 && u >= limite)
                        {
                            mr.PrintText(line, 01, obs + noticia); mr.PrintText(line++, 23, "|"); noticia = ""; obs = ""; limite = 22;
                        }
                        noticia += produto[ii].getNoticia().Substring(u++, 1);
                    }
                    mr.PrintText(line, 01, "|" + noticia); mr.PrintText(line++, 23, "|"); noticia = "";
                    mr.PrintText(line++, 01, "| --  -   --   -  --  |");
                }
                //produto
                mr.PrintText(line++, 01, pont);
                if (produto[0].garconImprimir.Length > 12) produto[0].garconImprimir = produto[0].garconImprimir.Substring(0, 12);
                string garc = "| GARCOM -" + produto[0].garconImprimir;
                mr.PrintText(line, 01, garc); mr.PrintText(line++, 23, "|");


                mr.PrintText(line, 01, "| " + mesa[mesa.Length - 1]); mr.PrintText(line++, 23, "|");
                mr.PrintText(line++, 01, pont);

                mr.PrintJob();
                mr.EndJob();
                lerArquivo(new Banco().getCodImpressoraByTipo(new BancoConsulta().cod_tipoPeloNome(new Banco().segmentoDoProduto(produto[0].produto[0].cod_produto))));
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message+ "info add:  "+ ee.Data);
            }
            }
        public string make48(string linha)
        {
            
            return linha.PadRight(48,' ');
        }
      
        public void gerarComandaNaoFiscal(string formaPagamento,double dinheiro, double troco)
        {
            int qtdLinha = 30 + (venda.Completos.Length * 2);
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
                mr.PrintText(line++, 01, pont);
                mr.PrintText(line, 01, "ID da VENDA : " + venda.cod_venda); mr.PrintText(line++, 37, "|");
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
                    string tam = new BancoInformacao().tamanhoDescricaoByCodigo(venda.Completos[ii].produto[0].cod_tamanho);
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
                if (venda.valorComissao > 0)
                {
                    mr.PrintText(line++, 01, cc.fixRightPont("COUVERT : " + new Tratamento().retornaValorEscrito(venda.valorComissao), 1));

                }

                mr.PrintText(line++, 01, pont);
                                mr.PrintText(line++, 01,cc.fixCenter( "FORMA DE PAGAMENTO : "+formaPagamento, 1));
               
                mr.PrintText(line, 01, "|"); mr.PrintText(line, 18, ("TOTAL RS : " + new Tratamento().retornaValorEscrito(venda.valorSomado))); 
                mr.PrintText(line++, 37, "|");
                mr.PrintText(line, 01, "|"); mr.PrintText(line, 18, ("DINHEIRO : " + new Tratamento().retornaValorEscrito(dinheiro))); 
                mr.PrintText(line++, 37, "|");
                mr.PrintText(line, 01, "|"); mr.PrintText(line, 18, ("TROCO    : " + new Tratamento().retornaValorEscrito(troco))); 
                mr.PrintText(line++, 37, "|");
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
                lerArquivo(1);

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
        private void lerArquivo(int cod_impressora)
        {
           
//  printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = print.PrinterSettings.DefaultPageSettings.PaperSize; //.PaperSize = new System.Drawing.Printing.PaperSize("fabricio", 300, 600);

            // printDialog1.Document = printDocument1;
           
            if (cod_impressora != 0)
            {
           
                ImprimirBematech(endereco, cod_impressora);
           
            }
            else
            {
                LerArquivoTexto(endereco);
                string x = comanda;
                leitor = new StringReader(x);
                printDocument1.DocumentName = "comanda.txt";
                // printDocument1.OriginAtMargins = true;
                PrintDialog print = new PrintDialog();

                print.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("comanda", 380, 2000);    // 500;
                print.PrinterSettings.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 10);

                printDocument1.DefaultPageSettings.Margins.Left = 0;
                printDocument1.DefaultPageSettings.Margins.Right = 0;
                printDocument1.DefaultPageSettings.Margins.Top = 0;
                printDocument1.DefaultPageSettings.Margins.Bottom = 0;

                printDocument1.Print();
            }
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
                    {

                        comanda += linha + "\n";
                    }
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
