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
            this.nombreP = new System.Windows.Forms.MaskedTextBox();
            this.Guardar = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(45, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(663, 216);
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
            this.label1.Location = new System.Drawing.Point(197, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto: ";
            // 
            // nombreP
            // 
            this.nombreP.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreP.Location = new System.Drawing.Point(295, 21);
            this.nombreP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreP.Name = "nombreP";
            this.nombreP.Size = new System.Drawing.Size(189, 27);
            this.nombreP.TabIndex = 3;
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(59, 348);
            this.Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(98, 34);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(611, 348);
            this.Calcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(98, 34);
            this.Calcular.TabIndex = 7;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 418);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.nombreP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "FinazPro 0.1";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.MaskedTextBox nombreP;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Calcular;
    }
}