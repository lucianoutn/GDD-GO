namespace ClinicaFrba.AbmRol
{
    partial class ListarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarRol));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2016Roles = new ClinicaFrba.GD2C2016Roles();
            this.gD2C2016DataSet = new ClinicaFrba.GD2C2016DataSet();
            this.gD2C2016DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolTableAdapter = new ClinicaFrba.GD2C2016RolesTableAdapters.rolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016Roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(108, 232);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(142, 12);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(138, 214);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_ObtenerRoles);
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "rol";
            this.rolBindingSource.DataSource = this.gD2C2016Roles;
            // 
            // gD2C2016Roles
            // 
            this.gD2C2016Roles.DataSetName = "GD2C2016Roles";
            this.gD2C2016Roles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD2C2016DataSet
            // 
            this.gD2C2016DataSet.DataSetName = "GD2C2016DataSet";
            this.gD2C2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD2C2016DataSetBindingSource
            // 
            this.gD2C2016DataSetBindingSource.DataSource = this.gD2C2016DataSet;
            this.gD2C2016DataSetBindingSource.Position = 0;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // ListarRol
            // 
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.rolesAlta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Roles";
            this.Load += new System.EventHandler(this.ListarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016Roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.ListView listView1;
        private GD2C2016DataSet gD2C2016DataSet;
        private System.Windows.Forms.BindingSource gD2C2016DataSetBindingSource;
        private GD2C2016Roles gD2C2016Roles;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private GD2C2016RolesTableAdapters.rolTableAdapter rolTableAdapter;
       
    }
}