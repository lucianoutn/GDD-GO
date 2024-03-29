﻿using System;
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
    public partial class BajaRol : Form
    {
        
        SubMenuRol menuAnterior;
        ABMRoles_DAO DAO;

        public BajaRol(SubMenuRol menu)
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

        private void BajaRol_Load(object sender, EventArgs e)
        {
           
            List<String> roles = DAO.obtenerRolesActivos();
            roles.ForEach(delegate(string s) {comboBajaRol.Items.Add(s); });
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (comboBajaRol.SelectedItem == null)
                MessageBox.Show("Debe seleccionar un Rol");
            else
            {
                String nombre = comboBajaRol.SelectedItem.ToString();
                DAO.bajaRol(nombre);
                MessageBox.Show("Rol dado de baja con exito");
                this.menuAnterior.Show();
                this.Close();
            }
        }

        
    }
}
