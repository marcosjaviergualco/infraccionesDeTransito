using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using CapaNegocio;

namespace UIWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Administradora admin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                admin = new Administradora();
                Session["administra"] = admin;
                
                ddTipoInfraccion.DataSource = admin.TiposInfraccion;
                ddTipoInfraccion.DataBind();

            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdmin.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            RegistroInfraccion ri;
            admin = new Administradora();
            string codigo = txtCodigo.Text;
            string dominio = txtDominio.Text;
            TipoInfraccion tipoInfraccion = Administradora.buscarTipoInfraccionPorDesc(ddTipoInfraccion.SelectedValue);
            string descripcion = txtDescripcion.Text;
            string fechaRegistro = cFechaRegistracion.SelectedDate.ToString();
            DateTime fechaSuceso = cFechaSuceso.SelectedDate;

            if (codigo == "" || dominio == "" || descripcion == "")
            {
                Manejo_error.Text = "SE REQUIEREN COMPLETAR TODOS LOS CAMPOS.";
            }
            else
            {
                ri = new RegistroInfraccion(codigo, dominio, descripcion, tipoInfraccion, fechaSuceso, fechaRegistro);
                bool statusInsercion = admin.insertar(ri);
                Response.Redirect("MenuAdmin.aspx");
            }

        }
    }
}