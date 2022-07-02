using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CapaDatos
{
    public class Datos
    {
        //Para Access 2000-2003
        private static string LugarBase;
        private static string Str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\fl\\Documents\\GitHub\\infraccionesDeTransito\\UI\\bin\\Debug\\persistencia\\infracciones.mdb";
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\Persistencia\basePersonas.mdb
        private static OleDbConnection Con;
        private static OleDbCommand Cmd;
        private static OleDbDataAdapter Da;
        //Para todos
        private static DataSet Ds;
        public static void PonerPathBaseAccess(string l)
        {
            LugarBase = l + @"\Persistencia\infracciones.mdb";
            // Datos.Str += LugarBase;
        }

        public static ArrayList RecuperarTiposDeInfraccion()
        {
            ArrayList datos = new ArrayList();
            try
            {
                string strCmd = "SELECT * FROM TipoInfraccion ORDER BY idTipo";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());

                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;
        }

        public static bool insertarTipoInfraccion(ArrayList datos, bool graveOleve)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 3)
            {
                try
                {
                    int idTipo = int.Parse(datos[0].ToString());
                    string descripcion = datos[1].ToString();
                    float importe = float.Parse(datos[2].ToString());
                    string categoria = "";
                    if (graveOleve)
                        categoria = "G";
                    else
                        categoria = "L";
                    string strCmd = "INSERT INTO TipoInfraccion(idTipo,descripcion,importe,categoria) " +
                        "VALUES (" + idTipo + ",'" + descripcion + "'," + importe + ",'" + categoria + "')";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;
        }

        public static bool eliminarTipoInfraccion(int idTipo )
        {
            bool estado = false;
            try
            {
                string strCmd = "DELETE FROM TipoInfraccion WHERE idTipo=" + idTipo + ";";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();
                estado = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

            return estado;
        }



    }
}
