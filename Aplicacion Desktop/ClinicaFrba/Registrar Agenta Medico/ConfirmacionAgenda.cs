using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Entidades;

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
                        Profesional prof, Especialidad esp,DateTime fechaIni,
                        DateTime fechaFin,Int32 d_turno,List<DiaLaboral> lista)
        {
            InitializeComponent();
            menu = posForm;
            try
            {
                menu = posForm;
                calendario = previoForm;
                profesional = prof;
                especialidad = esp;
                inicio = fechaIni;
                fin = fechaFin;
                t_consulta = d_turno;
                lista_dias = lista;
            }
            catch (Exception e)
            {   
                throw new Exception("no Casteable",e);
            }
            mostrarPorPantalla();
        }

        private void mostrarPorPantalla()
        {

        }
    }
}
