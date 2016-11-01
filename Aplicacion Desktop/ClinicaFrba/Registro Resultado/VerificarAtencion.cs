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

namespace ClinicaFrba.Registro_Resultado
{
    public partial class VerificarAtencion : Form
    {
        Menu unMenu;
        ABM_usuario_DAO abm_usuario;

        public VerificarAtencion(Menu menu)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            unMenu = menu;
            cargarDatos();
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        public void cargarDatos()
        {
            dateTimePickerAtMed.Format = DateTimePickerFormat.Custom;
            dateTimePickerAtMed.CustomFormat = "dd'/'MM'/'yyyy";
            dateTimePickerAtMed.Text = "05/05/2016";
        }

        private void button_abrirCosulta_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBoxAfiliado.Text)))
            {
                if (!(string.IsNullOrWhiteSpace(dateTimePickerAtMed.Text)))
                {
                    if (!(string.IsNullOrWhiteSpace(dateTimePickerAtMed.Text)))
                    {
                        RegistrarResultado subMenRegistraResult = new RegistrarResultado(this);
                        subMenRegistraResult.Show();
                    }
                }
            }
        }
        


        



       
    }
}
