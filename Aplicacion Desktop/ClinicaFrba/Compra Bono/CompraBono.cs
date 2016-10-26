using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class CompraBono : Form
    {
        Menu unMenu;

        public CompraBono(Menu menu)
        {
            InitializeComponent();
            unMenu = menu;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            SeleccionarBono seleccionBono = new SeleccionarBono(this);
            seleccionBono.Show();
            this.Hide();
        }
    }
}
