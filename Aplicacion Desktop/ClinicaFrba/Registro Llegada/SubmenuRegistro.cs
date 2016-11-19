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

namespace ClinicaFrba.Registro_Llegada
{
    public partial class SubmenuRegistro : Form
    {
        RegistroLlegada_DAO DAO;
        
        
        public SubmenuRegistro()
        {
            InitializeComponent();
            this.DAO = new RegistroLlegada_DAO();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmenuRegistro_Load(object sender, EventArgs e)
        {
            List<String> especialidades = DAO.obtenerEspecialidades();
            especialidades.ForEach(delegate(string s) { comboEspecialidad.Items.Add(s); });

            List<String> profesionales = DAO.obtenerProfesionales();
            profesionales.ForEach(delegate(string s) { comboProfesional.Items.Add(s); });
               
               
        }

        private void comboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string especialidadElegida = comboEspecialidad.SelectedItem.ToString();
            List<String> profesionales = DAO.obtenerProfesionalesPorEspecialidad(especialidadElegida);
            comboProfesional.Items.Clear();
            comboProfesional.ResetText();
            profesionales.ForEach(delegate(string s) { comboProfesional.Items.Add(s); });
        }

        private void comboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            string profElegido = comboProfesional.SelectedItem.ToString();
            dataGridTurno.Rows.Clear();
            dataGridTurno.Refresh();
                       
            List<int> turnosHoy = DAO.turnosHoy(profElegido);
           
            for (int i = 0; i < turnosHoy.Count; i++)
            {
                int id_turno = turnosHoy[i];

                dataGridTurno.Rows.Add(id_turno,
                                          DAO.getHoraTurno(id_turno),
                                          DAO.getAfTurno(id_turno));
                                          
            }

        }

        private void registrar_Click(object sender, EventArgs e)
        {
           //valido fila selecionada
            if (dataGridTurno.SelectedRows.Count == 0)
                MessageBox.Show("Seleccione un turno según el afiliado");
            else
            {
                DataGridViewRow fila = dataGridTurno.SelectedRows[0];
                int id_turno = int.Parse(fila.Cells["idTurno"].Value.ToString());
                string desc_hora_consulta = fila.Cells["Horario"].Value.ToString();
                int id_afiliado = DAO.getIdAfSegunTurno(id_turno);
                int cantDisponible = DAO.getCantBonosDisponibles(id_afiliado);

                //valido que tenga bonos disponibles y verifica tambien que los bonos sean del mismo plan actual del afiliado 
                if (cantDisponible == 0)
                    MessageBox.Show("El afiliado no tiene bonos de consulta disponibles");
                else
                {
                    //tomo el primer bono disponible, marco el bono como usado y decremento el total y verifica tambien que los bonos sean del mismo plan actual del afiliado
                    int id_bono = DAO.getUnBonoDisponible(id_afiliado);
                    DAO.marcarBonoUtilizado(id_bono);
                    cantDisponible--;
                   
                    //muestro bono utilizado y cantidad disponible
                    MessageBox.Show("Se utilizó el bono cuyo ID es el: "+id_bono+" y al afiliado le quedan "+cantDisponible+" bonos disponibles");


    /* VER SI HAY Q REGISTRAR LA CONSULTA COMPLETA ACA */

                    //inserto el registro consulta:
                    //marco la fecha y hora de llegada en la consulta
                    //DAO.registrarHoraLlegada(id_turno);
                    DAO.insertarConsulta(id_turno, id_bono, desc_hora_consulta);
                    MessageBox.Show("Llegada del afiliado registrada");
                    this.Close();

                }

            }
          
        }

       
    }
}
