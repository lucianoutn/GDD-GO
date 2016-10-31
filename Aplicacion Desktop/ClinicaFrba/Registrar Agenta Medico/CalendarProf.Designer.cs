namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class CalendarProf
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxEsp = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.dateTimePickerIni = new System.Windows.Forms.DateTimePicker();
            this.textBoxMi = new System.Windows.Forms.TextBox();
            this.textBoxHf = new System.Windows.Forms.TextBox();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.textBoxHi = new System.Windows.Forms.TextBox();
            this.textBoxMf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTurno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorDateIni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDateFin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHorarioIni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHorarioFin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDuracion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorDateIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDateFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorarioIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorarioFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEsp
            // 
            this.comboBoxEsp.FormattingEnabled = true;
            this.comboBoxEsp.Location = new System.Drawing.Point(38, 42);
            this.comboBoxEsp.Name = "comboBoxEsp";
            this.comboBoxEsp.Size = new System.Drawing.Size(296, 27);
            this.comboBoxEsp.TabIndex = 1;
            this.comboBoxEsp.Text = "Especialidades";
            this.comboBoxEsp.SelectedIndexChanged += new System.EventHandler(this.comboBoxEsp_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(34, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "labelProf";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 339);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 32);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "atras";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(282, 339);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 31);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Listo";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // dateTimePickerIni
            // 
            this.dateTimePickerIni.Location = new System.Drawing.Point(157, 89);
            this.dateTimePickerIni.Name = "dateTimePickerIni";
            this.dateTimePickerIni.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerIni.TabIndex = 5;
            this.dateTimePickerIni.ValueChanged += new System.EventHandler(this.dateTimePickerIni_ValueChanged);
            // 
            // textBoxMi
            // 
            this.textBoxMi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMi.Location = new System.Drawing.Point(92, 201);
            this.textBoxMi.Name = "textBoxMi";
            this.textBoxMi.Size = new System.Drawing.Size(54, 26);
            this.textBoxMi.TabIndex = 6;
            this.textBoxMi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHf
            // 
            this.textBoxHf.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHf.Location = new System.Drawing.Point(13, 268);
            this.textBoxHf.Name = "textBoxHf";
            this.textBoxHf.Size = new System.Drawing.Size(54, 26);
            this.textBoxHf.TabIndex = 7;
            this.textBoxHf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(157, 142);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFin.TabIndex = 8;
            // 
            // textBoxHi
            // 
            this.textBoxHi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHi.Location = new System.Drawing.Point(13, 201);
            this.textBoxHi.Name = "textBoxHi";
            this.textBoxHi.Size = new System.Drawing.Size(54, 26);
            this.textBoxHi.TabIndex = 9;
            this.textBoxHi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMf
            // 
            this.textBoxMf.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMf.Location = new System.Drawing.Point(92, 268);
            this.textBoxMf.Name = "textBoxMf";
            this.textBoxMf.Size = new System.Drawing.Size(54, 26);
            this.textBoxMf.TabIndex = 10;
            this.textBoxMf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(68, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(69, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(148, 339);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 32);
            this.buttonCheck.TabIndex = 13;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "FECHA INICIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "FECHA FIN:";
            // 
            // textBoxTurno
            // 
            this.textBoxTurno.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTurno.Location = new System.Drawing.Point(214, 239);
            this.textBoxTurno.Name = "textBoxTurno";
            this.textBoxTurno.Size = new System.Drawing.Size(70, 26);
            this.textBoxTurno.TabIndex = 16;
            this.textBoxTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "INICIO JORNADA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "FIN JORNADA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(198, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "DURACION TURNO";
            // 
            // errorDateIni
            // 
            this.errorDateIni.ContainerControl = this;
            this.errorDateIni.Tag = "";
            // 
            // errorDateFin
            // 
            this.errorDateFin.ContainerControl = this;
            // 
            // errorHorarioIni
            // 
            this.errorHorarioIni.ContainerControl = this;
            // 
            // errorHorarioFin
            // 
            this.errorHorarioFin.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorDuracion
            // 
            this.errorDuracion.ContainerControl = this;
            // 
            // CalendarProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 383);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMf);
            this.Controls.Add(this.textBoxHi);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.textBoxHf);
            this.Controls.Add(this.textBoxMi);
            this.Controls.Add(this.dateTimePickerIni);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxEsp);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalendarProf";
            this.Text = "VistaCalendario";
            ((System.ComponentModel.ISupportInitialize)(this.errorDateIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDateFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorarioIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorarioFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDuracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox comboBoxEsp;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.DateTimePicker dateTimePickerIni;
        private System.Windows.Forms.TextBox textBoxMi;
        private System.Windows.Forms.TextBox textBoxHf;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.TextBox textBoxHi;
        private System.Windows.Forms.TextBox textBoxMf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorDateIni;
        private System.Windows.Forms.ErrorProvider errorDateFin;
        private System.Windows.Forms.ErrorProvider errorHorarioIni;
        private System.Windows.Forms.ErrorProvider errorHorarioFin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorDuracion;

    }
}