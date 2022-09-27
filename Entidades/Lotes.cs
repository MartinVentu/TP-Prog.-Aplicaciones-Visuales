using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class Lotes
    {
        private int id_Lote;
        private Productos producto;
        private Proveedores proveedor;
        private DateTime fecha_ingreso;
        private int cantidad_Actual;
        private int cantidad_Inicial;

        public int Id_Lote { get;set; }
        public Productos Producto { get; set; }
        public Proveedores Proveedor { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public int Cantidad_Actual { get; set; }
        public int Cantidad_Inicial { get; set; }
    }
}
