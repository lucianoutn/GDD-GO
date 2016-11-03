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
           
            //// obtenerRoles.ImageList= DAO.obtenerRoles();
            ////this.Show();
            ////obtenerRoles.Items.
            //listView1.View = View.Details;
            //listView1.Clear();
            //   List <String> roles = DAO.obtenerRoles();
            //   //roles.ForEach(delegate(string s) { listView1.Items.Add(s); });
            //   roles.ForEach(delegate(string s) { listView1.Items.Add(new ListViewItem(s)); });
               
            //    //new ListViewItem(s);
            //   listView1.Items.Add(new ListViewItem("hola"));
            //   listView1.Items.Add("unstring");
            //  // listView1.Refresh();

            // //  listView1.Update();
            //   // listView1.Select();
            //   //listView1.Show();
            //   //listView1.Items.Add(new ListViewItem(roles));
            //   listView1.FullRowSelect = true;
        }   
        
      
        private void ListarRol_Load(object sender, EventArgs e)
        {
            //cargo la vista de roles
            listView1.Clear();
            List<String> roles = DAO.obtenerRolesActivos();
            //roles.ForEach(delegate(string s) { listView1.Items.Add(s); });
            roles.ForEach(delegate(string s) { listView1.Items.Add(new ListViewItem(s)); });
               

        }
        
        
    }
}
