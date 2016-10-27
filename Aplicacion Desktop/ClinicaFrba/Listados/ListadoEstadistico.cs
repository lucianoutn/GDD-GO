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

            comboBoxTop5.Items.Add("Afiliados con más cancelaciones por especialidad");
            comboBoxTop5.Items.Add("Profesionales con más cancelaciones por especialidad");
            comboBoxTop5.Items.Add("Profesionales más consultados por especialidad");
            comboBoxTop5.Items.Add("Profesionales con menos horas trabajadas");
            comboBoxTop5.Items.Add("Afiliados con más bonos comprados");
            comboBoxTop5.Items.Add("Profesionales con más bonos de consulta utilizados");

            comboBoxSemestre.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxSemestre.Items.Add("Primer semestre");
            comboBoxSemestre.Items.Add("Segundo semestre");

            comboBoxAnio.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (string aux in listEstDAO.get_anios())
            {
                comboBoxAnio.Items.Add(aux);
            }

            comboBoxTop5.Enabled = true;
            comboBoxSemestre.Enabled = true;
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
            dataGridViewTop5.Rows.Clear();
            comboBoxSemestre.Enabled = true;
            comboBoxTop5.Enabled = true;
            comboBoxAnio.Enabled = true;
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
                case "Afiliados con más cancelaciones por especialidad":
                    lectorTop5 = listEstDAO.getCancelacionesAfiliados(condicionSemAnio);
                    break;

                case "Profesionales con más cancelaciones por especialidad":
                    lectorTop5 = listEstDAO.getCancelacionesProfesional(condicionSemAnio);
                    break;

                case "Profesionales más consultados por especialidad":
                    lectorTop5 = listEstDAO.getProfMasConsultaPorEspecialidad(condicionSemAnio);
                    break;

                case "Profesionales con menos horas trabajadas":
                    lectorTop5 = listEstDAO.getProfConMenosHorasTrabajadas(condicionSemAnio);
                    break;

                case "Afiliados con más bonos comprados":
                    lectorTop5 = listEstDAO.getAfiliadosConMasBonosComprados(condicionSemAnio);
                    break;

                case "Profesionales con más bonos de consulta utilizados":
                    lectorTop5 = listEstDAO.getProfConMasBonosConsultUtilizados(condicionSemAnio);
                    break;

            }

        }

        
    
    }
}
