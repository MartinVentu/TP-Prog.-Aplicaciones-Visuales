using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liquidación.Repositorio
{
    class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();
        private SqlConnection _conexion;
        private SqlCommand _cmd;

        private DBHelper()
        {
            // Aca va la cadena de conexion para la base de datos
            string_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G10_2022;User ID=BD3K3G10_2022;Password=CLV10_30072";
        }

        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.ConnectionString = string_conexion;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            this.CloseConnection(cnn);
            return tabla;
        }


        public int EjecutarSQL(string strSql)
        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cnn.ConnectionString = string_conexion;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            afectadas = cmd.ExecuteNonQuery();
            
            this.CloseConnection(cnn);
           
            return afectadas;
        }

        public SqlTransaction IniciarTransaccion()
        {
            Conectar();
            var transaccion = _conexion.BeginTransaction();
            _cmd.Transaction = transaccion;
            return transaccion;
        }

        public int EjecutarTransaccionSQL(string strSql)
        {
            var id = 0;
            _cmd.CommandText = strSql;

            if (_cmd.ExecuteNonQuery() > 0)
            {
                string consultaGetId = "SELECT @@ Identity";
                _cmd.CommandText = consultaGetId;
                id = int.Parse(_cmd.ExecuteScalar()?.ToString());
            }
            return id;
        }


        public void EjecutarUpdateTransaccionSQL(string strSql)
        {
            _cmd.CommandText = strSql;
            _cmd.ExecuteNonQuery();
        }


        public void CloseConnection()
        {
            if (_conexion.State == ConnectionState.Open)
            {
                //cierra la conexión con la base de datos
                _conexion.Close();
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public void Conectar()
        {
            _conexion = new SqlConnection();
            _cmd = new SqlCommand();
            //asigan al objeto <conexion> la cadena de conexion
            _conexion.ConnectionString = string_conexion;
            //agrega la conexion (se crea el pipe entre la aplicación y la base de datos)
            _conexion.Open();
            //se comunica al objeto <cmd> sobre que conexion debe trabajar
            _cmd.Connection = _conexion;
            //se establece el tipo de comando que va ha ejecutar
            _cmd.CommandType = CommandType.Text;
        }


        public DataTable ConsultaDuranteTransaccion(string comando)
        {

            _cmd.CommandText = comando;
            //instancia un objeto <tabla> del tipo DataTable
            DataTable tabla = new DataTable();

            tabla.Load(_cmd.ExecuteReader());

            //devuelve el valor calculado a través de la función
            return tabla;
        }


    }
}
