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

       
         string conexao;
        //-------------------------------------
        //novos metodos
        //-------------------------------------
        
        public BancoRelatorio()
        {
            conexao = ClasseDLL.Variaveis.conexao;// new BancoSenha().conexao;
        }
        
        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(conexao);
        
        }
     
        //-------------------------------------VENDAS VALORES BASEADOS EM GARCON--------------

     
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
            case 1 : return " v.valorReal";
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
        public string[] garcons()
        {
            DataTable tabela = new DataTable();
            string query = "select nome as \"Garcon\" from garcon";
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            string[] retorno = new string[tabela.Rows.Count + 1];
            retorno[0] = "Todos";
            for (int i = 1; i < retorno.Length; i++)
                retorno[i] = tabela.Rows[i - 1].ItemArray.GetValue(0).ToString();

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
                retorno[i] = tabela.Rows[i - 1].ItemArray.GetValue(0).ToString();

            return retorno;
        }
        public string[] tamanhosDoTipo(int cod_tipo)
        {
            string query =
            " select tt.cod_tamanho, tt.descricao " +
            " from 	produto p      	  " +
            " inner join 	produtoTamanho pt         on (pt.cod_produto  = p.cod_produto)" +
            " inner join 	tamanho tt    	     	  on (tt.cod_tamanho  = pt.cod_tamanho )" +
            " inner join	tipo t			  on (t.cod_tipo      = p.cod_tipo)" +
            " where t.cod_tipo = " + cod_tipo +
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

        }// FINALIZADO
        public DataTable consultaVendaGeral(string []data, int order, bool hasFiltro, int filtro, int valorFiltro, bool ascen, bool cancelado)
        {
            string query = "select "
                + "to_char(v.cod_venda,'00000') as \"Id_Venda\", "                
                + "(select mm.descricao from mesa mm inner join vendaMesa vmm on(vmm.cod_mesa = mm.cod_mesa) inner join venda vv on (vv.cod_venda = vmm.cod_venda) where v.cod_venda = vv.cod_venda order by vv.cod_venda desc limit 1) as \"Venda\","
                + " (CASE v.horario > '06:00'  WHEN true THEN to_char(v.dataVenda, 'DD MM YYYY') ELSE to_char( v.dataVenda - 1, 'DD MM YYYY')||'* Madrugada'   end ) as \"Data\", to_char(v.horario, 'HH24:MI:SS') as \"Horario\", x.nomeCaixa as \"Caixa\" ,"
                + "(select gg.nome from garcon gg inner join GarconCompleto ccg on (ccg.cod_garcon = gg.cod_garcon) "
                     + " inner join completo cc on (cc.cod_completo = ccg.cod_completo) inner join vendaCompleta vvg on (vvg.cod_completo = cc.cod_completo) "
                     + " inner join venda vv on (vv.cod_venda = vvg.cod_venda) where vvg.cod_venda =  v.cod_venda order by vv.cod_venda desc limit 1) as \"Garcon\",";

            if (!cancelado) query += " (p.descricao) as \"Pagamento\",";
            else            query += " 'Não Houve' as \" Pagamento\", "; 
                
                 //   query +=" (CASE v.valorReal >0  WHEN true THEN (trim(to_char( v.valorReal,'9999.99'))) ELSE '0.00'  end ) as \"Valor\","
            query += "v.valorReal  as \"Valor\","// " trim(to_char(v.valorReal,'9999.99'))  as \"Valor\","
              
                +" (select x.descricao from ambiente x where x.cod_ambiente = (select mm.cod_ambiente from mesa mm inner join vendaMesa vmm on(vmm.cod_mesa = mm.cod_mesa) "
	               + " inner join venda vv on (vv.cod_venda = vmm.cod_venda) "
		           + " where v.cod_venda = vv.cod_venda order by vv.cod_venda desc limit 1)) as \"Ambiente\" "
                +" from  venda v " 
                +" inner join caixa x                   on (x.cod_caixa     = v.cod_caixa) "
                +" inner join pagamento p               on (p.cod_pagamento = v.cod_pagamento) "
             
                +" where v.aberta = false and v.cancelado = "+cancelado;
            if (hasFiltro)
                query += " and "+ filtroQuery(  filtro) +" = "+ (1+valorFiltro);
            if (data.Length == 1)
                query += " and( (v.dataVenda = '" + data[0] + "' and v.horario > ' 06:00' ) or (v.dataVenda = date '" + data[0] + "' + 1 and v.horario < ' 06:00' ))";     
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
        public DataTable consultaPorIDVenda(string cod_venda)
        {
            return null;
        }
        public DataTable consultaLeituraX(string data)
        {
            string query = "select "
                + "to_char(v.horario, 'HH24:MI') as \"Horario\", "
                + " v.cod_venda, "
                 + " p.cod_pagamento as \"Pagamento\","
                + " ( case v.valorReal > 0 when true then(trim(to_char( v.valorReal,'9999.99'))) else '0.00' end) as \"Valor\" "
                + ",( case v.cancelado when true then 'Extorno' else 'Finaliz' end) as \"Situacao\""
                + " from  venda v "
                + " inner join caixa x                   on (x.cod_caixa     = v.cod_caixa) "
                + " inner join pagamento p               on (p.cod_pagamento = v.cod_pagamento) "
                + " where v.aberta = false "+
         
                "and ((v.dataVenda = '" + data + "' and v.horario > ' 06:00' ) or (v.dataVenda = date '" 
                                        + data + "' + 1 and v.horario < ' 06:00' ))";
            
            //--filtros

            DataTable tabela = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(tabela);
            return tabela;
        } 
        public DataTable consultaGarconGeral(bool aberta, string[] data,bool hasGarcon, string garcon
        ,bool hasAmbiente, string ambiente, bool hasTipo, string tipo, int order , bool ascen)
        {
            string query =
                "select (CASE v.horario > '06:00'  WHEN true THEN to_char(v.dataVenda, 'DD MM YYYY') " +
                    "ELSE to_char( v.dataVenda - 1, 'DD MM YYYY')||'* Madrugada'   end ) as \"Data\" " +
                ", to_char(gc.horario, 'HH24:MI:SS') as \"HoraEntrega\" " +
                ", g.nome as \"Garcon\" " +
                " ,to_char(v.cod_venda,'00000') as \"Id_Venda\" "    +
             
                ",(select mm.descricao from mesa mm inner join vendaMesa vmm on(vmm.cod_mesa = mm.cod_mesa) " +
                    "inner join venda vv on (vv.cod_venda = vmm.cod_venda) " +
                    "where v.cod_venda = vv.cod_venda order by vv.cod_venda desc limit 1) as \"Mesa\" " +

                ",(select aa.descricao from ambiente aa inner join  mesa mm on (mm.cod_ambiente = aa.cod_ambiente) " +
                    "inner join vendaMesa vmm on(vmm.cod_mesa = mm.cod_mesa) " +
                    "inner join venda vv on (vv.cod_venda = vmm.cod_venda) ";
            if (hasAmbiente)
                query += " where v.cod_venda = vv.cod_venda and aa.cod_ambiente = "
                      + new BancoConsulta().codAmbientePelaDescricao(ambiente) 
                      + " order by vv.cod_venda desc limit 1) as \"Ambiente\",";
            else
                query += " where v.cod_venda = vv.cod_venda  order by vv.cod_venda desc limit 1) as \"Ambiente\",";
            query +=
                " t.nome as \"Segmento\" ,p.descricao as \"Produto\" ,tt.descricao as \"Tamanho\" "+
                ",(select s.descricao from divisor d inner join divisorSubDivisor ds on(d.cod_divisao = ds.cod_divisao) "+
                        "inner join subdivisor s on (s.cod_subDivisor= ds.cod_subdivisor) "+
                        "inner join tamanhoDIvisor td on (td.cod_divisao = d.cod_divisao) "+
                        "where   s.valor = cp.porcentagem and td.cod_tamanho = tt.cod_tamanho "+
                        "order by s.descricao desc limit 1) as \"Divisao\" "+
            
	                " , (c.valorUnitarioCompleto*(select s.valor from divisor d "+ 
	                "inner join divisorSubDivisor ds on(d.cod_divisao = ds.cod_divisao) "+
                        "inner join subdivisor s on (s.cod_subDivisor= ds.cod_subdivisor)  "+
                        "where   s.valor = cp.porcentagem order by s.descricao desc limit 1)) "+
                        " as \"ValorUnit\" "+
                ",gc.quantidade as \"Quantidade\" "+
                ",(case c.valorUnitarioCompleto > 0 when true then "+
                   
	                "((c.valorUnitarioCompleto*(select s.valor from divisor d "+
	                "inner join divisorSubDivisor ds on(d.cod_divisao = ds.cod_divisao) "+
                        "inner join subdivisor s on (s.cod_subDivisor= ds.cod_subdivisor) "+ 
                        "where   s.valor = cp.porcentagem order by s.descricao desc limit 1))  * gc.quantidade) "+
                        " else '0' end) as \"SubTotal\" " + 
                ",(CASE c.cancelado  WHEN true THEN 'Extornado' ELSE 'Vendido'  end ) as \"Entrega\" ";

            query +=
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
                " where v.aberta = " + aberta ;
                
                if (!aberta){
                    if (data.Length == 1)
                        query += " and ((v.dataVenda = '" + data[0] + "' and v.horario > ' 06:00' ) or (v.dataVenda = date '" + data[0] + "' + 1 and v.horario < ' 06:00' ))";
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
       //FINALIZADO
        public DataTable consultaProdutoGeral(string[] data, bool hasValor, bool hasTipo, int cod_tipo, bool hasTamanho, int cod_tamanho, 
            bool hasProduto, int cod_produto)
        {

            string query =
                " select "
                 + " (select pp.descricao from produto pp where pp.cod_produto = p.cod_produto) as \"Produto\" "
                 + " , (select pp.nome from tipo pp where pp.cod_tipo = t.cod_tipo) as \"Categoria\" "
                 + " , (select pp.descricao from tamanho pp where pp.cod_tamanho = tt.cod_tamanho) as \"SubCategoria\" "
                 + " ,(select s.descricao from divisor d inner join divisorSubDivisor ds on(d.cod_divisao = ds.cod_divisao)"
                     + " inner join subdivisor s on (s.cod_subDivisor= ds.cod_subdivisor) "
                     + " where   s.valor = cp.porcentagem order by s.descricao desc limit 1) as \"Divisao\" ";


            string quantidade =
              ",(select sum(gc7.quantidade) from garcon g7 inner join  garconCompleto gc7 on(gc7.cod_garcon = g7.cod_garcon) "
            + "inner join completo c7 on (c7.cod_completo = gc7.cod_completo) "
            + "inner join completoProduto cp7        on (cp7.cod_completo = c7.cod_completo)  "
            + "inner join produto p7      	     on (p7.cod_produto   = cp7.cod_produto )  "
            + "inner join produtoTamanho pt7         on (pt7.cod_produto  = p7.cod_produto)    "
            + "inner join tamanho tt7     	     on (tt7.cod_tamanho  = pt7.cod_tamanho and tt7.cod_tamanho =  cp7.cod_tamanho)  "
            + "inner join tipo t7 	             on (t7.cod_tipo      = p7.cod_tipo) "
            +"inner join vendaCompleta vc7 	 on( vc7.cod_completo = c7.cod_completo) "
	        +"inner join venda v7 		 on (v7.cod_venda = vc7.cod_venda ) "
            + "where v7.aberta = false and p7.cod_produto = p.cod_produto  and tt7.cod_tamanho = tt.cod_tamanho "
            + "and cp7.porcentagem = cp.porcentagem ";
            if (hasValor) quantidade += " and c7.valorUnitariocompleto = c.valorUnitarioCompleto ";

            if (data.Length == 1)
                quantidade += " and ((v7.dataVenda = '" + data[0] + "' and v7.horario > ' 06:00' ) or (v7.dataVenda = date '" + data[0] + "' + 1 and v7.horario < ' 06:00' ))";
            else
                quantidade += " and v7.dataVenda between '" + data[0] + "' and '" + data[1] + "' ";
            quantidade +=" and c7.cancelado = c.cancelado ) as \"Quantidade\" ";
            query += quantidade;
            string valorUnitario_subTotal =
                 " , (CASE (c.valorUnitarioCompleto*(cast(cp.porcentagem as double precision))) >0  "
                     + " WHEN true THEN ((c.valorUnitarioCompleto*(cast(cp.porcentagem as double precision) ))) "
                     + " ELSE '0'  end ) as \"ValorUnit\""
             + ",  (select ( ((c.valorUnitarioCompleto *  cp.porcentagem )*(select sum(gc7.quantidade) "
            + "from garcon g7 inner join  garconCompleto gc7 on(gc7.cod_garcon = g7.cod_garcon) "
            + "inner join completo c7 on (c7.cod_completo = gc7.cod_completo) "
            + "inner join completoProduto cp7        on (cp7.cod_completo = c7.cod_completo)  "
            + "inner join produto p7      	     on (p7.cod_produto   = cp7.cod_produto )  "
            + "inner join produtoTamanho pt7         on (pt7.cod_produto  = p7.cod_produto)    "
            + "inner join tamanho tt7     	     on (tt7.cod_tamanho  = pt7.cod_tamanho and tt7.cod_tamanho =  cp7.cod_tamanho)  "
            + "inner join tipo t7 	             on (t7.cod_tipo      = p7.cod_tipo) "
            + "inner join vendaCompleta vc7 	 on( vc7.cod_completo = c7.cod_completo) "
            + "inner join venda v7 		 on (v7.cod_venda = vc7.cod_venda ) " 
            + "where v7.aberta = false and p7.cod_produto = p.cod_produto and ";

             if (data.Length == 1)
                 valorUnitario_subTotal += " ((v7.dataVenda = '" + data[0] + "' and v7.horario > ' 06:00' ) or (v7.dataVenda = date '" + data[0] + "' + 1 and v7.horario < ' 06:00' ))";
            else
                 valorUnitario_subTotal += " v7.dataVenda between '" + data[0] + "' and '" + data[1] + "' ";
             valorUnitario_subTotal += "and cp7.porcentagem = cp.porcentagem and c7.valorUnitariocompleto = c.valorUnitarioCompleto and c7.cancelado = c.cancelado )))) as \"SubTotal\" ";

            if (hasValor)
                query += valorUnitario_subTotal;
                
                query+=
                   " ,(CASE c.cancelado  WHEN true THEN 'Extornado' ELSE 'Vendido'  end ) as \"Entrega\"";  
                query +=
               " from 		completo c              " +
                " inner join 	completoProduto cp        on (cp.cod_completo = c.cod_completo)     " +
                " inner join 	produto p      	     	  on (p.cod_produto   = cp.cod_produto ) " +
                " inner join 	produtoTamanho pt         on (pt.cod_produto  = p.cod_produto)   " +
                " inner join 	tamanho tt    	     	  on (tt.cod_tamanho  = pt.cod_tamanho and tt.cod_tamanho =  cp.cod_tamanho) " +
                " inner join	tipo t			          on (t.cod_tipo      = p.cod_tipo) " +
                " inner join	vendaCompleta vc	      on (vc.cod_completo = c.cod_completo)   " +
                " inner join 	venda v			          on (v.cod_venda = vc.cod_venda)" +
                " where v.aberta = false and ";
            if (data.Length == 1)
                query += " ((v.dataVenda = '" + data[0] + "' and v.horario > ' 06:00' ) or (v.dataVenda = date '" + data[0] + "' + 1 and v.horario < ' 06:00' ))";
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
            query += " group by t.cod_tipo,p.cod_produto, tt.cod_tamanho,cp.porcentagem , c.cancelado ";
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
       
        
    }
}
