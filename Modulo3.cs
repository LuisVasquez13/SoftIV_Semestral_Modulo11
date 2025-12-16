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
    public partial class Modulo3 : UserControl
    {
        public Modulo3()
        {
            InitializeComponent();
        }



        private void BtnConsul_Click(object sender, EventArgs e)
        {

        }

        private void Gpoboxhistorial_Enter(object sender, EventArgs e)
        {

        }

        private void BtnConsul_Click_1(object sender, EventArgs e)
        {
            tabforms.SelectedIndex = 0; // volver a consulta médica
        }

        private void Btnhist_Click(object sender, EventArgs e)
        {
            tabforms.SelectedIndex = 1; // ir al historial
        }

        private void DtaGriewprees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grpbxform1_Enter(object sender, EventArgs e)
        {

        }
    }
}