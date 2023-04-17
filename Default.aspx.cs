using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio8
{
    public partial class _Default : Page
    {
        List<Ciudadano> ciudadanos = new List<Ciudadano>();
        protected void Page_Load(object sender, EventArgs e)
        {
           //Postback: es cuando una página se recarga
           //la primera vez que se carga NO es Postback
            if (!IsPostBack)//que cargue los ciudadanos solo la primera vez
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

                DropDownListCiudadano.DataValueField = "DPI";
                DropDownListCiudadano.DataTextField = "Nombre";

                DropDownListCiudadano.DataSource = ciudadanos;
                DropDownListCiudadano.DataBind();
                reader.Close();
            }

        }

        protected void ButtonInscribir_Click(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("/Archivos/Inscripciones.txt");
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);            
            StreamWriter writer = new StreamWriter(stream);
            DateTime fecha = DateTime.Now;
            writer.WriteLine(DropDownListCiudadano.SelectedValue);
            writer.WriteLine(TextBoxPartido.Text);
            writer.WriteLine(fecha);
            writer.Close();
        }
    }
}