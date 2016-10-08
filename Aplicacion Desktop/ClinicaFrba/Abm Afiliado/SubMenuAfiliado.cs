using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class SubMenuAfiliado : Form
    {
        Menu unMenu;

        public SubMenuAfiliado(Menu menu)
        {
            InitializeComponent();

            unMenu = menu;
        }

        private void buttonAltaAfiliado_Click(object sender, EventArgs e)
        {
            AltaAfiliado alta = new AltaAfiliado(this);
            alta.Show();
            this.Hide();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
