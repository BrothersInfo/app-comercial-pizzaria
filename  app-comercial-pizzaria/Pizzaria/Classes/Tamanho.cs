using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Classes
{
    using Pizzaria.Banco;
 

    public class Tamanho
    {
        public int cod_tamanho2;
        public string nome2;
        public double valor;
        public double compra;
        public void setCodigo(string nome)
        {
            

            this.nome2 = nome;
            cod_tamanho2 = new Banco().codTamanho(nome);
        }
    }
}
