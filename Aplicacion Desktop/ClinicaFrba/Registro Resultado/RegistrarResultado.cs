using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class RegistrarResultado : Form
    {
        ABM_usuario_DAO abm_usuario;
        SeleccionarTurnoResultado subMenuVerAtencion;
        int unTurno = 0;
        RegistroResultado_DAO regResult;

        public RegistrarResultado(SeleccionarTurnoResultado subMenuAtencion, int turnoSeleccionado)
        {
            abm_usuario = new ABM_usuario_DAO();
            regResult = new RegistroResultado_DAO();
            InitializeComponent();
            subMenuVerAtencion = subMenuAtencion;
            unTurno = turnoSeleccionado;
        }


        private void button_Volver_Click(object sender, EventArgs e)
        {
            subMenuVerAtencion.Show();
            this.Close();
        }

        private void button_cerrarConsulta_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBoxSintoma.Text)) && !(string.IsNullOrWhiteSpace(textBoxDiagnostico.Text)))
            {
                String sintoma = textBoxSintoma.Text;
                String diagnostico = textBoxDiagnostico.Text;
                regResult.cargarDiagnosticoEnConsulta(unTurno, sintoma, diagnostico);
                MessageBox.Show("Diagnóstico cargado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.None);
                subMenuVerAtencion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cargar síntoma y/o enfermedad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void textBoxSintoma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingresar solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxDiagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingresar solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

       

        
    }
}
