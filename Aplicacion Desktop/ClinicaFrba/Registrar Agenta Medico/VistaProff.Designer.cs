namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class VistaProff
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
            this.comboBoxProff = new System.Windows.Forms.ComboBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxProff
            // 
            this.comboBoxProff.FormattingEnabled = true;
            this.comboBoxProff.Location = new System.Drawing.Point(62, 48);
            this.comboBoxProff.Name = "comboBoxProff";
            this.comboBoxProff.Size = new System.Drawing.Size(170, 21);
            this.comboBoxProff.TabIndex = 0;
            this.comboBoxProff.Text = "Profesionales";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(156, 130);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // VistaProff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.comboBoxProff);
            this.Name = "VistaProff";
            this.Text = "VistaProff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProff;
        private System.Windows.Forms.Button buttonNext;
    }
}