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

        public RegistroInfraccion(string unCodigo, string unDominio, string unaDescripcion, TipoInfraccion unTipo, DateTime unaFecha_de_suceso, string fecha_de_registro)
        {
            this.codigo = unCodigo;
            this.dominio = unDominio;
            this.tipoInfraccion = unTipo;
            this.descripcion = unaDescripcion;
            this.fecha_de_suceso = unaFecha_de_suceso;
            this.fecha_de_registro = fecha_de_registro;
            int diasDelMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            this.fecha_de_vencimiento = this.fecha_de_suceso.AddDays(diasDelMes).ToString();
            
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Dominio
        {
            get { return dominio; }
            set { dominio = value; }
        }

        public TipoInfraccion TipoInfraccion
        {
            get { return tipoInfraccion; }
            set { tipoInfraccion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime Fecha_de_suceso
        {
            get { return fecha_de_suceso; }
            set { fecha_de_suceso = value; }
        }

        public string Fecha_de_registro
        {
            get { return fecha_de_registro; }
            set { fecha_de_registro = value; }
        }

        public string Fecha_de_vencimiento
        {
            get { return fecha_de_vencimiento; }
            set { fecha_de_vencimiento = value; }
        }

        public float darImporte()
        {
            float subtotal = 0;

            subtotal = tipoInfraccion.calcularImporte(fecha_de_vencimiento);

            return subtotal;
        }

        public override string ToString()
        {
            return "Dominio: " + this.dominio + "Descripción: " + this.descripcion + "Tipo de infracción: " + this.tipoInfraccion;
        }


    }
}
