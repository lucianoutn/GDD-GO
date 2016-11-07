using ClinicaFrba.ABM_Usuario;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class CalendarAdmin : Form
    {
        Menu menu;
        String username;
        bool check;
        List<Profesional> lista_prof;

        public CalendarAdmin(Menu menuPrevio)
        {
            InitializeComponent();
            menu = menuPrevio;
            check=false;
            ProfesionalesDAO profesionalesDAO = new ProfesionalesDAO();
            lista_prof = profesionalesDAO.getProfesionales();
            foreach (Profesional aux in lista_prof)
            {
                comboBoxProff.Items.Add(aux.toString());
            }
        }


        private void buttonBack1_Click(object sender, System.EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void buttonConfirm1_Click(object sender, EventArgs e)
        {
            if (check)
            {
                CalendarProf vistaProff = new CalendarProf(this,menu, username);
                vistaProff.Show();
                this.Close();
            }
        }

        private void comboBoxProff_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Profesional aux
                in lista_prof)
            {
                if (aux.toString().CompareTo(comboBoxProff.SelectedItem) == 0)
                {
                    ABM_usuario_DAO usuario_DAO = new ABM_usuario_DAO();
                    username = usuario_DAO.getUsuarioDe(aux.getusuario()).getUsername();
                    check = true;
                    return;
                }
            }
        }
    }
}
