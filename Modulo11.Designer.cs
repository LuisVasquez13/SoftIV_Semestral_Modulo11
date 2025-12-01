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
            this.tabControl.Size = new System.Drawing.Size(836, 589);
            this.tabControl.TabIndex = 0;
            // 
            // tabFacturacion
            // 
            this.tabFacturacion.AutoScroll = true;
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
            this.tabFacturacion.Location = new System.Drawing.Point(4, 22);
            this.tabFacturacion.Name = "tabFacturacion";
            this.tabFacturacion.Padding = new System.Windows.Forms.Padding(5);
            this.tabFacturacion.Size = new System.Drawing.Size(828, 563);
            this.tabFacturacion.TabIndex = 0;
            this.tabFacturacion.Text = "Facturación";
            // 
            // lblNumFacturaF
            // 
            this.lblNumFacturaF.Location = new System.Drawing.Point(30, 20);
            this.lblNumFacturaF.Name = "lblNumFacturaF";
            this.lblNumFacturaF.Size = new System.Drawing.Size(100, 23);
            this.lblNumFacturaF.TabIndex = 0;
            this.lblNumFacturaF.Text = "N° Factura:";
            // 
            // txtNumFacturaF
            // 
            this.txtNumFacturaF.Location = new System.Drawing.Point(150, 17);
            this.txtNumFacturaF.Name = "txtNumFacturaF";
            this.txtNumFacturaF.Size = new System.Drawing.Size(160, 20);
            this.txtNumFacturaF.TabIndex = 1;
            // 
            // lblPacienteF
            // 
            this.lblPacienteF.Location = new System.Drawing.Point(30, 60);
            this.lblPacienteF.Name = "lblPacienteF";
            this.lblPacienteF.Size = new System.Drawing.Size(100, 23);
            this.lblPacienteF.TabIndex = 2;
            this.lblPacienteF.Text = "Paciente (*):";
            // 
            // cmbPacienteF
            // 
            this.cmbPacienteF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacienteF.Location = new System.Drawing.Point(150, 57);
            this.cmbPacienteF.Name = "cmbPacienteF";
            this.cmbPacienteF.Size = new System.Drawing.Size(300, 21);
            this.cmbPacienteF.TabIndex = 3;
            // 
            // lblAseguradoraF
            // 
            this.lblAseguradoraF.Location = new System.Drawing.Point(30, 100);
            this.lblAseguradoraF.Name = "lblAseguradoraF";
            this.lblAseguradoraF.Size = new System.Drawing.Size(100, 23);
            this.lblAseguradoraF.TabIndex = 4;
            this.lblAseguradoraF.Text = "Aseguradora:";
            // 
            // cmbAseguradoraF
            // 
            this.cmbAseguradoraF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAseguradoraF.Location = new System.Drawing.Point(150, 97);
            this.cmbAseguradoraF.Name = "cmbAseguradoraF";
            this.cmbAseguradoraF.Size = new System.Drawing.Size(300, 21);
            this.cmbAseguradoraF.TabIndex = 5;
            // 
            // lblPolizaF
            // 
            this.lblPolizaF.Location = new System.Drawing.Point(30, 140);
            this.lblPolizaF.Name = "lblPolizaF";
            this.lblPolizaF.Size = new System.Drawing.Size(100, 23);
            this.lblPolizaF.TabIndex = 6;
            this.lblPolizaF.Text = "N° Póliza:";
            // 
            // txtPolizaF
            // 
            this.txtPolizaF.Location = new System.Drawing.Point(150, 137);
            this.txtPolizaF.Name = "txtPolizaF";
            this.txtPolizaF.Size = new System.Drawing.Size(220, 20);
            this.txtPolizaF.TabIndex = 7;
            // 
            // lblFechaFacturaF
            // 
            this.lblFechaFacturaF.Location = new System.Drawing.Point(30, 180);
            this.lblFechaFacturaF.Name = "lblFechaFacturaF";
            this.lblFechaFacturaF.Size = new System.Drawing.Size(100, 23);
            this.lblFechaFacturaF.TabIndex = 8;
            this.lblFechaFacturaF.Text = "Fecha Factura (*):";
            // 
            // dtpFechaFacturaF
            // 
            this.dtpFechaFacturaF.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpFechaFacturaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFacturaF.Location = new System.Drawing.Point(150, 177);
            this.dtpFechaFacturaF.Name = "dtpFechaFacturaF";
            this.dtpFechaFacturaF.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaFacturaF.TabIndex = 9;
            // 
            // grpServiciosF
            // 
            this.grpServiciosF.Controls.Add(this.dgvServiciosF);
            this.grpServiciosF.Location = new System.Drawing.Point(30, 225);
            this.grpServiciosF.Name = "grpServiciosF";
            this.grpServiciosF.Size = new System.Drawing.Size(760, 220);
            this.grpServiciosF.TabIndex = 10;
            this.grpServiciosF.TabStop = false;
            this.grpServiciosF.Text = "Servicios (Detalle)";
            // 
            // dgvServiciosF
            // 
            this.dgvServiciosF.AllowUserToAddRows = false;
            this.dgvServiciosF.AllowUserToDeleteRows = false;
            this.dgvServiciosF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiciosF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvServiciosF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiciosF.Location = new System.Drawing.Point(3, 16);
            this.dgvServiciosF.MultiSelect = false;
            this.dgvServiciosF.Name = "dgvServiciosF";
            this.dgvServiciosF.ReadOnly = true;
            this.dgvServiciosF.RowHeadersVisible = false;
            this.dgvServiciosF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiciosF.Size = new System.Drawing.Size(754, 201);
            this.dgvServiciosF.TabIndex = 0;
            this.dgvServiciosF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiciosF_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unit.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblSubtotalF
            // 
            this.lblSubtotalF.Location = new System.Drawing.Point(30, 460);
            this.lblSubtotalF.Name = "lblSubtotalF";
            this.lblSubtotalF.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalF.TabIndex = 11;
            this.lblSubtotalF.Text = "Subtotal (*):";
            // 
            // txtSubtotalF
            // 
            this.txtSubtotalF.Location = new System.Drawing.Point(150, 457);
            this.txtSubtotalF.Name = "txtSubtotalF";
            this.txtSubtotalF.ReadOnly = true;
            this.txtSubtotalF.Size = new System.Drawing.Size(120, 20);
            this.txtSubtotalF.TabIndex = 12;
            // 
            // lblDescuentoF
            // 
            this.lblDescuentoF.Location = new System.Drawing.Point(30, 500);
            this.lblDescuentoF.Name = "lblDescuentoF";
            this.lblDescuentoF.Size = new System.Drawing.Size(100, 23);
            this.lblDescuentoF.TabIndex = 13;
            this.lblDescuentoF.Text = "Descuento (%):";
            // 
            // nudDescuentoF
            // 
            this.nudDescuentoF.Location = new System.Drawing.Point(150, 497);
            this.nudDescuentoF.Name = "nudDescuentoF";
            this.nudDescuentoF.Size = new System.Drawing.Size(90, 20);
            this.nudDescuentoF.TabIndex = 14;
            // 
            // lblImpuestoF
            // 
            this.lblImpuestoF.Location = new System.Drawing.Point(30, 540);
            this.lblImpuestoF.Name = "lblImpuestoF";
            this.lblImpuestoF.Size = new System.Drawing.Size(100, 23);
            this.lblImpuestoF.TabIndex = 15;
            this.lblImpuestoF.Text = "Impuesto (%):";
            // 
            // nudImpuestoF
            // 
            this.nudImpuestoF.Location = new System.Drawing.Point(150, 537);
            this.nudImpuestoF.Name = "nudImpuestoF";
            this.nudImpuestoF.Size = new System.Drawing.Size(90, 20);
            this.nudImpuestoF.TabIndex = 16;
            // 
            // lblTotalF
            // 
            this.lblTotalF.Location = new System.Drawing.Point(30, 580);
            this.lblTotalF.Name = "lblTotalF";
            this.lblTotalF.Size = new System.Drawing.Size(100, 23);
            this.lblTotalF.TabIndex = 17;
            this.lblTotalF.Text = "Total (*):";
            // 
            // txtTotalF
            // 
            this.txtTotalF.Location = new System.Drawing.Point(150, 577);
            this.txtTotalF.Name = "txtTotalF";
            this.txtTotalF.ReadOnly = true;
            this.txtTotalF.Size = new System.Drawing.Size(120, 20);
            this.txtTotalF.TabIndex = 18;
            // 
            // lblEstadoFacturaF
            // 
            this.lblEstadoFacturaF.Location = new System.Drawing.Point(30, 620);
            this.lblEstadoFacturaF.Name = "lblEstadoFacturaF";
            this.lblEstadoFacturaF.Size = new System.Drawing.Size(100, 23);
            this.lblEstadoFacturaF.TabIndex = 19;
            this.lblEstadoFacturaF.Text = "Estado factura (*):";
            // 
            // cmbEstadoFacturaF
            // 
            this.cmbEstadoFacturaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFacturaF.Location = new System.Drawing.Point(150, 617);
            this.cmbEstadoFacturaF.Name = "cmbEstadoFacturaF";
            this.cmbEstadoFacturaF.Size = new System.Drawing.Size(150, 21);
            this.cmbEstadoFacturaF.TabIndex = 20;
            // 
            // lblObservacionesF
            // 
            this.lblObservacionesF.Location = new System.Drawing.Point(30, 660);
            this.lblObservacionesF.Name = "lblObservacionesF";
            this.lblObservacionesF.Size = new System.Drawing.Size(100, 23);
            this.lblObservacionesF.TabIndex = 21;
            this.lblObservacionesF.Text = "Observaciones:";
            // 
            // txtObservacionesF
            // 
            this.txtObservacionesF.Location = new System.Drawing.Point(150, 657);
            this.txtObservacionesF.Multiline = true;
            this.txtObservacionesF.Name = "txtObservacionesF";
            this.txtObservacionesF.Size = new System.Drawing.Size(500, 70);
            this.txtObservacionesF.TabIndex = 22;
            // 
            // btnCalcularF
            // 
            this.btnCalcularF.Location = new System.Drawing.Point(30, 740);
            this.btnCalcularF.Name = "btnCalcularF";
            this.btnCalcularF.Size = new System.Drawing.Size(120, 30);
            this.btnCalcularF.TabIndex = 23;
            this.btnCalcularF.Text = "Calcular";
            // 
            // btnGuardarImprimirF
            // 
            this.btnGuardarImprimirF.Location = new System.Drawing.Point(170, 740);
            this.btnGuardarImprimirF.Name = "btnGuardarImprimirF";
            this.btnGuardarImprimirF.Size = new System.Drawing.Size(160, 30);
            this.btnGuardarImprimirF.TabIndex = 24;
            this.btnGuardarImprimirF.Text = "Guardar / Imprimir";
            // 
            // tabCaja
            // 
            this.tabCaja.AutoScroll = true;
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
            this.tabCaja.Location = new System.Drawing.Point(4, 22);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(5);
            this.tabCaja.Size = new System.Drawing.Size(828, 563);
            this.tabCaja.TabIndex = 1;
            this.tabCaja.Text = "Caja Pagos";
            // 
            // lblNumFacturaC
            // 
            this.lblNumFacturaC.Location = new System.Drawing.Point(30, 20);
            this.lblNumFacturaC.Name = "lblNumFacturaC";
            this.lblNumFacturaC.Size = new System.Drawing.Size(100, 23);
            this.lblNumFacturaC.TabIndex = 0;
            this.lblNumFacturaC.Text = "N° Factura (*):";
            // 
            // cmbNumFacturaC
            // 
            this.cmbNumFacturaC.Location = new System.Drawing.Point(170, 17);
            this.cmbNumFacturaC.Name = "cmbNumFacturaC";
            this.cmbNumFacturaC.Size = new System.Drawing.Size(200, 21);
            this.cmbNumFacturaC.TabIndex = 1;
            // 
            // lblPacienteC
            // 
            this.lblPacienteC.Location = new System.Drawing.Point(30, 60);
            this.lblPacienteC.Name = "lblPacienteC";
            this.lblPacienteC.Size = new System.Drawing.Size(100, 23);
            this.lblPacienteC.TabIndex = 2;
            this.lblPacienteC.Text = "Paciente:";
            // 
            // txtPacienteC
            // 
            this.txtPacienteC.Location = new System.Drawing.Point(170, 57);
            this.txtPacienteC.Name = "txtPacienteC";
            this.txtPacienteC.ReadOnly = true;
            this.txtPacienteC.Size = new System.Drawing.Size(300, 20);
            this.txtPacienteC.TabIndex = 3;
            // 
            // lblTotalFacturaC
            // 
            this.lblTotalFacturaC.Location = new System.Drawing.Point(30, 100);
            this.lblTotalFacturaC.Name = "lblTotalFacturaC";
            this.lblTotalFacturaC.Size = new System.Drawing.Size(100, 23);
            this.lblTotalFacturaC.TabIndex = 4;
            this.lblTotalFacturaC.Text = "Monto total factura:";
            // 
            // txtTotalFacturaC
            // 
            this.txtTotalFacturaC.Location = new System.Drawing.Point(170, 97);
            this.txtTotalFacturaC.Name = "txtTotalFacturaC";
            this.txtTotalFacturaC.ReadOnly = true;
            this.txtTotalFacturaC.Size = new System.Drawing.Size(140, 20);
            this.txtTotalFacturaC.TabIndex = 5;
            // 
            // lblMontoPagadoC
            // 
            this.lblMontoPagadoC.Location = new System.Drawing.Point(30, 140);
            this.lblMontoPagadoC.Name = "lblMontoPagadoC";
            this.lblMontoPagadoC.Size = new System.Drawing.Size(100, 23);
            this.lblMontoPagadoC.TabIndex = 6;
            this.lblMontoPagadoC.Text = "Monto ya pagado:";
            // 
            // txtMontoPagadoC
            // 
            this.txtMontoPagadoC.Location = new System.Drawing.Point(170, 137);
            this.txtMontoPagadoC.Name = "txtMontoPagadoC";
            this.txtMontoPagadoC.ReadOnly = true;
            this.txtMontoPagadoC.Size = new System.Drawing.Size(140, 20);
            this.txtMontoPagadoC.TabIndex = 7;
            // 
            // lblMontoPagarC
            // 
            this.lblMontoPagarC.Location = new System.Drawing.Point(30, 180);
            this.lblMontoPagarC.Name = "lblMontoPagarC";
            this.lblMontoPagarC.Size = new System.Drawing.Size(100, 23);
            this.lblMontoPagarC.TabIndex = 8;
            this.lblMontoPagarC.Text = "Monto a pagar (*):";
            // 
            // nudMontoPagarC
            // 
            this.nudMontoPagarC.DecimalPlaces = 2;
            this.nudMontoPagarC.Location = new System.Drawing.Point(170, 177);
            this.nudMontoPagarC.Name = "nudMontoPagarC";
            this.nudMontoPagarC.Size = new System.Drawing.Size(140, 20);
            this.nudMontoPagarC.TabIndex = 9;
            // 
            // lblFormaPagoC
            // 
            this.lblFormaPagoC.Location = new System.Drawing.Point(30, 220);
            this.lblFormaPagoC.Name = "lblFormaPagoC";
            this.lblFormaPagoC.Size = new System.Drawing.Size(100, 23);
            this.lblFormaPagoC.TabIndex = 10;
            this.lblFormaPagoC.Text = "Forma de pago (*):";
            // 
            // cmbFormaPagoC
            // 
            this.cmbFormaPagoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagoC.Location = new System.Drawing.Point(170, 217);
            this.cmbFormaPagoC.Name = "cmbFormaPagoC";
            this.cmbFormaPagoC.Size = new System.Drawing.Size(200, 21);
            this.cmbFormaPagoC.TabIndex = 11;
            // 
            // lblFechaPagoC
            // 
            this.lblFechaPagoC.Location = new System.Drawing.Point(30, 260);
            this.lblFechaPagoC.Name = "lblFechaPagoC";
            this.lblFechaPagoC.Size = new System.Drawing.Size(100, 23);
            this.lblFechaPagoC.TabIndex = 12;
            this.lblFechaPagoC.Text = "Fecha pago (*):";
            // 
            // dtpFechaPagoC
            // 
            this.dtpFechaPagoC.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpFechaPagoC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPagoC.Location = new System.Drawing.Point(170, 257);
            this.dtpFechaPagoC.Name = "dtpFechaPagoC";
            this.dtpFechaPagoC.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPagoC.TabIndex = 13;
            // 
            // lblReferenciaC
            // 
            this.lblReferenciaC.Location = new System.Drawing.Point(30, 300);
            this.lblReferenciaC.Name = "lblReferenciaC";
            this.lblReferenciaC.Size = new System.Drawing.Size(100, 23);
            this.lblReferenciaC.TabIndex = 14;
            this.lblReferenciaC.Text = "Referencia:";
            // 
            // txtReferenciaC
            // 
            this.txtReferenciaC.Location = new System.Drawing.Point(170, 297);
            this.txtReferenciaC.Name = "txtReferenciaC";
            this.txtReferenciaC.Size = new System.Drawing.Size(240, 20);
            this.txtReferenciaC.TabIndex = 15;
            // 
            // lblObservacionesC
            // 
            this.lblObservacionesC.Location = new System.Drawing.Point(30, 340);
            this.lblObservacionesC.Name = "lblObservacionesC";
            this.lblObservacionesC.Size = new System.Drawing.Size(100, 23);
            this.lblObservacionesC.TabIndex = 16;
            this.lblObservacionesC.Text = "Observaciones:";
            // 
            // txtObservacionesC
            // 
            this.txtObservacionesC.Location = new System.Drawing.Point(170, 337);
            this.txtObservacionesC.Multiline = true;
            this.txtObservacionesC.Name = "txtObservacionesC";
            this.txtObservacionesC.Size = new System.Drawing.Size(480, 70);
            this.txtObservacionesC.TabIndex = 17;
            // 
            // lblEstadoPagoC
            // 
            this.lblEstadoPagoC.Location = new System.Drawing.Point(30, 420);
            this.lblEstadoPagoC.Name = "lblEstadoPagoC";
            this.lblEstadoPagoC.Size = new System.Drawing.Size(100, 23);
            this.lblEstadoPagoC.TabIndex = 18;
            this.lblEstadoPagoC.Text = "Estado:";
            // 
            // cmbEstadoPagoC
            // 
            this.cmbEstadoPagoC.Location = new System.Drawing.Point(170, 417);
            this.cmbEstadoPagoC.Name = "cmbEstadoPagoC";
            this.cmbEstadoPagoC.Size = new System.Drawing.Size(150, 21);
            this.cmbEstadoPagoC.TabIndex = 19;
            // 
            // btnRegistrarPagoC
            // 
            this.btnRegistrarPagoC.Location = new System.Drawing.Point(30, 460);
            this.btnRegistrarPagoC.Name = "btnRegistrarPagoC";
            this.btnRegistrarPagoC.Size = new System.Drawing.Size(140, 30);
            this.btnRegistrarPagoC.TabIndex = 20;
            this.btnRegistrarPagoC.Text = "Registrar Pago";
            // 
            // btnImprimirReciboC
            // 
            this.btnImprimirReciboC.Location = new System.Drawing.Point(180, 460);
            this.btnImprimirReciboC.Name = "btnImprimirReciboC";
            this.btnImprimirReciboC.Size = new System.Drawing.Size(140, 30);
            this.btnImprimirReciboC.TabIndex = 21;
            this.btnImprimirReciboC.Text = "Imprimir Recibo";
            // 
            // Modulo11
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl);
            this.Name = "Modulo11";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(856, 609);
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
