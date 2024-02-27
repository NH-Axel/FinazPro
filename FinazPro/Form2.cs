using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace FinazPro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Historial_Click(object sender, EventArgs e)
        {
            Form historial = new Historial();
            historial.Show();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double TotalC = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (!fila.IsNewRow)
                {
                    object valorCostoUnidad = fila.Cells["costoUnidad"].Value;
                    object valorCantidad = fila.Cells["cantidad"].Value;

                    if (valorCostoUnidad != null && valorCantidad != null)
                    {
                        double costoUnidad = double.Parse(valorCostoUnidad.ToString());
                        double cantidad = double.Parse(valorCantidad.ToString());
                        double costoTotal = costoUnidad * cantidad;
                        fila.Cells["CostoTotal"].Value = costoTotal;

                        // Acumula el costo total dentro del bucle
                        TotalC += costoTotal;
                    }
                }
            }

            // Agrega la suma total en una nueva fila al final del DataGridView
            int nuevaFila = dataGridView1.Rows.Add();
            dataGridView1.Rows[nuevaFila].Cells["CostoTotal"].Value = TotalC;
            dataGridView1.Rows[nuevaFila].Cells["Cantidad"].Value = "Total gastado";
            // La propiedad ReadOnly de la nueva fila es para que no sea editable por el usuario
            dataGridView1.Rows[nuevaFila].ReadOnly = true;
            //AllowUserToAddRows en false para evitar que se creen más filas automáticamente
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string Ruta = Path.Combine(Application.StartupPath, "Productos\\");
            string NombreP = nombreP.Text.ToString();
            // Comprueba que el nombreIngresado no esté vacío antes de intentar guardar el archivo
            if (!string.IsNullOrEmpty(NombreP))
            {
                string filePath = Ruta + NombreP + ".txt"; // Agrega la extensión .txt al nombre del archivo

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
                        Crear.WriteLine(); // Agregar una nueva línea después de escribir los encabezados

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
                                Crear.WriteLine(); // Agregar una nueva línea después de escribir una fila
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
                MessageBox.Show("El nombre de la ruta de acceso está vacío.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
