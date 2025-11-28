using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; // Necesario para Point, Color, etc.

namespace Borrador
{
    // Aseguramos que hereda de UserControl y tiene el using System.Windows.Forms;
    public partial class UCOrdenLaboratorio : UserControl
    {
        // --- Campos de Identificación y Requeridos ---
        public int IdOrden { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public DateTime FechaHoraSolicitud { get; set; }
        public List<int> IdsExamenes { get; set; } = new List<int>();
        public string EstadoOrden { get; set; }
        public string TipoMuestra { get; set; }
        public string Prioridad { get; set; }
        public string IndicacionesClinicas { get; set; }

        // --- CONSTRUCTOR Y COMPONENTES VISUALES ---

        // Declaración de los componentes de la interfaz de usuario
        private Label lblPaciente;
        private TextBox txtIdPaciente;
        private Label lblMedico;
        private ComboBox cmbMedico;
        private GroupBox grpExamenes;
        private DataGridView dgvExamenes;
        private Label lblPrioridad;
        private RadioButton rbUrgente;
        private RadioButton rbRutina;
        private TextBox txtIndicaciones;
        private Label lblIndicaciones;
        private Button btnGuardar;

        public UCOrdenLaboratorio()
        {
            
            SetupLayoutAndControls();
            LoadSampleData(); // Nuevo método para cargar datos de prueba
            btnGuardar.Click += BtnGuardar_Click; // Conectar el evento Click
        }

        private void SetupLayoutAndControls()
        {
            // Configuración básica del control de usuario
            this.BackColor = Color.White;
            this.Padding = new Padding(20);

            // 1. Controles para ID Paciente
            lblPaciente = new Label { Text = "ID Paciente:", Location = new Point(30, 30), AutoSize = true };
            txtIdPaciente = new TextBox { Location = new Point(130, 30), Width = 150, Text = "1001" }; // Valor de prueba
            this.Controls.Add(lblPaciente);
            this.Controls.Add(txtIdPaciente);

            // 2. Controles para Médico
            lblMedico = new Label { Text = "Médico:", Location = new Point(30, 70), AutoSize = true };
            cmbMedico = new ComboBox { Location = new Point(130, 70), Width = 250, DropDownStyle = ComboBoxStyle.DropDownList };
            this.Controls.Add(lblMedico);
            this.Controls.Add(cmbMedico);

            // 3. Controles para Prioridad (Radio Buttons)
            lblPrioridad = new Label { Text = "Prioridad:", Location = new Point(400, 30), AutoSize = true };
            rbRutina = new RadioButton { Text = "Rutina", Location = new Point(490, 30), Checked = true, AutoSize = true };
            rbUrgente = new RadioButton { Text = "Urgente", Location = new Point(490, 50), AutoSize = true };
            this.Controls.Add(lblPrioridad);
            this.Controls.Add(rbRutina);
            this.Controls.Add(rbUrgente);

            // 4. GroupBox y DataGridView para Exámenes
            grpExamenes = new GroupBox { Text = "Exámenes Solicitados", Location = new Point(30, 110), Width = 700, Height = 300 };
            // ReadOnly=false temporalmente para que el checkbox sea editable, aunque solo permitimos agregar filas por código
            dgvExamenes = new DataGridView { Dock = DockStyle.Fill, AllowUserToAddRows = false, ReadOnly = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            grpExamenes.Controls.Add(dgvExamenes);
            this.Controls.Add(grpExamenes);

            // Inicializar DataGridView (Estructura de Columnas)
            dgvExamenes.Columns.Add("IdExamen", "ID");
            dgvExamenes.Columns.Add("Nombre", "Nombre del Examen");
            dgvExamenes.Columns["Nombre"].Width = 400; // Columna más ancha para el nombre

            // Crear la columna como DataGridViewCheckBoxColumn
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Seleccionar";
            checkColumn.HeaderText = "Sel.";
            checkColumn.Width = 50;
            dgvExamenes.Columns.Add(checkColumn);


            // 5. Indicaciones Clínicas
            lblIndicaciones = new Label { Text = "Indicaciones:", Location = new Point(30, 430), AutoSize = true };
            txtIndicaciones = new TextBox { Location = new Point(130, 430), Width = 600, Height = 80, Multiline = true };
            this.Controls.Add(lblIndicaciones);
            this.Controls.Add(txtIndicaciones);

            // 6. Botón Guardar
            btnGuardar = new Button { Text = "Guardar Orden", Location = new Point(600, 550), Width = 150 };
            this.Controls.Add(btnGuardar);
        }

        // MÉTODOS DE FUNCIONALIDAD

        private void LoadSampleData()
        {
            // Cargar médicos de ejemplo en el ComboBox
            cmbMedico.Items.Add(new KeyValuePair<int, string>(1, "Dr. José Pérez (General)"));
            cmbMedico.Items.Add(new KeyValuePair<int, string>(2, "Dra. Ana López (Pediatría)"));
            cmbMedico.Items.Add(new KeyValuePair<int, string>(3, "Dr. Juan Gómez (Internista)"));
            cmbMedico.DisplayMember = "Value"; // Muestra el nombre
            cmbMedico.ValueMember = "Key";   // Guarda el ID
            cmbMedico.SelectedIndex = 0;

            // Cargar exámenes de ejemplo en el DataGridView
            dgvExamenes.Rows.Add(101, "Hemograma Completo");
            dgvExamenes.Rows.Add(102, "Glucosa en Ayunas");
            dgvExamenes.Rows.Add(103, "Perfil Lipídico");
            dgvExamenes.Rows.Add(104, "Uroanálisis");
            dgvExamenes.Rows.Add(105, "Coproparasitológico");
            dgvExamenes.Rows.Add(106, "Hormona Tiroidea (TSH)");

            // Establecer el tipo de celda del CheckBox para las celdas existentes (no es necesario si se usa DataGridViewCheckBoxColumn)
            foreach (DataGridViewRow row in dgvExamenes.Rows)
            {
                row.Cells["Seleccionar"].Value = false; // Inicializar en desmarcado
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Obtener datos del paciente
            if (!int.TryParse(txtIdPaciente.Text, out int pacienteId))
            {
                MessageBox.Show("ID de Paciente inválido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.IdPaciente = pacienteId;

            // 2. Obtener médico seleccionado
            if (cmbMedico.SelectedItem is KeyValuePair<int, string> selectedMedico)
            {
                this.IdMedico = selectedMedico.Key;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un médico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Obtener prioridad
            this.Prioridad = rbUrgente.Checked ? "Urgente" : "Rutina";
            this.IndicacionesClinicas = txtIndicaciones.Text;

            // 4. Obtener exámenes seleccionados
            this.IdsExamenes.Clear();
            foreach (DataGridViewRow row in dgvExamenes.Rows)
            {
                // Verifica que la columna "Seleccionar" tenga un valor booleano (true si está marcada)
                bool isSelected = (row.Cells["Seleccionar"].Value is bool checkedValue && checkedValue);

                if (isSelected)
                {
                    if (int.TryParse(row.Cells["IdExamen"].Value.ToString(), out int examenId))
                    {
                        this.IdsExamenes.Add(examenId);
                    }
                }
            }

            if (this.IdsExamenes.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un examen.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Finalizar y mostrar resumen
            this.FechaHoraSolicitud = DateTime.Now;
            this.EstadoOrden = "Solicitada";

            MessageBox.Show(
                $"✅ Orden Creada\n" +
                $"Paciente ID: {this.IdPaciente}\n" +
                $"Médico ID: {this.IdMedico}\n" +
                $"Prioridad: {this.Prioridad}\n" +
                $"Exámenes seleccionados: {this.IdsExamenes.Count}",
                "Orden de Laboratorio Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UCOrdenLaboratorio
            // 
            this.Name = "UCOrdenLaboratorio";
            this.ResumeLayout(false);

        }
    }
}