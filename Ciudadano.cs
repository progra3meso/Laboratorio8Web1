﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio8
{
    public class Ciudadano
    {
        string dpi;
        string nombre;
        string direccion;

        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}