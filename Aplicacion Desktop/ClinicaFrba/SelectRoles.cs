using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba
{
    public partial class SelectRoles : Form
    {
       private int id_usuario;

        public SelectRoles(int id_usuario)
        {
            this.id_usuario = id_usuario;

        }

        private void SelectRoles_Load(object sender, EventArgs e)
        {

        }
    }
}
