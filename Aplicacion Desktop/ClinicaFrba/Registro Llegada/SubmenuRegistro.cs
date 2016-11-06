using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class SubmenuRegistro : Form
    {
        RegistroLlegada_DAO DAO;
        
        
        public SubmenuRegistro()
        {
            InitializeComponent();
            this.DAO = new RegistroLlegada_DAO();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmenuRegistro_Load(object sender, EventArgs e)
        {
            List<String> especialidades = DAO.obtenerEspecialidades();
            especialidades.ForEach(delegate(string s) { comboEspecialidad.Items.Add(s); });

            List<String> profesionales = DAO.obtenerProfesionales();
            profesionales.ForEach(delegate(string s) { comboProfesional.Items.Add(s); });
               
               
        }

        private void comboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string especialidadElegida = comboEspecialidad.SelectedItem.ToString();
            List<String> profesionales = DAO.obtenerProfesionalesPorEspecialidad(especialidadElegida);
            comboProfesional.Items.Clear();
            profesionales.ForEach(delegate(string s) { comboProfesional.Items.Add(s); });
        }

        private void comboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            string profElegido = comboProfesional.SelectedItem.ToString();
            dataGridTurno.Rows.Clear();
            dataGridTurno.Refresh();


        }

       
    }
}
