namespace ClinicaFrba.Listados
{
    partial class TopBonosComprados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopBonosComprados));
            this.dataGridViewBonosComprados = new System.Windows.Forms.DataGridView();
            this.Col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_GrupoFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_volver = new System.Windows.Forms.Button();
            this.labeTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonosComprados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBonosComprados
            // 
            this.dataGridViewBonosComprados.AllowUserToAddRows = false;
            this.dataGridViewBonosComprados.AllowUserToDeleteRows = false;
            this.dataGridViewBonosComprados.AllowUserToResizeColumns = false;
            this.dataGridViewBonosComprados.AllowUserToResizeRows = false;
            this.dataGridViewBonosComprados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewBonosComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBonosComprados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_nro,
            this.Col_ape,
            this.Col_nombre,
            this.Col_cant,
            this.Col_GrupoFam});
            this.dataGridViewBonosComprados.Location = new System.Drawing.Point(40, 43);
            this.dataGridViewBonosComprados.MultiSelect = false;
            this.dataGridViewBonosComprados.Name = "dataGridViewBonosComprados";
            this.dataGridViewBonosComprados.ReadOnly = true;
            this.dataGridViewBonosComprados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewBonosComprados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBonosComprados.ShowEditingIcon = false;
            this.dataGridViewBonosComprados.Size = new System.Drawing.Size(541, 169);
            this.dataGridViewBonosComprados.TabIndex = 5;
            // 
            // Col_nro
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Col_nro.DefaultCellStyle = dataGridViewCellStyle1;
            this.Col_nro.HeaderText = "Orden";
            this.Col_nro.Name = "Col_nro";
            this.Col_nro.ReadOnly = true;
            // 
            // Col_ape
            // 
            this.Col_ape.HeaderText = "Apellido";
            this.Col_ape.Name = "Col_ape";
            this.Col_ape.ReadOnly = true;
            // 
            // Col_nombre
            // 
            this.Col_nombre.HeaderText = "Nombre";
            this.Col_nombre.Name = "Col_nombre";
            this.Col_nombre.ReadOnly = true;
            // 
            // Col_cant
            // 
            this.Col_cant.HeaderText = "Cantidad";
            this.Col_cant.Name = "Col_cant";
            this.Col_cant.ReadOnly = true;
            // 
            // Col_GrupoFam
            // 
            this.Col_GrupoFam.HeaderText = "Grupo Familiar";
            this.Col_GrupoFam.Name = "Col_GrupoFam";
            this.Col_GrupoFam.ReadOnly = true;
            // 
            // button_volver
            // 
            this.button_volver.ForeColor = System.Drawing.Color.DarkRed;
            this.button_volver.Location = new System.Drawing.Point(506, 226);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 1;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // labeTop
            // 
            this.labeTop.AutoSize = true;
            this.labeTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTop.Location = new System.Drawing.Point(55, 18);
            this.labeTop.Name = "labeTop";
            this.labeTop.Size = new System.Drawing.Size(40, 16);
            this.labeTop.TabIndex = 2;
            this.labeTop.Text = "Top:";
            // 
            // TopBonosComprados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.estadistica;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.labeTop);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.dataGridViewBonosComprados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopBonosComprados";
            this.Text = "TopBonosComprados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonosComprados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBonosComprados;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label labeTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_GrupoFam;
    }
}