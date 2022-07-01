using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace UIWeb
{
    public partial class Inicio : System.Web.UI.Page
    {
        Administradora admin;
        //string lugarBase;//solo para usar Access u otra base que no corra en el Servidor SQL
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                admin = new Administradora();
                Session["administra"] = admin;
                recuperarAdmin();
                //lugarBase = Server.MapPath; //solo para usar Access u otra base que no corra en el Servidor SQL
            }
        }
        public void recuperarAdmin()
        {
            admin = (Administradora)Session["administra"];
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdmin.aspx");
            recuperarAdmin();
        }

        public void refrescarLista()
        {

            //if(ListBox1.Items.Count>0)
            ListBox1.Items.Clear();// Saco todo para que no se repitan
            recuperarAdmin();
            //List<Persona> l= admin.darLista();
            //for(int i=0;i<l.Count; i++)
            //ListBox1.Items.Add(l[i].ToString());

        }

        protected void Button3_Click(object sender, EventArgs e)// Salir
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("http:\\www.unimoron.edu.ar");
           
        }
        
        protected void Button1_Click(object sender, EventArgs e)//Crear
        {
            recuperarAdmin();        
            //Persona per = null;
            try
            {
                int d = int.Parse(TextBox1.Text.Trim());
                string n = TextBox2.Text.Trim();
                //per = new Persona(d, n);
                /*if (admin.ponerPersona(per))
                {
                    refrescarLista();
                    TextBox1.Text = string.Empty;
                    TextBox2.Text = string.Empty;
                    Label1.Text = string.Empty;
                }*/
                //else
                  //  Label1.Text = "Error al crear la persona. Verifique que el numero de DNI no esté repetido. ";
            }
            catch (Exception ex)
            {
              Label1.Text="Error al crear la persona: " + ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)//Eliminar Persona
        {
            recuperarAdmin();
            if (ListBox1.SelectedItem != null)
            {
                string textoPersona = ListBox1.SelectedValue;
                int lugarGuion = textoPersona.IndexOf("-");
                int dni = int.Parse(textoPersona.Substring(0, lugarGuion-1));
                //admin.eliminarPersona(dni);
                ListBox1.ClearSelection();
                Label1.Text = "Baja Realizada";
                Response.Redirect("Inicio.aspx");
            }
            
        }

        /*protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaPersona.aspx");
            refrescarLista();
        }*/
    }
}