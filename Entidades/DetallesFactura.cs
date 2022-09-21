using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class DetallesFactura
    {
        private Facturas factura;
        private Lotes lote;
        private float precio_Producto;
        private int cantidad_Productos;

        public Facturas Factura { get; set; }
        public Lotes Lote { get; set; }
        public int CantidadProductos { get;set; }
        public int Cantidad_Productos { get; set; }
    }
}
