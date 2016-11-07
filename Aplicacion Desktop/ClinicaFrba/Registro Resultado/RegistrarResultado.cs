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
        VerificarAtencion subMenuVerAtencion;
        String afiliado = "";
        RegistroResultado_DAO regResult;

        public RegistrarResultado(VerificarAtencion subMenuAtencion, String unAfiliado)
        {
            abm_usuario = new ABM_usuario_DAO();
            regResult = new RegistroResultado_DAO();
            InitializeComponent();
            subMenuVerAtencion = subMenuAtencion;
            afiliado = unAfiliado;
            cargarDatos();
        }

        public void cargarDatos()
        {
            labelAfiliado.Text = afiliado;
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            subMenuVerAtencion.Show();
            this.Close();
        }

        private void button_cerrarConsulta_Click(object sender, EventArgs e)
        {
            String sintoma = textBoxSintoma.Text;
            String diagnostico = textBoxDiagnostico.Text;
            regResult.cargarDiagnosticoEnConsulta(afiliado, sintoma, diagnostico);
            MessageBox.Show("Diagnóstico cargado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.None);

            this.Close();

        }

        
    }
}
