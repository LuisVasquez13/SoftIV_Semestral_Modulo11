namespace Borrador
{
    partial class Modulo10
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
            this.tabAgenda = new System.Windows.Forms.TabPage();
            this.pnlAgendaContent = new System.Windows.Forms.Panel();
            this.lblTituloAgenda = new System.Windows.Forms.Label();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtDiagPre = new System.Windows.Forms.TextBox();
            this.lblDiagPre = new System.Windows.Forms.Label();
            this.cmbTipoCirugia = new System.Windows.Forms.ComboBox();
            this.lblTipoCirugia = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.cmbCirujano = new System.Windows.Forms.ComboBox();
            this.lblCirujano = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtIdCirugia = new System.Windows.Forms.TextBox();
            this.lblIdCirugia = new System.Windows.Forms.Label();
            this.tabNota = new System.Windows.Forms.TabPage();
            this.pnlNotaContent = new System.Windows.Forms.Panel();
            this.lblTituloNota = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.cmbEstadoNota = new System.Windows.Forms.ComboBox();
            this.lblEstadoNota = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMateriales = new System.Windows.Forms.Label();
            this.txtComplicaciones = new System.Windows.Forms.TextBox();
            this.lblComplicaciones = new System.Windows.Forms.Label();
            this.rtbHallazgos = new System.Windows.Forms.RichTextBox();
            this.lblHallazgos = new System.Windows.Forms.Label();
            this.rtbTecnica = new System.Windows.Forms.RichTextBox();
            this.lblTecnica = new System.Windows.Forms.Label();
            this.txtDiagPost = new System.Windows.Forms.TextBox();
            this.lblDiagPost = new System.Windows.Forms.Label();
            this.dtpFinReal = new System.Windows.Forms.DateTimePicker();
            this.lblFinReal = new System.Windows.Forms.Label();
            this.dtpInicioReal = new System.Windows.Forms.DateTimePicker();
            this.lblInicioReal = new System.Windows.Forms.Label();
            this.cmbCirugiaSel = new System.Windows.Forms.ComboBox();
            this.lblCirugiaSel = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.tabAgenda.SuspendLayout();
            this.pnlAgendaContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            this.tabNota.SuspendLayout();
            this.pnlNotaContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabAgenda);
            this.tabControlPrincipal.Controls.Add(this.tabNota);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(950, 750);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabAgenda
            // 
            this.tabAgenda.BackColor = System.Drawing.Color.White;
            this.tabAgenda.Controls.Add(this.pnlAgendaContent);
            this.tabAgenda.Location = new System.Drawing.Point(4, 32);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgenda.Size = new System.Drawing.Size(942, 714);
            this.tabAgenda.TabIndex = 0;
            this.tabAgenda.Text = "Agenda de Cirugías";
            // 
            // pnlAgendaContent
            // 
            this.pnlAgendaContent.AutoScroll = true;
            this.pnlAgendaContent.Controls.Add(this.lblTituloAgenda);
            this.pnlAgendaContent.Controls.Add(this.btnProgramar);
            this.pnlAgendaContent.Controls.Add(this.txtObservaciones);
            this.pnlAgendaContent.Controls.Add(this.lblObservaciones);
            this.pnlAgendaContent.Controls.Add(this.cmbEstado);
            this.pnlAgendaContent.Controls.Add(this.lblEstado);
            this.pnlAgendaContent.Controls.Add(this.cmbPrioridad);
            this.pnlAgendaContent.Controls.Add(this.lblPrioridad);
            this.pnlAgendaContent.Controls.Add(this.numDuracion);
            this.pnlAgendaContent.Controls.Add(this.lblDuracion);
            this.pnlAgendaContent.Controls.Add(this.dtpFechaInicio);
            this.pnlAgendaContent.Controls.Add(this.lblFechaInicio);
            this.pnlAgendaContent.Controls.Add(this.cmbSala);
            this.pnlAgendaContent.Controls.Add(this.lblSala);
            this.pnlAgendaContent.Controls.Add(this.txtDiagPre);
            this.pnlAgendaContent.Controls.Add(this.lblDiagPre);
            this.pnlAgendaContent.Controls.Add(this.cmbTipoCirugia);
            this.pnlAgendaContent.Controls.Add(this.lblTipoCirugia);
            this.pnlAgendaContent.Controls.Add(this.txtEquipo);
            this.pnlAgendaContent.Controls.Add(this.lblEquipo);
            this.pnlAgendaContent.Controls.Add(this.cmbCirujano);
            this.pnlAgendaContent.Controls.Add(this.lblCirujano);
            this.pnlAgendaContent.Controls.Add(this.cmbPaciente);
            this.pnlAgendaContent.Controls.Add(this.lblPaciente);
            this.pnlAgendaContent.Controls.Add(this.txtIdCirugia);
            this.pnlAgendaContent.Controls.Add(this.lblIdCirugia);
            this.pnlAgendaContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAgendaContent.Location = new System.Drawing.Point(3, 3);
            this.pnlAgendaContent.Name = "pnlAgendaContent";
            this.pnlAgendaContent.Size = new System.Drawing.Size(936, 708);
            this.pnlAgendaContent.TabIndex = 0;
            // 
            // lblTituloAgenda
            // 
            this.lblTituloAgenda.AutoSize = true;
            this.lblTituloAgenda.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgenda.ForeColor = System.Drawing.Color.Black;
            this.lblTituloAgenda.Location = new System.Drawing.Point(20, 10);
            this.lblTituloAgenda.Name = "lblTituloAgenda";
            this.lblTituloAgenda.Size = new System.Drawing.Size(362, 52);
            this.lblTituloAgenda.TabIndex = 0;
            this.lblTituloAgenda.Text = "Programar Cirugía";
            // 
            // btnProgramar
            // 
            this.btnProgramar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.btnProgramar.FlatAppearance.BorderSize = 0;
            this.btnProgramar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProgramar.ForeColor = System.Drawing.Color.White;
            this.btnProgramar.Location = new System.Drawing.Point(604, 470);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(265, 40);
            this.btnProgramar.TabIndex = 25;
            this.btnProgramar.Text = "Programar / Guardar";
            this.btnProgramar.UseVisualStyleBackColor = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservaciones.Location = new System.Drawing.Point(29, 385);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(840, 60);
            this.txtObservaciones.TabIndex = 24;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblObservaciones.Location = new System.Drawing.Point(25, 365);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(120, 23);
            this.lblObservaciones.TabIndex = 23;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Programada",
            "Reprogramada",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(729, 320);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(140, 31);
            this.cmbEstado.TabIndex = 22;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstado.Location = new System.Drawing.Point(725, 300);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 23);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Estado";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.BackColor = System.Drawing.Color.White;
            this.cmbPrioridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPrioridad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "Electiva",
            "Urgente"});
            this.cmbPrioridad.Location = new System.Drawing.Point(589, 320);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(120, 31);
            this.cmbPrioridad.TabIndex = 20;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrioridad.Location = new System.Drawing.Point(585, 300);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(79, 23);
            this.lblPrioridad.TabIndex = 19;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // numDuracion
            // 
            this.numDuracion.BackColor = System.Drawing.Color.White;
            this.numDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDuracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numDuracion.Location = new System.Drawing.Point(469, 320);
            this.numDuracion.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(100, 30);
            this.numDuracion.TabIndex = 18;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDuracion.Location = new System.Drawing.Point(465, 300);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(123, 23);
            this.lblDuracion.TabIndex = 17;
            this.lblDuracion.Text = "Duración (min)";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(249, 320);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 30);
            this.dtpFechaInicio.TabIndex = 16;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(245, 300);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(155, 23);
            this.lblFechaInicio.TabIndex = 15;
            this.lblFechaInicio.Text = "Fecha y Hora Inicio";
            // 
            // cmbSala
            // 
            this.cmbSala.BackColor = System.Drawing.Color.White;
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(29, 320);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(200, 31);
            this.cmbSala.TabIndex = 14;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSala.Location = new System.Drawing.Point(25, 300);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(126, 23);
            this.lblSala.TabIndex = 13;
            this.lblSala.Text = "Sala Quirúrgica";
            // 
            // txtDiagPre
            // 
            this.txtDiagPre.BackColor = System.Drawing.Color.White;
            this.txtDiagPre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagPre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiagPre.Location = new System.Drawing.Point(299, 235);
            this.txtDiagPre.Multiline = true;
            this.txtDiagPre.Name = "txtDiagPre";
            this.txtDiagPre.Size = new System.Drawing.Size(570, 50);
            this.txtDiagPre.TabIndex = 12;
            // 
            // lblDiagPre
            // 
            this.lblDiagPre.AutoSize = true;
            this.lblDiagPre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiagPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiagPre.Location = new System.Drawing.Point(295, 215);
            this.lblDiagPre.Name = "lblDiagPre";
            this.lblDiagPre.Size = new System.Drawing.Size(210, 23);
            this.lblDiagPre.TabIndex = 11;
            this.lblDiagPre.Text = "Diagnóstico Preoperatorio";
            // 
            // cmbTipoCirugia
            // 
            this.cmbTipoCirugia.BackColor = System.Drawing.Color.White;
            this.cmbTipoCirugia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCirugia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTipoCirugia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoCirugia.FormattingEnabled = true;
            this.cmbTipoCirugia.Location = new System.Drawing.Point(29, 235);
            this.cmbTipoCirugia.Name = "cmbTipoCirugia";
            this.cmbTipoCirugia.Size = new System.Drawing.Size(250, 31);
            this.cmbTipoCirugia.TabIndex = 10;
            // 
            // lblTipoCirugia
            // 
            this.lblTipoCirugia.AutoSize = true;
            this.lblTipoCirugia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTipoCirugia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoCirugia.Location = new System.Drawing.Point(25, 215);
            this.lblTipoCirugia.Name = "lblTipoCirugia";
            this.lblTipoCirugia.Size = new System.Drawing.Size(126, 23);
            this.lblTipoCirugia.TabIndex = 9;
            this.lblTipoCirugia.Text = "Tipo de Cirugía";
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.Color.White;
            this.txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEquipo.Location = new System.Drawing.Point(29, 150);
            this.txtEquipo.Multiline = true;
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(840, 50);
            this.txtEquipo.TabIndex = 8;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEquipo.Location = new System.Drawing.Point(25, 130);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(234, 23);
            this.lblEquipo.TabIndex = 7;
            this.lblEquipo.Text = "Equipo Quirúrgico (Resumen)";
            // 
            // cmbCirujano
            // 
            this.cmbCirujano.BackColor = System.Drawing.Color.White;
            this.cmbCirujano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCirujano.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCirujano.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCirujano.FormattingEnabled = true;
            this.cmbCirujano.Location = new System.Drawing.Point(519, 90);
            this.cmbCirujano.Name = "cmbCirujano";
            this.cmbCirujano.Size = new System.Drawing.Size(350, 31);
            this.cmbCirujano.TabIndex = 6;
            // 
            // lblCirujano
            // 
            this.lblCirujano.AutoSize = true;
            this.lblCirujano.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCirujano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCirujano.Location = new System.Drawing.Point(515, 70);
            this.lblCirujano.Name = "lblCirujano";
            this.lblCirujano.Size = new System.Drawing.Size(144, 23);
            this.lblCirujano.TabIndex = 5;
            this.lblCirujano.Text = "Cirujano Principal";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.BackColor = System.Drawing.Color.White;
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(149, 90);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(350, 31);
            this.cmbPaciente.TabIndex = 4;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged_1);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPaciente.Location = new System.Drawing.Point(145, 70);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(74, 23);
            this.lblPaciente.TabIndex = 3;
            this.lblPaciente.Text = "Paciente";
            // 
            // txtIdCirugia
            // 
            this.txtIdCirugia.BackColor = System.Drawing.Color.White;
            this.txtIdCirugia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCirugia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdCirugia.Location = new System.Drawing.Point(29, 90);
            this.txtIdCirugia.Name = "txtIdCirugia";
            this.txtIdCirugia.ReadOnly = true;
            this.txtIdCirugia.Size = new System.Drawing.Size(100, 30);
            this.txtIdCirugia.TabIndex = 2;
            // 
            // lblIdCirugia
            // 
            this.lblIdCirugia.AutoSize = true;
            this.lblIdCirugia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIdCirugia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdCirugia.Location = new System.Drawing.Point(25, 70);
            this.lblIdCirugia.Name = "lblIdCirugia";
            this.lblIdCirugia.Size = new System.Drawing.Size(84, 23);
            this.lblIdCirugia.TabIndex = 1;
            this.lblIdCirugia.Text = "Id Cirugía";
            // 
            // tabNota
            // 
            this.tabNota.BackColor = System.Drawing.Color.White;
            this.tabNota.Controls.Add(this.pnlNotaContent);
            this.tabNota.Location = new System.Drawing.Point(4, 32);
            this.tabNota.Name = "tabNota";
            this.tabNota.Padding = new System.Windows.Forms.Padding(3);
            this.tabNota.Size = new System.Drawing.Size(942, 714);
            this.tabNota.TabIndex = 1;
            this.tabNota.Text = "Nota Operatoria";
            // 
            // pnlNotaContent
            // 
            this.pnlNotaContent.AutoScroll = true;
            this.pnlNotaContent.Controls.Add(this.lblTituloNota);
            this.pnlNotaContent.Controls.Add(this.btnImprimir);
            this.pnlNotaContent.Controls.Add(this.btnGuardarNota);
            this.pnlNotaContent.Controls.Add(this.cmbEstadoNota);
            this.pnlNotaContent.Controls.Add(this.lblEstadoNota);
            this.pnlNotaContent.Controls.Add(this.cmbProfesional);
            this.pnlNotaContent.Controls.Add(this.lblProfesional);
            this.pnlNotaContent.Controls.Add(this.dgvMateriales);
            this.pnlNotaContent.Controls.Add(this.lblMateriales);
            this.pnlNotaContent.Controls.Add(this.txtComplicaciones);
            this.pnlNotaContent.Controls.Add(this.lblComplicaciones);
            this.pnlNotaContent.Controls.Add(this.rtbHallazgos);
            this.pnlNotaContent.Controls.Add(this.lblHallazgos);
            this.pnlNotaContent.Controls.Add(this.rtbTecnica);
            this.pnlNotaContent.Controls.Add(this.lblTecnica);
            this.pnlNotaContent.Controls.Add(this.txtDiagPost);
            this.pnlNotaContent.Controls.Add(this.lblDiagPost);
            this.pnlNotaContent.Controls.Add(this.dtpFinReal);
            this.pnlNotaContent.Controls.Add(this.lblFinReal);
            this.pnlNotaContent.Controls.Add(this.dtpInicioReal);
            this.pnlNotaContent.Controls.Add(this.lblInicioReal);
            this.pnlNotaContent.Controls.Add(this.cmbCirugiaSel);
            this.pnlNotaContent.Controls.Add(this.lblCirugiaSel);
            this.pnlNotaContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotaContent.Location = new System.Drawing.Point(3, 3);
            this.pnlNotaContent.Name = "pnlNotaContent";
            this.pnlNotaContent.Size = new System.Drawing.Size(936, 708);
            this.pnlNotaContent.TabIndex = 0;
            // 
            // lblTituloNota
            // 
            this.lblTituloNota.AutoSize = true;
            this.lblTituloNota.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTituloNota.ForeColor = System.Drawing.Color.Black;
            this.lblTituloNota.Location = new System.Drawing.Point(20, 10);
            this.lblTituloNota.Name = "lblTituloNota";
            this.lblTituloNota.Size = new System.Drawing.Size(323, 52);
            this.lblTituloNota.TabIndex = 0;
            this.lblTituloNota.Text = "Nota Operatoria";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(653, 640);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 35);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.btnGuardarNota.FlatAppearance.BorderSize = 0;
            this.btnGuardarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNota.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarNota.ForeColor = System.Drawing.Color.White;
            this.btnGuardarNota.Location = new System.Drawing.Point(769, 640);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(100, 35);
            this.btnGuardarNota.TabIndex = 21;
            this.btnGuardarNota.Text = "Guardar";
            this.btnGuardarNota.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoNota
            // 
            this.cmbEstadoNota.BackColor = System.Drawing.Color.White;
            this.cmbEstadoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoNota.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEstadoNota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoNota.FormattingEnabled = true;
            this.cmbEstadoNota.Items.AddRange(new object[] {
            "Borrador",
            "Final"});
            this.cmbEstadoNota.Location = new System.Drawing.Point(349, 590);
            this.cmbEstadoNota.Name = "cmbEstadoNota";
            this.cmbEstadoNota.Size = new System.Drawing.Size(150, 31);
            this.cmbEstadoNota.TabIndex = 20;
            // 
            // lblEstadoNota
            // 
            this.lblEstadoNota.AutoSize = true;
            this.lblEstadoNota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstadoNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstadoNota.Location = new System.Drawing.Point(345, 570);
            this.lblEstadoNota.Name = "lblEstadoNota";
            this.lblEstadoNota.Size = new System.Drawing.Size(128, 23);
            this.lblEstadoNota.TabIndex = 19;
            this.lblEstadoNota.Text = "Estado de Nota";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.BackColor = System.Drawing.Color.White;
            this.cmbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesional.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProfesional.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(29, 590);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(300, 31);
            this.cmbProfesional.TabIndex = 18;
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfesional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProfesional.Location = new System.Drawing.Point(25, 570);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(180, 46);
            this.lblProfesional.TabIndex = 17;
            this.lblProfesional.Text = "Profesional Registrado\r\n\r\n";
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaterial,
            this.colCantidad,
            this.colObservacion});
            this.dgvMateriales.Location = new System.Drawing.Point(29, 455);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.RowHeadersWidth = 51;
            this.dgvMateriales.Size = new System.Drawing.Size(840, 100);
            this.dgvMateriales.TabIndex = 16;
            // 
            // colMaterial
            // 
            this.colMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaterial.HeaderText = "Material";
            this.colMaterial.MinimumWidth = 6;
            this.colMaterial.Name = "colMaterial";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 60;
            // 
            // colObservacion
            // 
            this.colObservacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObservacion.HeaderText = "Observación";
            this.colObservacion.MinimumWidth = 6;
            this.colObservacion.Name = "colObservacion";
            // 
            // lblMateriales
            // 
            this.lblMateriales.AutoSize = true;
            this.lblMateriales.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMateriales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMateriales.Location = new System.Drawing.Point(25, 435);
            this.lblMateriales.Name = "lblMateriales";
            this.lblMateriales.Size = new System.Drawing.Size(248, 23);
            this.lblMateriales.TabIndex = 15;
            this.lblMateriales.Text = "Materiales / Insumos Utilizados";
            // 
            // txtComplicaciones
            // 
            this.txtComplicaciones.BackColor = System.Drawing.Color.White;
            this.txtComplicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplicaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComplicaciones.Location = new System.Drawing.Point(29, 370);
            this.txtComplicaciones.Multiline = true;
            this.txtComplicaciones.Name = "txtComplicaciones";
            this.txtComplicaciones.Size = new System.Drawing.Size(840, 50);
            this.txtComplicaciones.TabIndex = 14;
            // 
            // lblComplicaciones
            // 
            this.lblComplicaciones.AutoSize = true;
            this.lblComplicaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblComplicaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblComplicaciones.Location = new System.Drawing.Point(25, 350);
            this.lblComplicaciones.Name = "lblComplicaciones";
            this.lblComplicaciones.Size = new System.Drawing.Size(129, 23);
            this.lblComplicaciones.TabIndex = 13;
            this.lblComplicaciones.Text = "Complicaciones";
            // 
            // rtbHallazgos
            // 
            this.rtbHallazgos.BackColor = System.Drawing.Color.White;
            this.rtbHallazgos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbHallazgos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbHallazgos.Location = new System.Drawing.Point(459, 235);
            this.rtbHallazgos.Name = "rtbHallazgos";
            this.rtbHallazgos.Size = new System.Drawing.Size(410, 100);
            this.rtbHallazgos.TabIndex = 12;
            this.rtbHallazgos.Text = "";
            // 
            // lblHallazgos
            // 
            this.lblHallazgos.AutoSize = true;
            this.lblHallazgos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHallazgos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHallazgos.Location = new System.Drawing.Point(455, 215);
            this.lblHallazgos.Name = "lblHallazgos";
            this.lblHallazgos.Size = new System.Drawing.Size(83, 23);
            this.lblHallazgos.TabIndex = 11;
            this.lblHallazgos.Text = "Hallazgos";
            // 
            // rtbTecnica
            // 
            this.rtbTecnica.BackColor = System.Drawing.Color.White;
            this.rtbTecnica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTecnica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbTecnica.Location = new System.Drawing.Point(29, 235);
            this.rtbTecnica.Name = "rtbTecnica";
            this.rtbTecnica.Size = new System.Drawing.Size(410, 100);
            this.rtbTecnica.TabIndex = 10;
            this.rtbTecnica.Text = "";
            // 
            // lblTecnica
            // 
            this.lblTecnica.AutoSize = true;
            this.lblTecnica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTecnica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTecnica.Location = new System.Drawing.Point(25, 215);
            this.lblTecnica.Name = "lblTecnica";
            this.lblTecnica.Size = new System.Drawing.Size(152, 23);
            this.lblTecnica.TabIndex = 9;
            this.lblTecnica.Text = "Técnica Operatoria";
            // 
            // txtDiagPost
            // 
            this.txtDiagPost.BackColor = System.Drawing.Color.White;
            this.txtDiagPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagPost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiagPost.Location = new System.Drawing.Point(29, 150);
            this.txtDiagPost.Multiline = true;
            this.txtDiagPost.Name = "txtDiagPost";
            this.txtDiagPost.Size = new System.Drawing.Size(840, 50);
            this.txtDiagPost.TabIndex = 8;
            // 
            // lblDiagPost
            // 
            this.lblDiagPost.AutoSize = true;
            this.lblDiagPost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiagPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiagPost.Location = new System.Drawing.Point(25, 130);
            this.lblDiagPost.Name = "lblDiagPost";
            this.lblDiagPost.Size = new System.Drawing.Size(217, 23);
            this.lblDiagPost.TabIndex = 7;
            this.lblDiagPost.Text = "Diagnóstico Postoperatorio";
            // 
            // dtpFinReal
            // 
            this.dtpFinReal.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFinReal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFinReal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinReal.Location = new System.Drawing.Point(649, 90);
            this.dtpFinReal.Name = "dtpFinReal";
            this.dtpFinReal.Size = new System.Drawing.Size(180, 30);
            this.dtpFinReal.TabIndex = 6;
            // 
            // lblFinReal
            // 
            this.lblFinReal.AutoSize = true;
            this.lblFinReal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFinReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFinReal.Location = new System.Drawing.Point(645, 70);
            this.lblFinReal.Name = "lblFinReal";
            this.lblFinReal.Size = new System.Drawing.Size(162, 23);
            this.lblFinReal.TabIndex = 5;
            this.lblFinReal.Text = "Fecha/Hora Real Fin";
            // 
            // dtpInicioReal
            // 
            this.dtpInicioReal.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInicioReal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpInicioReal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioReal.Location = new System.Drawing.Point(449, 90);
            this.dtpInicioReal.Name = "dtpInicioReal";
            this.dtpInicioReal.Size = new System.Drawing.Size(180, 30);
            this.dtpInicioReal.TabIndex = 4;
            // 
            // lblInicioReal
            // 
            this.lblInicioReal.AutoSize = true;
            this.lblInicioReal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInicioReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInicioReal.Location = new System.Drawing.Point(445, 70);
            this.lblInicioReal.Name = "lblInicioReal";
            this.lblInicioReal.Size = new System.Drawing.Size(159, 23);
            this.lblInicioReal.TabIndex = 3;
            this.lblInicioReal.Text = "Fecha/Hora Real In.";
            // 
            // cmbCirugiaSel
            // 
            this.cmbCirugiaSel.BackColor = System.Drawing.Color.White;
            this.cmbCirugiaSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCirugiaSel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCirugiaSel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCirugiaSel.FormattingEnabled = true;
            this.cmbCirugiaSel.Location = new System.Drawing.Point(29, 90);
            this.cmbCirugiaSel.Name = "cmbCirugiaSel";
            this.cmbCirugiaSel.Size = new System.Drawing.Size(400, 31);
            this.cmbCirugiaSel.TabIndex = 2;
            // 
            // lblCirugiaSel
            // 
            this.lblCirugiaSel.AutoSize = true;
            this.lblCirugiaSel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCirugiaSel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCirugiaSel.Location = new System.Drawing.Point(25, 70);
            this.lblCirugiaSel.Name = "lblCirugiaSel";
            this.lblCirugiaSel.Size = new System.Drawing.Size(155, 23);
            this.lblCirugiaSel.TabIndex = 1;
            this.lblCirugiaSel.Text = "Seleccionar Cirugía";
            // 
            // Modulo10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Modulo10";
            this.Size = new System.Drawing.Size(950, 750);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabAgenda.ResumeLayout(false);
            this.pnlAgendaContent.ResumeLayout(false);
            this.pnlAgendaContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            this.tabNota.ResumeLayout(false);
            this.pnlNotaContent.ResumeLayout(false);
            this.pnlNotaContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabAgenda;
        private System.Windows.Forms.TabPage tabNota;

        // --- CONTROLES AGENDA ---
        private System.Windows.Forms.Panel pnlAgendaContent;
        private System.Windows.Forms.Label lblTituloAgenda;
        private System.Windows.Forms.Label lblIdCirugia;
        private System.Windows.Forms.TextBox txtIdCirugia;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label lblCirujano;
        private System.Windows.Forms.ComboBox cmbCirujano;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label lblTipoCirugia;
        private System.Windows.Forms.ComboBox cmbTipoCirugia;
        private System.Windows.Forms.Label lblDiagPre;
        private System.Windows.Forms.TextBox txtDiagPre;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnProgramar;

        // --- CONTROLES NOTA ---
        private System.Windows.Forms.Panel pnlNotaContent;
        private System.Windows.Forms.Label lblTituloNota;
        private System.Windows.Forms.Label lblCirugiaSel;
        private System.Windows.Forms.ComboBox cmbCirugiaSel;
        private System.Windows.Forms.Label lblInicioReal;
        private System.Windows.Forms.DateTimePicker dtpInicioReal;
        private System.Windows.Forms.Label lblFinReal;
        private System.Windows.Forms.DateTimePicker dtpFinReal;
        private System.Windows.Forms.Label lblDiagPost;
        private System.Windows.Forms.TextBox txtDiagPost;
        private System.Windows.Forms.Label lblTecnica;
        private System.Windows.Forms.RichTextBox rtbTecnica;
        private System.Windows.Forms.Label lblHallazgos;
        private System.Windows.Forms.RichTextBox rtbHallazgos;
        private System.Windows.Forms.Label lblComplicaciones;
        private System.Windows.Forms.TextBox txtComplicaciones;
        private System.Windows.Forms.Label lblMateriales;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label lblEstadoNota;
        private System.Windows.Forms.ComboBox cmbEstadoNota;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.Button btnImprimir;
    }
}