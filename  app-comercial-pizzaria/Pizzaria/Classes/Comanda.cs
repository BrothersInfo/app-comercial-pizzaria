using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pizzaria.Classes
{

    using Pizzaria.Banco;
    public class Comanda
    {
        public string empresa;
        public string rua;
        public string telefone;
        public string titulo;
        public string mensagem;
        public string cidade;
        public string progNome;
        public string progTelefone;
        public string data;
        public int cod_venda;
        public Comanda(int codVenda)
        {
            DataTable dtt = new Banco().carregaComanda();
            setFull(dtt.Rows[0].ItemArray.GetValue(0).ToString(), dtt.Rows[0].ItemArray.GetValue(1).ToString(),
                dtt.Rows[0].ItemArray.GetValue(2).ToString(), dtt.Rows[0].ItemArray.GetValue(3).ToString(),
                dtt.Rows[0].ItemArray.GetValue(4).ToString(), dtt.Rows[0].ItemArray.GetValue(5).ToString(),
                dtt.Rows[0].ItemArray.GetValue(6).ToString(), dtt.Rows[0].ItemArray.GetValue(7).ToString());
            this.cod_venda = codVenda;
            this.data = fixCenter(new Banco().dataVenda(cod_venda), 1);
        }
        public Comanda(int codVenda, bool tre)
        {
            DataTable dtt = new Banco().carregaComanda();
            setFull2(dtt.Rows[0].ItemArray.GetValue(0).ToString());
            this.cod_venda = codVenda;
       //     this.data = fixCenter(new Banco().dataVenda(cod_venda), 2);
        }


        public void setFull(string empresa, string rua, string telefone, string titulo, string mensagem, string cidade, string progNome, string progTelefone)
        {
            this.empresa = empresa;
            this.empresa = fixEmpresa(this.empresa, 1);
            this.rua = rua;
            this.rua = fixCenterPont(this.rua, 1);
            this.telefone = telefone;
            this.telefone = fixCenterPont(this.telefone, 1);
            this.titulo = titulo;
            this.titulo = fixCenter(this.titulo, 1);
            this.mensagem = mensagem;
            this.mensagem = fixCenter(this.mensagem, 1);
            this.cidade = cidade;
            this.cidade = fixRightPont(this.cidade, 1);


            this.progNome = progNome;
            this.progNome = fixRightPont(this.progNome, 1);
            
            this.progTelefone = progTelefone;
            this.progTelefone = fixRightPont(this.progTelefone, 1);


        }
        public void setFull2(string empresa)
        {
            this.empresa = empresa;
            
        }


        private string fixEmpresa(string empresa, int num)
        {
            
            char[] c = new char[46/num];
            c[0] = ' '; c[(46/num)-1] = ' ';
            for (int i = 1; i < c.Length - 1; i++)
                c[i] = '-';

            int ini = (c.Length / 2) - (empresa.Length / 2);
            for (int i = 0; i < empresa.Length; i++)
                c[ini + i] = empresa.ToCharArray()[i];

            empresa = "";
            for (int i = 0; i < c.Length; i++)
                empresa += c[i];
            return empresa;
        }
        private string fixCenterPont(string vari, int num)
        {
            int x = (48 - num) / num;
            char[] c = new char[x];
            c[0] = '|'; c[x-1] = '|';
            for (int i = 1; i < c.Length - 1; i++)
                c[i] = '-';

            int ini = (c.Length / 2) - (vari.Length / 2);
            for (int i = 0; i < vari.Length; i++)
                c[ini + i] = vari.ToCharArray()[i];
            vari = "";
            for (int i = 0; i < c.Length; i++)
                vari += c[i];
            return vari;
        }
        public string fixCenter(string vari, int num)
        {
            vari = " " + vari + " ";
            int x = (48 - num) / num;//37 ou 
            char[] c = new char[x];
            c[0] = '|'; c[x-1] = '|';
            for (int i = 1; i < c.Length - 1; i++)
                c[i] = ' ';

            int ini = (c.Length / 2) - (vari.Length / 2);
            for (int i = 0; i < vari.Length; i++)
                c[ini + i] = vari.ToCharArray()[i];
            vari = "";
            for (int i = 0; i < c.Length; i++)
                vari += c[i];
            return vari;
        }
        public string fixRightPont(string vari, int num)
        {
            vari = " " + vari + " ";
            int x = (48 - num) / num;//37 ou 
            char[] c = new char[x];
            c[0] = '|'; c[x-1] = '|';
            for (int i = 1; i < c.Length - 1; i++)
                c[i] = '-';

            int ini = (c.Length) - (vari.Length + 1);
            for (int i = 0; i < vari.Length; i++)
                c[ini + i] = vari.ToCharArray()[i];
            vari = "";
            for (int i = 0; i < c.Length; i++)
                vari += c[i];
            return vari;
        }
        public string fixRightPontClear(string vari, int num)
        {
            vari = " " + vari + " ";
            int x = (48 - num) / num;//37 ou 
            char[] c = new char[x ];
            c[0] = '|'; c[x -1 ] = '|';
            for (int i = 1; i < c.Length - 1; i++)
                c[i] = ' ';

            int ini = (c.Length) - (vari.Length + 1);
            for (int i = 0; i < vari.Length; i++)
                c[ini + i] = vari.ToCharArray()[i];
            vari = "";
            for (int i = 0; i < c.Length; i++)
                vari += c[i];
            return vari;
        }
    }
}
