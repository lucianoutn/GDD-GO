using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class FormNuevoTurno : Form
    {
        private Form anterior;
        private Form menu;
        private String username;
        private List<Profesional> lista_prof;
        private List<Especialidad> lista_esp;
        private Boolean prof_es_unico;
        private Boolean esp_es_unica;
        private Profesional profesional;
        private Especialidad especialidad;
        private List<Horario> lista;

        public FormNuevoTurno(Form eleccion,Form menuppal, String name)
        {
            InitializeComponent();
            anterior = eleccion;
            menu = menuppal;
            username = name;

            prof_es_unico = false;
            esp_es_unica = false;
            ProfesionalesDAO profesionalesDAO = new ProfesionalesDAO();
            lista_prof = profesionalesDAO.getProfesionales();
            foreach (Profesional aux
                in lista_prof)
            {
                comboBox1.Items.Add(aux.toString());
            }
            comboBox1.Enabled = true;

            Especialidades_DAO especialidades_DAO = new Especialidades_DAO();
            lista_esp = especialidades_DAO.get_especialidades();
            foreach (Especialidad aux
                in lista_esp)
            {
                comboBox2.Items.Add(aux.toString());
            }
            comboBox2.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Profesional i in lista_prof)
            {
                if (i.toString().CompareTo(comboBox1.SelectedItem) == 0)
                {
                    profesional = i;
                    prof_es_unico = true;
                    if (!esp_es_unica)
                    {
                        comboBox2.Items.Clear();
                        actualizarEspecialidades();
                    }
                    else
                    {
                        iniciarGrid();
                    }
                    return;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Especialidad i in lista_esp)
            {
                if (i.toString().CompareTo(comboBox2.SelectedItem) == 0)
                {
                    especialidad = i;
                    esp_es_unica = true;
                    if (!prof_es_unico)
                    {
                        comboBox1.Items.Clear();
                        actualizarProfesionales();
                    }
                    else
                    {
                        iniciarGrid();
                    }
                    return;
                }
            }
        }

        private void actualizarEspecialidades()
        {
            comboBox2.Items.Clear();
            lista_esp.Clear();
            Especialidades_DAO especialidades_DAO = new Especialidades_DAO();
            lista_esp = especialidades_DAO.get_especialidadesDe(profesional.getid());
            foreach (Especialidad aux
                in lista_esp)
            {
                comboBox2.Items.Add(aux.toString());
            }
        }

        private void actualizarProfesionales()
        {
            comboBox1.Items.Clear();
            lista_prof.Clear();
            ProfesionalesDAO profesionalesDAO = new ProfesionalesDAO();
            lista_prof = profesionalesDAO.getProfesionalesConEspecialidad(especialidad.getID());
            foreach (Profesional aux
                in lista_prof)
            {
                comboBox1.Items.Add(aux.toString());
            }
        }

        private void iniciarGrid()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            if (!(esp_es_unica && prof_es_unico))
            {
                return;
            }
            Horarios_DAO DAO = new Horarios_DAO();
            lista = DAO.getHorariosDe(profesional, especialidad);
            Int32 aux = 0;
            foreach (Horario item in lista)
            {
                item.orden = aux;
                dataGridView.Rows.Add(
                    item.orden,item.getDate(),item.getDay(),item.getTime(),item.getDuracion());
                aux++;
            }
            dataGridView.Refresh();
            dataGridView.Sort(dataGridView.Columns[1],ListSortDirection.Ascending);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 i = (Int32) dataGridView.SelectedRows[0].Cells["Key"].Value;
                Horario h = lista.Find(x => x.orden.Equals(i));
                ConfirmacionTurno confirmacion =
                    new ConfirmacionTurno(this, menu, (Object)h, (Object)profesional, (Object)especialidad, username);

                this.Hide();
                confirmacion.Show();
            }
            catch
            {
                throw new Exception("Ni idea");
            }
        }
    }
}
