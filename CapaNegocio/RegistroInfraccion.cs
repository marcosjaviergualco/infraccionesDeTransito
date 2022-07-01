using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class RegistroInfraccion
    {

        private Vehiculo vehiculo;
        private TipoInfraccion tipoInfraccion;
        private DateTime fecha_de_suceso;
        private DateTime fecha_de_vencimiento;

        public RegistroInfraccion(Vehiculo unVehiculo, TipoInfraccion unTipo, DateTime fecha_de_suceso)
        {
            this.vehiculo = unVehiculo;
            this.tipoInfraccion = unTipo;
            this.fecha_de_suceso = fecha_de_suceso;
            // this.fecha_de_vencimiento = fecha_de_suceso + 30; *ver*
        }





    }
}
