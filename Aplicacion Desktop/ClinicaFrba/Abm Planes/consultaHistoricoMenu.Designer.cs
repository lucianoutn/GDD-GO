namespace ClinicaFrba.Abm_Planes
{
    partial class consultaHistoricoMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaHistoricoMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdAfiliado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.consultarHistorico = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.desc_fecha_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_plan_medico_anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIdAfiliado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Ingresar Id de Afiliado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Id Afiliado:";
            // 
            // textBoxIdAfiliado
            // 
            this.textBoxIdAfiliado.Location = new System.Drawing.Point(68, 27);
            this.textBoxIdAfiliado.Name = "textBoxIdAfiliado";
            this.textBoxIdAfiliado.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdAfiliado.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ClinicaFrba.Properties.Resources.historial;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // consultarHistorico
            // 
            this.consultarHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.consultarHistorico.ForeColor = System.Drawing.Color.DodgerBlue;
            this.consultarHistorico.Location = new System.Drawing.Point(6, 14);
            this.consultarHistorico.Name = "consultarHistorico";
            this.consultarHistorico.Size = new System.Drawing.Size(140, 29);
            this.consultarHistorico.TabIndex = 9;
            this.consultarHistorico.Text = "Consultar Histórico";
            this.consultarHistorico.UseVisualStyleBackColor = true;
            this.consultarHistorico.Click += new System.EventHandler(this.consultarHistorico_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(475, 232);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 58;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridHistorial);
            this.groupBox2.Controls.Add(this.consultarHistorico);
            this.groupBox2.Location = new System.Drawing.Point(204, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 214);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2)";
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.AllowUserToAddRows = false;
            this.dataGridHistorial.AllowUserToDeleteRows = false;
            this.dataGridHistorial.AllowUserToResizeColumns = false;
            this.dataGridHistorial.AllowUserToResizeRows = false;
            this.dataGridHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desc_fecha_modificacion,
            this.desc_motivo,
            this.id_plan_medico_anterior});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridHistorial.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHistorial.Location = new System.Drawing.Point(6, 49);
            this.dataGridHistorial.MultiSelect = false;
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.ReadOnly = true;
            this.dataGridHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHistorial.ShowEditingIcon = false;
            this.dataGridHistorial.Size = new System.Drawing.Size(334, 159);
            this.dataGridHistorial.TabIndex = 10;
            // 
            // desc_fecha_modificacion
            // 
            this.desc_fecha_modificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc_fecha_modificacion.HeaderText = "Fecha de Modificacion";
            this.desc_fecha_modificacion.Name = "desc_fecha_modificacion";
            this.desc_fecha_modificacion.ReadOnly = true;
            // 
            // desc_motivo
            // 
            this.desc_motivo.HeaderText = "Motivo";
            this.desc_motivo.Name = "desc_motivo";
            this.desc_motivo.ReadOnly = true;
            this.desc_motivo.Width = 160;
            // 
            // id_plan_medico_anterior
            // 
            this.id_plan_medico_anterior.HeaderText = "Plan anterior";
            this.id_plan_medico_anterior.Name = "id_plan_medico_anterior";
            this.id_plan_medico_anterior.ReadOnly = true;
            this.id_plan_medico_anterior.Width = 50;
            // 
            // consultaHistoricoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(562, 267);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultaHistoricoMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de cambios de planes médicos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdAfiliado;
        private System.Windows.Forms.Button consultarHistorico;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_fecha_modificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan_medico_anterior;
    }
}