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
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTurno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorDateIni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDateFin = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxL = new System.Windows.Forms.CheckBox();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.checkBoxJ = new System.Windows.Forms.CheckBox();
            this.checkBoxV = new System.Windows.Forms.CheckBox();
            this.checkBoxS = new System.Windows.Forms.CheckBox();
            this.errorDuracion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDias = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEsp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorDateIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDateFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEsp)).BeginInit();
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
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(157, 142);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFin.TabIndex = 8;
            this.dateTimePickerFin.ValueChanged += new System.EventHandler(this.dateTimePickerFin_ValueChanged);
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
            this.textBoxTurno.Location = new System.Drawing.Point(148, 307);
            this.textBoxTurno.Name = "textBoxTurno";
            this.textBoxTurno.Size = new System.Drawing.Size(75, 26);
            this.textBoxTurno.TabIndex = 16;
            this.textBoxTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Marcar dias que Asistirá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(118, 288);
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
            // checkBoxL
            // 
            this.checkBoxL.AutoSize = true;
            this.checkBoxL.Location = new System.Drawing.Point(20, 231);
            this.checkBoxL.Name = "checkBoxL";
            this.checkBoxL.Size = new System.Drawing.Size(37, 23);
            this.checkBoxL.TabIndex = 20;
            this.checkBoxL.Text = "L";
            this.checkBoxL.UseVisualStyleBackColor = true;
            this.checkBoxL.CheckedChanged += new System.EventHandler(this.checkBoxL_CheckedChanged);
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Location = new System.Drawing.Point(77, 231);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(42, 23);
            this.checkBoxM.TabIndex = 21;
            this.checkBoxM.Text = "M";
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Location = new System.Drawing.Point(144, 231);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(39, 23);
            this.checkBoxX.TabIndex = 22;
            this.checkBoxX.Text = "X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            this.checkBoxX.CheckedChanged += new System.EventHandler(this.checkBoxX_CheckedChanged);
            // 
            // checkBoxJ
            // 
            this.checkBoxJ.AutoSize = true;
            this.checkBoxJ.Location = new System.Drawing.Point(202, 231);
            this.checkBoxJ.Name = "checkBoxJ";
            this.checkBoxJ.Size = new System.Drawing.Size(36, 23);
            this.checkBoxJ.TabIndex = 23;
            this.checkBoxJ.Text = "J";
            this.checkBoxJ.UseVisualStyleBackColor = true;
            this.checkBoxJ.CheckedChanged += new System.EventHandler(this.checkBoxJ_CheckedChanged);
            // 
            // checkBoxV
            // 
            this.checkBoxV.AutoSize = true;
            this.checkBoxV.Location = new System.Drawing.Point(257, 231);
            this.checkBoxV.Name = "checkBoxV";
            this.checkBoxV.Size = new System.Drawing.Size(39, 23);
            this.checkBoxV.TabIndex = 24;
            this.checkBoxV.Text = "V";
            this.checkBoxV.UseVisualStyleBackColor = true;
            this.checkBoxV.CheckedChanged += new System.EventHandler(this.checkBoxV_CheckedChanged);
            // 
            // checkBoxS
            // 
            this.checkBoxS.AutoSize = true;
            this.checkBoxS.Location = new System.Drawing.Point(318, 231);
            this.checkBoxS.Name = "checkBoxS";
            this.checkBoxS.Size = new System.Drawing.Size(39, 23);
            this.checkBoxS.TabIndex = 25;
            this.checkBoxS.Text = "S";
            this.checkBoxS.UseVisualStyleBackColor = true;
            this.checkBoxS.CheckedChanged += new System.EventHandler(this.checkBoxS_CheckedChanged);
            // 
            // errorDuracion
            // 
            this.errorDuracion.ContainerControl = this;
            // 
            // errorDias
            // 
            this.errorDias.ContainerControl = this;
            // 
            // errorEsp
            // 
            this.errorEsp.ContainerControl = this;
            // 
            // CalendarProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 383);
            this.Controls.Add(this.checkBoxS);
            this.Controls.Add(this.checkBoxV);
            this.Controls.Add(this.checkBoxJ);
            this.Controls.Add(this.checkBoxX);
            this.Controls.Add(this.checkBoxM);
            this.Controls.Add(this.checkBoxL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.dateTimePickerFin);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox comboBoxEsp;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.DateTimePicker dateTimePickerIni;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorDateIni;
        private System.Windows.Forms.ErrorProvider errorDateFin;
        private System.Windows.Forms.CheckBox checkBoxS;
        private System.Windows.Forms.CheckBox checkBoxV;
        private System.Windows.Forms.CheckBox checkBoxJ;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.CheckBox checkBoxL;
        private System.Windows.Forms.ErrorProvider errorDuracion;
        private System.Windows.Forms.ErrorProvider errorDias;
        private System.Windows.Forms.ErrorProvider errorEsp;

    }
}