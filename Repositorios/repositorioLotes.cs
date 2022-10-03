using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;

namespace TPPAV.Repositorios
{
    public class repositorioLotes
    {

        public int RegistrarLote(Lotes lote )
        {
            try
            {
                string secuenciaSQL = $"INSERT INTO Lotes (Id_Producto,Cuil_Proveedor,Fecha_Ingreso,Cantidad_Actual,Cantidad_Inicial VALUES ('{lote.Producto.Id_Producto}','{lote.Proveedor.Cuil}','{lote.Fecha_Ingreso}','{lote.Cantidad_Inicial}','{lote.Cantidad_Inicial}')";
                var regLote = DBHelper.GetDBHelper().EjecutarSQL(secuenciaSQL);
                return regLote;
            }
            catch
            {
                throw new ApplicationException("No se pudo registrar nuevo barrio");
            }
        }
        public List<Lotes> ConsultarLotes()
        {
            try
            {
                List<Lotes> lotes = new List<Lotes>();
                string secuenciaSQL = $"SELECT * FROM Lotes";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    Lotes lote= new Lotes();
                    lote.Id_Lote = Convert.ToInt32(fila["Id_Lote"]);
                    lote.Producto = new Productos();
                    lote.Producto.Id_Producto = Convert.ToInt32(fila["Id_Producto"]);
                    lote.Proveedor = new Proveedores();
                    lote.Proveedor.Cuil = fila["Cuil_Proveedor"].ToString();
                    lote.Fecha_Ingreso = Convert.ToDateTime(fila["Fecha_Ingreso"]);
                    lote.Cantidad_Actual = Convert.ToInt32(fila["Cantidad_Actual"]);
                    lote.Cantidad_Inicial = Convert.ToInt32(fila["Cantidad_Inicial"]);
                    lotes.Add(lote);

                }
                return lotes;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener los lotes");
            }
        }
        public int ActualizarLote(Lotes lote)
        {
            try
            {
                string sentenciaSql = $"UPDATE Lotes SET  Cantidad_Actual = '{lote.Cantidad_Actual}' WHERE Id_Lote = '{lote.Id_Lote}' ";
                var rdo = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
                return rdo;
            }
            catch
            {
                throw new ApplicationException("No se pudo actualizar el lote");
            }
        }
    }
}
