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
            this.comboBoxPlanes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonComprar
            // 
            this.buttonComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComprar.Location = new System.Drawing.Point(172, 171);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 64;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // comboBoxPlanes
            // 
            this.comboBoxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlanes.FormattingEnabled = true;
            this.comboBoxPlanes.Location = new System.Drawing.Point(147, 44);
            this.comboBoxPlanes.Name = "comboBoxPlanes";
            this.comboBoxPlanes.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPlanes.TabIndex = 63;
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
            this.buttonVolver.Location = new System.Drawing.Point(38, 171);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 61;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click_1);
            // 
            // ComprarPlanMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 239);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.comboBoxPlanes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComprarPlanMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.ComboBox comboBoxPlanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;

    }
}