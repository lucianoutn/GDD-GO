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

            comboBoxAnio.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxMes.Items.Add("01");
            comboBoxMes.Items.Add("02");
            comboBoxMes.Items.Add("03");
            comboBoxMes.Items.Add("04");
            comboBoxMes.Items.Add("05");
            comboBoxMes.Items.Add("06");
            comboBoxMes.Items.Add("07");
            comboBoxMes.Items.Add("08");
            comboBoxMes.Items.Add("09");
            comboBoxMes.Items.Add("10");
            comboBoxMes.Items.Add("11");
            comboBoxMes.Items.Add("12");

            comboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList;

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

        public void cargar_lista()
        {
            SqlDataReader lectorTop5;

            string condicionSemAnio = " ";

            switch (comboBoxSemestre.Text)
            { 
                case "Primer Semestre":
                    condicionSemAnio = condicionSemAnio + " MONTH(desc_hora_desde) BETWEEN '1' AND '6' ";
                    break;

                case "Segundo Semestre":
                    condicionSemAnio = condicionSemAnio + " MONTH(desc_hora_desde) BETWEEN '7' AND '12' ";
                    break;
            }

            if (!(string.IsNullOrWhiteSpace(comboBoxAnio.Text)))
            {
                condicionSemAnio = condicionSemAnio + " YEAR(desc_hora_desde) = '" + comboBoxAnio.Text + "'";
            }

            this.condicion_guardada = condicionSemAnio;

            switch (comboBoxTop5.Text)
            { 
                case "Especialidades con más cancelaciones": /*Tanto de afiliados como profesionales*/
                    lectorTop5 = listEstDAO.getCancelaciones(condicionSemAnio);
                    break;

                case "Profesionales más consultados por especialidad":
                    lectorTop5 = listEstDAO.getProfMasConsultaPorEspecialidad(condicionSemAnio);
                    cargar_grid_profMasConsultadosPorEsp(lectorTop5);
                    break;

                case "Profesionales con menos horas trabajadas por especialidad":
                    lectorTop5 = listEstDAO.getProfConMenosHorasTrabajadas(condicionSemAnio);
                    break;

                case "Afiliados con más bonos comprados":
                    lectorTop5 = listEstDAO.getAfiliadosConMasBonosComprados(condicionSemAnio);
                    break;

                case "Especialidades con más bonos de consulta utilizados":
                    lectorTop5 = listEstDAO.getProfConMasBonosConsultUtilizados(condicionSemAnio);
                    break;

            }

        }


        private void cargar_grid_cancelaciones()
        { 
        
        }









        private void cargar_grid_profMasConsultadosPorEsp(SqlDataReader lector)
        {
            SqlDataReader lectorT5;
            int i = 0;

            lectorT5 = lector;

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[6];

            this.dataGridViewTop5.Columns["Col_GrupoFam"].Visible = false;

            while (lectorT5.Read())
            {
                i++;
                columnas[0] = i.ToString();
                columnas[1] = lectorT5["desc_apellido"].ToString();
                columnas[2] = lectorT5["desc_nombre"].ToString();
                columnas[3] = lectorT5["Especialidad"].ToString();
                columnas[4] = lectorT5["Cantidad"].ToString();
                columnas[5] = lectorT5["Grupo Fam"].ToString();
                
                filas.Add(new DataGridViewRow());
                dataGridViewTop5.Rows.AddRange(filas.ToArray());
            }   
        }












        private void cargar_grid_profConMenosHorasTrabajadas()
        {
        
        }

        private void cargar_grid_afiliadosConMasBonosComp()
        {
        
        }

        private void cargar_grid_profConMasBonosConsultUtil()
        {
        
        }

        private void comboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSemestre.Enabled = false;

            if(comboBoxSemestre.Text != "")
            {
                comboBoxMes.Enabled = false;
                comboBoxTop5.Enabled = true;
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
            }
            else
            {
                comboBoxSemestre.Enabled = false;
                comboBoxTop5.Enabled = false;
            }
        }

        private void comboBoxTop5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}
