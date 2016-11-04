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
    public partial class SubMenuPlanMedico : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;

        public SubMenuPlanMedico(Menu menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
        }

        private void buttonCambiarPlan_Click(object sender, EventArgs e)
        {
            SeleccionarAfiliado cambiarPlan = new SeleccionarAfiliado(this,0);
            this.Hide();
            cambiarPlan.Show();
        }

        private void buttonComprarPlan_Click(object sender, EventArgs e)
        {
            SeleccionarAfiliado cambiarPlan = new SeleccionarAfiliado(this,1);
            this.Hide();
            cambiarPlan.Show();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }
    }
}
