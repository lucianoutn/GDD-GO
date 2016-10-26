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

namespace ClinicaFrba.Compra_Bono
{
    public partial class CompraBono : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;

        public CompraBono(Menu menu)
        {
            InitializeComponent();
            unMenu = menu;
            abm_usuario = new ABM_usuario_DAO();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxIdAfiliado.Text))
            {
                if (!string.IsNullOrWhiteSpace(abm_usuario.get_nombre(textBoxIdAfiliado.Text)))
                {
                    SeleccionarBono seleccionBono = new SeleccionarBono(textBoxIdAfiliado.Text, this);
                    seleccionBono.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("El usuario no existe. Ingrese otro id");
            }
            else
                MessageBox.Show("Por favor ingrese un id afiliado");
        }
    }
}
