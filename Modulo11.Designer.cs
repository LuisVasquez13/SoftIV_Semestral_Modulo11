// Modulo11.Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Borrador
{
    partial class Modulo11
    {
        private IContainer components = null;

        // Controles (Facturación)
        private TabControl tabControl;
        private TabPage tabFacturacion;
        private TabPage tabCaja;

        // Nuevo Título Facturación
        private Label lblTituloF;

        private Label lblNumFacturaF;
        private TextBox txtNumFacturaF;

        private Label lblPacienteF;
        private ComboBox cmbPacienteF;

        private Label lblAseguradoraF;
        private ComboBox cmbAseguradoraF;

        private Label lblPolizaF;
        private TextBox txtPolizaF;

        private Label lblFechaFacturaF;
        private DateTimePicker dtpFechaFacturaF;

        private GroupBox grpServiciosF;
        private DataGridView dgvServiciosF;

        private Label lblSubtotalF;
        private TextBox txtSubtotalF;

        private Label lblDescuentoF;
        private NumericUpDown nudDescuentoF;

        private Label lblImpuestoF;
        private NumericUpDown nudImpuestoF;

        private Label lblTotalF;
        private TextBox txtTotalF;

        private Label lblEstadoFacturaF;
        private ComboBox cmbEstadoFacturaF;

        private Label lblObservacionesF;
        private TextBox txtObservacionesF;

        private Button btnCalcularF;
        private Button btnGuardarImprimirF;

        // Controles (Caja Pagos)
        // Nuevo Título Caja
        private Label lblTituloC;

        private Label lblNumFacturaC;
        private ComboBox cmbNumFacturaC;

        private Label lblPacienteC;
        private TextBox txtPacienteC;

        private Label lblTotalFacturaC;
        private TextBox txtTotalFacturaC;

        private Label lblMontoPagadoC;
        private TextBox txtMontoPagadoC;

        private Label lblMontoPagarC;
        private NumericUpDown nudMontoPagarC;

        private Label lblFormaPagoC;
        private ComboBox cmbFormaPagoC;

        private Label lblFechaPagoC;
        private DateTimePicker dtpFechaPagoC;

        private Label lblReferenciaC;
        private TextBox txtReferenciaC;

        private Label lblObservacionesC;
        private TextBox txtObservacionesC;

        private Label lblEstadoPagoC;
        private ComboBox cmbEstadoPagoC;

        private Button btnRegistrarPagoC;
        private Button btnImprimirReciboC;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFacturacion = new System.Windows.Forms.TabPage();
            this.lblTituloF = new System.Windows.Forms.Label();
            this.lblNumFacturaF = new System.Windows.Forms.Label();
            this.txtNumFacturaF = new System.Windows.Forms.TextBox();
            this.lblPacienteF = new System.Windows.Forms.Label();
            this.cmbPacienteF = new System.Windows.Forms.ComboBox();
            this.lblAseguradoraF = new System.Windows.Forms.Label();
            this.cmbAseguradoraF = new System.Windows.Forms.ComboBox();
            this.lblPolizaF = new System.Windows.Forms.Label();
            this.txtPolizaF = new System.Windows.Forms.TextBox();
            this.lblFechaFacturaF = new System.Windows.Forms.Label();
            this.dtpFechaFacturaF = new System.Windows.Forms.DateTimePicker();
            this.grpServiciosF = new System.Windows.Forms.GroupBox();
            this.dgvServiciosF = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtotalF = new System.Windows.Forms.Label();
            this.txtSubtotalF = new System.Windows.Forms.TextBox();
            this.lblDescuentoF = new System.Windows.Forms.Label();
            this.nudDescuentoF = new System.Windows.Forms.NumericUpDown();
            this.lblImpuestoF = new System.Windows.Forms.Label();
            this.nudImpuestoF = new System.Windows.Forms.NumericUpDown();
            this.lblTotalF = new System.Windows.Forms.Label();
            this.txtTotalF = new System.Windows.Forms.TextBox();
            this.lblEstadoFacturaF = new System.Windows.Forms.Label();
            this.cmbEstadoFacturaF = new System.Windows.Forms.ComboBox();
            this.lblObservacionesF = new System.Windows.Forms.Label();
            this.txtObservacionesF = new System.Windows.Forms.TextBox();
            this.btnCalcularF = new System.Windows.Forms.Button();
            this.btnGuardarImprimirF = new System.Windows.Forms.Button();
            this.tabCaja = new System.Windows.Forms.TabPage();
            this.lblTituloC = new System.Windows.Forms.Label();
            this.lblNumFacturaC = new System.Windows.Forms.Label();
            this.cmbNumFacturaC = new System.Windows.Forms.ComboBox();
            this.lblPacienteC = new System.Windows.Forms.Label();
            this.txtPacienteC = new System.Windows.Forms.TextBox();
            this.lblTotalFacturaC = new System.Windows.Forms.Label();
            this.txtTotalFacturaC = new System.Windows.Forms.TextBox();
            this.lblMontoPagadoC = new System.Windows.Forms.Label();
            this.txtMontoPagadoC = new System.Windows.Forms.TextBox();
            this.lblMontoPagarC = new System.Windows.Forms.Label();
            this.nudMontoPagarC = new System.Windows.Forms.NumericUpDown();
            this.lblFormaPagoC = new System.Windows.Forms.Label();
            this.cmbFormaPagoC = new System.Windows.Forms.ComboBox();
            this.lblFechaPagoC = new System.Windows.Forms.Label();
            this.dtpFechaPagoC = new System.Windows.Forms.DateTimePicker();
            this.lblReferenciaC = new System.Windows.Forms.Label();
            this.txtReferenciaC = new System.Windows.Forms.TextBox();
            this.lblObservacionesC = new System.Windows.Forms.Label();
            this.txtObservacionesC = new System.Windows.Forms.TextBox();
            this.lblEstadoPagoC = new System.Windows.Forms.Label();
            this.cmbEstadoPagoC = new System.Windows.Forms.ComboBox();
            this.btnRegistrarPagoC = new System.Windows.Forms.Button();
            this.btnImprimirReciboC = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabFacturacion.SuspendLayout();
            this.grpServiciosF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuentoF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImpuestoF)).BeginInit();
            this.tabCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagarC)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabFacturacion);
            this.tabControl.Controls.Add(this.tabCaja);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1339, 953);
            this.tabControl.TabIndex = 0;
            // 
            // tabFacturacion
            // 
            this.tabFacturacion.AutoScroll = true;
            this.tabFacturacion.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.tabFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.tabFacturacion.Controls.Add(this.lblTituloF);
            this.tabFacturacion.Controls.Add(this.lblNumFacturaF);
            this.tabFacturacion.Controls.Add(this.txtNumFacturaF);
            this.tabFacturacion.Controls.Add(this.lblPacienteF);
            this.tabFacturacion.Controls.Add(this.cmbPacienteF);
            this.tabFacturacion.Controls.Add(this.lblAseguradoraF);
            this.tabFacturacion.Controls.Add(this.cmbAseguradoraF);
            this.tabFacturacion.Controls.Add(this.lblPolizaF);
            this.tabFacturacion.Controls.Add(this.txtPolizaF);
            this.tabFacturacion.Controls.Add(this.lblFechaFacturaF);
            this.tabFacturacion.Controls.Add(this.dtpFechaFacturaF);
            this.tabFacturacion.Controls.Add(this.grpServiciosF);
            this.tabFacturacion.Controls.Add(this.lblSubtotalF);
            this.tabFacturacion.Controls.Add(this.txtSubtotalF);
            this.tabFacturacion.Controls.Add(this.lblDescuentoF);
            this.tabFacturacion.Controls.Add(this.nudDescuentoF);
            this.tabFacturacion.Controls.Add(this.lblImpuestoF);
            this.tabFacturacion.Controls.Add(this.nudImpuestoF);
            this.tabFacturacion.Controls.Add(this.lblTotalF);
            this.tabFacturacion.Controls.Add(this.txtTotalF);
            this.tabFacturacion.Controls.Add(this.lblEstadoFacturaF);
            this.tabFacturacion.Controls.Add(this.cmbEstadoFacturaF);
            this.tabFacturacion.Controls.Add(this.lblObservacionesF);
            this.tabFacturacion.Controls.Add(this.txtObservacionesF);
            this.tabFacturacion.Controls.Add(this.btnCalcularF);
            this.tabFacturacion.Controls.Add(this.btnGuardarImprimirF);
            this.tabFacturacion.Location = new System.Drawing.Point(4, 25);
            this.tabFacturacion.Name = "tabFacturacion";
            this.tabFacturacion.Padding = new System.Windows.Forms.Padding(5);
            this.tabFacturacion.Size = new System.Drawing.Size(1331, 924);
            this.tabFacturacion.TabIndex = 0;
            this.tabFacturacion.Text = "Facturación";
            // 
            // lblTituloF
            // 
            this.lblTituloF.AutoSize = true;
            this.lblTituloF.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTituloF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTituloF.Location = new System.Drawing.Point(28, 10);
            this.lblTituloF.Name = "lblTituloF";
            this.lblTituloF.Size = new System.Drawing.Size(289, 52);
            this.lblTituloF.TabIndex = 0;
            this.lblTituloF.Text = "FACTURACIÓN";
            // 
            // lblNumFacturaF
            // 
            this.lblNumFacturaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumFacturaF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumFacturaF.Location = new System.Drawing.Point(30, 80);
            this.lblNumFacturaF.Name = "lblNumFacturaF";
            this.lblNumFacturaF.Size = new System.Drawing.Size(100, 23);
            this.lblNumFacturaF.TabIndex = 1;
            this.lblNumFacturaF.Text = "N° Factura:";
            // 
            // txtNumFacturaF
            // 
            this.txtNumFacturaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumFacturaF.Location = new System.Drawing.Point(150, 77);
            this.txtNumFacturaF.Name = "txtNumFacturaF";
            this.txtNumFacturaF.Size = new System.Drawing.Size(300, 30);
            this.txtNumFacturaF.TabIndex = 2;
            // 
            // lblPacienteF
            // 
            this.lblPacienteF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPacienteF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPacienteF.Location = new System.Drawing.Point(30, 120);
            this.lblPacienteF.Name = "lblPacienteF";
            this.lblPacienteF.Size = new System.Drawing.Size(100, 23);
            this.lblPacienteF.TabIndex = 3;
            this.lblPacienteF.Text = "Paciente (*):";
            // 
            // cmbPacienteF
            // 
            this.cmbPacienteF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacienteF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPacienteF.Location = new System.Drawing.Point(150, 117);
            this.cmbPacienteF.Name = "cmbPacienteF";
            this.cmbPacienteF.Size = new System.Drawing.Size(300, 31);
            this.cmbPacienteF.TabIndex = 4;
            // 
            // lblAseguradoraF
            // 
            this.lblAseguradoraF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAseguradoraF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAseguradoraF.Location = new System.Drawing.Point(30, 160);
            this.lblAseguradoraF.Name = "lblAseguradoraF";
            this.lblAseguradoraF.Size = new System.Drawing.Size(100, 23);
            this.lblAseguradoraF.TabIndex = 5;
            this.lblAseguradoraF.Text = "Aseguradora:";
            // 
            // cmbAseguradoraF
            // 
            this.cmbAseguradoraF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAseguradoraF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAseguradoraF.Location = new System.Drawing.Point(150, 157);
            this.cmbAseguradoraF.Name = "cmbAseguradoraF";
            this.cmbAseguradoraF.Size = new System.Drawing.Size(300, 31);
            this.cmbAseguradoraF.TabIndex = 6;
            // 
            // lblPolizaF
            // 
            this.lblPolizaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPolizaF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPolizaF.Location = new System.Drawing.Point(30, 200);
            this.lblPolizaF.Name = "lblPolizaF";
            this.lblPolizaF.Size = new System.Drawing.Size(100, 23);
            this.lblPolizaF.TabIndex = 7;
            this.lblPolizaF.Text = "N° Póliza:";
            // 
            // txtPolizaF
            // 
            this.txtPolizaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPolizaF.Location = new System.Drawing.Point(150, 197);
            this.txtPolizaF.Name = "txtPolizaF";
            this.txtPolizaF.Size = new System.Drawing.Size(300, 30);
            this.txtPolizaF.TabIndex = 8;
            // 
            // lblFechaFacturaF
            // 
            this.lblFechaFacturaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaFacturaF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaFacturaF.Location = new System.Drawing.Point(30, 240);
            this.lblFechaFacturaF.Name = "lblFechaFacturaF";
            this.lblFechaFacturaF.Size = new System.Drawing.Size(120, 23);
            this.lblFechaFacturaF.TabIndex = 9;
            this.lblFechaFacturaF.Text = "Fecha Factura (*):";
            // 
            // dtpFechaFacturaF
            // 
            this.dtpFechaFacturaF.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpFechaFacturaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaFacturaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFacturaF.Location = new System.Drawing.Point(150, 237);
            this.dtpFechaFacturaF.Name = "dtpFechaFacturaF";
            this.dtpFechaFacturaF.Size = new System.Drawing.Size(300, 30);
            this.dtpFechaFacturaF.TabIndex = 10;
            // 
            // grpServiciosF
            // 
            this.grpServiciosF.Controls.Add(this.dgvServiciosF);
            this.grpServiciosF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpServiciosF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpServiciosF.Location = new System.Drawing.Point(30, 285);
            this.grpServiciosF.Name = "grpServiciosF";
            this.grpServiciosF.Size = new System.Drawing.Size(760, 220);
            this.grpServiciosF.TabIndex = 11;
            this.grpServiciosF.TabStop = false;
            this.grpServiciosF.Text = "Servicios (Detalle)";
            // 
            // dgvServiciosF
            // 
            this.dgvServiciosF.AllowUserToAddRows = false;
            this.dgvServiciosF.AllowUserToDeleteRows = false;
            this.dgvServiciosF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiciosF.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiciosF.ColumnHeadersHeight = 29;
            this.dgvServiciosF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvServiciosF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiciosF.Location = new System.Drawing.Point(3, 26);
            this.dgvServiciosF.MultiSelect = false;
            this.dgvServiciosF.Name = "dgvServiciosF";
            this.dgvServiciosF.ReadOnly = true;
            this.dgvServiciosF.RowHeadersVisible = false;
            this.dgvServiciosF.RowHeadersWidth = 51;
            this.dgvServiciosF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiciosF.Size = new System.Drawing.Size(754, 191);
            this.dgvServiciosF.TabIndex = 0;
            this.dgvServiciosF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiciosF_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unit.";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblSubtotalF
            // 
            this.lblSubtotalF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtotalF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubtotalF.Location = new System.Drawing.Point(30, 520);
            this.lblSubtotalF.Name = "lblSubtotalF";
            this.lblSubtotalF.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalF.TabIndex = 12;
            this.lblSubtotalF.Text = "Subtotal (*):";
            // 
            // txtSubtotalF
            // 
            this.txtSubtotalF.BackColor = System.Drawing.Color.White;
            this.txtSubtotalF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSubtotalF.Location = new System.Drawing.Point(150, 517);
            this.txtSubtotalF.Name = "txtSubtotalF";
            this.txtSubtotalF.ReadOnly = true;
            this.txtSubtotalF.Size = new System.Drawing.Size(300, 30);
            this.txtSubtotalF.TabIndex = 13;
            // 
            // lblDescuentoF
            // 
            this.lblDescuentoF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescuentoF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescuentoF.Location = new System.Drawing.Point(30, 560);
            this.lblDescuentoF.Name = "lblDescuentoF";
            this.lblDescuentoF.Size = new System.Drawing.Size(100, 23);
            this.lblDescuentoF.TabIndex = 14;
            this.lblDescuentoF.Text = "Descuento (%):";
            // 
            // nudDescuentoF
            // 
            this.nudDescuentoF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudDescuentoF.Location = new System.Drawing.Point(150, 557);
            this.nudDescuentoF.Name = "nudDescuentoF";
            this.nudDescuentoF.Size = new System.Drawing.Size(300, 30);
            this.nudDescuentoF.TabIndex = 15;
            // 
            // lblImpuestoF
            // 
            this.lblImpuestoF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblImpuestoF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImpuestoF.Location = new System.Drawing.Point(30, 600);
            this.lblImpuestoF.Name = "lblImpuestoF";
            this.lblImpuestoF.Size = new System.Drawing.Size(100, 23);
            this.lblImpuestoF.TabIndex = 16;
            this.lblImpuestoF.Text = "Impuesto (%):";
            // 
            // nudImpuestoF
            // 
            this.nudImpuestoF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudImpuestoF.Location = new System.Drawing.Point(150, 597);
            this.nudImpuestoF.Name = "nudImpuestoF";
            this.nudImpuestoF.Size = new System.Drawing.Size(300, 30);
            this.nudImpuestoF.TabIndex = 17;
            // 
            // lblTotalF
            // 
            this.lblTotalF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalF.Location = new System.Drawing.Point(30, 640);
            this.lblTotalF.Name = "lblTotalF";
            this.lblTotalF.Size = new System.Drawing.Size(100, 23);
            this.lblTotalF.TabIndex = 18;
            this.lblTotalF.Text = "Total (*):";
            // 
            // txtTotalF
            // 
            this.txtTotalF.BackColor = System.Drawing.Color.White;
            this.txtTotalF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalF.Location = new System.Drawing.Point(150, 637);
            this.txtTotalF.Name = "txtTotalF";
            this.txtTotalF.ReadOnly = true;
            this.txtTotalF.Size = new System.Drawing.Size(300, 30);
            this.txtTotalF.TabIndex = 19;
            // 
            // lblEstadoFacturaF
            // 
            this.lblEstadoFacturaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstadoFacturaF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoFacturaF.Location = new System.Drawing.Point(30, 680);
            this.lblEstadoFacturaF.Name = "lblEstadoFacturaF";
            this.lblEstadoFacturaF.Size = new System.Drawing.Size(120, 23);
            this.lblEstadoFacturaF.TabIndex = 20;
            this.lblEstadoFacturaF.Text = "Estado factura (*):";
            // 
            // cmbEstadoFacturaF
            // 
            this.cmbEstadoFacturaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFacturaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoFacturaF.Items.AddRange(new object[] {
            "Pagada",
            "Pendiente"});
            this.cmbEstadoFacturaF.Location = new System.Drawing.Point(150, 677);
            this.cmbEstadoFacturaF.Name = "cmbEstadoFacturaF";
            this.cmbEstadoFacturaF.Size = new System.Drawing.Size(300, 31);
            this.cmbEstadoFacturaF.TabIndex = 21;
            // 
            // lblObservacionesF
            // 
            this.lblObservacionesF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblObservacionesF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObservacionesF.Location = new System.Drawing.Point(30, 720);
            this.lblObservacionesF.Name = "lblObservacionesF";
            this.lblObservacionesF.Size = new System.Drawing.Size(100, 23);
            this.lblObservacionesF.TabIndex = 22;
            this.lblObservacionesF.Text = "Observaciones:";
            // 
            // txtObservacionesF
            // 
            this.txtObservacionesF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservacionesF.Location = new System.Drawing.Point(150, 717);
            this.txtObservacionesF.Multiline = true;
            this.txtObservacionesF.Name = "txtObservacionesF";
            this.txtObservacionesF.Size = new System.Drawing.Size(500, 70);
            this.txtObservacionesF.TabIndex = 23;
            // 
            // btnCalcularF
            // 
            this.btnCalcularF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(95)))), ((int)(((byte)(166)))));
            this.btnCalcularF.FlatAppearance.BorderSize = 0;
            this.btnCalcularF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcularF.ForeColor = System.Drawing.Color.White;
            this.btnCalcularF.Location = new System.Drawing.Point(48, 800);
            this.btnCalcularF.Name = "btnCalcularF";
            this.btnCalcularF.Size = new System.Drawing.Size(182, 35);
            this.btnCalcularF.TabIndex = 24;
            this.btnCalcularF.Text = "Calcular";
            this.btnCalcularF.UseVisualStyleBackColor = false;
            // 
            // btnGuardarImprimirF
            // 
            this.btnGuardarImprimirF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(95)))), ((int)(((byte)(166)))));
            this.btnGuardarImprimirF.FlatAppearance.BorderSize = 0;
            this.btnGuardarImprimirF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarImprimirF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarImprimirF.ForeColor = System.Drawing.Color.White;
            this.btnGuardarImprimirF.Location = new System.Drawing.Point(321, 800);
            this.btnGuardarImprimirF.Name = "btnGuardarImprimirF";
            this.btnGuardarImprimirF.Size = new System.Drawing.Size(245, 35);
            this.btnGuardarImprimirF.TabIndex = 25;
            this.btnGuardarImprimirF.Text = "Guardar";
            this.btnGuardarImprimirF.UseVisualStyleBackColor = false;
            // 
            // tabCaja
            // 
            this.tabCaja.AutoScroll = true;
            this.tabCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.tabCaja.Controls.Add(this.lblTituloC);
            this.tabCaja.Controls.Add(this.lblNumFacturaC);
            this.tabCaja.Controls.Add(this.cmbNumFacturaC);
            this.tabCaja.Controls.Add(this.lblPacienteC);
            this.tabCaja.Controls.Add(this.txtPacienteC);
            this.tabCaja.Controls.Add(this.lblTotalFacturaC);
            this.tabCaja.Controls.Add(this.txtTotalFacturaC);
            this.tabCaja.Controls.Add(this.lblMontoPagadoC);
            this.tabCaja.Controls.Add(this.txtMontoPagadoC);
            this.tabCaja.Controls.Add(this.lblMontoPagarC);
            this.tabCaja.Controls.Add(this.nudMontoPagarC);
            this.tabCaja.Controls.Add(this.lblFormaPagoC);
            this.tabCaja.Controls.Add(this.cmbFormaPagoC);
            this.tabCaja.Controls.Add(this.lblFechaPagoC);
            this.tabCaja.Controls.Add(this.dtpFechaPagoC);
            this.tabCaja.Controls.Add(this.lblReferenciaC);
            this.tabCaja.Controls.Add(this.txtReferenciaC);
            this.tabCaja.Controls.Add(this.lblObservacionesC);
            this.tabCaja.Controls.Add(this.txtObservacionesC);
            this.tabCaja.Controls.Add(this.lblEstadoPagoC);
            this.tabCaja.Controls.Add(this.cmbEstadoPagoC);
            this.tabCaja.Controls.Add(this.btnRegistrarPagoC);
            this.tabCaja.Controls.Add(this.btnImprimirReciboC);
            this.tabCaja.Location = new System.Drawing.Point(4, 25);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(5);
            this.tabCaja.Size = new System.Drawing.Size(1331, 924);
            this.tabCaja.TabIndex = 1;
            this.tabCaja.Text = "Caja Pagos";
            // 
            // lblTituloC
            // 
            this.lblTituloC.AutoSize = true;
            this.lblTituloC.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTituloC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTituloC.Location = new System.Drawing.Point(28, 10);
            this.lblTituloC.Name = "lblTituloC";
            this.lblTituloC.Size = new System.Drawing.Size(257, 52);
            this.lblTituloC.TabIndex = 0;
            this.lblTituloC.Text = "CAJA PAGOS";
            // 
            // lblNumFacturaC
            // 
            this.lblNumFacturaC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumFacturaC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumFacturaC.Location = new System.Drawing.Point(21, 98);
            this.lblNumFacturaC.Name = "lblNumFacturaC";
            this.lblNumFacturaC.Size = new System.Drawing.Size(134, 23);
            this.lblNumFacturaC.TabIndex = 1;
            this.lblNumFacturaC.Text = "N° Factura (*):";
            // 
            // cmbNumFacturaC
            // 
            this.cmbNumFacturaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumFacturaC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNumFacturaC.Location = new System.Drawing.Point(186, 95);
            this.cmbNumFacturaC.Name = "cmbNumFacturaC";
            this.cmbNumFacturaC.Size = new System.Drawing.Size(301, 31);
            this.cmbNumFacturaC.TabIndex = 2;
            this.cmbNumFacturaC.SelectedIndexChanged += new System.EventHandler(this.cmbNumFacturaC_SelectedIndexChanged_1);
            // 
            // lblPacienteC
            // 
            this.lblPacienteC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPacienteC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPacienteC.Location = new System.Drawing.Point(21, 138);
            this.lblPacienteC.Name = "lblPacienteC";
            this.lblPacienteC.Size = new System.Drawing.Size(100, 23);
            this.lblPacienteC.TabIndex = 3;
            this.lblPacienteC.Text = "Paciente:";
            // 
            // txtPacienteC
            // 
            this.txtPacienteC.BackColor = System.Drawing.Color.White;
            this.txtPacienteC.Enabled = false;
            this.txtPacienteC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPacienteC.Location = new System.Drawing.Point(187, 135);
            this.txtPacienteC.Name = "txtPacienteC";
            this.txtPacienteC.ReadOnly = true;
            this.txtPacienteC.Size = new System.Drawing.Size(300, 30);
            this.txtPacienteC.TabIndex = 4;
            this.txtPacienteC.TextChanged += new System.EventHandler(this.txtPacienteC_TextChanged);
            // 
            // lblTotalFacturaC
            // 
            this.lblTotalFacturaC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalFacturaC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalFacturaC.Location = new System.Drawing.Point(21, 178);
            this.lblTotalFacturaC.Name = "lblTotalFacturaC";
            this.lblTotalFacturaC.Size = new System.Drawing.Size(168, 23);
            this.lblTotalFacturaC.TabIndex = 5;
            this.lblTotalFacturaC.Text = "Monto total factura:";
            // 
            // txtTotalFacturaC
            // 
            this.txtTotalFacturaC.BackColor = System.Drawing.Color.White;
            this.txtTotalFacturaC.Enabled = false;
            this.txtTotalFacturaC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalFacturaC.Location = new System.Drawing.Point(187, 175);
            this.txtTotalFacturaC.Name = "txtTotalFacturaC";
            this.txtTotalFacturaC.ReadOnly = true;
            this.txtTotalFacturaC.Size = new System.Drawing.Size(300, 30);
            this.txtTotalFacturaC.TabIndex = 6;
            this.txtTotalFacturaC.TextChanged += new System.EventHandler(this.txtTotalFacturaC_TextChanged);
            // 
            // lblMontoPagadoC
            // 
            this.lblMontoPagadoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMontoPagadoC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMontoPagadoC.Location = new System.Drawing.Point(21, 218);
            this.lblMontoPagadoC.Name = "lblMontoPagadoC";
            this.lblMontoPagadoC.Size = new System.Drawing.Size(154, 23);
            this.lblMontoPagadoC.TabIndex = 7;
            this.lblMontoPagadoC.Text = "Monto ya pagado:";
            // 
            // txtMontoPagadoC
            // 
            this.txtMontoPagadoC.BackColor = System.Drawing.Color.White;
            this.txtMontoPagadoC.Enabled = false;
            this.txtMontoPagadoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMontoPagadoC.Location = new System.Drawing.Point(187, 215);
            this.txtMontoPagadoC.Name = "txtMontoPagadoC";
            this.txtMontoPagadoC.ReadOnly = true;
            this.txtMontoPagadoC.Size = new System.Drawing.Size(300, 30);
            this.txtMontoPagadoC.TabIndex = 8;
            this.txtMontoPagadoC.TextChanged += new System.EventHandler(this.txtMontoPagadoC_TextChanged);
            // 
            // lblMontoPagarC
            // 
            this.lblMontoPagarC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMontoPagarC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMontoPagarC.Location = new System.Drawing.Point(21, 258);
            this.lblMontoPagarC.Name = "lblMontoPagarC";
            this.lblMontoPagarC.Size = new System.Drawing.Size(168, 23);
            this.lblMontoPagarC.TabIndex = 9;
            this.lblMontoPagarC.Text = "Monto a pagar (*):";
            // 
            // nudMontoPagarC
            // 
            this.nudMontoPagarC.DecimalPlaces = 2;
            this.nudMontoPagarC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudMontoPagarC.Location = new System.Drawing.Point(187, 255);
            this.nudMontoPagarC.Name = "nudMontoPagarC";
            this.nudMontoPagarC.Size = new System.Drawing.Size(300, 30);
            this.nudMontoPagarC.TabIndex = 10;
            this.nudMontoPagarC.ValueChanged += new System.EventHandler(this.nudMontoPagarC_ValueChanged);
            // 
            // lblFormaPagoC
            // 
            this.lblFormaPagoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFormaPagoC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFormaPagoC.Location = new System.Drawing.Point(21, 298);
            this.lblFormaPagoC.Name = "lblFormaPagoC";
            this.lblFormaPagoC.Size = new System.Drawing.Size(168, 23);
            this.lblFormaPagoC.TabIndex = 11;
            this.lblFormaPagoC.Text = "Forma de pago (*):";
            // 
            // cmbFormaPagoC
            // 
            this.cmbFormaPagoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFormaPagoC.Items.AddRange(new object[] {
            "Seguro",
            "Efectivo",
            "Tarjeta"});
            this.cmbFormaPagoC.Location = new System.Drawing.Point(187, 295);
            this.cmbFormaPagoC.Name = "cmbFormaPagoC";
            this.cmbFormaPagoC.Size = new System.Drawing.Size(300, 31);
            this.cmbFormaPagoC.TabIndex = 12;
            this.cmbFormaPagoC.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPagoC_SelectedIndexChanged);
            // 
            // lblFechaPagoC
            // 
            this.lblFechaPagoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaPagoC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaPagoC.Location = new System.Drawing.Point(21, 338);
            this.lblFechaPagoC.Name = "lblFechaPagoC";
            this.lblFechaPagoC.Size = new System.Drawing.Size(134, 23);
            this.lblFechaPagoC.TabIndex = 13;
            this.lblFechaPagoC.Text = "Fecha pago (*):";
            // 
            // dtpFechaPagoC
            // 
            this.dtpFechaPagoC.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpFechaPagoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaPagoC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPagoC.Location = new System.Drawing.Point(187, 335);
            this.dtpFechaPagoC.Name = "dtpFechaPagoC";
            this.dtpFechaPagoC.Size = new System.Drawing.Size(300, 30);
            this.dtpFechaPagoC.TabIndex = 14;
            this.dtpFechaPagoC.ValueChanged += new System.EventHandler(this.dtpFechaPagoC_ValueChanged);
            // 
            // lblReferenciaC
            // 
            this.lblReferenciaC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReferenciaC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReferenciaC.Location = new System.Drawing.Point(21, 378);
            this.lblReferenciaC.Name = "lblReferenciaC";
            this.lblReferenciaC.Size = new System.Drawing.Size(108, 23);
            this.lblReferenciaC.TabIndex = 15;
            this.lblReferenciaC.Text = "Referencia:";
            // 
            // txtReferenciaC
            // 
            this.txtReferenciaC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReferenciaC.Location = new System.Drawing.Point(186, 375);
            this.txtReferenciaC.Name = "txtReferenciaC";
            this.txtReferenciaC.Size = new System.Drawing.Size(301, 30);
            this.txtReferenciaC.TabIndex = 16;
            this.txtReferenciaC.TextChanged += new System.EventHandler(this.txtReferenciaC_TextChanged);
            // 
            // lblObservacionesC
            // 
            this.lblObservacionesC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblObservacionesC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObservacionesC.Location = new System.Drawing.Point(21, 496);
            this.lblObservacionesC.Name = "lblObservacionesC";
            this.lblObservacionesC.Size = new System.Drawing.Size(134, 27);
            this.lblObservacionesC.TabIndex = 17;
            this.lblObservacionesC.Text = "Observaciones:";
            // 
            // txtObservacionesC
            // 
            this.txtObservacionesC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservacionesC.Location = new System.Drawing.Point(186, 430);
            this.txtObservacionesC.Multiline = true;
            this.txtObservacionesC.Name = "txtObservacionesC";
            this.txtObservacionesC.Size = new System.Drawing.Size(735, 151);
            this.txtObservacionesC.TabIndex = 18;
            this.txtObservacionesC.TextChanged += new System.EventHandler(this.txtObservacionesC_TextChanged);
            // 
            // lblEstadoPagoC
            // 
            this.lblEstadoPagoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstadoPagoC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoPagoC.Location = new System.Drawing.Point(21, 606);
            this.lblEstadoPagoC.Name = "lblEstadoPagoC";
            this.lblEstadoPagoC.Size = new System.Drawing.Size(100, 23);
            this.lblEstadoPagoC.TabIndex = 19;
            this.lblEstadoPagoC.Text = "Estado:";
            // 
            // cmbEstadoPagoC
            // 
            this.cmbEstadoPagoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPagoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoPagoC.Items.AddRange(new object[] {
            "Cancelado",
            "Parcial"});
            this.cmbEstadoPagoC.Location = new System.Drawing.Point(186, 603);
            this.cmbEstadoPagoC.Name = "cmbEstadoPagoC";
            this.cmbEstadoPagoC.Size = new System.Drawing.Size(301, 31);
            this.cmbEstadoPagoC.TabIndex = 20;
            this.cmbEstadoPagoC.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoPagoC_SelectedIndexChanged);
            // 
            // btnRegistrarPagoC
            // 
            this.btnRegistrarPagoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(95)))), ((int)(((byte)(166)))));
            this.btnRegistrarPagoC.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPagoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPagoC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarPagoC.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPagoC.Location = new System.Drawing.Point(412, 650);
            this.btnRegistrarPagoC.Name = "btnRegistrarPagoC";
            this.btnRegistrarPagoC.Size = new System.Drawing.Size(237, 48);
            this.btnRegistrarPagoC.TabIndex = 21;
            this.btnRegistrarPagoC.Text = "Registrar Pago";
            this.btnRegistrarPagoC.UseVisualStyleBackColor = false;
            // 
            // btnImprimirReciboC
            // 
            this.btnImprimirReciboC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(95)))), ((int)(((byte)(166)))));
            this.btnImprimirReciboC.FlatAppearance.BorderSize = 0;
            this.btnImprimirReciboC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirReciboC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimirReciboC.ForeColor = System.Drawing.Color.White;
            this.btnImprimirReciboC.Location = new System.Drawing.Point(680, 650);
            this.btnImprimirReciboC.Name = "btnImprimirReciboC";
            this.btnImprimirReciboC.Size = new System.Drawing.Size(241, 48);
            this.btnImprimirReciboC.TabIndex = 22;
            this.btnImprimirReciboC.Text = "Imprimir Recibo";
            this.btnImprimirReciboC.UseVisualStyleBackColor = false;
            // 
            // Modulo11
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(46)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.tabControl);
            this.Name = "Modulo11";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1359, 973);
            this.tabControl.ResumeLayout(false);
            this.tabFacturacion.ResumeLayout(false);
            this.tabFacturacion.PerformLayout();
            this.grpServiciosF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuentoF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImpuestoF)).EndInit();
            this.tabCaja.ResumeLayout(false);
            this.tabCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagarC)).EndInit();
            this.ResumeLayout(false);

        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}