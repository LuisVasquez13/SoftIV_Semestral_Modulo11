using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Borrador
{ 
        public class ImagenRepository
        {
            private readonly string connectionString;

            public ImagenRepository(string connString)
            {
                connectionString = connString;
            }

            // CREATE - Insertar nuevo estudio de imagen
            public int Insertar(EstudioImagen estudio)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO ESTUDIOS_IMAGEN 
                                (IdPaciente, IdMedico, IdTipoEstudio, FechaHoraEstudio, 
                                 SalaEquipo, RutaArchivoImagen, Observaciones, EstadoEstudio, IdConsultaOrden)
                                VALUES 
                                (@IdPaciente, @IdMedico, @IdTipoEstudio, @FechaHoraEstudio, 
                                 @SalaEquipo, @RutaArchivoImagen, @Observaciones, @EstadoEstudio, @IdConsultaOrden);
                                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPaciente", estudio.IdPaciente);
                        cmd.Parameters.AddWithValue("@IdMedico", estudio.IdMedico);
                        cmd.Parameters.AddWithValue("@IdTipoEstudio", estudio.IdTipoEstudio);
                        cmd.Parameters.AddWithValue("@FechaHoraEstudio", estudio.FechaHoraEstudio);
                        cmd.Parameters.AddWithValue("@SalaEquipo", (object)estudio.SalaEquipo ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@RutaArchivoImagen", (object)estudio.RutaArchivoImagen ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Observaciones", (object)estudio.Observaciones ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@EstadoEstudio", estudio.EstadoEstudio);
                        cmd.Parameters.AddWithValue("@IdConsultaOrden", (object)estudio.IdConsultaOrden ?? DBNull.Value);

                        conn.Open();
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }

            // READ - Obtener todos los estudios
            public List<EstudioImagen> ObtenerTodos()
            {
                List<EstudioImagen> estudios = new List<EstudioImagen>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT e.*, 
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                emp.Nombre + ' ' + emp.Apellido AS NombreMedico,
                                c.NombreEstudio AS TipoEstudio
                                FROM ESTUDIOS_IMAGEN e
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN MEDICOS m ON e.IdMedico = m.IdMedico
                                INNER JOIN EMPLEADOS emp ON m.IdEmpleado = emp.IdEmpleado
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                ORDER BY e.FechaHoraEstudio DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estudios.Add(MapearDesdeReader(reader));
                            }
                        }
                    }
                }
                return estudios;
            }

            // READ - Obtener estudio por ID
            public EstudioImagen ObtenerPorId(int idEstudio)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT e.*, 
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                emp.Nombre + ' ' + emp.Apellido AS NombreMedico,
                                c.NombreEstudio AS TipoEstudio
                                FROM ESTUDIOS_IMAGEN e
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN MEDICOS m ON e.IdMedico = m.IdMedico
                                INNER JOIN EMPLEADOS emp ON m.IdEmpleado = emp.IdEmpleado
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                WHERE e.IdEstudio = @IdEstudio";

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

            // READ - Obtener estudios por paciente
            public List<EstudioImagen> ObtenerPorPaciente(int idPaciente)
            {
                List<EstudioImagen> estudios = new List<EstudioImagen>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT e.*, 
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                emp.Nombre + ' ' + emp.Apellido AS NombreMedico,
                                c.NombreEstudio AS TipoEstudio
                                FROM ESTUDIOS_IMAGEN e
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN MEDICOS m ON e.IdMedico = m.IdMedico
                                INNER JOIN EMPLEADOS emp ON m.IdEmpleado = emp.IdEmpleado
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                WHERE e.IdPaciente = @IdPaciente
                                ORDER BY e.FechaHoraEstudio DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estudios.Add(MapearDesdeReader(reader));
                            }
                        }
                    }
                }
                return estudios;
            }

            // READ - Obtener estudios por estado
            public List<EstudioImagen> ObtenerPorEstado(string estado)
            {
                List<EstudioImagen> estudios = new List<EstudioImagen>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT e.*, 
                                p.Nombre + ' ' + p.Apellido AS NombrePaciente,
                                emp.Nombre + ' ' + emp.Apellido AS NombreMedico,
                                c.NombreEstudio AS TipoEstudio
                                FROM ESTUDIOS_IMAGEN e
                                INNER JOIN PACIENTES p ON e.IdPaciente = p.IdPaciente
                                INNER JOIN MEDICOS m ON e.IdMedico = m.IdMedico
                                INNER JOIN EMPLEADOS emp ON m.IdEmpleado = emp.IdEmpleado
                                INNER JOIN CAT_ESTUDIOS_IMAGEN c ON e.IdTipoEstudio = c.IdTipoEstudio
                                WHERE e.EstadoEstudio = @EstadoEstudio
                                ORDER BY e.FechaHoraEstudio DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EstadoEstudio", estado);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estudios.Add(MapearDesdeReader(reader));
                            }
                        }
                    }
                }
                return estudios;
            }

            // UPDATE - Actualizar estudio existente
            public bool Actualizar(EstudioImagen estudio)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE ESTUDIOS_IMAGEN 
                                SET IdPaciente = @IdPaciente,
                                    IdMedico = @IdMedico,
                                    IdTipoEstudio = @IdTipoEstudio,
                                    FechaHoraEstudio = @FechaHoraEstudio,
                                    SalaEquipo = @SalaEquipo,
                                    RutaArchivoImagen = @RutaArchivoImagen,
                                    Observaciones = @Observaciones,
                                    EstadoEstudio = @EstadoEstudio,
                                    IdConsultaOrden = @IdConsultaOrden
                                WHERE IdEstudio = @IdEstudio";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEstudio", estudio.IdEstudio);
                        cmd.Parameters.AddWithValue("@IdPaciente", estudio.IdPaciente);
                        cmd.Parameters.AddWithValue("@IdMedico", estudio.IdMedico);
                        cmd.Parameters.AddWithValue("@IdTipoEstudio", estudio.IdTipoEstudio);
                        cmd.Parameters.AddWithValue("@FechaHoraEstudio", estudio.FechaHoraEstudio);
                        cmd.Parameters.AddWithValue("@SalaEquipo", (object)estudio.SalaEquipo ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@RutaArchivoImagen", (object)estudio.RutaArchivoImagen ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Observaciones", (object)estudio.Observaciones ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@EstadoEstudio", estudio.EstadoEstudio);
                        cmd.Parameters.AddWithValue("@IdConsultaOrden", (object)estudio.IdConsultaOrden ?? DBNull.Value);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            // UPDATE - Actualizar solo el estado
            public bool ActualizarEstado(int idEstudio, string nuevoEstado)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE ESTUDIOS_IMAGEN 
                                SET EstadoEstudio = @EstadoEstudio
                                WHERE IdEstudio = @IdEstudio";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEstudio", idEstudio);
                        cmd.Parameters.AddWithValue("@EstadoEstudio", nuevoEstado);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            // DELETE - Eliminar estudio (validar que no tenga informe asociado)
            public bool Eliminar(int idEstudio)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Primero verificar si tiene informe asociado
                    string queryVerificar = @"SELECT COUNT(*) FROM INFORMES_RADIOLOGICOS WHERE IdEstudio = @IdEstudio";

                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@IdEstudio", idEstudio);
                        conn.Open();

                        int tieneInforme = (int)cmdVerificar.ExecuteScalar();
                        if (tieneInforme > 0)
                        {
                            throw new InvalidOperationException("No se puede eliminar el estudio porque tiene un informe radiológico asociado.");
                        }
                    }

                    // Si no tiene informe, proceder con la eliminación
                    string query = "DELETE FROM ESTUDIOS_IMAGEN WHERE IdEstudio = @IdEstudio";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEstudio", idEstudio);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            // Método auxiliar para mapear desde SqlDataReader
            private EstudioImagen MapearDesdeReader(SqlDataReader reader)
            {
                return new EstudioImagen
                {
                    IdEstudio = reader.GetInt32(reader.GetOrdinal("IdEstudio")),
                    IdPaciente = reader.GetInt32(reader.GetOrdinal("IdPaciente")),
                    IdMedico = reader.GetInt32(reader.GetOrdinal("IdMedico")),
                    IdTipoEstudio = reader.GetInt32(reader.GetOrdinal("IdTipoEstudio")),
                    FechaHoraEstudio = reader.GetDateTime(reader.GetOrdinal("FechaHoraEstudio")),
                    SalaEquipo = reader.IsDBNull(reader.GetOrdinal("SalaEquipo")) ? null : reader.GetString(reader.GetOrdinal("SalaEquipo")),
                    RutaArchivoImagen = reader.IsDBNull(reader.GetOrdinal("RutaArchivoImagen")) ? null : reader.GetString(reader.GetOrdinal("RutaArchivoImagen")),
                    Observaciones = reader.IsDBNull(reader.GetOrdinal("Observaciones")) ? null : reader.GetString(reader.GetOrdinal("Observaciones")),
                    EstadoEstudio = reader.GetString(reader.GetOrdinal("EstadoEstudio")),
                    IdConsultaOrden = reader.IsDBNull(reader.GetOrdinal("IdConsultaOrden")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("IdConsultaOrden")),

                    // Propiedades adicionales para mostrar
                    NombrePaciente = reader.GetString(reader.GetOrdinal("NombrePaciente")),
                    NombreMedico = reader.GetString(reader.GetOrdinal("NombreMedico")),
                    TipoEstudio = reader.GetString(reader.GetOrdinal("TipoEstudio"))
                };
            }
        }

        // Clase modelo para Estudio de Imagen
        public class EstudioImagen
        {
            public int IdEstudio { get; set; }
            public int IdPaciente { get; set; }
            public int IdMedico { get; set; }
            public int IdTipoEstudio { get; set; }
            public DateTime FechaHoraEstudio { get; set; }
            public string SalaEquipo { get; set; }
            public string RutaArchivoImagen { get; set; }
            public string Observaciones { get; set; }
            public string EstadoEstudio { get; set; } // Pendiente, Realizado, Informado
            public int? IdConsultaOrden { get; set; }

            // Propiedades adicionales para visualización
            public string NombrePaciente { get; set; }
            public string NombreMedico { get; set; }
            public string TipoEstudio { get; set; }
        }
    }