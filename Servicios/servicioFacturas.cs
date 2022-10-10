using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;
using TPPAV.Repositorios;

namespace TPPAV.Servicios
{
    public class servicioFacturas
    {
        private repositorioFactura repositorio;
        public servicioFacturas()
        {
            repositorio = new repositorioFactura();
        }

        public bool RegistrarFactura(Facturas factura)
        {
            if (repositorio.RegistrarFactura(factura) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Facturas> ConsultarFacturas()
        {
            var facturas = repositorio.ConsultarFacturas();
            return facturas;
        }

        public List<Facturas> ConsultarFacturas(DateTime fecha)
        {
            var facturas = repositorio.ConsultarFacturas(fecha);
            return facturas;
        }
        public List<Facturas> ConsultarFacturas(Clientes cliente)
        {
            var facturas = repositorio.ConsultarFacturas(cliente);
            return facturas;
        }
        public List<Facturas> ConsultarFacturas(TiposFacturas tipo)
        {
            var facturas = repositorio.ConsultarFacturas(tipo);
            return facturas;
        }
        public List<Facturas> ConsultarFacturas(Vendedores vendedor)
        {
            var facturas = repositorio.ConsultarFacturas(vendedor);
            return facturas;
        }

    }
}
