namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAtencionSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarAtencionSeleccion));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonPlanMedico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(101, 190);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 0;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonPlanMedico
            // 
            this.buttonPlanMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlanMedico.Location = new System.Drawing.Point(61, 43);
            this.buttonPlanMedico.Name = "buttonPlanMedico";
            this.buttonPlanMedico.Size = new System.Drawing.Size(162, 36);
            this.buttonPlanMedico.TabIndex = 14;
            this.buttonPlanMedico.Text = "Cancelación Médico";
            this.buttonPlanMedico.UseVisualStyleBackColor = true;
            this.buttonPlanMedico.Click += new System.EventHandler(this.buttonPlanMedico_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(61, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelación Afiliado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlanMedico);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CancelarAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelarAtencion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonPlanMedico;
        private System.Windows.Forms.Button button1;


    }
}