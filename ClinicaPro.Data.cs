using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Borrador
{
    /// <summary>
    /// Clase para manejar la conexión a SQL Server
    /// Patrón Singleton para una única instancia de conexión
    /// </summary>
    public class ConexionDB
    {
        #region Singleton Pattern
        private static ConexionDB _instancia;
        private static readonly object _lock = new object();

        private ConexionDB() { }

        public static ConexionDB Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_lock)
                    {
                        if (_instancia == null)
                        {
                            _instancia = new ConexionDB();
                        }
                    }
                }
                return _instancia;
            }
        }
        #endregion

        #region Cadena de Conexión

        /// <summary>
        /// Obtiene la cadena de conexión desde App.config o Web.config
        /// Si no existe, usa una cadena por defecto para SQL Server local
        /// </summary>
        

        /// <summary>
        /// Construye una cadena de conexión para SQL Server local con autenticación SQL
        /// </summary>
        private string ObtenerCadenaConexion()
        {
            try
            {
                // Primero intenta leer la conexión de Azure
                string cadenaAzure = ConfigurationManager.ConnectionStrings["ConexionAzure"]?.ConnectionString;

                if (!string.IsNullOrEmpty(cadenaAzure))
                {
                    return cadenaAzure;
                }

                // Si no existe, intenta leer ClinicaProDB (conexión local)
                string cadenaConfig = ConfigurationManager.ConnectionStrings["ClinicaProDB"]?.ConnectionString;

                if (!string.IsNullOrEmpty(cadenaConfig))
                {
                    return cadenaConfig;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error leyendo configuración: {ex.Message}");
            }

            // Cadena de conexión por defecto para Azure SQL Database
            return ConstruirCadenaConexionAzure();
        }

        /// <summary>
        /// Construye cadena de conexión con usuario y contraseña SQL Server
        /// </summary>
        private string ConstruirCadenaConexionAzure()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "hospitalserver.database.windows.net",
                InitialCatalog = "BD-Hospital",
                UserID = "SuperAdmin",
                Password = "Hospital.123",
                IntegratedSecurity = false,
                MultipleActiveResultSets = true,
                ConnectTimeout = 30,
                Encrypt = true,  // IMPORTANTE: Azure requiere encrypt=true
                TrustServerCertificate = false  // Azure usa certificados válidos
            };

            return builder.ConnectionString;
        }

        #endregion

        #region Métodos de Conexión

        /// <summary>
        /// Abre y retorna una nueva conexión a la base de datos
        /// </summary>
        public SqlConnection AbrirConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion());
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al conectar con la base de datos: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado al abrir conexión: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Cierra una conexión si está abierta
        /// </summary>
        public void CerrarConexion(SqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cerrar conexión: {ex.Message}");
            }
        }

        /// <summary>
        /// Prueba la conexión a la base de datos
        /// </summary>
        public bool ProbarConexion(out string mensaje)
        {
            SqlConnection conexion = null;
            try
            {
                conexion = AbrirConexion();
                mensaje = "Conexión exitosa a la base de datos ClinicaPro";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = $"Error de conexión: {ex.Message}";
                return false;
            }
            finally
            {
                CerrarConexion(conexion);
            }
        }

        #endregion

        #region Métodos de Ejecución SQL

        /// <summary>
        /// Ejecuta una consulta SELECT y retorna un DataTable
        /// </summary>
        public DataTable EjecutarConsulta(string query, SqlParameter[] parametros = null)
        {
            SqlConnection conexion = null;
            DataTable tabla = new DataTable();

            try
            {
                conexion = AbrirConexion();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandTimeout = 60;

                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
                return tabla;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error ejecutando consulta SQL: {ex.Message}\nQuery: {query}", ex);
            }
            finally
            {
                CerrarConexion(conexion);
            }
        }

        /// <summary>
        /// Ejecuta un comando INSERT, UPDATE o DELETE
        /// Retorna el número de filas afectadas
        /// </summary>
        public int EjecutarComando(string query, SqlParameter[] parametros = null)
        {
            SqlConnection conexion = null;

            try
            {
                conexion = AbrirConexion();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandTimeout = 60;

                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    return comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error ejecutando comando SQL: {ex.Message}\nQuery: {query}", ex);
            }
            finally
            {
                CerrarConexion(conexion);
            }
        }

        /// <summary>
        /// Ejecuta un INSERT y retorna el ID generado (IDENTITY)
        /// </summary>
        public int EjecutarComandoConRetorno(string query, SqlParameter[] parametros = null)
        {
            SqlConnection conexion = null;

            try
            {
                conexion = AbrirConexion();
                using (SqlCommand comando = new SqlCommand(query + "; SELECT SCOPE_IDENTITY();", conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandTimeout = 60;

                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    object resultado = comando.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error ejecutando comando con retorno: {ex.Message}\nQuery: {query}", ex);
            }
            finally
            {
                CerrarConexion(conexion);
            }
        }

        /// <summary>
        /// Ejecuta una consulta escalar (retorna un solo valor)
        /// </summary>
        public object EjecutarEscalar(string query, SqlParameter[] parametros = null)
        {
            SqlConnection conexion = null;

            try
            {
                conexion = AbrirConexion();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandTimeout = 60;

                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    return comando.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error ejecutando consulta escalar: {ex.Message}\nQuery: {query}", ex);
            }
            finally
            {
                CerrarConexion(conexion);
            }
        }

        /// <summary>
        /// Ejecuta un Stored Procedure
        /// </summary>
        public DataTable EjecutarStoredProcedure(string nombreSP, SqlParameter[] parametros = null)
        {
            SqlConnection conexion = null;
            DataTable tabla = new DataTable();

            try
            {
                conexion = AbrirConexion();
                using (SqlCommand comando = new SqlCommand(nombreSP, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandTimeout = 60;

                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
                return tabla;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error ejecutando SP {nombreSP}: {ex.Message}", ex);
            }
            finally
            {
                CerrarConexion(conexion);
            }
        }

        /// <summary>
        /// Ejecuta múltiples comandos en una transacción
        /// </summary>
        public bool EjecutarTransaccion(Action<SqlConnection, SqlTransaction> accion, out string mensajeError)
        {
            SqlConnection conexion = null;
            SqlTransaction transaccion = null;
            mensajeError = string.Empty;

            try
            {
                conexion = AbrirConexion();
                transaccion = conexion.BeginTransaction();

                accion(conexion, transaccion);

                transaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (transaccion != null)
                {
                    try
                    {
                        transaccion.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        mensajeError = $"Error en Rollback: {exRollback.Message}";
                    }
                }
                mensajeError = $"Error en transacción: {ex.Message}";
                return false;
            }
            finally
            {
                CerrarConexion(conexion);
            }
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Crea un parámetro SQL de forma rápida
        /// </summary>
        public SqlParameter CrearParametro(string nombre, object valor)
        {
            return new SqlParameter(nombre, valor ?? DBNull.Value);
        }

        /// <summary>
        /// Crea múltiples parámetros de forma rápida
        /// </summary>
        public SqlParameter[] CrearParametros(params (string nombre, object valor)[] parametros)
        {
            SqlParameter[] resultado = new SqlParameter[parametros.Length];
            for (int i = 0; i < parametros.Length; i++)
            {
                resultado[i] = CrearParametro(parametros[i].nombre, parametros[i].valor);
            }
            return resultado;
        }

        /// <summary>
        /// Obtiene información del servidor SQL
        /// </summary>
        public string ObtenerVersionServidor()
        {
            try
            {
                object version = EjecutarEscalar("SELECT @@VERSION");
                return version?.ToString() ?? "Desconocida";
            }
            catch
            {
                return "No disponible";
            }
        }

        /// <summary>
        /// Verifica si la base de datos existe
        /// </summary>
        public bool VerificarBaseDatos()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM sys.databases WHERE name = 'ClinicaPro2'";
                object resultado = EjecutarEscalar(query);
                return Convert.ToInt32(resultado) > 0;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}