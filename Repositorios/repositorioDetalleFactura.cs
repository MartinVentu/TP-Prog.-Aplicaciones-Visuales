using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;

namespace TPPAV.Repositorios
{
    public class repositorioDetalleFactura
    {
        public int RegistrarDetalle(DetallesFactura detalle)
        {
            try
            {
                string secuenciaSQL = $"INSERT INTO DetallesFactura (Numero_Factura,Tipo_Factura,Id_Lote,Precio_Producto,Cantidad_Productos) VALUES ('{detalle.Factura.Numero_Factura}','{detalle.Factura.TiposFacturas.IdTipo_Factura}','{detalle.Lote.Id_Lote}','{detalle.Precio_Productos}','{detalle.Cantidad_Productos}')";
                var regFactura = DBHelper.GetDBHelper().EjecutarSQL(secuenciaSQL);
                return regFactura;
            }
            catch
            {
                throw new ApplicationException("No se pudo registrar nuevo detalle de factura");
            }
        }
        public List<DetallesFactura> ConsultarDetalles(Facturas factura)
        {
            try
            {
                List<DetallesFactura> detalles = new List<DetallesFactura>();
                string secuenciaSQL = $"SELECT * FROM DetallesFactura WHERE Numero_Factura ='{factura.Numero_Factura}; AND Tipo_Factura='{factura.TiposFacturas.IdTipo_Factura}'";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    DetallesFactura detalle = new DetallesFactura();
                    detalle.Factura.Numero_Factura = Convert.ToInt32(fila["Numero_Factura"]);
                    detalle.Factura.TiposFacturas.IdTipo_Factura = Convert.ToInt32(fila["Tipo_Factura"]);
                    detalle.Lote.Id_Lote = Convert.ToInt32(fila["Id_Lote"]);
                    detalle.Precio_Productos = float.Parse(fila["Precio_Producto"].ToString());
                    detalle.Cantidad_Productos = Convert.ToInt32(fila["Cantidad_Productos"]);
                    detalles.Add(detalle);
                }
                return detalles ;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener los detalles");
            }
        }
        public int ActualizarDetalle(DetallesFactura detalle)
        {
            try
            {
                string sentenciaSql = $"UPDATE DetallesFactura SET Id_Lote = '{detalle.Lote.Id_Lote}' , Precio_Productos = '{detalle.Precio_Productos}', Cantidad_Productos = '{detalle.Cantidad_Productos}'" +
                    $" WHERE Numero_Factura = '{detalle.Factura.Numero_Factura}' AND Tipo_Factura = '{detalle.Factura.TiposFacturas.IdTipo_Factura}' AND Id_Lote = '{detalle.Lote.Id_Lote}'";
                var rdo = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
                return rdo;
            }
            catch
            {
                throw new ApplicationException("No se pudo actualizar el detalle ");
            }
        }

        public int EliminarDetalle(DetallesFactura detalle)
        {
            try
            {
                string sentenciaSql = $"DELETE FROM DetallesFactura  WHERE Numero_Factura = '{detalle.Factura.Numero_Factura}' AND Tipo_Factura = '{detalle.Factura.TiposFacturas.IdTipo_Factura}' AND Id_Lote = '{detalle.Lote.Id_Lote}'";
                var rdo = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
                return rdo;
            }
            catch
            {
                throw new ApplicationException("No se pudo eliminar el detalle");
            }
        }
    }
}
