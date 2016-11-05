namespace ClinicaFrba.Pedir_Turno
{
    partial class SeleccionAfiliado
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.comboBoxAf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBack1
            // 
            this.buttonBack.Location = new System.Drawing.Point(29, 132);
            this.buttonBack.Name = "buttonBack1";
            this.buttonBack.Size = new System.Drawing.Size(75, 32);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "atras";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm1
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(193, 133);
            this.buttonConfirm.Name = "buttonConfirm1";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 31);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Listo";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // comboBoxProff
            // 
            this.comboBoxAf.FormattingEnabled = true;
            this.comboBoxAf.Location = new System.Drawing.Point(29, 36);
            this.comboBoxAf.Name = "comboBoxProff";
            this.comboBoxAf.Size = new System.Drawing.Size(239, 27);
            this.comboBoxAf.TabIndex = 5;
            this.comboBoxAf.Text = "Profesionales";
            this.comboBoxAf.SelectedIndexChanged += new System.EventHandler(this.comboBoxAf_SelectedIndexChanged);
            // 
            // CalendarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 185);
            this.Controls.Add(this.comboBoxAf);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalendarAdmin";
            this.Text = "VistaCalendario";
            this.ResumeLayout(false);

        }


        private void comboBoxEsp_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ComboBox comboBoxAf;


        public System.EventHandler comboBoxEsp1_SelectedIndexChanged { get; set; }
    }
}