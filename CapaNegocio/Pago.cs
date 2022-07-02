using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pago
    {
        private int codigo;
        private List<RegistroInfraccion> Infracciones_a_pagar;
        private float monto_total;


        public Pago(int codigo, float monto_total)
        {
            this.codigo = codigo;
            this.monto_total = monto_total;
        }




    }
}
