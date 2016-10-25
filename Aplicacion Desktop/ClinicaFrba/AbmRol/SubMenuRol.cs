using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class SubMenuRol : Form
    {
        public SubMenuRol()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAltaRol_Click(object sender, EventArgs e)
        {
            AltaRol alta = new AltaRol(this);
            alta.Show();
            this.Hide();
        }

        private void buttonBajaRol_Click(object sender, EventArgs e)
        {
            BajaRol alta = new BajaRol(this);
            alta.Show();
            this.Hide();

        }

        private void buttonModificarRol_Click(object sender, EventArgs e)
        {
            ModificacionRol modificacion = new ModificacionRol(this);
            modificacion.Show();
            this.Hide();
        }

        private void buttonListarRol_Click(object sender, EventArgs e)
        {
            ListarRol listar = new ListarRol(this);
            listar.Show();
            this.Hide();
        }
       
    }
}
