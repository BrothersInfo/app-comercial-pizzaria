using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Classes
{
    public class GarconFisico
    {
        public int cod_garcon;
        public string nome;
        public int quantidade;
        public void setGarcon(int cod_garcon, int quantidade)
        {
            this.cod_garcon = cod_garcon;
            this.quantidade = quantidade;
            nome = new Banco.BancoVenda().nomeGarcon(cod_garcon);
        }

    }
}
