using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.DataBase.Entidades;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class CalendarProf : Form
    {
        private Form menu;
        private Profesional profesional;
        private Especialidad especialidad;
        private DateTime inicio;
        private DateTime fin;
        private bool check;
        private bool eleccion;
        private bool cambioFechaI;
        private bool cambioFechaF;
        private List<Especialidad> lista_esp;

        public CalendarProf(Form menuPrevio, String username)
        {
            InitializeComponent();
            menu = menuPrevio;

            ProfesionalesDAO profesionalesDAO = new ProfesionalesDAO();
            profesional = profesionalesDAO.getProfesionalDeNombre(username);
            comboBoxEsp.Enabled = false;
            dateTimePickerIni.Enabled = false;
            dateTimePickerIni.Value = new DateTime(
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 2),
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 1),
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 0));
            dateTimePickerFin.Enabled = false;
            dateTimePickerFin.Value = new DateTime(
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 2),
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 1),
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 0));
            check = false;
            cambioFechaI = false;
            cambioFechaF = false;
            eleccion = false;
            iniciarComboBox(username);
            labelName.Text = username;
        }

        private void iniciarComboBox(String username)
        {
            Especialidades_DAO especialidades_DAO = new Especialidades_DAO();
            lista_esp = especialidades_DAO.get_especialidadesDe(profesional.getid());
            foreach (Especialidad aux
                in lista_esp)
            {
                comboBoxEsp.Items.Add(aux.toString());
            }
            comboBoxEsp.Enabled = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void comboBoxEsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Especialidad i in lista_esp)
            {
                if (i.toString().CompareTo(comboBoxEsp.SelectedItem) == 0)
                {
                    especialidad = i;
                    dateTimePickerIni.Enabled = true;
                    eleccion = true;
                    return;
                }
        	}
        }

        private void dateTimePickerIni_ValueChanged(object sender, EventArgs e)
        {
            errorDateIni.Clear();
            Calendario_DAO calendarioDAO = new Calendario_DAO();
            if (!calendarioDAO.validarFecha(profesional, especialidad, dateTimePickerIni.Value.Date))
            {
                errorDateIni.SetError(dateTimePickerIni, "Fecha Ocupada o Invalida");
            }
            else
            {
                dateTimePickerFin.Enabled = true;
                cambioFechaI = true;
                inicio = dateTimePickerIni.Value.Date;
            }
        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            errorDateFin.Clear();
            Calendario_DAO calendarioDAO = new Calendario_DAO();

            if (!calendarioDAO.validarFecha(profesional, especialidad, dateTimePickerIni.Value.Date))
            {
                errorDateFin.SetError(dateTimePickerFin, "Fecha Ocupada o Invalida");
            }
            else if (inicio.CompareTo(dateTimePickerFin.Value.Date) >= 0)
            {
                errorDateFin.SetError(dateTimePickerFin, "Fecha anterior al inicio");
            }
            else
            {
                fin = dateTimePickerFin.Value.Date;
                cambioFechaF = true;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (validarCamposCompletados())
            {
                if (validarDatos())
                {
                    Calendario_DAO calendarioDAO = new Calendario_DAO();
                    Agenda agenda = calendarioDAO.newCalendar(profesional, especialidad, inicio, fin, int.Parse(textBoxTurno.Text));
                    ConfirmacionAgenda confirmacion = new ConfirmacionAgenda(menu,agenda);
                    confirmacion.Show();
                    this.Close();
                }
            }
        }

        private bool validarCamposCompletados()
        {
            errorDateIni.Clear();
            errorDateFin.Clear();
            errorHorarioIni.Clear();
            errorHorarioFin.Clear();
            errorDuracion.Clear();
            bool aux = true;

            if(textBoxHi.Text.CompareTo("") + textBoxMi.Text.CompareTo("") == 0)
            {
                    errorHorarioIni.SetError(textBoxMi, "Complete ambos Campos");
                    aux = false;
            }
            if(textBoxHf.Text.CompareTo("") + textBoxMf.Text.CompareTo("") == 0)
            {
                    errorHorarioFin.SetError(textBoxMf, "Complete ambos Campos");
                    aux = false;
            }
            if(!cambioFechaI)
            {
                    errorDateIni.SetError(dateTimePickerIni, "Elija una Fecha");
                    aux = false;
            }
            if(!cambioFechaF)
            {
                    errorDateFin.SetError(dateTimePickerFin, "Elija una Fecha");
                    aux = false;
            }
            if (textBoxTurno.Text.CompareTo("") == 0)
            {
                    errorDuracion.SetError(textBoxTurno, "Falta la Duracion de Cada Consulta");
                    aux = false;
            }
            return aux;
        }

        private bool validarDatos()
        {
            Calendario_DAO calendarioDAO = new Calendario_DAO();
            bool aux = false;
            switch (calendarioDAO.tryNewCalendar(profesional, especialidad, inicio, fin, int.Parse(textBoxTurno.Text)))
            {
                case 1:
                    errorHorarioIni.SetError(textBoxMi, "Debe ser despues de las "+calendarioDAO.getSHorarioMinimo());
                    break;
                case 2:
                    errorHorarioFin.SetError(textBoxMf, "Debe ser antes de las " + calendarioDAO.getSHorarioMaximo());
                    break;
                case 3:
                    errorDuracion.SetError(textBoxTurno, "Debe ser un plazo válido");
                    break;
                case 4:
                    errorDateIni.SetError(dateTimePickerIni, "Fatal Error");
                    errorDateFin.SetError(dateTimePickerFin, "Fatal Error");
                    errorDateIni.SetError(textBoxMi, "Fatal Error");
                    errorDateFin.SetError(textBoxMf, "Fatal Error");
                    errorProvider1.SetError(comboBoxEsp, "Imposible Agendar esta configuracion");
                    break;
                default:
                    aux = true;
                    break;
            }
            return aux;
        }

    }
}