namespace ClinicaFrba.Registro_Resultado
{
    partial class SeleccionarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarTurno));
            this.label1 = new System.Windows.Forms.Label();
            this.button_abrirCosulta = new System.Windows.Forms.Button();
            this.button_Volver = new System.Windows.Forms.Button();
            this.dataGridViewTurnos = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar turno:";
            // 
            // button_abrirCosulta
            // 
            this.button_abrirCosulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_abrirCosulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_abrirCosulta.Location = new System.Drawing.Point(288, 305);
            this.button_abrirCosulta.Name = "button_abrirCosulta";
            this.button_abrirCosulta.Size = new System.Drawing.Size(109, 23);
            this.button_abrirCosulta.TabIndex = 10;
            this.button_abrirCosulta.Text = "Seleccionar";
            this.button_abrirCosulta.UseVisualStyleBackColor = true;
            this.button_abrirCosulta.Click += new System.EventHandler(this.button_abrirCosulta_Click);
            // 
            // button_Volver
            // 
            this.button_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Volver.ForeColor = System.Drawing.Color.Maroon;
            this.button_Volver.Location = new System.Drawing.Point(48, 305);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 11;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // dataGridViewTurnos
            // 
            this.dataGridViewTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.nombre,
            this.hora_llegada,
            this.id_turno});
            this.dataGridViewTurnos.Location = new System.Drawing.Point(54, 77);
            this.dataGridViewTurnos.Name = "dataGridViewTurnos";
            this.dataGridViewTurnos.Size = new System.Drawing.Size(343, 173);
            this.dataGridViewTurnos.TabIndex = 15;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre y Apellido";
            this.nombre.Name = "nombre";
            // 
            // hora_llegada
            // 
            this.hora_llegada.HeaderText = "Hora Llegada";
            this.hora_llegada.Name = "hora_llegada";
            // 
            // id_turno
            // 
            this.id_turno.HeaderText = "Id_turno";
            this.id_turno.Name = "id_turno";
            this.id_turno.Visible = false;
            // 
            // SeleccionarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 347);
            this.Controls.Add(this.dataGridViewTurnos);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_abrirCosulta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeleccionarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado de Atención Médica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_abrirCosulta;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.DataGridView dataGridViewTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_turno;
    }
}