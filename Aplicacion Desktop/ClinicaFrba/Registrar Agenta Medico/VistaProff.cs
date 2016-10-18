using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class VistaProff : Form
    {
        Menu unMenu;

        public VistaProff(Menu menu)
        {
            InitializeComponent();
            unMenu = menu;
        }
    }
}
