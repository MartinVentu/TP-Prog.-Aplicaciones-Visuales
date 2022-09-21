using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class Clientes
    {
        private int id_Cliente;
        private string nombre;
        private string apellido;
        private string telefono;
        private string cuit;

        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Cuit { get; set; }

    }
}
