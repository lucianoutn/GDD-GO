namespace ClinicaFrba.Listados
{
    partial class Listado_Estadistico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.comboBoxTop5 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTop5 = new System.Windows.Forms.DataGridView();
            this.Col_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProfOAf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_GrupoFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_volver = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.comboBoxAnio = new System.Windows.Forms.ComboBox();
            this.labelMes = new System.Windows.Forms.Label();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Top 5:";
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Location = new System.Drawing.Point(82, 50);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemestre.TabIndex = 3;
            this.comboBoxSemestre.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemestre_SelectedIndexChanged);
            // 
            // comboBoxTop5
            // 
            this.comboBoxTop5.FormattingEnabled = true;
            this.comboBoxTop5.Location = new System.Drawing.Point(82, 84);
            this.comboBoxTop5.Name = "comboBoxTop5";
            this.comboBoxTop5.Size = new System.Drawing.Size(384, 21);
            this.comboBoxTop5.TabIndex = 4;
            this.comboBoxTop5.SelectedIndexChanged += new System.EventHandler(this.comboBoxTop5_SelectedIndexChanged);
            // 
            // dataGridViewTop5
            // 
            this.dataGridViewTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Especialidad,
            this.Col_ProfOAf,
            this.Col_Cantidad,
            this.Col_GrupoFam});
            this.dataGridViewTop5.Location = new System.Drawing.Point(25, 147);
            this.dataGridViewTop5.Name = "dataGridViewTop5";
            this.dataGridViewTop5.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewTop5.TabIndex = 5;
            // 
            // Col_Especialidad
            // 
            this.Col_Especialidad.HeaderText = "Especialidad";
            this.Col_Especialidad.Name = "Col_Especialidad";
            // 
            // Col_ProfOAf
            // 
            this.Col_ProfOAf.HeaderText = "Profesional o Afiliado";
            this.Col_ProfOAf.Name = "Col_ProfOAf";
            // 
            // Col_Cantidad
            // 
            this.Col_Cantidad.HeaderText = "Cantidad";
            this.Col_Cantidad.Name = "Col_Cantidad";
            // 
            // Col_GrupoFam
            // 
            this.Col_GrupoFam.HeaderText = "Grupo Familiar";
            this.Col_GrupoFam.Name = "Col_GrupoFam";
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(25, 310);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 7;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(391, 310);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 8;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // comboBoxAnio
            // 
            this.comboBoxAnio.FormattingEnabled = true;
            this.comboBoxAnio.Location = new System.Drawing.Point(82, 16);
            this.comboBoxAnio.Name = "comboBoxAnio";
            this.comboBoxAnio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnio.TabIndex = 10;
            this.comboBoxAnio.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnio_SelectedIndexChanged);
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(309, 53);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(30, 13);
            this.labelMes.TabIndex = 11;
            this.labelMes.Text = "Mes:";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Location = new System.Drawing.Point(345, 49);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMes.TabIndex = 12;
            this.comboBoxMes.SelectedIndexChanged += new System.EventHandler(this.comboBoxMes_SelectedIndexChanged);
            // 
            // Listado_Estadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 345);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.comboBoxAnio);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.dataGridViewTop5);
            this.Controls.Add(this.comboBoxTop5);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Listado_Estadistico";
            this.Text = "ListadoEstadistico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.ComboBox comboBoxTop5;
        private System.Windows.Forms.DataGridView dataGridViewTop5;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.ComboBox comboBoxAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProfOAf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_GrupoFam;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.ComboBox comboBoxMes;
    }
}