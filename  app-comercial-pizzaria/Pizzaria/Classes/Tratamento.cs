using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Classes
{

    using Pizzaria.Banco;
    public class Tratamento
    {
        public string[] ordenaBolha(string[] mesa)
        {
            int[] x = new int[mesa.Length];
            x = new Banco().cod_mesa(mesa);// aqui eu tenho o vetor de codigo
            for (int i = 0; i < mesa.Length; i++)
                for (int j = 0; j < mesa.Length; j++)
                    if (x[i] < x[j])
                    {
                        int temp = x[i]; x[i] = x[j]; x[j] = temp;
                    }
            //vetor está organizado.
            for (int i = 0; i < mesa.Length; i++)
                mesa[i] = new Banco().mesaNomeByCodigo(x[i]);
            return mesa;
        }
        public string retornaValorEscrito(double valor)
        {
            decimal d = Convert.ToDecimal(valor);
            double b = ((int)d) % 1;


            if (d % 1 == 0)
                return d + ",00";


            char[] ttt = valor.ToString().Replace('.', ',').ToCharArray();
            if (ttt[ttt.Length - 2] != ',')
                return valor.ToString().Replace('.', ',');
            return valor.ToString().Replace('.', ',') + "0";
            //return null;
        }
        public string retornaValorEscritoCo(double valor)
        {
            decimal d = Convert.ToDecimal(valor);
            double b = ((int)d) % 1;


            if (d % 1 == 0)
                if(d<10)
                return " "+d + ",00";
                else 
                return d + ",00";

            char[] ttt = valor.ToString().Replace('.', ',').ToCharArray();
            if (ttt[ttt.Length - 2] != ',')
                if (d < 10)
                return " "+valor.ToString().Replace('.', ',');
                else return valor.ToString().Replace('.', ','); 
            if (d<10)
            return " "+valor.ToString().Replace('.', ',') + "0";
            else return valor.ToString().Replace('.', ',') + "0";
            //return null;
        }

        public double stringToDouble(string valor)
        {

            double val = Convert.ToDouble(valor.Replace('.', ','));
            return val;
        }

    }
}
