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
        List<string> lista_usuarios_afiliados = new List<string>();

        public CompraBono(Menu menu)
        {
            InitializeComponent();
            unMenu = menu;

            abm_usuario = new ABM_usuario_DAO();
            plan_medico_dao = new PlanMedico_DAO();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();

            String desc_nombre = textBoxNombre.Text;
            String desc_apellido = textBoxApellido.Text;
            String desc_dni = textBoxDni.Text;
            String desc_id = textBoxId.Text;

            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                lista_usuarios_afiliados = abm_usuario.get_id_afiliado_multiple(desc_nombre, desc_apellido, desc_dni);


                for (int i = 0; i < lista_usuarios_afiliados.Count; i++)
                {
                    desc_id = lista_usuarios_afiliados[i];

                    dataGridViewResultados.Rows.Add(desc_id,
                                                    abm_usuario.get_nombre(desc_id).ToString(),
                                                    abm_usuario.get_apellido(desc_id).ToString(),
                                                    abm_usuario.get_dni(desc_id).ToString(),
                                                    abm_usuario.get_id_usuario(desc_id).ToString());
                }
            }
            else
            {
                int dni = abm_usuario.get_dni(desc_id);

                if (dni != 0)
                {
                    dataGridViewResultados.Rows.Add(desc_id,
                                                    abm_usuario.get_nombre(desc_id).ToString(),
                                                    abm_usuario.get_apellido(desc_id).ToString(),
                                                    dni.ToString(),
                                                    abm_usuario.get_id_usuario(desc_id).ToString());
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridViewResultados.SelectedRows[0];
            try
            {
                String id = fila.Cells["id"].Value.ToString();

                if (abm_usuario.get_plan_medico(id) == 0)
                {
                    MessageBox.Show("El afiliado no posee un Plan Médico. Por favor, dirigirse al Menú Principal y seleccionar la opcion Plan Médico, luego comprar un Plan Médico.");
                }
                else
                {
                    SeleccionarBono seleccionBono = new SeleccionarBono(id, this);
                    seleccionBono.Show();
                    this.Hide();
                }

            }
            catch
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
