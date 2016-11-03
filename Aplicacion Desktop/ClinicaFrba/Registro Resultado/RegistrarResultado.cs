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

        public RegistrarResultado(VerificarAtencion subMenuAtencion)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            subMenuVerAtencion = subMenuAtencion;
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            subMenuVerAtencion.Show();
            this.Close();
        }
    }
}
