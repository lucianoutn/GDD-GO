using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.Abm_Planes;

namespace ClinicaFrba.Compra_Bono
{
    public partial class SeleccionarBono : Form
    {
        Form unForm;
        ABM_usuario_DAO abm_usuario;
        PlanMedico_DAO plan_medico_dao;
        String unIdAfiliado;

        public SeleccionarBono(String idAfiliado, Form form)
        {
            abm_usuario = new ABM_usuario_DAO();
            plan_medico_dao = new PlanMedico_DAO();
            InitializeComponent();
            unForm = form;
            unIdAfiliado = idAfiliado;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unForm.Show();
            this.Close();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            int unPlan = abm_usuario.get_plan_medico(unIdAfiliado);
            if (unPlan == 0)
            {
                MessageBox.Show("Compre un Plan Medico antes de realizar la compra de Bonos");
            }
            else
            {
                try
                {
                    cantidad = int.Parse(textBoxCantidad.Text);
                    for (int i = 0; i < cantidad; i++)
                    {
                        plan_medico_dao.comprarBono(unIdAfiliado, unPlan);
                    }

                    MessageBox.Show("Compra realizada con exito");
                }
                catch
                {
                    MessageBox.Show("Ingrese una cantidad.");
                }
            }
        }
    }
}
