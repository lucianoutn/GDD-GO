using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.Abm_Afiliado;

namespace ClinicaFrba
{
    public partial class Menu : Form
    {
        public Menu(string user)
        {
            InitializeComponent();
            labelUser.Text = user;
            labelFecha.Text = ConstantesBD.fechaSistema.ToString();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void buttonABMAfiliado_Click(object sender, EventArgs e)
        {
            SubMenuAfiliado subMenuAf = new SubMenuAfiliado(this);
            subMenuAf.Show();
        }
    }
}
