using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinazPro
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void CrearArchivo_Click(object sender, EventArgs e)
        {
            Form CrearArchivo = new Form2();
            CrearArchivo.Show();
        }

        private void AbrirPDF_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarArchivo_Click(object sender, EventArgs e)
        {
            Form Historial = new Historial();
            Historial.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
