using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;
using System.Collections;

namespace Pizzaria
{
    public class BancoRelatorio
    {

        string conexao = "server=Localhost; Port=5432;User =postgres;Password=[zxc123];Database=Pizzaria";
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



    }
}
