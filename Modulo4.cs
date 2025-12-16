using Borrador.DBRepository;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Borrador
{
    public partial class Modulo4 : UserControl
    {
        private readonly string connectionString =
                    "Data Source=hospitalserver.database.windows.net;" +
                    "Initial Catalog=BD-Hospital;" +
                    "User ID=SuperAdmin;" +
                    "Password=Hospital.123;" +
                    "Integrated Security=False;" +
                    "MultipleActiveResultSets=True;" +
                    "Connect Timeout=30;" +
                    "Encrypt=True;" +
                    "TrustServerCertificate=False;";
        private readonly EnfermeriaRepository repository;

        public Modulo4()
        {
            InitializeComponent();
            repository = new EnfermeriaRepository(connectionString);
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            CargarCombos();
            ConfigurarGrids();
        }

        // ======================================================
        // CARGA INICIAL
        // ======================================================

        private void CargarCombos()
        {
            try
            {
                // Cargar turnos
                cmbTurno_Enf.Items.AddRange(new[] { "Mañana", "Tarde", "Noche" });

                // Cargar pacientes usando el SP
                DataTable dtPacientes = repository.ObtenerPacientes();

                cmbPaciente_Enf.DataSource = dtPacientes.Copy();
                cmbPaciente_Enf.DisplayMember = "NombreCompleto";
                cmbPaciente_Enf.ValueMember = "IdPaciente";
                cmbPaciente_Enf.SelectedIndex = -1;

                cmbPaciente_Med.DataSource = dtPacientes.Copy();
                cmbPaciente_Med.DisplayMember = "NombreCompleto";
                cmbPaciente_Med.ValueMember = "IdPaciente";
                cmbPaciente_Med.SelectedIndex = -1;

                // Cargar enfermeros usando el SP
                DataTable dtEnfermeros = repository.ObtenerEnfermeros();

                cmbEnfermero_Enf.DataSource = dtEnfermeros.Copy();
                cmbEnfermero_Enf.DisplayMember = "NombreCompleto";
                cmbEnfermero_Enf.ValueMember = "IdEmpleado";
                cmbEnfermero_Enf.SelectedIndex = -1;

                cmbResponsable_Med.DataSource = dtEnfermeros.Copy();
                cmbResponsable_Med.DisplayMember = "NombreCompleto";
                cmbResponsable_Med.ValueMember = "IdEmpleado";
                cmbResponsable_Med.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrids()
        {
            // Intervenciones
            dgvIntervenciones_Enf.Columns.Clear();
            dgvIntervenciones_Enf.Columns.Add("Hora", "Hora");
            dgvIntervenciones_Enf.Columns.Add("Intervencion", "Intervención");
            dgvIntervenciones_Enf.Columns.Add("Firma", "Firma");
            dgvIntervenciones_Enf.Columns["Intervencion"].Width = 300;

            // Signos vitales
            dgvSignosVitales_Enf.Columns.Clear();
            dgvSignosVitales_Enf.Columns.Add("Hora", "Hora");
            dgvSignosVitales_Enf.Columns.Add("TA", "TA (mmHg)");
            dgvSignosVitales_Enf.Columns.Add("Temp", "Temp (°C)");
            dgvSignosVitales_Enf.Columns.Add("FC", "FC (lpm)");
            dgvSignosVitales_Enf.Columns.Add("FR", "FR (rpm)");

            // Medicamentos prescritos
            dgvMedicamentosPrescritos_Med.Columns.Clear();
            dgvMedicamentosPrescritos_Med.Columns.Add("Medicamento", "Medicamento");
            dgvMedicamentosPrescritos_Med.Columns.Add("Dosis", "Dosis");
            dgvMedicamentosPrescritos_Med.Columns.Add("Via", "Vía");
            dgvMedicamentosPrescritos_Med.Columns.Add("Frecuencia", "Frecuencia");
            dgvMedicamentosPrescritos_Med.Columns.Add("Hora", "Hora");
            dgvMedicamentosPrescritos_Med.Columns["Medicamento"].Width = 200;
        }

        // ======================================================
        // EVENTOS ENFERMERÍA
        // ======================================================

        private void btnAgregarIntervencion_Enf_Click(object sender, EventArgs e)
        {
            if (cmbEnfermero_Enf.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un enfermero responsable", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvIntervenciones_Enf.Rows.Add(
                DateTime.Now.ToString("HH:mm"),
                "",
                cmbEnfermero_Enf.Text
            );
        }

        private void btnAgregarSignos_Enf_Click(object sender, EventArgs e)
        {
            dgvSignosVitales_Enf.Rows.Add(
                DateTime.Now.ToString("HH:mm"), "", "", "", ""
            );
        }

        private void btnGuardar_Enf_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosEnfermeria())
                return;

            try
            {
                int idPaciente = Convert.ToInt32(cmbPaciente_Enf.SelectedValue);
                int idEnfermero = Convert.ToInt32(cmbEnfermero_Enf.SelectedValue);

                // Guardar hoja de enfermería usando el SP
                int idHoja = repository.GuardarHojaEnfermeria(
                    idPaciente,
                    idEnfermero,
                    dtpFecha_Enf.Value,
                    cmbTurno_Enf.Text,
                    txtObservaciones_Enf.Text
                );

                // Guardar signos vitales usando el SP
                int signosGuardados = 0;
                foreach (DataGridViewRow row in dgvSignosVitales_Enf.Rows)
                {
                    if (row.IsNewRow) continue;

                    string horaStr = row.Cells["Hora"].Value?.ToString();
                    if (string.IsNullOrEmpty(horaStr)) continue;

                    TimeSpan hora;
                    if (!TimeSpan.TryParse(horaStr, out hora))
                    {
                        MessageBox.Show($"Formato de hora inválido: {horaStr}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    string ta = row.Cells["TA"].Value?.ToString();
                    int? fc = ParseIntOrNull(row.Cells["FC"].Value);
                    int? fr = ParseIntOrNull(row.Cells["FR"].Value);
                    decimal? temp = ParseDecimalOrNull(row.Cells["Temp"].Value);

                    repository.InsertarSignosVitales(idHoja, hora, ta, fc, fr, temp);
                    signosGuardados++;
                }

                string mensaje = $"Hoja de enfermería guardada correctamente.\n" +
                                $"ID Hoja: {idHoja}\n" +
                                $"Signos vitales registrados: {signosGuardados}";

                MessageBox.Show(mensaje, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarEnfermeria();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}\n\nDetalles: {ex.StackTrace}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosEnfermeria()
        {
            if (cmbPaciente_Enf.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un paciente", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaciente_Enf.Focus();
                return false;
            }

            if (cmbEnfermero_Enf.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un enfermero responsable", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEnfermero_Enf.Focus();
                return false;
            }

            if (cmbTurno_Enf.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el turno", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTurno_Enf.Focus();
                return false;
            }

            // Validar que haya al menos un registro de signos vitales con datos
            bool haySignosVitales = false;
            foreach (DataGridViewRow row in dgvSignosVitales_Enf.Rows)
            {
                if (!row.IsNewRow && row.Cells["Hora"].Value != null)
                {
                    haySignosVitales = true;
                    break;
                }
            }

            if (!haySignosVitales)
            {
                var result = MessageBox.Show(
                    "No hay signos vitales registrados. ¿Desea continuar sin registrar signos vitales?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                return result == DialogResult.Yes;
            }

            return true;
        }

        private void LimpiarEnfermeria()
        {
            cmbPaciente_Enf.SelectedIndex = -1;
            cmbEnfermero_Enf.SelectedIndex = -1;
            cmbTurno_Enf.SelectedIndex = -1;
            txtObservaciones_Enf.Clear();
            dgvIntervenciones_Enf.Rows.Clear();
            dgvSignosVitales_Enf.Rows.Clear();
            dtpFecha_Enf.Value = DateTime.Now;
        }

        private void btnIrAMedicamentos_Click(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedIndex = 1;
        }

        private void btnImprimir_Enf_Click(object sender, EventArgs e)
        {
            if (cmbPaciente_Enf.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un paciente antes de imprimir",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTurno_Enf.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el turno antes de imprimir",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PdfEnfermeria.Generar(
                cmbPaciente_Enf.Text,          // Nombre del paciente
                dtpFecha_Enf.Value,            // Fecha
                cmbTurno_Enf.Text,             // Turno
                dgvIntervenciones_Enf,         // Intervenciones
                dgvSignosVitales_Enf,          // Signos vitales
                txtObservaciones_Enf.Text      // Observaciones
            );
        }

        // ======================================================
        // MEDICAMENTOS
        // ======================================================

        private void cmbPaciente_Med_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaciente_Med.SelectedIndex == -1)
            {
                cmbPrescripcion_Med.DataSource = null;
                dgvMedicamentosPrescritos_Med.Rows.Clear();
                return;
            }

            try
            {
                int idPaciente = Convert.ToInt32(cmbPaciente_Med.SelectedValue);

                // Cargar prescripciones usando el SP
                DataTable dtPrescripciones = repository.ObtenerPrescripcionesPaciente(idPaciente);

                if (dtPrescripciones.Rows.Count == 0)
                {
                    MessageBox.Show("Este paciente no tiene prescripciones activas", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPrescripcion_Med.DataSource = null;
                    return;
                }

                cmbPrescripcion_Med.DataSource = dtPrescripciones;
                cmbPrescripcion_Med.DisplayMember = "DescripcionPrescripcion";
                cmbPrescripcion_Med.ValueMember = "IdPrescripcion";
                cmbPrescripcion_Med.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar prescripciones: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPrescripcion_Med_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrescripcion_Med.SelectedIndex == -1)
            {
                dgvMedicamentosPrescritos_Med.Rows.Clear();
                return;
            }

            try
            {
                int idPrescripcion = Convert.ToInt32(cmbPrescripcion_Med.SelectedValue);

                // Cargar detalle de prescripción usando el SP
                DataTable dtDetalle = repository.ObtenerDetallePrescripcion(idPrescripcion);

                dgvMedicamentosPrescritos_Med.Rows.Clear();

                foreach (DataRow row in dtDetalle.Rows)
                {
                    dgvMedicamentosPrescritos_Med.Rows.Add(
                        row["Medicamento"],
                        row["Dosis"],
                        row["Via"],
                        row["Frecuencia"],
                        row["Hora"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalle de prescripción: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Med_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosMedicamentos())
                return;

            try
            {
                int idPaciente = Convert.ToInt32(cmbPaciente_Med.SelectedValue);
                int idPrescripcion = Convert.ToInt32(cmbPrescripcion_Med.SelectedValue);
                int idResponsable = Convert.ToInt32(cmbResponsable_Med.SelectedValue);

                // Guardar administración usando el SP
                repository.GuardarAdministracionMedicamento(
                    idPaciente,
                    idPrescripcion,
                    idResponsable,
                    dtpHoraAdministracion_Med.Value,
                    chkAdministrado_Med.Checked,
                    txtObservaciones_Med.Text
                );

                string mensaje = chkAdministrado_Med.Checked
                    ? "Administración de medicamento registrada correctamente"
                    : "Se registró que el medicamento NO fue administrado";

                MessageBox.Show(mensaje, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarMedicamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar administración: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosMedicamentos()
        {
            if (cmbPaciente_Med.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un paciente", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaciente_Med.Focus();
                return false;
            }

            if (cmbPrescripcion_Med.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una prescripción", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPrescripcion_Med.Focus();
                return false;
            }

            if (cmbResponsable_Med.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el responsable", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbResponsable_Med.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarMedicamentos()
        {
            cmbPaciente_Med.SelectedIndex = -1;
            cmbPrescripcion_Med.SelectedIndex = -1;
            cmbResponsable_Med.SelectedIndex = -1;
            chkAdministrado_Med.Checked = false;
            txtObservaciones_Med.Clear();
            dgvMedicamentosPrescritos_Med.Rows.Clear();
            dtpHoraAdministracion_Med.Value = DateTime.Now;
        }

        private void btnCancelar_Med_Click(object sender, EventArgs e)
        {
            LimpiarMedicamentos();
            tabControlPrincipal.SelectedIndex = 0;
        }

        private void btnHistorial_Med_Click(object sender, EventArgs e)
        {
            if (cmbPaciente_Med.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un paciente para ver su historial", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idPaciente = Convert.ToInt32(cmbPaciente_Med.SelectedValue);

                // Obtener historial de los últimos 7 días
                DataTable dtHistorial = repository.ObtenerHistorialAdministracion(idPaciente);

                if (dtHistorial.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros de administración para este paciente en los últimos 7 días",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mostrar historial en un formulario o MessageBox simple
                string historial = "HISTORIAL DE ADMINISTRACIÓN DE MEDICAMENTOS\n" +
                                  "==========================================\n\n";

                foreach (DataRow row in dtHistorial.Rows)
                {
                    historial += $"Fecha/Hora: {row["HoraAdministracion"]}\n";
                    historial += $"Medicamento: {row["Medicamento"]}\n";
                    historial += $"Dosis: {row["Dosis"]}\n";
                    historial += $"Responsable: {row["Responsable"]}\n";
                    historial += $"Estado: {row["Estado"]}\n";
                    if (!string.IsNullOrEmpty(row["Observaciones"].ToString()))
                        historial += $"Observaciones: {row["Observaciones"]}\n";
                    historial += "\n";
                }

                MessageBox.Show(historial, "Historial de Medicamentos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener historial: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPageEnfermeria_Click(object sender, EventArgs e) { }

        // ======================================================
        // MÉTODOS AUXILIARES
        // ======================================================

        private int? ParseIntOrNull(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return null;

            int result;
            if (int.TryParse(value.ToString(), out result))
                return result;

            return null;
        }

        private decimal? ParseDecimalOrNull(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return null;

            decimal result;
            if (decimal.TryParse(value.ToString(), out result))
                return result;

            return null;
        }
    }
}