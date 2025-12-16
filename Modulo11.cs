
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Borrador
{
    public partial class Modulo11 : UserControl
    {
        private ConeccionSqlAdministracion conn = new ConeccionSqlAdministracion();
        private List<DetalleFactura> listaDetalles = new List<DetalleFactura>();
        private int UltimaFacturaId = 0;
        public Modulo11()
        {
            //ConexionDB.Instancia.ConstruirCadenaConexionSQL("", "ClinicaPro2", "", "");
            InitializeComponent();
            ConfigurarEventos();
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<ComboBoxItem> listaPacientes = conn.ObtenerPacientes();
            List<ComboBoxItem> listaAseguradoras = conn.ObtenerAseguradoras();
            List<ComboBoxItem> listaFacturas = conn.ObtenerFacturas();
            DataTable tablaServicios = conn.ObtenerServicios();

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

            dgvServiciosF.Columns.Clear();
            tablaServicios.Columns["Servicio"].ReadOnly = true;
            tablaServicios.Columns["Cantidad"].ReadOnly = false;
            tablaServicios.Columns["Precio Unit."].ReadOnly = true;
            tablaServicios.Columns["Subtotal"].ReadOnly = true;
            dgvServiciosF.ReadOnly = false;
            dgvServiciosF.DataSource = tablaServicios;
        }

        private void ConfigurarEventos()
        {
            btnCalcularF.Click += BtnCalcularF_Click;
            btnGuardarImprimirF.Click += BtnGuardarImprimirF_Click;
            cmbNumFacturaC.SelectedIndexChanged += CmbNumFacturaC_SelectedIndexChanged;
            btnRegistrarPagoC.Click += BtnRegistrarPagoC_Click;
            btnImprimirReciboC.Click += BtnImprimirReciboC_Click;
        }

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
                //row.Cells[3].Value = (cantidad * precio);
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

        private void BtnGuardarImprimirF_Click(object sender, EventArgs e)
        {
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

        private void CmbNumFacturaC_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacienteDatosCajaRetorno pacienteDatos = conn.ObtenerFactura(((ComboBoxItem)cmbNumFacturaC.SelectedItem).IdValor.ToString());
            txtPacienteC.Text = pacienteDatos.Nombre;
            txtTotalFacturaC.Text = pacienteDatos.Monto.ToString();
            txtMontoPagadoC.Text = pacienteDatos.TotalPagado.ToString();
        }

        private void BtnRegistrarPagoC_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Recibo impreso (simulado)", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void nudMontoPagarC_ValueChanged(object sender, EventArgs e)
        {

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

        private class ConeccionSqlAdministracion
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


            // Obtiene la lista de todos los alumnos(utiliza una versión con menos datos de los alumnos)
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
                                    where FACTURAS.idFactura = @idFactura
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
        }

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