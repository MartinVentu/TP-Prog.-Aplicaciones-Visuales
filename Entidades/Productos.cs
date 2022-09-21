using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class Productos
    {
        private int id_Producto;
        private string descripcion;
        private UnidadesMedidas unidad_medida;
        private float precio;
        private ClasificacionesUsos clasificacion_Uso;
        private Proveedores proveedor;

        public int Id_Producto { get; set; }
        public string Descripcion { get; set; }
        public UnidadesMedidas Unidad_medida { get; set; }
        public float Precio { get; set; }
        public ClasificacionesUsos Clasificacion_Uso { get; set; }
        public Proveedores Proveedor { get; set; }
        
    }
}
