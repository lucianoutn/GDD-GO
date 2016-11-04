using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.Abm_Planes;

namespace ClinicaFrba.Compra_Bono
{
    public partial class SeleccionarBono : Form
    {
        CompraBono unCompraBono;
        String unIdAfiliado;
        ABM_usuario_DAO abm_usuario;
        PlanMedico_DAO plan_medico_dao;

        public SeleccionarBono(String idAfiliado, CompraBono compraBono)
        {
            abm_usuario = new ABM_usuario_DAO();
            plan_medico_dao = new PlanMedico_DAO();
            InitializeComponent();
            unCompraBono = compraBono;
            unIdAfiliado = idAfiliado;
            cargarDatos();
        }

        private void cargarDatos()
        {
            List<string> lista_bonos = new List<string>();

            lista_bonos = plan_medico_dao.get_id_bono_multiple(abm_usuario.get_plan_medico(unIdAfiliado));

            if (lista_bonos.Count == 0)
            {
                MessageBox.Show("El afiliado no posee un Plan Médico. Por favor, dirigirse al Menú Principal y seleccionar la opcion Plan Médico, luego comprar un Plan Médico.");
                this.Close();
            }
            else
            {
                for (int i = 0; i < lista_bonos.Count; i++)
                {
                    comboBoxBonos.Items.Add(lista_bonos[i]);
                }
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unCompraBono.Show();
            this.Close();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            try
            {
                String bono = comboBoxBonos.SelectedItem.ToString();

                cantidad = int.Parse(textBoxCantidad.Text);
                for (int i = 0; i < cantidad; i++)
                {
                    plan_medico_dao.comprarBono(bono, unIdAfiliado);
                }

                MessageBox.Show("Compra realizada con exito");
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad.");
            }
        }
    }
}
