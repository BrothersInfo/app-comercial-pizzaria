using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Pizzaria.Classes
{
    public class VendaHalf
    {
        public int cod_venda;
        public int cod_caixa;
        public double valorTotal;
        public string horario;
        public string dia;
        public string[] mesa;
        public ArrayList produto = new ArrayList();
        public Completa[] Completos;
        public int qtdItens;
        public bool comanda = false;


        public VendaHalf(int cod_venda, int cod_caixa, double valorTotal,
            string horario, string dia, string[] mesas)
        {
            try
            {

                this.cod_venda = cod_venda;
                this.cod_caixa = cod_caixa;
                this.valorTotal = valorTotal;
                this.horario = horario;
                this.dia = dia;
                this.mesa = mesas;

            }
            catch { }
        }

        public void setCompleta(Completa[] conjunto)
        {
            Completos = conjunto;
            produto.AddRange(conjunto);
            for (int i = 0; i < conjunto.Length; i++)
                this.valorTotal += (conjunto[i].valorUnitario * conjunto[i].quantidade);


        }
        public void corrigirValor()
        {

            valorTotal = 0;
            for (int i = 0; !Completos.Equals(null) && i < Completos.Length; i++)
                valorTotal += (Completos[i].valorUnitario * Completos[i].quantidade);

        }
    }
}
