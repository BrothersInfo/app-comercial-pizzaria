using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Banco
{
   
    public class BancoSenha
    {
            string senha= "!tn13si!";
            string database = "Titan";
            string porta = "5432";
            
            public BancoSenha()
            {
              //  porta = "5433";
              //  senha = "fof0130407*";
                conexao  = "server=Localhost; Port="+porta+";User =postgres;Password="+senha+";Database="+database;
            }
            public string conexao;
    }
}
