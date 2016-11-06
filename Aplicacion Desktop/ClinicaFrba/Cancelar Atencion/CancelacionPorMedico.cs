using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionPorMedico : Form
    {
        Form unMenu;
        String profesional;

        public CancelacionPorMedico(Form menu, String id_profesional)
        {
            InitializeComponent();
            unMenu = menu;
            profesional = id_profesional;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }
    }
}
