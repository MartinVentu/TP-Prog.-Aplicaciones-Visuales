using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class Facturas
    {
        private int numero_Factura;
        private TiposFacturas tipo_Factura;
        private Clientes cliente;
        private Vendedores vendedor;
        private DateTime fecha;
        private float precio_Total;

        public int Numero_Factura { get; set; }
        public TiposFacturas TiposFacturas { get; set; }
        public Clientes Cliente { get; set; }
        public Vendedores Vendedor { get; set; }
        public DateTime Fecha { get; set; }
        public float Precio_Total { get; set; }

    }
}
