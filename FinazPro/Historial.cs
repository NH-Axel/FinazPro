using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinazPro
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string NombreProducto = NProducto.Text;
            string ruta = Path.Combine(Application.StartupPath, "Productos");
            if (!string.IsNullOrEmpty(NombreProducto))
            {
                dataGridView1.Visible = true; //Va a cargar el dataGrid
                string[] archivos = Directory.GetFiles(ruta, NombreProducto + "*.txt");

                if (archivos.Length > 0)
                {
                    string filePath = archivos[0]; // Para cargar el primer archivo que coincida con el que busca el usuario 

                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);

                        // Limpiar el DataGridView antes de cargar nuevos datos
                        dataGridView1.Rows.Clear();

                        // Agregar los datos al DataGridView
                        foreach (string line in lines)
                        {
                            string[] values = line.Split('\t'); // Por que hemos separado los datos por tabs
                            dataGridView1.Rows.Add(values);
                        }

                        MessageBox.Show("Archivo cargado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al abrir el archivo: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("El archivo especificado no existe.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre del archivo.");
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false; //Activa el modo de edicion
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string Ruta = Path.Combine(Application.StartupPath, "Productos");
            string NombreP = NProducto.Text.Trim();

            // Comprueba que el nombre ingresado no esté vacío antes de intentar guardar el archivo
            if (!string.IsNullOrEmpty(NombreP))
            {
                string filePath = Path.Combine(Ruta, NombreP + ".txt"); // Agrega la extensión .txt al nombre del archivo

                try
                {
                    // Crear el archivo con los datos del DataGridView
                    using (StreamWriter Crear = new StreamWriter(filePath))
                    {
                        // Escribir los encabezados de las columnas
                        foreach (DataGridViewColumn columna in dataGridView1.Columns)
                        {
                            Crear.Write(columna.HeaderText + "\t");
                        }
                        Crear.WriteLine(); // Nueva línea después de los encabezados

                        // Escribir los datos de cada fila
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                foreach (DataGridViewCell celda in fila.Cells)
                                {
                                    if (celda.Value != null)
                                    {
                                        Crear.Write(celda.Value.ToString() + "\t");
                                    }
                                    else
                                    {
                                        Crear.Write("\t"); // Si la celda está vacía, escribe 1 espacio
                                    }
                                }
                                Crear.WriteLine(); // Nueva línea después de cada fila
                            }
                        }
                    }

                    MessageBox.Show("Los datos se han guardado correctamente en el archivo.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los datos en el archivo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("El nombre del producto está vacío.");
            }
        }

        private void ExportarPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            string ProductoNombre = NProducto.Text;
            try
            {
                // Crear un objeto PdfWriter para escribir en el archivo PDF
                string Ruta = Path.Combine(Application.StartupPath, "Productos\\");
                string filePath = Ruta+ "Producto_" + NProducto.Text.ToString() + ".pdf";
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                // Abrir el documento para escribir
                doc.Open();

                // Agregar un nombre grande en la parte superior del documento
                iTextSharp.text.Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24, BaseColor.BLACK); //SE coloco iTextSharp.text por que si no el sistema no lo reconoce
                Paragraph titulo = new Paragraph(ProductoNombre, fontTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                // Agregar espacio en blanco, para evitar que salga todo junto
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));

                // Crear una tabla con el mismo número de columnas que el DataGridView
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                // Agregar los encabezados de las columnas al PDF
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                // Agregar las filas y celdas al PDF
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Verificar si el valor de la celda no es nulo antes de intentar acceder a él
                        if (cell.Value != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                        else
                        {
                            pdfTable.AddCell(""); // Si el valor es nulo, agregar una celda vacía al PDF
                        }
                    }
                }

                // Agregar la tabla al documento
                doc.Add(pdfTable);

                // Abrir el archivo PDF generado automáticamente
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar los datos a PDF: {ex.Message}");
            }
            finally
            {
                // Cerrar el documento
                doc.Close();
            }
        }
    }
    
}

