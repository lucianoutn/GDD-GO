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
using ClinicaFrba.AbmRol;
using ClinicaFrba.Registro_Resultado;
using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Listados;
using ClinicaFrba.Compra_Bono;
using ClinicaFrba.Abm_Planes;
using ClinicaFrba.SinImplementar;


namespace ClinicaFrba
{
    public partial class Menu : Form
    {
        private LoginDAO loginDAO;

        public Menu(string user, string rol)
        {
            leerArchivoConfig();
            InitializeComponent();
            labelUser.Text = user;
            labelFecha.Text = ConstantesBD.fechaSistema.ToString();
            loginDAO = new LoginDAO();
            List<string> funciones = this.loginDAO.get_funcionalidades(rol);
            
            //Visibilidad de funciones, desactivar las que no correspondan al rol
              if (!(funciones.Contains("ABM de Rol")))
                    buttonABMRol.Hide();
            //if (!(funciones.Contains("ABM de Usuarios")))
           //     boton_abm_roles.Hide();
              if (!(funciones.Contains("ABM de Afiliados")))
                    buttonABMAfiliado.Hide();
          //  if (!(funciones.Contains("ABM de Profesional")))
           //     boton.Hide();
          //  if (!(funciones.Contains("ABM de Especialidades Medicas")))
          //      boton.Hide();
         //   if (!(funciones.Contains("ABM de Plan")))
          //      boton.Hide();
           // if (!(funciones.Contains("Registrar Agenda Profesional")))
           //     boton.Hide();
              if (!(funciones.Contains("Compra de Bonos")))
                    buttonComprarBono.Hide();
           // if (!(funciones.Contains("Pedido de Turno")))
          //      boton.Hide();
          //  if (!(funciones.Contains("Registro de llegada para atencion medica")))
           //     boton.Hide();
              if (!(funciones.Contains("Registro de resultado para atencion medica")))
                    button_RegResultAtenMedica.Hide();
              if (!(funciones.Contains("Cancelar atencion medica")))
                    button_CancelarAtencion.Hide();
              if (!(funciones.Contains("Listado Estadístico")))
                    button_ListadoEstadistico.Hide();
              if (rol == "Profesional")
                  buttonCambiarPlan.Hide();
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


        private void buttonABMRol_Click(object sender, EventArgs e)
        {
            SubMenuRol subMenuRol = new SubMenuRol();
            subMenuRol.Show();
        }


        private void button_RegResultAtenMedica_Click_1(object sender, EventArgs e)
        {
            VerificarAtencion menuAtenMedica = new VerificarAtencion(this);
            menuAtenMedica.Show();
        }

        private void button_CancelarAtencion_Click(object sender, EventArgs e)
        {
            CancelarAtencion menuCancelarAtencion = new CancelarAtencion(this);
            menuCancelarAtencion.Show();
        }

        private void button_ListadoEstadistico_Click(object sender, EventArgs e)
        {
            Listado_Estadistico menuListadoEstadistico = new Listado_Estadistico(this);
            menuListadoEstadistico.Show();
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

        private void buttonComprarBono_Click(object sender, EventArgs e)
        {
            CompraBono compraBono = new CompraBono(this);
            compraBono.Show();
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

        private void buttonCambiarPlan_Click(object sender, EventArgs e)
        {
            CambiarPlanMedico cambiarPlan = new CambiarPlanMedico(this);
            this.Hide();
            cambiarPlan.Show();
        }

        private void ABMProfesional_Click(object sender, EventArgs e)
        {
            SinImplementarSubMenu sinImplementarSubMenu = new SinImplementarSubMenu();
            sinImplementarSubMenu.Show();

        }

        private void ABMUsuario_Click(object sender, EventArgs e)
        {
            SinImplementarSubMenu sinImplementarSubMenu = new SinImplementarSubMenu();
            sinImplementarSubMenu.Show();
        }

        private void ABMEspecialidadesMedicas_Click(object sender, EventArgs e)
        {
            SinImplementarSubMenu sinImplementarSubMenu = new SinImplementarSubMenu();
            sinImplementarSubMenu.Show();
        }

        private void ABMPlan_Click(object sender, EventArgs e)
        {
            SinImplementarSubMenu sinImplementarSubMenu = new SinImplementarSubMenu();
            sinImplementarSubMenu.Show();
        }

    }
}
