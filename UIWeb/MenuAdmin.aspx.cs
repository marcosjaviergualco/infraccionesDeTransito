using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace UIWeb
{
    public partial class MenuAdmin : System.Web.UI.Page
    {
        Administradora admin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                admin = new Administradora();
                Session["administra"] = admin;
                recuperarAdmin();
                //lugarBase = Server.MapPath; //solo para usar Access u otra base que no corra en el Servidor SQL

                ListBoxTipoInfraccion.DataSource = admin.TiposInfraccion;
                ListBoxTipoInfraccion.DataBind();
                
            }
        }
        public void recuperarAdmin()
        {
            admin = (Administradora)Session["administra"];
        }

        protected void ButtonAgregarTipoInfraccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarTipoInfraccion.aspx");
        }

        protected void ButtonModificarTipoInfraccion_Click(object sender, EventArgs e)
        {
            admin = (Administradora)Session["administra"];
            if (ListBoxTipoInfraccion.SelectedItem.Value != null)
            {
                TipoInfraccion ti = admin.darTipoInfraccion(ListBoxTipoInfraccion.SelectedIndex);
                Session["tipoInfraccion"] = ti;
                Response.Redirect("ModificarTipoInfraccion.aspx");
            }
        }
    }
}