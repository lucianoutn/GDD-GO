using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Entidades;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class ConfirmacionAgenda : Form
    {
        private Form menu;
        private Form calendario;
        private Profesional profesional;
        private Especialidad especialidad;
        private DateTime inicio;
        private DateTime fin;
        private Int32 t_consulta;
        private List<DiaLaboral> lista_dias;


        public ConfirmacionAgenda(Form previoForm, Form posForm,
                        Object prof, Object esp,DateTime fechaIni,
                        DateTime fechaFin,Int32 d_turno,Object lista)
        {
            InitializeComponent();
            menu = posForm;
            try
            {
                menu = (Form)posForm;
                calendario = (Form)previoForm;
                profesional = (Profesional)prof;
                especialidad = (Especialidad)esp;
                inicio = fechaIni;
                fin = fechaFin;
                t_consulta = d_turno;
                lista_dias = (List<DiaLaboral>) lista;
            }
            catch (Exception e)
            {   
                throw new Exception("no Casteable",e);
            }
            mostrarPorPantalla();
        }

        private void mostrarPorPantalla()
        {
            Calendario_DAO calendarioDAO = new Calendario_DAO();
            l_nombreProfesional.Text = profesional.toString();
            l_especialidad.Text = especialidad.toString();
            l_valorDuracion.Text = t_consulta.ToString();
            l_ValorHoras.Text = (calendarioDAO.controlHorarios(lista_dias)/100).ToString();
            l_valorDias.Text = calendarioDAO.stringAgenda(lista_dias);
            l_valorTurnos.Text = (calendarioDAO.controlHorarios(lista_dias) / deSexaADeci(t_consulta)).ToString();
            l_ValorInicio.Text = inicio.ToString();
            l_valorFin.Text = fin.ToString(); 
        }

        private Int32 deSexaADeci(Int32 a)
        {
            return a * 100 / 60;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            calendario.Show();
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Calendario_DAO calendarioDAO = new Calendario_DAO();
            try
            {
                calendarioDAO.newCalendar(profesional, especialidad, inicio, fin, t_consulta, lista_dias);
            }
            catch (Exception)
            {                
                throw new Excepciones.EjecucionComandoFallidaException("fallo nueva Agenda");
            }
            menu.Show();
            calendario.Close();
            this.Close();        
        }
    }
}
