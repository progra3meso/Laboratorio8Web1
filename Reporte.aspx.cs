using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio8
{
    public partial class Reporte1 : System.Web.UI.Page
    {
        List<Ciudadano> ciudadanos = new List<Ciudadano>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        List<Reporte> reportes = new List<Reporte>();

        private void LeerCiudadanos()
        {
            string archivos = Server.MapPath("/Archivos/Ciudadanos.txt");
            FileStream stream = new FileStream(archivos, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Ciudadano ciudadano = new Ciudadano();
                ciudadano.Dpi = reader.ReadLine();
                ciudadano.Nombre = reader.ReadLine();
                ciudadano.Direccion = reader.ReadLine();

                ciudadanos.Add(ciudadano);
            }
            reader.Close();
        }

        private void LeerInscripciones ()
        {
            string archivoI = Server.MapPath("/Archivos/Inscripciones.txt");
            FileStream streamI = new FileStream(archivoI, FileMode.Open, FileAccess.Read);
            StreamReader readerI = new StreamReader(streamI);
            while (readerI.Peek() > -1)
            {
                Inscripcion inscripcion = new Inscripcion();
                inscripcion.Dpi = readerI.ReadLine();
                inscripcion.Partido = readerI.ReadLine();
                inscripcion.Fecha = Convert.ToDateTime(readerI.ReadLine());

                inscripciones.Add(inscripcion);
            }
            readerI.Close();
        }

        private void CrearReporte()
        {
            for (int i = 0; i < inscripciones.Count; i++)
            {
                for (int j = 0; j < ciudadanos.Count; j++)
                {
                    if (inscripciones[i].Dpi == ciudadanos[j].Dpi)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Nombre = ciudadanos[j].Nombre;
                        reporte.Partido = inscripciones[i].Partido;

                        reportes.Add(reporte);
                    }
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonReporte_Click(object sender, EventArgs e)
        {
            LeerCiudadanos();
            LeerInscripciones();
            CrearReporte();
            
            GridView1.DataSource = reportes;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LeerCiudadanos();
            LeerInscripciones();
            CrearReporte();
            GridView1.DataSource = reportes.OrderByDescending(p => p.Partido);
            GridView1.DataBind();
        }

        protected void ButtonTotal_Click(object sender, EventArgs e)
        {
            LeerCiudadanos();
            LeerInscripciones();
            CrearReporte();
            LabelTotal.Text = reportes.Count().ToString();
        }
    }
}