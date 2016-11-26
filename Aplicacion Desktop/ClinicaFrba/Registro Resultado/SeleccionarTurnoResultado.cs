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
using ClinicaFrba.DataBase.Entidades;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class SeleccionarTurnoResultado : Form
    {
        Form unMenu;
        ABM_usuario_DAO abm_usuario;
        RegistroResultado_DAO regResult;
        int id_usuario_logeado;

        public SeleccionarTurnoResultado(Form menu, int unid_usuario_logeado)
        {
            abm_usuario = new ABM_usuario_DAO();
            regResult = new RegistroResultado_DAO();
            InitializeComponent();
            unMenu = menu;
            id_usuario_logeado = unid_usuario_logeado;
            cargarTurnos();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void cargarTurnos()
        {
            dataGridViewTurnos.Rows.Clear();
            dataGridViewTurnos.Refresh();

            List<TurnoProfesional> lista_turnos = new List<TurnoProfesional>();

            lista_turnos = regResult.get_turnos_del_dia(id_usuario_logeado);


            for (int i = 0; i < lista_turnos.Count; i++)
            {
                dataGridViewTurnos.Rows.Add(lista_turnos[i].getdni(),
                                            lista_turnos[i].toString(), 
                                            lista_turnos[i].gethora_llegada(),
                                            lista_turnos[i].getid());
            }
        }
    
        private void button_cargarAfiliado_Click(object sender, EventArgs e)
        {
        }



        private void button_abrirCosulta_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridViewTurnos.SelectedRows[0];
                int id_turno = int.Parse(fila.Cells["id_turno"].Value.ToString());

                RegistrarResultado registrarResultado = new RegistrarResultado(unMenu, id_turno);
                registrarResultado.Show();
                this.Hide(); 

            }
            catch
            {
                MessageBox.Show("Seleccione una fila");
            }

        }
      

        private void textBoxAfiliado_KeyPress(object sender, KeyPressEventArgs e) // Detecta desde el teclado que el ingreso sea de nros
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



       
    }
}
