using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio8
{
    public class Inscripcion
    {
        string dpi;
        string partido;
        DateTime fecha;

        public string Dpi { get => dpi; set => dpi = value; }
        public string Partido { get => partido; set => partido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}