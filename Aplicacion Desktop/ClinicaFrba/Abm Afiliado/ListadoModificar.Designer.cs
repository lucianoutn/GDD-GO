namespace ClinicaFrba.Abm_Afiliado
{
    partial class ListadoModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoModificar));
            this.button_volver = new System.Windows.Forms.Button();
            this.presentacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.comboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.comboDominio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_volver.ForeColor = System.Drawing.Color.Maroon;
            this.button_volver.Location = new System.Drawing.Point(25, 396);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 25;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.ForeColor = System.Drawing.Color.Black;
            this.presentacion.Location = new System.Drawing.Point(123, 20);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(143, 23);
            this.presentacion.TabIndex = 23;
            this.presentacion.Text = "Ingreso de datos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboDominio);
            this.groupBox1.Controls.Add(this.comboEstadoCivil);
            this.groupBox1.Controls.Add(this.radioButtonFemenino);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(25, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 318);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de datos nuevos";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(143, 219);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 17;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Telefono_Key_Press);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(73, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(63, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado Civil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(95, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sexo:";
            // 
            // Limpiar
            // 
            this.Limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Limpiar.Location = new System.Drawing.Point(28, 282);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 9;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(141, 77);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 8;
            // 
            // Guardar
            // 
            this.Guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Guardar.Location = new System.Drawing.Point(213, 282);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(94, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail :";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(141, 35);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(71, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion:";
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButtonFemenino.Location = new System.Drawing.Point(143, 142);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemenino.TabIndex = 115;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonMasculino.Location = new System.Drawing.Point(143, 119);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 114;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // comboEstadoCivil
            // 
            this.comboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstadoCivil.FormattingEnabled = true;
            this.comboEstadoCivil.Location = new System.Drawing.Point(143, 180);
            this.comboEstadoCivil.Name = "comboEstadoCivil";
            this.comboEstadoCivil.Size = new System.Drawing.Size(90, 21);
            this.comboEstadoCivil.TabIndex = 116;
            // 
            // comboDominio
            // 
            this.comboDominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDominio.FormattingEnabled = true;
            this.comboDominio.Location = new System.Drawing.Point(268, 76);
            this.comboDominio.Name = "comboDominio";
            this.comboDominio.Size = new System.Drawing.Size(90, 21);
            this.comboDominio.TabIndex = 117;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(244, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 118;
            this.label9.Text = "@";
            // 
            // ListadoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(452, 448);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.presentacion);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoModificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label presentacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.ComboBox comboEstadoCivil;
        private System.Windows.Forms.ComboBox comboDominio;
        private System.Windows.Forms.Label label9;

    }
}