namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class VistaCalendario
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
            this.UserName = new System.Windows.Forms.Label();
            this.comboBoxEsp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(13, 9);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(65, 19);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Usuario";
            // 
            // comboBoxEsp
            // 
            this.comboBoxEsp.FormattingEnabled = true;
            this.comboBoxEsp.Location = new System.Drawing.Point(136, 34);
            this.comboBoxEsp.Name = "comboBoxEsp";
            this.comboBoxEsp.Size = new System.Drawing.Size(252, 27);
            this.comboBoxEsp.TabIndex = 1;
            this.comboBoxEsp.Text = "Especialidades";
            // 
            // VistaCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 381);
            this.Controls.Add(this.comboBoxEsp);
            this.Controls.Add(this.UserName);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VistaCalendario";
            this.Text = "VistaCalendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.ComboBox comboBoxEsp;

    }
}