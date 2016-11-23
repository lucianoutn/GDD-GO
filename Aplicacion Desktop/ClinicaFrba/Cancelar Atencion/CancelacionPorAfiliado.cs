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
    public partial class CancelacionPorAfiliado : Form
    {
        Form unMenu;
        int id_afiliado;
        Turno_DAO turno_dao;
        ProfesionalesDAO prof_dao;
        Especialidades_DAO esp_dao;

        public CancelacionPorAfiliado(Form menu, int id)
        {
            turno_dao = new Turno_DAO();
            prof_dao = new ProfesionalesDAO();
            esp_dao = new Especialidades_DAO();
            InitializeComponent();
            unMenu = menu;
            id_afiliado = id;
            cargarDatos();
        }

        private void cargarDatos()
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Refresh();
            int desc_id;

            List<String> lista_turnos = turno_dao.get_turnos(id_afiliado,ConstantesBD.fechaSistema);

            for (int i = 0; i < lista_turnos.Count; i++)
            {
                desc_id = int.Parse(lista_turnos[i]);
                
                dataGridViewResultados.Rows.Add(turno_dao.get_hora_desde(desc_id),
                                            prof_dao.get_nombre(turno_dao.get_profesional(desc_id)),
                                            esp_dao.get_descripcion_segun_turno(desc_id),
                                            desc_id);
                
            }    
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridViewResultados.SelectedRows.Count == 0)
                MessageBox.Show("Debe seleccionar un turno");
            else
            {

                DataGridViewRow fila = dataGridViewResultados.SelectedRows[0];
                string dia = fila.Cells["Dia"].Value.ToString();

                DateTime myDate = Convert.ToDateTime(dia);
                DateTime myDate2 = Convert.ToDateTime(ConstantesBD.fechaSistema);

                if (myDate.CompareTo(myDate2) > 0)                     // ACA HAY Q VALIDAR Q DIA NO SEA IGUAL A HOY
                {
                    int id = int.Parse(fila.Cells["Id_turno"].Value.ToString());

                    turno_dao.cancelarTurno(id, textBoxMotivo.Text, id_afiliado, 1);

                    MessageBox.Show("Turno cancelado");
                    unMenu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No puede cancelar, los turnos se deben cancelar con mas de un día de anticipacion");
                }

            }
        }
        
    }
}
