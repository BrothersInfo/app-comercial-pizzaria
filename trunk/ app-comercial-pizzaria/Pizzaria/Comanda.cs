﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Pizzaria
{
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

        public Comanda()
        {
            DataTable dtt = new Banco().carregaComanda();
            setFull(dtt.Rows[0].ItemArray.GetValue(0).ToString(), dtt.Rows[0].ItemArray.GetValue(1).ToString(),
                dtt.Rows[0].ItemArray.GetValue(2).ToString(), dtt.Rows[0].ItemArray.GetValue(3).ToString(),
                dtt.Rows[0].ItemArray.GetValue(4).ToString(), dtt.Rows[0].ItemArray.GetValue(5).ToString(),
                dtt.Rows[0].ItemArray.GetValue(6).ToString(), dtt.Rows[0].ItemArray.GetValue(7).ToString() );
        }

        public void setFull(string empresa, string rua, string telefone, string titulo, string mensagem, string cidade, string progNome, string progTelefone)
        {
            this.empresa = empresa;
            this.empresa = fixEmpresa(this.empresa);
            this.rua = rua;
            this.rua = fixCenterPont(this.rua);
            this.telefone = telefone;
            this.telefone = fixCenterPont(this.telefone);
            this.titulo = titulo;
            this.titulo = fixCenter(this.titulo);
            this.mensagem = mensagem;
            this.mensagem = fixCenter(this.mensagem);
            this.cidade = cidade;
            this.cidade = fixRightPont(this.cidade);


            this.progNome = progNome;
            this.progNome = fixRightPont(this.progNome);
            this.progTelefone = progTelefone;
            this.progTelefone = fixRightPont(this.progTelefone);
        }


        private string fixEmpresa(string empresa)
        {
            empresa = " " + empresa + " ";
            char[] c = new char[41];
            c[0] = ' '; c[40] = ' ';
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
        private string fixCenterPont(string vari)
        {
            vari = " " + vari + " ";
            char[] c = new char[42];
            c[0] = '|'; c[41] = '|';
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
        private string fixCenter(string vari)
        {
            vari = " " + vari + " ";
            char[] c = new char[42];
            c[0] = '|'; c[41] = '|';
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
        public string fixRightPont(string vari)
        {
            vari = " " + vari + " ";
            char[] c = new char[42];
            c[0] = '|'; c[41] = '|';
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
    }
}
