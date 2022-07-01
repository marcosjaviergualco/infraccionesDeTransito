using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CapaDatos;

namespace RN
{
    public class Administradora
    {
        private List<Persona> lista;
        public Administradora()
        {
            lista = new List<Persona>();
            recuperarPersonas();
        }
        public bool  ponerPersona(Persona per)// Pone en la lista y Guarda en la Base de Datos
        {
            bool todoBien = false;        
            if (per != null)
            {
               
                todoBien= Datos.GuardarPersona(per.pasarseARelacional());
                if(todoBien)
                    this.lista.Add(per);
            }
                return todoBien;
        }
       
        public List<Persona> darLista()
        {
            return this.lista;
        }
        public void recuperarPersonas()
        {
            Persona per = null;
            int dni;
            string nombre;
            ArrayList datosTodas = Datos.RecuperarPersonas();
           for (int i=0;i<=datosTodas.Count-2;i=i+2)
            {
                dni = int.Parse(datosTodas[i].ToString());
                nombre = datosTodas[i+1].ToString();
                per = new Persona(dni, nombre);
                lista.Add(per);
            }
        }
        public void eliminarPersona(Persona per)
        {
            lista.Remove(per);
            Datos.EliminarPersona(per.Dni);

        }
        public void eliminarPersona(int dni)
        {
              Datos.EliminarPersona(dni);

        }
       
     
    }
}
