using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Registrar_Agenta_Medico;

namespace ClinicaFrba
{
    public partial class Menu : Form
    {
        public Menu(string user)
        {
            leerArchivoConfig();
            InitializeComponent();
            labelUser.Text = user;
            labelFecha.Text = ConstantesBD.fechaSistema.ToString();
        }

        public Menu()
        {
            // TODO: Complete member initialization
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void buttonABMAfiliado_Click(object sender, EventArgs e)
        {
            SubMenuAfiliado subMenuAf = new SubMenuAfiliado(this);
            subMenuAf.Show();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            if (labelUser.Text.CompareTo("Admin") == 0)
            {
                VistaProff vistaAdmin = new VistaProff(this);
                vistaAdmin.Show();
            }
            /**else
            {
               VistaCalendario vistaProff = new VistaCalendario(this, labelUser.Text);
                vistaProff.Show();
            }**/
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
