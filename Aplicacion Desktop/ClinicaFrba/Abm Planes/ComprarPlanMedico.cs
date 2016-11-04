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
        ABM_usuario_DAO abm_usuario;
        PlanMedico_DAO plan_medico_dao;
        SeleccionarAfiliado unMenu;
        String unAfiliado;

        public ComprarPlanMedico(String id_afiliado, SeleccionarAfiliado menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            plan_medico_dao = new PlanMedico_DAO();
            InitializeComponent();
            unAfiliado = id_afiliado;
            unMenu = menu;
            cargarDatos();
        }

        private void cargarDatos()
        {
            List<string> lista_planes = new List<string>();

            lista_planes = plan_medico_dao.get_id_plan_medico_multiple();

            for (int i = 0; i < lista_planes.Count; i++)
            {
                comboBoxPlanes.Items.Add(lista_planes[i]);
            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            String planSeleccionado = comboBoxPlanes.SelectedItem.ToString();

            if (abm_usuario.get_plan_medico(unAfiliado) == 0)
            {
                abm_usuario.comprarPlanMedico(unAfiliado, planSeleccionado);
                MessageBox.Show("Plan Médico comprado con exito!");
            }
            else
            {
                MessageBox.Show("El afiliado ya tiene un Plan Médico asignado");
            }

            unMenu.Show();
            this.Close();

        }

        private void buttonVolver_Click_1(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }
    }
}
