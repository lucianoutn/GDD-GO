namespace ClinicaFrba.Pedir_Turno
{
    partial class ConfirmacionTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmacionTurno));
            this.l_nombreProfesional = new System.Windows.Forms.Label();
            this.l_especialidad = new System.Windows.Forms.Label();
            this.l_valorDuracion = new System.Windows.Forms.Label();
            this.l_ValorHoras = new System.Windows.Forms.Label();
            this.l_valorDias = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_nombreProfesional
            // 
            this.l_nombreProfesional.AutoSize = true;
            this.l_nombreProfesional.Location = new System.Drawing.Point(13, 43);
            this.l_nombreProfesional.Name = "l_nombreProfesional";
            this.l_nombreProfesional.Size = new System.Drawing.Size(99, 13);
            this.l_nombreProfesional.TabIndex = 0;
            this.l_nombreProfesional.Text = "Nombre Profesional";
            // 
            // l_especialidad
            // 
            this.l_especialidad.AutoSize = true;
            this.l_especialidad.Location = new System.Drawing.Point(13, 75);
            this.l_especialidad.Name = "l_especialidad";
            this.l_especialidad.Size = new System.Drawing.Size(97, 13);
            this.l_especialidad.TabIndex = 1;
            this.l_especialidad.Text = "Especialidad - Tipo";
            // 
            // l_valorDuracion
            // 
            this.l_valorDuracion.AutoSize = true;
            this.l_valorDuracion.Location = new System.Drawing.Point(13, 141);
            this.l_valorDuracion.Name = "l_valorDuracion";
            this.l_valorDuracion.Size = new System.Drawing.Size(77, 13);
            this.l_valorDuracion.TabIndex = 3;
            this.l_valorDuracion.Text = "Valor Duracion";
            // 
            // l_ValorHoras
            // 
            this.l_ValorHoras.AutoSize = true;
            this.l_ValorHoras.Location = new System.Drawing.Point(13, 109);
            this.l_ValorHoras.Name = "l_ValorHoras";
            this.l_ValorHoras.Size = new System.Drawing.Size(62, 13);
            this.l_ValorHoras.TabIndex = 5;
            this.l_ValorHoras.Text = "Valor Horas";
            // 
            // l_valorDias
            // 
            this.l_valorDias.AutoSize = true;
            this.l_valorDias.Location = new System.Drawing.Point(13, 13);
            this.l_valorDias.Name = "l_valorDias";
            this.l_valorDias.Size = new System.Drawing.Size(55, 13);
            this.l_valorDias.TabIndex = 7;
            this.l_valorDias.Text = "Valor Dias";
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(16, 190);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "atras";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.Location = new System.Drawing.Point(136, 190);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 11;
            this.buttonConfirm.Text = "Confirmar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "min";
            // 
            // ConfirmacionTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.l_valorDias);
            this.Controls.Add(this.l_ValorHoras);
            this.Controls.Add(this.l_valorDuracion);
            this.Controls.Add(this.l_especialidad);
            this.Controls.Add(this.l_nombreProfesional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmacionTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmacionAgenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nombreProfesional;
        private System.Windows.Forms.Label l_especialidad;
        private System.Windows.Forms.Label l_valorDuracion;
        private System.Windows.Forms.Label l_ValorHoras;
        private System.Windows.Forms.Label l_valorDias;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label2;
    }
}