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

            return null;
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
            default : return " v.data";
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

        
    }
}
