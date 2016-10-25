using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.AbmRol
{
    public partial class ListarRol : Form
    {
        
        SubMenuRol menuAnterior;
        ABMRoles_DAO DAO;

        public ListarRol(SubMenuRol menu)
        {
            InitializeComponent();
            this.DAO = new ABMRoles_DAO();
            this.menuAnterior = menu;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.menuAnterior.Show();
            this.Close();
        }

        private void listView1_ObtenerRoles(object sender, EventArgs e)
        {
            //obtenerRoles.ImageList= DAO.obtenerRoles();
            //this.Show();
            //obtenerRoles.Items.
               List <String> roles = DAO.obtenerRoles();
               roles.ForEach(delegate(string s) { listView1.Items.Add(s); });
        }
        
        
    }
}
