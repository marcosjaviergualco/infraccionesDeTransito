using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.IO;

namespace UIWeb
{
    public partial class ConsultarInfracciones : System.Web.UI.Page
    {
        Administradora admin;
        string unDominio;
        List<RegistroInfraccion> infracciones;
        float total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                admin = (Administradora)Session["administra"];
                unDominio = (string)Session["dominio"];
                infracciones = admin.buscarInfracciones(unDominio);
                ListBoxInfracciones.DataSource = infracciones;
                ListBoxInfracciones.DataBind();

                for (int i = 0; i<infracciones.Count; i++)
                {
                    total += infracciones[i].darImporte();
                }

                LabelTotal.Text = "$ "+total.ToString();

            }
        }

        protected void ButtonGenerarPago_Click(object sender, EventArgs e)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            // Draw the text
            gfx.DrawString("Orden de pago", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.Center);

            //Getting fields on the pdf form
            
            

            // Save the document...
            string filename = "C:\\Users\\fl\\Documents\\GitHub\\infraccionesDeTransito\\UIWeb\\HelloWorld.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);

            Response.Redirect("MenuAdmin.aspx");
        }
    }
}