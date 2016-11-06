using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class VerificarAtencion : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;
        RegistroResultado_DAO regResult;
      

        public VerificarAtencion(Menu menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            regResult = new RegistroResultado_DAO();
            InitializeComponent();
            unMenu = menu;
            cargarDatos();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        public void cargarDatos()
        {
            //labelHoraLlegada.Text = DateTime.Now.ToString("G");
            labelHoraLlegada.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button_abrirCosulta_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBoxAfiliado.Text)))
            {
                        if (regResult.afiliadoExistente(textBoxAfiliado.Text) == 0)
                        {
                            String nroAfiliado = textBoxAfiliado.Text;
                            String hora = labelHoraLlegada.Text;

                            regResult.cargarLlegadaEnConsulta(nroAfiliado, hora);
                            

                            RegistrarResultado subMenRegistraResult = new RegistrarResultado(this);
                            subMenRegistraResult.Show();
                        }
                        else
                        {
                            MessageBox.Show("No posee turno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }              
            }
        }
      

        private void textBoxAfiliado_KeyPress(object sender, KeyPressEventArgs e) // Detecta desde el teclado que el ingreso sea de nros
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        


        



       
    }
}
