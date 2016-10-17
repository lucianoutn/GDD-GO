using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class ListadoModificar : Form
    {
        SubMenuAfiliado unMenu;
        ABM_usuario_DAO abm_usuario;
        int afiliado;

        public ListadoModificar(int id_afiliado, SubMenuAfiliado menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
            afiliado = id_afiliado;
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxMail.Text = "";
            textBoxSexo.Text = "";
            textBoxFechaNac.Text = "";
            textBoxEstadoCivil.Text = "";
            textBoxTelefono.Text = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            abm_usuario.actualizarAfiliado(textBoxApellido.Text, textBoxNombre.Text, textBoxDireccion.Text, textBoxMail.Text, textBoxTelefono.Text, textBoxSexo.Text, textBoxFechaNac.Text, textBoxEstadoCivil.Text, afiliado);
            unMenu.Show();
            this.Close();
        }
    }
}
