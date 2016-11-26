namespace ClinicaFrba.Registro_Llegada
{
    partial class SubmenuRegistro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmenuRegistro));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboProfesional = new System.Windows.Forms.ComboBox();
            this.comboEspecialidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridTurno = new System.Windows.Forms.DataGridView();
            this.registrar = new System.Windows.Forms.Button();
            this.idTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(328, 298);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboProfesional);
            this.groupBox1.Controls.Add(this.comboEspecialidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1º) Indicar Profesional del turno pactado";
            // 
            // comboProfesional
            // 
            this.comboProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfesional.FormattingEnabled = true;
            this.comboProfesional.Location = new System.Drawing.Point(9, 80);
            this.comboProfesional.Name = "comboProfesional";
            this.comboProfesional.Size = new System.Drawing.Size(156, 21);
            this.comboProfesional.TabIndex = 8;
            this.comboProfesional.SelectedIndexChanged += new System.EventHandler(this.comboProfesional_SelectedIndexChanged);
            // 
            // comboEspecialidad
            // 
            this.comboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEspecialidad.FormattingEnabled = true;
            this.comboEspecialidad.Location = new System.Drawing.Point(9, 33);
            this.comboEspecialidad.Name = "comboEspecialidad";
            this.comboEspecialidad.Size = new System.Drawing.Size(156, 21);
            this.comboEspecialidad.TabIndex = 10;
            this.comboEspecialidad.SelectedIndexChanged += new System.EventHandler(this.comboEspecialidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del Profesional";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Especialidad (puede filtrar)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridTurno);
            this.groupBox2.Location = new System.Drawing.Point(246, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 204);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2º) Seleccionar Afiliado";
            // 
            // dataGridTurno
            // 
            this.dataGridTurno.AllowUserToAddRows = false;
            this.dataGridTurno.AllowUserToDeleteRows = false;
            this.dataGridTurno.AllowUserToResizeColumns = false;
            this.dataGridTurno.AllowUserToResizeRows = false;
            this.dataGridTurno.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurno,
            this.Horario,
            this.nombreAfiliado,
            this.fechaConsulta});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTurno.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTurno.Location = new System.Drawing.Point(6, 19);
            this.dataGridTurno.MultiSelect = false;
            this.dataGridTurno.Name = "dataGridTurno";
            this.dataGridTurno.ReadOnly = true;
            this.dataGridTurno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTurno.ShowEditingIcon = false;
            this.dataGridTurno.Size = new System.Drawing.Size(479, 178);
            this.dataGridTurno.TabIndex = 8;
            // 
            // registrar
            // 
            this.registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.registrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.registrar.Location = new System.Drawing.Point(546, 223);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(185, 33);
            this.registrar.TabIndex = 5;
            this.registrar.Text = "Registrar Llegada";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // idTurno
            // 
            this.idTurno.HeaderText = "Nº Turno";
            this.idTurno.Name = "idTurno";
            this.idTurno.ReadOnly = true;
            this.idTurno.Width = 70;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 90;
            // 
            // nombreAfiliado
            // 
            this.nombreAfiliado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreAfiliado.HeaderText = "Nombre Afiliado";
            this.nombreAfiliado.Name = "nombreAfiliado";
            this.nombreAfiliado.ReadOnly = true;
            // 
            // fechaConsulta
            // 
            this.fechaConsulta.HeaderText = "fechaConsulta";
            this.fechaConsulta.Name = "fechaConsulta";
            this.fechaConsulta.ReadOnly = true;
            this.fechaConsulta.Visible = false;
            // 
            // SubmenuRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 333);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubmenuRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Llegada";
            this.Load += new System.EventHandler(this.SubmenuRegistro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboProfesional;
        private System.Windows.Forms.ComboBox comboEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridTurno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsulta;
    }
}