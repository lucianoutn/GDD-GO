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
    public partial class CancelarAtencion : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;

        public CancelarAtencion(Menu menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonPlanMedico_Click(object sender, EventArgs e)
        {
            CancelacionPorMedico cancelarMed = new CancelacionPorMedico(this);
            cancelarMed.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CancelacionPorAfiliado cancelarAfi = new CancelacionPorAfiliado(this);
            cancelarAfi.Show();
            this.Hide();
        }
    }
}
