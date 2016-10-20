using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba.Botonazo
{
    public partial class SubMenuBotonazo : Form
    {
        Menu unMenu;

        public SubMenuBotonazo(Menu menu)
        {
            InitializeComponent();

            unMenu = menu;
        }

    }
}
