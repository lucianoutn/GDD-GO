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

            comboBoxTop5.Items.Add("Especialidades con más cancelaciones - Profesionales");
            comboBoxTop5.Items.Add("Especialidades con más cancelaciones - Afiliados");
            comboBoxTop5.Items.Add("Profesionales más consultados por especialidad");
            comboBoxTop5.Items.Add("Profesionales con menos horas trabajadas por especialidad");
            comboBoxTop5.Items.Add("Afiliados con más bonos comprados");
            comboBoxTop5.Items.Add("Especialidades con más bonos de consulta utilizados");

            comboBoxSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            
            comboBoxSemestre.Items.Add("Primer semestre");
            comboBoxSemestre.Items.Add("Segundo semestre");
           
            comboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList;

         
            comboBoxAnio.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (string aux in listEstDAO.get_anios())
            {
                comboBoxAnio.Items.Add(aux);
            }

            comboBoxTop5.Enabled = false;
            comboBoxSemestre.Enabled = false;
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
            comboBoxSemestre.Enabled = false;
            comboBoxTop5.Enabled = false;
            comboBoxAnio.Enabled = true;
            comboBoxMes.Enabled = false;
        }

        private void comboBoxTop5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTop5.Enabled = false;
            cargar_lista();
        }

        public void cargar_lista()
        {
            SqlDataReader lectorTop5;            
         
            string condicion = " ";
            string condicionAnio = " ";

            if (!(string.IsNullOrWhiteSpace(comboBoxMes.Text)))
            {
                condicion = condicion + " MONTH(co.desc_hora_consulta) = '" + comboBoxMes.Text + "'";
            }
            else
            {
                switch (comboBoxSemestre.Text)
                {
                    case "Primer semestre":
                        condicion = condicion + " MONTH(co.desc_hora_consulta) BETWEEN '1' AND '6' ";
                        break;

                    case "Segundo semestre":
                        condicion = condicion + " MONTH(co.desc_hora_consulta) BETWEEN '7' AND '12' ";
                        break;
                }
            }

      /*      if (!(string.IsNullOrWhiteSpace(comboBoxMes.Text)))
            {
                condicionMes = condicionMes + " MONTH(co.desc_hora_consulta) = '" + comboBoxMes.Text + "'";
            }
    */
            if (!(string.IsNullOrWhiteSpace(comboBoxAnio.Text)))
            {
                condicionAnio = condicionAnio + " AND YEAR(co.desc_hora_consulta) = '" + comboBoxAnio.Text + "'";
            }

            condicion = condicion + condicionAnio; /*+ condicionMes + condicionAnio;*/
            this.condicion_guardada = condicion;

            switch (comboBoxTop5.Text)
            { 
                case "Especialidades con más cancelaciones - Profesionales": /*Tanto de afiliados como profesionales*/
                    lectorTop5 = listEstDAO.getCancelaciones_profesionales(condicion);
                    cargar_grid_cancelaciones_profesionales(lectorTop5);
                    break;

                case "Especialidades con más cancelaciones - Afiliados": 
                    lectorTop5 = listEstDAO.getCancelaciones_afiliados(condicion);
                    cargar_grid_cancelaciones_afiliados(lectorTop5);
                    break;

                case "Profesionales más consultados por especialidad":
                    lectorTop5 = listEstDAO.getProfMasConsultaPorEspecialidad(condicion);
                    cargar_grid_profMasConsultadosPorEsp(lectorTop5);
                    break;

                case "Profesionales con menos horas trabajadas por especialidad":
                    lectorTop5 = listEstDAO.getProfConMenosHorasTrabajadas(condicion);
                    cargar_grid_profConMenosHorasTrabajadas(lectorTop5);
                    break;

                case "Afiliados con más bonos comprados":
                    lectorTop5 = listEstDAO.getAfiliadosConMasBonosComprados(condicion);
                    cargar_grid_afiliadosConMasBonosComp(lectorTop5);
                    break;

                case "Especialidades con más bonos de consulta utilizados":
                    lectorTop5 = listEstDAO.getProfConMasBonosConsultUtilizados(condicion);
                    cargar_grid_profConMasBonosConsultUtil(lectorTop5);
                    break;

            }

        }


        private void cargar_grid_cancelaciones_profesionales(SqlDataReader lector) //Cancelaciones  profesionales
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
                columnas[4] = lectorT5["Cantidad"].ToString(); // cancelaciones
               
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
            }

            lectorT5.Close();
            dataGridViewTop5.Rows.AddRange(filas.ToArray());
        }

        private void cargar_grid_cancelaciones_afiliados(SqlDataReader lector) //Cancelaciones por afiliado
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
                columnas[4] = lectorT5["Cantidad"].ToString(); // cancelaciones
                
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
            }

            lectorT5.Close();
            dataGridViewTop5.Rows.AddRange(filas.ToArray());
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
                            
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
            }

            lectorT5.Close();
            dataGridViewTop5.Rows.AddRange(filas.ToArray());
        }



        private void cargar_grid_profConMenosHorasTrabajadas(SqlDataReader lector)
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
                 
                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
                }

                lectorT5.Close();
                dataGridViewTop5.Rows.AddRange(filas.ToArray());
            
        }

        private void cargar_grid_afiliadosConMasBonosComp(SqlDataReader lector)
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

        private void cargar_grid_profConMasBonosConsultUtil(SqlDataReader lector) 
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
                    columnas[4] = lectorT5["Cantidad"].ToString(); 
                 
                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
                }

                lectorT5.Close();
                dataGridViewTop5.Rows.AddRange(filas.ToArray());
            
        }

        private void comboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e) // la idea es que muestre meses según el semestre elegido 
        {
            comboBoxSemestre.Enabled = false;
            comboBoxMes.Items.Clear();

            if(comboBoxSemestre.Text != "")
            {
                comboBoxMes.Enabled = true;
                comboBoxTop5.Enabled = true;

                if (comboBoxSemestre.Text == "Primer semestre")
                {
                    foreach (string aux2 in listEstDAO.get_primerSemestre())
                    {
                        comboBoxMes.Items.Add(aux2); //por cada selección suma meses !!
                    }
                } 
                else
                {
                    if (comboBoxSemestre.Text == "Segundo semestre")
                    {
                        foreach (string aux3 in listEstDAO.get_segundoSemestre())
                        {
                            comboBoxMes.Items.Add(aux3);
                        }
                    }
                }
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
