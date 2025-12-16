namespace Borrador
{
    partial class Modulo4
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageEnfermeria = new System.Windows.Forms.TabPage();
            this.btnGuardar_Enf = new System.Windows.Forms.Button();
            this.groupBoxObservaciones_Enf = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtObservaciones_Enf = new System.Windows.Forms.TextBox();
            this.btnImprimir_Enf = new System.Windows.Forms.Button();
            this.groupBoxSignos_Enf = new System.Windows.Forms.GroupBox();
            this.btnAgregarSignos_Enf = new System.Windows.Forms.Button();
            this.dgvSignosVitales_Enf = new System.Windows.Forms.DataGridView();
            this.btnIrAMedicamentos = new System.Windows.Forms.Button();
            this.groupBoxIntervenciones_Enf = new System.Windows.Forms.GroupBox();
            this.btnAgregarIntervencion_Enf = new System.Windows.Forms.Button();
            this.dgvIntervenciones_Enf = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos_Enf = new System.Windows.Forms.GroupBox();
            this.cmbTurno_Enf = new System.Windows.Forms.ComboBox();
            this.lblTurno_Enf = new System.Windows.Forms.Label();
            this.dtpFecha_Enf = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_Enf = new System.Windows.Forms.Label();
            this.cmbEnfermero_Enf = new System.Windows.Forms.ComboBox();
            this.lblEnfermero_Enf = new System.Windows.Forms.Label();
            this.cmbPaciente_Enf = new System.Windows.Forms.ComboBox();
            this.lblPaciente_Enf = new System.Windows.Forms.Label();
            this.panelHeader_Enf = new System.Windows.Forms.Panel();
            this.lblTitulo_Enf = new System.Windows.Forms.Label();
            this.tabPageMedicamentos = new System.Windows.Forms.TabPage();
            this.btnCancelar_Med = new System.Windows.Forms.Button();
            this.groupBoxAdministracion_Med = new System.Windows.Forms.GroupBox();
            this.txtObservaciones_Med = new System.Windows.Forms.TextBox();
            this.lblObservaciones_Med = new System.Windows.Forms.Label();
            this.cmbResponsable_Med = new System.Windows.Forms.ComboBox();
            this.lblResponsable_Med = new System.Windows.Forms.Label();
            this.chkAdministrado_Med = new System.Windows.Forms.CheckBox();
            this.dtpHoraAdministracion_Med = new System.Windows.Forms.DateTimePicker();
            this.lblHoraAdministracion_Med = new System.Windows.Forms.Label();
            this.btnHistorial_Med = new System.Windows.Forms.Button();
            this.groupBoxMedicamentos_Med = new System.Windows.Forms.GroupBox();
            this.dgvMedicamentosPrescritos_Med = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos_Med = new System.Windows.Forms.GroupBox();
            this.cmbPrescripcion_Med = new System.Windows.Forms.ComboBox();
            this.lblPrescripcion_Med = new System.Windows.Forms.Label();
            this.cmbPaciente_Med = new System.Windows.Forms.ComboBox();
            this.lblPaciente_Med = new System.Windows.Forms.Label();
            this.panelHeader_Med = new System.Windows.Forms.Panel();
            this.lblTitulo_Med = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageEnfermeria.SuspendLayout();
            this.groupBoxObservaciones_Enf.SuspendLayout();
            this.groupBoxSignos_Enf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignosVitales_Enf)).BeginInit();
            this.groupBoxIntervenciones_Enf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenciones_Enf)).BeginInit();
            this.groupBoxDatos_Enf.SuspendLayout();
            this.panelHeader_Enf.SuspendLayout();
            this.tabPageMedicamentos.SuspendLayout();
            this.groupBoxAdministracion_Med.SuspendLayout();
            this.groupBoxMedicamentos_Med.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosPrescritos_Med)).BeginInit();
            this.groupBoxDatos_Med.SuspendLayout();
            this.panelHeader_Med.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPageEnfermeria);
            this.tabControlPrincipal.Controls.Add(this.tabPageMedicamentos);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1467, 1126);
            this.tabControlPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabPageEnfermeria
            // 
            this.tabPageEnfermeria.AutoScroll = true;
            this.tabPageEnfermeria.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.tabPageEnfermeria.AutoScrollMinSize = new System.Drawing.Size(0, 950);
            this.tabPageEnfermeria.BackColor = System.Drawing.Color.White;
            this.tabPageEnfermeria.Controls.Add(this.btnGuardar_Enf);
            this.tabPageEnfermeria.Controls.Add(this.groupBoxObservaciones_Enf);
            this.tabPageEnfermeria.Controls.Add(this.btnImprimir_Enf);
            this.tabPageEnfermeria.Controls.Add(this.groupBoxSignos_Enf);
            this.tabPageEnfermeria.Controls.Add(this.btnIrAMedicamentos);
            this.tabPageEnfermeria.Controls.Add(this.groupBoxIntervenciones_Enf);
            this.tabPageEnfermeria.Controls.Add(this.groupBoxDatos_Enf);
            this.tabPageEnfermeria.Controls.Add(this.panelHeader_Enf);
            this.tabPageEnfermeria.Location = new System.Drawing.Point(4, 29);
            this.tabPageEnfermeria.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEnfermeria.Name = "tabPageEnfermeria";
            this.tabPageEnfermeria.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEnfermeria.Size = new System.Drawing.Size(1459, 1093);
            this.tabPageEnfermeria.TabIndex = 0;
            this.tabPageEnfermeria.Text = "Hoja de Enfermería";
            this.tabPageEnfermeria.Click += new System.EventHandler(this.tabPageEnfermeria_Click);
            // 
            // btnGuardar_Enf
            // 
            this.btnGuardar_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar_Enf.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar_Enf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar_Enf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar_Enf.ForeColor = System.Drawing.Color.White;
            this.btnGuardar_Enf.Location = new System.Drawing.Point(1163, 1019);
            this.btnGuardar_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar_Enf.Name = "btnGuardar_Enf";
            this.btnGuardar_Enf.Size = new System.Drawing.Size(215, 49);
            this.btnGuardar_Enf.TabIndex = 0;
            this.btnGuardar_Enf.Text = "💾 Guardar";
            this.btnGuardar_Enf.UseVisualStyleBackColor = false;
            this.btnGuardar_Enf.Click += new System.EventHandler(this.btnGuardar_Enf_Click);
            // 
            // groupBoxObservaciones_Enf
            // 
            this.groupBoxObservaciones_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxObservaciones_Enf.Controls.Add(this.button1);
            this.groupBoxObservaciones_Enf.Controls.Add(this.txtObservaciones_Enf);
            this.groupBoxObservaciones_Enf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxObservaciones_Enf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.groupBoxObservaciones_Enf.Location = new System.Drawing.Point(36, 784);
            this.groupBoxObservaciones_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxObservaciones_Enf.Name = "groupBoxObservaciones_Enf";
            this.groupBoxObservaciones_Enf.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxObservaciones_Enf.Size = new System.Drawing.Size(1347, 206);
            this.groupBoxObservaciones_Enf.TabIndex = 4;
            this.groupBoxObservaciones_Enf.TabStop = false;
            this.groupBoxObservaciones_Enf.Text = "Observaciones de Turno";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(166)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "+ Agregar Observación";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtObservaciones_Enf
            // 
            this.txtObservaciones_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones_Enf.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtObservaciones_Enf.Location = new System.Drawing.Point(20, 34);
            this.txtObservaciones_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones_Enf.MaxLength = 400;
            this.txtObservaciones_Enf.Multiline = true;
            this.txtObservaciones_Enf.Name = "txtObservaciones_Enf";
            this.txtObservaciones_Enf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones_Enf.Size = new System.Drawing.Size(1326, 106);
            this.txtObservaciones_Enf.TabIndex = 0;
            // 
            // btnImprimir_Enf
            // 
            this.btnImprimir_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir_Enf.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnImprimir_Enf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir_Enf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnImprimir_Enf.ForeColor = System.Drawing.Color.White;
            this.btnImprimir_Enf.Location = new System.Drawing.Point(986, 1019);
            this.btnImprimir_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir_Enf.Name = "btnImprimir_Enf";
            this.btnImprimir_Enf.Size = new System.Drawing.Size(147, 49);
            this.btnImprimir_Enf.TabIndex = 1;
            this.btnImprimir_Enf.Text = "🖨️ Imprimir";
            this.btnImprimir_Enf.UseVisualStyleBackColor = false;
            this.btnImprimir_Enf.Click += new System.EventHandler(this.btnImprimir_Enf_Click);
            // 
            // groupBoxSignos_Enf
            // 
            this.groupBoxSignos_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSignos_Enf.Controls.Add(this.btnAgregarSignos_Enf);
            this.groupBoxSignos_Enf.Controls.Add(this.dgvSignosVitales_Enf);
            this.groupBoxSignos_Enf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxSignos_Enf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.groupBoxSignos_Enf.Location = new System.Drawing.Point(35, 550);
            this.groupBoxSignos_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSignos_Enf.Name = "groupBoxSignos_Enf";
            this.groupBoxSignos_Enf.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSignos_Enf.Size = new System.Drawing.Size(1347, 214);
            this.groupBoxSignos_Enf.TabIndex = 3;
            this.groupBoxSignos_Enf.TabStop = false;
            this.groupBoxSignos_Enf.Text = "Signos Vitales por Hora";
            // 
            // btnAgregarSignos_Enf
            // 
            this.btnAgregarSignos_Enf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(166)))));
            this.btnAgregarSignos_Enf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSignos_Enf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarSignos_Enf.ForeColor = System.Drawing.Color.White;
            this.btnAgregarSignos_Enf.Location = new System.Drawing.Point(20, 160);
            this.btnAgregarSignos_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarSignos_Enf.Name = "btnAgregarSignos_Enf";
            this.btnAgregarSignos_Enf.Size = new System.Drawing.Size(213, 37);
            this.btnAgregarSignos_Enf.TabIndex = 1;
            this.btnAgregarSignos_Enf.Text = "+ Agregar Registro";
            this.btnAgregarSignos_Enf.UseVisualStyleBackColor = false;
            this.btnAgregarSignos_Enf.Click += new System.EventHandler(this.btnAgregarSignos_Enf_Click);
            // 
            // dgvSignosVitales_Enf
            // 
            this.dgvSignosVitales_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSignosVitales_Enf.BackgroundColor = System.Drawing.Color.White;
            this.dgvSignosVitales_Enf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSignosVitales_Enf.Location = new System.Drawing.Point(20, 34);
            this.dgvSignosVitales_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSignosVitales_Enf.Name = "dgvSignosVitales_Enf";
            this.dgvSignosVitales_Enf.RowHeadersWidth = 51;
            this.dgvSignosVitales_Enf.Size = new System.Drawing.Size(1319, 114);
            this.dgvSignosVitales_Enf.TabIndex = 0;
            // 
            // btnIrAMedicamentos
            // 
            this.btnIrAMedicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrAMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.btnIrAMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrAMedicamentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIrAMedicamentos.ForeColor = System.Drawing.Color.White;
            this.btnIrAMedicamentos.Location = new System.Drawing.Point(622, 1019);
            this.btnIrAMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnIrAMedicamentos.Name = "btnIrAMedicamentos";
            this.btnIrAMedicamentos.Size = new System.Drawing.Size(333, 49);
            this.btnIrAMedicamentos.TabIndex = 2;
            this.btnIrAMedicamentos.Text = "💊 Administrar Medicamentos";
            this.btnIrAMedicamentos.UseVisualStyleBackColor = false;
            this.btnIrAMedicamentos.Click += new System.EventHandler(this.btnIrAMedicamentos_Click);
            // 
            // groupBoxIntervenciones_Enf
            // 
            this.groupBoxIntervenciones_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIntervenciones_Enf.Controls.Add(this.btnAgregarIntervencion_Enf);
            this.groupBoxIntervenciones_Enf.Controls.Add(this.dgvIntervenciones_Enf);
            this.groupBoxIntervenciones_Enf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxIntervenciones_Enf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.groupBoxIntervenciones_Enf.Location = new System.Drawing.Point(35, 320);
            this.groupBoxIntervenciones_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIntervenciones_Enf.Name = "groupBoxIntervenciones_Enf";
            this.groupBoxIntervenciones_Enf.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIntervenciones_Enf.Size = new System.Drawing.Size(1347, 214);
            this.groupBoxIntervenciones_Enf.TabIndex = 2;
            this.groupBoxIntervenciones_Enf.TabStop = false;
            this.groupBoxIntervenciones_Enf.Text = "Lista de Intervenciones";
            // 
            // btnAgregarIntervencion_Enf
            // 
            this.btnAgregarIntervencion_Enf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(166)))));
            this.btnAgregarIntervencion_Enf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarIntervencion_Enf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarIntervencion_Enf.ForeColor = System.Drawing.Color.White;
            this.btnAgregarIntervencion_Enf.Location = new System.Drawing.Point(20, 161);
            this.btnAgregarIntervencion_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarIntervencion_Enf.Name = "btnAgregarIntervencion_Enf";
            this.btnAgregarIntervencion_Enf.Size = new System.Drawing.Size(213, 37);
            this.btnAgregarIntervencion_Enf.TabIndex = 1;
            this.btnAgregarIntervencion_Enf.Text = "+ Agregar Intervención";
            this.btnAgregarIntervencion_Enf.UseVisualStyleBackColor = false;
            this.btnAgregarIntervencion_Enf.Click += new System.EventHandler(this.btnAgregarIntervencion_Enf_Click);
            // 
            // dgvIntervenciones_Enf
            // 
            this.dgvIntervenciones_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIntervenciones_Enf.BackgroundColor = System.Drawing.Color.White;
            this.dgvIntervenciones_Enf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervenciones_Enf.Location = new System.Drawing.Point(20, 34);
            this.dgvIntervenciones_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIntervenciones_Enf.Name = "dgvIntervenciones_Enf";
            this.dgvIntervenciones_Enf.RowHeadersWidth = 51;
            this.dgvIntervenciones_Enf.Size = new System.Drawing.Size(1319, 119);
            this.dgvIntervenciones_Enf.TabIndex = 0;
            // 
            // groupBoxDatos_Enf
            // 
            this.groupBoxDatos_Enf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatos_Enf.Controls.Add(this.cmbTurno_Enf);
            this.groupBoxDatos_Enf.Controls.Add(this.lblTurno_Enf);
            this.groupBoxDatos_Enf.Controls.Add(this.dtpFecha_Enf);
            this.groupBoxDatos_Enf.Controls.Add(this.lblFecha_Enf);
            this.groupBoxDatos_Enf.Controls.Add(this.cmbEnfermero_Enf);
            this.groupBoxDatos_Enf.Controls.Add(this.lblEnfermero_Enf);
            this.groupBoxDatos_Enf.Controls.Add(this.cmbPaciente_Enf);
            this.groupBoxDatos_Enf.Controls.Add(this.lblPaciente_Enf);
            this.groupBoxDatos_Enf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos_Enf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.groupBoxDatos_Enf.Location = new System.Drawing.Point(35, 90);
            this.groupBoxDatos_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDatos_Enf.Name = "groupBoxDatos_Enf";
            this.groupBoxDatos_Enf.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDatos_Enf.Size = new System.Drawing.Size(1347, 211);
            this.groupBoxDatos_Enf.TabIndex = 1;
            this.groupBoxDatos_Enf.TabStop = false;
            this.groupBoxDatos_Enf.Text = "Datos Generales";
            // 
            // cmbTurno_Enf
            // 
            this.cmbTurno_Enf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno_Enf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTurno_Enf.FormattingEnabled = true;
            this.cmbTurno_Enf.Location = new System.Drawing.Point(20, 153);
            this.cmbTurno_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTurno_Enf.Name = "cmbTurno_Enf";
            this.cmbTurno_Enf.Size = new System.Drawing.Size(399, 31);
            this.cmbTurno_Enf.TabIndex = 7;
            // 
            // lblTurno_Enf
            // 
            this.lblTurno_Enf.AutoSize = true;
            this.lblTurno_Enf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTurno_Enf.Location = new System.Drawing.Point(16, 125);
            this.lblTurno_Enf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurno_Enf.Name = "lblTurno_Enf";
            this.lblTurno_Enf.Size = new System.Drawing.Size(59, 23);
            this.lblTurno_Enf.TabIndex = 6;
            this.lblTurno_Enf.Text = "Turno:";
            // 
            // dtpFecha_Enf
            // 
            this.dtpFecha_Enf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFecha_Enf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Enf.Location = new System.Drawing.Point(722, 153);
            this.dtpFecha_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha_Enf.Name = "dtpFecha_Enf";
            this.dtpFecha_Enf.Size = new System.Drawing.Size(399, 30);
            this.dtpFecha_Enf.TabIndex = 5;
            // 
            // lblFecha_Enf
            // 
            this.lblFecha_Enf.AutoSize = true;
            this.lblFecha_Enf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha_Enf.Location = new System.Drawing.Point(718, 125);
            this.lblFecha_Enf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha_Enf.Name = "lblFecha_Enf";
            this.lblFecha_Enf.Size = new System.Drawing.Size(58, 23);
            this.lblFecha_Enf.TabIndex = 4;
            this.lblFecha_Enf.Text = "Fecha:";
            // 
            // cmbEnfermero_Enf
            // 
            this.cmbEnfermero_Enf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnfermero_Enf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEnfermero_Enf.FormattingEnabled = true;
            this.cmbEnfermero_Enf.Location = new System.Drawing.Point(722, 63);
            this.cmbEnfermero_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEnfermero_Enf.Name = "cmbEnfermero_Enf";
            this.cmbEnfermero_Enf.Size = new System.Drawing.Size(399, 31);
            this.cmbEnfermero_Enf.TabIndex = 3;
            // 
            // lblEnfermero_Enf
            // 
            this.lblEnfermero_Enf.AutoSize = true;
            this.lblEnfermero_Enf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEnfermero_Enf.Location = new System.Drawing.Point(718, 34);
            this.lblEnfermero_Enf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnfermero_Enf.Name = "lblEnfermero_Enf";
            this.lblEnfermero_Enf.Size = new System.Drawing.Size(209, 23);
            this.lblEnfermero_Enf.TabIndex = 2;
            this.lblEnfermero_Enf.Text = "Enfermero/a Responsable:";
            // 
            // cmbPaciente_Enf
            // 
            this.cmbPaciente_Enf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente_Enf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaciente_Enf.FormattingEnabled = true;
            this.cmbPaciente_Enf.Location = new System.Drawing.Point(20, 63);
            this.cmbPaciente_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaciente_Enf.Name = "cmbPaciente_Enf";
            this.cmbPaciente_Enf.Size = new System.Drawing.Size(600, 31);
            this.cmbPaciente_Enf.TabIndex = 1;
            // 
            // lblPaciente_Enf
            // 
            this.lblPaciente_Enf.AutoSize = true;
            this.lblPaciente_Enf.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente_Enf.Location = new System.Drawing.Point(16, 34);
            this.lblPaciente_Enf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente_Enf.Name = "lblPaciente_Enf";
            this.lblPaciente_Enf.Size = new System.Drawing.Size(78, 23);
            this.lblPaciente_Enf.TabIndex = 0;
            this.lblPaciente_Enf.Text = "Paciente:";
            // 
            // panelHeader_Enf
            // 
            this.panelHeader_Enf.AutoScroll = true;
            this.panelHeader_Enf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.panelHeader_Enf.Controls.Add(this.lblTitulo_Enf);
            this.panelHeader_Enf.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader_Enf.Location = new System.Drawing.Point(4, 4);
            this.panelHeader_Enf.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader_Enf.Name = "panelHeader_Enf";
            this.panelHeader_Enf.Size = new System.Drawing.Size(1451, 56);
            this.panelHeader_Enf.TabIndex = 0;
            // 
            // lblTitulo_Enf
            // 
            this.lblTitulo_Enf.AutoSize = true;
            this.lblTitulo_Enf.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo_Enf.ForeColor = System.Drawing.Color.White;
            this.lblTitulo_Enf.Location = new System.Drawing.Point(27, 7);
            this.lblTitulo_Enf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo_Enf.Name = "lblTitulo_Enf";
            this.lblTitulo_Enf.Size = new System.Drawing.Size(339, 41);
            this.lblTitulo_Enf.TabIndex = 0;
            this.lblTitulo_Enf.Text = "🧑‍⚕️ Hoja de Enfermería";
            // 
            // tabPageMedicamentos
            // 
            this.tabPageMedicamentos.AutoScroll = true;
            this.tabPageMedicamentos.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.tabPageMedicamentos.BackColor = System.Drawing.Color.White;
            this.tabPageMedicamentos.Controls.Add(this.btnCancelar_Med);
            this.tabPageMedicamentos.Controls.Add(this.groupBoxAdministracion_Med);
            this.tabPageMedicamentos.Controls.Add(this.btnHistorial_Med);
            this.tabPageMedicamentos.Controls.Add(this.groupBoxMedicamentos_Med);
            this.tabPageMedicamentos.Controls.Add(this.groupBoxDatos_Med);
            this.tabPageMedicamentos.Controls.Add(this.panelHeader_Med);
            this.tabPageMedicamentos.Location = new System.Drawing.Point(4, 29);
            this.tabPageMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMedicamentos.Name = "tabPageMedicamentos";
            this.tabPageMedicamentos.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMedicamentos.Size = new System.Drawing.Size(1459, 1093);
            this.tabPageMedicamentos.TabIndex = 1;
            this.tabPageMedicamentos.Text = "Administración de Medicamentos";
            // 
            // btnCancelar_Med
            // 
            this.btnCancelar_Med.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar_Med.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(166)))));
            this.btnCancelar_Med.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar_Med.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar_Med.ForeColor = System.Drawing.Color.White;
            this.btnCancelar_Med.Location = new System.Drawing.Point(500, 1004);
            this.btnCancelar_Med.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar_Med.Name = "btnCancelar_Med";
            this.btnCancelar_Med.Size = new System.Drawing.Size(240, 49);
            this.btnCancelar_Med.TabIndex = 1;
            this.btnCancelar_Med.Text = "✖ Cancelar";
            this.btnCancelar_Med.UseVisualStyleBackColor = false;
            this.btnCancelar_Med.Click += new System.EventHandler(this.btnCancelar_Med_Click);
            // 
            // groupBoxAdministracion_Med
            // 
            this.groupBoxAdministracion_Med.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAdministracion_Med.Controls.Add(this.txtObservaciones_Med);
            this.groupBoxAdministracion_Med.Controls.Add(this.lblObservaciones_Med);
            this.groupBoxAdministracion_Med.Controls.Add(this.cmbResponsable_Med);
            this.groupBoxAdministracion_Med.Controls.Add(this.lblResponsable_Med);
            this.groupBoxAdministracion_Med.Controls.Add(this.chkAdministrado_Med);
            this.groupBoxAdministracion_Med.Controls.Add(this.dtpHoraAdministracion_Med);
            this.groupBoxAdministracion_Med.Controls.Add(this.lblHoraAdministracion_Med);
            this.groupBoxAdministracion_Med.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAdministracion_Med.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.groupBoxAdministracion_Med.Location = new System.Drawing.Point(35, 632);
            this.groupBoxAdministracion_Med.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAdministracion_Med.Name = "groupBoxAdministracion_Med";
            this.groupBoxAdministracion_Med.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAdministracion_Med.Size = new System.Drawing.Size(1304, 345);
            this.groupBoxAdministracion_Med.TabIndex = 3;
            this.groupBoxAdministracion_Med.TabStop = false;
            this.groupBoxAdministracion_Med.Text = "Registro de Administración";
            // 
            // txtObservaciones_Med
            // 
            this.txtObservaciones_Med.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones_Med.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtObservaciones_Med.Location = new System.Drawing.Point(33, 228);
            this.txtObservaciones_Med.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones_Med.MaxLength = 300;
            this.txtObservaciones_Med.Multiline = true;
            this.txtObservaciones_Med.Name = "txtObservaciones_Med";
            this.txtObservaciones_Med.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones_Med.Size = new System.Drawing.Size(1236, 91);
            this.txtObservaciones_Med.TabIndex = 6;
            // 
            // lblObservaciones_Med
            // 
            this.lblObservaciones_Med.AutoSize = true;
            this.lblObservaciones_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblObservaciones_Med.Location = new System.Drawing.Point(29, 199);
            this.lblObservaciones_Med.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones_Med.Name = "lblObservaciones_Med";
            this.lblObservaciones_Med.Size = new System.Drawing.Size(124, 23);
            this.lblObservaciones_Med.TabIndex = 5;
            this.lblObservaciones_Med.Text = "Observaciones:";
            // 
            // cmbResponsable_Med
            // 
            this.cmbResponsable_Med.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbResponsable_Med.FormattingEnabled = true;
            this.cmbResponsable_Med.Location = new System.Drawing.Point(679, 148);
            this.cmbResponsable_Med.Margin = new System.Windows.Forms.Padding(4);
            this.cmbResponsable_Med.Name = "cmbResponsable_Med";
            this.cmbResponsable_Med.Size = new System.Drawing.Size(394, 31);
            this.cmbResponsable_Med.TabIndex = 4;
            // 
            // lblResponsable_Med
            // 
            this.lblResponsable_Med.AutoSize = true;
            this.lblResponsable_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResponsable_Med.Location = new System.Drawing.Point(675, 119);
            this.lblResponsable_Med.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsable_Med.Name = "lblResponsable_Med";
            this.lblResponsable_Med.Size = new System.Drawing.Size(219, 23);
            this.lblResponsable_Med.TabIndex = 3;
            this.lblResponsable_Med.Text = "Responsable (Enfermero/a):";
            // 
            // chkAdministrado_Med
            // 
            this.chkAdministrado_Med.AutoSize = true;
            this.chkAdministrado_Med.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkAdministrado_Med.Location = new System.Drawing.Point(33, 150);
            this.chkAdministrado_Med.Margin = new System.Windows.Forms.Padding(4);
            this.chkAdministrado_Med.Name = "chkAdministrado_Med";
            this.chkAdministrado_Med.Size = new System.Drawing.Size(276, 27);
            this.chkAdministrado_Med.TabIndex = 2;
            this.chkAdministrado_Med.Text = "✓ Medicamento Administrado";
            this.chkAdministrado_Med.UseVisualStyleBackColor = true;
            // 
            // dtpHoraAdministracion_Med
            // 
            this.dtpHoraAdministracion_Med.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpHoraAdministracion_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraAdministracion_Med.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraAdministracion_Med.Location = new System.Drawing.Point(33, 74);
            this.dtpHoraAdministracion_Med.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraAdministracion_Med.Name = "dtpHoraAdministracion_Med";
            this.dtpHoraAdministracion_Med.ShowUpDown = true;
            this.dtpHoraAdministracion_Med.Size = new System.Drawing.Size(465, 30);
            this.dtpHoraAdministracion_Med.TabIndex = 1;
            // 
            // lblHoraAdministracion_Med
            // 
            this.lblHoraAdministracion_Med.AutoSize = true;
            this.lblHoraAdministracion_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHoraAdministracion_Med.Location = new System.Drawing.Point(29, 46);
            this.lblHoraAdministracion_Med.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraAdministracion_Med.Name = "lblHoraAdministracion_Med";
            this.lblHoraAdministracion_Med.Size = new System.Drawing.Size(194, 23);
            this.lblHoraAdministracion_Med.TabIndex = 0;
            this.lblHoraAdministracion_Med.Text = "Hora de Administración:";
            // 
            // btnHistorial_Med
            // 
            this.btnHistorial_Med.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.btnHistorial_Med.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial_Med.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHistorial_Med.ForeColor = System.Drawing.Color.White;
            this.btnHistorial_Med.Location = new System.Drawing.Point(35, 1004);
            this.btnHistorial_Med.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorial_Med.Name = "btnHistorial_Med";
            this.btnHistorial_Med.Size = new System.Drawing.Size(240, 49);
            this.btnHistorial_Med.TabIndex = 2;
            this.btnHistorial_Med.Text = "📋 Ver Historial";
            this.btnHistorial_Med.UseVisualStyleBackColor = false;
            this.btnHistorial_Med.Click += new System.EventHandler(this.btnHistorial_Med_Click);
            // 
            // groupBoxMedicamentos_Med
            // 
            this.groupBoxMedicamentos_Med.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMedicamentos_Med.Controls.Add(this.dgvMedicamentosPrescritos_Med);
            this.groupBoxMedicamentos_Med.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxMedicamentos_Med.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.groupBoxMedicamentos_Med.Location = new System.Drawing.Point(35, 380);
            this.groupBoxMedicamentos_Med.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMedicamentos_Med.Name = "groupBoxMedicamentos_Med";
            this.groupBoxMedicamentos_Med.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMedicamentos_Med.Size = new System.Drawing.Size(1304, 229);
            this.groupBoxMedicamentos_Med.TabIndex = 2;
            this.groupBoxMedicamentos_Med.TabStop = false;
            this.groupBoxMedicamentos_Med.Text = "Medicamentos Prescritos";
            // 
            // dgvMedicamentosPrescritos_Med
            // 
            this.dgvMedicamentosPrescritos_Med.AllowUserToAddRows = false;
            this.dgvMedicamentosPrescritos_Med.AllowUserToDeleteRows = false;
            this.dgvMedicamentosPrescritos_Med.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicamentosPrescritos_Med.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicamentosPrescritos_Med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentosPrescritos_Med.Location = new System.Drawing.Point(20, 34);
            this.dgvMedicamentosPrescritos_Med.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMedicamentosPrescritos_Med.Name = "dgvMedicamentosPrescritos_Med";
            this.dgvMedicamentosPrescritos_Med.ReadOnly = true;
            this.dgvMedicamentosPrescritos_Med.RowHeadersWidth = 51;
            this.dgvMedicamentosPrescritos_Med.Size = new System.Drawing.Size(1264, 176);
            this.dgvMedicamentosPrescritos_Med.TabIndex = 0;
            // 
            // groupBoxDatos_Med
            // 
            this.groupBoxDatos_Med.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatos_Med.Controls.Add(this.cmbPrescripcion_Med);
            this.groupBoxDatos_Med.Controls.Add(this.lblPrescripcion_Med);
            this.groupBoxDatos_Med.Controls.Add(this.cmbPaciente_Med);
            this.groupBoxDatos_Med.Controls.Add(this.lblPaciente_Med);
            this.groupBoxDatos_Med.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos_Med.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.groupBoxDatos_Med.Location = new System.Drawing.Point(35, 110);
            this.groupBoxDatos_Med.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDatos_Med.Name = "groupBoxDatos_Med";
            this.groupBoxDatos_Med.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDatos_Med.Size = new System.Drawing.Size(1304, 250);
            this.groupBoxDatos_Med.TabIndex = 1;
            this.groupBoxDatos_Med.TabStop = false;
            this.groupBoxDatos_Med.Text = "Datos del Paciente";
            // 
            // cmbPrescripcion_Med
            // 
            this.cmbPrescripcion_Med.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrescripcion_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPrescripcion_Med.FormattingEnabled = true;
            this.cmbPrescripcion_Med.Location = new System.Drawing.Point(33, 172);
            this.cmbPrescripcion_Med.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrescripcion_Med.Name = "cmbPrescripcion_Med";
            this.cmbPrescripcion_Med.Size = new System.Drawing.Size(1063, 31);
            this.cmbPrescripcion_Med.TabIndex = 3;
            this.cmbPrescripcion_Med.SelectedIndexChanged += new System.EventHandler(this.cmbPrescripcion_Med_SelectedIndexChanged);
            // 
            // lblPrescripcion_Med
            // 
            this.lblPrescripcion_Med.AutoSize = true;
            this.lblPrescripcion_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrescripcion_Med.Location = new System.Drawing.Point(29, 144);
            this.lblPrescripcion_Med.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrescripcion_Med.Name = "lblPrescripcion_Med";
            this.lblPrescripcion_Med.Size = new System.Drawing.Size(231, 23);
            this.lblPrescripcion_Med.TabIndex = 2;
            this.lblPrescripcion_Med.Text = "Orden Médica / Prescripción:";
            // 
            // cmbPaciente_Med
            // 
            this.cmbPaciente_Med.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaciente_Med.FormattingEnabled = true;
            this.cmbPaciente_Med.Location = new System.Drawing.Point(33, 86);
            this.cmbPaciente_Med.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaciente_Med.Name = "cmbPaciente_Med";
            this.cmbPaciente_Med.Size = new System.Drawing.Size(1063, 31);
            this.cmbPaciente_Med.TabIndex = 1;
            // 
            // lblPaciente_Med
            // 
            this.lblPaciente_Med.AutoSize = true;
            this.lblPaciente_Med.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaciente_Med.Location = new System.Drawing.Point(29, 58);
            this.lblPaciente_Med.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente_Med.Name = "lblPaciente_Med";
            this.lblPaciente_Med.Size = new System.Drawing.Size(78, 23);
            this.lblPaciente_Med.TabIndex = 0;
            this.lblPaciente_Med.Text = "Paciente:";
            // 
            // panelHeader_Med
            // 
            this.panelHeader_Med.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.panelHeader_Med.Controls.Add(this.lblTitulo_Med);
            this.panelHeader_Med.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader_Med.Location = new System.Drawing.Point(4, 4);
            this.panelHeader_Med.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader_Med.Name = "panelHeader_Med";
            this.panelHeader_Med.Size = new System.Drawing.Size(1451, 86);
            this.panelHeader_Med.TabIndex = 0;
            // 
            // lblTitulo_Med
            // 
            this.lblTitulo_Med.AutoSize = true;
            this.lblTitulo_Med.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo_Med.ForeColor = System.Drawing.Color.White;
            this.lblTitulo_Med.Location = new System.Drawing.Point(27, 22);
            this.lblTitulo_Med.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo_Med.Name = "lblTitulo_Med";
            this.lblTitulo_Med.Size = new System.Drawing.Size(541, 41);
            this.lblTitulo_Med.TabIndex = 0;
            this.lblTitulo_Med.Text = "💊 Administración de Medicamentos";
            // 
            // Modulo4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Modulo4";
            this.Size = new System.Drawing.Size(1467, 1126);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageEnfermeria.ResumeLayout(false);
            this.groupBoxObservaciones_Enf.ResumeLayout(false);
            this.groupBoxObservaciones_Enf.PerformLayout();
            this.groupBoxSignos_Enf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignosVitales_Enf)).EndInit();
            this.groupBoxIntervenciones_Enf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenciones_Enf)).EndInit();
            this.groupBoxDatos_Enf.ResumeLayout(false);
            this.groupBoxDatos_Enf.PerformLayout();
            this.panelHeader_Enf.ResumeLayout(false);
            this.panelHeader_Enf.PerformLayout();
            this.tabPageMedicamentos.ResumeLayout(false);
            this.groupBoxAdministracion_Med.ResumeLayout(false);
            this.groupBoxAdministracion_Med.PerformLayout();
            this.groupBoxMedicamentos_Med.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosPrescritos_Med)).EndInit();
            this.groupBoxDatos_Med.ResumeLayout(false);
            this.groupBoxDatos_Med.PerformLayout();
            this.panelHeader_Med.ResumeLayout(false);
            this.panelHeader_Med.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Tabs
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageEnfermeria;
        private System.Windows.Forms.TabPage tabPageMedicamentos;

        // --- Controles Enfermería ---
        private System.Windows.Forms.Panel panelHeader_Enf;
        private System.Windows.Forms.Label lblTitulo_Enf;
        // Panel Main eliminado para reducir anidamiento
        private System.Windows.Forms.GroupBox groupBoxDatos_Enf;
        private System.Windows.Forms.ComboBox cmbPaciente_Enf;
        private System.Windows.Forms.Label lblPaciente_Enf;
        private System.Windows.Forms.ComboBox cmbEnfermero_Enf;
        private System.Windows.Forms.Label lblEnfermero_Enf;
        private System.Windows.Forms.DateTimePicker dtpFecha_Enf;
        private System.Windows.Forms.Label lblFecha_Enf;
        private System.Windows.Forms.ComboBox cmbTurno_Enf;
        private System.Windows.Forms.Label lblTurno_Enf;
        private System.Windows.Forms.GroupBox groupBoxIntervenciones_Enf;
        private System.Windows.Forms.DataGridView dgvIntervenciones_Enf;
        private System.Windows.Forms.Button btnAgregarIntervencion_Enf;
        private System.Windows.Forms.GroupBox groupBoxSignos_Enf;
        private System.Windows.Forms.DataGridView dgvSignosVitales_Enf;
        private System.Windows.Forms.Button btnAgregarSignos_Enf;
        private System.Windows.Forms.GroupBox groupBoxObservaciones_Enf;
        private System.Windows.Forms.TextBox txtObservaciones_Enf;
        private System.Windows.Forms.Button btnGuardar_Enf;
        private System.Windows.Forms.Button btnImprimir_Enf;
        private System.Windows.Forms.Button btnIrAMedicamentos;

        // --- Controles Medicamentos ---
        private System.Windows.Forms.Panel panelHeader_Med;
        private System.Windows.Forms.Label lblTitulo_Med;
        // Panel Main eliminado para reducir anidamiento
        private System.Windows.Forms.GroupBox groupBoxDatos_Med;
        private System.Windows.Forms.ComboBox cmbPaciente_Med;
        private System.Windows.Forms.Label lblPaciente_Med;
        private System.Windows.Forms.ComboBox cmbPrescripcion_Med;
        private System.Windows.Forms.Label lblPrescripcion_Med;
        private System.Windows.Forms.GroupBox groupBoxMedicamentos_Med;
        private System.Windows.Forms.DataGridView dgvMedicamentosPrescritos_Med;
        private System.Windows.Forms.GroupBox groupBoxAdministracion_Med;
        private System.Windows.Forms.DateTimePicker dtpHoraAdministracion_Med;
        private System.Windows.Forms.Label lblHoraAdministracion_Med;
        private System.Windows.Forms.CheckBox chkAdministrado_Med;
        private System.Windows.Forms.ComboBox cmbResponsable_Med;
        private System.Windows.Forms.Label lblResponsable_Med;
        private System.Windows.Forms.TextBox txtObservaciones_Med;
        private System.Windows.Forms.Label lblObservaciones_Med;
        private System.Windows.Forms.Button btnCancelar_Med;
        private System.Windows.Forms.Button btnHistorial_Med;
        private System.Windows.Forms.Button button1;
    }
}