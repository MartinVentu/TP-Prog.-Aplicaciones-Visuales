using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;
using TPPAV.Repositorios;

namespace TPPAV.Servicios
{
    public class servicioClasificacionesUso
    {
        private repositorioClasificacionesUso repositorio;

        public servicioClasificacionesUso()
        {
            repositorio = new repositorioClasificacionesUso();
        }

        public bool RegistrarClasificacion(ClasificacionesUsos clasificacion)
        {
            if (repositorio.RegistrarClasificacion(clasificacion)>0)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
        public List<ClasificacionesUsos> ConsultarClasificaciones()
        {
            var clasificaciones = repositorio.ConsultarClasificacion();
            return clasificaciones;
        }
    }
}
