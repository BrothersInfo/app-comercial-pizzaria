using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;
using System.Collections;


namespace Pizzaria.Banco
{


    using Pizzaria.Classes;
    public class BancoVenda
    {
         string conexao;
        //-------------------------------------
        //novos metodos
        //-------------------------------------
        
        public BancoVenda()
        {
            conexao = new BancoSenha().conexao;
        }
        
        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(conexao);
        }
        public void encerrarVenda(double valor, int cod_venda, string[] mesas, bool isBalcao)
        {

            new NpgsqlDataAdapter("UPDATE venda   SET aberta = false, valortotal = '" + new Tratamento().retornaValorEscrito(valor).Replace(',', '.') + "' WHERE cod_venda = " + cod_venda, Conectar()).Fill(new DataTable());

            int[] i = new Banco().cod_mesa(mesas);
            if(!isBalcao)
            for (int j = 0; j < i.Length; j++)
                new Banco().disponibilizarMesa(i[j]);
        }
        public string[] mesasDaVenda(int cod_venda)
        {
            DataTable dttMesa = new DataTable();
            NpgsqlDataAdapter a = new NpgsqlDataAdapter
                    (" select m.descricao from mesa m " +
                    " inner join vendaMesa vm on (m.cod_mesa = vm.cod_mesa) " +
                    " inner join venda v on (v.cod_venda = vm.cod_venda) " +
                    " where  v.aberta = true and m.status = false and v.cod_venda = " + cod_venda, Conectar());
            a.Fill(dttMesa);
            string[] mesa = new string[dttMesa.Rows.Count];
            for (int j = 0; j < dttMesa.Rows.Count; j++)
                mesa[j] = dttMesa.Rows[j].ItemArray.GetValue(0).ToString();
            return mesa;
        }
        public VendaFull carregaVenda(int cod_venda)
        {
            Completa[] conjCompleto;

            DataTable dttVenda = new DataTable();
            //--------CARREGAR MESA ------------------
            DataTable dttMesa = new DataTable();
            NpgsqlDataAdapter a = new NpgsqlDataAdapter
                    (" select m.descricao from mesa m " +
                    " inner join vendaMesa vm on (m.cod_mesa = vm.cod_mesa) " +
                    " inner join venda v on (v.cod_venda = vm.cod_venda) " +
                    " where  v.aberta = true and m.status = false and v.cod_venda = " + cod_venda, Conectar());
            a.Fill(dttMesa);
            string[] mesa = new string[dttMesa.Rows.Count];
            for (int j = 0; j < dttMesa.Rows.Count; j++)
                mesa[j] = dttMesa.Rows[j].ItemArray.GetValue(0).ToString();

            
         
            //-------------------------------------------------------------------------------------
            DataTable numero = new DataTable();
            string queryC = "select count(vc.cod_completo) from vendacompleta vc inner join completo c on (c.cod_completo = vc.cod_completo)"
                +" where cod_venda =" + cod_venda+" and c.cancelado  = false ";
            new NpgsqlDataAdapter(queryC, Conectar()).Fill(numero);

            conjCompleto = new Completa[Convert.ToInt16(numero.Rows[0].ItemArray.GetValue(0))];
            string queryComplet = "select c.cod_completo from completo c inner join vendaCompleta vc on (vc.cod_completo = c.cod_completo)" +
                                  " inner join venda v on (v.cod_venda = vc.cod_venda)" +
                                  " where v.cod_venda = " + cod_venda+ " and c.cancelado = false";
            numero = new DataTable();
            new NpgsqlDataAdapter(queryComplet, Conectar()).Fill(numero);


            for (int j = 0; j < conjCompleto.Length; j++)
            {
                //-----------GARCON DO PRODUTO ---------------------------------------------------------

                string garconA = "select g.cod_garcon,sum(quantidade) from garcon g inner join garconCompleto gc on(g.cod_garcon = gc.cod_garcon) " +
                    "inner join completo c on(c.cod_completo = gc.cod_completo) where c.cod_completo = "
                    + (int)numero.Rows[j].ItemArray.GetValue(0) +" and cancelado = false "
                    + " group by g.cod_garcon";
                DataTable garc = new DataTable();

                new NpgsqlDataAdapter(garconA, Conectar()).Fill(garc);

                string querySubProduto = "select p.cod_produto,cp.porcentagem , c.valorUnitarioCompleto ,cp.cod_tamanho  " +
            " from completo c inner join completoProduto cp on (c.cod_completo = cp.cod_completo)" +
            " inner join produto p on( p.cod_produto = cp.cod_produto) where c.cod_completo = " + (int)numero.Rows[j].ItemArray.GetValue(0) 
            + " and c.cancelado = false ";
                DataTable sub = new DataTable();
                new NpgsqlDataAdapter(querySubProduto, Conectar()).Fill(sub);
                GarconFisico[] gf = new GarconFisico[garc.Rows.Count];
                for (int k = 0; k < garc.Rows.Count; k++)
                {
                    gf[k] = new GarconFisico();
                    gf[k].setGarcon(Convert.ToInt16(garc.Rows[k].ItemArray.GetValue(0)), Convert.ToInt16(garc.Rows[k].ItemArray.GetValue(1)));
                }

                
                Produto[] subProdutos = new Produto[sub.Rows.Count];
                for (int k = 0; k < sub.Rows.Count; k++)
                {
                    int teste = new BancoInformacao().quantidadeCompletaByCodigo((int)numero.Rows[j].ItemArray.GetValue(0));
                    subProdutos[k] = new Produto();
                    subProdutos[k].setLoad(
                        Convert.ToInt16(sub.Rows[k].ItemArray.GetValue(0)),
                        Convert.ToDouble(sub.Rows[k].ItemArray.GetValue(1)),
                        Convert.ToDouble(sub.Rows[k].ItemArray.GetValue(2)),
                        Convert.ToInt16(sub.Rows[k].ItemArray.GetValue(3)),
                        //preciso fazer saber a quantidade de produtos
                      
                        new Banco().isImpressoProduto(Convert.ToInt16(sub.Rows[k].ItemArray.GetValue(0)))
                        );

                }
                conjCompleto[j] = new Completa(subProdutos,
                    (int)numero.Rows[j].ItemArray.GetValue(0),gf);
            }
            //---------------------------------------------------------------
            string query = "select valorTotal, dataVenda, horario, cod_caixa, aberta,impressao, cod_pagamento from venda where cod_venda =" + cod_venda;
            numero = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(numero);

            try
            {
                VendaFull saida = 
                    new VendaFull(
                        conjCompleto, 
                        cod_venda, 
                        (int)numero.Rows[0].ItemArray.GetValue(3), 
                        (double)numero.Rows[0].ItemArray.GetValue(0),
                    numero.Rows[0].ItemArray.GetValue(2).ToString(), 
                    numero.Rows[0].ItemArray.GetValue(1).ToString(), 
                    mesa);

                saida.super = retornoSuper(cod_venda);
                return saida;
            }
            catch
            {
                VendaFull saida = new VendaFull(conjCompleto, cod_venda, 1, 0, null, null, mesa);
                saida.super = retornoSuper(cod_venda);
                return saida;
            }

        }
        public int retornoSuper(int cod_venda)
        {
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter
            ("select cod_super from superVenda where cod_venda = " + cod_venda, Conectar()).Fill(dtt);

            return Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0).ToString());


        }
        
        public string nomeGarcon(int cod_garcon)
        {
            DataTable tamanho = new DataTable();
            new NpgsqlDataAdapter
            ("select nome from garcon where cod_garcon =  " + cod_garcon, Conectar()).Fill(tamanho);

            return tamanho.Rows[0].ItemArray.GetValue(0).ToString();

        }

        public string nomeAmbiente(string mesa)
        {
            DataTable tamanho = new DataTable();
            new NpgsqlDataAdapter
            ("select a.descricao from ambiente a inner join mesa m  on (a.cod_ambiente = m.cod_ambiente)   where m.descricao = '" + mesa + "'", Conectar()).Fill(tamanho);

            return tamanho.Rows[0].ItemArray.GetValue(0).ToString();

        }
        public string nomeVendedor(int cod_vend)
        {
            DataTable compl = new DataTable();
            string x = "select nomecaixa from caixa where cod_caixa = " + cod_vend;
            new NpgsqlDataAdapter(x, Conectar()).Fill(compl);

            return compl.Rows[0].ItemArray.GetValue(0).ToString();
        }
        public void inserirMesaIntoVenda(int cod_venda, int cod_mesa)
        {
            DataTable compl = new DataTable();
            string x = "UPDATE mesa  SET  status= false  WHERE cod_mesa = " + cod_mesa;

            new NpgsqlDataAdapter(x, Conectar()).Fill(compl);
            x = "INSERT INTO vendamesa(cod_venda, cod_mesa)   VALUES (" + cod_venda + "," + cod_mesa + " )";
            new NpgsqlDataAdapter(x, Conectar()).Fill(compl);
        }
        private void retirarMesa(int cod_mesa, int cod_venda)
        {
            DataTable compl = new DataTable();
            string x = "UPDATE mesa  SET  status= true  WHERE cod_mesa = " + cod_mesa;

            new NpgsqlDataAdapter(x, Conectar()).Fill(compl);
            x = "DELETE FROM vendamesa WHERE cod_mesa = " + cod_mesa + " and cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(x, Conectar()).Fill(compl);
        }
        public void removerMesaIntoVenda(int cod_venda, int cod_mesa)
        {
            int[] mesa = new Banco().cod_mesa(mesasDaVenda(cod_venda));

            if (mesa.Length == 1) return;
            for (int i = 0; i < mesa.Length; i++)

                if (mesa[i] == cod_mesa)
                {
                    retirarMesa(cod_mesa, cod_venda);
                    return;
                }

        }
        public int codMesaPelaDescricao(string nomeMesa)
        {
            DataTable compl = new DataTable();
            string x = "select cod_mesa from mesa where descricao = '" + nomeMesa + "'";
            new NpgsqlDataAdapter(x, Conectar()).Fill(compl);

            return Convert.ToInt16(compl.Rows[0].ItemArray.GetValue(0));

        }
        //------------------------------------------------  RETIRAR PRODUTO --------------------------------------
       
        //------------------------------------------------ ANULAR VENDA
        public void anularVenda(int cod_venda, bool isBalcao)
        {
           string []mesas =   mesasDaVenda(cod_venda);
              for (int i = 0; i < mesas.Length; i++)
            {
                new Banco().disponibilizarMesa(codMesaPelaDescricao(mesas[i]));
              }
            DataTable compl = new DataTable();
            DataTable conjCompleto = new DataTable();
            string completos = "select cod_completo from VendaCompleta where cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(completos, Conectar()).Fill(conjCompleto);
             
            double valor = 0;
            for (int i = 0; i < conjCompleto.Rows.Count; i++)
            {
                string vlr = "select valorUnitarioCompleto from completo where cod_completo = " + Convert.ToInt16(conjCompleto.Rows[i].ItemArray.GetValue(0));
                DataTable vl = new DataTable();
                new NpgsqlDataAdapter(vlr, Conectar()).Fill(vl);
                double info = Convert.ToDouble(vl.Rows[0].ItemArray.GetValue(0)); 
                int quantidade = new BancoInformacao().quantidadeCompletaByCodigo(Convert.ToInt16(conjCompleto.Rows[i].ItemArray.GetValue(0)));
                valor+= ( info * quantidade);

                string completo = "update Completo set cancelado = true where cod_completo  = "
                    + Convert.ToInt16(conjCompleto.Rows[i].ItemArray.GetValue(0));

                DataTable dt = new DataTable();
                new NpgsqlDataAdapter(completo, Conectar()).Fill(dt);
            }
            string vendas = "update venda set valortotal = " + new Tratamento().retornaValorEscrito(valor).Replace(',', '.') + ", cancelado = true, aberta = false, horario = current_time where cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(vendas, Conectar()).Fill(compl);
        }
        public void unirVendas(string [] mesasDaVenda, string mesaDestino)
        {
          int[] vendas = new int[mesasDaVenda.Length];
          for (int i = 0; i < mesasDaVenda.Length; i++)
          {
              vendas[i] = new Banco().codigoDaVendaPelaMesa(mesasDaVenda[i]);
              string query = "update vendaCompleta set cod_venda = " + new Banco().codigoDaVendaPelaMesa(mesaDestino) + " where cod_venda = " + vendas[i];;
              string query2 = "update vendaMesa set  cod_venda = " + new Banco().codigoDaVendaPelaMesa(mesaDestino) + " where cod_venda = " + vendas[i];
              string query3 = "update supervenda set cod_venda = " + new Banco().codigoDaVendaPelaMesa(mesaDestino) + " where cod_venda = " + vendas[i]; ;

              string query4 = "delete from venda where cod_venda = " + vendas[i]; 
             

              new NpgsqlDataAdapter(query, Conectar()).Fill(new DataTable());
              new NpgsqlDataAdapter(query2, Conectar()).Fill(new DataTable());
              new NpgsqlDataAdapter(query3, Conectar()).Fill(new DataTable());
              if(mesasDaVenda[i]!=mesaDestino)
              new NpgsqlDataAdapter(query4, Conectar()).Fill(new DataTable());
          }
          
        }

        public void imprimiu(int cod_venda)
        {

            string query = "UPDATE venda   SET  impressao= true WHERE cod_venda = " + cod_venda;

            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

        }//true para impresso
        public void naoImprimiu(int cod_venda)
        {

            string query = "UPDATE venda   SET  impressao= false WHERE cod_venda = " + cod_venda;

            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

        }
        public bool isImpresso(int cod_venda)
        {

            string query = "select count (*) from venda where cod_venda = " + cod_venda + " and impressao = true";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;

        }
        //-----------------------------------------------------------------------
   
        public void receber(int cod_pagar, int cod_venda)
        {
            DataTable dtt = new DataTable();
            string query = "update venda set cod_pagamento = " + cod_pagar + "where cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
        }
        public int superVenda(int cod_venda)//usada no inicio da primeira venda.
        {
            DataTable dtt = new DataTable();
            string query1 = "INSERT INTO super( valor_total, encerrada) VALUES (0,false )";
            new NpgsqlDataAdapter(query1, Conectar()).Fill(dtt);
            dtt = new DataTable();
            int super;
            try
            {
                dtt = new DataTable();
                new NpgsqlDataAdapter("select cod_super from super order by cod_super desc limit 1", Conectar()).Fill(dtt);
                super = Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));
            }
            catch { super = 1; }
            dtt = new DataTable();
            string query = "INSERT INTO superVenda(cod_super, cod_venda) VALUES (" + super + "," + cod_venda + " )";
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);

            return super;
        }
        public void superVendas(int cod_super, int cod_venda)//serve para acrescentar super venda 
        {
            DataTable dtt = new DataTable();
            string query = "INSERT INTO supervenda( cod_super, cod_venda) VALUES (" + cod_super + "," + cod_venda + " )";
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
        }
        public void atualizaSuper(int cod_super, double valor)
        {
            DataTable dtt = new DataTable();
            string query = "update super set valor_total =(valor_total+"
                + new Tratamento().retornaValorEscrito(valor).Replace(',', '.')
                + "), encerrada = true where cod_super = " + cod_super;
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
        }
        public int consultaSuper(int cod_venda)
        {
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter("select cod_super from supervenda where cod_venda = " + cod_venda, Conectar()).Fill(dtt);
            return Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));

        }
        private Produto[] getProduto(int cod_completo)
        {
            string query = "select p.cod_produto, cp.porcentagem, c.valorUnitarioCompleto , cp.cod_tamanho " +
                            " from completoProduto cp inner join Produto p on (p.cod_produto = cp.cod_produto)" +
                            " inner join completo c on (c.cod_completo = cp.cod_completo) where c.cod_completo = " + cod_completo+ " and c.cancelado = false";
            DataTable t = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(t);

            Produto[] conjunto = new Produto[t.Rows.Count];
            for (int i = 0; i < t.Rows.Count; i++)
            {
                conjunto[i] = new Produto();
                conjunto[i].setLoadDividido(Convert.ToInt16(t.Rows[i].ItemArray.GetValue(0)),
                                    Convert.ToDouble(t.Rows[i].ItemArray.GetValue(1)),
                                    Convert.ToDouble(t.Rows[i].ItemArray.GetValue(2)),
                                    Convert.ToInt16(t.Rows[i].ItemArray.GetValue(3)),
                                   
                                     new Banco().isImpressoProduto(Convert.ToInt16(t.Rows[i].ItemArray.GetValue(0)))
                                    );
            }

            return conjunto;
        }
        public string formaPagamento(int codPagamento){

            string query = "select descricao from pagamento where cod_pagamento = " + codPagamento;
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
        return dtt.Rows[0].ItemArray.GetValue(0).ToString();
        }
        public Completa getCompleta(int cod_completa, bool cancelado)
        {
            string query = "select p.cod_produto,cp.porcentagem, c.valorUnitarioCompleto,cp.cod_tamanho,p.impresso "
                        +"from completo c inner join completoProduto cp on (cp.cod_completo = c.cod_completo) "
                        +"inner join produto p on (p.cod_produto = cp.cod_produto)"
                        +"where c.cod_completo = "+cod_completa+" and c.cancelado = "+cancelado;

            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            Produto [] produtos = new Produto[dtt.Rows.Count];
            for(int i = 0; i < produtos.Length;i++){
            
            produtos[i] = new Produto();
                produtos[i].setLoad(
                     Convert.ToInt16(  dtt.Rows[i].ItemArray.GetValue(0))
                    ,Convert.ToDouble(  dtt.Rows[i].ItemArray.GetValue(1))
                    ,Convert.ToDouble(  dtt.Rows[i].ItemArray.GetValue(2))
                    ,Convert.ToInt16(  dtt.Rows[i].ItemArray.GetValue(3))
                    ,Convert.ToBoolean(  dtt.Rows[i].ItemArray.GetValue(4)));
            }

            string garconA = "select g.cod_garcon,sum(quantidade) from garcon g inner join garconCompleto gc on(g.cod_garcon = gc.cod_garcon) " +
                "inner join completo c on(c.cod_completo = gc.cod_completo) where c.cod_completo = "
                + cod_completa + " and cancelado = false "
                + " group by g.cod_garcon";
            DataTable garc = new DataTable();

            new NpgsqlDataAdapter(garconA, Conectar()).Fill(garc);
            GarconFisico[] gf = new GarconFisico[garc.Rows.Count];
            for (int k = 0; k < garc.Rows.Count; k++)
            {
                gf[k] = new GarconFisico();
                gf[k].setGarcon  ( Convert.ToInt16( garc.Rows[k].ItemArray.GetValue(0)), Convert.ToInt16(garc.Rows[k].ItemArray.GetValue(1)));
            }
            return new Completa(produtos, cod_completa,gf);

        }
        public int qtdSegmentos()
        {
            string query = "select count(*)as \"Quantidade\" from tipo";
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            return Convert.ToInt16( dtt.Rows[0].ItemArray.GetValue(0));
        }
        public int codSegmentoByProduto(int cod_produto)
        {
            string query = "select t.cod_tipo from produto p inner join tipo t on (t.cod_tipo = p.cod_tipo) where p.cod_produto = "+ cod_produto;
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            return Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));
        }
    }
}
