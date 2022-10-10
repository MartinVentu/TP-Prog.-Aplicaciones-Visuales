using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPAV.Entidades;

namespace TPPAV.Repositorios
{
    public class repositorioFactura
    {
        public int RegistrarFactura(Facturas factura)
        {
            try
            {
                string secuenciaSQL = $"INSERT INTO Facturas (Tipo_Factura,Id_Cliente,Nro_Dto_Vendedor,Tipo_Doc_Vendedor,Fecha,Precio_Total)" +
                    $" VALUES ('{factura.TiposFacturas.IdTipo_Factura}','{factura.Cliente.Id_Cliente}','{factura.Vendedor.Numero_Doc}','{factura.Vendedor.TiposDocumentos.Id_tipo_documento}'," +
                    $"'{factura.Fecha}','{factura.Precio_Total}')";
                var regFactura = DBHelper.GetDBHelper().EjecutarSQL(secuenciaSQL);
                return regFactura;
            }
            catch
            {
                throw new ApplicationException("No se pudo registrar nueva Factura");
            }
        }
        public List<Facturas> ConsultarFacturas()
        {
            try
            {
                List<Facturas> facturas = new List<Facturas>();
                string secuenciaSQL = $"SELECT * FROM Facturas";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    Facturas factura = new Facturas();
                    factura.Numero_Factura = Convert.ToInt32(fila["Numero_Factura"]);
                    factura.TiposFacturas.IdTipo_Factura = Convert.ToInt32(fila["Tipo_Factura"]);
                    factura.Cliente.Id_Cliente = Convert.ToInt32(fila["Id_Cliente"]);
                    factura.Vendedor.Numero_Doc = fila["Nro_Dto_Vendedor"].ToString();
                    factura.Vendedor.TiposDocumentos.Id_tipo_documento = Convert.ToInt32(fila["Tipo_Dto_Vendedor"]);
                    factura.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    factura.Precio_Total = float.Parse(fila["Precio_Total"].ToString());
                    facturas.Add(factura);
                }
                return facturas;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener las facturas");
            }
        }
        public List<Facturas> ConsultarFacturas(DateTime fecha)
        {
            try
            {
                List<Facturas> facturas = new List<Facturas>();
                string secuenciaSQL = $"SELECT * FROM Facturas WHERE Fecha='{fecha}'";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    Facturas factura = new Facturas();
                    factura.Numero_Factura = Convert.ToInt32(fila["Numero_Factura"]);
                    factura.TiposFacturas.IdTipo_Factura = Convert.ToInt32(fila["Tipo_Factura"]);
                    factura.Cliente.Id_Cliente = Convert.ToInt32(fila["Id_Cliente"]);
                    factura.Vendedor.Numero_Doc = fila["Nro_Dto_Vendedor"].ToString();
                    factura.Vendedor.TiposDocumentos.Id_tipo_documento = Convert.ToInt32(fila["Tipo_Dto_Vendedor"]);
                    factura.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    factura.Precio_Total = float.Parse(fila["Precio_Total"].ToString());
                    facturas.Add(factura);
                }
                return facturas;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener las facturas");
            }
        }
        public List<Facturas> ConsultarFacturas(Clientes cliente)
        {
            try
            {
                List<Facturas> facturas = new List<Facturas>();
                string secuenciaSQL = $"SELECT * FROM Facturas WHERE Id_Cliente='{cliente.Id_Cliente}'";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    Facturas factura = new Facturas();
                    factura.Numero_Factura = Convert.ToInt32(fila["Numero_Factura"]);
                    factura.TiposFacturas.IdTipo_Factura = Convert.ToInt32(fila["Tipo_Factura"]);
                    factura.Cliente.Id_Cliente = Convert.ToInt32(fila["Id_Cliente"]);
                    factura.Vendedor.Numero_Doc = fila["Nro_Dto_Vendedor"].ToString();
                    factura.Vendedor.TiposDocumentos.Id_tipo_documento = Convert.ToInt32(fila["Tipo_Dto_Vendedor"]);
                    factura.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    factura.Precio_Total = float.Parse(fila["Precio_Total"].ToString());
                    facturas.Add(factura);
                }
                return facturas;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener las facturas");
            }
        }
        public List<Facturas> ConsultarFacturas(TiposFacturas tipo)
        {
            try
            {
                List<Facturas> facturas = new List<Facturas>();
                string secuenciaSQL = $"SELECT * FROM Facturas WHERE Tipo_Factura='{tipo.IdTipo_Factura}'";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    Facturas factura = new Facturas();
                    factura.Numero_Factura = Convert.ToInt32(fila["Numero_Factura"]);
                    factura.TiposFacturas.IdTipo_Factura = Convert.ToInt32(fila["Tipo_Factura"]);
                    factura.Cliente.Id_Cliente = Convert.ToInt32(fila["Id_Cliente"]);
                    factura.Vendedor.Numero_Doc = fila["Nro_Dto_Vendedor"].ToString();
                    factura.Vendedor.TiposDocumentos.Id_tipo_documento = Convert.ToInt32(fila["Tipo_Dto_Vendedor"]);
                    factura.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    factura.Precio_Total = float.Parse(fila["Precio_Total"].ToString());
                    facturas.Add(factura);
                }
                return facturas;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener las facturas");
            }
        }
        public List<Facturas> ConsultarFacturas(Vendedores vendedor)
        {
            try
            {
                List<Facturas> facturas = new List<Facturas>();
                string secuenciaSQL = $"SELECT * FROM Facturas WHERE Nro_Dto_Vendedor='{vendedor.Numero_Doc}' AND Tipo_Dto_Vendedor='{vendedor.TiposDocumentos.Id_tipo_documento}";
                var tabla = DBHelper.GetDBHelper().ConsultaSQL(secuenciaSQL);
                foreach (DataRow fila in tabla.Rows)
                {
                    Facturas factura = new Facturas();
                    factura.Numero_Factura = Convert.ToInt32(fila["Numero_Factura"]);
                    factura.TiposFacturas.IdTipo_Factura = Convert.ToInt32(fila["Tipo_Factura"]);
                    factura.Cliente.Id_Cliente = Convert.ToInt32(fila["Id_Cliente"]);
                    factura.Vendedor.Numero_Doc = fila["Nro_Dto_Vendedor"].ToString();
                    factura.Vendedor.TiposDocumentos.Id_tipo_documento = Convert.ToInt32(fila["Tipo_Dto_Vendedor"]);
                    factura.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    factura.Precio_Total = float.Parse(fila["Precio_Total"].ToString());
                    facturas.Add(factura);
                }
                return facturas;
            }
            catch
            {
                throw new ApplicationException("No se pudo obtener las facturas");
            }
        }
    }
}
