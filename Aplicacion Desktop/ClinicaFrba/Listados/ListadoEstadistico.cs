using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Listados
{
    public partial class ListadoEstadistico : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;
        ListadoEstadistico_DAO listEstDAO = new ListadoEstadistico_DAO();
        string condicion_guardada;

        public ListadoEstadistico(Menu menu)
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


        }
        
    
    }
}
