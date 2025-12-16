using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador
{
    public partial class Modulo10 : UserControl
    {
        private readonly CirugiaRepository _repository;
        private int _idCirugiaActual = 0;

        public Modulo10()
        {
            InitializeComponent();
            _repository = new CirugiaRepository();
            ConfigurarEventos();
            CargarDatosIniciales();
        }

        private void ConfigurarEventos()
        {
            // Eventos Tab Agenda
            btnProgramar.Click += BtnProgramar_Click;
            cmbPaciente.SelectedIndexChanged += CmbPaciente_SelectedIndexChanged;

            // Eventos Tab Nota Operatoria
            cmbCirugiaSel.SelectedIndexChanged += CmbCirugiaSel_SelectedIndexChanged;
            btnGuardarNota.Click += BtnGuardarNota_Click;
            btnImprimir.Click += BtnImprimir_Click;
        }

        private void CargarDatosIniciales()
        {
            try
            {
                // Cargar combos Tab Agenda
                CargarPacientes();
                CargarCirujanos();
                CargarTiposCirugia();
                CargarSalasQuirurgicas();

                // Cargar estados
                cmbEstado.Items.Clear();
                cmbEstado.Items.AddRange(new[] { "Programada", "Reprogramada", "Cancelada" });
                cmbEstado.SelectedIndex = 0;

                cmbPrioridad.Items.Clear();
                cmbPrioridad.Items.AddRange(new[] { "Electiva", "Urgente" });
                cmbPrioridad.SelectedIndex = 0;

                // Cargar combos Tab Nota
                CargarCirugiasParaNota();
                CargarProfesionales();

                cmbEstadoNota.Items.Clear();
                cmbEstadoNota.Items.AddRange(new[] { "Borrador", "Final" });
                cmbEstadoNota.SelectedIndex = 0;

                // Configurar DataGridView Materiales
                ConfigurarGridMateriales();

                // Generar ID automático
                GenerarIdCirugia();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos iniciales: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Tab Agenda - Métodos

        private void CargarPacientes()
        {
            try
            {
                // Desconectar evento temporalmente
                cmbPaciente.SelectedIndexChanged -= CmbPaciente_SelectedIndexChanged;

                var dt = _repository.ObtenerPacientes();
                cmbPaciente.DataSource = dt;
                cmbPaciente.DisplayMember = "Display";
                cmbPaciente.ValueMember = "IdPaciente";
                cmbPaciente.SelectedIndex = -1;

                // Reconectar evento
                cmbPaciente.SelectedIndexChanged += CmbPaciente_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}", "Error");
            }
        }

        private void CargarCirujanos()
        {
            try
            {
                var dt = _repository.ObtenerCirujanos();
                cmbCirujano.DataSource = dt;
                cmbCirujano.DisplayMember = "Display";
                cmbCirujano.ValueMember = "IdMedico";
                cmbCirujano.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cirujanos: {ex.Message}", "Error");
            }
        }

        private void CargarTiposCirugia()
        {
            try
            {
                var dt = _repository.ObtenerTiposCirugia();
                cmbTipoCirugia.DataSource = dt;
                cmbTipoCirugia.DisplayMember = "TipoCirugia";
                cmbTipoCirugia.ValueMember = "TipoCirugia";
                cmbTipoCirugia.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de cirugía: {ex.Message}", "Error");
            }
        }

        private void CargarSalasQuirurgicas()
        {
            try
            {
                var dt = _repository.ObtenerSalasQuirurgicas();
                cmbSala.DataSource = dt;
                cmbSala.DisplayMember = "NombreSala";
                cmbSala.ValueMember = "IdSalaQuirofano";
                cmbSala.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar salas: {ex.Message}", "Error");
            }
        }

        private void GenerarIdCirugia()
        {
            txtIdCirugia.Text = _idCirugiaActual == 0 ?
                $"CIR-{DateTime.Now:yyyyMMddHHmmss}" :
                $"CIR-{_idCirugiaActual}";
        }

        private void CmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí podrías cargar información adicional del paciente si lo necesitas
        }

        private void BtnProgramar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatosAgenda())
                    return;

                if (cmbPaciente.SelectedValue == null || cmbCirujano.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un paciente y un cirujano", "Validación");
                    return;
                }

                var cirugia = new CirugiaDTO
                {
                    // ⚠️ CORRECCIÓN CRÍTICA: Ahora sí se usa el ID actual
                    IdCirugia = _idCirugiaActual,
                    IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue),
                    IdCirujano = Convert.ToInt32(cmbCirujano.SelectedValue),
                    TipoCirugia = cmbTipoCirugia.Text,
                    DiagnosticoPreoperatorio = txtDiagPre.Text.Trim(),
                    IdSalaQuirofano = cmbSala.SelectedValue != null ? Convert.ToInt32(cmbSala.SelectedValue) : (int?)null,
                    FechaHoraInicio = dtpFechaInicio.Value,
                    DuracionEstimada = Convert.ToInt32(numDuracion.Value),
                    Prioridad = cmbPrioridad.Text,
                    EstadoProgramacion = cmbEstado.Text,
                    Observaciones = txtObservaciones.Text.Trim()
                };

                int idGuardado = _repository.GuardarCirugia(cirugia);

                if (idGuardado > 0)
                {
                    string mensaje = _idCirugiaActual == 0 ?
                        "Cirugía programada exitosamente" :
                        "Cirugía actualizada exitosamente";

                    MessageBox.Show(mensaje, "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormularioAgenda();
                    GenerarIdCirugia();
                    CargarCirugiasParaNota(); // Actualizar lista en tab Nota
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cirugía", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cirugía: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosAgenda()
        {
            if (cmbPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Validación");
                cmbPaciente.Focus();
                return false;
            }

            if (cmbCirujano.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cirujano", "Validación");
                cmbCirujano.Focus();
                return false;
            }

            if (cmbTipoCirugia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de cirugía", "Validación");
                cmbTipoCirugia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiagPre.Text))
            {
                MessageBox.Show("Debe ingresar el diagnóstico preoperatorio", "Validación");
                txtDiagPre.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarFormularioAgenda()
        {
            _idCirugiaActual = 0;
            cmbPaciente.SelectedIndex = -1;
            cmbCirujano.SelectedIndex = -1;
            cmbTipoCirugia.SelectedIndex = -1;
            cmbSala.SelectedIndex = -1;
            txtEquipo.Clear();
            txtDiagPre.Clear();
            numDuracion.Value = 0;
            cmbPrioridad.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            txtObservaciones.Clear();
            dtpFechaInicio.Value = DateTime.Now;
        }

        #endregion

        #region Tab Nota Operatoria - Métodos

        private void CargarCirugiasParaNota()
        {
            try
            {
                // Desconectar evento temporalmente
                cmbCirugiaSel.SelectedIndexChanged -= CmbCirugiaSel_SelectedIndexChanged;

                var dt = _repository.ObtenerCirugiasParaNota();
                cmbCirugiaSel.DataSource = dt;
                cmbCirugiaSel.DisplayMember = "Display";
                cmbCirugiaSel.ValueMember = "IdCirugia";
                cmbCirugiaSel.SelectedIndex = -1;

                // Reconectar evento
                cmbCirugiaSel.SelectedIndexChanged += CmbCirugiaSel_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cirugías: {ex.Message}", "Error");
            }
        }

        private void CargarProfesionales()
        {
            try
            {
                var dt = _repository.ObtenerProfesionalesMedicos();
                cmbProfesional.DataSource = dt;
                cmbProfesional.DisplayMember = "Display";
                cmbProfesional.ValueMember = "IdEmpleado";
                cmbProfesional.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar profesionales: {ex.Message}", "Error");
            }
        }

        private void ConfigurarGridMateriales()
        {
            dgvMateriales.Columns.Clear();
            dgvMateriales.Columns.Add("Material", "Material");
            dgvMateriales.Columns.Add("Cantidad", "Cantidad");
            dgvMateriales.Columns.Add("Observacion", "Observación");

            dgvMateriales.AllowUserToAddRows = true;
            dgvMateriales.AllowUserToDeleteRows = true;
        }

        private void CmbCirugiaSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCirugiaSel.SelectedValue == null || cmbCirugiaSel.SelectedIndex == -1)
                return;

            try
            {
                int idCirugia = Convert.ToInt32(cmbCirugiaSel.SelectedValue);
                var detalle = _repository.ObtenerDetalleCirugia(idCirugia);

                if (detalle != null)
                {
                    // Cargar datos básicos de la cirugía
                    dtpInicioReal.Value = detalle.FechaHoraInicio;
                    dtpFinReal.Value = detalle.FechaHoraInicio.AddHours(1); // Default: 1 hora después

                    // Cargar nota operatoria si existe
                    var nota = _repository.ObtenerNotaOperatoria(idCirugia);
                    if (nota != null)
                    {
                        dtpInicioReal.Value = nota.FechaHoraRealInicio;
                        dtpFinReal.Value = nota.FechaHoraRealFin;
                        txtDiagPost.Text = nota.DiagnosticoPostoperatorio;
                        rtbTecnica.Text = nota.TecnicaOperatoria;
                        rtbHallazgos.Text = nota.Hallazgos;
                        txtComplicaciones.Text = nota.Complicaciones ?? "";

                        if (nota.IdEmpleadoRegistra > 0)
                            cmbProfesional.SelectedValue = nota.IdEmpleadoRegistra;

                        cmbEstadoNota.Text = nota.EstadoNota;

                        // Cargar materiales
                        CargarMaterialesNota(nota.IdNotaOperatoria);
                    }
                    else
                    {
                        // Limpiar si no hay nota
                        txtDiagPost.Clear();
                        rtbTecnica.Clear();
                        rtbHallazgos.Clear();
                        txtComplicaciones.Clear();
                        dgvMateriales.Rows.Clear();
                        cmbProfesional.SelectedIndex = -1;
                        cmbEstadoNota.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalle: {ex.Message}", "Error");
            }
        }

        private void CargarMaterialesNota(int idNotaOperatoria)
        {
            try
            {
                dgvMateriales.Rows.Clear();
                var materiales = _repository.ObtenerMaterialesCirugia(idNotaOperatoria);

                foreach (DataRow row in materiales.Rows)
                {
                    dgvMateriales.Rows.Add(
                        row["Material"].ToString(),
                        row["Cantidad"].ToString(),
                        row["Observacion"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materiales: {ex.Message}", "Error");
            }
        }

        private void BtnGuardarNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatosNota())
                    return;

                if (cmbCirugiaSel.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una cirugía", "Validación");
                    return;
                }

                var nota = new NotaOperatoriaDTO
                {
                    IdCirugia = Convert.ToInt32(cmbCirugiaSel.SelectedValue),
                    FechaHoraRealInicio = dtpInicioReal.Value,
                    FechaHoraRealFin = dtpFinReal.Value,
                    DiagnosticoPostoperatorio = txtDiagPost.Text.Trim(),
                    TecnicaOperatoria = rtbTecnica.Text.Trim(),
                    Hallazgos = rtbHallazgos.Text.Trim(),
                    Complicaciones = string.IsNullOrWhiteSpace(txtComplicaciones.Text) ?
                        null : txtComplicaciones.Text.Trim(),
                    IdEmpleadoRegistra = cmbProfesional.SelectedValue != null ?
                        Convert.ToInt32(cmbProfesional.SelectedValue) : 0,
                    EstadoNota = cmbEstadoNota.Text
                };

                // Obtener materiales del grid
                nota.Materiales = new List<MaterialCirugiaDTO>();
                foreach (DataGridViewRow row in dgvMateriales.Rows)
                {
                    if (row.IsNewRow) continue;

                    var material = row.Cells[0].Value?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(material))
                    {
                        nota.Materiales.Add(new MaterialCirugiaDTO
                        {
                            Material = material,
                            Cantidad = Convert.ToInt32(row.Cells[1].Value ?? 1),
                            Observacion = row.Cells[2].Value?.ToString() ?? ""
                        });
                    }
                }

                bool resultado = _repository.GuardarNotaOperatoria(nota);

                if (resultado)
                {
                    MessageBox.Show("Nota operatoria guardada exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // No limpiar el formulario para permitir seguir editando
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar nota: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosNota()
        {
            if (cmbCirugiaSel.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una cirugía", "Validación");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiagPost.Text))
            {
                MessageBox.Show("Debe ingresar el diagnóstico postoperatorio", "Validación");
                txtDiagPost.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtbTecnica.Text))
            {
                MessageBox.Show("Debe describir la técnica operatoria", "Validación");
                rtbTecnica.Focus();
                return false;
            }

            if (dtpFinReal.Value <= dtpInicioReal.Value)
            {
                MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio", "Validación");
                dtpFinReal.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarFormularioNota()
        {
            cmbCirugiaSel.SelectedIndex = -1;
            txtDiagPost.Clear();
            rtbTecnica.Clear();
            rtbHallazgos.Clear();
            txtComplicaciones.Clear();
            dgvMateriales.Rows.Clear();
            cmbProfesional.SelectedIndex = -1;
            cmbEstadoNota.SelectedIndex = 0;
            dtpInicioReal.Value = DateTime.Now;
            dtpFinReal.Value = DateTime.Now;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de impresión en desarrollo", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void cmbPaciente_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}