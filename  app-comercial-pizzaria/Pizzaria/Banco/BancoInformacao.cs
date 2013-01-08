using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;
using System.Collections;
using Pizzaria.Classes;


namespace Pizzaria.Banco
{
    public class BancoInformacao
    {
         string conexao;
        //-------------------------------------
        //novos metodos
        //-------------------------------------
        
        public BancoInformacao()
        {
            conexao = new BancoSenha().conexao;
        }
        
        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(conexao);
        }
        //metodos responsaveis por enviar String voltar codigo da tabela.


        //metodos responsaveis por enviar um codigo e retornar uma string
        public string tamanhoDescricaoByCodigo(int cod_tamanho)
        {
            string query = "select descricao from tamanho where cod_tamanho = " + cod_tamanho;
            DataTable tamanho = new DataTable();
            new NpgsqlDataAdapter  (query, Conectar()).Fill(tamanho);

            return tamanho.Rows[0].ItemArray.GetValue(0).ToString();
        }
        public int criarCompleto(int cod_venda, int cod_garcon, double valorUnitario
                                 , int quantidadeItem, bool impresso, bool cancelado, Produto[] conjProd)
        {
            int cod_completo = new Banco().novoCompleto(conjProd, valorUnitario, cancelado);
            new Banco().makeVendaCompleto(cod_venda, cod_completo);
            GarconCompleto(cod_garcon, cod_completo, quantidadeItem);

            return cod_completo;
        }
        public int criarCompletoEspecial(int cod_venda,  double valorUnitario
                               , int quantidadeItem, bool impresso, bool cancelado, Produto[] conjProd)
        {
            int cod_completo = new Banco().novoCompleto(conjProd, valorUnitario, cancelado);
            new Banco().makeVendaCompleto(cod_venda, cod_completo);
            return cod_completo;
        }
        public bool existeProdutoNaVenda(int cod_venda, int cod_produto,int cod_tamanho,  double valor)
        {
            string query = "select count(*)>0 "
	    +"from venda v inner join vendaCompleta vc on (vc.cod_venda = v.cod_venda) "
		+"inner join completo c on (c.cod_completo = vc.cod_completo) "
		+"inner join completoProduto cp on (cp.cod_completo = c.cod_completo) "
		+"where v.cod_venda = "+cod_venda
		+"and cp.porcentagem = 1 and c.cancelado = false "
        + "and c.valorunitariocompleto = "+ new Tratamento().retornaValorEscrito(valor).Replace(',', '.')
		+" and cp.cod_produto = "+ cod_produto
        +" and cp.cod_tamanho = " + cod_tamanho;
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            return Convert.ToBoolean(dtt.Rows[0].ItemArray.GetValue(0));

        }
        public int codCompletoExistente(int cod_venda, int cod_produto, int cod_tamanho, double valor)
        {
            string query = "select c.cod_completo "
        + "from venda v inner join vendaCompleta vc on (vc.cod_venda = v.cod_venda) "
        + "inner join completo c on (c.cod_completo = vc.cod_completo) "
        + "inner join completoProduto cp on (cp.cod_completo = c.cod_completo) "
        + "where v.cod_venda = " + cod_venda
        + "and cp.porcentagem = 1 and c.cancelado = false "
        + "and c.valorunitariocompleto = " + new Tratamento().retornaValorEscrito(valor).Replace(',', '.')
        + " and cp.cod_produto = " + cod_produto
        + " and cp.cod_tamanho = " + cod_tamanho;
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
            return Convert.ToInt16(dtt.Rows[0].ItemArray.GetValue(0));

        }
        public void deletarCompleto(int cod_Completo, int quantidadeRetirada)
        {

            if (quantidadeCompletaByCodigo(cod_Completo) == quantidadeRetirada)
            {
                makeCompletoDeletado(cod_Completo, true);
            }
            else
            {   
                Completa c = new BancoVenda().getCompleta(cod_Completo, false);
               int codigo = criarCompletoEspecial(codigoVendaByCompleto(cod_Completo), 
                   c.valorUnitario
                  , quantidadeRetirada, c.needImpress, true, c.produto);
                dinimuirGarcon(cod_Completo, quantidadeRetirada, codigo);
            }


        }
        public int codigoVendaByCompleto(int cod_completo)
        {
            string query = "select cod_venda from vendaCompleta where cod_completo = "+cod_completo;
            DataTable quantidadeTable = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(quantidadeTable);
            return Convert.ToInt16(quantidadeTable.Rows[0].ItemArray.GetValue(0));

        }
        public void makeCompletoDeletado(int cod_completo, bool cancelado)
        {
            string query = "update Completo set cancelado = " + cancelado + " where cod_completo = " + cod_completo;
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);
        }
        public int quantidadeCompletaByCodigo(int cod_completo)
        {
            string qtdItens = "select sum(cg.quantidade)  "
                +" from garcon g "
            + " inner join garconCompleto cg on(cg.cod_garcon = g.cod_garcon)"
            + " inner join completo c on(c.cod_completo = cg.cod_completo)"
            + " where c.cod_completo = " + cod_completo + " and c.cancelado =  false";
            DataTable quantidadeTable = new DataTable();
            new NpgsqlDataAdapter(qtdItens, Conectar()).Fill(quantidadeTable);
            return Convert.ToInt16(quantidadeTable.Rows[0].ItemArray.GetValue(0));

        }
        public void alterarVendaCompleta(int cod_vendaAnt,int cod_vendaNova, int cod_completa)
        {
          string query =  "update vendaCompleta set cod_venda = "+ cod_vendaNova+" where cod_venda = "
              + cod_vendaAnt+ " and cod_completo = "+cod_completa;
            
            new NpgsqlDataAdapter(query, Conectar()).Fill(new DataTable());
          

        }
        public void dinimuirGarcon(int cod_completo, int quantidade, int cod_completoNovo)//sem o novo Completo
        {
            DataTable compl = new DataTable();
            string itens = "select g.cod_garcon,cg.quantidade from garcon g "
                + " inner join garconCompleto cg on(cg.cod_garcon = g.cod_garcon)"
                + " inner join completo c on(c.cod_completo = cg.cod_completo)"
                + " where c.cod_completo = " + cod_completo + " and c.cancelado = false order by cg.horario";
            new NpgsqlDataAdapter(itens, Conectar()).Fill(compl);

            for (int i = 0; (i < compl.Rows.Count) && (quantidade > 0); i++)
            {
                int codigo = Convert.ToInt16(compl.Rows[i].ItemArray.GetValue(1));
                if (Convert.ToInt16(compl.Rows[i].ItemArray.GetValue(1)) <= quantidade)//se a quantidade desse garcon e igual ou menor ao q deve ser deletado
                {
                    alterarTabelaCompletaGarcon(Convert.ToInt16(compl.Rows[i].ItemArray.GetValue(0)), cod_completo, cod_completoNovo, Convert.ToInt16(compl.Rows[i].ItemArray.GetValue(1)));
                    quantidade -= Convert.ToInt16(compl.Rows[i].ItemArray.GetValue(1));
                }
                else
                {
                    alterarTabelaCompletaGarconQuantidade(Convert.ToInt16(compl.Rows[i].ItemArray.GetValue(0)), cod_completo, quantidade, Convert.ToInt16(compl.Rows[i].ItemArray.GetValue(1)));
                    GarconCompleto(Convert.ToInt16(compl.Rows[i].ItemArray.GetValue(0)), cod_completoNovo, quantidade);
                    quantidade = 0;
                }
            }
        }
        public void alterarTabelaCompletaGarcon(int cod_garcon, int cod_completoantigo, int cod_completoNovo, int quantidade)
        {
            string query = "update garconCompleto set cod_completo = " + cod_completoNovo
                        + " where cod_completo =  " + cod_completoantigo + " and cod_garcon = " + cod_garcon +
                       " and quantidade =  "+quantidade+" and horario = " +
                "(select horario from garconCompleto where cod_garcon = "+cod_garcon
                + " and cod_completo = " + cod_completoantigo + "  and quantidade =  " + quantidade + "  order by horario desc limit 1)";
            DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);

        }
        public void alterarTabelaCompletaGarconQuantidade(int cod_garcon, int cod_completo, int quantidade, int qtdAntiga)
        {
            string query = "update garconCompleto set quantidade = (quantidade-" + quantidade
                        + ") where cod_completo =  " + cod_completo + " and cod_garcon = " + cod_garcon +
                        "  and quantidade =  " + qtdAntiga + "  and horario = " +
                        "(select horario from garconCompleto where cod_garcon = " + cod_garcon
                        + " and cod_completo = " + cod_completo + " and quantidade =  " 
                        + qtdAntiga + "  order by horario desc limit 1)";
                        DataTable dtt = new DataTable();
                        new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);

        }
        public int[] garconByCompleto(int cod_completo)
        {
            string query = "select cod_garcon from garconCompleto where  cod_completo = "+cod_completo+" group by cod_garcon";
               DataTable dtt = new DataTable();
            new NpgsqlDataAdapter(query, Conectar()).Fill(dtt);

            int[] sim = new int[dtt.Rows.Count];
            for (int i = 0; i < sim.Length; i++)
                sim[i] = Convert.ToInt16( dtt.Rows[i].ItemArray.GetValue(0));
            
            return sim;
        }
        public void addqtdGarconCompleto(int cod_garcon, int cod_completo, int quantidade)
        {
            string opa = "select count(*)=0 from garconCompleto where cod_garcon = "+cod_garcon+" and cod_completo = "+cod_completo;
             DataTable dttOpa = new DataTable();
            new NpgsqlDataAdapter(opa, Conectar()).
              Fill(dttOpa);
                GarconCompleto(cod_garcon, cod_completo, quantidade);

            }
        public void GarconCompleto(int cod_garcon, int cod_completo, int quantidade)
        {
            DataTable dtt = new DataTable();
            string query = "INSERT INTO garconcompleto( cod_garcon, cod_completo, quantidade)    VALUES (" + cod_garcon + "," + cod_completo + "," + quantidade + ")";
            new NpgsqlDataAdapter(query, Conectar()).
              Fill(dtt);
        }
        public void transferirCompleto(int cod_Completo, int quantidadeRetirada, int cod_venda)
        {

            if (new BancoInformacao().quantidadeCompletaByCodigo(cod_Completo) == quantidadeRetirada)
            {
                //se for a mesma quantidade, eu so preciso atualizar .
                //VendaCompleta onde cod_venda veio do metodo
                mudaVendaCompleta(cod_venda, cod_Completo);
            }
            else
            {
                Completa c = new BancoVenda().getCompleta(cod_Completo, false);//peguei o comple
                int novoCompleto = new BancoInformacao().criarCompletoEspecial(cod_venda
                                                   , c.valorUnitario
                                                   , quantidadeRetirada
                                                   , c.needImpress, false, c.produto);
                new BancoInformacao().dinimuirGarcon(cod_Completo, quantidadeRetirada, novoCompleto);
            }
        }
        public void mudaVendaCompleta(int cod_venda, int cod_completo)
        {
            string query = "update vendaCompleta set  cod_venda = " + cod_venda + " where cod_completo = " + cod_completo;

            new NpgsqlDataAdapter(query, Conectar()).Fill(new DataTable());
        }
        public void unirProdutosIguais(VendaFull vf)
        {
            for (int i = 0; i < vf.Completos.Length-1; i++)
            {
                Completa temp = vf.Completos[i];
                for (int j = i + 1; j < vf.Completos.Length; j++)
                {
                    
                    if(doisProdutos(temp,vf.Completos[j])){
                        agruparDoisItens(temp.cod_completo, vf.Completos[j].cod_completo);
                       
                    }
                }
            }

        }
        public void agruparDoisItens(int codigoA, int codigoB)
        {//a -> B
            //update na quantidade e no valor de B, acrescentando A.

         
            string query2 = "update garconCompleto set cod_completo = " + codigoB + " where cod_completo = " + codigoA;
            new NpgsqlDataAdapter(query2, Conectar()).
              Fill(new DataTable());
            string query3 = "delete from vendaCompleta where cod_completo = " + codigoA;
            new NpgsqlDataAdapter(query3, Conectar()).
           Fill(new DataTable());
            string query4 = "delete from completoProduto where cod_completo = " + codigoA;
            new NpgsqlDataAdapter(query4, Conectar()).
           Fill(new DataTable());
            

        }
        public bool doisProdutos(Completa um, Completa dois)
        {
            if ((um.valorUnitario == dois.valorUnitario) && 
                (um.produto[0].cod_tamanho == dois.produto[0].cod_tamanho) && 
                (um.produto.Length == dois.produto.Length))
            {
                for (int i = 0; i < um.produto.Length; i++)
                    if ((um.produto[i].cod_produto != dois.produto[i].cod_produto) ||(um.produto[i].porcentagem!=  dois.produto[i].porcentagem))
                        return false;
                return true;
            }
            else
            { return false; }
        }

    }
}
