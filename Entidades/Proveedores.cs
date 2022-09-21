﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class Proveedores
    {
        private string cuil;
        private string apellido;
        private string nombre;
        private Barrios barrio;
        private string calle;
        private int nro_Calle;
        private string telefono;

        public string Cuil { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Barrios Barrio { get; set; }
        public string Calle { get; set; }
        public int Nro_Calle { get; set; }
        public string Telefono { get; set; }

    }
}
