using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


//using System.Data;
//using System.Drawing;
using System.Windows.Forms;

namespace Pizzaria.Banco
{
   
    public class BancoSenha
    {
            string senha= "!tn13si!";
            string database = "Titan";
            string porta = "5432";

            public void endereco(){
                
                
                StreamReader sr;
                try
                {
                   
                    sr = File.OpenText(Environment.CurrentDirectory + "\\StringConexao.txt");

                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                    {
                        conexao = input;
                    }
                    if (conexao.Length == 0)
                    {
                        porta = "5433";
                        senha = "fof0130407*";
                        conexao = "server=Localhost; Port=" + porta + ";User =postgres;Password=" + senha + ";Database=" + database;
                    }
                }
                catch
                {
                    porta = "5433";
                      senha = "fof0130407*";
                      conexao  = "server=Localhost; Port="+porta+";User =postgres;Password="+senha+";Database="+database;
                }
             
            }
            
            public BancoSenha()
            {
                endereco();

            //    porta = "5433";
             //   senha = "fof0130407*";
              //  conexao  = "server=Localhost; Port="+porta+";User =postgres;Password="+senha+";Database="+database;
            }
            public string conexao;
    }
}
