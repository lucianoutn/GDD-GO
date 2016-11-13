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
        int id_usuario_logeado;

        public SubMenuPlanMedico(Menu menu, int id_usuario)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
            id_usuario_logeado = id_usuario;
        }

        private void buttonCambiarPlan_Click(object sender, EventArgs e)
        {
            if (id_usuario_logeado == -1)
            {
                SeleccionarAfiliado cambiarPlan = new SeleccionarAfiliado(this, 0);
                this.Hide();
                cambiarPlan.Show();
            }
            else
            {
                CambiarPlanMedico seleccionPlan = new CambiarPlanMedico(id_usuario_logeado.ToString(), this);
                seleccionPlan.Show();
                this.Hide();
            }
        }

        private void buttonComprarPlan_Click(object sender, EventArgs e)
        {
            if (id_usuario_logeado == -1)
            {
                SeleccionarAfiliado cambiarPlan = new SeleccionarAfiliado(this, 1);
                this.Hide();
                cambiarPlan.Show();
            }
            else
            {
                ComprarPlanMedico comprarPlan = new ComprarPlanMedico(id_usuario_logeado.ToString(), this);
                comprarPlan.Show();
                this.Hide();
 
            }
            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }
    }
}
