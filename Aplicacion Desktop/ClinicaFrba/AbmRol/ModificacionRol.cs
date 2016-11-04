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
    public partial class ModificacionRol : Form
    {
        
        SubMenuRol menuAnterior;
        ABMRoles_DAO DAO;

        public ModificacionRol(SubMenuRol menu)
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

        private void modificar_Click(object sender, EventArgs e)
        {

            if (comboModRol.SelectedItem == null)
                MessageBox.Show("Debe seleccionar un Rol");
            else
            {
                //hacer la magia:
                //aca insertar en la tabla de funciones x rol
                String desc_nombre_rol = comboModRol.Text;
                
                //las bajas:
                List<String> funcionesDeBaja = new List<string>();
                foreach (var item in checkedListFunciones.Items)
                {

                    funcionesDeBaja.Add(item.ToString());
                }

                funcionesDeBaja.ForEach(delegate(string f)
                {
                    DAO.EliminarFuncionRol(f, desc_nombre_rol);
                });
                     
                //las altas:
                List<String> funcionesDeAlta = new List<string>();
                foreach (var item in checkedListFunciones.CheckedItems)
                {
                    funcionesDeAlta.Add(item.ToString());
                }

                funcionesDeAlta.ForEach(delegate(string f)
                {
                    DAO.InsertarFuncionRol(f, desc_nombre_rol);
                });
                
                MessageBox.Show("Rol modificado con exito");
                this.menuAnterior.Show();
                this.Close();
            }
            
        }

        private void ModificacionRol_Load(object sender, EventArgs e)
        {
            List<String> roles = DAO.obtenerRoles();
            roles.ForEach(delegate(string s) { comboModRol.Items.Add(s); });
            reactivar.Hide();
            
            List<String> funciones = DAO.getfunciones();
            funciones.ForEach(delegate(string s) { checkedListFunciones.Items.Add(s); });
            checkedListFunciones.ClearSelected();
        }

        private void comboModRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            reactivar.Hide();
            checkedListFunciones.ClearSelected();
            int cant = checkedListFunciones.Items.Count;
            for (int i = 0; i < cant; i++)
            {
                checkedListFunciones.SetItemChecked(i, false);
            }
            String rolSeleccionado = comboModRol.SelectedItem.ToString();
            bool estado = DAO.consultaEstadoRol(rolSeleccionado);
            if (!estado)
                reactivar.Show();
            
            List<string> funcionesActivas = DAO.get_funcionalidades(rolSeleccionado);
            funcionesActivas.ForEach(delegate(string s)
            {
                int index = checkedListFunciones.FindStringExact(s);
                checkedListFunciones.SetItemChecked(index, true);
            });


        }

        private void reactivar_Click(object sender, EventArgs e)
        {
            String rolSeleccionado = comboModRol.SelectedItem.ToString();
            DAO.reactivarRol(rolSeleccionado);
            MessageBox.Show("Rol re-activado con exito");
            this.Close();
            this.menuAnterior.Show();
        }

        
    }
}
