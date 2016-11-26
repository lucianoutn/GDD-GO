using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionPorMedico : Form
    {
        Form unMenu;
        String unProfesional;
        Turno_DAO turno_dao;

        public CancelacionPorMedico(Form menu, String id_profesional)
        {
            turno_dao = new Turno_DAO();
            InitializeComponent();
            unMenu = menu;
            unProfesional = id_profesional;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("No valido");
            }
            else
            {

                List<string> listaTurnos = new List<string>();

                listaTurnos = turno_dao.get_turnos_profesional_por_fecha(unProfesional, dateTimePickerIni.Value, dateTimePickerFin.Value);

                for (int i = 0; i < listaTurnos.Count; i++)
                {
                    turno_dao.cancelarTurnoProfesional(textBoxMotivo.Text, unProfesional, listaTurnos[i]);

                }

                    MessageBox.Show("Turnos cancelados");
            }
        }

        private bool validar()
        {
            return dateTimePickerFin.Value>dateTimePickerIni.Value;
        }
    }
}
