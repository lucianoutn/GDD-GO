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
        ABMRoles_DAO DAO;

        public ModificacionRol(SubMenuRol menu)
        {
            InitializeComponent();
            this.DAO = new ABMRoles_DAO();
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

        private void ModificacionRol_Load(object sender, EventArgs e)
        {
            List<String> roles = DAO.obtenerRoles();
            roles.ForEach(delegate(string s) { comboModRol.Items.Add(s); });
            reactivar.Hide();
            
        }

        private void comboModRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            reactivar.Hide();
            String rolSeleccionado = comboModRol.SelectedItem.ToString();
            bool estado = DAO.consultaEstadoRol(rolSeleccionado);
            if (!estado)
                reactivar.Show();

        }

        private void reactivar_Click(object sender, EventArgs e)
        {
            String rolSeleccionado = comboModRol.SelectedItem.ToString();
            DAO.reactivarRol(rolSeleccionado);
            MessageBox.Show("Rol re-activado con exito");
            this.Close();
            this.menuAnterior.Show();
        }

        
    }
}
