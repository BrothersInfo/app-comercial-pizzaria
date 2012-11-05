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
    public class Banco
    {
        string conexao = "server=Localhost; Port=5432;User =postgres;Password=fof0130407*;Database=Delirius";
        //-------------------------------------
        //novos metodos
        //-------------------------------------
        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(conexao);
        }
        public void mudarQuantidade(int cod_venda, int cod_completo, int qtd, int cod_garcon)
        {

            new Banco().GarconCompleto(cod_garcon, cod_completo, qtd);
            DataTable dtt = new DataTable();
            string query1 = "UPDATE completo   SET  quantidade=(quantidade+ " + qtd + ")  WHERE cod_completo = " + cod_completo;
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter
                (query1, Conectar());
            sql.Fill(dtt);

            return;
          
        }
        public int codGarconPeloCompleto(int cod_completo)
        {
            DataTable dtt = new DataTable();
            string query = "select cod_garcon from garconCompleto where cod_completo =" + cod_completo + "order by horario desc limit 1";
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter               (query, Conectar());
            sql.Fill(dtt);
            return Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));
        }
        public bool jaTemProduto(int cod_venda, int cod_produto, int XcodTamanho, double valor, bool pct, int qtdade, int cod_garcon)
        {
            if (!pct) return false;

            string query = " select  c.cod_completo from venda v " +
                            "inner join vendaCompleta vc    on (vc.cod_venda    = v.cod_venda)" +
                            "inner join completo c          on (vc.cod_completo = c.cod_completo)" +
                            "inner join completoProduto cp  on (cp.cod_completo = c.cod_completo)" +
                                "where v.cod_venda = " + cod_venda + " and cp.cod_produto = " + cod_produto + " and cp.cod_tamanho = " + XcodTamanho + " and valorUnitarioCompleto = '" + new Tratamento().retornaValorEscrito(valor).Replace(',', '.') + "'";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            if (dtt.Rows.Count > 0)
            {
                mudarQuantidade(cod_venda, Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)), qtdade, cod_garcon);

                new Banco().GarconCompleto(cod_garcon, Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)), qtdade);
                return true;
            }
            return false;
        }
        public string trazerNomeMesa(int cod_venda)
        {
            //
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(
            "select m.descricao from venda v inner join vendaMesa vm on(vm.cod_venda = v.cod_venda)"
            + " inner join mesa m on (m.cod_mesa = vm.cod_mesa) " +
            "where v.aberta = true and m.status = false and v.cod_venda =" + cod_venda, Conectar());
            sql.Fill(dtt);

            return dtt.Rows[0].ItemArray.GetValue(0).ToString();

        }
        public int codigoProduto(string nomeProduto)
        {
            try
            {
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(
                "select cod_produto from produto where ativo = true and descricao =  '" + nomeProduto + "'", Conectar());
                sql.Fill(dtt);
                return Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));
            }
            catch { return 0; }
        }
        public DataTable codigoGarcon()
        {
            DataTable dttGarcon = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter("select cod_garcon,nome from garcon where ativo = true order by garcon.cod_garcon", Conectar());
            sql.Fill(dttGarcon);
            return dttGarcon;
        }
        public DataTable GarconDaVenda(int cod_venda)
        {
            DataTable dttGarcon = new DataTable();
            string garcon =
            "select g.cod_garcon, g.nome from garcon g inner join GarconCompleto cg on (cg.cod_garcon = g.cod_garcon) "+
            "inner join completo c on (c.cod_completo = cg.cod_completo) inner join vendaCompleta vg on (vg.cod_completo = c.cod_completo) "+
            "inner join venda v on (v.cod_venda = vg.cod_venda) where vg.cod_venda = "+cod_venda+" and  g.ativo = true group by g.cod_garcon, g.nome";
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(garcon, Conectar());
            sql.Fill(dttGarcon);
            return dttGarcon;
        }
        public bool temGarconIn(int cod_venda)
        {
            string query = 
            "select (count(g.cod_garcon))>0 as \"booleana\" "+
            "from garcon g inner join GarconCompleto cg on (cg.cod_garcon = g.cod_garcon) "+
            "inner join completo c on (c.cod_completo = cg.cod_completo) inner join vendaCompleta vg "
            +" on (vg.cod_completo = c.cod_completo) "+
            "inner join venda v on (v.cod_venda = vg.cod_venda) "+
            "where vg.cod_venda = "+cod_venda+" and g.ativo = true ";
            DataTable dttGarcon = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dttGarcon);
      
            return Convert.ToBoolean( dttGarcon.Rows[0].ItemArray.GetValue(0));
        }
        public DataTable GarconNaoUsadoPelaVenda(int cod_venda)
        {
            DataTable dttGarcon = new DataTable();
            string garcon = "select g.cod_garcon, g.nome from garcon g where g.ativo = true and  g.cod_garcon not in "+
            "(select g.cod_garcon from garcon g inner join GarconCompleto cg on (cg.cod_garcon = g.cod_garcon) "+
            "inner join completo c on (c.cod_completo = cg.cod_completo) inner join vendaCompleta vg on (vg.cod_completo = c.cod_completo) "+
            "inner join venda v on (v.cod_venda = vg.cod_venda) where vg.cod_venda = "+cod_venda+" ) order by g.cod_garcon";

            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(garcon, Conectar());
            sql.Fill(dttGarcon);
            return dttGarcon;
        }
        public int codGarconByNome(string nome)
        {

            DataTable dttGarcon = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter("select cod_garcon from garcon where nome = '" + nome + "'", Conectar());
            sql.Fill(dttGarcon);
            return Convert.ToInt16(dttGarcon.Rows[0].ItemArray.GetValue(0));
        }
        public string preencherNomeProduct(int cod_produto)
        {
            try
            {
                DataTable dttGarcon = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter("select descricao from produto where ativo = true and cod_produto = '" + cod_produto + "'", Conectar());
                sql.Fill(dttGarcon);
                return dttGarcon.Rows[0].ItemArray.GetValue(0).ToString();
            }
            catch { return "Não Existe"; }
        }
        public string preencherNomeProdctAll(int cod_produto)
        {
            DataTable dttGarcon = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter("select descricao from produto where cod_produto = '" + cod_produto + "'", Conectar());
            sql.Fill(dttGarcon);
            return dttGarcon.Rows[0].ItemArray.GetValue(0).ToString();

        }
        public string preencherNomeProdutoAlt(int cod_produto)
        {
            DataTable dttGarcon = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter("select descricao from produto where  cod_produto = '" + cod_produto + "'", Conectar());
            sql.Fill(dttGarcon);
            return dttGarcon.Rows[0].ItemArray.GetValue(0).ToString();

        }
        public string categoriaProduto(int cod_produto)
        {
            DataTable dttGarcon = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter
                ("select t.nome from tipo t inner join produto p on (t.cod_tipo = p.cod_tipo ) where t.ativo = true and p.ativo = true and p.cod_produto = '"
                + cod_produto + "'", Conectar());
            sql.Fill(dttGarcon);
            return dttGarcon.Rows[0].ItemArray.GetValue(0).ToString();
        }
        public string categoriaProdutoAll(int cod_produto)
        {
            DataTable dttGarcon = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter
                ("select t.nome from tipo t inner join produto p on (t.cod_tipo = p.cod_tipo ) where  p.cod_produto = '"
                + cod_produto + "'", Conectar());
            sql.Fill(dttGarcon);
            return dttGarcon.Rows[0].ItemArray.GetValue(0).ToString();
        }
        public void makeGarconVenda(int cod_venda, int cod_garcon)
        {
            try
            {
                new NpgsqlDataAdapter("INSERT INTO vendaGarcon(cod_venda, cod_garcon, quantidade)  VALUES('" + cod_venda + "' , '" + cod_garcon + "', 1)", Conectar()).Fill(new DataTable());
            }
            catch
            {
                DataTable dttTamanho = new DataTable();

                string query = "UPDATE vendaGarcon set   quantidade=(quantidade+1) WHERE cod_venda = '" + cod_venda + "' and cod_garcon = '" + cod_garcon + "'";
                new NpgsqlDataAdapter(query, Conectar()).Fill(new DataTable());
            }
        }
        //-------------------------------------
        public int novoCompleto(Produto[] itens, double valor, int quantidade)
        {
            makeCompleto(valor, quantidade);

            int cod_completo = resgatarUltimaCompleto();//codigo do produto atual
            for (int i = 0; i < itens.Length; i++)
                makeCompletoProduto(cod_completo, itens[i].cod_produto, Convert.ToInt16(itens[i].porcentagem), itens[i].cod_tamanho);


            return cod_completo;
        }
        public void makeCompleto(double valor, int quantidade)
        {
            NpgsqlConnection conn = new NpgsqlConnection(conexao);
            NpgsqlCommand cmd = new NpgsqlCommand
                ("insert into Completo (valorUnitarioCompleto,quantidade) values (@valorUnitario,@quantidade)", conn);
            cmd.Parameters.Add("@valorUnitario", valor);
            cmd.Parameters.Add("@quantidade", quantidade);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void makeCompletoProduto(int cod_completo, int cod_produto, int porcentagem, int cod_tamanho)
        {
            try
            {
                string query = "INSERT INTO completoProduto(cod_completo, cod_produto, porcentagem, cod_tamanho)" +
                    " VALUES ('" + cod_completo + "', '" + cod_produto + "' ," + porcentagem + "," + cod_tamanho + " )";
                new NpgsqlDataAdapter(query,
                    Conectar()).Fill(new DataTable());
            }
            catch { }
        }
        public void makeVendaCompleto(int cod_venda, int cod_completo)
        {
            try
            {

                new NpgsqlDataAdapter("INSERT INTO vendacompleta(cod_venda, cod_completo) VALUES ('" + cod_venda + "', '" + cod_completo + "')", Conectar()).Fill(new DataTable());
            }
            catch { }
        }
        public int resgatarUltimaCompleto()
        {
            try
            {
                DataTable dttTamanho = new DataTable();
                new NpgsqlDataAdapter("select cod_completo from Completo order by cod_completo desc limit 1", Conectar()).Fill(dttTamanho);
                return Convert.ToInt16(dttTamanho.Rows[0].ItemArray.GetValue(0));
            }
            catch
            {
                return 0;
            }
        }
        //---------------------------------------------
        public DataTable informacoes(string mesa)
        {
            DataTable dttValor = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(
                "select  (c.cod_completo), tt.descricao,sum ((c.valorunitarioCompleto )* ((cast (cp.porcentagem as double precision))/100)),c.quantidade " +
                "from  venda v inner join vendaCompleta vc          on (vc.cod_venda    = v.cod_venda)       inner join completo c                on (vc.cod_completo = c.cod_completo)" +
                "inner join completoProduto cp        on (cp.cod_completo = c.cod_completo)" +
                "inner join produto p   on (p.cod_produto   = cp.cod_produto )" +
                "inner join vendaMesa vm  on (vm.cod_venda    = v.cod_venda)" +
                "inner join mesa m                    on (m.cod_mesa      = vm.cod_mesa)" +
                "inner join produtoTamanho pt         on (pt.cod_produto  = p.cod_produto)" +
                "inner join tamanho tt    on (tt.cod_tamanho  = pt.cod_tamanho)" +
                " where m.status = false and v.aberta = true    and cp.cod_tamanho = tt.cod_tamanho and m.descricao = '" + mesa + "'" +
                " and p.ativo = true and tt.ativo = true " +
                "group by c.cod_completo,tt.descricao,c.quantidade  order by c.cod_completo", Conectar());
            sql.Fill(dttValor);

            return dttValor;
        }
        //da o codigo de uma venda e retorna o nome do produto interno.
        public string informacoes2(int cod_completo)
        {
            DataTable dttValor2 = new DataTable();
            NpgsqlDataAdapter sql2 = new NpgsqlDataAdapter(
                "select p.descricao, cp.porcentagem " +
            "from completo c inner join completoProduto cp        on (cp.cod_completo = c.cod_completo) " +
            "inner join produto p        on (p.cod_produto   = cp.cod_produto ) " +
            "where p.ativo = true and c.cod_completo = '" + cod_completo + "'order by c.cod_completo desc limit 1", Conectar());
            sql2.Fill(dttValor2);

            string nome = dttValor2.Rows[0].ItemArray.GetValue(0).ToString();
            int pct = (Convert.ToInt16(dttValor2.Rows[0].ItemArray.GetValue(1)));
            if (pct != 100) return "Mista : " + nome;
            return nome;
        }
        // esse metodo retorna os tamanhos.
        public DataTable tamanhoProduto(int cod_produto)
        {
            DataTable dttTamanho = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter
                (" select t.descricao, pt.valorproduto from Produtotamanho pt inner join tamanho t on( t.cod_tamanho = pt.cod_tamanho)" +
                " inner join produto p on (p.cod_produto = pt.cod_produto) where t.ativo = true and p.ativo = true and p.cod_produto = '" + cod_produto + "' order by t.cod_tamanho", Conectar());
            sql.Fill(dttTamanho);
            return dttTamanho;

        }
        public double valorProduto(int cod_produto, string Tamanho)
        {

            try
            {
                DataTable dttTamanho = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter
                    ("select tp.valorproduto from produto p inner join produtotamanho tp on (p.cod_produto = tp.cod_produto)" +
                    " inner join tamanho t on( t.cod_tamanho = tp.cod_tamanho ) where p.ativo = true and t.ativo and p.cod_produto = '"
                    + cod_produto + "' and t.descricao = '" + Tamanho + "'", Conectar());
                sql.Fill(dttTamanho);
                double cod_tamanho = Convert.ToDouble(dttTamanho.Rows[0].ItemArray.GetValue(0));
                return cod_tamanho;
            }
            catch
            {
                return 0;
            }


        }
        public void alterarValor(int cod_produto, int cod_tamanho, double valor)
        {
            string query = "UPDATE produtotamanho set valorproduto= " + new Tratamento().retornaValorEscrito(valor).Replace(',', '.') + " WHERE cod_produto = " + cod_produto + " and cod_tamanho = " + cod_tamanho;
            DataTable t = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(t);

        }
        public int codTamanho(string nomeTamanho)
        {
            try
            {
                DataTable dttTamanho = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(" select cod_tamanho  from Tamanho where ativo = true and descricao = '"
                    + nomeTamanho + "'", Conectar());
                sql.Fill(dttTamanho);
                int cod_tamanho = Convert.ToInt16(dttTamanho.Rows[0].ItemArray.GetValue(0));
                return cod_tamanho;
            }
            catch
            {
                return 1;
            }

        }
        public string[] exibirTamanhos(int codProduto, int cod_tamanho)
        {
            if (isPizza(codProduto))
                if (cod_tamanho == 1) return new string[] { "INTEIRA", "50% | 50%", "50% | 2 x 25%", "4 x 25%" };
                else return new string[] { "INTEIRA", "50% | 50%" };
            return null;
        }
        //esse metodo informa se eh ou nao uma pizza
        public bool isPizza(int cod_produto)
        {

            DataTable dttTamanho = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter("select isPizza from produto where ativo = true and cod_produto =  '" + cod_produto + "'", Conectar());
            sql.Fill(dttTamanho);
            if (Convert.ToBoolean(dttTamanho.Rows[0].ItemArray.GetValue(0))) return true;
            return false;

        }
        // esse metodo pressupoe, q eu sei o tamanho.
        //1 para INVISIVEL
        //2 para 50% 50%
        //3 para todas opcoes (caso da pizza grande)
        public int porcetagemPizza(int cod_Produto, int cod_tamanho)
        {

            if (isPizza(cod_Produto))
            {
                if (cod_tamanho == 1) return 3;
                return 2;
            }
            return 1;

        }
        // se é uma pizza, entao esse metodo limita a 2 tamanhos possiveis.

        public int codigoDaVendaPelaMesa(string mesa)
        {
            // 
            DataTable dttTamanho = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter
                ("select v.cod_venda from mesa m inner join vendaMesa vm on(m.cod_mesa = vm.cod_mesa) "
                + " inner join venda v on(vm.cod_venda = v.cod_venda) "
                + " where m.status = false and v.aberta = true and m.descricao = '" + mesa + "' order by v.cod_venda desc limit 1", Conectar());
            sql.Fill(dttTamanho);
            return Convert.ToInt16(dttTamanho.Rows[0].ItemArray.GetValue(0)); ;
        }
        // todas as mesas disponiveis.
        public string[] mesasDisponiveis()// mesas ativas , ammbiente ativo, mesas disponiveis
        {
            DataTable dttTamanho = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter("select m.descricao from mesa m inner join ambiente a on (a.cod_ambiente = m.cod_ambiente) where a.ativo = true and m.ativo = true and m.status = true order by m.cod_mesa", Conectar());
            sql.Fill(dttTamanho);
            string[] resposta = new string[dttTamanho.Rows.Count];
            for (int i = 0; i < dttTamanho.Rows.Count; i++)
                resposta[i] = Convert.ToString(dttTamanho.Rows[i].ItemArray.GetValue(0));

            return resposta;

        }
        public string[] mesasIndisponiveis()
        {
            DataTable dtt = new DataTable();
            string query1 = "select v.cod_venda from venda v inner join vendaMesa vm on(vm.cod_venda = v.cod_venda)" +
"inner join mesa m on (m.cod_mesa = vm.cod_mesa) where v.aberta = true group by v.cod_venda";
            new NpgsqlDataAdapter(query1, Conectar()).Fill(dtt);
            string[] conj = new string[dtt.Rows.Count];
            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                DataTable dtt2 = new DataTable();
                int cod = Convert.ToInt16(dtt.Rows[i].ItemArray.GetValue(0));
                string query2 = "select m.descricao from venda v inner join vendaMesa vm on(vm.cod_venda = v.cod_venda)" +
   "inner join mesa m on (m.cod_mesa = vm.cod_mesa) where v.cod_venda = " + cod + " group by m.descricao order by m.descricao  desc limit 1";
                new NpgsqlDataAdapter(query2, Conectar()).Fill(dtt2);
                conj[i] = dtt2.Rows[0].ItemArray.GetValue(0).ToString();
            }

            return new Tratamento().ordenaBolha(conj);

        }
        public string mesaNomeByCodigo(int cod_mesa)
        {
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter("select descricao from mesa where cod_mesa = " + cod_mesa, Conectar()).Fill(dtt);
            return dtt.Rows[0].ItemArray.GetValue(0).ToString();

        }
        public void indisponibilizarMesa(int cod_mesa)
        {

            new NpgsqlDataAdapter("UPDATE mesa   SET status= false WHERE cod_mesa = " + cod_mesa, Conectar()).Fill(new DataTable());
        }
        public void disponibilizarMesa(int cod_mesa)
        {

            new NpgsqlDataAdapter("UPDATE mesa   SET status= true WHERE cod_mesa = " + cod_mesa, Conectar()).Fill(new DataTable());
        }
        public int codVendaSelecionada(string mesa)
        {
            //
            DataTable dttTamanho = new DataTable();
            new NpgsqlDataAdapter
                ("select v.cod_venda from mesa m inner join vendaMesa vm on (m.cod_mesa = vm.cod_mesa)"
                + " inner join venda v on (v.cod_venda = vm.cod_venda) where aberta = true and m.cod_mesa =  '" + mesa + "'", Conectar()).
                Fill(dttTamanho);
            return Convert.ToInt16(dttTamanho.Rows[0].ItemArray.GetValue(0));
        }
        public int codVendaSelecionada2(string mesa)
        {
            //
            DataTable dttTamanho = new DataTable();
            new NpgsqlDataAdapter
                ("select v.cod_venda from mesa m inner join vendaMesa vm on (m.cod_mesa = vm.cod_mesa)"
                + " inner join venda v on (v.cod_venda = vm.cod_venda) where aberta = true and m.descricao =  '" + mesa + "'", Conectar()).
                Fill(dttTamanho);
            return Convert.ToInt16(dttTamanho.Rows[0].ItemArray.GetValue(0));
        }
        // esse metodo preenche o produto final e retorna o produtoCOMPLETO que sera inserido na venda    
        public int cod_tamanhoDoEscolhido(int cod_produto, string descricaoTamanho)
        {
            try
            {
                DataTable dttTamanho = new DataTable();
                new NpgsqlDataAdapter("select t.cod_tamanho from produto p inner join produtotamanho pt on(p.cod_produto = pt.cod_produto ) "
                    + "inner join tamanho t on(t.cod_tamanho = pt.cod_tamanho) where t.descricao = '" + descricaoTamanho
                    + "' and p.cod_produto = " + cod_produto, Conectar()).
                Fill(dttTamanho);
                return Convert.ToInt16(dttTamanho.Rows[0].ItemArray.GetValue(0));
            }
            catch { return 0; }
        }
        public DataTable carregarCodigo()
        {
            DataTable dttTamanho = new DataTable();
            new NpgsqlDataAdapter("select nome from tipo where ativo = true order by cod_tipo", Conectar()).
            Fill(dttTamanho);
            return dttTamanho;

        }
        public DataTable carregarNomeProdutoPeloTipo(string nomeTipo)
        {
            string query = "select p.cod_produto, p.descricao from produto p inner join tipo t on (t.cod_tipo = p.Cod_tipo )"
                + "where t.ativo = true and p.ativo = true and t.nome = '" + nomeTipo + "' order by p.cod_produto";
            DataTable dttTamanho = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).
            Fill(dttTamanho);
            return dttTamanho;
        }
        public int novaVenda(int cod_caixa, int[] codMesa)
        {
            DataTable dttTamanho = new DataTable();

            new NpgsqlDataAdapter
                ("INSERT INTO venda(valortotal, datavenda, horario, cod_caixa, aberta, impressao) VALUES ( 0, current_date,current_time, '" +
                cod_caixa + "', true, false)", Conectar())
                .Fill(new DataTable());

            new NpgsqlDataAdapter("select cod_venda from venda order by cod_venda desc limit 1", Conectar()).Fill(dttTamanho);
            int cod_venda = Convert.ToInt16(dttTamanho.Rows[0].ItemArray.GetValue(0));
            for (int i = 0; i < codMesa.Length; i++)
            {
                new NpgsqlDataAdapter("INSERT INTO vendaMesa(cod_venda, cod_mesa)  VALUES ('" + cod_venda + "' , '" + codMesa[i] + "')", Conectar()).Fill(new DataTable());

                indisponibilizarMesa(codMesa[i]);
            }
            return cod_venda;
        }
        //se informar qual a mesa ela retorna todos os codigos referentes
        public int[] cod_mesa(string[] mesa)
        {
            int[] x = new int[mesa.Length];
            for (int i = 0; i < x.Length; i++)
            {
                DataTable dttTamanho = new DataTable();
                new NpgsqlDataAdapter("select cod_mesa from mesa where descricao = '" + mesa[i] + "'", Conectar()).
                    Fill(dttTamanho);
                x[i] = Convert.ToInt16(dttTamanho.Rows[0].ItemArray.GetValue(0));
            }
            return x;
        }

        public void GarconCompleto(int cod_garcon, int cod_completo, int quantidade)
        {
            DataTable dtt = new DataTable();
            string query = "INSERT INTO garconcompleto( cod_garcon, cod_completo, quantidade)    VALUES ("+cod_garcon+","+cod_completo+ "," +quantidade+")";
            new NpgsqlDataAdapter(query, Conectar()).
              Fill(dtt);
        }
        
        public void scriptLimpezaBanco()
        {
            DataTable t = new DataTable();
            string query1 = "delete from supervenda";
            new NpgsqlDataAdapter(query1, Conectar()).Fill(t);
            t = new DataTable();
            string query2 = "delete from completoProduto";
            new NpgsqlDataAdapter(query2, Conectar()).Fill(t);
            t = new DataTable();
            string query3 = "delete from vendaGarcon";
            new NpgsqlDataAdapter(query3, Conectar()).Fill(t);
            t = new DataTable();
            string query4 = "delete from vendaCompleta";
            new NpgsqlDataAdapter(query4, Conectar()).Fill(t);
            t = new DataTable();
            string query10 = "delete from completo";
            new NpgsqlDataAdapter(query10, Conectar()).Fill(t);
            t = new DataTable();
            string query5 = "delete from vendaMesa";
            new NpgsqlDataAdapter(query5, Conectar()).Fill(t);
            t = new DataTable();
            string query6 = "delete from venda";
            new NpgsqlDataAdapter(query6, Conectar()).Fill(t);
            t = new DataTable();
            string query7 = "delete from super";
            new NpgsqlDataAdapter(query7, Conectar()).Fill(t);
            t = new DataTable();
            string query8 = "UPDATE mesA set status =true";
            new NpgsqlDataAdapter(query8, Conectar()).Fill(t);
            t = new DataTable();
            string query9 = "SELECT setval('public.super_cod_super_seq', 1, true);"
                + "SELECT setval('public.completo_cod_completo_seq', 1, true);SELECT setval('public.venda_cod_venda_seq', 1, true);";
            new NpgsqlDataAdapter(query9, Conectar()).Fill(t);
            t = new DataTable();
        }

        public DataTable carregaComanda()
        {
            DataTable dtt = new DataTable();
            string query = "select empresa, rua, telefone, titulo, mensagem, cidade, prognome, progtelefone, cod_comanda from comanda where cod_comanda = 1";
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            return dtt;
        }
        public string getHorarioVenda(int cod_venda)
        {
            DataTable dtt = new DataTable();
            string query = "select horario from venda where cod_venda = "+cod_venda;
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            return dtt.Rows[0].ItemArray.GetValue(0).ToString().Substring(10);
        }
    }
}
