using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;
using TPPAV.Repositorios;

namespace TPPAV.Servicios
{
    public class servicioBarrio
    {
        private repositorioBarrio repositorioBarrio;

        public servicioBarrio()
        {
            repositorioBarrio = new repositorioBarrio();
        }

        public bool registrarBarrio(Barrios barrio)
        {
            if (repositorioBarrio.RegistrarBarrio(barrio) > 0)
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
