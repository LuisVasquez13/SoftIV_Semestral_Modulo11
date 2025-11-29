using System;
using System.Drawing;
using System.Windows.Forms;

namespace Borrador
{
    public partial class UCFacturacion : UserControl
    {
        
        //  PROPIEDADES PUBLICAS
        
        public int IdFactura { get; set; } // Identificador único de la factura
        public int IdPaciente { get; set; } // Identificador del paciente asociado
        public int IdAseguradora { get; set; } // Identificador de la aseguradora asociada

        public UCFacturacion()
        {
            InitializeComponent();
            SetupLayoutAndControls();
        }

        
        //  DEFINICIÓN DE CONTROLES PRINCIPALES
        private TabControl tabControl;

        // Pestaña 1: FACTURACIÓN
        private TabPage tabFacturacion;

        private TextBox txtNumFacturaF;
        private ComboBox cmbPacienteF;
        private ComboBox cmbAseguradoraF;
        private TextBox txtPolizaF;
        private DateTimePicker dtpFechaFacturaF;

        private DataGridView dgvServiciosF;

        private TextBox txtSubtotalF;
        private NumericUpDown nudDescuentoF;
        private NumericUpDown nudImpuestoF;
        private TextBox txtTotalF;

        private ComboBox cmbEstadoFacturaF;
        private TextBox txtObservacionesF;

        private Button btnCalcularF;
        private Button btnGuardarImprimirF;

        // Pestaña 2: CAJA PAGOS
        private TabPage tabCaja;

        private ComboBox cmbNumFacturaC;
        private TextBox txtPacienteC;
        private TextBox txtTotalFacturaC;
        private TextBox txtMontoPagadoC;

        private NumericUpDown nudMontoPagarC;
        private ComboBox cmbFormaPagoC;
        private DateTimePicker dtpFechaPagoC;

        private TextBox txtReferenciaC;
        private TextBox txtObservacionesC;
        private ComboBox cmbEstadoPagoC;

        private Button btnRegistrarPagoC;
        private Button btnImprimirReciboC;


        
        //  CONFIGURACIÓN GENERAL
        
        private void SetupLayoutAndControls()
        {
            this.Size = new Size(856, 609);
            this.BackColor = Color.White;
            this.Padding = new Padding(10);

            tabControl = new TabControl()
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10)
            };
            this.Controls.Add(tabControl);

            // Crear las dos pestañas
            tabFacturacion = new TabPage("Facturación");
            tabCaja = new TabPage("Caja Pagos");

            tabControl.TabPages.Add(tabFacturacion);
            tabControl.TabPages.Add(tabCaja);

            // Construcción de cada formulario
            BuildFacturacionUI();
            BuildCajaPagosUI();
        }

        
        //  UI DE FORMULARIO 1 - FACTURACIÓN
        
        private void BuildFacturacionUI()
        {
            tabFacturacion.AutoScroll = true;

            int x1 = 30, y = 30;

            // N° Factura
            tabFacturacion.Controls.Add(new Label() { Text = "N° Factura:", Location = new Point(x1, y), AutoSize = true });
            txtNumFacturaF = new TextBox() { Location = new Point(x1 + 130, y - 3), Width = 150 };
            tabFacturacion.Controls.Add(txtNumFacturaF);

            // Paciente
            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "Paciente (*):", Location = new Point(x1, y), AutoSize = true });
            cmbPacienteF = new ComboBox() { Location = new Point(x1 + 130, y - 3), Width = 250, DropDownStyle = ComboBoxStyle.DropDownList };
            tabFacturacion.Controls.Add(cmbPacienteF);

            // Aseguradora
            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "Aseguradora:", Location = new Point(x1, y), AutoSize = true });
            cmbAseguradoraF = new ComboBox() { Location = new Point(x1 + 130, y - 3), Width = 250, DropDownStyle = ComboBoxStyle.DropDownList };
            tabFacturacion.Controls.Add(cmbAseguradoraF);

            // Nº póliza
            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "N° Póliza:", Location = new Point(x1, y), AutoSize = true });
            txtPolizaF = new TextBox() { Location = new Point(x1 + 130, y - 3), Width = 200 };
            tabFacturacion.Controls.Add(txtPolizaF);

            // Fecha de factura
            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "Fecha Factura (*):", Location = new Point(x1, y), AutoSize = true });
            dtpFechaFacturaF = new DateTimePicker() { Location = new Point(x1 + 130, y - 3), Width = 200 };
            tabFacturacion.Controls.Add(dtpFechaFacturaF);

            // Servicios
            y += 50;
            GroupBox grpServicios = new GroupBox()
            {
                Text = "Servicios (Detalle)",
                Location = new Point(x1, y),
                Width = 760,
                Height = 220
            };
            tabFacturacion.Controls.Add(grpServicios);

            dgvServiciosF = new DataGridView()
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = true,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            };
            dgvServiciosF.Columns.Add("Servicio", "Servicio");
            dgvServiciosF.Columns.Add("Cantidad", "Cant.");
            dgvServiciosF.Columns.Add("Precio", "Precio Unit.");
            dgvServiciosF.Columns.Add("Subtotal", "Subtotal");

            grpServicios.Controls.Add(dgvServiciosF);

            // Subtotal - Descuento - Impuesto - Total
            y += 250;
            tabFacturacion.Controls.Add(new Label() { Text = "Subtotal (*):", Location = new Point(x1, y), AutoSize = true });
            txtSubtotalF = new TextBox() { Location = new Point(x1 + 130, y - 3), Width = 100, ReadOnly = true };
            tabFacturacion.Controls.Add(txtSubtotalF);

            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "Descuento (%):", Location = new Point(x1, y), AutoSize = true });
            nudDescuentoF = new NumericUpDown() { Location = new Point(x1 + 130, y - 3), Width = 80, DecimalPlaces = 2 };
            tabFacturacion.Controls.Add(nudDescuentoF);

            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "Impuesto (%):", Location = new Point(x1, y), AutoSize = true });
            nudImpuestoF = new NumericUpDown() { Location = new Point(x1 + 130, y - 3), Width = 80, DecimalPlaces = 2 };
            tabFacturacion.Controls.Add(nudImpuestoF);

            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "Total (*):", Location = new Point(x1, y), AutoSize = true });
            txtTotalF = new TextBox() { Location = new Point(x1 + 130, y - 3), Width = 100, ReadOnly = true };
            tabFacturacion.Controls.Add(txtTotalF);

            // Estado
            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "Estado Factura (*):", Location = new Point(x1, y), AutoSize = true });
            cmbEstadoFacturaF = new ComboBox()
            {
                Location = new Point(x1 + 130, y - 3),
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbEstadoFacturaF.Items.AddRange(new string[] { "Pendiente", "Pagada", "Anulada" });
            tabFacturacion.Controls.Add(cmbEstadoFacturaF);

            // Observaciones
            y += 40;
            tabFacturacion.Controls.Add(new Label() { Text = "Observaciones:", Location = new Point(x1, y), AutoSize = true });
            txtObservacionesF = new TextBox()
            {
                Location = new Point(x1 + 130, y - 3),
                Width = 500,
                Height = 70,
                Multiline = true
            };
            tabFacturacion.Controls.Add(txtObservacionesF);

            // Botones
            y += 90;
            btnCalcularF = new Button() { Text = "Calcular", Location = new Point(x1, y), Width = 120 };
            btnGuardarImprimirF = new Button() { Text = "Guardar / Imprimir", Location = new Point(x1 + 140, y), Width = 160 };

            tabFacturacion.Controls.Add(btnCalcularF);
            tabFacturacion.Controls.Add(btnGuardarImprimirF);
        }

        
        //  UI DE FORMULARIO 2 - CAJA PAGOS

        private void BuildCajaPagosUI()
        {
            tabCaja.AutoScroll = true;

            int x1 = 30, y = 30;

            // N° Factura
            tabCaja.Controls.Add(new Label() { Text = "N° Factura (*):", Location = new Point(x1, y), AutoSize = true });
            cmbNumFacturaC = new ComboBox() { Location = new Point(x1 + 150, y - 3), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            tabCaja.Controls.Add(cmbNumFacturaC);

            // Paciente
            y += 40;
            tabCaja.Controls.Add(new Label() { Text = "Paciente:", Location = new Point(x1, y), AutoSize = true });
            txtPacienteC = new TextBox() { Location = new Point(x1 + 150, y - 3), Width = 250, ReadOnly = true };
            tabCaja.Controls.Add(txtPacienteC);

            // Monto total factura
            y += 40;
            tabCaja.Controls.Add(new Label() { Text = "Monto total factura:", Location = new Point(x1, y), AutoSize = true });
            txtTotalFacturaC = new TextBox() { Location = new Point(x1 + 150, y - 3), Width = 150, ReadOnly = true };
            tabCaja.Controls.Add(txtTotalFacturaC);

            // Monto ya pagado
            y += 40;
            tabCaja.Controls.Add(new Label() { Text = "Monto ya pagado:", Location = new Point(x1, y), AutoSize = true });
            txtMontoPagadoC = new TextBox() { Location = new Point(x1 + 150, y - 3), Width = 150, ReadOnly = true };
            tabCaja.Controls.Add(txtMontoPagadoC);

            // Monto a pagar ahora
            y += 40;
            tabCaja.Controls.Add(new Label() { Text = "Monto a pagar (*):", Location = new Point(x1, y), AutoSize = true });
            nudMontoPagarC = new NumericUpDown() { Location = new Point(x1 + 150, y - 3), Width = 120, DecimalPlaces = 2 };
            tabCaja.Controls.Add(nudMontoPagarC);

            // Forma de pago
            y += 40;
            tabCaja.Controls.Add(new Label() { Text = "Forma de pago (*):", Location = new Point(x1, y), AutoSize = true });
            cmbFormaPagoC = new ComboBox()
            {
                Location = new Point(x1 + 150, y - 3),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFormaPagoC.Items.AddRange(new string[] { "Efectivo", "Tarjeta", "Transferencia", "Seguro" });
            tabCaja.Controls.Add(cmbFormaPagoC);

            // Fecha de pago
            y += 40;
            tabCaja.Controls.Add(new Label() { Text = "Fecha pago (*):", Location = new Point(x1, y), AutoSize = true });
            dtpFechaPagoC = new DateTimePicker() { Location = new Point(x1 + 150, y - 3), Width = 200 };
            tabCaja.Controls.Add(dtpFechaPagoC);

            // Referencia
            y += 40;
            tabCaja.Controls.Add(new Label() { Text = "Referencia:", Location = new Point(x1, y), AutoSize = true });
            txtReferenciaC = new TextBox() { Location = new Point(x1 + 150, y - 3), Width = 200 };
            tabCaja.Controls.Add(txtReferenciaC);

            // Observaciones
            y += 40;
            tabCaja.Controls.Add(new Label() { Text = "Observaciones:", Location = new Point(x1, y), AutoSize = true });
            txtObservacionesC = new TextBox()
            {
                Location = new Point(x1 + 150, y - 3),
                Width = 450,
                Height = 70,
                Multiline = true
            };
            tabCaja.Controls.Add(txtObservacionesC);

            // Estado pago
            y += 90;
            tabCaja.Controls.Add(new Label() { Text = "Estado:", Location = new Point(x1, y), AutoSize = true });
            cmbEstadoPagoC = new ComboBox()
            {
                Location = new Point(x1 + 150, y - 3),
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbEstadoPagoC.Items.AddRange(new string[] { "Pagado", "Cancelado" });
            tabCaja.Controls.Add(cmbEstadoPagoC);

            // Botones
            y += 50;
            btnRegistrarPagoC = new Button() { Text = "Registrar Pago", Location = new Point(x1, y), Width = 150 };
            btnImprimirReciboC = new Button() { Text = "Imprimir Recibo", Location = new Point(x1 + 180, y), Width = 150 };

            tabCaja.Controls.Add(btnRegistrarPagoC);
            tabCaja.Controls.Add(btnImprimirReciboC);
        }


        
        //  InitializeComponent
        
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "UCFacturacion";
            this.ResumeLayout(false);
        }
    }
}