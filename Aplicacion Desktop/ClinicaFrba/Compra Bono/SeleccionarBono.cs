﻿using System;
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
        CompraBono unCompraBono;
        List<string> un_lista_bonos;
        ABM_usuario_DAO abm_usuario;
        PlanMedico_DAO plan_medico_dao;
        String unIdAfiliado;

        public SeleccionarBono(String idAfiliado, List<string> lista_bonos, CompraBono compraBono)
        {
            abm_usuario = new ABM_usuario_DAO();
            plan_medico_dao = new PlanMedico_DAO();
            InitializeComponent();
            unCompraBono = compraBono;
            un_lista_bonos = lista_bonos;
            unIdAfiliado = idAfiliado;
            cargarDatos();
        }

        private void cargarDatos()
        {
            for (int i = 0; i < un_lista_bonos.Count; i++)
            {
                comboBoxBonos.Items.Add(un_lista_bonos[i]);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unCompraBono.Show();
            this.Close();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            try
            {
                String bono = comboBoxBonos.SelectedItem.ToString();

                cantidad = int.Parse(textBoxCantidad.Text);
                for (int i = 0; i < cantidad; i++)
                {
                    plan_medico_dao.comprarBono(bono, unIdAfiliado);
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
