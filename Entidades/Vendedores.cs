using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Clases;

namespace TPPAV.Entidades
{
    public class Vendedores
    {
        private string numero_Doc;          
        private TiposDocumentos tipo_Doc;
        private DateTime fecha_Ingreso;
        private DateTime fecha_Nacimiento;
        private string telefono;
        private string nombre;
        private string apellido;
        private ComisionesVendedores comision;

        public string Numero_Doc { get; set; }
        public TiposDocumentos TiposDocumentos { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public ComisionesVendedores Comision { get; set; }

    }
}
