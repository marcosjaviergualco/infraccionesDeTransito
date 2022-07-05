using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CapaDatos;

namespace CapaNegocio
{
    public class Administradora
    {
        private List<TipoInfraccion> tiposInfraccion;
        private List<RegistroInfraccion> infracciones;
        private List<Pago> pagos;

        public Administradora()
        {
            tiposInfraccion = new List<TipoInfraccion>();
            infracciones = new List<RegistroInfraccion>();
            pagos = new List<Pago>();

            recuperarTodo();
        }

        public void recuperarTodo()
        {
            recuperarTiposInfraccion();
            recuperarInfracciones();
            recuperarPagos();
        }

        public void recuperarInfracciones()
        {
            string codigo, desc, fechaRegistro, fechaDeVencimiento, dominio, condicion;
            DateTime fechaSuceso;
            int idTipo;
            ArrayList datosRegistros = Datos.recuperarInfracciones();
            RegistroInfraccion ri;

            for (int a = 0; a < datosRegistros.Count; a = a + 8)
            {
                codigo = datosRegistros[a].ToString();
                idTipo = int.Parse(datosRegistros[a + 1].ToString());
                desc = datosRegistros[a + 2].ToString();
                fechaRegistro = datosRegistros[a + 3].ToString();
                fechaSuceso = DateTime.ParseExact(datosRegistros[a + 4].ToString(), "d/M/yyyy HH:mm:ss", null);
                fechaDeVencimiento = datosRegistros[a + 5].ToString();
                dominio = datosRegistros[a + 6].ToString();
                condicion = datosRegistros[a + 7].ToString();

                ri = new RegistroInfraccion(codigo, dominio, desc, buscarTipoInfraccion(idTipo), fechaSuceso, fechaRegistro, condicion);

                infracciones.Add(ri);
            }

        }

        public void recuperarTiposInfraccion()
        {
            int unIdTipo;
            string unaDesc;
            float unImporte;
            ArrayList datosTodosTipos = Datos.RecuperarTiposDeInfraccion();

            TipoInfraccion ti;
            for (int a = 0; a < datosTodosTipos.Count; a = a + 4)
            {
                unIdTipo = int.Parse(datosTodosTipos[a].ToString());
                unaDesc = datosTodosTipos[a + 1].ToString();
                unImporte = float.Parse(datosTodosTipos[a + 2].ToString());

                if (datosTodosTipos[a + 3].ToString() == "G")
                    ti = new TipoInfraccionGrave(unIdTipo, unaDesc, unImporte);
                else
                    ti = new TipoInfraccionLeve(unIdTipo, unaDesc, unImporte);

                tiposInfraccion.Add(ti);
            }
        }

        public void recuperarPagos()
        {
            int unCodigo;
            string unaFechaPago;
            float unMontoTotal;
            List<RegistroInfraccion> unaListaInfracciones;
            ArrayList datosPagos = Datos.RecuperarPagos();
            Pago p;
            for (int a = 0; a < datosPagos.Count; a = a + 3)
            {
                unCodigo = int.Parse(datosPagos[a].ToString());
                unaFechaPago = datosPagos[a + 1].ToString();
                unMontoTotal = float.Parse(datosPagos[a + 2].ToString());

                unaListaInfracciones = recuperarPago_RegistroInfraccion(unCodigo);

                p = new Pago(unCodigo, unaListaInfracciones, unMontoTotal, unaFechaPago);
                pagos.Add(p);
            }
        }

        public List<RegistroInfraccion> recuperarPago_RegistroInfraccion(int unCodigo)
        {
            ArrayList datos = Datos.RecuperarPago_RegistroInfraccion(unCodigo);

            List<RegistroInfraccion> lista = new List<RegistroInfraccion>();

            for (int i=0; i<datos.Count; i++) {
                lista.Add(buscarInfraccion(datos[i].ToString()));
            }

            return lista;
        }

        public RegistroInfraccion buscarInfraccion(string unCodInfraccion)
        {
            RegistroInfraccion ri = null;
            int i = 0;

            while (unCodInfraccion != infracciones[i].Codigo && i < infracciones.Count)
            {
                i++;
            }

            ri = infracciones[i];

            return ri;
        }

        public TipoInfraccion buscarTipoInfraccion(int indice)
        {
            //ArrayList datosTipoInfraccion = Datos.RecuperarTipoDeInfraccion(indice);
            //TipoInfraccion ti = new TipoInfraccionLeve(12, "  ", 123);

            TipoInfraccion ti = null;
            int i = 0;

            while (indice != tiposInfraccion[i].IdTipo && i < tiposInfraccion.Count)
            {
                i++;
            }

            ti = tiposInfraccion[i];

            return ti;
        }

        public static TipoInfraccion buscarTipoInfraccionPorDesc(string descripcion)
        {
            TipoInfraccion ti;
            int position = descripcion.IndexOf(" ");
            string desc = descripcion.Substring(0, position);
            ArrayList datosTipoInfraccion = Datos.RecuperarTipoDeInfraccion(desc);

            if(datosTipoInfraccion[3].ToString() == "L")
            {
                ti = new TipoInfraccionLeve(int.Parse(datosTipoInfraccion[0].ToString()), datosTipoInfraccion[1].ToString(), float.Parse(datosTipoInfraccion[2].ToString()));
            }
            else
            {
                ti = new TipoInfraccionGrave(int.Parse(datosTipoInfraccion[0].ToString()), datosTipoInfraccion[1].ToString(), float.Parse(datosTipoInfraccion[2].ToString()));
            }

            return ti;
        }

        public bool agregar(TipoInfraccion ti)
        {
            bool status = Datos.insertarTipoInfraccion(pasarTipoARelacional(ti), ti.sosGrave());
            tiposInfraccion.Add(ti);

            return status;
        }

        public ArrayList pasarTipoARelacional(TipoInfraccion ti)
        {
            ArrayList datos = new ArrayList();
            datos.Add(ti.IdTipo);
            datos.Add(ti.Descripcion);
            datos.Add(ti.Importe);

            return datos;
        }

        public ArrayList pasarRegistroInfraccionARelacional(RegistroInfraccion ri)
        {
            ArrayList datos = new ArrayList();
            datos.Add(ri.Codigo);
            datos.Add(ri.TipoInfraccion.IdTipo);
            datos.Add(ri.Descripcion);
            datos.Add(ri.Fecha_de_registro);
            datos.Add(ri.Fecha_de_suceso.ToString());
            datos.Add(ri.Fecha_de_vencimiento);
            datos.Add(ri.Dominio);
            datos.Add(ri.Condicion);
            
            return datos;
        }

        public ArrayList pasarPagoARelacional(Pago p)
        {
            ArrayList datos = new ArrayList();
            datos.Add(p.Codigo);
            datos.Add(p.Infracciones);
            datos.Add(p.MontoTotal);
            datos.Add(p.FechaPago);

            return datos;
        }

        public bool insertar(RegistroInfraccion ri)
        {
            bool insercionOK = Datos.insertarRegistroInfraccion(pasarRegistroInfraccionARelacional(ri));
            if (insercionOK)
            {
                this.infracciones = new List<RegistroInfraccion>();
                this.recuperarInfracciones();
            }
            return insercionOK;
        }

        public bool insertar(Pago p)
        {
            bool insercionOK;
            insercionOK = Datos.insertarPago(pasarPagoARelacional(p));
            ArrayList inf = new ArrayList();
            foreach (RegistroInfraccion item in p.Infracciones)
            {
                inf.Add(item.Codigo);
            }
            insercionOK = Datos.insertarPago_Registro(inf, p.Codigo);

            this.pagos.Add(p);

            return insercionOK;
        }

        

        public List<TipoInfraccion> TiposInfraccion
        {
            get { return tiposInfraccion; }
        }

        public TipoInfraccion darTipoInfraccion(int indice)
        {
            return tiposInfraccion[indice];
        }

        public bool modificar(TipoInfraccion ti, TipoInfraccion tiModificado)
        {
            bool todoBien = false;

            if (tiModificado != null)
            {
                todoBien = Datos.eliminarTipoInfraccion(ti.IdTipo);
                todoBien = Datos.insertarTipoInfraccion(pasarTipoARelacional(tiModificado), tiModificado.sosGrave());

                //tiposInfraccion.Remove(ti);
                //tiposInfraccion.Add(tiModificado);
            }

            if (todoBien)
            {
                this.tiposInfraccion = new List<TipoInfraccion>();
                this.recuperarTiposInfraccion();
            }
                

            return todoBien;
        }

        public List<RegistroInfraccion> buscarInfracciones(string unDominio)
        {
            List<RegistroInfraccion> lista = new List<RegistroInfraccion>();
            for (int i = 0; i < infracciones.Count; i++)
            {
                if (infracciones[i].Dominio == unDominio)
                    lista.Add(infracciones[i]);
            }

            return lista;
        }

        public List<RegistroInfraccion> buscarInfraccionesImpagas(string unDominio)
        {
            List<RegistroInfraccion> lista = new List<RegistroInfraccion>();
            for (int i = 0; i < infracciones.Count; i++)
            {
                if (infracciones[i].Dominio == unDominio && infracciones[i].Condicion=="I")
                    lista.Add(infracciones[i]);
            }

            return lista;
        }

        public List<RegistroInfraccion> buscarInfraccionesPagas(string unDominio)
        {
            List<RegistroInfraccion> lista = new List<RegistroInfraccion>();
            for (int i = 0; i < infracciones.Count; i++)
            {
                if (infracciones[i].Dominio == unDominio && infracciones[i].Condicion == "P")
                    lista.Add(infracciones[i]);
            }

            return lista;
        }

        public List<Pago> Pagos
        {
            get { return pagos; }
        }

        public bool actualizarRegistroInfraccion(string cod)
        {
            bool todoOk = Datos.actualizarRegistroInfraccion(cod);

            return todoOk;
        }

        /* 
         SOLUCION : 2 INTERFACES 
            1- ADMINISTRADOR (objetivo registrar,y ver infracciones)
            2- TITULAR (objetivo ver infracciones, y pagar)
         
       
         1- 
            A) INTERFAZ 1
            En base a una matricula ingresada por el usuario, buscar si se encuentra en la lista "infracciones_a_pagar"
            Si esta -> le lista las infracciones a pagar (INTERFAZ 2)
            Si no esta -> cartel "no tiene infracciones a pagar" (no debe nada)
            
            B) INTERFAZ 2
            El usuario ve la lista a detalle de infracciones a pagar y puede escoger 1 o mas para efectuar el pago. 
            Selecciona pagar (INTERFAZ 3)

            **Ver si en tiempo real se puede ir calculando el monto total**
            

            C) INTERFAZ 3
            El usuario ingresa datos de tarjeta (como el pago de cuotas de la facu). Selecciona pagar. (INTERFAZ 4)

            **Ver manejo de errores en ingreso de datos**

            D) INTERFAZ 4
            Cartel pago exitoso/no exitoso.
            
       
        2-
            A) INTERFAZ 1
            Acciones:
                -Ver infracciones a pagar. (INTERFAZ 2)
                -Ver infracciones pagadas. (INTERFAZ 3)
                -Registrar una infraccion. (INTERFAZ 4)
                -Agregar un tipo de infraccion o modificar el descuento del tipo de infraccion (INTERFAZ 5)
                ****EXTRA**** -Buscar por vehiculo si tiene alguna infraccion o si pago alguna infraccion.
            
            B) INTERFAZ 2
                Listar infracciones a pagar
            
            C) INTERFAZ 3
                Listar infracciones pagadas.

            D) INTERFAZ 4
            
            Se listan los tipos de infraciones 
            El usario selecciona 1 tipo de infraccion e ingresa num matricula , num de dni , fecha de suceso.
            Se genera la infraccion.
            Se añade a lista de infracciones a pagar.

            E)
            Se listan los tipos de infraciones.
            Se selecciona 1 para modificar. (Solo se puede modificar el descuento por default ) Si quiere cambiar de gravedad, que lo elimine y lo vuelva a crear.
            o 
            Se agrega uno nuevo. 
            MANEJAR BORRACHO - ID 09 - SELECCIONA LEVE O GRAVE.
           

         */




    }
}
