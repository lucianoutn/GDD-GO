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
        List<Afiliado> lista_Afiliados;

        public SeleccionAfiliado(Menu menuPrevio)
        {
            InitializeComponent();
            menu = menuPrevio;
            check=false;
            Clientes_DAO DAO = new Clientes_DAO();
            lista_Afiliados = DAO.getAfiliados();
            foreach (Afiliado aux in lista_Afiliados)
            {
                comboBoxAf.Items.Add(aux.toString());
            }
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
                Form1 formTurno = new Form1();
                formTurno.Show();
                this.Hide();
            }
        }

        private void comboBoxAf_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Afiliado aux
                in lista_Afiliados)
            {
                if (aux.toString().CompareTo(comboBoxAf.SelectedItem) == 0)
                {
                    ABM_usuario_DAO usuario_DAO = new ABM_usuario_DAO();
                    username = usuario_DAO.getUsuarioDe(aux.getusuario()).getUsername();
                    check = true;
                    return;
                }
            }
        }
    }
}
