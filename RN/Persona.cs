using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RN
{
    public class Persona
    {
        private int dni;
        private string nombre;
            public Persona(int d,string n)
        {
            this.dni = d;
            this.nombre = n;
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public ArrayList pasarseARelacional()
        {
            ArrayList datos = new ArrayList();
            datos.Add(this.dni);
            datos.Add(this.nombre);
            return datos;
        }
        public static Persona GenerarPersona(ArrayList datos)
        {
            Persona per = null;
            if(datos!=null && datos.Count == 2)
            {
                int dni = int.Parse(datos[0].ToString());
                string nombre = datos[1].ToString();
                per = new Persona(dni, nombre);
            }
            return per;
        }
        public override string ToString()
        {
            return this.Dni.ToString()+ " - " + this.Nombre;
        }

    }
}
