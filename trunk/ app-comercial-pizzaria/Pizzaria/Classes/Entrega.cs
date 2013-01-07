using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Classes
{
    public class Entrega
    {
        public int cod_completo;
        private List<GarconFisico> garcons;

        public Entrega(int codigoItem)
        {
            this.cod_completo = codigoItem;
            garcons = new List<GarconFisico>();
        }
        public void addGarcon(GarconFisico garcon){
            garcons.Add(garcon);
        }
        public GarconFisico[] getGarcons()
        {
            return garcons.ToArray();
        }
    }
}
