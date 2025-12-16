using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Borrador
{
    public partial class Modulo5 : UserControl
    {
        public Modulo5()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void interface_1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int radio = 20; // Tamaño del redondeado
            Color colorBorde = Color.Gray; // Color del borde

            // Suavizado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear ruta del borde redondeado
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            // Relleno del panel
            using (SolidBrush brush = new SolidBrush(panel.BackColor))
                e.Graphics.FillPath(brush, path);

            // Borde gris
            using (Pen pen = new Pen(colorBorde, 2)) // Grosor 2 px
                e.Graphics.DrawPath(pen, path);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int radio = 20; // Tamaño del redondeado
            Color colorBorde = Color.Gray; // Color del borde

            // Suavizado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear ruta del borde redondeado
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            // Relleno del panel
            using (SolidBrush brush = new SolidBrush(panel.BackColor))
                e.Graphics.FillPath(brush, path);

            // Borde gris
            using (Pen pen = new Pen(colorBorde, 2)) // Grosor 2 px
                e.Graphics.DrawPath(pen, path);
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void UCOrdenLaboratorio_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int radio = 20; // Tamaño del redondeado
            Color colorBorde = Color.Gray; // Color del borde

            // Suavizado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear ruta del borde redondeado
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            // Relleno del panel
            using (SolidBrush brush = new SolidBrush(panel.BackColor))
                e.Graphics.FillPath(brush, path);

            // Borde gris
            using (Pen pen = new Pen(colorBorde, 2)) // Grosor 2 px
                e.Graphics.DrawPath(pen, path);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int radio = 20; // Tamaño del redondeado
            Color colorBorde = Color.Gray; // Color del borde

            // Suavizado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear ruta del borde redondeado
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            // Relleno del panel
            using (SolidBrush brush = new SolidBrush(panel.BackColor))
                e.Graphics.FillPath(brush, path);

            // Borde gris
            using (Pen pen = new Pen(colorBorde, 2)) // Grosor 2 px
                e.Graphics.DrawPath(pen, path);
        }
    }
}