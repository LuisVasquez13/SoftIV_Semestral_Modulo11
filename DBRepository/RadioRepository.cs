using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Borrador
{
    public class RadioRepository
    {
        private readonly string connectionString;

        public RadioRepository(string connString)
        {
            connectionString = connString;
        }

        // CREATE - Insertar nuevo informe radiológico
        public int Insertar(InformeRadiologico informe)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO INFORMES_RADIOLOGICOS 
                                (IdEstudio, IdEmpleadoRadiologo, FechaInforme, 
                                 DescripcionHallazgos, ConclusionDiagnostica, Recomendaciones, EstadoInforme)
                                VALUES 
                                (@IdEstudio, @IdEmpleadoRadiologo, @FechaInforme, 
                                 @DescripcionHallazgos, @ConclusionDiagnostica, @Recomendaciones, @EstadoInforme);
                                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdEstudio", informe.IdEstudio);
                    cmd.Parameters.AddWithValue("@IdEmpleadoRadiologo", informe.IdEmpleadoRadiologo);
                    cmd.Parameters.AddWithValue("@FechaInforme", informe.FechaInforme);
                    cmd.Parameters.AddWithValue("@DescripcionHallazgos", informe.DescripcionHallazgos);
                    cmd.Parameters.AddWithValue("@ConclusionDiagnostica", informe.ConclusionDiagnostica);
                    cmd.Parameters.AddWithValue("@Recomendaciones", (object)informe.Recomendaciones ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstadoInforme", informe.EstadoInforme);

                    conn.Open();
                    int idInforme = (int)cmd.ExecuteScalar();

                    // Actualizar el estado del estudio a "Informado"
                    ActualizarEstadoEstudio(conn, informe.IdEstudio, "Informado");

                    return idInforme;
                }
            }
        }

        // READ - Obtener todos los informes
        public List<InformeRadiologico> ObtenerTodos()
        {
            List<InformeRadiologico> informes = new List<InformeRadiologico>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT i.*, 
                                empRad.Nombre + ' ' + empRad.Apellido AS NombreRadiologo,
                                e.IdPaciente,
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                c.NombreEstudio AS TipoEstudio,
                                e.FechaHoraEstudio
                                FROM INFORMES_RADIOLOGICOS i
                                INNER JOIN EMPLEADOS empRad ON i.IdEmpleadoRadiologo = empRad.IdEmpleado
                                INNER JOIN ESTUDIOS_IMAGEN e ON i.IdEstudio = e.IdEstudio
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                ORDER BY i.FechaInforme DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            informes.Add(MapearDesdeReader(reader));
                        }
                    }
                }
            }
            return informes;
        }

        // READ - Obtener informe por ID
        public InformeRadiologico ObtenerPorId(int idInforme)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT i.*, 
                                empRad.Nombre + ' ' + empRad.Apellido AS NombreRadiologo,
                                e.IdPaciente,
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                c.NombreEstudio AS TipoEstudio,
                                e.FechaHoraEstudio
                                FROM INFORMES_RADIOLOGICOS i
                                INNER JOIN EMPLEADOS empRad ON i.IdEmpleadoRadiologo = empRad.IdEmpleado
                                INNER JOIN ESTUDIOS_IMAGEN e ON i.IdEstudio = e.IdEstudio
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                WHERE i.IdInforme = @IdInforme";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdInforme", idInforme);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapearDesdeReader(reader);
                        }
                    }
                }
            }
            return null;
        }

        // READ - Obtener informe por estudio
        public InformeRadiologico ObtenerPorEstudio(int idEstudio)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT i.*, 
                                empRad.Nombre + ' ' + empRad.Apellido AS NombreRadiologo,
                                e.IdPaciente,
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                c.NombreEstudio AS TipoEstudio,
                                e.FechaHoraEstudio
                                FROM INFORMES_RADIOLOGICOS i
                                INNER JOIN EMPLEADOS empRad ON i.IdEmpleadoRadiologo = empRad.IdEmpleado
                                INNER JOIN ESTUDIOS_IMAGEN e ON i.IdEstudio = e.IdEstudio
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                WHERE i.IdEstudio = @IdEstudio";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdEstudio", idEstudio);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapearDesdeReader(reader);
                        }
                    }
                }
            }
            return null;
        }

        // READ - Obtener informes por paciente
        public List<InformeRadiologico> ObtenerPorPaciente(int idPaciente)
        {
            List<InformeRadiologico> informes = new List<InformeRadiologico>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT i.*, 
                                empRad.Nombre + ' ' + empRad.Apellido AS NombreRadiologo,
                                e.IdPaciente,
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                c.NombreEstudio AS TipoEstudio,
                                e.FechaHoraEstudio
                                FROM INFORMES_RADIOLOGICOS i
                                INNER JOIN EMPLEADOS empRad ON i.IdEmpleadoRadiologo = empRad.IdEmpleado
                                INNER JOIN ESTUDIOS_IMAGEN e ON i.IdEstudio = e.IdEstudio
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                WHERE e.IdPaciente = @IdPaciente
                                ORDER BY i.FechaInforme DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            informes.Add(MapearDesdeReader(reader));
                        }
                    }
                }
            }
            return informes;
        }

        // READ - Obtener informes por estado
        public List<InformeRadiologico> ObtenerPorEstado(string estado)
        {
            List<InformeRadiologico> informes = new List<InformeRadiologico>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT i.*, 
                                empRad.Nombre + ' ' + empRad.Apellido AS NombreRadiologo,
                                e.IdPaciente,
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                c.NombreEstudio AS TipoEstudio,
                                e.FechaHoraEstudio
                                FROM INFORMES_RADIOLOGICOS i
                                INNER JOIN EMPLEADOS empRad ON i.IdEmpleadoRadiologo = empRad.IdEmpleado
                                INNER JOIN ESTUDIOS_IMAGEN e ON i.IdEstudio = e.IdEstudio
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                WHERE i.EstadoInforme = @EstadoInforme
                                ORDER BY i.FechaInforme DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EstadoInforme", estado);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            informes.Add(MapearDesdeReader(reader));
                        }
                    }
                }
            }
            return informes;
        }

        // READ - Obtener informes por radiólogo
        public List<InformeRadiologico> ObtenerPorRadiologo(int idEmpleadoRadiologo)
        {
            List<InformeRadiologico> informes = new List<InformeRadiologico>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT i.*, 
                                empRad.Nombre + ' ' + empRad.Apellido AS NombreRadiologo,
                                e.IdPaciente,
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                c.NombreEstudio AS TipoEstudio,
                                e.FechaHoraEstudio
                                FROM INFORMES_RADIOLOGICOS i
                                INNER JOIN EMPLEADOS empRad ON i.IdEmpleadoRadiologo = empRad.IdEmpleado
                                INNER JOIN ESTUDIOS_IMAGEN e ON i.IdEstudio = e.IdEstudio
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                WHERE i.IdEmpleadoRadiologo = @IdEmpleadoRadiologo
                                ORDER BY i.FechaInforme DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdEmpleadoRadiologo", idEmpleadoRadiologo);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            informes.Add(MapearDesdeReader(reader));
                        }
                    }
                }
            }
            return informes;
        }

        // UPDATE - Actualizar informe existente
        public bool Actualizar(InformeRadiologico informe)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE INFORMES_RADIOLOGICOS 
                                SET IdEstudio = @IdEstudio,
                                    IdEmpleadoRadiologo = @IdEmpleadoRadiologo,
                                    FechaInforme = @FechaInforme,
                                    DescripcionHallazgos = @DescripcionHallazgos,
                                    ConclusionDiagnostica = @ConclusionDiagnostica,
                                    Recomendaciones = @Recomendaciones,
                                    EstadoInforme = @EstadoInforme
                                WHERE IdInforme = @IdInforme";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdInforme", informe.IdInforme);
                    cmd.Parameters.AddWithValue("@IdEstudio", informe.IdEstudio);
                    cmd.Parameters.AddWithValue("@IdEmpleadoRadiologo", informe.IdEmpleadoRadiologo);
                    cmd.Parameters.AddWithValue("@FechaInforme", informe.FechaInforme);
                    cmd.Parameters.AddWithValue("@DescripcionHallazgos", informe.DescripcionHallazgos);
                    cmd.Parameters.AddWithValue("@ConclusionDiagnostica", informe.ConclusionDiagnostica);
                    cmd.Parameters.AddWithValue("@Recomendaciones", (object)informe.Recomendaciones ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstadoInforme", informe.EstadoInforme);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // UPDATE - Actualizar solo el estado
        public bool ActualizarEstado(int idInforme, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE INFORMES_RADIOLOGICOS 
                                SET EstadoInforme = @EstadoInforme
                                WHERE IdInforme = @IdInforme";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdInforme", idInforme);
                    cmd.Parameters.AddWithValue("@EstadoInforme", nuevoEstado);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // DELETE - Eliminar informe
        public bool Eliminar(int idInforme)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Obtener el IdEstudio antes de eliminar para actualizar su estado
                string queryEstudio = "SELECT IdEstudio FROM INFORMES_RADIOLOGICOS WHERE IdInforme = @IdInforme";
                int idEstudio = 0;

                using (SqlCommand cmdEstudio = new SqlCommand(queryEstudio, conn))
                {
                    cmdEstudio.Parameters.AddWithValue("@IdInforme", idInforme);
                    conn.Open();
                    object result = cmdEstudio.ExecuteScalar();
                    if (result != null)
                    {
                        idEstudio = (int)result;
                    }
                }

                // Eliminar el informe
                string query = "DELETE FROM INFORMES_RADIOLOGICOS WHERE IdInforme = @IdInforme";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdInforme", idInforme);
                    bool eliminado = cmd.ExecuteNonQuery() > 0;

                    // Si se eliminó el informe, actualizar el estado del estudio a "Realizado"
                    if (eliminado && idEstudio > 0)
                    {
                        ActualizarEstadoEstudio(conn, idEstudio, "Realizado");
                    }

                    return eliminado;
                }
            }
        }

        // Método auxiliar para actualizar el estado del estudio
        private void ActualizarEstadoEstudio(SqlConnection conn, int idEstudio, string nuevoEstado)
        {
            string query = "UPDATE ESTUDIOS_IMAGEN SET EstadoEstudio = @EstadoEstudio WHERE IdEstudio = @IdEstudio";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdEstudio", idEstudio);
                cmd.Parameters.AddWithValue("@EstadoEstudio", nuevoEstado);
                cmd.ExecuteNonQuery();
            }
        }

        // Método auxiliar para mapear desde SqlDataReader
        private InformeRadiologico MapearDesdeReader(SqlDataReader reader)
        {
            return new InformeRadiologico
            {
                IdInforme = reader.GetInt32(reader.GetOrdinal("IdInforme")),
                IdEstudio = reader.GetInt32(reader.GetOrdinal("IdEstudio")),
                IdEmpleadoRadiologo = reader.GetInt32(reader.GetOrdinal("IdEmpleadoRadiologo")),
                FechaInforme = reader.GetDateTime(reader.GetOrdinal("FechaInforme")),
                DescripcionHallazgos = reader.GetString(reader.GetOrdinal("DescripcionHallazgos")),
                ConclusionDiagnostica = reader.GetString(reader.GetOrdinal("ConclusionDiagnostica")),
                Recomendaciones = reader.IsDBNull(reader.GetOrdinal("Recomendaciones")) ? null : reader.GetString(reader.GetOrdinal("Recomendaciones")),
                EstadoInforme = reader.GetString(reader.GetOrdinal("EstadoInforme")),

                // Propiedades adicionales para mostrar
                NombreRadiologo = reader.GetString(reader.GetOrdinal("NombreRadiologo")),
                IdPaciente = reader.GetInt32(reader.GetOrdinal("IdPaciente")),
                NombrePaciente = reader.GetString(reader.GetOrdinal("NombrePaciente")),
                TipoEstudio = reader.GetString(reader.GetOrdinal("TipoEstudio")),
                FechaHoraEstudio = reader.GetDateTime(reader.GetOrdinal("FechaHoraEstudio"))
            };
        }
    }

    // Clase modelo para Informe Radiológico
    public class InformeRadiologico
    {
        public int IdInforme { get; set; }
        public int IdEstudio { get; set; }
        public int IdEmpleadoRadiologo { get; set; }
        public DateTime FechaInforme { get; set; }
        public string DescripcionHallazgos { get; set; }
        public string ConclusionDiagnostica { get; set; }
        public string Recomendaciones { get; set; }
        public string EstadoInforme { get; set; } // Borrador, Final

        // Propiedades adicionales para visualización
        public string NombreRadiologo { get; set; }
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string TipoEstudio { get; set; }
        public DateTime FechaHoraEstudio { get; set; }
    }
}