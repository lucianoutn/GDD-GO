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

        int unSexo, unDesc_Estado_Civil;
        String unDesc_Nombre, unDesc_Apellido, unTipo_doc, unDesc_Dni, unDesc_Mail, unDesc_Dom_Calle, unDesc_Telefono, unDesc_Fecha_Nac;

        public SeleccionarAfiliado(Form menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
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

            String desc_nombre = textBoxNombre.Text;
            String desc_apellido = textBoxApellido.Text;
            String desc_dni = textBoxDni.Text;
            String desc_id = textBoxId.Text;

            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                lista_usuarios_afiliados = abm_usuario.get_id_afiliado_multiple(desc_nombre, desc_apellido, desc_dni);

            }
            else
            {
                lista_usuarios_afiliados = abm_usuario.get_id_afiliado(desc_id);
                
            } 
            
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
    }
}
