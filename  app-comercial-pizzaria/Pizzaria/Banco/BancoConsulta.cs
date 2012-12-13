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

    public class BancoConsulta
    {
        string conexao = "server=Localhost; Port=5432;User =postgres;Password=fof0130407*;Database=Delirius";
        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(conexao);
        }
        public bool isTamanhoAtivo(int cod_produto, int cod_tamanho)
        {
            string query = "select count (t.cod_tamanho) from produto p "
                +"inner join produtoTamanho pt on (p.cod_produto = pt.cod_produto)"
                +" inner join tamanho t on (t.cod_tamanho = pt.cod_tamanho) 	where p.cod_produto = " 
                + cod_produto + " and t.cod_tamanho = " + cod_tamanho + "";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;

        }
        //--------------------------------TAMANHO-------------------------------
        public void alterarTamanho(string antigo, string novo, bool ativo)
        {
            string query = "UPDATE tamanho    SET  descricao= '" + novo + "', ativo = " + ativo 
                + " WHERE  upper(descricao) = upper( trim('" + antigo + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }
        public DataTable descricaoTamanho()
        {
            string query = "select descricao from tamanho where ativo  = true order by cod_tamanho";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }
        public DataTable descricaoTamanhoAll()
        {
            string query = "select descricao from tamanho  order by cod_tamanho";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }
        public bool existeTamanho(string nome)
        {
            string query = "select count (descricao) from tamanho where ativo  = true"
                +" and upper(descricao) = upper( trim('" + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
            //
        }
        public bool existeTamanhoAll(string nome)
        {
            string query = "select count (descricao) from tamanho where  upper(descricao) = upper( trim('" + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
            //
        }
        public bool isTamanhoAtivo(string descricao)
        {
            string query = "select ativo from tamanho where upper(descricao) = upper( trim('" + descricao + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
        }
        public void alterarTamanho(string antigo, string novo)
        {
            string query = "UPDATE tamanho    SET  descricao= '" + novo 
                + "' WHERE  ativo  = true and upper(descricao) = upper( trim('" + antigo + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }
        public void novoTamanho(string novo)
        {
            string query = "INSERT INTO tamanho(cod_tamanho, descricao)    VALUES (" 
                + novoCod_tamanho() + " , '" + novo + "')";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

        }
        public int novoCod_tamanho()
        {
            try
            {
                string query = "select cod_tamanho from tamanho order by cod_tamanho desc limit 1";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return (1 + Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));
            }
            catch
            {
                return 1;
            }
        }
        //--------------------------------TIPO-----------------------------------



        public void alterarTipo(string antigo, string novo, bool ativo)
        {
            string query = "UPDATE tipo    SET  nome= '" + novo + "', ativo = " + ativo 
                + " WHERE  upper(nome) = upper( trim('" + antigo + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }

        public DataTable descricaoTipoAll()
        {
            string query = "select nome from tipo  order by cod_tipo";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }

        public bool existeTipoAll(string nome)
        {
            string query = "select count (nome) from tipo where  upper(nome) = upper( trim('" + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
            //
        }
        public bool isTipoAtivo(string nome)
        {
            try
            {
                string query = "select ativo from tipo where upper(nome) = upper( trim('" + nome + "'))";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return Convert.ToBoolean(dtt.Rows[0].ItemArray.GetValue(0));
            }
            catch { return false; }
        }

        public DataTable descricaoTipo()
        {
            string query = "select nome from tipo where ativo  = true order by cod_tipo";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }
        public bool existeTipo(string descricao)
        {
            string query = "select count (nome) from tipo  where  ativo  = true and upper(nome) = "
                +"upper( trim('" + descricao + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
            //
        }
        public void alterarTipo(string antigo, string novo)
        {
            string query = "UPDATE tipo SET nome= '" + novo + "'  WHERE  upper(nome) = upper( trim('" + antigo + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }
        public void novoTipo(string novo)
        {
            string query = "INSERT INTO tipo(cod_tipo, nome)    VALUES (" + novoCod_tipo() + " ,'" + novo + "')";

            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

        }
        public int novoCod_tipo()
        {
            try
            {
                string query = "select cod_tipo from tipo order by cod_tipo desc limit 1";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return (1 + Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));
            }
            catch
            {
                return 1;
            }
        }
        //--------------------------------AMBIENTE---------------------------------
        public DataTable descricaoAmbiente()
        {
            string query = "select descricao from ambiente where ativo = true order by cod_Ambiente";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }
        public DataTable descricaoAmbienteAll()
        {
            string query = "select descricao from ambiente  order by cod_Ambiente";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }
        //se a consultar retornar 1, existe o valor na tabela.
        public bool existeAmbiente(string nome)
        {
            string query = "select count (*) from ambiente where upper(descricao) = upper( trim('" 
                + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
            //
        }
        public void alterarAmbiente(string antigo, string novo, bool ativo)
        {
            string query = "UPDATE ambiente    SET  descricao= '" + novo + "', ativo = " 
                + ativo + " WHERE  upper(descricao) = upper( trim('" + antigo + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }
        public void novoAmbiente(string novo)
        {
            string query = "INSERT INTO ambiente(cod_ambiente, descricao)    VALUES (" 
                + novoCod_Ambiente() + " , '" + novo + "')";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

        }
        public int novoCod_Ambiente()
        {
            try
            {
                string query = "select cod_Ambiente from ambiente order by cod_ambiente desc limit 1";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return (1 + Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));
            }
            catch
            {
                return 1;
            }
        }
        public string ambienteDaMesa(string mesa)
        {
            try
            {
                string query = "select b.descricao from mesa m inner join ambiente b on "
                    +"(b.cod_ambiente = m.cod_ambiente) where m.descricao = '" + mesa + "'";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return dtt.Rows[0].ItemArray.GetValue(0).ToString();
            }
            catch { return ""; }
        }

        public bool existeAmbienteAll(string descricao)
        {
            string query = "select count (descricao) from ambiente where  upper(descricao) = upper( trim('" 
                + descricao + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
            //
        }
        public bool isAmbienteAtivo(string descricao)
        {
            try
            {
                string query = "select ativo from ambiente where upper(descricao) = upper( trim('" 
                    + descricao + "'))";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return Convert.ToBoolean(dtt.Rows[0].ItemArray.GetValue(0));
            }
            catch { return false; }
        }


        //---------------------------------MESA-----------------------------------
        public DataTable descricaoMesa()
        {
            string query = "select  m.descricao from mesa m  order by m.cod_mesa";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }

        public bool isMesaAtivo(string descricao)
        {
            try
            {
                string query = "select ativo from mesa where upper(descricao) = upper( trim('" + descricao + "'))";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return Convert.ToBoolean(dtt.Rows[0].ItemArray.GetValue(0));
            }
            catch
            {
                return false;
            }
        }
        public void alterarAmbienteDaMesa(string ambienteNovo, string descricao, bool ativo)
        {
            string query = "UPDATE mesa   SET  cod_ambiente = '" + codAmbientePelaDescricao(ambienteNovo) +
               "' , ativo = " + ativo + " WHERE  upper(descricao) = upper( trim('" + descricao + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }
        public int codAmbientePelaDescricao(string ambiente)
        {
            string query = "select cod_ambiente from ambiente where descricao = '" + ambiente + "'";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

            return Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));
        }
        public void novaMesa(string ambiente)
        {

            string query = "INSERT INTO mesa(cod_mesa, descricao, cod_ambiente, status) VALUES ("
                + novoCod_Mesa() + ", 'Mesa " + novoCod_Mesa() + "'," + codAmbientePelaDescricao(ambiente) + ", true)";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

        }
        public string nomeProximaMesa()
        {
            return "Mesa " + novoCod_Mesa();
        }
        public int novoCod_Mesa()
        {
            try
            {
                string query = "select cod_mesa from mesa order by cod_mesa desc limit 1";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return (1 + Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));
            }
            catch
            {
                return 1;
            }
        }
        public bool existeMesaAll(string nome)
        {
            string query = "select count (descricao) from mesa where upper(descricao) = upper( trim('" 
                + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
            //
        }

        //--------------------------------GARCON----------------------------------
        public bool getGarconAtivo(string nome)
        {
            string query = "select ativo from garcon where upper(nome) = upper( trim('" + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return Convert.ToBoolean(Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));

        }
        public DataTable descricaoGarcon()
        {
            string query = "select nome, ativo from  garcon  order by cod_garcon";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }
        public bool existeGarcon(string nome)
        {
            string query = "select count (*) from garcon where upper(nome) = upper( trim('" + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
            //
        }
        public void alterarGarcon(string antigo, string novo, bool ativo)
        {
            string query = "UPDATE garcon    SET  nome= '" + novo + "', ativo = " + ativo 
                + " WHERE  upper(nome) = upper( trim('" + antigo + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }
        public void novoGarcon(string novo)
        {
            string query = "INSERT INTO garcon(cod_garcon, nome)    VALUES (" + novoCod_Garcon() + " , '" 
                + novo + "')";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

        }
        public int novoCod_Garcon()
        {
            try
            {
                string query = "select cod_garcon from garcon order by cod_garcon desc limit 1";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return (1 + Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));
            }
            catch
            {
                return 1;
            }
        }
        //------------------------------CAIXA--------------------------------------
        public DataTable descricaoCaixa()
        {
            string query = "select nomecaixa from caixa order by cod_caixa";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }
        public bool isAdm(string nome)
        {
            string query = "select nivel_acesso from caixa where upper(nomeCaixa) = upper( trim('" + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return Convert.ToBoolean(Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));
        }
        public DataTable carregarCaixaFull(string caixa)
        {
            string query = "select * from caixa where upper(nomecaixa) = upper( trim('" + caixa
                + "')) or upper(id) = upper( trim('" + caixa + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt;
        }
        public void caixaOpcoes(string caixa, string novo, string id, string senha, bool adm)
        {
            DataTable dtt = carregarCaixaFull(caixa);
            if (novo.Equals(""))
                novo = dtt.Rows[0].ItemArray.GetValue(1).ToString();
            if (id.Equals(""))
                id = dtt.Rows[0].ItemArray.GetValue(2).ToString();
            if (senha.Equals(""))
                senha = dtt.Rows[0].ItemArray.GetValue(3).ToString();

            alterarCaixa(caixa, novo, id, senha, adm);
        }
        public bool existeCaixa(string nome, string id)
        {
            try
            {
                string query = "select count (*) from caixa where upper(nomecaixa) = upper( trim('" + nome 
                    + "')) or upper(id) = upper( trim('" + id + "'))";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
                //
            }
            catch { return false; }
        }
        private void alterarCaixa(string antigoNome, string novo, string id, string senha, bool adm)
        {
            string query = "UPDATE caixa    SET  nomecaixa= '" + novo 
                + "', nivel_acesso= " + adm + ", id= '" + id + "', senha= '" + senha 
                + "' WHERE  upper(nomecaixa) = upper( trim('" + antigoNome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }
        public string getNome_Caixa(int cod_caixa)
        {
            string query = "select nomecaixa from caixa where cod_caixa='" + cod_caixa + "'";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return dtt.Rows[0].ItemArray.GetValue(0).ToString();

        }
        public void novoCaixa(string novo, string id, string senha, bool adm)
        {
            string query = "INSERT INTO caixa(cod_caixa, nomecaixa, nivel_acesso, id, senha)  VALUES (" +
                novoCod_Caixa() + " , '" + novo + "' , " + adm + " ,  '" + id + "', '" + senha + "' )";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);

        }
        public int novoCod_Caixa()
        {
            try
            {
                string query = "select cod_caixa from caixa order by cod_caixa desc limit 1";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return (1 + Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));
            }
            catch
            {
                return 1;
            }
        }
        //-----------------------------PRODUTO------------------------------------
        public bool produtoIsAtivo(int codProduto)
        {
            string query = "select aTIvo from produto where cod_produto = " + codProduto;
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return Convert.ToBoolean(Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));

        }
        public bool prodExiste(int codProduto)
        {
            string query = "select count (*) from produto where cod_produto = " + codProduto;
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
        }
        public void produtoAlterarAll(int cod_produto, string descricao, int codTipo, bool ativo)
        {
            string query = "UPDATE produto   SET descricao= '" + descricao + "' , cod_tipo= '" 
                + codTipo + "' , ativo= " + ativo + "   WHERE cod_produto =  " + cod_produto + " ";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
        }


        public bool existeProdudo(string nome)
        {
            string query = " select count (*) from produto where  ativo  = true and"
                +" upper(descricao) = upper( trim('" + nome + "'))";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;

        }
        public int novoCod_Produto()
        {
            try
            {
                string query = "select cod_produto from produto order by cod_produto desc limit 1";
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return (1 + Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0)));
            }
            catch
            {
                return 1;
            }
        }
        public int cod_tipoPeloNome(string nome)
        {
            string query = "select cod_tipo from tipo where ativo  = true and upper(nome) = "
                +"upper( trim('" + nome + "'))";
            try
            {
                DataTable dtt = new DataTable();
                NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
                sql.Fill(dtt);
                return Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));
            }
            catch { return 0; }
        }

        public void cadastrarProduto(string nome, string tipo, Tamanho[] tam, bool isPizza)
        {
            int cod_produto = novoCod_Produto();

            string query = "INSERT INTO produto(cod_produto, descricao, cod_tipo, isPizza)  VALUES ("
                + cod_produto + " , '" + nome + "' , " + cod_tipoPeloNome(tipo) + " , " + isPizza + " )";
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query, Conectar());
            sql.Fill(dtt);
            for (int i = 0; i < tam.Length; i++)
            {
                string query2 = "INSERT INTO produtotamanho( cod_produto, cod_tamanho, valorproduto) VALUES ("
                    + cod_produto + ",'" + tam[i].cod_tamanho2 + "' , " + (tam[i].valor).ToString().Replace(',', '.') 
                    + ")";
                dtt = new DataTable();
                sql = new NpgsqlDataAdapter(query2, Conectar());
                sql.Fill(dtt);
            }

        }
        public void alterarTamanhoDoProduto(string nome, Tamanho[] tam)
        {
            int cod_produto = new Banco().codigoProduto(nome);
            string query1 = "DELETE FROM produtotamanho WHERE cod_produto =" + cod_produto;
            DataTable dtt = new DataTable();
            NpgsqlDataAdapter sql = new NpgsqlDataAdapter(query1, Conectar());
            sql.Fill(dtt);
            for (int i = 0; i < tam.Length; i++)
            {
                string query2 = "INSERT INTO produtotamanho( cod_produto, cod_tamanho, valorproduto) VALUES ("
                    + cod_produto + ",'" + tam[i].cod_tamanho2 + "' , " 
                    + (tam[i].valor).ToString().Replace(',', '.') + ")";
                dtt = new DataTable();
                sql = new NpgsqlDataAdapter(query2, Conectar());
                sql.Fill(dtt);
            }
        }

        public bool mesaImpressa(string mesa)
        {
            string query2 = "select count (m.cod_mesa) from venda v  "
                +"inner join vendaMesa vm on(vm.cod_venda = v.cod_venda)" +
                "inner join mesa m on (m.cod_mesa = vm.cod_mesa)" +
                " where m.status = false and aberta = true and "
                +"impressao = true and upper(m.descricao) = upper( trim('" + mesa + "'))";
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query2, Conectar()).Fill(dtt);

            return (Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0))) == 1;
        }
        //------------------------CONSULTA DE PRECO ------------------------------
        public DataTable tabela(bool preco)
        {
            DataTable t = new DataTable();
            string query = "";
            if (preco)
                query = "select p.cod_produto, p.descricao as \"Produto\", t.descricao as \"Sub-Categoria\"," +
                   "cast( ( valorProduto ) as character varying(10) ) as \"Valor\"" +
                   "from produto p  inner join produtotamanho pt on( p.cod_produto = pt.cod_produto)" +
                   " inner join tamanho t on(t.cod_tamanho = pt.cod_tamanho)inner join tipo i on (i.cod_tipo = p.cod_tipo) "
                   +"where p.ativo = true and t.ativo = true and i.ativo = true order by p.cod_produto, t.cod_tamanho";
            else query = "select p.cod_produto, p.descricao as \"Produto\", t.nome as \"Segmento\"" +
                "from produto p  inner join tipo t on( t.cod_tipo = p.cod_tipo) "
                +"	where p.ativo = true and t.ativo = true order by p.cod_produto";
            new NpgsqlDataAdapter(query, Conectar()).Fill(t);
            //codigo - nomeProduto - tamanho - valor
            return t;

        }

    }
}
