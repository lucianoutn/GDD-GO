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

namespace ClinicaFrba.Registro_Resultado
{
    public partial class SeleccionarMedicoResultado : Form
    {
        Form unMenu;
        ProfesionalesDAO profesionales_dao;
        List<Profesional> lista_usuarios_profesionales = new List<Profesional>();
        int pagActual = 0;
        int totalPagActual = 10;

        public SeleccionarMedicoResultado(Form menu)
        {
            profesionales_dao = new ProfesionalesDAO();
            InitializeComponent();
            unMenu = menu;
            dataGridViewResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridViewResultados.SelectedRows[0];
            int id = int.Parse(fila.Cells["id"].Value.ToString());



            SeleccionarTurnoResultado seleccionTurno = new SeleccionarTurnoResultado(this, id);
            seleccionTurno.Show();
            this.Hide();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();
            pagActual = 0;
            totalPagActual = 10;

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
                totalPagActual = 1;

            }

            cargarGrid();

        }

        private void cargarGrid()
        {
            String desc_id;

            for (int i = pagActual; i < totalPagActual; i++)
            {
                desc_id = lista_usuarios_profesionales[i].getid().ToString();

                dataGridViewResultados.Rows.Add(desc_id,
                                            lista_usuarios_profesionales[i].getnombre(),
                                            lista_usuarios_profesionales[i].getapellido(),
                                            lista_usuarios_profesionales[i].getdni().ToString(),
                                            lista_usuarios_profesionales[i].getid().ToString());
            }
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

        private void buttonPagSig_Click(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();

            pagActual = pagActual + 10;

            if (pagActual >= lista_usuarios_profesionales.Count)
            {
                pagActual = pagActual - 10;
            }
            if (pagActual + 10 >= lista_usuarios_profesionales.Count)
            {
                totalPagActual = lista_usuarios_profesionales.Count;
            }
            else
            {
                totalPagActual = pagActual + 10;
            }

            cargarGrid();
        }

        private void buttonPagAnt_Click(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();

            if (pagActual != 0)
            {
                pagActual = pagActual - 10;
                totalPagActual = pagActual + 10;
            }

            cargarGrid();
        }

    }
}
