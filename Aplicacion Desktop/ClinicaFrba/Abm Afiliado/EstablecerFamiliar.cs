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
    public partial class EstablecerFamiliar : Form
    {
        AltaAfiliado unMenu;
        ABM_usuario_DAO abm_usuario;
        List<string> lista_usuarios_afiliados = new List<string>();

        int unSexo, unDesc_Estado_Civil;
        String unDesc_Nombre, unDesc_Apellido, unTipo_doc, unDesc_Dni, unDesc_Mail, unDesc_Dom_Calle, unDesc_Telefono, unDesc_Fecha_Nac;

        public EstablecerFamiliar(String desc_Nombre, String desc_Apellido, int sexo, String tipo_doc, String desc_Dni, String desc_Mail, String desc_Dom_Calle, String desc_Telefono, int desc_Estado_Civil, String desc_Fecha_Nac, AltaAfiliado menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
            unDesc_Nombre=desc_Nombre;
            unDesc_Apellido=desc_Apellido;
            unTipo_doc=tipo_doc;
            unDesc_Dni=desc_Dni;
            unDesc_Mail=desc_Mail;
            unDesc_Dom_Calle=desc_Dom_Calle;
            unDesc_Telefono = desc_Telefono;
            unDesc_Fecha_Nac=desc_Fecha_Nac;
            unSexo = sexo;
            unDesc_Estado_Civil = desc_Estado_Civil;
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String familiar = "null";
            String plan = "null";

            try
            {
                DataGridViewRow fila = dataGridViewResultados.SelectedRows[0];
                int id = int.Parse(fila.Cells["id"].Value.ToString());
                familiar = "" + id;

                int plan_ppal = abm_usuario.get_plan_medico(familiar);
                if (plan_ppal != 0)
                {
                    plan = "" + plan_ppal;
                }
                else
                {
                    plan = "null";
                }  
            }
            catch
            {
                familiar = "null";
            }

            abm_usuario.altaAfiliado(familiar, unDesc_Nombre, unDesc_Apellido, unSexo, unTipo_doc, unDesc_Dni, unDesc_Mail, unDesc_Dom_Calle, unDesc_Telefono, unDesc_Estado_Civil, unDesc_Fecha_Nac, plan);
            
          
            MessageBox.Show("Afiliado creado. Bienvenido!");
            this.Close();
            unMenu.Close();
        }
    }
}
