using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Abm_Planes
{
    public partial class SeleccionarAfiliado : Form
    {
        SubMenuPlanMedico unMenu;
        ABM_usuario_DAO abm_usuario;
        int opcionElegida;

        public SeleccionarAfiliado(SubMenuPlanMedico menu, int opcion)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
            opcionElegida = opcion;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxIdAfiliado.Text))
            {
                if (!string.IsNullOrWhiteSpace(abm_usuario.get_nombre(textBoxIdAfiliado.Text)))
                {
                    if (opcionElegida == 0)
                    {
                        if (abm_usuario.get_plan_medico(textBoxIdAfiliado.Text) == 0)
                        {
                            MessageBox.Show("El Afiliado no tiene un Plan Médico. Por favor, dirigirse al menu anterior y seleccionar la opcion Comprar Plan Médico");
                        }
                        else
                        {
                            CambiarPlanMedico seleccionPlan = new CambiarPlanMedico(textBoxIdAfiliado.Text, this);
                            seleccionPlan.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        ComprarPlanMedico comprarPlan = new ComprarPlanMedico(textBoxIdAfiliado.Text, this);
                        comprarPlan.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("El usuario no existe. Ingrese otro id");
            }
            else
                MessageBox.Show("Por favor ingrese un id afiliado");
        }
    }
}
