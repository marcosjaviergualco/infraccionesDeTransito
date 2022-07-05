﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.IO;
using CapaNegocio;

namespace UIWeb
{
    public partial class ConsultarInfracciones : System.Web.UI.Page
    {
        Administradora admin;
        string unDominio;
        List<RegistroInfraccion> infracciones;
        List<RegistroInfraccion> infraccionesPagas;
        float total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                admin = (Administradora)Session["administra"];
                unDominio = (string)Session["dominio"];
                infracciones = admin.buscarInfraccionesImpagas(unDominio);
                ListBoxInfracciones.DataSource = infracciones;
                ListBoxInfracciones.DataBind();
                infraccionesPagas = admin.buscarInfraccionesPagas(unDominio);
                ListBoxPagas.DataSource = infraccionesPagas;
                ListBoxPagas.DataBind();
                Label_vehiculo.Text = unDominio;

                if (infracciones.Count == 0)
                {
                    LabelTotal.Text ="0."+ " -- EL VEHICULO NO TIENE INFRACCIONES A PAGAR.";
                    ButtonGenerarPago.Enabled = false;
                }
                else
                {

                    for (int i = 0; i < infracciones.Count; i++)
                    {
                        total += infracciones[i].darImporte();
                    }

                    Session["total"] = total;
                    Session["infraccioness"] = infracciones;
                    LabelTotal.Text = "$ " + total.ToString();
                    recuperarTotaleInfracciones();

                }

            }
            
        }

        protected void recuperarTotaleInfracciones()
        {
            admin = (Administradora)(Session["administra"]);
            total = (float)(Session["total"]);
            infracciones = (List<RegistroInfraccion>)(Session["infraccioness"]);
        }

        protected void ButtonGenerarPago_Click(object sender, EventArgs e)
        {
            recuperarTotaleInfracciones();
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont font2 = new XFont("Times New Roman", 10, XFontStyle.Regular);

            // Draw the text
            gfx.DrawString("Orden de pago", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.TopCenter);

            Pago p;
            int paraListarInfracciones = 70;
            Random rand = new Random();
            for (int i = 0; i < infracciones.Count; i++)
            {
                gfx.DrawString("\n" + infracciones[i].ToString(), font2, XBrushes.Black,
                    new XRect(50, paraListarInfracciones += 20, page.Width, page.Height),
                    XStringFormats.TopLeft);

                infracciones[i].Condicion = "P";
                admin.actualizarRegistroInfraccion(infracciones[i].Codigo);
            }

            int cod;
            cod = admin.Pagos.Count + 1;
            p = new Pago(cod, infracciones, total, DateTime.Today.ToString());
            admin.insertar(p);

            gfx.DrawString("TOTAL: $" + total, font, XBrushes.Black,
                new XRect(-30, 0, page.Width, page.Height), XStringFormats.BottomRight);


            // Save the document...
            string filename = "C:\\Users\\fl\\Documents\\GitHub\\infraccionesDeTransito\\UIWeb\\OrdenDePago.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);

            Response.Redirect("MenuAdmin.aspx");
        }

        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdmin.aspx");
        }
    }
}