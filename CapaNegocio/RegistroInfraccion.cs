using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class RegistroInfraccion
    {
        private TipoInfraccion tipoInfraccion;
        private DateTime fecha_de_suceso;
        private DateTime fecha_de_vencimiento;
        private string dominio;

        public RegistroInfraccion(string unDominio, TipoInfraccion unTipo, DateTime fecha_de_suceso)
        {
            this.dominio = unDominio;
            this.tipoInfraccion = unTipo;
            this.fecha_de_suceso = fecha_de_suceso;
            // this.fecha_de_vencimiento = fecha_de_suceso + 30; *ver*
        }





    }
}
