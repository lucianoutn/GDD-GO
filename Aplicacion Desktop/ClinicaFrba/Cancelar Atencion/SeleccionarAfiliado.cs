using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class SeleccionarAfiliado : Form
    {
        Form unMenu;
        ABM_usuario_DAO abm_usuario;
        List<string> lista_usuarios_afiliados = new List<string>();
        int pagActual = 0;
        int totalPagActual = 10;

        public SeleccionarAfiliado(Form menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
            dataGridViewResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxDni.Text = "";
            textBoxApellido.Text = "";
            textBoxId.Text = "";
        }
        
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();
            pagActual = 0;
            totalPagActual = 10;

            String desc_nombre = textBoxNombre.Text;
            String desc_apellido = textBoxApellido.Text;
            String desc_dni = textBoxDni.Text;
            String desc_id = textBoxId.Text;

            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                lista_usuarios_afiliados = abm_usuario.get_id_afiliado_multiple(desc_nombre, desc_apellido, desc_dni);

                cargarGrid();
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

        private void cargarGrid()
        {
            String desc_id;

            for (int i = pagActual; i < totalPagActual; i++)
            {
                desc_id = lista_usuarios_afiliados[i];

                dataGridViewResultados.Rows.Add(desc_id,
                                                abm_usuario.get_nombre(desc_id).ToString(),
                                                abm_usuario.get_apellido(desc_id).ToString(),
                                                abm_usuario.get_dni(desc_id).ToString(),
                                                abm_usuario.get_id_usuario(desc_id).ToString());
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridViewResultados.SelectedRows[0];
            try
            {

            }
            catch
            {
                MessageBox.Show("Seleccione una fila");
            }
            int id = int.Parse(fila.Cells["id"].Value.ToString());

            CancelacionPorAfiliado cancelarAfi = new CancelacionPorAfiliado(this, id);
            cancelarAfi.Show();
            this.Hide();
        }

        private void buttonPagSig_Click(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();

            pagActual = pagActual + 10;

            if (pagActual + 10 >= lista_usuarios_afiliados.Count)
            {
                totalPagActual = lista_usuarios_afiliados.Count;
            }
            else
            {
                totalPagActual = pagActual + 10;
            }

            cargarGrid();
        }

        private void buttonPagAnt_Click(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();

            if (pagActual != 0)
            {
                pagActual = pagActual - 10;
                totalPagActual = pagActual + 10;
            }

            cargarGrid();
        }
    }
}
