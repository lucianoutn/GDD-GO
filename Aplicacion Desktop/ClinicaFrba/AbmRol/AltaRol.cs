using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.AbmRol
{
    public partial class AltaRol : Form
    {
        
        SubMenuRol menuAnterior;

        public AltaRol(SubMenuRol menu)
        {
            InitializeComponent();

            this.menuAnterior = menu;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.menuAnterior.Show();
            this.Close();
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {

        }

        

    }

}
