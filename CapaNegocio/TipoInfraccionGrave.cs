using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TipoInfraccionGrave : TipoInfraccion
    {
        private int descuento_veinticinco_dias;

        public TipoInfraccionGrave(int idTipo, string descripcion, float importe) : base(idTipo, descripcion, importe)
        {
            this.descuento_veinticinco_dias = 20;
        }

        public override bool sosGrave()
        {
            return true;
        }

        public override float calcularImporte(string fechaVenc)
        {
            float subtotal = 0;
            DateTime fechaVencimiento = DateTime.ParseExact(fechaVenc, "M/d/yyyy h:mm:ss tt", null);
            DateTime hoy = DateTime.Today;

            if ((fechaVencimiento - hoy).Days >= 25)
            {
                int aux = 100 - descuento_veinticinco_dias;
                subtotal += Importe * aux / 100;
            }
            else
            {
                subtotal += Importe;
            }

            return subtotal;
        }
      
    }
}
