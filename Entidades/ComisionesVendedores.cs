using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class ComisionesVendedores
    {
        private int id_Comision_Vendedor;
        private string descripcion;
        private float valor_Comision;

        public int ID_Comision_Vendedor { get; set; }
        public string Descripcion { get; set; } 
        public float ValorComision { get; set; }
    }
}
