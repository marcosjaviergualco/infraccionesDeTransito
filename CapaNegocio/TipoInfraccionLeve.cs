using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TipoInfraccionLeve : TipoInfraccion
    {
        private int descuento_veinte_dias;
        private int descuento_diez_dias;
        public TipoInfraccionLeve(int idTipo, string descripcion, float importe) : base(idTipo, descripcion, importe)
        {
            this.descuento_veinte_dias = 25;
            this.descuento_diez_dias = 15;
        }

        public override float calcularImporte(string fechaVenc)
        {
            float subtotal = 0;
            DateTime fechaVencimiento = DateTime.ParseExact(fechaVenc, "d/M/yyyy HH:mm:ss", null);
            DateTime hoy = DateTime.Today;

            if ((fechaVencimiento-hoy).Days >= 20) // 20 dias antes (inclusive) o mas
            {
                int aux = 100 - descuento_veinte_dias;
                subtotal += Importe * aux / 100;
            }
            else
            {
                if ((fechaVencimiento - hoy).Days >= 10)
                {
                    int aux = 100 - descuento_diez_dias;
                    subtotal += Importe * aux / 100;
                }
                else
                {
                    subtotal += Importe;
                }
            }

            return subtotal;
        }
    }
}
