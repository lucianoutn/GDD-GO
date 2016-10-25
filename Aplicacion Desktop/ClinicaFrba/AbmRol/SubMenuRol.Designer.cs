namespace ClinicaFrba.AbmRol
{
    partial class SubMenuRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuRol));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Baja = new System.Windows.Forms.Button();
            this.Listar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(100, 232);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(47, 129);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 5;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.buttonAltaRol_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(47, 187);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 6;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.buttonModificarRol_Click);
            // 
            // Baja
            // 
            this.Baja.Location = new System.Drawing.Point(47, 158);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(75, 23);
            this.Baja.TabIndex = 7;
            this.Baja.Text = "Baja";
            this.Baja.UseVisualStyleBackColor = true;
            this.Baja.Click += new System.EventHandler(this.buttonBajaRol_Click);
            // 
            // Listar
            // 
            this.Listar.Location = new System.Drawing.Point(47, 100);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(75, 23);
            this.Listar.TabIndex = 8;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.buttonListarRol_Click);
            // 
            // SubMenuRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.coach_with_clipboard_400_clr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.buttonVolver);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubMenuRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Baja;
        private System.Windows.Forms.Button Listar;
    }
}