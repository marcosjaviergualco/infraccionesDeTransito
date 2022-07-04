using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CapaDatos;

namespace CapaNegocio
{
    public abstract class TipoInfraccion
    {
        private int idTipo;
        private string descripcion;
        private float importe;

        //tipo detalle identifica : Semaforo en rojo, Borracho etc.
        //idTipo : categoriza su gravedad. 

        public TipoInfraccion(int idTipo, string descripcion, float importe)
        {
            this.idTipo = idTipo;
            this.descripcion = descripcion;
            this.importe = importe;
        }

        public virtual bool sosGrave()
        {
            return false;
        }

        public int IdTipo
        {
            get { return idTipo; }
            set { idTipo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public override string ToString()
        {
            return idTipo + " " + descripcion + " " + importe;
        }

    }
}
