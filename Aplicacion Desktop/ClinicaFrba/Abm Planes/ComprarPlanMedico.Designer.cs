namespace ClinicaFrba.Abm_Planes
{
    partial class ComprarPlanMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprarPlanMedico));
            this.buttonComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.dataGridViewPlan = new System.Windows.Forms.DataGridView();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonComprar
            // 
            this.buttonComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComprar.Location = new System.Drawing.Point(212, 261);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 64;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Seleccione un Plan:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(38, 261);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 61;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click_1);
            // 
            // dataGridViewPlan
            // 
            this.dataGridViewPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_plan,
            this.nombre_plan});
            this.dataGridViewPlan.Location = new System.Drawing.Point(143, 47);
            this.dataGridViewPlan.Name = "dataGridViewPlan";
            this.dataGridViewPlan.Size = new System.Drawing.Size(144, 145);
            this.dataGridViewPlan.TabIndex = 65;
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
            // ComprarPlanMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(338, 335);
            this.Controls.Add(this.dataGridViewPlan);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComprarPlanMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Plan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridView dataGridViewPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_plan;

    }
}