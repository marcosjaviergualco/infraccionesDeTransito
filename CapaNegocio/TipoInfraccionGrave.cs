using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TipoInfraccionGrave : TipoInfraccion
    {
        private int descuento_veinticinco_dias;

        public TipoInfraccionGrave(int idTipo, string descripcion, float importe) : base(idTipo, descripcion, importe)
        {
            this.descuento_veinticinco_dias = 20;
        }

        public override bool sosGrave()
        {
            return true;
        }

    }
}
