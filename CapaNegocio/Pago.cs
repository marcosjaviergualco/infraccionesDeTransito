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
        private string fechaPago;
        private float monto_total;


        public Pago(int codigo, List<RegistroInfraccion> lista, float monto_total, string fechaPago)
        {
            this.codigo = codigo;
            this.Infracciones_a_pagar = lista;
            this.monto_total = monto_total;
            this.fechaPago = fechaPago;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public List<RegistroInfraccion> Infracciones
        {
            get { return Infracciones_a_pagar; }
        }

        public float MontoTotal
        {
            get { return monto_total; }
        }

        public string FechaPago
        {
            get { return fechaPago; }
        }

    }
}
