using System;
using System.Collections.Generic;
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
    }
}
