using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;

namespace ClinicaFrba.Abm_Planes
{
    public partial class consultaHistoricoMenu : Form
    {
        SubMenuPlanMedico menuAnterior;
        ABM_usuario_DAO abm_usuario;
        
        public consultaHistoricoMenu(SubMenuPlanMedico menuAnterior)
        {
            InitializeComponent();
            abm_usuario = new ABM_usuario_DAO();
            this.menuAnterior = menuAnterior;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            menuAnterior.Show();
            this.Close();
        }

        private void consultarHistorico_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxIdAfiliado.Text))
            {
                if (!string.IsNullOrWhiteSpace(abm_usuario.get_nombre(textBoxIdAfiliado.Text)))
                {
                    dataGridHistorial.Rows.Clear();
                    dataGridHistorial.Refresh();

                    List<int> ids_historial = abm_usuario.getIdsHistorial(textBoxIdAfiliado.Text);

                    for (int i = 0; i < ids_historial.Count; i++)
                    {
                        int id_historial = ids_historial[i];

                        dataGridHistorial.Rows.Add(abm_usuario.getFechaModificacion(id_historial),
                                                  abm_usuario.getMotivo(id_historial),
                                                  abm_usuario.getPlanAnterior(id_historial));

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
