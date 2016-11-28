namespace ClinicaFrba.Listados
{
    partial class TopEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopEspecialidades));
            this.dataGridViewEspecialidades = new System.Windows.Forms.DataGridView();
            this.Col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_volver = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEspecialidades
            // 
            this.dataGridViewEspecialidades.AllowUserToAddRows = false;
            this.dataGridViewEspecialidades.AllowUserToDeleteRows = false;
            this.dataGridViewEspecialidades.AllowUserToResizeColumns = false;
            this.dataGridViewEspecialidades.AllowUserToResizeRows = false;
            this.dataGridViewEspecialidades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_nro,
            this.Col_esp,
            this.Col_cant});
            this.dataGridViewEspecialidades.Location = new System.Drawing.Point(42, 42);
            this.dataGridViewEspecialidades.MultiSelect = false;
            this.dataGridViewEspecialidades.Name = "dataGridViewEspecialidades";
            this.dataGridViewEspecialidades.ReadOnly = true;
            this.dataGridViewEspecialidades.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEspecialidades.ShowEditingIcon = false;
            this.dataGridViewEspecialidades.Size = new System.Drawing.Size(340, 147);
            this.dataGridViewEspecialidades.TabIndex = 5;
            // 
            // Col_nro
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Col_nro.DefaultCellStyle = dataGridViewCellStyle1;
            this.Col_nro.HeaderText = "Orden";
            this.Col_nro.Name = "Col_nro";
            this.Col_nro.ReadOnly = true;
            // 
            // Col_esp
            // 
            this.Col_esp.HeaderText = "Especialidad";
            this.Col_esp.Name = "Col_esp";
            this.Col_esp.ReadOnly = true;
            // 
            // Col_cant
            // 
            this.Col_cant.HeaderText = "Cantidad";
            this.Col_cant.Name = "Col_cant";
            this.Col_cant.ReadOnly = true;
            // 
            // button_volver
            // 
            this.button_volver.ForeColor = System.Drawing.Color.DarkRed;
            this.button_volver.Location = new System.Drawing.Point(307, 213);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 1;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(42, 23);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(40, 16);
            this.labelTop.TabIndex = 2;
            this.labelTop.Text = "Top:";
            // 
            // TopEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.estadistica;
            this.ClientSize = new System.Drawing.Size(425, 250);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.dataGridViewEspecialidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopEspecialidades";
            this.Text = "TopEspecialidades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEspecialidades;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_esp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_cant;
    }
}