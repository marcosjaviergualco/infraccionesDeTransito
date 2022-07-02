using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using CapaNegocio;

namespace UIWeb
{
    public partial class AgregarTipoInfraccion : System.Web.UI.Page
    {
        Administradora adm;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void recuperarAdmin()
        {
            adm = (Administradora)Session["administra"];
        }

        

        protected void ButtonAgregar_Click1(object sender, EventArgs e)
        {
            recuperarAdmin();
            TipoInfraccion ti = null;
            try
            {
                int id = int.Parse(TextBoxIdTipo.Text.Trim());
                string descripcion = TextBoxDescripcion.Text.ToString();
                float importe = float.Parse(TextBoxImporte.Text.Trim());
                if (RadioButtonGrave.Checked)
                    ti = new TipoInfraccionGrave(id, descripcion, importe);
                else
                    ti = new TipoInfraccionLeve(id, descripcion, importe);

                if (adm.agregar(ti))
                    Response.Redirect("MenuAdmin.aspx");
                else
                    LabelError.Text = "Error al crear el tipo de infraccion";


            }
            catch (Exception ex)
            {
                LabelError.Text = "Error al crear el tipo de infraccion: " + ex.Message;
            }
        }

        protected void ButtonCancelar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdmin.aspx");
        }
    }
}