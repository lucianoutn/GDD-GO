using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Abm_Planes
{
    public partial class ComprarPlanMedico : Form
    {
        SubMenuPlanMedico unMenu;
        ABM_usuario_DAO abm_usuario;

        public ComprarPlanMedico(SubMenuPlanMedico menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxIdAfiliado.Text))
            {
                if (!string.IsNullOrWhiteSpace(abm_usuario.get_nombre(textBoxIdAfiliado.Text)))
                {
                    SeleccionarPlan seleccionPlan = new SeleccionarPlan(textBoxIdAfiliado.Text);
                    seleccionPlan.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("El usuario no existe. Ingrese otro id");
            }
            else
                MessageBox.Show("Por favor ingrese un id afiliado");
        }
    }
}
