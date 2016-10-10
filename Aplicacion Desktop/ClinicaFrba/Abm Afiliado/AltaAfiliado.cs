﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AltaAfiliado : Form
    {
        SubMenuAfiliado unMenu;
        ABM_usuario_DAO abm_usuario;

        public AltaAfiliado(SubMenuAfiliado menu)
        {
            abm_usuario = new ABM_usuario_DAO();
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
                // DNI EXISTENTE - SI ES = 1 ES PORQUE ES VALIDO EL DNI (NO ESTÁ INGRESADO TODAVIA)
                if (abm_usuario.validarDNIExistente(textDni.Text) == 1)
                {
                    if (comboDominio.SelectedItem == null)
                    {
                        MessageBox.Show("Debe ingresar un dominio de email. Ayuda: seleccione una de las opciones dadas");
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
                        String desc_fecha_creacion = textFechaCre.Text;
                        int desc_Estado_Civil = comboEstadoCivil.SelectedIndex;
                        int sexo;


                        if (radioButtonMasculino.Checked)
                        {
                            sexo = 1;
                        }
                        else
                        {
                            sexo = 0;
                        }
                        

                        AltaAfiliado2 altaAfiliado2 = new AltaAfiliado2(desc_Nombre, desc_Apellido, sexo, tipo_doc, desc_Dni, desc_Mail, desc_Dom_Calle, desc_Telefono, desc_Estado_Civil, desc_Fecha_Nac, desc_fecha_creacion, this);
                        altaAfiliado2.Show();
                            
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado ya está registrado en el sistema");
                }
            }

        }
    }