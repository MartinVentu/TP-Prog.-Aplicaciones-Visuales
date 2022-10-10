using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;
using TPPAV.Repositorios;

namespace TPPAV.Servicios
{
    public class servicioDetallesFactura
    {
        private repositorioDetalleFactura repositorio;

        public servicioDetallesFactura()
        {
            repositorio = new repositorioDetalleFactura();
        }

        public bool RegistrarDetalle(DetallesFactura detalle)
        {
            if (repositorio.RegistrarDetalle(detalle) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<DetallesFactura> ConsultarDetalle(Facturas factura)
        {
            var detalles = repositorio.ConsultarDetalles(factura);
            return detalles;
        }
    }
}
