﻿using System;
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
    public partial class CambiarPlanMedico : Form
    {
        ABM_usuario_DAO abm_usuario;
        PlanMedico_DAO plan_medico_dao;
        SeleccionarAfiliado unMenu;
        String unAfiliado;

        public CambiarPlanMedico(String id_afiliado, SeleccionarAfiliado menu)
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

            dataGridViewPlan.Rows.Clear();
            dataGridViewPlan.Refresh();

            List<string> lista_planes = new List<string>();

            lista_planes = plan_medico_dao.get_id_plan_medico_multiple();

            for (int i = 0; i < lista_planes.Count; i++)
            {
                dataGridViewPlan.Rows.Add(lista_planes[i]
                                         ,plan_medico_dao.get_nombre(lista_planes[i]));
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridViewPlan.SelectedRows[0];
            int id = int.Parse(fila.Cells["id_plan"].Value.ToString());

            String planSeleccionado = id.ToString();

            abm_usuario.cambiarPlanMedico(unAfiliado, planSeleccionado, textBoxMotivo.Text);

            MessageBox.Show("Plan cambiado con exito!");

            unMenu.Show();
            this.Close();
        }
    }
}
