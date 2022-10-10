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
            var clasificaciones = repositorio.ConsultarLotes();
            return clasificaciones;
        }
    }
}
