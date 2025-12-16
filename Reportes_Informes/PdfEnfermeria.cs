using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

public static class PdfEnfermeria
{
    public static void Generar(
        string paciente,
        DateTime fecha,
        string turno,
        DataGridView dgvIntervenciones,
        DataGridView dgvSignos,
        string observaciones
    )
    {
        try
        {
            string ruta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"Enfermeria_{paciente.Replace(" ", "_")}_{DateTime.Now:yyyyMMddHHmm}.pdf"
            );

            Document doc = new Document(PageSize.A4, 40, 40, 50, 50);
            PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open();

            // ==== FUENTES ====
            Font titulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Font subtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
            Font normal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            Font headerTabla = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, new BaseColor(220, 220, 220));

            // ==== ENCABEZADO ====
            Paragraph encabezado = new Paragraph("CLÍNICA / HOSPITAL\nDepartamento de Enfermería", titulo);
            encabezado.Alignment = Element.ALIGN_CENTER;
            encabezado.SpacingAfter = 20;
            doc.Add(encabezado);

            // ==== DATOS DEL PACIENTE ====
            PdfPTable datos = new PdfPTable(2);
            datos.WidthPercentage = 100;
            datos.SetWidths(new float[] { 30, 70 });

            AgregarCelda(datos, "Paciente:", paciente, subtitulo, normal);
            AgregarCelda(datos, "Fecha:", fecha.ToString("dd/MM/yyyy"), subtitulo, normal);
            AgregarCelda(datos, "Turno:", turno, subtitulo, normal);

            datos.SpacingAfter = 15;
            doc.Add(datos);

            // ==== INTERVENCIONES ====
            doc.Add(new Paragraph("Intervenciones de Enfermería", subtitulo));
            doc.Add(new Paragraph(" "));
            doc.Add(CrearTablaDesdeGrid(dgvIntervenciones, headerTabla));

            doc.Add(new Paragraph(" "));

            // ==== SIGNOS VITALES ====
            doc.Add(new Paragraph("Signos Vitales", subtitulo));
            doc.Add(new Paragraph(" "));
            doc.Add(CrearTablaDesdeGrid(dgvSignos, headerTabla));

            // ==== OBSERVACIONES ====
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Observaciones", subtitulo));

            PdfPTable obs = new PdfPTable(1);
            obs.WidthPercentage = 100;

            PdfPCell obsCell = new PdfPCell(new Phrase(
                string.IsNullOrWhiteSpace(observaciones) ? "Sin observaciones." : observaciones,
                normal
            ));
            obsCell.MinimumHeight = 60;
            obsCell.Padding = 8;
            obsCell.BackgroundColor = new BaseColor(245, 245, 245);
            obs.AddCell(obsCell);

            doc.Add(obs);

            // ==== FOOTER ====
            Paragraph footer = new Paragraph(
                $"Documento generado el {DateTime.Now:dd/MM/yyyy HH:mm}",
                FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8)
            );
            footer.Alignment = Element.ALIGN_RIGHT;
            footer.SpacingBefore = 20;
            doc.Add(footer);

            doc.Close();

            MessageBox.Show("PDF generado correctamente en el Escritorio.",
                "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al generar PDF:\n" + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ================== MÉTODOS AUXILIARES ==================

    private static void AgregarCelda(
        PdfPTable tabla,
        string etiqueta,
        string valor,
        Font fontEtiqueta,
        Font fontValor
    )
    {
        tabla.AddCell(new PdfPCell(new Phrase(etiqueta, fontEtiqueta))
        {
            Border = Rectangle.NO_BORDER,
            Padding = 5
        });

        tabla.AddCell(new PdfPCell(new Phrase(valor, fontValor))
        {
            Border = Rectangle.NO_BORDER,
            Padding = 5
        });
    }

    private static PdfPTable CrearTablaDesdeGrid(DataGridView dgv, Font headerFont)
    {
        PdfPTable tabla = new PdfPTable(dgv.Columns.Count);
        tabla.WidthPercentage = 100;

        // Headers
        foreach (DataGridViewColumn col in dgv.Columns)
        {
            PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, headerFont));
            cell.BackgroundColor = new BaseColor(52, 73, 94); // azul gris
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Padding = 5;
            tabla.AddCell(cell);
        }

        // Filas
        foreach (DataGridViewRow row in dgv.Rows)
        {
            if (row.IsNewRow) continue;

            foreach (DataGridViewCell cell in row.Cells)
            {
                tabla.AddCell(new PdfPCell(new Phrase(
                    cell.Value?.ToString() ?? "",
                    FontFactory.GetFont(FontFactory.HELVETICA, 9)
                ))
                {
                    Padding = 4
                });
            }
        }

        return tabla;
    }
}
