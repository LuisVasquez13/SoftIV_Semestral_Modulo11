using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Borrador
{
    public class CirugiaRepository
    {
        public CirugiaRepository()
        {
        }

        #region Métodos para Agenda de Cirugías

        public DataTable ObtenerCirugiasAgenda()
        {
            string query = @"
                SELECT 
                    c.IdCirugia,
                    c.IdPaciente,
                    CONCAT(p.Nombre, ' ', p.Apellido) AS NombrePaciente,
                    c.IdCirujano,
                    CONCAT(e.Nombre, ' ', e.Apellido) AS NombreCirujano,
                    c.FechaHoraInicio,
                    c.TipoCirugia,
                    c.DiagnosticoPreoperatorio,
                    c.Prioridad,
                    c.EstadoProgramacion,
                    s.NombreSala
                FROM CIRUGIAS c
                INNER JOIN PACIENTES p ON c.IdPaciente = p.IdPaciente
                INNER JOIN MEDICOS m ON c.IdCirujano = m.IdMedico
                INNER JOIN EMPLEADOS e ON m.IdEmpleado = e.IdEmpleado
                LEFT JOIN CAT_SALAS_QUIROFANO s ON c.IdSalaQuirofano = s.IdSalaQuirofano
                ORDER BY c.FechaHoraInicio DESC";

            return ConexionDB.Instancia.EjecutarConsulta(query);
        }

        public DataTable ObtenerPacientes()
        {
            string query = @"
                SELECT 
                    IdPaciente,
                    CONCAT(Cedula, ' - ', Nombre, ' ', Apellido) AS Display,
                    Cedula,
                    Nombre,
                    Apellido
                FROM PACIENTES
                WHERE EstadoPaciente = 'Activo'
                ORDER BY Apellido, Nombre";

            return ConexionDB.Instancia.EjecutarConsulta(query);
        }

        public DataTable ObtenerCirujanos()
        {
            string query = @"
                SELECT 
                    m.IdMedico,
                    CONCAT(e.Nombre, ' ', e.Apellido, ' - ', esp.NombreEspecialidad) AS Display,
                    e.Nombre,
                    e.Apellido
                FROM MEDICOS m
                INNER JOIN EMPLEADOS e ON m.IdEmpleado = e.IdEmpleado
                LEFT JOIN CAT_ESPECIALIDADES esp ON m.IdEspecialidad = esp.IdEspecialidad
                WHERE e.TipoEmpleado = 'Médico'
                ORDER BY e.Apellido, e.Nombre";

            return ConexionDB.Instancia.EjecutarConsulta(query);
        }

        public DataTable ObtenerTiposCirugia()
        {
            string query = @"
                SELECT DISTINCT TipoCirugia
                FROM CIRUGIAS
                WHERE TipoCirugia IS NOT NULL
                UNION
                SELECT 'Apendicectomía' AS TipoCirugia
                UNION SELECT 'Colecistectomía laparoscópica'
                UNION SELECT 'Hernioplastia inguinal'
                UNION SELECT 'Cesárea'
                UNION SELECT 'Amigdalectomía'
                UNION SELECT 'Colecistectomía'
                UNION SELECT 'Laparotomía exploratoria'
                ORDER BY TipoCirugia";

            return ConexionDB.Instancia.EjecutarConsulta(query);
        }

        public DataTable ObtenerSalasQuirurgicas()
        {
            string query = @"
                SELECT 
                    IdSalaQuirofano, 
                    NombreSala, 
                    Estado
                FROM CAT_SALAS_QUIROFANO
                WHERE Estado IN ('Disponible', 'En uso')
                ORDER BY NombreSala";

            return ConexionDB.Instancia.EjecutarConsulta(query);
        }

        /// <summary>
        /// ⚠️ CORREGIDO: Ahora maneja correctamente INSERT y UPDATE
        /// </summary>
        public int GuardarCirugia(CirugiaDTO cirugia)
        {
            int resultado = 0;
            string mensajeError;

            bool exito = ConexionDB.Instancia.EjecutarTransaccion((conn, trans) =>
            {
                string query;

                if (cirugia.IdCirugia == 0)
                {
                    // ✅ INSERT - Nueva cirugía
                    query = @"
                        INSERT INTO CIRUGIAS 
                        (IdPaciente, IdCirujano, TipoCirugia, DiagnosticoPreoperatorio, 
                         IdSalaQuirofano, FechaHoraInicio, DuracionEstimada, Prioridad, 
                         EstadoProgramacion, Observaciones)
                        VALUES 
                        (@IdPaciente, @IdCirujano, @TipoCirugia, @DiagnosticoPreoperatorio,
                         @IdSalaQuirofano, @FechaHoraInicio, @DuracionEstimada, @Prioridad,
                         @EstadoProgramacion, @Observaciones);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                }
                else
                {
                    // ✅ UPDATE - Actualizar cirugía existente
                    query = @"
                        UPDATE CIRUGIAS
                        SET IdPaciente = @IdPaciente,
                            IdCirujano = @IdCirujano,
                            TipoCirugia = @TipoCirugia,
                            DiagnosticoPreoperatorio = @DiagnosticoPreoperatorio,
                            IdSalaQuirofano = @IdSalaQuirofano,
                            FechaHoraInicio = @FechaHoraInicio,
                            DuracionEstimada = @DuracionEstimada,
                            Prioridad = @Prioridad,
                            EstadoProgramacion = @EstadoProgramacion,
                            Observaciones = @Observaciones
                        WHERE IdCirugia = @IdCirugia;
                        SELECT @IdCirugia;";
                }

                using (var cmd = new SqlCommand(query, conn, trans))
                {
                    // Agregar parámetro IdCirugia solo para UPDATE
                    if (cirugia.IdCirugia > 0)
                        cmd.Parameters.AddWithValue("@IdCirugia", cirugia.IdCirugia);

                    cmd.Parameters.AddWithValue("@IdPaciente", cirugia.IdPaciente);
                    cmd.Parameters.AddWithValue("@IdCirujano", cirugia.IdCirujano);
                    cmd.Parameters.AddWithValue("@TipoCirugia", cirugia.TipoCirugia ?? "");
                    cmd.Parameters.AddWithValue("@DiagnosticoPreoperatorio", cirugia.DiagnosticoPreoperatorio ?? "");
                    cmd.Parameters.AddWithValue("@IdSalaQuirofano", (object)cirugia.IdSalaQuirofano ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaHoraInicio", cirugia.FechaHoraInicio);
                    cmd.Parameters.AddWithValue("@DuracionEstimada", cirugia.DuracionEstimada);
                    cmd.Parameters.AddWithValue("@Prioridad", cirugia.Prioridad ?? "Electiva");
                    cmd.Parameters.AddWithValue("@EstadoProgramacion", cirugia.EstadoProgramacion ?? "Programada");
                    cmd.Parameters.AddWithValue("@Observaciones", (object)cirugia.Observaciones ?? DBNull.Value);

                    var resultObj = cmd.ExecuteScalar();
                    if (resultObj != null && resultObj != DBNull.Value)
                    {
                        resultado = Convert.ToInt32(resultObj);
                    }
                }
            }, out mensajeError);

            if (!exito)
            {
                throw new Exception($"Error al guardar cirugía: {mensajeError}");
            }

            return resultado;
        }

        /// <summary>
        /// ✅ NUEVO: Método para eliminar cirugía
        /// </summary>
        public bool EliminarCirugia(int idCirugia)
        {
            string mensajeError;

            bool exito = ConexionDB.Instancia.EjecutarTransaccion((conn, trans) =>
            {
                // Primero eliminar la nota operatoria si existe
                string queryNota = "DELETE FROM NOTAS_OPERATORIAS WHERE IdCirugia = @IdCirugia";
                using (var cmdNota = new SqlCommand(queryNota, conn, trans))
                {
                    cmdNota.Parameters.AddWithValue("@IdCirugia", idCirugia);
                    cmdNota.ExecuteNonQuery();
                }

                // Luego eliminar la cirugía
                string queryCirugia = "DELETE FROM CIRUGIAS WHERE IdCirugia = @IdCirugia";
                using (var cmdCirugia = new SqlCommand(queryCirugia, conn, trans))
                {
                    cmdCirugia.Parameters.AddWithValue("@IdCirugia", idCirugia);
                    cmdCirugia.ExecuteNonQuery();
                }
            }, out mensajeError);

            if (!exito)
            {
                throw new Exception($"Error al eliminar cirugía: {mensajeError}");
            }

            return exito;
        }

        #endregion

        #region Métodos para Nota Operatoria

        public DataTable ObtenerCirugiasParaNota()
        {
            string query = @"
                SELECT 
                    c.IdCirugia,
                    CONCAT(p.Nombre, ' ', p.Apellido, ' - ', 
                           CONVERT(VARCHAR, c.FechaHoraInicio, 103), ' ', 
                           CONVERT(VARCHAR, c.FechaHoraInicio, 108), ' - ',
                           c.TipoCirugia) AS Display,
                    c.EstadoProgramacion
                FROM CIRUGIAS c
                INNER JOIN PACIENTES p ON c.IdPaciente = p.IdPaciente
                WHERE c.EstadoProgramacion IN ('Programada', 'Reprogramada')
                ORDER BY c.FechaHoraInicio DESC";

            return ConexionDB.Instancia.EjecutarConsulta(query);
        }

        public CirugiaDetalleDTO ObtenerDetalleCirugia(int idCirugia)
        {
            string query = @"
                SELECT 
                    c.IdCirugia,
                    c.IdPaciente,
                    CONCAT(p.Nombre, ' ', p.Apellido) AS NombrePaciente,
                    c.IdCirujano,
                    c.FechaHoraInicio,
                    c.TipoCirugia,
                    c.DiagnosticoPreoperatorio,
                    c.EstadoProgramacion
                FROM CIRUGIAS c
                INNER JOIN PACIENTES p ON c.IdPaciente = p.IdPaciente
                WHERE c.IdCirugia = @IdCirugia";

            SqlParameter[] parametros = { ConexionDB.Instancia.CrearParametro("@IdCirugia", idCirugia) };
            DataTable dt = ConexionDB.Instancia.EjecutarConsulta(query, parametros);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new CirugiaDetalleDTO
                {
                    IdCirugia = Convert.ToInt32(row["IdCirugia"]),
                    IdPaciente = Convert.ToInt32(row["IdPaciente"]),
                    NombrePaciente = row["NombrePaciente"].ToString(),
                    IdCirujano = Convert.ToInt32(row["IdCirujano"]),
                    FechaHoraInicio = Convert.ToDateTime(row["FechaHoraInicio"]),
                    TipoCirugia = row["TipoCirugia"].ToString(),
                    DiagnosticoPreoperatorio = row["DiagnosticoPreoperatorio"].ToString(),
                    EstadoProgramacion = row["EstadoProgramacion"].ToString()
                };
            }
            return null;
        }

        public NotaOperatoriaDTO ObtenerNotaOperatoria(int idCirugia)
        {
            string query = @"
                SELECT 
                    IdNotaOperatoria,
                    IdCirugia,
                    FechaHoraRealInicio,
                    FechaHoraRealFin,
                    DiagnosticoPostoperatorio,
                    TecnicaOperatoria,
                    Hallazgos,
                    Complicaciones,
                    IdEmpleadoRegistra,
                    EstadoNota
                FROM NOTAS_OPERATORIAS
                WHERE IdCirugia = @IdCirugia";

            SqlParameter[] parametros = { ConexionDB.Instancia.CrearParametro("@IdCirugia", idCirugia) };
            DataTable dt = ConexionDB.Instancia.EjecutarConsulta(query, parametros);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new NotaOperatoriaDTO
                {
                    IdNotaOperatoria = Convert.ToInt32(row["IdNotaOperatoria"]),
                    IdCirugia = Convert.ToInt32(row["IdCirugia"]),
                    FechaHoraRealInicio = Convert.ToDateTime(row["FechaHoraRealInicio"]),
                    FechaHoraRealFin = Convert.ToDateTime(row["FechaHoraRealFin"]),
                    DiagnosticoPostoperatorio = row["DiagnosticoPostoperatorio"].ToString(),
                    TecnicaOperatoria = row["TecnicaOperatoria"].ToString(),
                    Hallazgos = row["Hallazgos"].ToString(),
                    Complicaciones = row["Complicaciones"] == DBNull.Value ? null : row["Complicaciones"].ToString(),
                    IdEmpleadoRegistra = Convert.ToInt32(row["IdEmpleadoRegistra"]),
                    EstadoNota = row["EstadoNota"].ToString()
                };
            }
            return null;
        }

        public DataTable ObtenerMaterialesCirugia(int idNotaOperatoria)
        {
            string query = @"
                SELECT 
                    IdMaterialCx,
                    Material,
                    Cantidad,
                    Observacion
                FROM MATERIALES_CIRUGIA
                WHERE IdNotaOperatoria = @IdNotaOperatoria
                ORDER BY IdMaterialCx";

            SqlParameter[] parametros = { ConexionDB.Instancia.CrearParametro("@IdNotaOperatoria", idNotaOperatoria) };
            return ConexionDB.Instancia.EjecutarConsulta(query, parametros);
        }

        public DataTable ObtenerProfesionalesMedicos()
        {
            string query = @"
                SELECT 
                    IdEmpleado,
                    CONCAT(Nombre, ' ', Apellido, ' - ', TipoEmpleado) AS Display,
                    TipoEmpleado
                FROM EMPLEADOS
                WHERE TipoEmpleado IN ('Médico', 'Enfermero')
                ORDER BY TipoEmpleado, Apellido, Nombre";

            return ConexionDB.Instancia.EjecutarConsulta(query);
        }

        /// <summary>
        /// ⚠️ CORREGIDO: Mejor manejo de transacciones
        /// </summary>
        public bool GuardarNotaOperatoria(NotaOperatoriaDTO nota)
        {
            string mensajeError;

            bool exito = ConexionDB.Instancia.EjecutarTransaccion((conn, trans) =>
            {
                int idNotaOperatoria = 0;

                // Verificar si ya existe una nota operatoria
                string queryExiste = "SELECT IdNotaOperatoria FROM NOTAS_OPERATORIAS WHERE IdCirugia = @IdCirugia";
                using (var cmdExiste = new SqlCommand(queryExiste, conn, trans))
                {
                    cmdExiste.Parameters.AddWithValue("@IdCirugia", nota.IdCirugia);
                    var resultado = cmdExiste.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                        idNotaOperatoria = Convert.ToInt32(resultado);
                }

                string query;
                if (idNotaOperatoria == 0)
                {
                    // ✅ INSERT
                    query = @"
                        INSERT INTO NOTAS_OPERATORIAS 
                        (IdCirugia, FechaHoraRealInicio, FechaHoraRealFin, DiagnosticoPostoperatorio,
                         TecnicaOperatoria, Hallazgos, Complicaciones, IdEmpleadoRegistra, EstadoNota)
                        VALUES 
                        (@IdCirugia, @FechaHoraRealInicio, @FechaHoraRealFin, @DiagnosticoPostoperatorio,
                         @TecnicaOperatoria, @Hallazgos, @Complicaciones, @IdEmpleadoRegistra, @EstadoNota);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                }
                else
                {
                    // ✅ UPDATE
                    query = @"
                        UPDATE NOTAS_OPERATORIAS
                        SET FechaHoraRealInicio = @FechaHoraRealInicio,
                            FechaHoraRealFin = @FechaHoraRealFin,
                            DiagnosticoPostoperatorio = @DiagnosticoPostoperatorio,
                            TecnicaOperatoria = @TecnicaOperatoria,
                            Hallazgos = @Hallazgos,
                            Complicaciones = @Complicaciones,
                            IdEmpleadoRegistra = @IdEmpleadoRegistra,
                            EstadoNota = @EstadoNota
                        WHERE IdNotaOperatoria = @IdNotaOperatoria;
                        SELECT @IdNotaOperatoria;";
                }

                using (var cmd = new SqlCommand(query, conn, trans))
                {
                    if (idNotaOperatoria > 0)
                        cmd.Parameters.AddWithValue("@IdNotaOperatoria", idNotaOperatoria);

                    cmd.Parameters.AddWithValue("@IdCirugia", nota.IdCirugia);
                    cmd.Parameters.AddWithValue("@FechaHoraRealInicio", nota.FechaHoraRealInicio);
                    cmd.Parameters.AddWithValue("@FechaHoraRealFin", nota.FechaHoraRealFin);
                    cmd.Parameters.AddWithValue("@DiagnosticoPostoperatorio", nota.DiagnosticoPostoperatorio ?? "");
                    cmd.Parameters.AddWithValue("@TecnicaOperatoria", nota.TecnicaOperatoria ?? "");
                    cmd.Parameters.AddWithValue("@Hallazgos", nota.Hallazgos ?? "");
                    cmd.Parameters.AddWithValue("@Complicaciones", (object)nota.Complicaciones ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdEmpleadoRegistra", nota.IdEmpleadoRegistra);
                    cmd.Parameters.AddWithValue("@EstadoNota", nota.EstadoNota ?? "Borrador");

                    var resultObj = cmd.ExecuteScalar();
                    if (resultObj != null && resultObj != DBNull.Value)
                    {
                        idNotaOperatoria = Convert.ToInt32(resultObj);
                    }
                }

                // Guardar materiales - primero eliminar los existentes
                string queryDeleteMateriales = "DELETE FROM MATERIALES_CIRUGIA WHERE IdNotaOperatoria = @IdNotaOperatoria";
                using (var cmdDelete = new SqlCommand(queryDeleteMateriales, conn, trans))
                {
                    cmdDelete.Parameters.AddWithValue("@IdNotaOperatoria", idNotaOperatoria);
                    cmdDelete.ExecuteNonQuery();
                }

                // Insertar materiales nuevos
                if (nota.Materiales != null && nota.Materiales.Count > 0)
                {
                    string queryMateriales = @"
                        INSERT INTO MATERIALES_CIRUGIA (IdNotaOperatoria, Material, Cantidad, Observacion)
                        VALUES (@IdNotaOperatoria, @Material, @Cantidad, @Observacion)";

                    foreach (var material in nota.Materiales)
                    {
                        using (var cmdMat = new SqlCommand(queryMateriales, conn, trans))
                        {
                            cmdMat.Parameters.AddWithValue("@IdNotaOperatoria", idNotaOperatoria);
                            cmdMat.Parameters.AddWithValue("@Material", material.Material);
                            cmdMat.Parameters.AddWithValue("@Cantidad", material.Cantidad);
                            cmdMat.Parameters.AddWithValue("@Observacion", (object)material.Observacion ?? DBNull.Value);
                            cmdMat.ExecuteNonQuery();
                        }
                    }
                }
            }, out mensajeError);

            if (!exito)
            {
                throw new Exception($"Error al guardar nota operatoria: {mensajeError}");
            }

            return exito;
        }

        #endregion
    }

    #region DTOs

    public class CirugiaDTO
    {
        public int IdCirugia { get; set; }
        public int IdPaciente { get; set; }
        public int IdCirujano { get; set; }
        public string TipoCirugia { get; set; }
        public string DiagnosticoPreoperatorio { get; set; }
        public int? IdSalaQuirofano { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public int DuracionEstimada { get; set; }
        public string Prioridad { get; set; }
        public string EstadoProgramacion { get; set; }
        public string Observaciones { get; set; }
    }

    public class CirugiaDetalleDTO
    {
        public int IdCirugia { get; set; }
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public int IdCirujano { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public string TipoCirugia { get; set; }
        public string DiagnosticoPreoperatorio { get; set; }
        public string EstadoProgramacion { get; set; }
    }

    public class NotaOperatoriaDTO
    {
        public int IdNotaOperatoria { get; set; }
        public int IdCirugia { get; set; }
        public DateTime FechaHoraRealInicio { get; set; }
        public DateTime FechaHoraRealFin { get; set; }
        public string DiagnosticoPostoperatorio { get; set; }
        public string TecnicaOperatoria { get; set; }
        public string Hallazgos { get; set; }
        public string Complicaciones { get; set; }
        public int IdEmpleadoRegistra { get; set; }
        public string EstadoNota { get; set; }
        public List<MaterialCirugiaDTO> Materiales { get; set; }
    }

    public class MaterialCirugiaDTO
    {
        public int IdMaterialCx { get; set; }
        public string Material { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
    }

    #endregion
}