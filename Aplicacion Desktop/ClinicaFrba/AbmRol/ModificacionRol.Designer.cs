﻿namespace ClinicaFrba.AbmRol
{
    partial class ModificacionRol

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionRol));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboModRol = new System.Windows.Forms.ComboBox();
            this.modificar = new System.Windows.Forms.Button();
            this.reactivar = new System.Windows.Forms.Button();
            this.checkedListFunciones = new System.Windows.Forms.CheckedListBox();
            this.cambiarFunciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(106, 232);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cambiarFunciones);
            this.groupBox1.Controls.Add(this.checkedListFunciones);
            this.groupBox1.Controls.Add(this.comboModRol);
            this.groupBox1.Controls.Add(this.modificar);
            this.groupBox1.Controls.Add(this.reactivar);
            this.groupBox1.Location = new System.Drawing.Point(104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 214);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Rol";
            // 
            // comboModRol
            // 
            this.comboModRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModRol.FormattingEnabled = true;
            this.comboModRol.Location = new System.Drawing.Point(14, 19);
            this.comboModRol.Name = "comboModRol";
            this.comboModRol.Size = new System.Drawing.Size(156, 21);
            this.comboModRol.TabIndex = 10;
            this.comboModRol.SelectedIndexChanged += new System.EventHandler(this.comboModRol_SelectedIndexChanged);
            // 
            // modificar
            // 
            this.modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificar.ForeColor = System.Drawing.Color.Maroon;
            this.modificar.Location = new System.Drawing.Point(95, 185);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 9;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // reactivar
            // 
            this.reactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reactivar.ForeColor = System.Drawing.Color.Maroon;
            this.reactivar.Location = new System.Drawing.Point(6, 185);
            this.reactivar.Name = "reactivar";
            this.reactivar.Size = new System.Drawing.Size(75, 23);
            this.reactivar.TabIndex = 8;
            this.reactivar.Text = "Re-Activar";
            this.reactivar.UseVisualStyleBackColor = true;
            this.reactivar.Click += new System.EventHandler(this.reactivar_Click);
            // 
            // checkedListFunciones
            // 
            this.checkedListFunciones.CheckOnClick = true;
            this.checkedListFunciones.FormattingEnabled = true;
            this.checkedListFunciones.Location = new System.Drawing.Point(6, 70);
            this.checkedListFunciones.Name = "checkedListFunciones";
            this.checkedListFunciones.Size = new System.Drawing.Size(164, 109);
            this.checkedListFunciones.TabIndex = 8;
            // 
            // cambiarFunciones
            // 
            this.cambiarFunciones.AutoSize = true;
            this.cambiarFunciones.Location = new System.Drawing.Point(6, 54);
            this.cambiarFunciones.Name = "cambiarFunciones";
            this.cambiarFunciones.Size = new System.Drawing.Size(100, 13);
            this.cambiarFunciones.TabIndex = 11;
            this.cambiarFunciones.Text = "Cambiar Funciones:";
            // 
            // ModificacionRol
            // 
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.rolesMod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVolver);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificacionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Rol";
            this.Load += new System.EventHandler(this.ModificacionRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reactivar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.ComboBox comboModRol;
        private System.Windows.Forms.CheckedListBox checkedListFunciones;
        private System.Windows.Forms.Label cambiarFunciones;
        
    }
}