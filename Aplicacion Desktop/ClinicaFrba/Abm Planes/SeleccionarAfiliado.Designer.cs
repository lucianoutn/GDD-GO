namespace ClinicaFrba.Abm_Planes
{
    partial class SeleccionarAfiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarAfiliado));
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdAfiliado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Location = new System.Drawing.Point(190, 173);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 58;
            this.buttonEliminar.Text = "Seleccionar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(24, 173);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 57;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Id Afiliado:";
            // 
            // textBoxIdAfiliado
            // 
            this.textBoxIdAfiliado.Location = new System.Drawing.Point(83, 52);
            this.textBoxIdAfiliado.Name = "textBoxIdAfiliado";
            this.textBoxIdAfiliado.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdAfiliado.TabIndex = 59;
            // 
            // CambiarPlanMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdAfiliado);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiarPlanMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdAfiliado;
    }
}