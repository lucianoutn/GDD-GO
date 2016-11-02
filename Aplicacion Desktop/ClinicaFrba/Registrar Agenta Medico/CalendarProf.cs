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
        private bool eleccion;
        private bool cambioFechaI;
        private bool cambioFechaF;
        private List<Especialidad> lista_esp;
        private List<DiaLaboral> lista_dias;

        public CalendarProf(Form menuPrevio, String username)
        {
            InitializeComponent();
            menu = menuPrevio;

            ProfesionalesDAO profesionalesDAO = new ProfesionalesDAO();
            profesional = profesionalesDAO.getProfesionalDeNombre(username);

            lista_dias = new List<DiaLaboral>();
            
            comboBoxEsp.Enabled = false;
            checkBoxL.Checked = false;
            checkBoxM.Checked = false;
            checkBoxX.Checked = false;
            checkBoxJ.Checked = false;
            checkBoxV.Checked = false;
            checkBoxS.Checked = false;

            dateTimePickerIni.Value = new DateTime(
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 2),
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 1),
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 0));

            dateTimePickerFin.Value = new DateTime(
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 2),
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 1),
                ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 0));

            cambioFechaI = false;
            cambioFechaF = false;
            eleccion = false;
            iniciarComboBox(username);
            labelName.Text = username;
        }

        public void regresar(Object dia)
        {
            this.Show();
            try
            {
                lista_dias.Add((DiaLaboral) dia);
            }
            catch (Exception e)
            {
                throw new Exception("no Casteable", e);
            }
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
                    eleccion = true;
                    dateTimePickerIni.Enabled = true;
                    return;
                }
        	}
        }

        private void dateTimePickerIni_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerIni.Checked)
            {
                errorDateIni.Clear();
                Calendario_DAO calendarioDAO = new Calendario_DAO();
                if (!calendarioDAO.validarFecha(profesional, dateTimePickerIni.Value.Date))
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
        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFin.Checked)
            {
                errorDateFin.Clear();
                Calendario_DAO calendarioDAO = new Calendario_DAO();

                if (!calendarioDAO.validarFecha(profesional, dateTimePickerIni.Value.Date))
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
                    ConfirmacionAgenda confirmacion = new ConfirmacionAgenda(this,menu,
                        profesional, especialidad, inicio, fin,
                        Int32.Parse(textBoxTurno.Text),lista_dias);
                    confirmacion.Show();
                    this.Hide();
                }
            }
        }

        private bool validarCamposCompletados()
        {
            errorDateIni.Clear();
            errorDateFin.Clear();
            errorDias.Clear();
            errorEsp.Clear();
            errorDuracion.Clear();
            bool aux = true;

            if(lista_dias.Count.Equals(0))
            {
                    errorDias.SetError(label5, "Elija al menos un dia");
                    aux = false;
            }
            if(!eleccion)
            {
                    errorEsp.SetError(comboBoxEsp, "Elija una Especialidad");
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
            switch (calendarioDAO.tryNewCalendar(profesional, especialidad, inicio, fin, int.Parse(textBoxTurno.Text),lista_dias))
            {
                case 1:
                    errorDateIni.SetError(dateTimePickerIni, "Fecha Invalida");
                    break;
                case 2:
                    errorDateFin.SetError(dateTimePickerFin, "Fecha Invalida");
                    break;
                case 3:
                    errorDuracion.SetError(textBoxTurno, "Debe ser un plazo válido");
                    break;
                case 4:
                    errorDias.SetError(label5, "Tope de 48 hs semanales superado");
                    break;
                case 5:
                    errorDateIni.SetError(dateTimePickerIni, "Imposible Agendar esta configuracion");
                    break;
                case 6:
                    errorDateFin.SetError(dateTimePickerFin, "Imposible Agendar esta configuracion");
                    break;
                default:
                    aux = true;
                    break;
            }
            return aux;
        }

        private void checkBoxL_CheckedChanged(object sender, EventArgs e)
        {
            errorDias.Clear();
            if (checkBoxL.Checked)
            {
                VistaJornada vista = new VistaJornada(this, 'L');
                vista.Show();
                this.Hide();
            }
        }

        private void checkBoxM_CheckedChanged(object sender, EventArgs e)
        {
            errorDias.Clear();
            if (checkBoxM.Checked)
            {
                VistaJornada vista = new VistaJornada(this, 'M');
                vista.Show();
                this.Hide();
            }
        }

        private void checkBoxX_CheckedChanged(object sender, EventArgs e)
        {
            errorDias.Clear();
            if (checkBoxX.Checked)
            {
                VistaJornada vista = new VistaJornada(this, 'X');
                vista.Show();
                this.Hide();
            }
        }

        private void checkBoxJ_CheckedChanged(object sender, EventArgs e)
        {
            errorDias.Clear();
            if (checkBoxJ.Checked)
            {
                VistaJornada vista = new VistaJornada(this, 'J');
                vista.Show();
                this.Hide();
            }
        }

        private void checkBoxV_CheckedChanged(object sender, EventArgs e)
        {
            errorDias.Clear();
            if (checkBoxV.Checked)
            {
                VistaJornada vista = new VistaJornada(this, 'V');
                vista.Show();
                this.Hide();
            }
        }

        private void checkBoxS_CheckedChanged(object sender, EventArgs e)
        {
            errorDias.Clear();
            if (checkBoxS.Checked)
            {
                VistaJornada vista = new VistaJornada(this, 'S');
                vista.Show();
                this.Hide();
            }
        }

    }
}