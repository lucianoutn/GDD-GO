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
        PlanMedico_DAO plan_medico_dao;

        public CompraBono(Menu menu)
        {
            InitializeComponent();
            unMenu = menu;

            abm_usuario = new ABM_usuario_DAO();
            plan_medico_dao = new PlanMedico_DAO();
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
                    List<string> lista_bonos = new List<string>();
                    lista_bonos = plan_medico_dao.get_id_bono_multiple(abm_usuario.get_plan_medico(textBoxIdAfiliado.Text));

                    if (lista_bonos.Count == 0)
                    {
                        MessageBox.Show("El afiliado no posee un Plan Médico. Por favor, dirigirse al Menú Principal y seleccionar la opcion Plan Médico, luego comprar un Plan Médico.");
                    }
                    else
                    {
                        SeleccionarBono seleccionBono = new SeleccionarBono(textBoxIdAfiliado.Text ,lista_bonos, this);
                        seleccionBono.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("El usuario no existe. Ingrese otro id");
            }
            else
                MessageBox.Show("Por favor ingrese un id afiliado");
        }
    }
}
