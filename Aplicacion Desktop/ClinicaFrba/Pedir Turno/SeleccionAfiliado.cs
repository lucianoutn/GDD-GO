using ClinicaFrba.ABM_Usuario;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class SeleccionAfiliado : Form
    {
        Menu menu;
        String username;
        bool check;
        List<Cliente> lista_Clientes;

        public SeleccionAfiliado(Menu menuPrevio)
        {
            InitializeComponent();
            menu = menuPrevio;
            check=false;
//            ProfesionalesDAO profesionalesDAO = new ProfesionalesDAO();
//            lista_prof = profesionalesDAO.getProfesionales();
//            foreach (Profesional aux in lista_prof)
//            {
//                comboBoxAf.Items.Add(aux.toString());
//            }
        }


        private void buttonBack_Click(object sender, System.EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (check)
            {
                Form1 vistaProff = new Form1();
                vistaProff.Show();
                this.Hide();
            }
        }

        private void comboBoxAf_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            foreach (Profesional aux
                in lista)
            {
                if (aux.toString().CompareTo(comboBoxAf.SelectedItem) == 0)
                {
                    ABM_usuario_DAO usuario_DAO = new ABM_usuario_DAO();
                    username = usuario_DAO.getUsuarioDe(aux.getusuario()).getUsername();
                    check = true;
                    return;
                }
            }
*/        }
    }
}
