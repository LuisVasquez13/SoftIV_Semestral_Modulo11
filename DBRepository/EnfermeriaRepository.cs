using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Borrador.DBRepository
{
    public class EnfermeriaRepository
    {
        private readonly string connectionString;

        public EnfermeriaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        #region Hoja de Enfermería

        /// <summary>
        /// Guarda una nueva hoja de enfermería y devuelve el ID generado
        /// </summary>
        public int GuardarHojaEnfermeria(int idPaciente, int idEmpleadoEnfermero,
            DateTime fecha, string turno, string observaciones)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_GuardarHoja", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@IdEmpleadoEnfermero", idEmpleadoEnfermero);
                    cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
                    cmd.Parameters.AddWithValue("@Turno", turno);
                    cmd.Parameters.AddWithValue("@ObservacionesTurno",
                        string.IsNullOrEmpty(observaciones) ? (object)DBNull.Value : observaciones);

                    cn.Open();
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        /// <summary>
        /// Inserta un registro de signos vitales
        /// </summary>
        public void InsertarSignosVitales(int idHojaEnf, TimeSpan hora, string ta,
            int? fc, int? fr, decimal? temp)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_InsertSignosVitales", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdHojaEnf", idHojaEnf);
                    cmd.Parameters.AddWithValue("@Hora", hora);
                    cmd.Parameters.AddWithValue("@TA", string.IsNullOrEmpty(ta) ? (object)DBNull.Value : ta);
                    cmd.Parameters.AddWithValue("@FC", fc.HasValue ? (object)fc.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@FR", fr.HasValue ? (object)fr.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Temp", temp.HasValue ? (object)temp.Value : DBNull.Value);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Obtiene las hojas de enfermería de un paciente
        /// </summary>
        public DataTable ObtenerHojasEnfermeriaPaciente(int idPaciente)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_ObtenerHojasEnfermeriaPaciente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Obtiene los signos vitales de una hoja de enfermería
        /// </summary>
        public DataTable ObtenerSignosVitalesHoja(int idHojaEnf)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_ObtenerSignosVitalesHoja", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdHojaEnf", idHojaEnf);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        #endregion

        #region Administración de Medicamentos

        /// <summary>
        /// Guarda un registro de administración de medicamento
        /// </summary>
        public void GuardarAdministracionMedicamento(int idPaciente, int idPrescripcion,
            int idEmpleadoResponsable, DateTime horaAdministracion,
            bool medicamentoAdministrado, string observaciones)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_GuardarAdminMedicamento", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@IdPrescripcion", idPrescripcion);
                    cmd.Parameters.AddWithValue("@IdEmpleadoResponsable", idEmpleadoResponsable);
                    cmd.Parameters.AddWithValue("@HoraAdministracion", horaAdministracion);
                    cmd.Parameters.AddWithValue("@MedicamentoAdministrado", medicamentoAdministrado);
                    cmd.Parameters.AddWithValue("@Observaciones",
                        string.IsNullOrEmpty(observaciones) ? (object)DBNull.Value : observaciones);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Obtiene el historial de administración de medicamentos
        /// </summary>
        public DataTable ObtenerHistorialAdministracion(int idPaciente, DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_ObtenerHistorialAdministracion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@FechaInicio",
                        fechaInicio.HasValue ? (object)fechaInicio.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaFin",
                        fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        #endregion

        #region Consultas de Datos

        /// <summary>
        /// Obtiene la lista de pacientes activos
        /// </summary>
        public DataTable ObtenerPacientes()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_ObtenerPacientes", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Obtiene la lista de enfermeros activos
        /// </summary>
        public DataTable ObtenerEnfermeros()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_ObtenerEnfermeros", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Obtiene las prescripciones activas de un paciente
        /// </summary>
        public DataTable ObtenerPrescripcionesPaciente(int idPaciente)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_ObtenerPrescripcionesPaciente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Obtiene el detalle de una prescripción específica
        /// </summary>
        public DataTable ObtenerDetallePrescripcion(int idPrescripcion)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Enf_ObtenerDetallePrescripcion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPrescripcion", idPrescripcion);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Verifica si un paciente está actualmente hospitalizado
        /// </summary>
        public bool PacienteEstaHospitalizado(int idPaciente)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT COUNT(*)
                    FROM HOSPITALIZACION
                    WHERE IdPaciente = @IdPaciente
                      AND Estado = 'Hospitalizado'", cn))
                {
                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                    cn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Obtiene información básica del paciente
        /// </summary>
        public DataTable ObtenerInfoPaciente(int idPaciente)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        p.IdPaciente,
                        CONCAT(p.Nombre, ' ', p.Apellido) AS NombreCompleto,
                        p.Cedula,
                        p.FechaNacimiento,
                        p.Sexo,
                        p.Telefono,
                        p.Celular,
                        s.NombreSeguro,
                        p.NumeroPoliza
                    FROM PACIENTES p
                    LEFT JOIN CAT_SEGUROS s ON p.IdSeguro = s.IdSeguro
                    WHERE p.IdPaciente = @IdPaciente", cn))
                {
                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        internal DataTable ObtenerMedicamentosPrescripcion(int idPrescripcion)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
