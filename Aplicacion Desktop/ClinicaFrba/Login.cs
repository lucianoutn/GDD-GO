﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.SeleccionDeRol;


namespace ClinicaFrba
{
    public partial class Login : Form
    {
        private LoginDAO loginDAO;
        

        public Login()
        {
            leerArchivoConfig();
            loginDAO = new LoginDAO();
            InitializeComponent();
            loginDAO.iniciar_aplicacion();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(textBoxUserName.Text)) || (string.IsNullOrWhiteSpace(textBoxPassword.Text)))
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mensaje = this.loginDAO.validar_login(textBoxUserName.Text, textBoxPassword.Text);
                switch (mensaje)
                {
                    case "invalido":
                        MessageBox.Show("El usuario no existe en el sistema.", "Usuario Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "incorrecto":
                        MessageBox.Show("La contraseña ingresada es incorrecta.", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "inhabilitado":
                        MessageBox.Show("El usuario esta inhabilitado.", "Usuario inhabilitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "correcto":

                        int id_usuario = loginDAO.get_id_usuario(textBoxUserName.Text);
                        //  VERIFICANDO SI TIENE MULTIPLES ROLES Y PREGUNTANDO CUAL ELIGE
                        int cant_roles = loginDAO.get_cant_roles(id_usuario);
                        if (cant_roles > 1)
                        {
                            MessageBox.Show("El usuario tiene multiples roles asignados, favor seleccione uno");
                            SeleccionRol roles = new SeleccionRol(id_usuario, this);
                            roles.Show();
                            break;
                        }

                        else
                        {
                            string rol = loginDAO.get_rol(id_usuario);
                            Menu menu = new Menu(textBoxUserName.Text, id_usuario, rol);
                            menu.Show();
                            this.Hide();
                            break;
                        }   
                }
            }
        }

        public void rolSeleccionado(string rol, int id_usuario)
        {
            Menu menu = new Menu(textBoxUserName.Text, id_usuario, rol);
            menu.Show();
            this.Hide();
        }

        private void leerArchivoConfig()
        {
            try
            {
                using (StreamReader sr = new StreamReader("ArchivoConfiguracion.txt"))
                {
                    string line, textoArchivo = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        textoArchivo = textoArchivo + line + "\n";
                    }

                    char[] delimitadores = { ' ', ',', '.', '\t', '\n' };

                    string[] palabras = textoArchivo.Split(delimitadores);

                    ConstantesBD.fechaSistema = palabras[2];
                    ConstantesBD.Param_Conexion_urlServidor = palabras[9];
                    ConstantesBD.Param_Conexion_usuario = palabras[14];
                    ConstantesBD.Param_Conexion_contraseña = palabras[17];
                    ConstantesBD.Param_Conexion_nombreBD = palabras[24];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al leer el archivo de configuracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
       
    }
}
