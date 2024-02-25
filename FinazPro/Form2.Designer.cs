namespace FinazPro
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.CrearPDF = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaPrima,
            this.CostoUnidad,
            this.Cantidad,
            this.CostoTotal});
            this.dataGridView1.Location = new System.Drawing.Point(68, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(995, 333);
            this.dataGridView1.TabIndex = 1;
            // 
            // MateriaPrima
            // 
            this.MateriaPrima.HeaderText = "Materia Prima";
            this.MateriaPrima.MinimumWidth = 8;
            this.MateriaPrima.Name = "MateriaPrima";
            this.MateriaPrima.Width = 150;
            // 
            // CostoUnidad
            // 
            this.CostoUnidad.HeaderText = "Costo por unidad";
            this.CostoUnidad.MinimumWidth = 8;
            this.CostoUnidad.Name = "CostoUnidad";
            this.CostoUnidad.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "CostoTotal";
            this.CostoTotal.MinimumWidth = 8;
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            this.CostoTotal.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto: ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(442, 33);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(281, 37);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(89, 535);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(147, 52);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // CrearPDF
            // 
            this.CrearPDF.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearPDF.Location = new System.Drawing.Point(346, 535);
            this.CrearPDF.Name = "CrearPDF";
            this.CrearPDF.Size = new System.Drawing.Size(187, 52);
            this.CrearPDF.TabIndex = 5;
            this.CrearPDF.Text = "Crear PDF";
            this.CrearPDF.UseVisualStyleBackColor = true;
            // 
            // Historial
            // 
            this.Historial.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historial.Location = new System.Drawing.Point(876, 535);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(187, 52);
            this.Historial.TabIndex = 6;
            this.Historial.Text = "Historial";
            this.Historial.UseVisualStyleBackColor = true;
            this.Historial.Click += new System.EventHandler(this.Historial_Click);
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(636, 535);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(147, 52);
            this.Calcular.TabIndex = 7;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 643);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.CrearPDF);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "FinazPro 0.01v";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button CrearPDF;
        private System.Windows.Forms.Button Historial;
        private System.Windows.Forms.Button Calcular;
    }
}