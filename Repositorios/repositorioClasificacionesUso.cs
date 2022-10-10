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
                var regClasificacion = DBHelper.GetDBHelper().EjecutarSQL(secuenciaSQL);
                return regClasificacion;
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
        public int ActualizarClasificacion(ClasificacionesUsos clasificacion)
        {
            try
            {
                string sentenciaSql = $"UPDATE Clasificaciones_Usos SET Descripcion = '{clasificacion.Descripcion}' WHERE Id_Clasificacion = '{clasificacion.Id_Clasificacion}'";
                var rdo = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
                return rdo;
            }
            catch
            {
                throw new ApplicationException("No se pudo actualizar la clasificacion de uso");
            }
        }

        public int EliminarClasificacion(ClasificacionesUsos clasificacion)
        {
            try
            {
                string sentenciaSql = $"DELETE FROM Clasificaciones_Usos  WHERE Id_Clasificacion = '{clasificacion.Id_Clasificacion}'";
                var rdo = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
                return rdo;
            }
            catch
            {
                throw new ApplicationException("No se pudo eliminar la clasificacion de uso");
            }
        }

    }
}
