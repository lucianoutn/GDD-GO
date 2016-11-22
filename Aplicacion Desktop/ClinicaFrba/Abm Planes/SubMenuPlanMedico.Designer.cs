namespace ClinicaFrba.Abm_Planes
{
    partial class SubMenuPlanMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuPlanMedico));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonCambiarPlan = new System.Windows.Forms.Button();
            this.buttonComprarPlan = new System.Windows.Forms.Button();
            this.consultaHistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(96, 200);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 58;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonCambiarPlan
            // 
            this.buttonCambiarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCambiarPlan.Location = new System.Drawing.Point(58, 23);
            this.buttonCambiarPlan.Name = "buttonCambiarPlan";
            this.buttonCambiarPlan.Size = new System.Drawing.Size(162, 36);
            this.buttonCambiarPlan.TabIndex = 59;
            this.buttonCambiarPlan.Text = "Cambiar Plan";
            this.buttonCambiarPlan.UseVisualStyleBackColor = true;
            this.buttonCambiarPlan.Click += new System.EventHandler(this.buttonCambiarPlan_Click);
            // 
            // buttonComprarPlan
            // 
            this.buttonComprarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComprarPlan.Location = new System.Drawing.Point(58, 65);
            this.buttonComprarPlan.Name = "buttonComprarPlan";
            this.buttonComprarPlan.Size = new System.Drawing.Size(162, 36);
            this.buttonComprarPlan.TabIndex = 60;
            this.buttonComprarPlan.Text = "Comprar Plan";
            this.buttonComprarPlan.UseVisualStyleBackColor = true;
            this.buttonComprarPlan.Click += new System.EventHandler(this.buttonComprarPlan_Click);
            // 
            // consultaHistorico
            // 
            this.consultaHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultaHistorico.Location = new System.Drawing.Point(58, 107);
            this.consultaHistorico.Name = "consultaHistorico";
            this.consultaHistorico.Size = new System.Drawing.Size(162, 36);
            this.consultaHistorico.TabIndex = 60;
            this.consultaHistorico.Text = "Consultar histórico de cambios de planes médicos";
            this.consultaHistorico.UseVisualStyleBackColor = true;
            this.consultaHistorico.Click += new System.EventHandler(this.consultaHistorico_Click);
            // 
            // SubMenuPlanMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.consultaHistorico);
            this.Controls.Add(this.buttonComprarPlan);
            this.Controls.Add(this.buttonCambiarPlan);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubMenuPlanMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan Medico";
            this.Load += new System.EventHandler(this.SubMenuPlanMedico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonCambiarPlan;
        private System.Windows.Forms.Button buttonComprarPlan;
        private System.Windows.Forms.Button consultaHistorico;
    }
}