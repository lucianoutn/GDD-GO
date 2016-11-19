using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using System.Data.SqlClient;

namespace ClinicaFrba.Listados
{
    public partial class Listado_Estadistico : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;
        ListadoEstadistico_DAO listEstDAO = new ListadoEstadistico_DAO();
        string condicion_guardada;

        public Listado_Estadistico(Menu menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
            cargar_combos();
        }


        private void cargar_combos()
        {
            //Para no poder editar el comboBox
            comboBoxTop5.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxTop5.Items.Add("Especialidades con más cancelaciones");
            comboBoxTop5.Items.Add("Profesionales más consultados por especialidad");
            comboBoxTop5.Items.Add("Profesionales con menos horas trabajadas por especialidad");
            comboBoxTop5.Items.Add("Afiliados con más bonos comprados");
            comboBoxTop5.Items.Add("Especialidades con más bonos de consulta utilizados");

            comboBoxSemestre.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxSemestre.Items.Add("Primer semestre");
            comboBoxSemestre.Items.Add("Segundo semestre");

            /*comboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (string aux1 in listEstDAO.get_meses())
            {
                comboBoxMes.Items.Add(aux1);
            }*/

            comboBoxAnio.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (string aux in listEstDAO.get_anios())
            {
                comboBoxAnio.Items.Add(aux);
            }

            comboBoxTop5.Enabled = true;
            comboBoxSemestre.Enabled = true;
            comboBoxMes.Enabled = false;
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            comboBoxAnio.SelectedIndex = -1;
            comboBoxTop5.SelectedIndex = -1;
            comboBoxSemestre.SelectedIndex = -1;
            comboBoxMes.SelectedIndex = -1;
            dataGridViewTop5.Rows.Clear();
            comboBoxSemestre.Enabled = true;
            comboBoxTop5.Enabled = true;
            comboBoxAnio.Enabled = true;
            comboBoxMes.Enabled = true;
        }

        private void comboBoxTop5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTop5.Enabled = false;
            cargar_lista();
        }



        public void cargar_lista()
        {
            SqlDataReader lectorTop5;

            string condicionSemOMesAnio = " "; // debe permitir enviar el semestre completo o algún mes elegido pero dentro del semestre

           
                switch (comboBoxSemestre.Text) // semestre completo ¿Por alguna razón ya no manda el semestre completo :( ?
                {
                    case "Primer Semestre":
                        condicionSemOMesAnio = condicionSemOMesAnio + " MONTH(co.desc_hora_consulta) BETWEEN '1' AND '6' ";
                        break;

                    case "Segundo Semestre":
                        condicionSemOMesAnio = condicionSemOMesAnio + " MONTH(co.desc_hora_consulta) BETWEEN '7' AND '12' ";
                        break;
                }
            

            if (!(string.IsNullOrWhiteSpace(comboBoxMes.Text)) && !(string.IsNullOrWhiteSpace(comboBoxSemestre.Text)))
            {
                condicionSemOMesAnio = condicionSemOMesAnio + " MONTH(co.desc_hora_consulta) = '" + comboBoxMes.Text + "'";
                     // cuando se elige un mes dentro semestre
            }

            if (!(string.IsNullOrWhiteSpace(comboBoxAnio.Text)))
            {
                condicionSemOMesAnio = condicionSemOMesAnio + " AND YEAR(co.desc_hora_consulta) = '" + comboBoxAnio.Text + "'";
            }

            this.condicion_guardada = condicionSemOMesAnio;

            switch (comboBoxTop5.Text)
            { 
                case "Especialidades con más cancelaciones": /*Tanto de afiliados como profesionales*/
                    lectorTop5 = listEstDAO.getCancelaciones(condicionSemOMesAnio);
                    break;

                case "Profesionales más consultados por especialidad":
                    lectorTop5 = listEstDAO.getProfMasConsultaPorEspecialidad(condicionSemOMesAnio);
                    cargar_grid_profMasConsultadosPorEsp(lectorTop5);
                    break;

                case "Profesionales con menos horas trabajadas por especialidad":
                    lectorTop5 = listEstDAO.getProfConMenosHorasTrabajadas(condicionSemOMesAnio);
                    break;

                case "Afiliados con más bonos comprados":
                    lectorTop5 = listEstDAO.getAfiliadosConMasBonosComprados(condicionSemOMesAnio);
                    break;

                case "Especialidades con más bonos de consulta utilizados":
                    lectorTop5 = listEstDAO.getProfConMasBonosConsultUtilizados(condicionSemOMesAnio);
                    break;

            }

        }


        private void cargar_grid_cancelaciones() // 1 listado, creo que debe ir en otra form porque el grid es distinto
        { 
        
        }

        private void cargar_grid_profMasConsultadosPorEsp(SqlDataReader lector) // punto 2 de listado hecho
        {
            SqlDataReader lectorT5;
            int i = 0;

            lectorT5 = lector;

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            this.dataGridViewTop5.Columns["Col_GrupoFam"].Visible = false;

            while (lectorT5.Read())
            {
                i++;
                columnas[0] = i.ToString();
                columnas[1] = lectorT5["desc_apellido"].ToString();
                columnas[2] = lectorT5["desc_nombre"].ToString();
                columnas[3] = lectorT5["Especialidad"].ToString();
                columnas[4] = lectorT5["Cantidad"].ToString(); // consultados
               // columnas[5] = lectorT5["Col_GrupoFam"].ToString();
                
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
            }

            lectorT5.Close();
            dataGridViewTop5.Rows.AddRange(filas.ToArray());
        }



        private void cargar_grid_profConMenosHorasTrabajadas(SqlDataReader lector)
        {
            {
                SqlDataReader lectorT5;
                int i = 0;

                lectorT5 = lector;

                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[5];

                this.dataGridViewTop5.Columns["Col_GrupoFam"].Visible = false; // no visible porque no va grupo familiar

                while (lectorT5.Read())
                {
                    i++;
                    columnas[0] = i.ToString();
                    columnas[1] = lectorT5["desc_apellido"].ToString();
                    columnas[2] = lectorT5["desc_nombre"].ToString();
                    columnas[3] = lectorT5["Especialidad"].ToString();
                    columnas[4] = lectorT5["Cantidad"].ToString(); //menos horas trabajadas
                    // columnas[5] = lectorT5["Col_GrupoFam"].ToString();

                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
                }

                lectorT5.Close();
                dataGridViewTop5.Rows.AddRange(filas.ToArray());
            }
        }

        private void cargar_grid_afiliadosConMasBonosComp(SqlDataReader lector)
        {
            {
                SqlDataReader lectorT5;
                int i = 0;

                lectorT5 = lector;

                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[6]; // 6 porque agrego grupo familiar

                this.dataGridViewTop5.Columns["Col_GrupoFam"].Visible = true; // visible porque agrego grupo familiar

                while (lectorT5.Read())
                {
                    i++;
                    columnas[0] = i.ToString();
                    columnas[1] = lectorT5["desc_apellido"].ToString(); //apellido afiliado
                    columnas[2] = lectorT5["desc_nombre"].ToString();//nombre afiliado
                    columnas[3] = lectorT5["Especialidad"].ToString();
                    columnas[4] = lectorT5["Cantidad"].ToString(); //cantidad de bonos comprados
                    columnas[5] = lectorT5["Col_GrupoFam"].ToString();

                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
                }

                lectorT5.Close();
                dataGridViewTop5.Rows.AddRange(filas.ToArray());
            }
        }

        private void cargar_grid_profConMasBonosConsultUtil() // 5 listado, creo que debe ir en otra form porque el grid es distinto
        {
        
        }

        private void comboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e) // la idea es que muestre meses según el semestre elegido 
        {
            comboBoxSemestre.Enabled = false;

            if(comboBoxSemestre.Text != "")
            {
                comboBoxMes.Enabled = true;
                comboBoxTop5.Enabled = true;

               /* if (comboBoxSemestre.Text == "Primer Semestre")
                {
                    foreach (string aux2 in listEstDAO.get_primerSemestre())
                    {
                        comboBoxMes.Items.Add(aux2);
                    }
                } 
                else
                {
                    foreach (string aux3 in listEstDAO.get_segundoSemestre())
                    {
                        comboBoxMes.Items.Add(aux3);
                    }
                }*/
            }
            else
            {
                comboBoxTop5.Enabled = false;
            }
        }


       



        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMes.Enabled = false;

            if (comboBoxMes.Text != "")
            {
                comboBoxSemestre.Enabled = false;
                comboBoxTop5.Enabled = true;
            }
            else
            {
                comboBoxTop5.Enabled = false;
            }
        }

        private void comboBoxAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAnio.Enabled = false;

            if(comboBoxAnio.Text != "")
            {
                comboBoxSemestre.Enabled = true;
               // comboBoxMes.Enabled = true;
            }
            else
            {
                comboBoxSemestre.Enabled = false;
                comboBoxTop5.Enabled = false;
                comboBoxMes.Enabled = false;
            }
        }

       

        
    }
}
