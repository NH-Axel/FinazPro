namespace FinazPro
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.CrearArchivo = new System.Windows.Forms.Button();
            this.CargarArchivo = new System.Windows.Forms.Button();
            this.AbrirPDF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CrearArchivo
            // 
            this.CrearArchivo.Location = new System.Drawing.Point(12, 90);
            this.CrearArchivo.Name = "CrearArchivo";
            this.CrearArchivo.Size = new System.Drawing.Size(237, 56);
            this.CrearArchivo.TabIndex = 0;
            this.CrearArchivo.Text = "Crear Nueva Cotizacion";
            this.CrearArchivo.UseVisualStyleBackColor = true;
            this.CrearArchivo.Click += new System.EventHandler(this.CrearArchivo_Click);
            // 
            // CargarArchivo
            // 
            this.CargarArchivo.Location = new System.Drawing.Point(12, 260);
            this.CargarArchivo.Name = "CargarArchivo";
            this.CargarArchivo.Size = new System.Drawing.Size(237, 56);
            this.CargarArchivo.TabIndex = 1;
            this.CargarArchivo.Text = "Abrir Cootizaciones Pasadas";
            this.CargarArchivo.UseVisualStyleBackColor = true;
            this.CargarArchivo.Click += new System.EventHandler(this.CargarArchivo_Click);
            // 
            // AbrirPDF
            // 
            this.AbrirPDF.Location = new System.Drawing.Point(12, 177);
            this.AbrirPDF.Name = "AbrirPDF";
            this.AbrirPDF.Size = new System.Drawing.Size(237, 56);
            this.AbrirPDF.TabIndex = 2;
            this.AbrirPDF.Text = "Abrir Cotizacion en PDF";
            this.AbrirPDF.UseVisualStyleBackColor = true;
            this.AbrirPDF.Click += new System.EventHandler(this.AbrirPDF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 134);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.AbrirPDF);
            this.Controls.Add(this.CargarArchivo);
            this.Controls.Add(this.CrearArchivo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "FinazPro 0.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrearArchivo;
        private System.Windows.Forms.Button CargarArchivo;
        private System.Windows.Forms.Button AbrirPDF;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}