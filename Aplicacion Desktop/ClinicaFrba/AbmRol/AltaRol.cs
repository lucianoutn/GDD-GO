﻿using System;
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
        ABMRoles_DAO DAO;

        public AltaRol(SubMenuRol menu)
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

        private void AltaRol_Load(object sender, EventArgs e)
        {
            //cargo la vista de funciones
            checkedListFunciones.ClearSelected();
            List<String> funciones = DAO.getfunciones();
            funciones.ForEach(delegate(string s) { checkedListFunciones.Items.Add(s); });
        }

        private void crear_Click(object sender, EventArgs e)
        {
            if (textBoxNombreRol.Modified == false)
                MessageBox.Show("Debe ingresar un nombre para el nuevo Rol");
            else if (checkedListFunciones.CheckedItems.Count == 0)
                MessageBox.Show("Debe seleccionar al menos una función");
            else
            {
                String desc_nombre_rol = textBoxNombreRol.Text;
                DAO.altaRol(desc_nombre_rol);

                //aca insertar en la tabla de funciones x rol
                List<String> funciones = new List<string>();
                foreach (var item in checkedListFunciones.CheckedItems)
                {
                    funciones.Add(item.ToString());
                }
                
                funciones.ForEach(delegate(string f) {
                    DAO.InsertarFuncionRol(f, desc_nombre_rol);
                });
                
                MessageBox.Show("Rol creado con exito");
                this.Hide();
                this.menuAnterior.Show();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreRol.Clear();

            for (int i = 0; i < checkedListFunciones.Items.Count; i++)
                checkedListFunciones.SetItemChecked(i, false);
        }
        

    }

}
