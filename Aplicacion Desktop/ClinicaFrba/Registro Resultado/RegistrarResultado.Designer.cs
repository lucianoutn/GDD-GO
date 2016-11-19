namespace ClinicaFrba.Registro_Resultado
{
    partial class RegistrarResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarResultado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSintoma = new System.Windows.Forms.TextBox();
            this.textBoxDiagnostico = new System.Windows.Forms.TextBox();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_cerrarConsulta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAfiliado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Síntomas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagnóstico:";
            // 
            // textBoxSintoma
            // 
            this.textBoxSintoma.Location = new System.Drawing.Point(87, 43);
            this.textBoxSintoma.Name = "textBoxSintoma";
            this.textBoxSintoma.Size = new System.Drawing.Size(144, 20);
            this.textBoxSintoma.TabIndex = 2;
            this.textBoxSintoma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSintoma_KeyPress);
            // 
            // textBoxDiagnostico
            // 
            this.textBoxDiagnostico.Location = new System.Drawing.Point(87, 83);
            this.textBoxDiagnostico.Name = "textBoxDiagnostico";
            this.textBoxDiagnostico.Size = new System.Drawing.Size(144, 20);
            this.textBoxDiagnostico.TabIndex = 3;
            this.textBoxDiagnostico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiagnostico_KeyPress);
            // 
            // button_Volver
            // 
            this.button_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Volver.ForeColor = System.Drawing.Color.Maroon;
            this.button_Volver.Location = new System.Drawing.Point(16, 153);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 5;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_cerrarConsulta
            // 
            this.button_cerrarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cerrarConsulta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_cerrarConsulta.Location = new System.Drawing.Point(231, 153);
            this.button_cerrarConsulta.Name = "button_cerrarConsulta";
            this.button_cerrarConsulta.Size = new System.Drawing.Size(98, 23);
            this.button_cerrarConsulta.TabIndex = 6;
            this.button_cerrarConsulta.Text = "Cerrar consulta";
            this.button_cerrarConsulta.UseVisualStyleBackColor = true;
            this.button_cerrarConsulta.Click += new System.EventHandler(this.button_cerrarConsulta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Afiliado: ";
            // 
            // labelAfiliado
            // 
            this.labelAfiliado.AutoSize = true;
            this.labelAfiliado.Location = new System.Drawing.Point(87, 12);
            this.labelAfiliado.Name = "labelAfiliado";
            this.labelAfiliado.Size = new System.Drawing.Size(53, 13);
            this.labelAfiliado.TabIndex = 8;
            this.labelAfiliado.Text = "unAfiliado";
            // 
            // RegistrarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 196);
            this.Controls.Add(this.labelAfiliado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_cerrarConsulta);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.textBoxDiagnostico);
            this.Controls.Add(this.textBoxSintoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSintoma;
        private System.Windows.Forms.TextBox textBoxDiagnostico;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_cerrarConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAfiliado;
    }
}