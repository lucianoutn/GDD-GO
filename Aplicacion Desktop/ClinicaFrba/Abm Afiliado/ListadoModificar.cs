using System;
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
    public partial class ListadoModificar : Form
    {
        SubMenuAfiliado unMenu;
        ABM_usuario_DAO abm_usuario;
        int afiliado;

        public ListadoModificar(int id_afiliado, SubMenuAfiliado menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
            afiliado = id_afiliado;

            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");

            comboEstadoCivil.Items.Add("Soltero/a");
            comboEstadoCivil.Items.Add("Casado/a");
            comboEstadoCivil.Items.Add("Viudo/a");
            comboEstadoCivil.Items.Add("Concubinato/a");
            comboEstadoCivil.Items.Add("Divorciado/a");
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBoxDireccion.Text = "";
            textBoxMail.Text = "";
            textBoxTelefono.Text = "";
        }

        private bool validarCampos()
        {
            if (comboDominio.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un dominio de email. Ayuda: seleccione una de las opciones dadas");
                return false;
            }
            if (!radioButtonMasculino.Checked & !radioButtonFemenino.Checked)
            {
                MessageBox.Show("Debe seleccionar el sexo");
                return false;
            }
            if (textBoxDireccion.Modified == false)
            {
                MessageBox.Show("Debe ingresar una dirección");
                return false;
            }
            if (textBoxTelefono.Modified == false)
            {
                MessageBox.Show("Debe ingresar un telefono");
                return false;
            }
            if (comboEstadoCivil.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar estado civil");
                return false;
            }

            return true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            bool camposLlenos = validarCampos();

            if (camposLlenos)
            {
                int sexo;
                int desc_Estado_Civil = comboEstadoCivil.SelectedIndex;

                if (radioButtonMasculino.Checked)
                {
                    sexo = 1;
                }
                else
                {
                    sexo = 0;
                }

                abm_usuario.actualizarAfiliado(textBoxDireccion.Text, textBoxMail.Text, textBoxTelefono.Text, sexo, desc_Estado_Civil, afiliado);
                unMenu.Show();
                this.Close();
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
