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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class ConfirmacionTurno : Form
    {
        private Form anterior;
        private Form siguiente;
        private Profesional profesional;
        private Especialidad especialidad;
        private String username;
        private Horario horario;


        public ConfirmacionTurno(Form previoForm, Form posForm, Object h, Object prof, Object esp, String user)
        {
            InitializeComponent();
            try
            {
                anterior = previoForm;
                siguiente = posForm;
                horario = (Horario)h;
                profesional = (Profesional)prof;
                especialidad = (Especialidad)esp;
                username = user;
            }
            catch (Exception e)
            {   
                throw new Exception("no Casteable",e);
            }
            mostrarPorPantalla();
        }

        private void mostrarPorPantalla()
        {
            l_valorDias.Text = username;
            l_nombreProfesional.Text = profesional.toString();
            l_especialidad.Text = especialidad.toString();
            l_valorDuracion.Text = horario.getDuracion();
            l_ValorHoras.Text = horario.getDate()+" - "+horario.getTime();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Turno_DAO DAO = new Turno_DAO();
                Afiliado_DAO aux = new Afiliado_DAO();
                DAO.agendar_Turno(horario.getAgenda(),aux.getIDAfiliado(username),
                    profesional.getid(),especialidad.getID(),horario.getFecha());
            }
            catch (Exception)
            {                
                throw new Excepciones.EjecucionComandoFallidaException("fallo nuevo Turno");
            }
            siguiente.Show();
            this.Close();        
        }
    }
}
