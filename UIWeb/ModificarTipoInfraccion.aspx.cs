using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace UIWeb
{
    public partial class ModificarTipoInfraccion : System.Web.UI.Page
    {
        Administradora adm;
        TipoInfraccion ti;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                recuperarAdmin();
                int idTipo = int.Parse(TextBoxCodigo.Text);
                string desc = TextBoxDescripcion.Text.ToString();
                float imp = float.Parse(TextBoxImporte.Text.ToString());

                TipoInfraccion tiModificado;

                if (RadioButtonGrave.Checked)
                    tiModificado = new TipoInfraccionGrave(idTipo, desc, imp);
                else
                    tiModificado = new TipoInfraccionLeve(idTipo, desc, imp);

                if (adm.modificar(ti, tiModificado))
                    Label9.Text = "ACTUALIZACION REALIZADA CON EXITO!!!!!";
                else
                    Label9.Text = "hubo un error";
            }
            else
            {
                recuperarAdmin();
                TextBoxCodigo.Text = ti.IdTipo.ToString();
                TextBoxDescripcion.Text = ti.Descripcion.ToString();
                TextBoxImporte.Text = ti.Importe.ToString();

                if (ti.sosGrave())
                    RadioButtonGrave.Checked = true;
                else
                    RadioButtonLeve.Checked = true;
            }
            

        }
        public void recuperarAdmin()
        {
            adm = (Administradora)Session["administra"];
            ti = (TipoInfraccion)Session["tipoInfraccion"];
        }

        // agregar excepciones!!!!!!!!
        // ver modificar categoria
        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarTipoInfraccion.aspx");
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdmin.aspx");
        }
    }
}