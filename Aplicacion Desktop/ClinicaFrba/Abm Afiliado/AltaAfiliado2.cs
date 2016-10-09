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
    public partial class AltaAfiliado2 : Form
    {
        AltaAfiliado unAltaAfiliado;
        ABM_usuario_DAO abm_usuario;
        List<string> listadoAfiliados = new List<string>();
        String unDesc_Apellido;
        String unDesc_Nombre;
        String unDesc_Dni;
        String unTipo_doc;
        String unDesc_Mail;
        String unDesc_Dom_Calle;
        String unDesc_Telefono;
        String unDesc_Fecha_Nac;
        String unDesc_fecha_creacion;
        int unDesc_Estado_Civil;
        int unSexo;

        public AltaAfiliado2(String desc_Nombre, String desc_Apellido, int sexo, String tipo_doc, String desc_Dni, String desc_Mail, String desc_Dom_Calle, String desc_Telefono, int desc_Estado_Civil, String desc_Fecha_Nac, String desc_fecha_creacion, AltaAfiliado altaAfiliado)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unAltaAfiliado = altaAfiliado;

            unDesc_Apellido = desc_Apellido;
            unDesc_Nombre = desc_Nombre;
            unDesc_Dni = desc_Dni;
            unTipo_doc = tipo_doc;
            unDesc_Mail = desc_Mail;
            unDesc_Dom_Calle = desc_Dom_Calle;
            unDesc_Telefono = desc_Telefono;
            unDesc_Fecha_Nac = desc_Fecha_Nac;
            unDesc_fecha_creacion = desc_fecha_creacion;
            unDesc_Estado_Civil = desc_Estado_Civil;
            unSexo = sexo;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unAltaAfiliado.Show();
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            String dniBuscado = textBoxDni.Text;

            listadoAfiliados = abm_usuario.get_afiliados_con_dni(dniBuscado);

            dataGridViewAfiliado.Rows.Add(listadoAfiliados[0], abm_usuario.get_apellido(listadoAfiliados[0]), abm_usuario.get_nombre(listadoAfiliados[0]), abm_usuario.get_mail(listadoAfiliados[0]), abm_usuario.get_fecha_nac(listadoAfiliados[0]));
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDni.Text))
            {
                abm_usuario.altaAfiliado(1, unDesc_Nombre, unDesc_Apellido, unSexo, unTipo_doc, unDesc_Dni, unDesc_Mail, unDesc_Dom_Calle, unDesc_Telefono, unDesc_Estado_Civil, unDesc_Fecha_Nac, unDesc_fecha_creacion);

            }
            else
            {
                DataGridViewRow fila = dataGridViewAfiliado.SelectedRows[0];
                int id = int.Parse(fila.Cells["Id"].Value.ToString());

                MessageBox.Show(id.ToString());
            }

            MessageBox.Show("El nuevo Afiliado fue creado con éxito!");
            this.Close();
            unAltaAfiliado.Close();
        }
    }
}
