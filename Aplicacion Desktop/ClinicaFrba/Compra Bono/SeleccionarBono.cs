using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class SeleccionarBono : Form
    {
        CompraBono unCompraBono;
        String unIdAfiliado;

        public SeleccionarBono(String idAfiliado, CompraBono compraBono)
        {
            InitializeComponent();
            unCompraBono = compraBono;
            unIdAfiliado = idAfiliado;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unCompraBono.Show();
            this.Close();
        }
    }
}
