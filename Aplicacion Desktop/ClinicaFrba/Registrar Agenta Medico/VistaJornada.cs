using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.DataBase.Conexion;
using ClinicaFrba.DataBase.Entidades;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class VistaJornada : Form
    {
        private CalendarProf menuAnterior;
        private Char desc_dia;

        public VistaJornada(CalendarProf vistaPrevia, Char dia)
        {
            InitializeComponent();
            menuAnterior = vistaPrevia;
            desc_dia = dia;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            menuAnterior.Show();
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            errorHI.Clear(); errorHF.Clear();
            switch (validarHorarios())
            {
                case 1:
                    errorHI.SetError(textBox1, "HORARIO INVALIDO");
                    break;
                case 2:
                    errorHF.SetError(textBox3, "HORARIO INVALIDO");
                    break;
                case 3:
                    errorHI.SetError(textBox1, "HORARIO INVALIDO");
                    errorHF.SetError(textBox3, "HORARIO INVALIDO");
                    break;
                case 4:
                    errorHI.SetError(textBox1, "FRANJA HORARIA INVALIDA");
                    errorHF.SetError(textBox3, "FRANJA HORARIA INVALIDA");
                    break;
                default:
                    crearDiaLaboral();
                    break;
            }
        }

        private int validarHorarios()
        {
            
            int flag = 0;
            if (!ConstantesBD.horarioInicio(
                Int32.Parse(textBox1.Text),
                Int32.Parse(textBox2.Text),
                desc_dia))
            {
                flag++;
            }
            if (!ConstantesBD.horarioFin(
                Int32.Parse(textBox3.Text),
                Int32.Parse(textBox4.Text),
                desc_dia))
            {
                flag = flag + 2;
            }
            if (flag == 0)
            {
                if (Int32.Parse(textBox1.Text + textBox2.Text) >= Int32.Parse(textBox3.Text + textBox4.Text))
                {
                    flag = 4;
                }
            }
            return flag;
        }
        private void crearDiaLaboral()
        {
            DiaLaboral dia = new DiaLaboral(desc_dia,textBox1.Text,
                                            textBox2.Text,textBox3.Text,
                                            textBox4.Text);
            menuAnterior.regresar((Object) dia);
            this.Close();
        }
    }
}
