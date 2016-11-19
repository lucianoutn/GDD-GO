using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.DataBase.Entidades;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class SeleccionarProfesional : Form
    {
        Form unMenu;
        ProfesionalesDAO profesionales_dao;
        List<Profesional> lista_usuarios_profesionales = new List<Profesional>();

        public SeleccionarProfesional(Form menu)
        {
            profesionales_dao = new ProfesionalesDAO();
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();

            String desc_nombre = textBoxNombre.Text;
            String desc_apellido = textBoxApellido.Text;
            String desc_dni = textBoxDni.Text;
            String desc_id = textBoxId.Text;

           if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                lista_usuarios_profesionales = profesionales_dao.get_profesional_multiple(desc_nombre, desc_apellido, desc_dni);

            }
            else
            {
                lista_usuarios_profesionales = profesionales_dao.get_profesional_multiple(desc_id);
                
            }

                for (int i = 0; i < lista_usuarios_profesionales.Count; i++)
                {
                    desc_id = lista_usuarios_profesionales[i].getid().ToString();

                    dataGridViewResultados.Rows.Add(desc_id,
                                                lista_usuarios_profesionales[i].getnombre(),
                                                lista_usuarios_profesionales[i].getapellido(),
                                                lista_usuarios_profesionales[i].getdni().ToString(),
                                                lista_usuarios_profesionales[i].getid().ToString());
                }

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            String familiar = "null";
            
            DataGridViewRow fila = dataGridViewResultados.SelectedRows[0];
            int id = int.Parse(fila.Cells["id"].Value.ToString());

            familiar = "" + id;


            CancelacionPorMedico cancelarMed = new CancelacionPorMedico(this, familiar);
            cancelarMed.Show();
            this.Hide();
        }
    }
}
