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


    }
}
