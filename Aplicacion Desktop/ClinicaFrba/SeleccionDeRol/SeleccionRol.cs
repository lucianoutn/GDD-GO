using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;


namespace ClinicaFrba.SeleccionDeRol
{
    public partial class SeleccionRol : Form
    {
        private int id_usuario;
        private Login login;
        private LoginDAO loginDAO;

        public SeleccionRol(int id_usuario, Login login)
        {
            this.id_usuario = id_usuario;
            this.login = login;
            this.loginDAO = new LoginDAO();
            InitializeComponent();

        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            //cargar combobox
            List<String> roles = loginDAO.get_roles(id_usuario);
            roles.ForEach(delegate(string s) { comboRoles.Items.Add(s);});

        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            if (comboRoles.SelectedItem == null)
                MessageBox.Show("Debe seleccionar un Rol");
            else
            {
                string rol = comboRoles.SelectedItem.ToString();
                login.rolSeleccionado(rol, id_usuario);
                this.Close();

            }
        }

        
        
    }
}
