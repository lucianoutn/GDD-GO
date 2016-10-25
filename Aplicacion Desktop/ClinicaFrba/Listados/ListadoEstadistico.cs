using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Listados
{
    public partial class ListadoEstadistico : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;

        public ListadoEstadistico(Menu menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
        }
    }
}
