namespace ClinicaFrba.Abm_Afiliado
{
    partial class SubMenuAfiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuAfiliado));
            this.buttonAltaAfiliado = new System.Windows.Forms.Button();
            this.buttonBajaAfiliado = new System.Windows.Forms.Button();
            this.buttonModificarAfiliado = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAltaAfiliado
            // 
            this.buttonAltaAfiliado.Location = new System.Drawing.Point(76, 12);
            this.buttonAltaAfiliado.Name = "buttonAltaAfiliado";
            this.buttonAltaAfiliado.Size = new System.Drawing.Size(121, 48);
            this.buttonAltaAfiliado.TabIndex = 0;
            this.buttonAltaAfiliado.Text = "Alta Afiliado";
            this.buttonAltaAfiliado.UseVisualStyleBackColor = true;
            this.buttonAltaAfiliado.Click += new System.EventHandler(this.buttonAltaAfiliado_Click);
            // 
            // buttonBajaAfiliado
            // 
            this.buttonBajaAfiliado.Location = new System.Drawing.Point(76, 80);
            this.buttonBajaAfiliado.Name = "buttonBajaAfiliado";
            this.buttonBajaAfiliado.Size = new System.Drawing.Size(121, 49);
            this.buttonBajaAfiliado.TabIndex = 1;
            this.buttonBajaAfiliado.Text = "Baja Afiliado";
            this.buttonBajaAfiliado.UseVisualStyleBackColor = true;
            this.buttonBajaAfiliado.Click += new System.EventHandler(this.buttonBajaAfiliado_Click);
            // 
            // buttonModificarAfiliado
            // 
            this.buttonModificarAfiliado.Location = new System.Drawing.Point(76, 150);
            this.buttonModificarAfiliado.Name = "buttonModificarAfiliado";
            this.buttonModificarAfiliado.Size = new System.Drawing.Size(121, 57);
            this.buttonModificarAfiliado.TabIndex = 2;
            this.buttonModificarAfiliado.Text = "Modificar Afiliado";
            this.buttonModificarAfiliado.UseVisualStyleBackColor = true;
            this.buttonModificarAfiliado.Click += new System.EventHandler(this.buttonModificarAfiliado_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(97, 226);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // SubMenuAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonModificarAfiliado);
            this.Controls.Add(this.buttonBajaAfiliado);
            this.Controls.Add(this.buttonAltaAfiliado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubMenuAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Afiliados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAltaAfiliado;
        private System.Windows.Forms.Button buttonBajaAfiliado;
        private System.Windows.Forms.Button buttonModificarAfiliado;
        private System.Windows.Forms.Button buttonVolver;
    }
}