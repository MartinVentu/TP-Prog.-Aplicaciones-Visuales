using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;

namespace TPPAV.Repositorios
{
    public class repositorioBarrio
    {
        public int RegistrarBarrio(Barrios barrio)
        {
            try
            {
                string secuenciaSQL = $"INSERT INTO Barrios (Nombre) VALUES ({barrio.Nombre})";
                var regBarrio = DBHelper.GetDBHelper().EjecutarSQL(secuenciaSQL);
                return regBarrio;
            }
            catch
            {
                throw new ApplicationException("No se pudo registrar nuevo barrio");
            }
        }
    }
}
