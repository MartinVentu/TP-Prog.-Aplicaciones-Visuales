using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;
using TPPAV.Repositorios;

namespace TPPAV.Servicios
{
    public class servicioLotes
    {
        private repositorioLotes repositorio;

        public servicioLotes()
        {
            repositorio = new repositorioLotes();
        }
        public bool RegistrarLote(Lotes lote)
        {
            if (repositorio.RegistrarLote(lote) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Lotes> ConsultarLotes()
        {
            var lotes = repositorio.ConsultarLotes();
            return lotes;
        }
        public List<Lotes> ConsultarLotesDisponibles()
        {
            var lotes = repositorio.ConsultarLotesDisponibles();
            return lotes;
        }
        public List<Lotes> ConsultarLotes(Proveedores proveedor)
        {
            var lotes = repositorio.ConsultarLotes(proveedor);
            return lotes;
        }
        public List<Lotes> ConsultarLotes(int mes, int anio)
        {
            var lotes = repositorio.ConsultarLotes(mes,anio);
            return lotes;
        }
        public bool ActualizarLote(Lotes lote)
        {
            if (repositorio.ActualizarLote(lote) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarLote(Lotes lote)
        {
            if (repositorio.EliminarLote(lote) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
