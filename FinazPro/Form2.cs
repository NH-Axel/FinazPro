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
    }
}
