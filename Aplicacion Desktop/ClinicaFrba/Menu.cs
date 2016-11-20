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
using ClinicaFrba.Registro_Llegada;
using ClinicaFrba.Pedir_Turno;


namespace ClinicaFrba
{
    public partial class Menu : Form
    {
        private LoginDAO loginDAO;
        private ABM_usuario_DAO usuarioDAO;
        private PlanMedico_DAO plan_medico_dao;
        int id_usuario_logeado;
        string rol_logeado;

        public Menu(string user,int id_usuario, string rol)
        {
            leerArchivoConfig();
            InitializeComponent();
            labelUser.Text = user;
            id_usuario_logeado = id_usuario;
            rol_logeado = rol;

            labelFecha.Text = ConstantesBD.fechaSistema.ToString();
            loginDAO = new LoginDAO();
            usuarioDAO = new ABM_usuario_DAO();
            plan_medico_dao = new PlanMedico_DAO();

            if (rol == "Profesional")
            {
                id_usuario_logeado = usuarioDAO.get_id_profesional(id_usuario_logeado);
            }
            else
            {
                if (rol == "Afiliado")
                    id_usuario_logeado = usuarioDAO.get_id_afiliado(id_usuario_logeado);
                else
                    id_usuario_logeado = -1;
            }

            List<string> funciones = this.loginDAO.get_funcionalidades(rol);
            
            //Visibilidad de funciones, desactivar las que no correspondan al rol
              if (!(funciones.Contains("ABM de Rol")))
                    buttonABMRol.Hide();
              if (!(funciones.Contains("ABM de Usuarios")))
                    ABMUsuario.Hide();
              if (!(funciones.Contains("ABM de Afiliados")))
                    buttonABMAfiliado.Hide();
              if (!(funciones.Contains("ABM de Profesional")))
                    ABMProfesional.Hide();
              if (!(funciones.Contains("ABM de Especialidades Medicas")))
                    ABMEspecialidadesMedicas.Hide();
              if (!(funciones.Contains("ABM de Plan")))
                    ABMPlan.Hide();
              if (!(funciones.Contains("Registrar Agenda Profesional")))
                    ButtonCalendar.Hide();
              if (!(funciones.Contains("Compra de Bonos")))
                    buttonComprarBono.Hide();
              if (!(funciones.Contains("Pedido de Turno")))
                    pedidoTurno.Hide();
              if (!(funciones.Contains("Registro de llegada para atencion medica")))
                    button_RegLlegadaAtenMedica.Hide();
              if (!(funciones.Contains("Registro de resultado para atencion medica")))
                    button_RegResultAtenMedica.Hide();
              if (!(funciones.Contains("Cancelar atencion medica")))
                    button_CancelarAtencion.Hide();
              if (!(funciones.Contains("Listado Estadístico")))
                    button_ListadoEstadistico.Hide();
              if (rol == "Profesional")
                    buttonPlanMedico.Hide();
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
            SeleccionarTurno menuAtenMedica = new SeleccionarTurno(this, id_usuario_logeado);
            menuAtenMedica.Show();
        }

        private void button_CancelarAtencion_Click(object sender, EventArgs e)
        {
            if (id_usuario_logeado == -1)
            {
                CancelarAtencionSeleccion menuCancelarAtencion = new CancelarAtencionSeleccion(this);
                menuCancelarAtencion.Show();
            }

            if (rol_logeado == "Profesional")
            {
                CancelacionPorMedico cancelarMedico = new CancelacionPorMedico(this, id_usuario_logeado.ToString());
                cancelarMedico.Show();
            }
            else
            {
                if (rol_logeado == "Afiliado")
                {
                    CancelacionPorAfiliado cancelarAfiliado = new CancelacionPorAfiliado(this, id_usuario_logeado);
                    cancelarAfiliado.Show(); 
                }
            }

        }

        private void button_ListadoEstadistico_Click(object sender, EventArgs e)
        {
            Listado_Estadistico menuListadoEstadistico = new Listado_Estadistico(this);
            menuListadoEstadistico.Show();
        }


        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            if (labelUser.Text.CompareTo("admin") == 0)
            {
                CalendarAdmin vistaAdmin = new CalendarAdmin(this);
                vistaAdmin.Show();
                this.Hide();
            }
            else
            {
                CalendarProf vistaProff = new CalendarProf(this,this,labelUser.Text);
                vistaProff.Show();
                this.Hide();
            }
        }

        private void buttonComprarBono_Click(object sender, EventArgs e)
        {
            if (id_usuario_logeado == -1)
            {
                CompraBono compraBono = new CompraBono(this);
                compraBono.Show();
                this.Hide();
            }
            else
            {
                if (usuarioDAO.get_plan_medico(id_usuario_logeado.ToString()) == 0)
                {
                    MessageBox.Show("El afiliado no posee un Plan Médico. Por favor, dirigirse al Menú Principal y seleccionar la opcion Plan Médico, luego comprar un Plan Médico.");
                }
                else
                {
                    SeleccionarBono seleccionBono = new SeleccionarBono(id_usuario_logeado.ToString(), this);
                    seleccionBono.Show();
                    this.Hide();
                }
            }
            
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

        private void buttonPlanMedico_Click(object sender, EventArgs e)
        {
            SubMenuPlanMedico menu = new SubMenuPlanMedico(this, id_usuario_logeado);
            menu.Show();
            this.Hide();
        }

        private void button_RegLlegadaAtenMedica_Click(object sender, EventArgs e)
        {
            SubmenuRegistro menu = new SubmenuRegistro();
            menu.Show();
        }

        private void pedidoTurno_Click(object sender, EventArgs e)
        {
            if (labelUser.Text.CompareTo("admin") == 0)
            {
                Pedir_Turno.SeleccionarAfiliado vista = new Pedir_Turno.SeleccionarAfiliado(this);
                vista.Show();
                this.Hide();
            }
            else
            {
                FormNuevoTurno vista = new FormNuevoTurno(this, this, labelUser.Text);
                    vista.Show();
                this.Hide();
            }
        }

    }
}
