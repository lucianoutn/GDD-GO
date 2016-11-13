namespace ClinicaFrba.Abm_Planes
{
    partial class CambiarPlanMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarPlanMedico));
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.dataGridViewPlan = new System.Windows.Forms.DataGridView();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCambiar.Location = new System.Drawing.Point(209, 300);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(75, 23);
            this.buttonCambiar.TabIndex = 58;
            this.buttonCambiar.Text = "Cambiar";
            this.buttonCambiar.UseVisualStyleBackColor = true;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Seleccione un Plan:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(35, 300);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 55;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Motivo Del Cambio:";
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(140, 233);
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(144, 20);
            this.textBoxMotivo.TabIndex = 60;
            // 
            // dataGridViewPlan
            // 
            this.dataGridViewPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_plan,
            this.nombre_plan});
            this.dataGridViewPlan.Location = new System.Drawing.Point(140, 70);
            this.dataGridViewPlan.Name = "dataGridViewPlan";
            this.dataGridViewPlan.Size = new System.Drawing.Size(144, 145);
            this.dataGridViewPlan.TabIndex = 61;
            // 
            // id_plan
            // 
            this.id_plan.HeaderText = "ID";
            this.id_plan.Name = "id_plan";
            this.id_plan.Visible = false;
            // 
            // nombre_plan
            // 
            this.nombre_plan.HeaderText = "Nombre Plan";
            this.nombre_plan.Name = "nombre_plan";
            // 
            // CambiarPlanMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 391);
            this.Controls.Add(this.dataGridViewPlan);
            this.Controls.Add(this.textBoxMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCambiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiarPlanMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Plan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCambiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.DataGridView dataGridViewPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_plan;
    }
}