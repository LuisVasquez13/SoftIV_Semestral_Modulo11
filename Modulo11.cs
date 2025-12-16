using System;
using System.Windows.Forms;

namespace Borrador
{
    public partial class Modulo11 : UserControl
    {
        public Modulo11()
        {
            InitializeComponent();
            ConfigurarEventos();

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
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgvServiciosF.Rows)
            {
                if (row.IsNewRow) continue;
                decimal cantidad = 0, precio = 0;
                decimal.TryParse(Convert.ToString(row.Cells[1].Value), out cantidad);
                decimal.TryParse(Convert.ToString(row.Cells[2].Value), out precio);
                row.Cells[3].Value = (cantidad * precio).ToString("0.00");
                subtotal += cantidad * precio;
            }

            txtSubtotalF.Text = subtotal.ToString("0.00");
            decimal desc = subtotal * (nudDescuentoF.Value / 100);
            decimal imp = (subtotal - desc) * (nudImpuestoF.Value / 100);
            txtTotalF.Text = (subtotal - desc + imp).ToString("0.00");
        }

        private void BtnGuardarImprimirF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Factura guardada e impresa (simulado)", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbNumFacturaC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPacienteC.Text = "Paciente Demo";
            txtTotalFacturaC.Text = "120.00";
            txtMontoPagadoC.Text = "0.00";
        }

        private void BtnRegistrarPagoC_Click(object sender, EventArgs e)
        {
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
    }
}