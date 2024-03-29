﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.DataBase.Entidades;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AltaAfiliado : Form
    {
        SubMenuAfiliado unMenu;
        ABM_usuario_DAO abm_usuario;
        ProfesionalesDAO profesional_dao;

        public AltaAfiliado(SubMenuAfiliado menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            profesional_dao = new ProfesionalesDAO();
            InitializeComponent();
            unMenu = menu;
            cargarDatos();
        }

        public void cargarDatos()
        {
            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");

            comboTipoDoc.Items.Add("DNI");

            fechaNacimiento.Format = DateTimePickerFormat.Custom;
            fechaNacimiento.CustomFormat = "dd'/'MM'/'yyyy";
            fechaNacimiento.Text = "05/05/2016";

            textFechaCre.Text = ConstantesBD.fechaSistema;

            comboEstadoCivil.Items.Add("Soltero/a");
            comboEstadoCivil.Items.Add("Casado/a");
            comboEstadoCivil.Items.Add("Viudo/a");
            comboEstadoCivil.Items.Add("Concubinato/a");
            comboEstadoCivil.Items.Add("Divorciado/a");
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonAlta_Click_1(object sender, EventArgs e)
        {
            if (!checkBoxExistente.Checked)
            {
                // DNI EXISTENTE - SI ES = 1 ES PORQUE ES VALIDO EL DNI (NO ESTÁ INGRESADO TODAVIA)
                if (abm_usuario.validarDNIExistente(textDni.Text) == 1)
                {
                    if (abm_usuario.validarUsuarioExistente(textBoxUserName.Text) == 1)
                    {
                        if (comboDominio.SelectedItem == null)
                        {
                            MessageBox.Show("Debe ingresar un dominio de email. Ayuda: seleccione una de las opciones dadas");
                        }
                        if (!radioButtonMasculino.Checked & !radioButtonFemenino.Checked)
                        {
                            MessageBox.Show("Debe seleccionar el sexo");
                        }
                        if (textCalle.Modified == false)
                        {
                            MessageBox.Show("Debe ingresar una dirección");
                        }
                        if (textTelefono.Modified == false)
                        {
                            MessageBox.Show("Debe ingresar un telefono");
                        }
                        if (comboEstadoCivil.SelectedItem == null)
                        {
                            MessageBox.Show("Debe seleccionar estado civil");
                        }


                        else if (comboTipoDoc.SelectedItem == null)
                        {
                            MessageBox.Show("Debe ingresar un tipo de documento. Ayuda: seleccione una de las opciones dadas");
                        }
                        else
                        {
                            String desc_Apellido = textApellido.Text;
                            String desc_Nombre = textNombre.Text;
                            String desc_Dni = textDni.Text;
                            String tipo_doc = comboTipoDoc.SelectedItem.ToString();
                            String desc_Mail = textMail.Text + "@" + comboDominio.SelectedItem.ToString();
                            String desc_Dom_Calle = textCalle.Text;
                            String desc_Telefono = textTelefono.Text;
                            String desc_Fecha_Nac = fechaNacimiento.Text;
                            int desc_Estado_Civil = comboEstadoCivil.SelectedIndex;
                            int sexo;
                            String user = textBoxUserName.Text;
                            String pass = textBoxPassword.Text;

                            if (radioButtonMasculino.Checked)
                            {
                                sexo = 1;
                            }
                            else
                            {
                                sexo = 0;
                            }

                            //abm_usuario.crearUsuario(user, pass);

                            EstablecerFamiliar altaAfiliado2 = new EstablecerFamiliar(desc_Nombre, desc_Apellido, sexo, tipo_doc, desc_Dni, desc_Mail, desc_Dom_Calle, desc_Telefono, desc_Estado_Civil, desc_Fecha_Nac,"(select ISNULL((Select MAX(id_usuario) from GDD_GO.usuario),0))",user, pass, this);
                            altaAfiliado2.Show();

                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Username ingresado ya está registrado en el sistema");

                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado ya está registrado en el sistema");
                }
            }
            else
            {
                int id_usuario = abm_usuario.validarUsuarioExistente(textBoxUserName.Text);
                if (id_usuario != 1)
                {
                    Profesional prof = profesional_dao.getProfesionalDeId(id_usuario.ToString());

                    if (prof != null)
                    {
                        if (abm_usuario.validarDNIExistente(prof.getdni().ToString()) == 1)
                        {
                            String user = textBoxUserName.Text;
                            String pass = "NO";

                            EstablecerFamiliar altaAfiliado2 = new EstablecerFamiliar(prof.getnombre(), prof.getapellido(), 1, "DNI", prof.getdni().ToString(), prof.getmail(), prof.getdireccion(), prof.gettelefono().ToString(), 1, "'" + prof.getnacimiento().ToString() + "'", id_usuario.ToString(),user, pass, this);
                            altaAfiliado2.Show();

                            this.Hide();
                        }
                        else
                            MessageBox.Show("El Afiliado ingresado no existe");

                    }
                    else
                    {
                        MessageBox.Show("El Profesional no existe");
                    }
                }
                else
                {
                    MessageBox.Show("El Username ingresado no existe");

                }
            }
        }

        private void textBox_DNI_Key_Press(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingresar solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_Telefono_Key_Press(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingresar solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
    }
}
