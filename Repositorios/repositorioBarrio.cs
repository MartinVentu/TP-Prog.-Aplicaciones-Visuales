using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPAV.Entidades;

namespace TPPAV.Repositorios
{
    public class repositorioBarrio
    {
        public int RegistrarBarrio(Barrios barrio)
        {
            try
            {
                string secuenciaSQL = $"INSERT INTO Barrios (Nombre) VALUES ('{barrio.Nombre}')";
                var regBarrio = DBHelper.GetDBHelper().EjecutarSQL(secuenciaSQL);
                return regBarrio;
            }
            catch
            {
                throw new ApplicationException("No se pudo registrar nuevo barrio");
            }
        }
        public List<Barrios> ConsultarBarrio()
        {
            try
            {
                List<Barrios> barrios = new List<Barrios>();
                string secuenciaSQL = $"SELECT * FROM Barrios";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    Barrios barrio = new Barrios();
                    barrio.Id_barrio = Convert.ToInt32(fila["Id_Barrio"]);
                    barrio.Nombre = fila["Nombre"].ToString();
                    barrios.Add(barrio);
                }
                return barrios;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener los barrios");
            }
        }

    }
}
