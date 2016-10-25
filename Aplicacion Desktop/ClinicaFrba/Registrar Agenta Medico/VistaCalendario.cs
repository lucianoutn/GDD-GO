using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class 
        VistaCalendario : Form
    {
        Menu unMenu;

        public VistaCalendario(Menu menu, String profesional, String especialidad)
        {
            InitializeComponent();

            unMenu = menu;
            iniciarComboBoxes(profesional, especialidad);
        }

        private void iniciarComboBoxes(String profesional, String especialidad)
        {/**
            if (profesional == Nullable)
            {
                foreach(Profesional i in ProfesionalesDAO.getProfesionales())
                {
                    comboBoxEsp.Items.Add(i.getName());
                }
            }
            if (especialidad == Nullable)
            {
                foreach(Especialiad j in EspecialidadesDAO.getEspecialiades())
                {
                    comboBoxEsp.Items.Add(j.getName());
                }
            }**/
        }


   
    }
}
