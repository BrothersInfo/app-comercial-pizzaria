using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;
using System.Collections;

namespace Pizzaria.Banco
{
    public class BancoRelatorio
    {

        string conexao = "server=Localhost; Port=5432;User =postgres;Password=fof0130407*;Database=Delirius";
        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(conexao);
        
        }
        public DataTable quadroGarconTodos()
        {

            string query = "select cod_garcon as \"Codigo\",nome as \"Nome do Garcon\", CASE ativo WHEN true THEN 'Ativo' ELSE 'Inativo'  end , entrada from garcon order by ativo=false, cod_garcon";
            DataTable dtt = new DataTable();

            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
           
        }
        public DataTable quadroGarconAtivo(bool ativo)
        {

            string query = "select cod_garcon as \"Codigo\",nome as \"Nome do Garcon\", CASE ativo WHEN true THEN 'Ativo' ELSE 'Inativo'  end , entrada from garcon where ativo = "+ativo+" order by  cod_garcon";
            DataTable dtt = new DataTable();

            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;

        }
        public DataTable trabalhadoGarconPeriodo(string query2)
        {
            string query =
            "select g.nome,CASE g.ativo WHEN true THEN 'Ativo' ELSE 'Inativo'  end, v.dataVenda from garcon g " +
            "inner join vendagarcon vg on (g.cod_garcon = vg.cod_garcon) "+
            "inner join venda v on(v.cod_venda = vg.cod_venda) "+query2+
            //"where v.datavenda"+ 
            //"between '01-06-2012' and ((date '01-06-2012'+interval '1 month') - interval '1 day') "+
            //"and g.ativo = true "+
            //"and g.cod_garcon = 1 "+
            " group by g.nome, v.datavenda, g.ativo "+
            "order by v.datavenda";	



                DataTable dtt = new DataTable();

            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;

        }
        public DataTable trabalhadoGarconPeriodoSemAtivo(string query2)
        {
            string query =
            "select g.nome, v.dataVenda from garcon g " +
            "inner join vendagarcon vg on (g.cod_garcon = vg.cod_garcon) " +
            "inner join venda v on(v.cod_venda = vg.cod_venda) " + query2 +
                //"where v.datavenda"+ 
                //"between '01-06-2012' and ((date '01-06-2012'+interval '1 month') - interval '1 day') "+
                //"and g.ativo = true "+
                //"and g.cod_garcon = 1 "+
            "group by g.nome, v.datavenda " +
            "order by v.datavenda";



            DataTable dtt = new DataTable();

            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;

        }
    //-------------------------------------VENDAS VALORES BASEADOS EM GARCON--------------

        public DataTable valoresGarconNaVenda(string where)
        {

        string query = "select "+
        "g.nome as \"Garcon\", "+
        "v.datavenda as \"Data da Venda\", "+
        "(select m.descricao  from mesa m inner join vendaMesa vm on(m.cod_mesa  = vm.cod_mesa) inner join venda vv on (vv.cod_venda = vm.cod_venda) "+
        "where vv.cod_venda = v.cod_venda order by vv.cod_venda desc limit 1)as \"Mesa da Venda\", "+
        "sum (c.valorUnitarioCompleto*gc.quantidade) as \"Sub-Total\" "+
        "from garcon g "+
        "inner join GarconCompleto gc on (g .cod_garcon   = gc.cod_garcon) "+
        "inner join completo       c  on (c .cod_completo = gc.cod_completo) "+
        "inner join vendaCompleta  vc on (vc.cod_completo = c .cod_completo) "+
        "inner join venda          v  on (v .cod_venda    = vc.cod_venda) "+
        "inner join supervenda     sv on (sv.cod_venda    = v .cod_venda) "+
        "inner join super          s  on (s .cod_super    = sv.cod_super) "+
        "inner join vendamesa      vm on (v .cod_venda    = vm.cod_venda) "+
        where+
        "group by g.nome,v.cod_venda, v.datavenda "+
        "order by v.cod_venda ";


        DataTable dtt = new DataTable();

        NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
        sql.Fill(dtt);
        return dtt;


        }


        public string[] caixas()
        {
            DataTable tabela = new DataTable();
            string query = "select nomeCaixa as \"Caixa\" from caixa ";
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            string[] retorno = new string[tabela.Rows.Count];

            for (int i = 0; i < retorno.Length; i++)
                retorno[i] = tabela.Rows[i].ItemArray.GetValue(0).ToString();

            return retorno;
        }
        public string[] formasPagamento()
        {
            DataTable tabela = new DataTable();
            string query = "select descricao as \"Pagamento\" from pagamento ";
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            string[] retorno = new string[tabela.Rows.Count];

            for (int i = 0; i < retorno.Length; i++)
                retorno[i] = tabela.Rows[i].ItemArray.GetValue(0).ToString();

                return retorno;

        }
        public string[] ambientes()
        {
            DataTable tabela = new DataTable();
            string query = "select descricao as \"Ambiente\" from Ambiente ";
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            string[] retorno = new string[tabela.Rows.Count];

            for (int i = 0; i < retorno.Length; i++)
                retorno[i] = tabela.Rows[i].ItemArray.GetValue(0).ToString();

            return retorno;

        }
        public string[] itemDoFiltroVenda(int numero)
        {

            switch (numero)
            {
                case 0:  return new string [0];
                case 1:  return caixas();
                case 2:  return formasPagamento();
                case 3:  return ambientes();
                default: return new string[0];


            }
        }
        public string[] orderByDaVenda()
        {
            return new string[] { "Data", "Valor", "Ambiente", "Caixa", "Forma Pag"  };
         
        }
        private string orderQuery(int numero){
        switch(numero){
            case 0 : return " v.datavenda";
            case 1 : return " v.valorTotal";
            case 2 : return " a.cod_ambiente";
            case 3 :return " x.cod_caixa";
            case 4 :return " p.cod_pagamento";
            default : return " v.datavenda";
        }

        }
        private string filtroQuery(int numero)
        {
            switch (numero)
            {
                case 1: return " x.cod_caixa";
                case 2: return " p.cod_pagamento";
                case 3: return " a.cod_ambiente";
                
                default: goto case 1;
            }

        }
        public DataTable consultaVendaGeral(string []data, int order, bool hasFiltro, int filtro, int valorFiltro, bool ascen)
        {

            string query = "select "+ "(select mm.descricao from mesa mm inner join vendaMesa vmm on(vmm.cod_mesa = mm.cod_mesa) inner join venda vv on (vv.cod_venda = vmm.cod_venda) where v.cod_venda = vv.cod_venda order by vv.cod_venda desc limit 1) as \"Venda\"," 
                +" to_char(v.dataVenda, 'DD MM YYYY') as \"Data\", to_char(v.horario, 'HH24:MI:SS') as \"Horario\", x.nomeCaixa as \"Caixa\" ,"
                
                + "(select gg.nome from garcon gg inner join GarconCompleto ccg on (ccg.cod_garcon = gg.cod_garcon) "
                +" inner join completo cc on (cc.cod_completo = ccg.cod_completo) inner join vendaCompleta vvg on (vvg.cod_completo = cc.cod_completo) "
                +" inner join venda vv on (vv.cod_venda = vvg.cod_venda) where vvg.cod_venda =  v.cod_venda order by vv.cod_venda desc limit 1) as \"Garcon\","
                
                + " p.descricao as \"Pagamento\",(CASE v.valortotal >0  WHEN true THEN (trim(to_char( v.valorTotal,'9999.99'))) ELSE '0.00'  end ) as \"Valor\",    a.descricao as \"Ambiente\""
                +" from  venda v " 
                +" inner join vendaMesa vm              on (vm.cod_venda    = v.cod_venda) "    
                +" inner join mesa m                    on (m.cod_mesa      = vm.cod_mesa) "
                +" inner join caixa x                   on (x.cod_caixa     = v.cod_caixa) "
                +" inner join pagamento p               on (p.cod_pagamento = v.cod_pagamento) "
                +" inner join ambiente a                on (a.cod_ambiente  = m.cod_ambiente) "
                +" where v.aberta = false ";
            if (hasFiltro)
                query += " and "+ filtroQuery(  filtro) +" = "+ (1+valorFiltro);
            if (data.Length == 1)
                query += " and v.dataVenda = '"+data[0]+"' ";
            else
                query += " and v.dataVenda between '" + data[0] + "' and '" + data[1] + "' ";
                    //--filtros
            query +=
             " order by " + orderQuery(  order);
            if (ascen) query += " asc";
            else query += " desc";
            DataTable tabela = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            return tabela;
        }
        //--------------------------ok GARCON
        public string[] garcons()
        {
            DataTable tabela = new DataTable();
            string query = "select nome as \"Garcon\" from garcon";
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            string[] retorno = new string[tabela.Rows.Count+1];
            retorno[0] = "Todos";
            for (int i = 1; i < retorno.Length; i++)
                retorno[i] = tabela.Rows[i-1].ItemArray.GetValue(0).ToString();

            return retorno;
        }
        public string[] categorias()
        {
            DataTable tabela = new DataTable();
            string query = "select nome as \"Categoria\" from tipo  ";
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            string[] retorno = new string[tabela.Rows.Count + 1];
            retorno[0] = "Todos";
            for (int i = 1; i < retorno.Length; i++)
                retorno[i] = tabela.Rows[i-1].ItemArray.GetValue(0).ToString();

            return retorno;
        }
        public DataTable consultaGarconGeral(bool aberta, string[] data,bool hasGarcon, string garcon
        ,bool hasAmbiente, string ambiente, bool hasTipo, string tipo, int order , bool ascen)
        {
            string query =
                "select to_char(v.dataVenda, 'DD MM YYYY') as \"Data da Venda\"" +
                ", g.nome as \"Garcon\"" +
                ",(select mm.descricao from mesa mm inner join vendaMesa vmm on(vmm.cod_mesa = mm.cod_mesa) " +
                " inner join venda vv on (vv.cod_venda = vmm.cod_venda) " +
                " where v.cod_venda = vv.cod_venda order by vv.cod_venda desc limit 1) as \"Mesa\" ," +

                " (select aa.descricao from ambiente aa inner join  mesa mm on (mm.cod_ambiente = aa.cod_ambiente) " +
                " inner join vendaMesa vmm on(vmm.cod_mesa = mm.cod_mesa) " +
                " inner join venda vv on (vv.cod_venda = vmm.cod_venda) ";
            if (hasAmbiente)
                query += " where v.cod_venda = vv.cod_venda and aa.cod_ambiente = " + new BancoConsulta().codAmbientePelaDescricao(ambiente) + " order by vv.cod_venda desc limit 1) as \"AMBIENTE\",";

            else
                query += " where v.cod_venda = vv.cod_venda  order by vv.cod_venda desc limit 1) as \"Ambiente\",";
            query +=
               
                " t.nome as \"Categoria\" " +
                ",p.descricao as \"Produto\" " +
                ",tt.descricao as \"Tamanho\" " +
                ",(CASE cp.porcentagem = 100 when true then	(CASE (t.cod_tipo = 1)when true then 'Inteiro' ELSE 'Unico' end ) else " +
                "    (CASE (cp.porcentagem = 50 )when true then 'Metade' ELSE " +
                "        (CASE (cp.porcentagem = 25 )when true then '1/4' " +
                "            ELSE ('Desconhecido') end ) end )  end)as \"Divisao\", " +

                "(CASE (c.valorUnitarioCompleto*(cast(cp.porcentagem as double precision) /100)) >0  WHEN true THEN (trim(to_char( (c.valorUnitarioCompleto*(cast(cp.porcentagem as double precision) /100)),'9999.99'))) ELSE '0.00'  end ) as \"Valor Unitario\"," +
                " gc.quantidade as \"Quantidade\" " +
                ", to_char(gc.horario, 'HH24:MI:SS') as \"Hora Entrega\" " +
                "from garcon g " +
                " inner join garconCompleto gc on (gc.cod_garcon = g.cod_garcon) " +
                " inner join completo c on (c.cod_completo = gc.cod_completo) " +
                " inner join vendaCompleta vc on (vc.cod_completo = c.cod_completo) " +
                " inner join venda v on (v.cod_venda = vc.cod_venda) " +
                " inner join completoProduto cp on (cp.cod_completo = c.cod_completo) " +
                " inner join produto p on (p.cod_produto = cp.cod_produto) " +
                " inner join tipo t on (p.cod_tipo = t.cod_tipo) " +
                " inner join produtoTamanho pt on (pt.cod_produto = p.cod_produto) " +
                " inner join tamanho tt on (tt.cod_tamanho = pt.cod_tamanho) and  (tt.cod_tamanho =  cp.cod_tamanho) " +
                " where " +
                "v.aberta = " + aberta;
                
                if (!aberta){
                    if (data.Length == 1)
                        query += " and v.dataVenda = '" + data[0] + "' ";
                    else
                        query += " and v.dataVenda between '" + data[0] + "' and '" + data[1] + "' ";
                }
                if (hasGarcon)
                    query += " and g.cod_garcon = " + new Banco().codGarconByNome(garcon);
                if (hasTipo)
                    query += " and t.cod_tipo = " + new BancoConsulta().cod_tipoPeloNome(tipo);
            query +=
             " order by " + orderGarcon(order);
            if (ascen) query += " asc";
            else query += " desc";
            DataTable tabela = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            return tabela;

        }
        public string orderGarcon(int numero)
        {
            switch (numero)
            {
                case 0: return " v.datavenda";
                case 1: return " g.cod_garcon";

                case 2: return " t.cod_tipo";
                case 3: return " c.valorUnitarioCompleto";
                default: return " v.dataVenda";
            }

        }
        public DataTable consultaProdutoGeral(string[] data, bool hasValor, bool hasTipo, int cod_tipo, bool hasTamanho, int cod_tamanho, 
            bool hasProduto, int cod_produto)
        {
            string query =
                " select " +
                " (select pp.descricao from produto pp where pp.cod_produto = p.cod_produto) as \"Produto\" " +
                " , (select pp.nome from tipo pp where pp.cod_tipo = t.cod_tipo) as \"Categoria\" " +
                " , (select pp.descricao from tamanho pp where pp.cod_tamanho = tt.cod_tamanho) as \"Sub Categoria\" ";
            if (hasValor)
                query +=
            " , (CASE (c.valorUnitarioCompleto*(cast(cp.porcentagem as double precision) /100)) >0 "
            + " WHEN true THEN (trim(to_char( (c.valorUnitarioCompleto*(cast(cp.porcentagem as double precision) /100)),'9999.99'))) ELSE '0.00'  end ) as \"Valor Unitario\" " +
            " , (CASE ((c.valorUnitarioCompleto*(cast(cp.porcentagem as double precision) /100))* sum(c.quantidade)) >0  WHEN true "+
	            " THEN (trim(to_char( ((c.valorUnitarioCompleto*(cast(cp.porcentagem as double precision) /100))* sum(c.quantidade)),'9999.99'))) ELSE '0.00'  end ) as \"Sub Total\" ";
            query +=
                " ,(CASE cp.porcentagem = 100 when true then	(CASE (t.cod_tipo = 1)when true then 'Inteiro' ELSE 'Unico' end ) else  " +
                "                    (CASE (cp.porcentagem = 50 )when true then 'Metade' ELSE " +
                "                        (CASE (cp.porcentagem = 25 )when true then '1/4'  " +
                "                            ELSE ('Desconhecido') end ) end )  end)as \"Divisao\" " +
                " , sum(c.quantidade) as \"Quantidade\" " +
                " from 		completo c              " +
                " inner join 	completoProduto cp        on (cp.cod_completo = c.cod_completo)     " +
                " inner join 	produto p      	     	  on (p.cod_produto   = cp.cod_produto ) " +
                " inner join 	produtoTamanho pt         on (pt.cod_produto  = p.cod_produto)   " +
                " inner join 	tamanho tt    	     	  on (tt.cod_tamanho  = pt.cod_tamanho and tt.cod_tamanho =  cp.cod_tamanho) " +
                " inner join	tipo t			          on (t.cod_tipo      = p.cod_tipo) " +
                " inner join	vendaCompleta vc	      on (vc.cod_completo = c.cod_completo)   " +
                " inner join 	venda v			          on (v.cod_venda = vc.cod_venda)" +
                " where ";
            if (data.Length == 1)
                query += " v.dataVenda = '" + data[0] + "' ";
            else
                query += " v.dataVenda between '" + data[0] + "' and '" + data[1] + "' ";
            if (hasTipo)
            {
                query += " and t.cod_tipo = " + cod_tipo;
                if (hasTamanho)
                    query += " and tt.cod_tamanho = " + cod_tamanho;
                if (hasProduto)
                    query += " and p.cod_produto = " + cod_produto;
            }
            query += " group by t.cod_tipo,p.cod_produto, tt.cod_tamanho,cp.porcentagem ";
            if(hasValor)
                query+=
                " , c.valorUnitarioCompleto  ";
            query+=
                " order by t.cod_tipo,p.cod_produto, tt.cod_tamanho,  cp.porcentagem ";

            DataTable tabela = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            return tabela;
        }
        public string[] tamanhosDoTipo(int cod_tipo)
        {
            string query = 
            " select tt.cod_tamanho, tt.descricao " +
            " from 	produto p      	  "+
            " inner join 	produtoTamanho pt         on (pt.cod_produto  = p.cod_produto)"+  
            " inner join 	tamanho tt    	     	  on (tt.cod_tamanho  = pt.cod_tamanho )"+
            " inner join	tipo t			  on (t.cod_tipo      = p.cod_tipo)"+
            " where t.cod_tipo = "+cod_tipo +
            " group by tt.cod_tamanho, tt.descricao order by tt.cod_tamanho ";
            DataTable tabela = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);

            string[] retorno = new string[tabela.Rows.Count + 1];
            retorno[0] = "Todos";
            for (int i = 1; i < retorno.Length; i++)
                retorno[i] = tabela.Rows[i - 1].ItemArray.GetValue(1).ToString();

            return retorno;
        
        }
        public string[] produtosDoTipo(int cod_tipo)
        {
            string query =
            " select p.cod_produto, p.descricao " +
            " from 	produto p      	  " +
            " inner join 	produtoTamanho pt         on (pt.cod_produto  = p.cod_produto)" +
            " inner join 	tamanho tt    	     	  on (tt.cod_tamanho  = pt.cod_tamanho )" +
            " inner join	tipo t			  on (t.cod_tipo      = p.cod_tipo)" +
            " where t.cod_tipo = " + cod_tipo +
            " group by p.cod_produto, p.descricao order by p.cod_produto ";
            DataTable tabela = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);

            string[] retorno = new string[tabela.Rows.Count + 1];
            retorno[0] = "Todos";
            for (int i = 1; i < retorno.Length; i++)
                retorno[i] = tabela.Rows[i - 1].ItemArray.GetValue(1).ToString();

            return retorno;

        }
        
    }
}
