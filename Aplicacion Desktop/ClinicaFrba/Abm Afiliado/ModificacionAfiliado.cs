﻿using System;
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
    public partial class ModificacionAfiliado : Form
    {
        SubMenuAfiliado unMenu;
        ABM_usuario_DAO abm_usuario;
        List<string> lista_usuarios_afiliados = new List<string>();

        public ModificacionAfiliado(SubMenuAfiliado menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxDni.Text = "";
            textBoxApellido.Text = "";
            textBoxId.Text = "";
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridViewResultados.SelectedRows[0];
                int id_afiliado = int.Parse(fila.Cells["ID"].Value.ToString());

                MessageBox.Show(" "+id_afiliado);
                
                ListadoModificar formModificar = new ListadoModificar(id_afiliado, unMenu);
                formModificar.Show();
                this.Close();
                
            }
            catch
            {
                MessageBox.Show("Seleccione una fila");
            }

        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();

            String desc_nombre = textBoxNombre.Text;
            String desc_apellido = textBoxApellido.Text;
            String desc_dni = textBoxDni.Text;
            String desc_id = textBoxId.Text;

            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                lista_usuarios_afiliados = abm_usuario.get_id_afiliado_multiple(desc_nombre, desc_apellido, desc_dni);


                for (int i = 0; i < lista_usuarios_afiliados.Count; i++)
                {
                    desc_id = lista_usuarios_afiliados[i];

                    dataGridViewResultados.Rows.Add(desc_id,
                                              abm_usuario.get_nombre(desc_id).ToString(),
                                              abm_usuario.get_apellido(desc_id).ToString(),
                                              abm_usuario.get_dni(desc_id).ToString(),
                                              abm_usuario.get_id_usuario(desc_id).ToString());
                }
            }
            else
            {
                dataGridViewResultados.Rows.Add(desc_id,
                                              abm_usuario.get_nombre(desc_id).ToString(),
                                              abm_usuario.get_apellido(desc_id).ToString(),
                                              abm_usuario.get_dni(desc_id).ToString(),
                                              abm_usuario.get_id_usuario(desc_id).ToString());
            }

        }

        private void buttonVolver_Click_1(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();

        }
    }
}