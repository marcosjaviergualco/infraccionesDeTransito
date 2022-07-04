using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class RegistroInfraccion
    {
        private string codigo;
        private TipoInfraccion tipoInfraccion;
        private string descripcion;
        private string fecha_de_registro;
        private DateTime fecha_de_suceso;
        private string fecha_de_vencimiento;
        private string dominio;

        public RegistroInfraccion(string unCodigo, string unDominio, string unaDescripcion, TipoInfraccion unTipo, DateTime fecha_de_suceso, string fecha_de_registro)
        {
            this.codigo = unCodigo;
            this.dominio = unDominio;
            this.tipoInfraccion = unTipo;
            this.descripcion = unaDescripcion;
            this.fecha_de_suceso = fecha_de_suceso;
            this.fecha_de_registro = fecha_de_registro;
            int diasDelMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            this.fecha_de_vencimiento = fecha_de_suceso.AddDays(diasDelMes).ToString();

        }

        public override string ToString()
        {
            return "Dominio: " + this.dominio + "Descripción: " + this.descripcion + "Tipo de infracción: " + this.tipoInfraccion;
        }

        public string Dominio
        {
            get { return dominio; }
        }

        public TipoInfraccion TipoInfraccion
        {
            get { return tipoInfraccion; }
        }

        public float darImporte()
        {
            float subtotal = 0;

            subtotal = tipoInfraccion.calcularImporte(fecha_de_vencimiento);

            return subtotal;
        }

    }
}
