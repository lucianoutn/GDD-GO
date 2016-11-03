namespace ClinicaFrba.Registro_Resultado
{
    partial class VerificarAtencion
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
            this.textBoxAfiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.button_abrirCosulta = new System.Windows.Forms.Button();
            this.button_Volver = new System.Windows.Forms.Button();
            this.dateTimePickerAtMed = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxAfiliado
            // 
            this.textBoxAfiliado.Location = new System.Drawing.Point(79, 16);
            this.textBoxAfiliado.Name = "textBoxAfiliado";
            this.textBoxAfiliado.Size = new System.Drawing.Size(208, 20);
            this.textBoxAfiliado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Afiliado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora:";
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(75, 95);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(100, 20);
            this.textBoxHora.TabIndex = 5;
            // 
            // button_abrirCosulta
            // 
            this.button_abrirCosulta.ForeColor = System.Drawing.Color.DarkRed;
            this.button_abrirCosulta.Location = new System.Drawing.Point(178, 151);
            this.button_abrirCosulta.Name = "button_abrirCosulta";
            this.button_abrirCosulta.Size = new System.Drawing.Size(109, 23);
            this.button_abrirCosulta.TabIndex = 10;
            this.button_abrirCosulta.Text = "Abrir Consulta";
            this.button_abrirCosulta.UseVisualStyleBackColor = true;
            this.button_abrirCosulta.Click += new System.EventHandler(this.button_abrirCosulta_Click);
            // 
            // button_Volver
            // 
            this.button_Volver.Location = new System.Drawing.Point(15, 151);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(75, 23);
            this.button_Volver.TabIndex = 11;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // dateTimePickerAtMed
            // 
            this.dateTimePickerAtMed.Location = new System.Drawing.Point(75, 54);
            this.dateTimePickerAtMed.Name = "dateTimePickerAtMed";
            this.dateTimePickerAtMed.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerAtMed.TabIndex = 108;
            // 
            // VerificarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 204);
            this.Controls.Add(this.dateTimePickerAtMed);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_abrirCosulta);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAfiliado);
            this.Name = "VerificarAtencion";
            this.Text = "Resultado de Atención Médica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAfiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.Button button_abrirCosulta;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.DateTimePicker dateTimePickerAtMed;
    }
}