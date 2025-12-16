
using Azure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Borrador
{
    public partial class Modulo11 : UserControl
    {

        private ConexionSqlAdministracion conn = new ConexionSqlAdministracion();
        private List<DetalleFactura> listaDetalles = new List<DetalleFactura>();
        private int UltimaFacturaId = 0;
        public Modulo11()
        {
            InitializeComponent();
            ConfigurarEventos();
            CargarDatos();
        }

        // Carga todos los datos del formualrio cada vez que se selecciona
        private void CargarDatos()
        {
            List<ComboBoxItem> listaPacientes = conn.ObtenerPacientes();
            List<ComboBoxItem> listaAseguradoras = conn.ObtenerAseguradoras();
            List<ComboBoxItem> listaFacturas = conn.ObtenerFacturas();
            DataTable tablaServicios = conn.ObtenerServicios();

            // Hace un loop a cada ComboBox y añade los items de la lista
            foreach (ComboBoxItem s in listaPacientes)
            {
                cmbPacienteF.Items.Add(s);
            }

            foreach (ComboBoxItem s in listaAseguradoras)
            {
                cmbAseguradoraF.Items.Add(s);
            }
            foreach (ComboBoxItem s in listaFacturas)
            {
                cmbNumFacturaC.Items.Add(s);
            }

            // Crea el dataGrid en donde iran los servicios
            crearDatagrid(tablaServicios);
        }

        private void crearDatagrid(DataTable tablaServicios)
        {

            dgvServiciosF.Columns.Clear();

            tablaServicios.Columns["Servicio"].ReadOnly = true;
            tablaServicios.Columns["Cantidad"].ReadOnly = false;
            tablaServicios.Columns["Precio Unit."].ReadOnly = true;
            tablaServicios.Columns["Subtotal"].ReadOnly = false;

            tablaServicios.Columns["Cantidad"].DataType = typeof(int);

            dgvServiciosF.ReadOnly = false;
            dgvServiciosF.DataSource = tablaServicios;

        }

        // Configura todos los eventos manualmente del forms
        private void ConfigurarEventos()
        {
            btnCalcularF.Click += BtnCalcularF_Click;
            btnGuardarImprimirF.Click += BtnGuardarImprimirF_Click;
            cmbNumFacturaC.SelectedIndexChanged += CmbNumFacturaC_SelectedIndexChanged;
            btnRegistrarPagoC.Click += BtnRegistrarPagoC_Click;
            btnImprimirReciboC.Click += BtnImprimirReciboC_Click;
            dgvServiciosF.EditingControlShowing += dgvServiciosF_EditingControlShowing;
        }

        // Calcula los costos de los servicios del hospital
        private void BtnCalcularF_Click(object sender, EventArgs e)
        {
            listaDetalles.Clear();
            decimal subtotal = 0;
            int contIdServicios = 1;
            foreach (DataGridViewRow row in dgvServiciosF.Rows)
            {
                if (row.IsNewRow) continue;
                decimal cantidad = 0, precio = 0;
                decimal.TryParse(Convert.ToString(row.Cells[1].Value), out cantidad);
                decimal.TryParse(Convert.ToString(row.Cells[2].Value), out precio);
                row.Cells[3].Value = (cantidad * precio);
                subtotal += cantidad * precio;
                if (cantidad > 0)
                {
                    listaDetalles.Add(new DetalleFactura(
                        0,
                        contIdServicios,
                        (int)cantidad,
                        precio,
                        cantidad * precio
                        ));
                }
                contIdServicios += 1;
            }

            txtSubtotalF.Text = subtotal.ToString("0.00");
            decimal desc = subtotal * (nudDescuentoF.Value / 100);
            decimal imp = (subtotal - desc) * (nudImpuestoF.Value / 100);
            txtTotalF.Text = (subtotal - desc + imp).ToString("0.00");
        }

        // Guarda la factura
        private void BtnGuardarImprimirF_Click(object sender, EventArgs e)
        {
            if (!inputValidadosFactura()) { MessageBox.Show("No todos los campos están llenos", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            float subtotal = float.Parse(txtSubtotalF.Text);
            UltimaFacturaId = conn.AnadirFactura(new Factura(
                                txtNumFacturaF.Text,
                                ((ComboBoxItem)cmbPacienteF.SelectedItem).IdValor,
                                ((ComboBoxItem)cmbAseguradoraF.SelectedItem).IdValor,
                                txtPolizaF.Text,
                                dtpFechaFacturaF.Text,
                                subtotal,
                                float.Parse(nudDescuentoF.Text) / 100 * subtotal,
                                float.Parse(nudImpuestoF.Text) / 100 * subtotal,
                                float.Parse(txtTotalF.Text),
                                (string)cmbEstadoFacturaF.SelectedItem,
                                txtObservacionesF.Text ?? null
                                ));
            foreach (DetalleFactura f in listaDetalles)
            {
                f.IdFactura = UltimaFacturaId;
            }
            conn.AnadirDetalleFactura(listaDetalles);
            MessageBox.Show("Factura guardada e impresa (simulado)", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Al cambiar el número de factura en caja se cargan los datos financieros de ese paciente
        private void CmbNumFacturaC_SelectedIndexChanged(object sender, EventArgs e)
        {

            PacienteDatosCajaRetorno pacienteDatos = conn.ObtenerFactura(((ComboBoxItem)cmbNumFacturaC.SelectedItem).IdValor.ToString());
            txtPacienteC.Text = pacienteDatos.Nombre;
            txtTotalFacturaC.Text = pacienteDatos.Monto.ToString();
            txtMontoPagadoC.Text = pacienteDatos.TotalPagado.ToString();
        }

        private void BtnRegistrarPagoC_Click(object sender, EventArgs e)
        {
            if (!inputValidadosCaja()) { MessageBox.Show("No todos los campos están llenos", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            Pago pago = new Pago(
                ((ComboBoxItem)cmbNumFacturaC.SelectedItem).IdValor,
                Convert.ToDecimal(nudMontoPagarC.Value),
                (string)cmbFormaPagoC.SelectedItem,
                dtpFechaPagoC.Text,
                txtReferenciaC.Text,
                (string)cmbEstadoPagoC.SelectedItem,
                txtObservacionesC.Text
                );
            conn.InsertarPago(pago);
            MessageBox.Show("Pago registrado (simulado)", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnImprimirReciboC_Click(object sender, EventArgs e)
        {
            if (!inputValidadosCaja()) { MessageBox.Show("No todos los campos están llenos", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            Pago pago = new Pago(
                                ((ComboBoxItem)cmbNumFacturaC.SelectedItem).IdValor,
                                Convert.ToDecimal(nudMontoPagarC.Value),
                                (string)cmbFormaPagoC.SelectedItem,
                                dtpFechaPagoC.Text,
                                txtReferenciaC.Text,
                                (string)cmbEstadoPagoC.SelectedItem,
                                txtObservacionesC.Text
                                );
            conn.ToPdf("Factura pago", pago, txtPacienteC.Text, txtTotalFacturaC.Text);
            MessageBox.Show("Recibo impreso (simulado)", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Válidación de los inpus
        private bool inputValidadosFactura()
        {

            return !string.IsNullOrEmpty(txtNumFacturaF.Text) &&
                    cmbPacienteF.SelectedIndex > -1 &&
                    cmbAseguradoraF.SelectedIndex > -1 &&
                    !string.IsNullOrEmpty(txtPolizaF.Text) &&
                    float.TryParse(txtTotalF.Text, out float result) &&
                    cmbEstadoFacturaF.SelectedIndex > -1;
        }

        private bool inputValidadosCaja()
        {
            return nudMontoPagarC.Value > (decimal)0 &&
                    cmbNumFacturaC.SelectedIndex > -1 &&
                    cmbFormaPagoC.SelectedIndex > -1 &&
                    !string.IsNullOrEmpty(txtReferenciaC.Text) &&
                    cmbEstadoPagoC.SelectedIndex > -1;
        }

        // Permite solo números en la columna de cantidad
        private void dgvServiciosF_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvServiciosF.CurrentCell.ColumnIndex == dgvServiciosF.Columns["Cantidad"].Index)
            {
                System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= OnlyNumbers_KeyPress;
                    tb.KeyPress += OnlyNumbers_KeyPress;
                }
            }
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y borrar(Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvServiciosF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbNumFacturaC_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPacienteC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalFacturaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoPagadoC_TextChanged(object sender, EventArgs e)
        {

        }

        // El método se encarga de revisar si el monto a pagar excede el monto que debe de pagar el paciente
        private void nudMontoPagarC_ValueChanged(object sender, EventArgs e)
        {
            decimal existeValor;
            if (!decimal.TryParse(txtTotalFacturaC.Text, out existeValor))
            {
                nudMontoPagarC.Value = 0;
                return;
            }
            decimal montoMaximo = decimal.Parse(txtTotalFacturaC.Text) - decimal.Parse(txtMontoPagadoC.Text);
            if (nudMontoPagarC.Value >= montoMaximo)
            {
                nudMontoPagarC.Value = montoMaximo;
            }
        }

        private void cmbFormaPagoC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaPagoC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtReferenciaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacionesC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstadoPagoC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /**************************************************************
         ***************                       ************************
         ***************   CLASE CONECCION SQL ************************
         ***************                       ************************
         **************************************************************/
        private class ConexionSqlAdministracion
        {

            public void ConectarBaseDeDatos()
            {
                ConexionDB.Instancia.VerificarBaseDatos();
            }

            public SqlParameter CrearParametro(string nombre, object valor)
            {
                return new SqlParameter(nombre, valor ?? DBNull.Value);
            }

            //***************** MÉTODOS CRUD ********************
            public int AnadirFactura(Factura fac)
            {
                try
                {
                    if (!ConexionDB.Instancia.VerificarBaseDatos()) return -1; // En caso de que la conexión no este abierta entonces regresa
                    string comando = @"INSERT INTO Facturas (NroFactura, IdPaciente, IdAseguradora, NumeroPoliza, FechaFactura, Subtotal, Descuento, Impuesto, Total, EstadoFactura, Observaciones) " +
                                                    "VALUES (@NroFactura, @IdPaciente, @IdAseguradora, @NroPoliza, @Fecha, @Subtotal, @Descuento, @Impuesto, @total,@Estado, @Observaciones);";
                    SqlParameter[] parametros =
                    {
                        CrearParametro("NroFactura", SqlDbType.VarChar),
                        CrearParametro("IdPaciente", SqlDbType.Int),
                        CrearParametro("IdAseguradora", SqlDbType.Int),
                        CrearParametro("NroPoliza", SqlDbType.VarChar),
                        CrearParametro("Fecha", SqlDbType.Date),
                        CrearParametro("Subtotal", SqlDbType.Decimal),
                        CrearParametro("Descuento", SqlDbType.Decimal),
                        CrearParametro("Impuesto", SqlDbType.Decimal),
                        CrearParametro("total", SqlDbType.Decimal),
                        CrearParametro("Estado", SqlDbType.VarChar),
                        CrearParametro("Observaciones", SqlDbType.VarChar)
                    };

                    parametros[0].Value = fac.NroFactura;
                    parametros[1].Value = fac.IdPaciente;
                    parametros[2].Value = fac.IdAseguradora;
                    parametros[3].Value = fac.NroPoliza;
                    parametros[4].Value = fac.Fecha;
                    parametros[5].Value = fac.Subtotal;
                    parametros[6].Value = fac.Descuento;
                    parametros[7].Value = fac.Impuesto;
                    parametros[8].Value = fac.Total;
                    parametros[9].Value = fac.Estado;
                    parametros[10].Value = fac.Observaciones;

                    return ConexionDB.Instancia.EjecutarComandoConRetorno(comando, parametros);
                }
                catch (Exception e)
                {
                    throw;
                }

            }

            public void AnadirDetalleFactura(List<DetalleFactura> detalles)
            {
                try
                {
                    if (!ConexionDB.Instancia.VerificarBaseDatos()) return; // En caso de que la conexión no este abierta entonces regresa

                    foreach (DetalleFactura f in detalles)
                    {
                        string comando = @"INSERT INTO DETALLE_FACTURA (IdFactura, IdServicio, Cantidad, PrecioUnitario, Subtotal) " +
                                "VALUES (@id, @servicio, @cant, @precio, @total);";
                        SqlParameter[] parametros =
                        {
                        CrearParametro("id", SqlDbType.VarChar),
                        CrearParametro("servicio", SqlDbType.Int),
                        CrearParametro("cant", SqlDbType.Int),
                        CrearParametro("precio", SqlDbType.Decimal),
                        CrearParametro("total", SqlDbType.Decimal)
                    };

                        parametros[0].Value = f.IdFactura;
                        parametros[1].Value = f.IdServicio;
                        parametros[2].Value = f.Cantidad;
                        parametros[3].Value = f.PrecioUnitario;
                        parametros[4].Value = f.Subtotal;

                        ConexionDB.Instancia.EjecutarComando(comando, parametros);
                    }

                    return;
                }
                catch (Exception e)
                {
                    throw;
                }

            }


            // Obtiene la lista de todos los pacientes
            public List<ComboBoxItem> ObtenerPacientes()
            {
                string comando = @"select idPaciente, Concat(Cedula, ' ', Nombre, ' ',Apellido) as Nombre from PACIENTES";
                DataTable tabla = ConexionDB.Instancia.EjecutarConsulta(comando);
                List<ComboBoxItem> listaPacientes = (from rw in tabla.AsEnumerable()
                                                     select new ComboBoxItem(Convert.ToString(rw["Nombre"]), Convert.ToString(rw["idPaciente"]))

                ).ToList<ComboBoxItem>();

                return listaPacientes;
            }

            public List<ComboBoxItem> ObtenerAseguradoras()
            {
                string comando = @"select idSeguro, NombreSeguro as Nombre from CAT_SEGUROS";
                DataTable tabla = ConexionDB.Instancia.EjecutarConsulta(comando);
                List<ComboBoxItem> listaAseguradoras = (from rw in tabla.AsEnumerable()
                                                        select new ComboBoxItem(Convert.ToString(rw["Nombre"]), Convert.ToString(rw["idSeguro"]))
                                                    ).ToList<ComboBoxItem>();
                return listaAseguradoras;
            }

            public DataTable ObtenerServicios()
            {
                string comando = @"select NombreServicio as Servicio, 0 as Cantidad, PrecioUnitario as 'Precio Unit.', 0 as Subtotal from SERVICIOS;";
                return ConexionDB.Instancia.EjecutarConsulta(comando);
            }
            public List<ComboBoxItem> ObtenerFacturas()
            {
                string comando = @"select * from FACTURAS where EstadoFactura != 'Pagada'";
                DataTable tabla = ConexionDB.Instancia.EjecutarConsulta(comando);
                List<ComboBoxItem> listaFacturas = (from rw in tabla.AsEnumerable()
                                                    select new ComboBoxItem(Convert.ToString(rw["NroFactura"]), Convert.ToString(rw["idFactura"]))
                                    ).ToList<ComboBoxItem>();
                return listaFacturas;
            }

            public PacienteDatosCajaRetorno ObtenerFactura(string idFactura)
            {
                string comando = @" select Facturas.IdFactura, FACTURAS.IdPaciente, Concat(PACIENTES.Nombre, ' ', PACIENTES.Apellido) as Nombre, COALESCE(SUM(PAGOS.MontoAPagar), FACTURAS.Total) as MontoPagado, FACTURAS.Total
                                    from FACTURAS
									left join PAGOS
                                    on Pagos.IdFactura = FACTURAS.IdFactura
                                    inner join PACIENTES
                                    on FACTURAS.IdPaciente = PACIENTES.IdPaciente
                                    where FACTURAS.idFactura = @idFactura and FACTURAS.EstadoFactura != 'Pagada'
									group by Pagos.IdFactura, FACTURAS.IdFactura, FACTURAS.IdPaciente, PACIENTES.Nombre, PACIENTES.Apellido, FACTURAS.Total;
                                    ";
                SqlParameter[] parametros = { CrearParametro("idFactura", SqlDbType.Int) };
                parametros[0].Value = Convert.ToInt32(idFactura);

                DataTable fila = ConexionDB.Instancia.EjecutarConsulta(comando, parametros);
                return new PacienteDatosCajaRetorno(fila.Rows[0]["Nombre"].ToString(),
                                                    Convert.ToDecimal(fila.Rows[0]["Total"]),
                                                    Convert.ToDecimal(fila.Rows[0]["MontoPagado"])
                                                    );

            }

            public void InsertarPago(Pago pago)
            {
                try
                {
                    if (!ConexionDB.Instancia.VerificarBaseDatos()) return; // En caso de que la conexión no este abierta entonces regresa
                    string comando = @"INSERT INTO PAGOS (IdFactura, MontoAPagar, FormaPago, FechaPago, NumeroReferencia, EstadoPago, ObservacionesCaja) " +
                                                    "VALUES (@idFac, @monto, @tipo, @fecha, @numRef, @estado, @observacion);";
                    SqlParameter[] parametros =
                    {
                        CrearParametro("idFac", SqlDbType.Int),
                        CrearParametro("monto", SqlDbType.Decimal),
                        CrearParametro("tipo", SqlDbType.VarChar),
                        CrearParametro("fecha", SqlDbType.Date),
                        CrearParametro("numRef", SqlDbType.VarChar),
                        CrearParametro("estado", SqlDbType.VarChar),
                        CrearParametro("observacion", SqlDbType.VarChar)
                    };

                    parametros[0].Value = pago.IdFactura;
                    parametros[1].Value = pago.MontoAPagar;
                    parametros[2].Value = pago.FormaPago;
                    parametros[3].Value = pago.FechaPago;
                    parametros[4].Value = pago.NumeroReferencia;
                    parametros[5].Value = pago.EstadoPago;
                    parametros[6].Value = pago.Observacion ?? null;

                    ConexionDB.Instancia.EjecutarComando(comando, parametros);
                }
                catch (Exception e)
                {
                    throw;
                }
            }

            /************ MÉTODOS PARA IMPRIMIR EN UN ARCHIVO ***************/
            public void ToPdf(string Filename, Pago p, string nombrePaciente, string totalFactura)
            {
                var preview = new PrintPreviewDialog();
                var pd = new System.Drawing.Printing.PrintDocument();
                pd.PrintPage += (s, ev) =>
                {
                    float leftMargin = 40;
                    float rightMargin = ev.MarginBounds.Right;
                    float y = 40;

                    // Increased font sizes
                    var fontTitle = new Font("Segoe UI", 22, FontStyle.Bold);
                    var fontHeader = new Font("Segoe UI", 14, FontStyle.Bold);
                    var fontBody = new Font("Segoe UI", 13);
                    var fontFooter = new Font("Segoe UI", 11, FontStyle.Italic);

                    // --- Hospital Header ---
                    ev.Graphics.DrawString("Hospital General - Factura de Pago", fontTitle, new SolidBrush(ColorTranslator.FromHtml("#3861b5")), leftMargin, y);
                    y += 50;
                    ev.Graphics.DrawLine(Pens.Black, leftMargin, y, rightMargin, y);
                    y += 25;

                    // --- Datos del paciente ---
                    ev.Graphics.DrawString("Paciente:", fontHeader, Brushes.Black, leftMargin, y);
                    ev.Graphics.DrawString(nombrePaciente, fontBody, Brushes.Black, leftMargin + 180, y);
                    y += 30;

                    ev.Graphics.DrawString("Id Factura:", fontHeader, Brushes.Black, leftMargin, y);
                    ev.Graphics.DrawString(p.IdFactura.ToString(), fontBody, Brushes.Black, leftMargin + 180, y);
                    y += 30;

                    ev.Graphics.DrawString("N° Referencia:", fontHeader, Brushes.Black, leftMargin, y);
                    ev.Graphics.DrawString(p.NumeroReferencia, fontBody, Brushes.Black, leftMargin + 180, y);
                    y += 30;

                    ev.Graphics.DrawString("Fecha:", fontHeader, Brushes.Black, leftMargin, y);
                    ev.Graphics.DrawString(p.FechaPago, fontBody, Brushes.Black, leftMargin + 180, y);
                    y += 30;

                    // --- Estado antes de la tabla ---
                    ev.Graphics.DrawString("Estado:", fontHeader, Brushes.Black, leftMargin, y);
                    ev.Graphics.DrawString(p.EstadoPago, fontBody, Brushes.Black, leftMargin + 180, y);
                    y += 50;

                    // --- Sección de pagos tipo tabla ---
                    int colWidth = 220;
                    int rowHeight = 40;
                    string[] headers = { "Forma de Pago", "Monto Pagado", "Total Factura" };
                    string[] values = { p.FormaPago, p.MontoAPagar.ToString("C"), Convert.ToDecimal(totalFactura).ToString("C") };

                    // Encabezados
                    for (int i = 0; i < headers.Length; i++)
                    {
                        Rectangle rect = new Rectangle((int)(leftMargin + i * colWidth), (int)y, colWidth, rowHeight);
                        ev.Graphics.FillRectangle(Brushes.LightGray, rect);
                        ev.Graphics.DrawRectangle(Pens.Black, rect);
                        ev.Graphics.DrawString(headers[i], fontHeader, Brushes.Black, rect);
                    }
                    y += rowHeight;

                    // Valores
                    for (int i = 0; i < values.Length; i++)
                    {
                        Rectangle rect = new Rectangle((int)(leftMargin + i * colWidth), (int)y, colWidth, rowHeight);
                        ev.Graphics.DrawRectangle(Pens.Black, rect);
                        ev.Graphics.DrawString(values[i], fontBody, Brushes.Black, rect);
                    }
                    y += rowHeight + 50;

                    // --- Observaciones ---
                    ev.Graphics.DrawString("Observación:", fontHeader, Brushes.Black, leftMargin, y);
                    ev.Graphics.DrawString(p.Observacion, fontBody, Brushes.Black, leftMargin + 180, y);
                    y += 50;

                    // --- Footer ---
                    ev.Graphics.DrawLine(Pens.Black, leftMargin, y, rightMargin, y);
                    y += 15;
                    ev.Graphics.DrawString("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                                           fontFooter, Brushes.Gray, leftMargin, y);
                    ev.Graphics.DrawString("Gracias por confiar en Hospital General", fontFooter, Brushes.Gray, rightMargin - 300, y);
                };

                preview.Document = pd;
                try
                {
                    preview.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al preparar la impresión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        /**************************************************************
         ***************                       ************************
         ***************       CLASE DATOS     ************************
         ***************                       ************************
         **************************************************************/

        private class Pago
        {
            public int IdFactura;
            public decimal MontoAPagar;
            public string FormaPago;
            public string FechaPago;
            public string NumeroReferencia;
            public string EstadoPago;
            public string Observacion;

            public Pago(int id, decimal monto, string forma, string fecha, string referencia, string estado, string obs = null)
            {
                IdFactura = id;
                MontoAPagar = monto;
                FormaPago = forma;
                FechaPago = fecha;
                NumeroReferencia = referencia;
                EstadoPago = estado;
                Observacion = obs;
            }
        }

        private class DetalleFactura
        {
            public int IdFactura;
            public int IdServicio;
            public int Cantidad;
            public decimal PrecioUnitario;
            public decimal Subtotal;

            public DetalleFactura(int id, int servicio, int cant, decimal precio, decimal total)
            {
                IdFactura = id;
                IdServicio = servicio;
                Cantidad = cant;
                PrecioUnitario = precio;
                Subtotal = total;
            }
        }

        private class PacienteDatosCajaRetorno
        {

            public string Nombre;
            public decimal Monto;
            public decimal TotalPagado;

            public PacienteDatosCajaRetorno(string nombre, decimal total, decimal totalAPagar)
            {
                Nombre = nombre;
                Monto = total;
                TotalPagado = totalAPagar;
            }
        }

        private class ComboBoxItem
        {
            string nombre;
            string idValor;

            // Constructor
            public ComboBoxItem(string d, string h)
            {
                nombre = d;
                idValor = h;
            }

            // Para acceder al id del paciente en vez del nombre
            public int IdValor
            {
                get
                {
                    return int.Parse(idValor);
                }
            }

            public override string ToString()
            {
                return nombre;
            }
        }

        private class Factura
        {
            public string NroFactura;
            public int IdPaciente;
            public int IdAseguradora;
            public string NroPoliza;
            public string Fecha;
            public float Subtotal;
            public float Descuento;
            public float Impuesto;
            public float Total;
            public string Estado;
            public string Observaciones;

            public Factura(string NFact, int idPaciente, int idAseguradora, string nroPoliza, string fecha, float subtotal, float descuento, float impuesto, float total, string estado, string observaciones)
            {
                NroFactura = NFact;
                IdPaciente = idPaciente;
                IdAseguradora = idAseguradora;
                NroPoliza = nroPoliza;
                Fecha = fecha;
                Subtotal = subtotal;
                Descuento = descuento;
                Impuesto = impuesto;
                Estado = estado;
                Total = total;
                Observaciones = observaciones;
            }


        };


    }

}