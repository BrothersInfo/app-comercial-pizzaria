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
        string conexao = "server=Localhost; Port=5432;User =postgres;Password=fof0130407*;Database=Delirius";
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

            //-----------GARCON DA VENDA ---------------------------------------------------------
            DataTable garc = new DataTable();

            string garcon;
             garcon =
            "select g.cod_garcon, g.nome " +
            "from garcon g inner join GarconCompleto cg " +
            "on (cg.cod_garcon = g.cod_garcon) 	inner join completo c " +
            "on (c.cod_completo = cg.cod_completo)	inner join vendaCompleta vg " +
            "on (vg.cod_completo = c.cod_completo)	inner join venda v " +
            "on (v.cod_venda = vg.cod_venda)	" +
            "where v.cod_venda = "+cod_venda+" group by g.nome, g.cod_garcon";



            new NpgsqlDataAdapter(garcon, Conectar()).Fill(garc);
            int[] garcons = new int[garc.Rows.Count];
            for (int j = 0; j < garc.Rows.Count; j++)
                garcons[j] = Convert.ToInt16(garc.Rows[j].ItemArray.GetValue(0));
            //-------------------------------------------------------------------------------------
            DataTable numero = new DataTable();
            string queryC = "select count(cod_completo) from vendacompleta where cod_venda =" + cod_venda;
            new NpgsqlDataAdapter(queryC, Conectar()).Fill(numero);

            conjCompleto = new Completa[Convert.ToInt16(numero.Rows[0].ItemArray.GetValue(0))];
            string queryComplet = "select c.cod_completo from completo c inner join vendaCompleta vc on (vc.cod_completo = c.cod_completo)" +
                                  " inner join venda v on (v.cod_venda = vc.cod_venda)" +
                                  " where v.cod_venda = " + cod_venda;
            numero = new DataTable();
            new NpgsqlDataAdapter(queryComplet, Conectar()).Fill(numero);

            for (int j = 0; j < conjCompleto.Length; j++)
            {
                string querySubProduto = "select p.cod_produto,cp.porcentagem , c.valorUnitarioCompleto ,c.quantidade ,cp.cod_tamanho  " +
            " from completo c inner join completoProduto cp on (c.cod_completo = cp.cod_completo)" +
            " inner join produto p on( p.cod_produto = cp.cod_produto) where c.cod_completo = " + (int)numero.Rows[j].ItemArray.GetValue(0);
                DataTable sub = new DataTable();
                new NpgsqlDataAdapter(querySubProduto, Conectar()).Fill(sub);
                Produto[] subProdutos = new Produto[sub.Rows.Count];
                for (int k = 0; k < sub.Rows.Count; k++)
                {
                    subProdutos[k] = new Produto();
                    subProdutos[k].setLoad(
                        Convert.ToInt16(sub.Rows[k].ItemArray.GetValue(0)),
                        Convert.ToInt16(sub.Rows[k].ItemArray.GetValue(1)),
                        Convert.ToDouble(sub.Rows[k].ItemArray.GetValue(2)),
                        Convert.ToInt16(sub.Rows[k].ItemArray.GetValue(4)),
                        Convert.ToInt16(sub.Rows[k].ItemArray.GetValue(3))
                        , new Banco().isImpressoProduto(Convert.ToInt16(sub.Rows[k].ItemArray.GetValue(0)))
                        );

                }
                conjCompleto[j] = new Completa(subProdutos, Convert.ToInt16(sub.Rows[0].ItemArray.GetValue(3)),
                    (int)numero.Rows[j].ItemArray.GetValue(0));
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
                    mesa, 
                    garcons);

                saida.super = retornoSuper(cod_venda);
                return saida;
            }
            catch
            {
                VendaFull saida = new VendaFull(conjCompleto, cod_venda, 1, 0, null, null, mesa, garcons);
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
        public string tamanhoDescricao(int cod_tamanho)
        {
            DataTable tamanho = new DataTable();
            new NpgsqlDataAdapter
            ("select descricao from tamanho where cod_tamanho = " + cod_tamanho, Conectar()).Fill(tamanho);

            return tamanho.Rows[0].ItemArray.GetValue(0).ToString();

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
        public void retirarProdutoOuQuantidade(int cod_venda, int cod_produto, int quantidadeAtual, int quantidadeRetirada)
        {
            string x;
            string y;
            //UPDATE completo   SET quantidade = y  WHERE cod_completo = x
            if (quantidadeAtual == quantidadeRetirada)//retirada total
            { x = "DELETE FROM vendacompleta WHERE cod_venda = " + cod_venda + " and cod_completo = " + cod_produto;

            y = "DELETE FROM garconcompleto WHERE cod_completo = "+cod_produto;
            }
            
            else { x = "UPDATE completo   SET quantidade = " + (quantidadeAtual - quantidadeRetirada) + "  WHERE cod_completo = " + cod_produto;
            y = 
                "DELETE FROM garconcompleto where cod_completo = "+ cod_produto +" and horario in ("+
                "select gc.horario from garconCompleto gc where gc.cod_completo = " + cod_produto + " order by gc.horario desc limit " + (quantidadeAtual - quantidadeRetirada) + " )";
            }

            DataTable compl = new DataTable();
            new NpgsqlDataAdapter(x, Conectar()).Fill(compl);
            compl = new DataTable();
            new NpgsqlDataAdapter(y, Conectar()).Fill(compl);

        }
        //------------------------------------------------ ANULAR VENDA
        public void anularVenda(int cod_venda, bool isBalcao)
        {
            DataTable compl = new DataTable();
            DataTable conjCompleto = new DataTable();
            string completos = "select cod_completo from VendaCompleta where cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(completos, Conectar()).Fill(conjCompleto);



            string vendaCompleta = "Delete From vendaCompleta where cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(vendaCompleta, Conectar()).Fill(compl);

            for (int i = 0; i < conjCompleto.Rows.Count; i++)
            {
                DataTable tt = new DataTable();
                string completoP = "Delete From CompletoProduto where cod_completo  = "
                    + Convert.ToInt16(conjCompleto.Rows[i].ItemArray.GetValue(0));
                new NpgsqlDataAdapter(completoP, Conectar()).Fill(tt);

                string y = "DELETE FROM garconcompleto WHERE cod_completo = "  + Convert.ToInt16(conjCompleto.Rows[i].ItemArray.GetValue(0));
                new NpgsqlDataAdapter(y, Conectar()).Fill(tt);
                tt = new DataTable();
                string completo = "Delete From Completo where cod_completo  = "
                    + Convert.ToInt16(conjCompleto.Rows[i].ItemArray.GetValue(0));

                tt = new DataTable();
                new NpgsqlDataAdapter(completo, Conectar()).Fill(tt);
            }
            
            string[] mesas = mesasDaVenda(cod_venda);
            if(!isBalcao)
            for (int i = 0; i < mesas.Length; i++)
                retirarMesa(codMesaPelaDescricao(mesas[i]), cod_venda);


            string vendaMesa = "Delete From vendamesa where cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(vendaMesa, Conectar()).Fill(compl);
            DataTable ttt = new DataTable();
            //--------------MUDANCA OU DELETANDO GARCON
            string query3 = "select cod_super from superVenda where cod_venda = " + cod_venda;  //vejo qual o codigo Super
            new NpgsqlDataAdapter(query3, Conectar()).Fill(ttt);

            string query4 = "select cod_venda from supervenda where cod_super = " + Convert.ToInt16(ttt.Rows[0].ItemArray.GetValue(0))
                + " and cod_venda <> " + cod_venda + " order by cod_venda asc limit 1";//vejo um outro codigo venda para a reposicao dos garcons
            ttt = new DataTable();

            new NpgsqlDataAdapter(query4, Conectar()).Fill(ttt);

            string quer = "delete from supervenda where cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(quer, Conectar()).Fill(compl);
            string venda = "delete from venda where cod_venda = " + cod_venda;
            new NpgsqlDataAdapter(venda, Conectar()).Fill(compl);

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
        public VendaFull aplicarHalfVenda(VendaFull venda)
        {
            new VendaFull(venda.subItem.Completos, 2, venda.cod_caixa, venda.subItem.valorTotal, venda.subItem.horario, venda.dia, venda.mesa, venda.garcon);
            return null;
        }
        public void novaMeiaVenda(VendaFull vendaHalf)//esse metodo FAZ A VENDA. é um METODO PARA ENCERRAR!!
        {
            DataTable dtt = new DataTable();
            //nova venda
            string query1 = "INSERT INTO venda(valortotal, datavenda, horario, cod_caixa, aberta, impressao)  VALUES "
                                            + "( " + new Tratamento().retornaValorEscrito(vendaHalf.valorTotal).Replace(',', '.')
                                            + " ,current_date,current_time,'" + vendaHalf.cod_caixa + "' ,false, true)";
            new NpgsqlDataAdapter(query1, Conectar()).Fill(dtt);
            dtt = new DataTable();
            new NpgsqlDataAdapter("select cod_venda from venda order by cod_venda desc limit 1", Conectar()).Fill(dtt);
            int cod_venda = Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));
            superVendas(vendaHalf.super, cod_venda);
            receber(vendaHalf.cod_pagamento, cod_venda);
            for (int i = 0; i < vendaHalf.mesa.Length; i++)
            {
                int codig = new Banco().cod_mesa(vendaHalf.mesa)[i];
                new NpgsqlDataAdapter("INSERT INTO vendaMesa(cod_venda, cod_mesa)  VALUES ('" + cod_venda + "' , '" + codig + "')", Conectar()).Fill(new DataTable());

            }
            for (int i = 0; i < vendaHalf.Completos.Length; i++)
                trocarCompleto(cod_venda, vendaHalf.Completos[i]);


        }
        public void trocarCompleto(int cod_venda, Completa produto)
        {
            DataTable dtt = new DataTable();
            string query = "select quantidade from vendaCOmpletA v inner join completo c on(v.cod_completo = c.cod_completo) where v.cod_completo = " + produto.cod_completo;
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            int qtd = Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));//eu tinha 2 produtos no local anterior
            if (produto.quantidade == qtd) // transferencia total. tira do antigo e coloca no novo. ou seja, alter table na tabela.
            {

                query = "UPDATE vendacompleta SET cod_venda = " + cod_venda + " WHERE  cod_completo= " + produto.cod_completo;
                new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            }
            else // transferencia parcial. diminui de um, cria um novo codigo, e duplica o segundo!
            {
                string query1 = " INSERT INTO completo(valorunitariocompleto, quantidade) VALUES ( '" + new Tratamento().retornaValorEscrito(produto.valorUnitario).Replace(',', '.') + "'," + produto.quantidade + ")";
                //crio um novo completo , com a quantidade nova
                new NpgsqlDataAdapter(query1, Conectar()).Fill(dtt);
                //preciso associar esse produto a esta venda
                int comp = new Banco().resgatarUltimaCompleto();
                //resgatei o valor desse novo completo para associar a venda q eu criei
                string query3 = "INSERT INTO vendacompleta( cod_venda, cod_completo) VALUES (" + cod_venda + "," + comp + " )";

                new NpgsqlDataAdapter(query3, Conectar()).Fill(dtt);

                for (int k = 0; k < produto.produto.Length; k++)
                {
                    string query4 = "INSERT INTO completoproduto(cod_completo, cod_produto, porcentagem, cod_tamanho) VALUES ("
                        + comp + "," + produto.produto[k].cod_produto + "," + (produto.produto[k].porcentagem * 100) + "  , " + produto.produto[k].cod_tamanho + ")";
                    new NpgsqlDataAdapter(query4, Conectar()).Fill(dtt);
                }
                // ao chegar aqui, ja tenho o produto associado a nova venda, mas nao removi a quantidade da venda anterior, nem associei garcon.
                //string query6 = "INSERT INTO   completogarcon(cod_completo, cod_garcon , quantidade) VALUES ( "+comp+", "+produto.cod_garcon+","+ 1 +")";
                //new NpgsqlDataAdapter(query6, Conectar()).Fill(dtt);
                qtd = (qtd - produto.quantidade);
                string query2 = "update completo set quantidade = " + qtd + " where cod_completo = " + produto.cod_completo;
                new NpgsqlDataAdapter(query2, Conectar()).Fill(dtt);
            }


        }
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
            string query = "select p.cod_produto, cp.porcentagem, c.valorUnitarioCompleto , cp.cod_tamanho,  c.quantidade" +
                            " from completoProduto cp inner join Produto p on (p.cod_produto = cp.cod_produto)" +
                            " inner join completo c on (c.cod_completo = cp.cod_completo) where c.cod_completo = " + cod_completo;
            DataTable t = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(t);

            Produto[] conjunto = new Produto[t.Rows.Count];
            for (int i = 0; i < t.Rows.Count; i++)
            {
                conjunto[i] = new Produto();
                conjunto[i].setLoad(Convert.ToInt16(t.Rows[i].ItemArray.GetValue(0)),
                                    Convert.ToDouble(t.Rows[i].ItemArray.GetValue(1)),
                                    Convert.ToDouble(t.Rows[i].ItemArray.GetValue(2)),
                                    Convert.ToInt16(t.Rows[i].ItemArray.GetValue(3)),
                                    Convert.ToInt16(t.Rows[i].ItemArray.GetValue(4)),
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
        public Completa getCompleta(int cod_completa)
        {
            string query = "select quantidade from completo where cod_completo = " + cod_completa;
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            return new Completa(getProduto(cod_completa), Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)), cod_completa);


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
