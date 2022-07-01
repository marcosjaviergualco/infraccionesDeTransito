using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Vehiculo
    {
        private int patente;
        private int titular_dni;
        private List<RegistroInfraccion> infracciones_a_pagar;


        public Vehiculo(int patente, int titular_dni)
        {
            this.patente = patente;
            this.titular_dni = titular_dni;

        }







    }
}
