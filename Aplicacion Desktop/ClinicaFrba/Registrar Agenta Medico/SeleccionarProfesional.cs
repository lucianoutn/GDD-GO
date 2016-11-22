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
using ClinicaFrba.Registrar_Agenta_Medico;

namespace ClinicaFrba.Registrar_Agenda_Medico
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
            DataGridViewRow fila = dataGridViewResultados.SelectedRows[0];
            Int32 id = Int32.Parse(fila.Cells["id"].Value.ToString());

            ABM_usuario_DAO dao = new ABM_usuario_DAO();
            CalendarProf vistaProff = new CalendarProf(this, unMenu,
                dao.getUsuarioDe(lista_usuarios_profesionales[id].getusuario()).getUsername());
            vistaProff.Show();
            this.Hide();
       }
    }
}
