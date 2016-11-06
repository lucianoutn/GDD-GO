namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class CalendarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarAdmin));
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.buttonConfirm1 = new System.Windows.Forms.Button();
            this.comboBoxProff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBack1
            // 
            this.buttonBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack1.Location = new System.Drawing.Point(29, 132);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(75, 32);
            this.buttonBack1.TabIndex = 3;
            this.buttonBack1.Text = "atras";
            this.buttonBack1.UseVisualStyleBackColor = true;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_Click);
            // 
            // buttonConfirm1
            // 
            this.buttonConfirm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm1.Location = new System.Drawing.Point(193, 133);
            this.buttonConfirm1.Name = "buttonConfirm1";
            this.buttonConfirm1.Size = new System.Drawing.Size(75, 31);
            this.buttonConfirm1.TabIndex = 4;
            this.buttonConfirm1.Text = "Listo";
            this.buttonConfirm1.UseVisualStyleBackColor = true;
            this.buttonConfirm1.Click += new System.EventHandler(this.buttonConfirm1_Click);
            // 
            // comboBoxProff
            // 
            this.comboBoxProff.FormattingEnabled = true;
            this.comboBoxProff.Location = new System.Drawing.Point(29, 36);
            this.comboBoxProff.Name = "comboBoxProff";
            this.comboBoxProff.Size = new System.Drawing.Size(239, 27);
            this.comboBoxProff.TabIndex = 5;
            this.comboBoxProff.Text = "Profesionales";
            this.comboBoxProff.SelectedIndexChanged += new System.EventHandler(this.comboBoxProff_SelectedIndexChanged);
            // 
            // CalendarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 185);
            this.Controls.Add(this.comboBoxProff);
            this.Controls.Add(this.buttonConfirm1);
            this.Controls.Add(this.buttonBack1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalendarAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaCalendario";
            this.ResumeLayout(false);

        }


        private void comboBoxEsp_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonBack1;
        private System.Windows.Forms.Button buttonConfirm1;
        private System.Windows.Forms.ComboBox comboBoxProff;


        public System.EventHandler comboBoxEsp1_SelectedIndexChanged { get; set; }
    }
}