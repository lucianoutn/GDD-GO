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
    public partial class CancelarAtencionSeleccion : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;

        public CancelarAtencionSeleccion(Menu menu)
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
        {/*
            CancelacionPorMedico cancelarMed = new CancelacionPorMedico(this);
            cancelarMed.Show();
          * */
            SeleccionarProfesional seleccionProfesional = new SeleccionarProfesional(this);
            seleccionProfesional.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            CancelacionPorAfiliado cancelarAfi = new CancelacionPorAfiliado(this);
            cancelarAfi.Show();
            */
            SeleccionarAfiliado seleccionAfiliado = new SeleccionarAfiliado(this);
            seleccionAfiliado.Show();
            this.Hide();
        }
    }
}
