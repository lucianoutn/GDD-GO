using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.AbmRol
{
    public partial class ModificacionRol : Form
    {
        
        SubMenuRol menuAnterior;

        public ModificacionRol(SubMenuRol menu)
        {
            InitializeComponent();

            this.menuAnterior = menu;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.menuAnterior.Show();
            this.Close();
        }

        private void modificar_Click(object sender, EventArgs e)
        {

            /*if (.SelectedItem == null)
                MessageBox.Show("Debe seleccionar un Rol");
            else
            {

                MessageBox.Show("Rol modificado con exito");
                this.menuAnterior.Show();
                this.Close();
            }
            */
        }

        
    }
}
