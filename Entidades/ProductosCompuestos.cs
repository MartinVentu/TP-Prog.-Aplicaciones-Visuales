using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class ProductosCompuestos
    {
        private Productos producto_Compuesto;
        private Productos producto_Componente;
        private int composicion;
        private string descripcion;

        public Productos Producto_Compuesto { get; set; }
        public Productos Producto_Componente { get; set; }
        public int Composicion { get; set; }
        public string Descripcion { get; set; }
    }
}
