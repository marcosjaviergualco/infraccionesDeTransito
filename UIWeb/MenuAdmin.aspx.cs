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
        protected void Page_Load(object sender, EventArgs e)
        {
            recuperarAdmin();
        }
        public void recuperarAdmin()
        {
            Administradora adm = (Administradora)Session["administra"];
        }

        protected void ButtonAgregarTipoInfraccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarTipoInfraccion.aspx");
        }
    }
}