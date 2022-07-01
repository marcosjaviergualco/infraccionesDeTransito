using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tarjeta
    {
        private int num_tarjeta;
        private string nombre_titular;
        private int cod_seguridad;
        private DateTime fecha_vencimiento;
        private string email;
        public Tarjeta(int num_tarjeta, string nombre_titular, int cod_seguridad, DateTime fecha_vencimiento, string email)
        {
            this.num_tarjeta = num_tarjeta;
            this.nombre_titular = nombre_titular;
            this.cod_seguridad = cod_seguridad;
            this.fecha_vencimiento = fecha_vencimiento;
            this.email = email;
        }


    }
}
