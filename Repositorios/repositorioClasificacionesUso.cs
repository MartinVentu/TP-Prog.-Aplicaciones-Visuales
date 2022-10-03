using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;

namespace TPPAV.Repositorios
{
    public class repositorioClasificacionesUso
    {
        public int RegistrarClasificacion(ClasificacionesUsos clasificacion)
        {
            try
            {
                string secuenciaSQL = $"INSERT INTO Clasificaciones_Usos (Descripcion) VALUES ('{clasificacion.Descripcion}')";
                var regBarrio = DBHelper.GetDBHelper().EjecutarSQL(secuenciaSQL);
                return regBarrio;
            }
            catch
            {
                throw new ApplicationException("No se pudo registrar nueva clasificacion");
            }
        }
        public List<ClasificacionesUsos> ConsultarClasificacion()
        {
            try
            {
                List<ClasificacionesUsos> clasificaciones = new List<ClasificacionesUsos>();
                string secuenciaSQL = $"SELECT * FROM Clasificaciones_Usos";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    ClasificacionesUsos clasificacion = new ClasificacionesUsos();
                    clasificacion.Id_Clasificacion = Convert.ToInt32(fila["Id_Clasificacion"]);
                    clasificacion.Descripcion = fila["Descripcion"].ToString();
                    clasificaciones.Add(clasificacion);
                }
                return clasificaciones;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener las clasificaciones de uso");
            }
        }
    }
}
